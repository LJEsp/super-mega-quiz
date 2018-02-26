<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pnlManage = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dtgUsers = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.btnManage = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtSignUpVerifyPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSignUpPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSignUpUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.lblLogged = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblScoreEnglish = New System.Windows.Forms.Label()
        Me.btnPlayEnglish = New System.Windows.Forms.Button()
        Me.lblScoreArt = New System.Windows.Forms.Label()
        Me.lblScoreEconomics = New System.Windows.Forms.Label()
        Me.btnPlayArt = New System.Windows.Forms.Button()
        Me.btnPlayEconomics = New System.Windows.Forms.Button()
        Me.lblScoreScience = New System.Windows.Forms.Label()
        Me.btnPlayScience = New System.Windows.Forms.Button()
        Me.lblScoreMath = New System.Windows.Forms.Label()
        Me.btnPlayMath = New System.Windows.Forms.Button()
        Me.pnlGame = New System.Windows.Forms.Panel()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnChoice4 = New System.Windows.Forms.Button()
        Me.btnChoice3 = New System.Windows.Forms.Button()
        Me.btnChoice2 = New System.Windows.Forms.Button()
        Me.btnChoice1 = New System.Windows.Forms.Button()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.pnlEnd = New System.Windows.Forms.Panel()
        Me.btnRetry = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.pnlManage.SuspendLayout()
        CType(Me.dtgUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLogin.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlGame.SuspendLayout()
        Me.pnlEnd.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlManage
        '
        Me.pnlManage.BackgroundImage = Global.SuperMegaQuiz.My.Resources.Resources.quiz
        Me.pnlManage.Controls.Add(Me.btnBack)
        Me.pnlManage.Controls.Add(Me.btnDelete)
        Me.pnlManage.Controls.Add(Me.dtgUsers)
        Me.pnlManage.Controls.Add(Me.Label6)
        Me.pnlManage.Location = New System.Drawing.Point(153, 0)
        Me.pnlManage.Name = "pnlManage"
        Me.pnlManage.Size = New System.Drawing.Size(158, 562)
        Me.pnlManage.TabIndex = 19
        Me.pnlManage.Visible = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.SuperMegaQuiz.My.Resources.Resources.btnBack
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.ForeColor = System.Drawing.Color.Transparent
        Me.btnBack.Location = New System.Drawing.Point(36, 123)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(48, 40)
        Me.btnBack.TabIndex = 16
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BackgroundImage = Global.SuperMegaQuiz.My.Resources.Resources.btnDelete
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.Transparent
        Me.btnDelete.Location = New System.Drawing.Point(522, 195)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(152, 40)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'dtgUsers
        '
        Me.dtgUsers.AllowUserToAddRows = False
        Me.dtgUsers.AllowUserToDeleteRows = False
        Me.dtgUsers.AllowUserToResizeColumns = False
        Me.dtgUsers.AllowUserToResizeRows = False
        Me.dtgUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgUsers.BackgroundColor = System.Drawing.Color.White
        Me.dtgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgUsers.Location = New System.Drawing.Point(111, 195)
        Me.dtgUsers.MultiSelect = False
        Me.dtgUsers.Name = "dtgUsers"
        Me.dtgUsers.RowTemplate.Height = 30
        Me.dtgUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dtgUsers.Size = New System.Drawing.Size(405, 312)
        Me.dtgUsers.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(229, 124)
        Me.Label6.MaximumSize = New System.Drawing.Size(700, 500)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(327, 38)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Delete Users"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlLogin
        '
        Me.pnlLogin.BackgroundImage = CType(resources.GetObject("pnlLogin.BackgroundImage"), System.Drawing.Image)
        Me.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlLogin.Controls.Add(Me.btnManage)
        Me.pnlLogin.Controls.Add(Me.GroupBox1)
        Me.pnlLogin.Controls.Add(Me.Panel1)
        Me.pnlLogin.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(147, 562)
        Me.pnlLogin.TabIndex = 14
        '
        'btnManage
        '
        Me.btnManage.BackColor = System.Drawing.Color.Transparent
        Me.btnManage.BackgroundImage = Global.SuperMegaQuiz.My.Resources.Resources.btnManage
        Me.btnManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnManage.FlatAppearance.BorderSize = 0
        Me.btnManage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManage.ForeColor = System.Drawing.Color.Transparent
        Me.btnManage.Location = New System.Drawing.Point(688, 466)
        Me.btnManage.Name = "btnManage"
        Me.btnManage.Size = New System.Drawing.Size(72, 72)
        Me.btnManage.TabIndex = 15
        Me.btnManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnManage.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(916, 362)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnSignUp)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.txtSignUpVerifyPassword)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtSignUpPassword)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtSignUpUsername)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(216, 220)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 287)
        Me.Panel1.TabIndex = 14
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.Transparent
        Me.btnSignUp.BackgroundImage = Global.SuperMegaQuiz.My.Resources.Resources.btnSignUp
        Me.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSignUp.FlatAppearance.BorderSize = 0
        Me.btnSignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignUp.ForeColor = System.Drawing.Color.Transparent
        Me.btnSignUp.Location = New System.Drawing.Point(192, 246)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(152, 40)
        Me.btnSignUp.TabIndex = 7
        Me.btnSignUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BackgroundImage = Global.SuperMegaQuiz.My.Resources.Resources.btnLogin
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.ForeColor = System.Drawing.Color.Transparent
        Me.btnLogin.Location = New System.Drawing.Point(192, 68)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(152, 40)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(51, 5)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(97, 18)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username:"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(154, 2)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(190, 27)
        Me.txtUsername.TabIndex = 1
        '
        'txtSignUpVerifyPassword
        '
        Me.txtSignUpVerifyPassword.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignUpVerifyPassword.Location = New System.Drawing.Point(154, 213)
        Me.txtSignUpVerifyPassword.Name = "txtSignUpVerifyPassword"
        Me.txtSignUpVerifyPassword.Size = New System.Drawing.Size(190, 27)
        Me.txtSignUpVerifyPassword.TabIndex = 6
        Me.txtSignUpVerifyPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(56, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Verify password:"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(154, 35)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(190, 27)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(56, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password:"
        '
        'txtSignUpPassword
        '
        Me.txtSignUpPassword.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignUpPassword.Location = New System.Drawing.Point(154, 180)
        Me.txtSignUpPassword.Name = "txtSignUpPassword"
        Me.txtSignUpPassword.Size = New System.Drawing.Size(190, 27)
        Me.txtSignUpPassword.TabIndex = 5
        Me.txtSignUpPassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(341, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Don't have an account? Create one now!"
        '
        'txtSignUpUsername
        '
        Me.txtSignUpUsername.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignUpUsername.Location = New System.Drawing.Point(154, 147)
        Me.txtSignUpUsername.Name = "txtSignUpUsername"
        Me.txtSignUpUsername.Size = New System.Drawing.Size(190, 27)
        Me.txtSignUpUsername.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(51, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Username:"
        '
        'pnlMain
        '
        Me.pnlMain.BackgroundImage = CType(resources.GetObject("pnlMain.BackgroundImage"), System.Drawing.Image)
        Me.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnlMain.Controls.Add(Me.Label8)
        Me.pnlMain.Controls.Add(Me.btnLogOut)
        Me.pnlMain.Controls.Add(Me.lblLogged)
        Me.pnlMain.Controls.Add(Me.Panel2)
        Me.pnlMain.Location = New System.Drawing.Point(317, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(163, 562)
        Me.pnlMain.TabIndex = 15
        Me.pnlMain.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(229, 209)
        Me.Label8.MaximumSize = New System.Drawing.Size(700, 500)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(327, 38)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Select a category"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.Transparent
        Me.btnLogOut.BackgroundImage = Global.SuperMegaQuiz.My.Resources.Resources.btnLogOut
        Me.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.ForeColor = System.Drawing.Color.Transparent
        Me.btnLogOut.Location = New System.Drawing.Point(620, 510)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(152, 40)
        Me.btnLogOut.TabIndex = 8
        Me.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'lblLogged
        '
        Me.lblLogged.BackColor = System.Drawing.Color.Transparent
        Me.lblLogged.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogged.ForeColor = System.Drawing.Color.White
        Me.lblLogged.Location = New System.Drawing.Point(228, 520)
        Me.lblLogged.Name = "lblLogged"
        Me.lblLogged.Size = New System.Drawing.Size(328, 18)
        Me.lblLogged.TabIndex = 0
        Me.lblLogged.Text = "Logged in as [username]"
        Me.lblLogged.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.lblScoreEnglish)
        Me.Panel2.Controls.Add(Me.btnPlayEnglish)
        Me.Panel2.Controls.Add(Me.lblScoreArt)
        Me.Panel2.Controls.Add(Me.lblScoreEconomics)
        Me.Panel2.Controls.Add(Me.btnPlayArt)
        Me.Panel2.Controls.Add(Me.btnPlayEconomics)
        Me.Panel2.Controls.Add(Me.lblScoreScience)
        Me.Panel2.Controls.Add(Me.btnPlayScience)
        Me.Panel2.Controls.Add(Me.lblScoreMath)
        Me.Panel2.Controls.Add(Me.btnPlayMath)
        Me.Panel2.Location = New System.Drawing.Point(42, 264)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(219, 237)
        Me.Panel2.TabIndex = 20
        '
        'lblScoreEnglish
        '
        Me.lblScoreEnglish.AutoSize = True
        Me.lblScoreEnglish.BackColor = System.Drawing.Color.Transparent
        Me.lblScoreEnglish.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreEnglish.ForeColor = System.Drawing.Color.White
        Me.lblScoreEnglish.Location = New System.Drawing.Point(158, 199)
        Me.lblScoreEnglish.Name = "lblScoreEnglish"
        Me.lblScoreEnglish.Size = New System.Drawing.Size(58, 18)
        Me.lblScoreEnglish.TabIndex = 18
        Me.lblScoreEnglish.Text = "Score"
        '
        'btnPlayEnglish
        '
        Me.btnPlayEnglish.BackColor = System.Drawing.Color.Transparent
        Me.btnPlayEnglish.BackgroundImage = Global.SuperMegaQuiz.My.Resources.Resources.btnEnglish
        Me.btnPlayEnglish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPlayEnglish.FlatAppearance.BorderSize = 0
        Me.btnPlayEnglish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPlayEnglish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPlayEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlayEnglish.ForeColor = System.Drawing.Color.Transparent
        Me.btnPlayEnglish.Location = New System.Drawing.Point(0, 189)
        Me.btnPlayEnglish.Name = "btnPlayEnglish"
        Me.btnPlayEnglish.Size = New System.Drawing.Size(152, 40)
        Me.btnPlayEnglish.TabIndex = 19
        Me.btnPlayEnglish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPlayEnglish.UseVisualStyleBackColor = False
        '
        'lblScoreArt
        '
        Me.lblScoreArt.AutoSize = True
        Me.lblScoreArt.BackColor = System.Drawing.Color.Transparent
        Me.lblScoreArt.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreArt.ForeColor = System.Drawing.Color.White
        Me.lblScoreArt.Location = New System.Drawing.Point(158, 153)
        Me.lblScoreArt.Name = "lblScoreArt"
        Me.lblScoreArt.Size = New System.Drawing.Size(58, 18)
        Me.lblScoreArt.TabIndex = 16
        Me.lblScoreArt.Text = "Score"
        '
        'lblScoreEconomics
        '
        Me.lblScoreEconomics.AutoSize = True
        Me.lblScoreEconomics.BackColor = System.Drawing.Color.Transparent
        Me.lblScoreEconomics.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreEconomics.ForeColor = System.Drawing.Color.White
        Me.lblScoreEconomics.Location = New System.Drawing.Point(158, 107)
        Me.lblScoreEconomics.Name = "lblScoreEconomics"
        Me.lblScoreEconomics.Size = New System.Drawing.Size(58, 18)
        Me.lblScoreEconomics.TabIndex = 14
        Me.lblScoreEconomics.Text = "Score"
        '
        'btnPlayArt
        '
        Me.btnPlayArt.BackColor = System.Drawing.Color.Transparent
        Me.btnPlayArt.BackgroundImage = Global.SuperMegaQuiz.My.Resources.Resources.btnArt
        Me.btnPlayArt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPlayArt.FlatAppearance.BorderSize = 0
        Me.btnPlayArt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPlayArt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPlayArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlayArt.ForeColor = System.Drawing.Color.Transparent
        Me.btnPlayArt.Location = New System.Drawing.Point(0, 143)
        Me.btnPlayArt.Name = "btnPlayArt"
        Me.btnPlayArt.Size = New System.Drawing.Size(152, 40)
        Me.btnPlayArt.TabIndex = 17
        Me.btnPlayArt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPlayArt.UseVisualStyleBackColor = False
        '
        'btnPlayEconomics
        '
        Me.btnPlayEconomics.BackColor = System.Drawing.Color.Transparent
        Me.btnPlayEconomics.BackgroundImage = Global.SuperMegaQuiz.My.Resources.Resources.btnEconomics
        Me.btnPlayEconomics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPlayEconomics.FlatAppearance.BorderSize = 0
        Me.btnPlayEconomics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPlayEconomics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPlayEconomics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlayEconomics.ForeColor = System.Drawing.Color.Transparent
        Me.btnPlayEconomics.Location = New System.Drawing.Point(0, 97)
        Me.btnPlayEconomics.Name = "btnPlayEconomics"
        Me.btnPlayEconomics.Size = New System.Drawing.Size(152, 40)
        Me.btnPlayEconomics.TabIndex = 15
        Me.btnPlayEconomics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPlayEconomics.UseVisualStyleBackColor = False
        '
        'lblScoreScience
        '
        Me.lblScoreScience.AutoSize = True
        Me.lblScoreScience.BackColor = System.Drawing.Color.Transparent
        Me.lblScoreScience.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreScience.ForeColor = System.Drawing.Color.White
        Me.lblScoreScience.Location = New System.Drawing.Point(158, 61)
        Me.lblScoreScience.Name = "lblScoreScience"
        Me.lblScoreScience.Size = New System.Drawing.Size(58, 18)
        Me.lblScoreScience.TabIndex = 10
        Me.lblScoreScience.Text = "Score"
        '
        'btnPlayScience
        '
        Me.btnPlayScience.BackColor = System.Drawing.Color.Transparent
        Me.btnPlayScience.BackgroundImage = Global.SuperMegaQuiz.My.Resources.Resources.btnScience
        Me.btnPlayScience.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPlayScience.FlatAppearance.BorderSize = 0
        Me.btnPlayScience.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPlayScience.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPlayScience.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlayScience.ForeColor = System.Drawing.Color.Transparent
        Me.btnPlayScience.Location = New System.Drawing.Point(0, 51)
        Me.btnPlayScience.Name = "btnPlayScience"
        Me.btnPlayScience.Size = New System.Drawing.Size(152, 40)
        Me.btnPlayScience.TabIndex = 13
        Me.btnPlayScience.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPlayScience.UseVisualStyleBackColor = False
        '
        'lblScoreMath
        '
        Me.lblScoreMath.AutoSize = True
        Me.lblScoreMath.BackColor = System.Drawing.Color.Transparent
        Me.lblScoreMath.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreMath.ForeColor = System.Drawing.Color.White
        Me.lblScoreMath.Location = New System.Drawing.Point(158, 15)
        Me.lblScoreMath.Name = "lblScoreMath"
        Me.lblScoreMath.Size = New System.Drawing.Size(58, 18)
        Me.lblScoreMath.TabIndex = 9
        Me.lblScoreMath.Text = "Score"
        '
        'btnPlayMath
        '
        Me.btnPlayMath.BackColor = System.Drawing.Color.Transparent
        Me.btnPlayMath.BackgroundImage = CType(resources.GetObject("btnPlayMath.BackgroundImage"), System.Drawing.Image)
        Me.btnPlayMath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPlayMath.FlatAppearance.BorderSize = 0
        Me.btnPlayMath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPlayMath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPlayMath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlayMath.ForeColor = System.Drawing.Color.Transparent
        Me.btnPlayMath.Location = New System.Drawing.Point(0, 5)
        Me.btnPlayMath.Name = "btnPlayMath"
        Me.btnPlayMath.Size = New System.Drawing.Size(152, 40)
        Me.btnPlayMath.TabIndex = 7
        Me.btnPlayMath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPlayMath.UseVisualStyleBackColor = False
        '
        'pnlGame
        '
        Me.pnlGame.BackgroundImage = CType(resources.GetObject("pnlGame.BackgroundImage"), System.Drawing.Image)
        Me.pnlGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlGame.Controls.Add(Me.lblSubject)
        Me.pnlGame.Controls.Add(Me.btnQuit)
        Me.pnlGame.Controls.Add(Me.btnChoice4)
        Me.pnlGame.Controls.Add(Me.btnChoice3)
        Me.pnlGame.Controls.Add(Me.btnChoice2)
        Me.pnlGame.Controls.Add(Me.btnChoice1)
        Me.pnlGame.Controls.Add(Me.lblQuestion)
        Me.pnlGame.Controls.Add(Me.Label7)
        Me.pnlGame.Controls.Add(Me.lblScore)
        Me.pnlGame.Location = New System.Drawing.Point(486, 0)
        Me.pnlGame.Name = "pnlGame"
        Me.pnlGame.Size = New System.Drawing.Size(143, 562)
        Me.pnlGame.TabIndex = 17
        Me.pnlGame.Visible = False
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.BackColor = System.Drawing.Color.Transparent
        Me.lblSubject.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.ForeColor = System.Drawing.Color.White
        Me.lblSubject.Location = New System.Drawing.Point(24, 119)
        Me.lblSubject.MaximumSize = New System.Drawing.Size(700, 500)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(153, 38)
        Me.lblSubject.TabIndex = 16
        Me.lblSubject.Text = "Subject"
        Me.lblSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Transparent
        Me.btnQuit.BackgroundImage = Global.SuperMegaQuiz.My.Resources.Resources.btnQuit
        Me.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuit.FlatAppearance.BorderSize = 0
        Me.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.ForeColor = System.Drawing.Color.Transparent
        Me.btnQuit.Location = New System.Drawing.Point(620, 510)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(152, 40)
        Me.btnQuit.TabIndex = 15
        Me.btnQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'btnChoice4
        '
        Me.btnChoice4.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.btnChoice4.Location = New System.Drawing.Point(12, 461)
        Me.btnChoice4.Name = "btnChoice4"
        Me.btnChoice4.Size = New System.Drawing.Size(760, 40)
        Me.btnChoice4.TabIndex = 14
        Me.btnChoice4.Text = "Choice4"
        Me.btnChoice4.UseVisualStyleBackColor = True
        '
        'btnChoice3
        '
        Me.btnChoice3.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.btnChoice3.Location = New System.Drawing.Point(12, 415)
        Me.btnChoice3.Name = "btnChoice3"
        Me.btnChoice3.Size = New System.Drawing.Size(760, 40)
        Me.btnChoice3.TabIndex = 13
        Me.btnChoice3.Text = "Choice3"
        Me.btnChoice3.UseVisualStyleBackColor = True
        '
        'btnChoice2
        '
        Me.btnChoice2.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.btnChoice2.Location = New System.Drawing.Point(12, 369)
        Me.btnChoice2.Name = "btnChoice2"
        Me.btnChoice2.Size = New System.Drawing.Size(760, 40)
        Me.btnChoice2.TabIndex = 12
        Me.btnChoice2.Text = "Choice2"
        Me.btnChoice2.UseVisualStyleBackColor = True
        '
        'btnChoice1
        '
        Me.btnChoice1.Font = New System.Drawing.Font("Verdana", 16.0!)
        Me.btnChoice1.Location = New System.Drawing.Point(12, 323)
        Me.btnChoice1.Name = "btnChoice1"
        Me.btnChoice1.Size = New System.Drawing.Size(760, 40)
        Me.btnChoice1.TabIndex = 11
        Me.btnChoice1.Text = "Choice1"
        Me.btnChoice1.UseVisualStyleBackColor = True
        '
        'lblQuestion
        '
        Me.lblQuestion.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.ForeColor = System.Drawing.Color.White
        Me.lblQuestion.Location = New System.Drawing.Point(12, 174)
        Me.lblQuestion.MaximumSize = New System.Drawing.Size(759, 143)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(759, 143)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "Question"
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(558, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 38)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Score:"
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblScore.ForeColor = System.Drawing.Color.Transparent
        Me.lblScore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblScore.Location = New System.Drawing.Point(695, 119)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(60, 38)
        Me.lblScore.TabIndex = 9
        Me.lblScore.Text = "0"
        '
        'pnlEnd
        '
        Me.pnlEnd.BackgroundImage = Global.SuperMegaQuiz.My.Resources.Resources.quiz
        Me.pnlEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlEnd.Controls.Add(Me.btnRetry)
        Me.pnlEnd.Controls.Add(Me.lblResult)
        Me.pnlEnd.Controls.Add(Me.btnConfirm)
        Me.pnlEnd.Location = New System.Drawing.Point(635, 0)
        Me.pnlEnd.Name = "pnlEnd"
        Me.pnlEnd.Size = New System.Drawing.Size(149, 562)
        Me.pnlEnd.TabIndex = 18
        Me.pnlEnd.Visible = False
        '
        'btnRetry
        '
        Me.btnRetry.BackColor = System.Drawing.Color.Transparent
        Me.btnRetry.BackgroundImage = Global.SuperMegaQuiz.My.Resources.Resources.btnRetry
        Me.btnRetry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRetry.FlatAppearance.BorderSize = 0
        Me.btnRetry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRetry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetry.ForeColor = System.Drawing.Color.Transparent
        Me.btnRetry.Location = New System.Drawing.Point(395, 315)
        Me.btnRetry.Name = "btnRetry"
        Me.btnRetry.Size = New System.Drawing.Size(152, 40)
        Me.btnRetry.TabIndex = 18
        Me.btnRetry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnRetry.UseVisualStyleBackColor = False
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.Color.Transparent
        Me.lblResult.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.ForeColor = System.Drawing.Color.White
        Me.lblResult.Location = New System.Drawing.Point(12, 211)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(760, 100)
        Me.lblResult.TabIndex = 17
        Me.lblResult.Text = "Result"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.Transparent
        Me.btnConfirm.BackgroundImage = Global.SuperMegaQuiz.My.Resources.Resources.btnConfirm
        Me.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.ForeColor = System.Drawing.Color.Transparent
        Me.btnConfirm.Location = New System.Drawing.Point(237, 315)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(152, 40)
        Me.btnConfirm.TabIndex = 16
        Me.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.pnlManage)
        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlGame)
        Me.Controls.Add(Me.pnlEnd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Super Mega Quiz"
        Me.pnlManage.ResumeLayout(False)
        CType(Me.dtgUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLogin.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlGame.ResumeLayout(False)
        Me.pnlGame.PerformLayout()
        Me.pnlEnd.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSignUpPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSignUpUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSignUpVerifyPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblLogged As Label
    Friend WithEvents pnlGame As Panel
    Friend WithEvents lblQuestion As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnChoice4 As Button
    Friend WithEvents btnChoice3 As Button
    Friend WithEvents btnChoice2 As Button
    Friend WithEvents btnChoice1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Private WithEvents btnLogin As Button
    Private WithEvents btnSignUp As Button
    Private WithEvents btnPlayMath As Button
    Private WithEvents btnLogOut As Button
    Private WithEvents btnQuit As Button
    Friend WithEvents pnlEnd As Panel
    Private WithEvents btnConfirm As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents lblScoreMath As Label
    Friend WithEvents lblScoreScience As Label
    Friend WithEvents Label8 As Label
    Private WithEvents btnPlayScience As Button
    Private WithEvents btnPlayEconomics As Button
    Friend WithEvents lblScoreEconomics As Label
    Friend WithEvents lblSubject As Label
    Private WithEvents btnPlayArt As Button
    Friend WithEvents lblScoreArt As Label
    Private WithEvents btnPlayEnglish As Button
    Friend WithEvents lblScoreEnglish As Label
    Friend WithEvents Panel2 As Panel
    Private WithEvents btnRetry As Button
    Private WithEvents btnManage As Button
    Friend WithEvents pnlManage As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents dtgUsers As DataGridView
    Private WithEvents btnBack As Button
    Private WithEvents btnDelete As Button
End Class
