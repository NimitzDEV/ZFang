﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.wbOperator = New System.Windows.Forms.WebBrowser()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbNext = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnAction = New System.Windows.Forms.Button()
        Me.tmrTicker = New System.Windows.Forms.Timer(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbRnd = New System.Windows.Forms.RadioButton()
        Me.rbNormal = New System.Windows.Forms.RadioButton()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.pnlContain = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbUserName = New System.Windows.Forms.Label()
        Me.lbUserNumber = New System.Windows.Forms.Label()
        Me.lbCanDo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnlContain.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'wbOperator
        '
        Me.wbOperator.Location = New System.Drawing.Point(250, 67)
        Me.wbOperator.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbOperator.Name = "wbOperator"
        Me.wbOperator.Size = New System.Drawing.Size(459, 201)
        Me.wbOperator.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnStop)
        Me.GroupBox1.Controls.Add(Me.btnAction)
        Me.GroupBox1.Controls.Add(Me.lbNext)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbStatus)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(3, 201)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 129)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "操作区"
        '
        'lbNext
        '
        Me.lbNext.AutoSize = True
        Me.lbNext.Location = New System.Drawing.Point(4, 114)
        Me.lbNext.Name = "lbNext"
        Me.lbNext.Size = New System.Drawing.Size(35, 12)
        Me.lbNext.TabIndex = 4
        Me.lbNext.Text = "Ready"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(4, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 48)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "自动评教过程中你可以最小化本程序" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "但是不要点击右边的内容" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "以免发生元素检测错误~" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "所有课程评教完之后将会自动提交"
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = True
        Me.lbStatus.Location = New System.Drawing.Point(4, 102)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(35, 12)
        Me.lbStatus.TabIndex = 2
        Me.lbStatus.Text = "Ready"
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(113, 17)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(96, 23)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "停止自动评教"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnAction
        '
        Me.btnAction.Location = New System.Drawing.Point(6, 17)
        Me.btnAction.Name = "btnAction"
        Me.btnAction.Size = New System.Drawing.Size(96, 23)
        Me.btnAction.TabIndex = 0
        Me.btnAction.Text = "开始自动评教"
        Me.btnAction.UseVisualStyleBackColor = True
        '
        'tmrTicker
        '
        Me.tmrTicker.Interval = 500
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(6, 76)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(125, 12)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Powered by NimitzDEV"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbRnd)
        Me.GroupBox2.Controls.Add(Me.rbNormal)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 336)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 99)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "评教模式"
        '
        'rbRnd
        '
        Me.rbRnd.AutoSize = True
        Me.rbRnd.Location = New System.Drawing.Point(6, 54)
        Me.rbRnd.Name = "rbRnd"
        Me.rbRnd.Size = New System.Drawing.Size(155, 28)
        Me.rbRnd.TabIndex = 1
        Me.rbRnd.Text = "随机模式" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "（优秀和良好之间随机）"
        Me.rbRnd.UseVisualStyleBackColor = True
        '
        'rbNormal
        '
        Me.rbNormal.AutoSize = True
        Me.rbNormal.Checked = True
        Me.rbNormal.Location = New System.Drawing.Point(6, 20)
        Me.rbNormal.Name = "rbNormal"
        Me.rbNormal.Size = New System.Drawing.Size(191, 28)
        Me.rbNormal.TabIndex = 0
        Me.rbNormal.TabStop = True
        Me.rbNormal.Text = "普通模式" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "（第一项目为良好，其他优秀）"
        Me.rbNormal.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(137, 76)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(29, 12)
        Me.LinkLabel2.TabIndex = 5
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "知乎"
        '
        'pnlContain
        '
        Me.pnlContain.AutoScroll = True
        Me.pnlContain.Controls.Add(Me.GroupBox4)
        Me.pnlContain.Controls.Add(Me.GroupBox3)
        Me.pnlContain.Controls.Add(Me.GroupBox2)
        Me.pnlContain.Controls.Add(Me.GroupBox1)
        Me.pnlContain.Location = New System.Drawing.Point(0, 0)
        Me.pnlContain.Name = "pnlContain"
        Me.pnlContain.Size = New System.Drawing.Size(234, 507)
        Me.pnlContain.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.LinkLabel2)
        Me.GroupBox3.Controls.Add(Me.LinkLabel1)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(223, 100)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "操作说明"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 48)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "操作说明：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1.登录进入教务系统" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2.选择""教学质量评价"" 的第一个课程" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3.点击""开始自动评教"""
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbCanDo)
        Me.GroupBox4.Controls.Add(Me.lbUserNumber)
        Me.GroupBox4.Controls.Add(Me.lbUserName)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 109)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(223, 86)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "登录信息"
        '
        'lbUserName
        '
        Me.lbUserName.AutoSize = True
        Me.lbUserName.Location = New System.Drawing.Point(9, 17)
        Me.lbUserName.Name = "lbUserName"
        Me.lbUserName.Size = New System.Drawing.Size(29, 12)
        Me.lbUserName.TabIndex = 0
        Me.lbUserName.Text = "姓名"
        '
        'lbUserNumber
        '
        Me.lbUserNumber.AutoSize = True
        Me.lbUserNumber.Location = New System.Drawing.Point(9, 39)
        Me.lbUserNumber.Name = "lbUserNumber"
        Me.lbUserNumber.Size = New System.Drawing.Size(29, 12)
        Me.lbUserNumber.TabIndex = 1
        Me.lbUserNumber.Text = "学号"
        '
        'lbCanDo
        '
        Me.lbCanDo.AutoSize = True
        Me.lbCanDo.Location = New System.Drawing.Point(9, 62)
        Me.lbCanDo.Name = "lbCanDo"
        Me.lbCanDo.Size = New System.Drawing.Size(29, 12)
        Me.lbCanDo.TabIndex = 2
        Me.lbCanDo.Text = "状态"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 554)
        Me.Controls.Add(Me.pnlContain)
        Me.Controls.Add(Me.wbOperator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pnlContain.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents wbOperator As System.Windows.Forms.WebBrowser
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAction As System.Windows.Forms.Button
    Friend WithEvents tmrTicker As System.Windows.Forms.Timer
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents lbStatus As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbNext As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbRnd As System.Windows.Forms.RadioButton
    Friend WithEvents rbNormal As System.Windows.Forms.RadioButton
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents pnlContain As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lbCanDo As System.Windows.Forms.Label
    Friend WithEvents lbUserNumber As System.Windows.Forms.Label
    Friend WithEvents lbUserName As System.Windows.Forms.Label

End Class
