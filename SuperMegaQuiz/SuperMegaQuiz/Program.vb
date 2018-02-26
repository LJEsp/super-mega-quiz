Imports MySql.Data.MySqlClient
Imports VB = Microsoft.VisualBasic


Public Class frmMain

    Dim con As MySqlConnection

    Dim activeUser As String

    Dim username As String
    Dim password As String

    Dim subject As String = ""
    Dim item As Integer = 1
    Dim count As Integer

    Dim subjectScore As String

    Dim subjectTable As String

    'START PROGRAM
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FormBorderStyle = FormBorderStyle.Fixed3D
        MaximizeBox = False

        pnlLogin.Dock = DockStyle.Fill

        btnSignUp.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255)
        btnLogin.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255)
        btnPlayMath.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255)
        btnPlayScience.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255)
        btnPlayEconomics.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255)
        btnPlayArt.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255)
        btnPlayEnglish.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255)
        btnLogOut.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255)
        btnQuit.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255)
        btnConfirm.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255)
        btnManage.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255)
        btnDelete.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255)

    End Sub

    'SIGN UP
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click

        con = New MySqlConnection
        con.ConnectionString = "server=localhost;user=root;password=;database=dbsupermegaquiz"

        Dim reader As MySqlDataReader

        Dim username As String = txtSignUpUsername.Text
        Dim password As String = txtSignUpPassword.Text
        Dim verifyPassword As String = txtSignUpVerifyPassword.Text

        If username = "" Or password = "" Then

            MessageBox.Show("Please complete the fields")
            txtSignUpPassword.Clear()

        Else
            If password = verifyPassword Then

                Try
                    con.Open()
                    Dim sql As String
                    sql = "insert into tblusers(username,password) values ('" & username & "','" & password & "')"

                    Dim cmd = New MySqlCommand(sql, con)
                    reader = cmd.ExecuteReader

                    txtSignUpUsername.Clear()
                    txtSignUpPassword.Clear()
                    txtSignUpVerifyPassword.Clear()

                    con.Close()
                    MessageBox.Show("Sign up successful")

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                    txtSignUpUsername.Clear()
                    txtSignUpPassword.Clear()
                    txtSignUpVerifyPassword.Clear()

                Finally
                    con.Dispose()
                End Try

            Else
                MessageBox.Show("Password does not match")
                txtSignUpPassword.Clear()
                txtSignUpVerifyPassword.Clear()

            End If

        End If
    End Sub

    Private Sub btnSignUp_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSignUp.MouseDown
        btnSignUp.BackgroundImage = My.Resources.btnSignUpDown
    End Sub

    Private Sub btnSignUp_MouseUp(sender As Object, e As MouseEventArgs) Handles btnSignUp.MouseUp
        btnSignUp.BackgroundImage = My.Resources.btnSignUp
    End Sub

    'LOGIN
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        username = txtUsername.Text
        password = txtPassword.Text

        Try
            con = New MySqlConnection
            con.ConnectionString = "server=localhost;user=root;password=;database=dbsupermegaquiz"

            Dim reader As MySqlDataReader

            con.Open()
            Dim sql As String
            sql = "SELECT * from tblusers where username = ('" & username & "')"

            Dim cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader

            Dim user As String = ""
            Dim pass As String = ""

            If reader.Read Then

                user = reader.GetString(0)
                pass = reader.GetString(1)

            End If

            If username = "" Or password = "" Then

                MessageBox.Show("Please complete the fields")

            Else
                If username = user And password = pass Then

                    activeUser = user

                    txtUsername.Clear()
                    txtPassword.Clear()

                    MessageBox.Show("Welcome " + user + "!")

                    pnlLogin.Visible = False
                    pnlMain.Visible = True

                    pnlMain.Dock = DockStyle.Fill

                Else
                    MessageBox.Show("Invalid username or password")
                    txtUsername.Clear()
                    txtPassword.Clear()

                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

            txtUsername.Clear()
            txtPassword.Clear()

        Finally

            con.Close()
        End Try

        lblLogged.Text = "Logged in as " + username

        displayScore()

    End Sub

    'HANDLES THE MOUSE DOWN & UP EFFECT
    Private Sub btnLogin_MouseDown(sender As Object, e As MouseEventArgs) Handles btnLogin.MouseDown
        btnLogin.BackgroundImage = My.Resources.btnLoginDown
    End Sub

    Private Sub btnLogin_MouseUp(sender As Object, e As MouseEventArgs) Handles btnLogin.MouseUp
        btnLogin.BackgroundImage = My.Resources.btnLogin
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub

    'SUBROUTINE THAT DISPLAYS THE SCORE
    Sub displayScore()

        con = New MySqlConnection
        con.ConnectionString = "server=localhost;user=root;password=;database=dbsupermegaquiz"

        Dim reader As MySqlDataReader

        con.Open()
        Dim sql As String
        sql = "SELECT * from tblusers where username = ('" & username & "')"

        Dim cmd = New MySqlCommand(sql, con)
        reader = cmd.ExecuteReader

        Dim scoreMath As String = ""
        Dim scoreScience As String = ""
        Dim scoreEconomics As String = ""
        Dim scoreArt As String = ""
        Dim scoreEnglish As String = ""

        If reader.Read Then

            scoreMath = reader.GetString(2)
            scoreScience = reader.GetString(3)
            scoreEconomics = reader.GetString(4)
            scoreArt = reader.GetString(5)
            scoreEnglish = reader.GetString(6)

        End If

        con.Close()

        lblScoreMath.Text = scoreMath
        lblScoreScience.Text = scoreScience
        lblScoreEconomics.Text = scoreEconomics
        lblScoreArt.Text = scoreArt
        lblScoreEnglish.Text = scoreEnglish

    End Sub

    'PLAY MATH GAME
    Private Sub btnPlayMath_Click(sender As Object, e As EventArgs) Handles btnPlayMath.Click

        subjectTable = "tblmath"

        playGame(subjectTable)

        subjectScore = "scoremath"

        lblSubject.Text = "Math"
    End Sub

    Private Sub btnPlayMath_MouseDown(sender As Object, e As MouseEventArgs) Handles btnPlayMath.MouseDown
        btnPlayMath.BackgroundImage = My.Resources.btnMathDown
    End Sub

    Private Sub btnPlayMath_MouseUp(sender As Object, e As MouseEventArgs) Handles btnPlayMath.MouseUp
        btnPlayMath.BackgroundImage = My.Resources.btnMath
    End Sub

    'PLAY SCIENCE GAME
    Private Sub btnPlayScience_Click(sender As Object, e As EventArgs) Handles btnPlayScience.Click
        subjectTable = "tblscience"

        playGame(subjectTable)

        subjectScore = "scorescience"

        lblSubject.Text = "Science"

    End Sub

    Private Sub btnPlayScience_MouseDown(sender As Object, e As MouseEventArgs) Handles btnPlayScience.MouseDown
        btnPlayScience.BackgroundImage = My.Resources.btnScienceDown
    End Sub

    Private Sub btnPlayScience_MouseUp(sender As Object, e As MouseEventArgs) Handles btnPlayScience.MouseUp
        btnPlayScience.BackgroundImage = My.Resources.btnScience
    End Sub

    'PLAY ECONOMICS GAME
    Private Sub btnPlayEconomics_Click(sender As Object, e As EventArgs) Handles btnPlayEconomics.Click

        subjectTable = "tbleconomics"

        playGame(subjectTable)

        subjectScore = "scoreeconomics"

        lblSubject.Text = "Economics"

    End Sub

    Private Sub btnPlayEconomics_MouseDown(sender As Object, e As MouseEventArgs) Handles btnPlayEconomics.MouseDown
        btnPlayEconomics.BackgroundImage = My.Resources.btnEconomicsDown
    End Sub

    Private Sub btnPlayEconomics_MouseUp(sender As Object, e As MouseEventArgs) Handles btnPlayEconomics.MouseUp
        btnPlayEconomics.BackgroundImage = My.Resources.btnEconomics
    End Sub

    'PLAY ART GAME
    Private Sub btnPlayArt_Click(sender As Object, e As EventArgs) Handles btnPlayArt.Click
        subjectTable = "tblart"

        playGame(subjectTable)

        subjectScore = "scoreart"

        lblSubject.Text = "Art"

    End Sub

    Private Sub btnPlayArt_MouseDown(sender As Object, e As MouseEventArgs) Handles btnPlayArt.MouseDown
        btnPlayArt.BackgroundImage = My.Resources.btnArtDown
    End Sub

    Private Sub btnPlayArt_MouseUp(sender As Object, e As MouseEventArgs) Handles btnPlayArt.MouseUp
        btnPlayArt.BackgroundImage = My.Resources.btnArt
    End Sub

    'PLAY ENGLISH GAME
    Private Sub btnPlayEnglish_Click(sender As Object, e As EventArgs) Handles btnPlayEnglish.Click
        subjectTable = "tblenglish"

        playGame(subjectTable)

        subjectScore = "scoreenglish"

        lblSubject.Text = "English"

    End Sub

    Private Sub btnPlayEnglish_MouseDown(sender As Object, e As MouseEventArgs) Handles btnPlayEnglish.MouseDown
        btnPlayEnglish.BackgroundImage = My.Resources.btnEnglishDown
    End Sub

    Private Sub btnPlayEnglish_MouseUp(sender As Object, e As MouseEventArgs) Handles btnPlayEnglish.MouseUp
        btnPlayEnglish.BackgroundImage = My.Resources.btnEnglish
    End Sub

    'FUNCTION TO PLAY GAME. NEEDS TABLE NAME OF THE SUBJECT
    Sub playGame(subj)

        subject = subj

        pnlMain.Visible = False

        pnlGame.Visible = True

        pnlGame.Dock = DockStyle.Fill

        lblScore.Text = 0

        newQuestion()

        countQuestions()

    End Sub

    'SUBROUTINE TO CLEAR/RESET VARIABLES
    Sub clear()

        subject = ""
        'subjectScore = ""

        item = 1
        count = 0
        score = 0
        number = 0
        oldNumber = 0
        question = ""
        answer = ""
        choice1 = ""
        choice2 = ""
        choice3 = ""

    End Sub

    'SUBROUTINE USED TO SHUFFLE THE CHOICES
    Private rnd As New Random()
    Public Sub Shuffle(items As String())
        Dim j As Int32
        Dim temp As String

        For n As Int32 = items.Length - 1 To 0 Step -1
            j = rnd.Next(0, n + 1)
            ' Swap them.
            temp = items(n)
            items(n) = items(j)
            items(j) = temp
        Next n
    End Sub

    'creating variables for the quiz
    Dim number = 0
    Dim question As String = ""
    Dim answer As String = ""
    Dim choice1 As String = ""
    Dim choice2 As String = ""
    Dim choice3 As String = ""

    Dim score As Integer = 0

    Private Sub pnlGame_Paint(sender As Object, e As PaintEventArgs) Handles pnlGame.Paint

    End Sub

    'FUNCTION TO COUNT THE NUMBER OF QUESTIONS IN A TABLE
    Function countQuestions()
        con = New MySqlConnection
        con.ConnectionString = "server=localhost;user=root;password=;database=dbsupermegaquiz"

        'Dim reader As MySqlDataReader

        con.Open()
        Dim sql As String

        sql = "SELECT COUNT(*) FROM " + subject

        Dim cmd = New MySqlCommand(sql, con)

        count = Integer.Parse(cmd.ExecuteScalar)

        con.Close()
        cmd = Nothing

        Return count

    End Function

    'SUBROUTINE THAT ADDS SCORE TO DATABASE
    Sub addScore(score)

        con = New MySqlConnection
        con.ConnectionString = "server=localhost;user=root;password=;database=dbsupermegaquiz"

        Dim reader As MySqlDataReader

        con.Open()
        Dim sql As String
        sql = "UPDATE tblusers SET " & subjectScore & " = ('" & score & "') where username = ('" & activeUser & "')"
        Dim cmd = New MySqlCommand(sql, con)

        reader = cmd.ExecuteReader

        con.Close()

    End Sub

    Dim oldNumber

    'SUBROUTINE TO DISPLAY NEW QUESTION FROM A TABLE AND ALSO HANDLE END GAME
    Sub newQuestion()

        con = New MySqlConnection
        con.ConnectionString = "server=localhost;user=root;password=;database=dbsupermegaquiz"

        Dim reader As MySqlDataReader

        con.Open()
        Dim sql As String

        sql = "SELECT * from " + subject + " where number = " + item.ToString
        'sql = subject + " where number = " + item.ToString

        Dim cmd = New MySqlCommand(sql, con)
        reader = cmd.ExecuteReader

        oldNumber = number

        If reader.Read Then

            'assigns data from to database to variables
            number = reader.GetString(0)
            question = reader.GetString(1)
            answer = reader.GetString(2)
            choice1 = reader.GetString(3)
            choice2 = reader.GetString(4)
            choice3 = reader.GetString(5)

        End If

        'creates an array of the choices
        Dim choices = {answer, choice1, choice2, choice3}

        'displays question to label
        lblQuestion.Text = question

        'shuffles the choices with the shuffle subroutine
        Shuffle(choices)

        '//Dim result As String = String.Join(vbCrLf, choices)

        '//lblChoices.Text = result

        'displays choices to buttons
        btnChoice1.Text = choices(0)
        btnChoice2.Text = choices(1)
        btnChoice3.Text = choices(2)
        btnChoice4.Text = choices(3)

        con.Close()

        'if the same question is repeated then end the quiz
        If oldNumber = number Then

            Dim message As String = "You've got " & vbCrLf & score & "/" & countQuestions()

            If score = countQuestions() Then
                message = " Congratulations! You've got PERFECT." & vbCrLf & score & "/" & countQuestions()
            End If

            'MessageBox.Show(message)

            pnlGame.Visible = False
            '//pnlMain.Visible = True

            item = 1

            Dim result As String = score & "/" & countQuestions()

            addScore(result)

            pnlEnd.Visible = True
            pnlEnd.Dock = DockStyle.Fill

            lblResult.Text = message

            displayScore()

        End If

    End Sub

    'SUBROUTINE TO WAIT FOR SECONDS PROVIDED
    Public Sub wait(ByVal seconds As Single)
        Static start As Single
        start = VB.Timer()
        Do While VB.Timer() < start + seconds
            System.Windows.Forms.Application.DoEvents()
        Loop
    End Sub

    'CHOICE BUTTON CLICKED
    Private Sub MyButtons_Click(sender As Object, e As EventArgs) Handles btnChoice1.Click, btnChoice2.Click, btnChoice3.Click, btnChoice4.Click

        Dim btn As Button = CType(sender, Button)

        If btn.Text = answer Then

            My.Computer.Audio.Play(My.Resources.correct, AudioPlayMode.Background)
            item += 1
            score += 1
            lblScore.Text = score

            btn.BackColor = Color.Green

            btnChoice1.Enabled = False
            btnChoice2.Enabled = False
            btnChoice3.Enabled = False
            btnChoice4.Enabled = False

            btnQuit.Enabled = False

            wait(1)

            'MessageBox.Show("Correct!")

            btn.BackColor = DefaultBackColor

            newQuestion()

            btnChoice1.Enabled = True
            btnChoice2.Enabled = True
            btnChoice3.Enabled = True
            btnChoice4.Enabled = True

            btnQuit.Enabled = True

        Else

            My.Computer.Audio.Play(My.Resources.incorrect, AudioPlayMode.Background)

            item += 1

            btn.BackColor = Color.Red

            btnChoice1.Enabled = False
            btnChoice2.Enabled = False
            btnChoice3.Enabled = False
            btnChoice4.Enabled = False

            btnQuit.Enabled = False

            wait(1)

            'MessageBox.Show("Incorrect!")

            btn.BackColor = DefaultBackColor

            newQuestion()

            btnChoice1.Enabled = True
            btnChoice2.Enabled = True
            btnChoice3.Enabled = True
            btnChoice4.Enabled = True

            btnQuit.Enabled = True

        End If

    End Sub

    'SUBMIT ANSWER BUTTON (NOT USED)
    'Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
    '    If txtAnswer.Text = answer Then
    '        MessageBox.Show(1)
    '        item += 1
    '        score += 1
    '        newQuestion()

    '        lblScore.Text = score

    '    Else
    '        MessageBox.Show("Incorrect!")
    '        item += 1
    '        newQuestion()
    '    End If
    'End Sub

    'QUIT BUTTON
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        Dim quit As MsgBoxResult = MsgBox("Are you sure?", MsgBoxStyle.YesNo)

        If quit = MsgBoxResult.Yes Then
            pnlGame.Visible = False
            pnlMain.Visible = True

            clear()
        End If

    End Sub

    Private Sub btnQuit_MouseDown(sender As Object, e As MouseEventArgs) Handles btnQuit.MouseDown
        btnQuit.BackgroundImage = My.Resources.btnQuitDown
    End Sub

    Private Sub btnQuit_MouseUp(sender As Object, e As MouseEventArgs) Handles btnQuit.MouseUp
        btnQuit.BackgroundImage = My.Resources.btnQuit
    End Sub

    'LOGOUT BUTTON
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click

        Dim logout As MsgBoxResult = MsgBox("Are you sure you want to log out?", MsgBoxStyle.YesNo)

        If logout = MsgBoxResult.Yes Then
            pnlMain.Visible = False
            pnlLogin.Visible = True

            activeUser = ""
        End If

    End Sub

    Private Sub btnLogOut_MouseDown(sender As Object, e As MouseEventArgs) Handles btnLogOut.MouseDown
        btnLogOut.BackgroundImage = My.Resources.btnLogOutDown
    End Sub

    Private Sub btnLogOut_MouseUp(sender As Object, e As MouseEventArgs) Handles btnLogOut.MouseUp
        btnLogOut.BackgroundImage = My.Resources.btnLogOut
    End Sub

    'CONFIRM BUTTON
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        clear()

        pnlEnd.Visible = False
        pnlMain.Visible = True

    End Sub

    Private Sub btnConfirm_MouseDown(sender As Object, e As MouseEventArgs) Handles btnConfirm.MouseDown
        btnConfirm.BackgroundImage = My.Resources.btnConfirmDown
    End Sub

    Private Sub btnConfirm_MouseUp(sender As Object, e As MouseEventArgs) Handles btnConfirm.MouseUp
        btnConfirm.BackgroundImage = My.Resources.btnConfirm
    End Sub

    'RETRY BUTTON
    Private Sub btnRetry_Click(sender As Object, e As EventArgs) Handles btnRetry.Click

        clear()

        playGame(subjectTable)

    End Sub

    Private Sub btnRetry_MouseDown(sender As Object, e As MouseEventArgs) Handles btnRetry.MouseDown
        btnRetry.BackgroundImage = My.Resources.btnRetryDown
    End Sub

    Private Sub btnRetry_MouseUp(sender As Object, e As MouseEventArgs) Handles btnRetry.MouseUp
        btnRetry.BackgroundImage = My.Resources.btnRetry
    End Sub

    'BUTTON THAT GOES TO THE MANAGE PANEL
    Private Sub btnManage_Click(sender As Object, e As EventArgs) Handles btnManage.Click
        pnlLogin.Visible = False
        pnlManage.Visible = True
        pnlManage.Dock = DockStyle.Fill

        displayUsers()

        dtgUsers.CurrentCell.Selected = False

    End Sub

    'SUBROUTINE THAT DISPLAYS USERS IN THE DATAGRIDVIEW
    Sub displayUsers()
        con = New MySqlConnection
        con.ConnectionString = "server=localhost;user=root;password=;database=dbsupermegaquiz"

        Try
            con.Open()

            Dim sql As String

            Dim dta As New MySqlDataAdapter

            Dim dt As New DataTable

            Dim ds As New BindingSource

            sql = "select username from tblusers"

            Dim cmd = New MySqlCommand(sql, con)

            dta.SelectCommand = cmd
            dta.Fill(dt)
            ds.DataSource = dt
            dtgUsers.DataSource = ds
            dta.Update(dt)

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
        End Try


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        pnlManage.Visible = False
        pnlLogin.Visible = True
    End Sub

    Dim selectedUser As String

    Private Sub dtgUsers_Click(sender As Object, e As EventArgs) Handles dtgUsers.Click

        selectedUser = dtgUsers.CurrentRow.Cells("username").Value
        'MessageBox.Show(selectedUser)

    End Sub

    'BUTTON THAT DELETES THE USERNAME IN THE SELECTED CELL 
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim msg As String
        msg = MessageBox.Show("Are you sure you want to delete " & selectedUser & ".", "Warning", MessageBoxButtons.YesNo)
        If msg = DialogResult.Yes Then
            con = New MySqlConnection
            con.ConnectionString = "server=localhost;user=root;password=;database=dbsupermegaquiz"

            Dim reader As MySqlDataReader
            Try
                con.Open()
                Dim sql As String
                sql = "delete from tblusers WHERE username = ('" & selectedUser & "')"

                Dim cmd = New MySqlCommand(sql, con)
                reader = cmd.ExecuteReader
                MessageBox.Show("User " & selectedUser & " deleted successfully.")

                con.Close()
            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try

            displayUsers()
        End If
    End Sub

    Private Sub btnDelete_MouseDown(sender As Object, e As MouseEventArgs) Handles btnDelete.MouseDown
        btnDelete.BackgroundImage = My.Resources.btnDeleteDown
    End Sub

    Private Sub btnDelete_MouseUp(sender As Object, e As MouseEventArgs) Handles btnDelete.MouseUp
        btnDelete.BackgroundImage = My.Resources.btnDelete
    End Sub
End Class