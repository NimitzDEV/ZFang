<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.wbOperator = New System.Windows.Forms.WebBrowser()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnAction = New System.Windows.Forms.Button()
        Me.lbNext = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tmrTicker = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbCommons = New System.Windows.Forms.CheckBox()
        Me.rbRnd = New System.Windows.Forms.RadioButton()
        Me.rbNormal = New System.Windows.Forms.RadioButton()
        Me.pnlContain = New System.Windows.Forms.Panel()
        Me.btnOneClickLogin = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbCanDo = New System.Windows.Forms.Label()
        Me.lbUserNumber = New System.Windows.Forms.Label()
        Me.lbUserName = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlProgress = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.abInfo = New 正方评教全自动挂.FlatAlertBox()
        Me.pbBrowser = New 正方评教全自动挂.FlatProgressBar()
        Me.btnAvg = New 正方评教全自动挂.FlatButton()
        Me.btnLoginOthers = New 正方评教全自动挂.FlatButton()
        Me.btnRefresh = New 正方评教全自动挂.FlatButton()
        Me.fbChange = New 正方评教全自动挂.FlatButton()
        Me.btnAbout = New 正方评教全自动挂.FlatButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnlContain.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.pnlProgress.SuspendLayout()
        Me.SuspendLayout()
        '
        'wbOperator
        '
        Me.wbOperator.IsWebBrowserContextMenuEnabled = False
        Me.wbOperator.Location = New System.Drawing.Point(2, 40)
        Me.wbOperator.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbOperator.Name = "wbOperator"
        Me.wbOperator.ScriptErrorsSuppressed = True
        Me.wbOperator.Size = New System.Drawing.Size(459, 201)
        Me.wbOperator.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnStop)
        Me.GroupBox1.Controls.Add(Me.btnAction)
        Me.GroupBox1.Controls.Add(Me.lbNext)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(4, 528)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 94)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "操作区"
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
        'lbNext
        '
        Me.lbNext.AutoSize = True
        Me.lbNext.Location = New System.Drawing.Point(6, 72)
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
        Me.Label2.Size = New System.Drawing.Size(213, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "自动评教过程中你可以最小化本程序" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "所有课程评教完之后将会自动提交"
        '
        'tmrTicker
        '
        Me.tmrTicker.Interval = 500
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbCommons)
        Me.GroupBox2.Controls.Add(Me.rbRnd)
        Me.GroupBox2.Controls.Add(Me.rbNormal)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 411)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 111)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "评教模式"
        '
        'cbCommons
        '
        Me.cbCommons.AutoCheck = False
        Me.cbCommons.AutoSize = True
        Me.cbCommons.Location = New System.Drawing.Point(6, 88)
        Me.cbCommons.Name = "cbCommons"
        Me.cbCommons.Size = New System.Drawing.Size(120, 16)
        Me.cbCommons.TabIndex = 10
        Me.cbCommons.Text = "同时自动填写评论"
        Me.cbCommons.UseVisualStyleBackColor = True
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
        'pnlContain
        '
        Me.pnlContain.AutoScroll = True
        Me.pnlContain.Controls.Add(Me.btnAvg)
        Me.pnlContain.Controls.Add(Me.btnLoginOthers)
        Me.pnlContain.Controls.Add(Me.btnRefresh)
        Me.pnlContain.Controls.Add(Me.fbChange)
        Me.pnlContain.Controls.Add(Me.GroupBox1)
        Me.pnlContain.Controls.Add(Me.btnOneClickLogin)
        Me.pnlContain.Controls.Add(Me.GroupBox4)
        Me.pnlContain.Controls.Add(Me.GroupBox3)
        Me.pnlContain.Controls.Add(Me.GroupBox2)
        Me.pnlContain.Location = New System.Drawing.Point(454, 2)
        Me.pnlContain.Name = "pnlContain"
        Me.pnlContain.Size = New System.Drawing.Size(233, 680)
        Me.pnlContain.TabIndex = 5
        '
        'btnOneClickLogin
        '
        Me.btnOneClickLogin.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnOneClickLogin.Enabled = False
        Me.btnOneClickLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOneClickLogin.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnOneClickLogin.ForeColor = System.Drawing.Color.White
        Me.btnOneClickLogin.Location = New System.Drawing.Point(3, 3)
        Me.btnOneClickLogin.Name = "btnOneClickLogin"
        Me.btnOneClickLogin.Size = New System.Drawing.Size(227, 62)
        Me.btnOneClickLogin.TabIndex = 6
        Me.btnOneClickLogin.Text = "一键评教"
        Me.btnOneClickLogin.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbCanDo)
        Me.GroupBox4.Controls.Add(Me.lbUserNumber)
        Me.GroupBox4.Controls.Add(Me.lbUserName)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 319)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(223, 86)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "登录信息"
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
        'lbUserNumber
        '
        Me.lbUserNumber.AutoSize = True
        Me.lbUserNumber.Location = New System.Drawing.Point(9, 39)
        Me.lbUserNumber.Name = "lbUserNumber"
        Me.lbUserNumber.Size = New System.Drawing.Size(29, 12)
        Me.lbUserNumber.TabIndex = 1
        Me.lbUserNumber.Text = "学号"
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnAbout)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 140)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(223, 173)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "操作说明"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 131)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "该版本中，你可以使用全自动模式或者半自动模式" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "->全自动模式" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1.点击""一键评教""按钮即可，如果你没有设置账号密码，则需要先设置" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2.随后的评教过程将会全部" &
    "自动" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "->半自动模式" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1.即自己在左侧的网页中自行登陆" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2.登陆之后请手动进入评教页面" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3.点击""开始自动评教""按钮即可完成"
        '
        'pnlProgress
        '
        Me.pnlProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.pnlProgress.Controls.Add(Me.Label3)
        Me.pnlProgress.Controls.Add(Me.pbBrowser)
        Me.pnlProgress.Location = New System.Drawing.Point(2, 247)
        Me.pnlProgress.Name = "pnlProgress"
        Me.pnlProgress.Size = New System.Drawing.Size(427, 50)
        Me.pnlProgress.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "加载中"
        '
        'abInfo
        '
        Me.abInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.abInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.abInfo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.abInfo.kind = 正方评教全自动挂.FlatAlertBox._Kind.Success
        Me.abInfo.Location = New System.Drawing.Point(2, 323)
        Me.abInfo.Name = "abInfo"
        Me.abInfo.Size = New System.Drawing.Size(427, 42)
        Me.abInfo.TabIndex = 9
        Me.abInfo.Text = "提示信息"
        Me.abInfo.Visible = False
        '
        'pbBrowser
        '
        Me.pbBrowser.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.pbBrowser.DarkerProgress = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.pbBrowser.Location = New System.Drawing.Point(79, 3)
        Me.pbBrowser.Maximum = 100
        Me.pbBrowser.Name = "pbBrowser"
        Me.pbBrowser.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.pbBrowser.Size = New System.Drawing.Size(345, 42)
        Me.pbBrowser.TabIndex = 6
        Me.pbBrowser.Text = "页面加载中..."
        Me.pbBrowser.Value = 100
        '
        'btnAvg
        '
        Me.btnAvg.BackColor = System.Drawing.Color.Transparent
        Me.btnAvg.BaseColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnAvg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAvg.Enabled = False
        Me.btnAvg.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnAvg.Location = New System.Drawing.Point(90, 102)
        Me.btnAvg.Name = "btnAvg"
        Me.btnAvg.Rounded = False
        Me.btnAvg.Size = New System.Drawing.Size(140, 32)
        Me.btnAvg.TabIndex = 9
        Me.btnAvg.Text = "计算加权平均分"
        Me.btnAvg.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnLoginOthers
        '
        Me.btnLoginOthers.BackColor = System.Drawing.Color.Transparent
        Me.btnLoginOthers.BaseColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnLoginOthers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoginOthers.Enabled = False
        Me.btnLoginOthers.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.btnLoginOthers.Location = New System.Drawing.Point(90, 65)
        Me.btnLoginOthers.Name = "btnLoginOthers"
        Me.btnLoginOthers.Rounded = False
        Me.btnLoginOthers.Size = New System.Drawing.Size(140, 32)
        Me.btnLoginOthers.TabIndex = 8
        Me.btnLoginOthers.Text = "一键评教（他人账号）"
        Me.btnLoginOthers.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnRefresh.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnRefresh.Location = New System.Drawing.Point(4, 628)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Rounded = False
        Me.btnRefresh.Size = New System.Drawing.Size(224, 32)
        Me.btnRefresh.TabIndex = 0
        Me.btnRefresh.Text = "刷新页面"
        Me.btnRefresh.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'fbChange
        '
        Me.fbChange.BackColor = System.Drawing.Color.Transparent
        Me.fbChange.BaseColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.fbChange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fbChange.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.fbChange.Location = New System.Drawing.Point(4, 65)
        Me.fbChange.Name = "fbChange"
        Me.fbChange.Rounded = False
        Me.fbChange.Size = New System.Drawing.Size(84, 32)
        Me.fbChange.TabIndex = 7
        Me.fbChange.Text = "修改登陆信息"
        Me.fbChange.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.Transparent
        Me.btnAbout.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(112, 142)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Rounded = False
        Me.btnAbout.Size = New System.Drawing.Size(106, 25)
        Me.btnAbout.TabIndex = 4
        Me.btnAbout.Text = "关于本程序"
        Me.btnAbout.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 748)
        Me.Controls.Add(Me.abInfo)
        Me.Controls.Add(Me.pnlProgress)
        Me.Controls.Add(Me.pnlContain)
        Me.Controls.Add(Me.wbOperator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pnlContain.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.pnlProgress.ResumeLayout(False)
        Me.pnlProgress.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents wbOperator As System.Windows.Forms.WebBrowser
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAction As System.Windows.Forms.Button
    Friend WithEvents tmrTicker As System.Windows.Forms.Timer
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbRnd As System.Windows.Forms.RadioButton
    Friend WithEvents rbNormal As System.Windows.Forms.RadioButton
    Friend WithEvents pnlContain As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lbCanDo As System.Windows.Forms.Label
    Friend WithEvents lbUserNumber As System.Windows.Forms.Label
    Friend WithEvents lbUserName As System.Windows.Forms.Label
    Friend WithEvents btnOneClickLogin As Button
    Friend WithEvents lbNext As Label
    Friend WithEvents btnRefresh As FlatButton
    Friend WithEvents pbBrowser As FlatProgressBar
    Friend WithEvents pnlProgress As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents fbChange As FlatButton
    Friend WithEvents btnLoginOthers As FlatButton
    Friend WithEvents abInfo As FlatAlertBox
    Friend WithEvents cbCommons As CheckBox
    Friend WithEvents btnAbout As FlatButton
    Friend WithEvents btnAvg As FlatButton
End Class
