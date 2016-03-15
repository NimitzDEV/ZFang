Public Class frmAvgCalc

    Public normalCourseCount As Integer = 0
    Public normalXFCount As Double = 0
    Public normalCJCount As Integer = 0
    Public normalJDCount As Double = 0
    Public normalX As Double = 0
    Public specCourseCount As Integer = 0
    Public specXFCount As Double = 0
    Public specCJCount As Integer = 0
    Public specJDCount As Double = 0
    Public specX As Double = 0

    Public normalFinal As Double = 0
    Public specFinal As Double = 0

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub frmAvgCalc_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        lbStatus.Text = "正在运行，请稍等..."
        Form1.performAvg()
        Form1.clickInputDlg("历年成绩")
        FlatButton2.Visible = False
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Me.Close()
        Form1.callAvgFormFunction = False
        Form1.callAvgFormFunctionInner = False
    End Sub

    Public Sub performAvgClacMain()
        Dim tmp As Double = 0
        Try
            Dim webTxt As HtmlDocument = Form1.wbOperator.Document.Window.Frames("iframeautoheight").Document
            If webTxt.Body.InnerText.Contains("在校学习成绩") Then
                lbStatus.Text = "计算中..."
                Dim tableEle As HtmlElementCollection = webTxt.GetElementById("Datagrid1").GetElementsByTagName("tr")
                For i = 1 To tableEle.Count - 1
                    If tableEle(i).GetAttribute("class") <> "datelisthead" Then
                        Dim tdEle As HtmlElementCollection = tableEle(i).GetElementsByTagName("td")
                        normalCourseCount += 1
                        normalXFCount += tdEle(6).InnerText
                        normalJDCount += tdEle(7).InnerText
                        If tdEle(11).InnerText.Trim = "" And tdEle(10).InnerText.Trim = "" Then
                            tmp = txtTable(tdEle(8).InnerText)
                        Else
                            If (tdEle(11).InnerText.Trim = "") Then
                                tmp = txtTable(tdEle(10).InnerText)
                            Else
                                tmp = txtTable(tdEle(11).InnerText)
                            End If
                        End If
                        normalCJCount += tmp
                        normalX += tmp * tdEle(6).InnerText
                        If (tdEle(4).InnerText <> "公共选修课") Then
                            specCourseCount += 1
                            specXFCount += tdEle(6).InnerText
                            specJDCount += tdEle(7).InnerText
                            If tdEle(11).InnerText.Trim = "" And tdEle(10).InnerText.Trim = "" Then
                                tmp = txtTable(tdEle(8).InnerText)
                            Else
                                If (tdEle(11).InnerText.Trim = "") Then
                                    tmp = txtTable(tdEle(10).InnerText)
                                Else
                                    tmp = txtTable(tdEle(11).InnerText)
                                End If
                            End If
                            specCJCount += tmp
                            specX += tmp * tdEle(6).InnerText
                        End If
                    End If
                    updateMe()
                    Application.DoEvents()
                Next
                calcResult()
            Else
                lbStatus.Text = "正在等待表单载入..."
            End If
        Catch ex As Exception
            MsgBox("ERR，计算过程发生未知情况，请联系软件作者")
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub updateMe()
        lbResult.Text = "普通统计：" & vbCrLf & "课程数量" & normalCourseCount & " / 学分总和" & normalXFCount & " / 成绩总和" & normalCJCount & " / 绩点总和" & normalJDCount
        lbResult.Text &= vbCrLf & "加权分总和：" & normalX & " / 加权平均分：" & normalFinal
        lbResult.Text &= vbCrLf & vbCrLf
        lbResult.Text &= "排除公共选修课：" & vbCrLf & "课程数量" & specCourseCount & " / 学分总和" & specXFCount & " / 成绩总和" & specCJCount & " / 绩点总和" & specJDCount
        lbResult.Text &= vbCrLf & "加权分总和：" & specX & " / 加权平均分：" & specFinal
    End Sub

    Public Sub calcResult()
        normalFinal = normalX / normalXFCount
        specFinal = specX / specXFCount
        updateMe()
        lbStatus.Text = "计算完毕"
    End Sub

    Private Function txtTable(ByVal cat As String) As Integer
        Select Case cat
            Case "优秀"
                Return 95
            Case "良好"
                Return 85
            Case "中等"
                Return 75
            Case "合格"
                Return 65
            Case "及格"
                Return 65
            Case "不合格"
                Return 40
            Case "不及格"
                Return 40
            Case Else
                Return cat
        End Select

    End Function
End Class