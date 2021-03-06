﻿Imports System.Text.RegularExpressions
Public Class Form1
    Dim opStep As Integer = 0
    Public actionStarted As Boolean = False
    Dim r As New Random
    Public userName As String
    Public userNumber As String
    Public autoMode As Boolean = False
    Public goSteps As Integer = 0

    Public callInputClicker As Boolean = False
    Public callInputClickerText As String = ""

    Public callAvgFormFunction As Boolean = False
    Public callAvgFormFunctionInner As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AccountProvider.SwitchModeToDf()
        wbOperator.Navigate("http://jw.bwgl.cn")
        ReadSettings()
        Me.Text = Application.ProductName & " - " & Application.ProductVersion
        If AccountProvider.GetUserName = "" Or AccountProvider.GetUserPass = "" Then
            frmSetUserName.ShowDialog(Me)
            frmSetUserName.Dispose()
        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbOperator.DocumentCompleted
        If wbOperator.ReadyState <> WebBrowserReadyState.Complete Then Exit Sub
        If getRightText(wbOperator).Contains("欢迎您") Then
            Try
                getUserInfo(True, False)
                Dim auth As HtmlDocument = wbOperator.Document.Window.Frames("iframeautoheight").Document
                If auth.Body.InnerText.Contains("评价课程名称") Then
                    getUserInfo(True, True)
                Else
                    'If btnStop.Enabled = True Then
                    '    btnStop.PerformClick()
                    'End If
                    triggerStop(False, 0, True, False)
                End If
            Catch ex As Exception

            End Try
        Else
            autoMode = False
            getUserInfo(False, False)
            showInfo("没有登陆", FlatAlertBox._Kind.Info)
            Exit Sub
        End If
    End Sub

    Private Sub getUserInfo(ByVal loginStatus As Boolean, ByVal canDo As Boolean)
        If loginStatus = True Then
            userName = (Regex.Replace(wbOperator.Document.GetElementById("xhxm").InnerText, "\d", "", RegexOptions.IgnoreCase).Trim().Replace("同学", ""))
            userNumber = wbOperator.Document.GetElementById("xhxm").InnerText.Replace("同学", "").Replace(userName, "")
            lbUserName.Text = "姓名：" & userName
            lbUserNumber.Text = "学号：" & userNumber
            btnAvg.Enabled = True
            If canDo = True Then
                If Not autoMode Then showInfo("（非全自动模式）现在请点击开始按钮进行评教", FlatAlertBox._Kind.Info)
                GroupBox1.Enabled = True
                lbCanDo.Text = "可以开始自动评教"
                If autoMode And goSteps = 2 Then
                    btnAction.PerformClick()
                End If
                If Not autoMode Then goSteps = 2
            Else
                If Not autoMode Then showInfo("（非全自动模式）现在请点击第一个需要评教的课程", FlatAlertBox._Kind.Info)
                If btnStop.Enabled = True And Not actionStarted Then
                    btnStop.PerformClick()
                End If
                GroupBox1.Enabled = False
                lbCanDo.Text = "已登录但是未进入评教页面"
                If autoMode And goSteps = 1 Then
                    goIntoFirstCourse()
                End If
                If Not autoMode Then goSteps = 1
            End If
            If callInputClicker Then
                callInputClicker = False
                clickInputByText(callInputClickerText)
            End If
            If callAvgFormFunction Then
                frmAvgCalc.performAvgClacMain()
            End If
        Else
            btnAvg.Enabled = False
            lbUserName.Text = "姓名：（未登录）"
            lbUserNumber.Text = "学号：（未登录）"
            lbCanDo.Text = "（未登录）"
            triggerStop(True, 0, True, True)
            'If btnStop.Enabled = True Then btnStop.PerformClick()
            GroupBox1.Enabled = False
            'btnOneClickLogin.Enabled = True
            'goSteps = 0
            'autoMode = False
        End If
    End Sub

    Public Function getRightText(ByVal wb As WebBrowser) As String
        Dim reader As New System.IO.StreamReader(wb.DocumentStream, System.Text.Encoding.GetEncoding(wb.Document.Encoding))
        Return reader.ReadToEnd
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAction.Click
        btnAction.Enabled = False
        btnStop.Enabled = True
        tmrTicker.Enabled = True
        btnOneClickLogin.Enabled = False
        btnLoginOthers.Enabled = False
        'performAction()
        actionStarted = True
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width < 800 Then Me.Width = 800
        If Me.Height < 800 Then Me.Height = 800
        pnlContain.Height = Me.ClientRectangle.Height
        wbOperator.Height = Me.ClientRectangle.Height
        wbOperator.Width = Me.ClientRectangle.Width - pnlContain.Width
        pnlContain.Top = 0
        pnlContain.Left = Me.ClientRectangle.Width - pnlContain.Width
        wbOperator.Left = 0
        wbOperator.Top = 0
        pnlProgress.Left = (wbOperator.Width - pnlProgress.Width) / 2
        pnlProgress.Top = Me.ClientRectangle.Height - pnlProgress.Height - 20
        abInfo.Left = pnlProgress.Left
        abInfo.Top = pnlProgress.Top - abInfo.Height - 5
    End Sub

    Private Sub tmrTicker_Tick(sender As Object, e As EventArgs) Handles tmrTicker.Tick
        performAction()
    End Sub
    '处理评教
    Private Sub performAction()
        Try
            Dim counter As Integer = 0
            Dim a As HtmlDocument = wbOperator.Document.Window.Frames("iframeautoheight").Document
            Dim b As HtmlElementCollection = a.GetElementsByTagName("select")
            Dim authSubmit As HtmlElement = a.GetElementById("Button2")
            For Each c As HtmlElement In b
                If c.InnerText.Contains("不及格") Then
                    counter += 1
                    c.SetAttribute("value", getValue(counter))
                Else
                    Me.Text = Application.ProductName & " - " & Application.ProductVersion & " - [正在评教课程ID：" & c.GetAttribute("value") & "]"
                End If
            Next
            If cbCommons.Checked Then
                a.GetElementById("pjxx").SetAttribute("value", CommonsProvider.getCommon)
            End If
            Dim d As HtmlElement = a.GetElementById("Button1")
            lbNext.Text = "等待中：" & d.GetAttribute("value")
            d.InvokeMember("click")
            If authSubmit.GetAttribute("value").Contains("先完成评价") = False Then
                authSubmit.InvokeMember("click")
                tmrTicker.Enabled = False
                btnAction.Enabled = True
                btnStop.Enabled = False
                lbNext.Text = "Ready"
                actionStarted = False
                Me.Text = Application.ProductName & " - " & Application.ProductVersion
                MsgBox("评教已经完成！")
                clickElementByText("安全退出")
            End If
        Catch ex As Exception
            GroupBox1.Enabled = True
            clickElementByText("安全退出")
        End Try
    End Sub
    '加权平均分计算
    Public Sub performAvg()
        Try
            clickElementByText("成绩查询")
        Catch ex As Exception

        End Try
    End Sub
    '获取评分
    Private Function getValue(ByVal counter As Integer) As String
        If rbNormal.Checked = True Then
            If counter = 1 Then
                Return ("良好")
            Else
                Return ("优秀")
            End If
        End If
        If rbRnd.Checked = True Then
            Dim a As Integer
            a = r.Next(2)
            Debug.Print(a)
            If a = 0 Then Return "优秀"
            If a = 1 Then Return "良好"
            Debug.Print(a)
        End If
    End Function

    '插入脚本
    Private Sub wbOperator_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles wbOperator.ProgressChanged
        Try
            pnlProgress.Visible = True
            If wbOperator.ReadyState = WebBrowserReadyState.Complete Then
                pnlProgress.Visible = False
                Dim DomDocument As mshtml.IHTMLDocument2 = wbOperator.Document.Window.Frames("iframeautoheight").Document.DomDocument
                DomDocument.parentWindow.execScript("function confirm(s){return 1;} ", "javaScript")
                DomDocument.parentWindow.execScript("function alert(s){return true;} ", "javaScript")
            End If
            pbBrowser.Value = e.CurrentProgress / e.MaximumProgress * 100
        Catch
            pbBrowser.Value = 100
        End Try
    End Sub


    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        actionStarted = False
        tmrTicker.Enabled = False
        autoMode = False
        btnOneClickLogin.Enabled = True
        btnLoginOthers.Enabled = True
        goSteps = 1
        btnAction.Enabled = True
        btnStop.Enabled = False
        lbNext.Text = "Ready"
        Me.Text = Application.ProductName & " - " & Application.ProductVersion
        MsgBox("评教已停止！")
    End Sub


    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SaveSettings()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnOneClickLogin.Click
        AccountProvider.SwitchModeToDf()
        If AccountProvider.GetUserPass = "" Or AccountProvider.GetUserName = "" Then
            frmSetUserName.ShowDialog(Me)
            frmSetUserName.Dispose()
            If AccountProvider.GetUserPass = "" Or AccountProvider.GetUserName = "" Then
                Exit Sub
            End If
            btnOneClickLogin.PerformClick()
        Else
            automaticSubmit()
        End If
    End Sub
    '全自动化处理过程
    Private Sub automaticSubmit()
        btnOneClickLogin.Enabled = False
        btnLoginOthers.Enabled = False
        autoMode = True
        If goSteps <> 0 Then
            Select Case goSteps
                Case 1
                    goIntoFirstCourse()
                Case 2
                    btnAction.PerformClick()
            End Select
            Exit Sub
        End If
        loginInto()
    End Sub
    'LOGIN
    Private Sub loginInto()
        goSteps = 1
        Try
            With wbOperator
                .Document.GetElementById("TextBox1").SetAttribute("value", AccountProvider.GetUserName)
                .Document.GetElementById("TextBox2").SetAttribute("value", AccountProvider.GetUserPass)
                .Document.GetElementById("Button1").InvokeMember("click")
            End With
        Catch
            MsgBox("登陆步骤出现问题")
            triggerStop(True, 0, True, True)
        End Try
    End Sub

    Private Sub goIntoFirstCourse()
        goSteps = 2
        With wbOperator
            Dim allATags As HtmlElementCollection
            Dim targetingLink As HtmlElement
            allATags = .Document.GetElementsByTagName("a")
            For i = 0 To allATags.Count - 1
                Try
                    Debug.Print(allATags(i).InnerText)
                    If allATags(i).InnerText.Contains("教学质量评价") Then
                        targetingLink = allATags(i + 1)
                        Exit For
                    End If
                Catch
                End Try
            Next
            If targetingLink.InnerText <> "信息维护" Then
                targetingLink.InvokeMember("click")
            Else
                MsgBox("评教已经完成")
            End If
        End With
    End Sub
    'common trigger
    '''<summary>
    '''操作一键评教按钮
    '''</summary>
    '''<param name="isCoverGosteps">是否覆盖当前步骤</param>
    ''' <param name="goStepsI">覆盖的值</param>
    ''' <param name="btnState">按钮状态</param>
    ''' <param name="resetAm">是否重置自动模式标志</param>
    '''<remarks></remarks>
    Private Sub triggerStop(ByVal isCoverGosteps As Boolean, ByVal goStepsI As Integer, ByVal btnState As Boolean, ByVal resetAm As Boolean)
        actionStarted = False
        If btnStop.Enabled = True Then
            btnStop.PerformClick()
        End If
        If isCoverGosteps Then goSteps = goStepsI
        btnOneClickLogin.Enabled = btnState
        btnLoginOthers.Enabled = btnState
        If resetAm Then autoMode = False
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        wbOperator.Refresh(WebBrowserRefreshOption.Completely)
    End Sub

    Private Sub clickElementByText(ByVal btnText As String, Optional ByVal clickOffset As Integer = 0)
        Dim allATags As HtmlElementCollection
        allATags = wbOperator.Document.GetElementsByTagName("a")
        For i = 0 To allATags.Count - 1
            If allATags(i).InnerText = btnText Then
                allATags(i + clickOffset).InvokeMember("click")
                Exit For
            End If
        Next
    End Sub

    Public Sub clickInputDlg(ByVal txt As String)
        callInputClickerText = txt
        callInputClicker = True
    End Sub

    Public Sub clickInputByText(ByVal txt As String)
        Dim allInput As HtmlElementCollection
        allInput = wbOperator.Document.Window.Frames("iframeautoheight").Document.GetElementsByTagName("input")
        For i = 0 To allInput.Count - 1
            Debug.Print(allInput(i).GetAttribute("value"))
            If allInput(i).GetAttribute("value") = txt Then
                allInput(i).InvokeMember("click")
            End If
        Next
    End Sub

    Private Sub fbChange_Click(sender As Object, e As EventArgs) Handles fbChange.Click
        AccountProvider.SwitchModeToDf()
        frmSetUserName.ShowDialog(Me)
        frmSetUserName.Dispose()
    End Sub

    Private Sub btnLoginOthers_Click(sender As Object, e As EventArgs) Handles btnLoginOthers.Click
        AccountProvider.SwitchModeToOt()
        frmSetUserName.ShowDialog(Me)
        frmSetUserName.Dispose()
        If AccountProvider.GetUserPass = "" Or AccountProvider.GetUserName = "" Then
            MsgBox("由于账号密码不完整，所以评教未开始")
            Exit Sub
        End If
        automaticSubmit()
    End Sub
    '系统提示信息
    Private Sub showInfo(ByVal info As String, ByVal kind As FlatAlertBox._Kind)
        abInfo.ShowControl(kind, info, 5000)
    End Sub

    Private Sub cbCommons_Click(sender As Object, e As EventArgs) Handles cbCommons.Click
        cbCommons.Text = "同时自动填写评论"
        If cbCommons.Checked Then
            cbCommons.Checked = False
            Exit Sub
        End If
        cbCommons.Checked = CommonsProvider.canBeUsed
        If cbCommons.Checked Then
            cbCommons.Text = "同时自动填写评论（随机" & CommonsProvider.loadCommons & "条）"
        End If
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        frmAbout.ShowDialog(Me)
        frmAbout.Dispose()
    End Sub

    Private Sub btnAvg_Click(sender As Object, e As EventArgs) Handles btnAvg.Click
        callAvgFormFunction = True
        frmAvgCalc.ShowDialog(Me)
        frmAvgCalc.Dispose()
    End Sub
End Class