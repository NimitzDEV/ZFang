﻿Imports System.Text.RegularExpressions
Public Class Form1
    Dim opStep As Integer = 0
    Public actionStarted As Boolean = False
    Dim r As New Random
    Public userName As String
    Public userNumber As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlContain.Top = 0
        pnlContain.Left = 0
        wbOperator.Navigate("http://jw.bwgl.cn")
        wbOperator.Left = pnlContain.Width
        wbOperator.Top = 0
        Me.Text = Application.ProductName & " - " & Application.ProductVersion
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbOperator.DocumentCompleted
        If getRightText(wbOperator).Contains("欢迎您") Then
            getUserInfo(True, False)
            Dim auth As HtmlDocument = wbOperator.Document.Window.Frames("iframeautoheight").Document
            Try
                If auth.Body.InnerText.Contains("评价课程名称") Then
                    getUserInfo(True, True)
                End If
            Catch ex As Exception
            End Try
        Else
            getUserInfo(False, False)
            Exit Sub
        End If

    End Sub

    Private Sub getUserInfo(ByVal loginStatus As Boolean, ByVal canDo As Boolean)
        If loginStatus = True Then
            userName = (Regex.Replace(wbOperator.Document.GetElementById("xhxm").InnerText, "\d", "", RegexOptions.IgnoreCase).Trim().Replace("同学", ""))
            userNumber = wbOperator.Document.GetElementById("xhxm").InnerText.Replace("同学", "").Replace(userName, "")
            lbUserName.Text = "姓名：" & userName
            lbUserNumber.Text = "学号：" & userNumber
            If canDo = True Then
                lbCanDo.Text = "可以开始自动评教"
            Else
                lbCanDo.Text = "已登录但是未进入评教页面"
            End If
        Else
            lbUserName.Text = "姓名：（未登录）"
            lbUserNumber.Text = "学号：（未登录）"
            lbCanDo.Text = "（未登录）"
        End If
        GroupBox1.Enabled = canDo
    End Sub

    Public Function getRightText(ByVal wb As WebBrowser) As String
        Dim reader As New System.IO.StreamReader(wb.DocumentStream, System.Text.Encoding.GetEncoding(wb.Document.Encoding))
        Return reader.ReadToEnd
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAction.Click
        btnAction.Enabled = False
        btnStop.Enabled = True
        tmrTicker.Enabled = True
        'performAction()
        'actionStarted = True
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        pnlContain.Height = Me.ClientRectangle.Height
        wbOperator.Height = Me.ClientRectangle.Height
        wbOperator.Width = Me.ClientRectangle.Width - pnlContain.Width

    End Sub

    Private Sub tmrTicker_Tick(sender As Object, e As EventArgs) Handles tmrTicker.Tick
        performAction()
    End Sub

    Private Sub performAction()
        Try
            Dim counter As Integer = 0
            Dim a As HtmlDocument = wbOperator.Document.Window.Frames("iframeautoheight").Document
            Dim b As HtmlElementCollection = a.GetElementsByTagName("select")
            Dim authSubmit As HtmlElement = a.GetElementById("Button2")
            For Each c As HtmlElement In b
                If c.InnerText.Contains("不及格") Then
                    counter += 1
                    'If counter = 1 Then
                    c.SetAttribute("value", getValue(counter))
                    'Else
                    '    c.SetAttribute("value", "优秀")
                    'End If
                Else
                    lbStatus.Text = "正在评教课程ID：" & c.GetAttribute("value")
                End If
            Next
            Dim d As HtmlElement = a.GetElementById("Button1")

            lbNext.Text = "等待中：" & d.GetAttribute("value")

            d.InvokeMember("click")
            If authSubmit.GetAttribute("value").Contains("先完成评价") = False Then
                authSubmit.InvokeMember("click")
                tmrTicker.Enabled = False
                btnAction.Enabled = True
                btnStop.Enabled = False
                lbStatus.Text = "Ready"
                lbNext.Text = "Ready"
                MsgBox("评教已经完成！" & "thanks for using~")
            End If
        Catch ex As Exception
        End Try
    End Sub

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

    Private Sub wbOperator_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles wbOperator.ProgressChanged
        If wbOperator.ReadyState = WebBrowserReadyState.Complete Then
            Dim DomDocument As mshtml.IHTMLDocument2 = wbOperator.Document.Window.Frames("iframeautoheight").Document.DomDocument
            DomDocument.parentWindow.execScript("function confirm(s){return 1;} ", "javaScript")
            DomDocument.parentWindow.execScript("function alert(s){return true;} ", "javaScript")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://nimitzdev.org")
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        tmrTicker.Enabled = False
        MsgBox("评教已停止！" & "thanks for using~")
        btnAction.Enabled = True
        btnStop.Enabled = False
        lbStatus.Text = "Ready"
        lbNext.Text = "Ready"
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://zhihu.com/people/nimitzdev")
    End Sub
End Class
