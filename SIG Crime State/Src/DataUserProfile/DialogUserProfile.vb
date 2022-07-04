Imports System.Windows.Forms
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class DialogUserProfile
    Implements IDbConnection

    Public FormSender As Object
    Dim finduser As String
    Dim userfindstatus As Boolean = False
    Public isnewUser As Boolean = False
    Public isUpdateUser As Boolean = False
    Dim senduserData As Boolean = False
    Private picture As String = "#"
    Private pictureKTP As String = "#"


    Public Sub FindUserData(ByVal userID As String)
        finduser = userID
        Dim dbConn As New DatabaseConnection
        dbConn.Query = "SELECT * FROM users WHERE id = '" & userID & "'"
        dbConn.tableName = "users"
        dbConn.objectSender = Me
        dbConn.ShowDialog()

        If Not picture = "" Then
            Try
                PictureBox1.Load(Globals.kecPicUrl + picture)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub GetFullData(userID As String)
        Dim dbConn As New DatabaseConnection
        dbConn.Query = "SELECT * FROM user_data WHERE user_id = '" & userID & "'"
        dbConn.tableName = "userdata"
        dbConn.objectSender = Me
        dbConn.ShowDialog()
    End Sub

    Private Sub addnewUser()
        Me.UseWaitCursor = True
        Dim querys As String = ""
        Dim saveFullData As New DatabaseConnection
        With saveFullData
            If KtpFileDialog.FileName.Length > 0 Then
                Dim pathFile As New FileInfo(KtpFileDialog.FileName)
                .WithUpload = True
                .UploadFile = KtpFileDialog.FileName
                .UploadUrl = ""
                querys = "INSERT INTO user_data (nik, user_id, name, tempat_lahir, tanggal_lahir, jenis_kelamin, " + _
        "alamat, rt_rw, kel_desa, kecamatan, agama, st_kawin, pekerjaan, kewarganegaraan, exp) VALUES " + _
        "('" & NikTextBox.Text & "', " + _
        "'" & MetroTextBox1.Text & "', " + _
        "'" & NameTextBox.Text & "', " + _
        "'" & Tempat_lahirTextBox.Text & "', " + _
        "'" & Tanggal_lahirDateTimePicker.Value.ToString("yyyy-MM-dd") & "', " + _
        "'" & Jenis_kelaminTextBox.Text & "', " + _
        "'" & AlamatTextBox.Text & "', " + _
        "'" & Rt_rwTextBox.Text & "', " + _
        "'" & Kel_desaTextBox.Text & "', " + _
        "'" & KecamatanTextBox.Text & "', " + _
        "'" & AgamaTextBox.Text & "', " + _
        "'" & St_kawinTextBox.Text & "', " + _
        "'" & PekerjaanTextBox.Text & "', " + _
        "'" & KewarganegaraanTextBox.Text & "', " + _
        "'" & ExpTextBox.Text & "'); SELECT * FROM user_data WHERE id = LAST_INSERT_ID()"
            Else
                .WithUpload = False
                querys = "INSERT INTO user_data (nik, user_id, name, tempat_lahir, tanggal_lahir, jenis_kelamin, " + _
        "alamat, rt_rw, kel_desa, kecamatan, agama, st_kawin, pekerjaan, kewarganegaraan, exp) VALUES " + _
        "('" & NikTextBox.Text & "', " + _
        "'" & MetroTextBox1.Text & "', " + _
        "'" & NameTextBox.Text & "', " + _
        "'" & Tempat_lahirTextBox.Text & "', " + _
        "'" & Tanggal_lahirDateTimePicker.Value.ToString("yyyy-MM-dd") & "', " + _
        "'" & Jenis_kelaminTextBox.Text & "', " + _
        "'" & AlamatTextBox.Text & "', " + _
        "'" & Rt_rwTextBox.Text & "', " + _
        "'" & Kel_desaTextBox.Text & "', " + _
        "'" & KecamatanTextBox.Text & "', " + _
        "'" & AgamaTextBox.Text & "', " + _
        "'" & St_kawinTextBox.Text & "', " + _
        "'" & PekerjaanTextBox.Text & "', " + _
        "'" & KewarganegaraanTextBox.Text & "', " + _
        "'" & ExpTextBox.Text & "'); SELECT * FROM user_data WHERE id = LAST_INSERT_ID()"
            End If


            .Query = querys
            .tableName = "userdata"
            .objectSender = Me
        End With
        saveFullData.ShowDialog()
    End Sub

    Private Sub updateUser()
        Me.UseWaitCursor = True
        Dim querys As String = ""
        Dim saveFullData As New DatabaseConnection
        With saveFullData
            If KtpFileDialog.FileName.Length > 0 Then
                Dim pathFile As New FileInfo(KtpFileDialog.FileName)
                .WithUpload = True
                .UploadFile = KtpFileDialog.FileName
                .UploadUrl = Globals.UploadKtpImg
                querys = "UPDATE user_data SET " + _
            "nik='" & NikTextBox.Text & "',  " + _
            "name='" & NameTextBox.Text & "',  " + _
            "tempat_lahir='" & Tempat_lahirTextBox.Text & "',  " + _
            "tanggal_lahir='" & Tanggal_lahirDateTimePicker.Value.ToString("yyyy-MM-dd") & "',  " + _
            "jenis_kelamin='" & Jenis_kelaminTextBox.Text & "',  " + _
            "alamat='" & AlamatTextBox.Text & "',  " + _
            "rt_rw='" & Rt_rwTextBox.Text & "',  " + _
            "kel_desa='" & Kel_desaTextBox.Text & "',  " + _
            "kecamatan='" & KecamatanTextBox.Text & "',  " + _
            "agama='" & AgamaTextBox.Text & "',  " + _
            "st_kawin='" & St_kawinTextBox.Text & "',  " + _
            "pekerjaan='" & PekerjaanTextBox.Text & "',  " + _
            "kewarganegaraan='" & KewarganegaraanTextBox.Text & "',  " + _
            "filename='" & pathFile.Name & "',  " + _
            "exp='" & ExpTextBox.Text & "'  " + _
            "WHERE (user_id='" & MetroTextBox1.Text & "');"
            Else
                .WithUpload = False
                querys = "UPDATE user_data SET " + _
            "nik='" & NikTextBox.Text & "',  " + _
            "name='" & NameTextBox.Text & "',  " + _
            "tempat_lahir='" & Tempat_lahirTextBox.Text & "',  " + _
            "tanggal_lahir='" & Tanggal_lahirDateTimePicker.Value.ToString("yyyy-MM-dd") & "',  " + _
            "jenis_kelamin='" & Jenis_kelaminTextBox.Text & "',  " + _
            "alamat='" & AlamatTextBox.Text & "',  " + _
            "rt_rw='" & Rt_rwTextBox.Text & "',  " + _
            "kel_desa='" & Kel_desaTextBox.Text & "',  " + _
            "kecamatan='" & KecamatanTextBox.Text & "',  " + _
            "agama='" & AgamaTextBox.Text & "',  " + _
            "st_kawin='" & St_kawinTextBox.Text & "',  " + _
            "pekerjaan='" & PekerjaanTextBox.Text & "',  " + _
            "kewarganegaraan='" & KewarganegaraanTextBox.Text & "',  " + _
            "exp='" & ExpTextBox.Text & "'  " + _
            "WHERE (user_id='" & MetroTextBox1.Text & "');"
            End If
            .Query = querys
            .tableName = "userdata"
            .objectSender = Me
        End With
        senduserData = False
        saveFullData.ShowDialog()


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            MetroTextBox3.UseSystemPasswordChar = False
            MetroTextBox3.PasswordChar = ""
        Else
            MetroTextBox3.UseSystemPasswordChar = True
            MetroTextBox3.PasswordChar = "*"
        End If
    End Sub

    Public Sub DatabaseResult(status As String, message As String, dt As SigDataSet) Implements Globals.IDbConnection.DatabaseResult
        Dim resultStatus As String = ""
        If status = ResultCode.Success Then
            resultStatus = "Success"
            If dt.Tables("users").Rows.Count > 0 Then
                Me.SigDataSet = dt
                userfindstatus = True
                finduser = dt.Tables("users").Rows(0).Item(0)
                MetroTextBox1.DataBindings.Clear()
                MetroTextBox2.DataBindings.Clear()
                MetroTextBox3.DataBindings.Clear()
                CheckBox2.DataBindings.Clear()
                CheckBox3.DataBindings.Clear()

                MetroTextBox1.DataBindings.Add("Text", Me.SigDataSet.Tables("users"), "id", True)
                MetroTextBox2.DataBindings.Add("Text", Me.SigDataSet.Tables("users"), "user", True)
                MetroTextBox3.DataBindings.Add("Text", Me.SigDataSet.Tables("users"), "pass", True)
                CheckBox2.DataBindings.Add("Checked", Me.SigDataSet.Tables("users"), "is_admin", True)
                CheckBox3.DataBindings.Add("Checked", Me.SigDataSet.Tables("users"), "user_verified", True)
                EmailTextBox.DataBindings.Clear()
                EmailTextBox.DataBindings.Add("text", Me.SigDataSet.Tables("users"), "email", True)
                Try
                    If SigDataSet.Tables("users").Rows.Count > 0 Then
                        PictureBox1.Load(Globals.userPofilePicUrl + Me.SigDataSet.Tables("users").Rows(0).Item("filename"))
                    End If
                Catch ex As Exception
                    'MsgBox(ex.ToString)
                End Try

                If isnewUser = True Then
                    addnewUser()
                End If

            End If


            If dt.Tables("userdata").Rows.Count > 0 Then
                If Me.SigDataSet.Tables("userdata").Rows.Count < 1 Then
                    Me.SigDataSet.Tables.Remove(Me.SigDataSet.Tables("userdata"))
                    Me.SigDataSet.AcceptChanges()
                    Dim newtable As New DataTable("userdata")
                    For i As Integer = 0 To dt.Tables("userdata").Columns.Count - 1
                        newtable.Columns.Add(dt.Tables("userdata").Columns(i).ColumnName)
                    Next

                    For irow As Integer = 0 To dt.Tables("userdata").Rows.Count - 1
                        For icol As Integer = 0 To dt.Tables("userdata").Columns.Count - 1
                            newtable.Rows.Add(dt.Tables("userdata").Rows(irow).Item(icol))
                        Next
                    Next
                    Me.SigDataSet.Tables.Add(newtable)
                End If
                Me.SigDataSet = dt

                IdTextBox.DataBindings.Clear()
                IdTextBox.DataBindings.Add("Text", Me.SigDataSet.Tables("userdata"), "id", True)
                User_idTextBox.DataBindings.Clear()
                User_idTextBox.DataBindings.Add("Text", Me.SigDataSet.Tables("userdata"), "user_id", True)

                NikTextBox.DataBindings.Clear()
                NikTextBox.DataBindings.Add("Text", Me.SigDataSet.Tables("userdata"), "nik", True)
                NameTextBox.DataBindings.Clear()
                NameTextBox.DataBindings.Add("Text", Me.SigDataSet.Tables("userdata"), "name", True)
                Tempat_lahirTextBox.DataBindings.Clear()
                Tempat_lahirTextBox.DataBindings.Add("Text", Me.SigDataSet.Tables("userdata"), "tempat_lahir", True)
                Tanggal_lahirDateTimePicker.DataBindings.Clear()
                Tanggal_lahirDateTimePicker.DataBindings.Add("Value", Me.SigDataSet.Tables("userdata"), "tanggal_lahir", True)
                Jenis_kelaminTextBox.DataBindings.Clear()
                Jenis_kelaminTextBox.DataBindings.Add("Text", Me.SigDataSet.Tables("userdata"), "jenis_kelamin", True)

                AlamatTextBox.DataBindings.Clear()
                AlamatTextBox.DataBindings.Add("Text", Me.SigDataSet.Tables("userdata"), "alamat", True)
                Rt_rwTextBox.DataBindings.Clear()
                Rt_rwTextBox.DataBindings.Add("Text", Me.SigDataSet.Tables("userdata"), "rt_rw", True)
                Kel_desaTextBox.DataBindings.Clear()
                Kel_desaTextBox.DataBindings.Add("Text", Me.SigDataSet.Tables("userdata"), "kel_desa", True)
                KecamatanTextBox.DataBindings.Clear()
                KecamatanTextBox.DataBindings.Add("Text", Me.SigDataSet.Tables("userdata"), "kecamatan", True)

                AgamaTextBox.DataBindings.Clear()
                AgamaTextBox.DataBindings.Add("Text", Me.SigDataSet.Tables("userdata"), "agama", True)
                St_kawinTextBox.DataBindings.Clear()
                St_kawinTextBox.DataBindings.Add("Text", Me.SigDataSet.Tables("userdata"), "st_kawin", True)
                PekerjaanTextBox.DataBindings.Clear()
                PekerjaanTextBox.DataBindings.Add("Text", Me.SigDataSet.Tables("userdata"), "pekerjaan", True)
                KewarganegaraanTextBox.DataBindings.Clear()
                KewarganegaraanTextBox.DataBindings.Add("Text", Me.SigDataSet.Tables("userdata"), "kewarganegaraan", True)

                ExpTextBox.DataBindings.Clear()
                ExpTextBox.DataBindings.Add("Text", Me.SigDataSet.Tables("userdata"), "exp", True)

                Try
                    If SigDataSet.Tables("userdata").Rows.Count > 0 Then
                        PictureBox2.Load(Globals.userPicUrl + Me.SigDataSet.Tables("userdata").Rows(0).Item("filename"))
                    End If
                Catch ex As Exception
                    'MsgBox(ex.ToString)
                End Try
            End If

            If senduserData = True Then
                updateUser()
            End If

            If Me.UseWaitCursor = True Then
                Me.UseWaitCursor = False
            End If

        ElseIf status = ResultCode.Failed Then
            resultStatus = "Failed"
        End If
    End Sub

    Private Sub DialogUserProfile_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Me.Text = "Perbaharui Data" Then
            BackgroundWorker1.RunWorkerAsync()
            MetroButton1.Visible = True
        Else
            MetroButton1.Visible = False
        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        FindUserData(finduser)

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        GetFullData(finduser)
    End Sub

    Private Sub MetroButton3_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        With UserPicFileDialog
            .FileName = ""
            .Multiselect = False
            .Title = "Picture Image"
            .Filter = ("JPEGs|*.jpg")
            .ShowDialog()
        End With
    End Sub

    Private Sub UserPicFileDialog_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles UserPicFileDialog.FileOk
        If e.Cancel = False Then
            Dim fileName As New FileInfo(UserPicFileDialog.FileName)
            PictureBox1.Image = Image.FromFile(UserPicFileDialog.FileName)
        End If
    End Sub

    Private Sub MetroButton2_Click_1(sender As System.Object, e As System.EventArgs) Handles MetroButton2.Click
        If MetroTextBox2.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input Username", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MetroTextBox2.Focus()
            Exit Sub
        End If

        If MetroTextBox3.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input Password", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MetroTextBox3.Focus()
            Exit Sub
        End If

        If NameTextBox.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input Nama Lengkap", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            NameTextBox.Focus()
            Exit Sub
        End If

        If EmailTextBox.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input Email", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            EmailTextBox.Focus()
            Exit Sub
        End If

        Dim saveData As New DatabaseConnection
        With saveData
            If UserPicFileDialog.FileName.Length > 0 Then
                .WithUpload = True
                .UploadFile = UserPicFileDialog.FileName
            Else
                .WithUpload = False
            End If
            .Query = "INSERT INTO users (user, pass, email, full_name, is_admin, user_verified, filename) VALUES " + _
                "('" & MetroTextBox2.Text & "', '" & MetroTextBox3.Text & "', " + _
                "'" & EmailTextBox.Text & "', '" & NameTextBox.Text & "', '" & CheckBox2.Checked.ToString & "', '" & CheckBox3.Checked.ToString & "', '" & UserPicFileDialog.FileName & "'); " + _
                "SELECT * FROM users WHERE id = LAST_INSERT_ID();"

            .tableName = "users"
            .objectSender = Me
        End With
        saveData.ShowDialog()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        With KtpFileDialog
            .FileName = ""
            .Multiselect = False
            .Title = "Picture Image"
            .Filter = ("JPEGs|*.jpg")
            .ShowDialog()
        End With
    End Sub

    Private Sub KtpFileDialog_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles KtpFileDialog.FileOk
        If e.Cancel = False Then
            Dim fileName As New FileInfo(KtpFileDialog.FileName)
            PictureBox2.Image = Image.FromFile(KtpFileDialog.FileName)
            PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub MetroTextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles MetroTextBox1.TextChanged
        
    End Sub

    Private Sub MetroButton3_Click_1(sender As System.Object, e As System.EventArgs) Handles MetroButton3.Click
        If MetroTextBox2.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input Username", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MetroTextBox2.Focus()
            Exit Sub
        End If

        If MetroTextBox3.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input Password", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MetroTextBox3.Focus()
            Exit Sub
        End If

        If NameTextBox.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input Nama Lengkap", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            NameTextBox.Focus()
            Exit Sub
        End If

        If EmailTextBox.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input Email", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            EmailTextBox.Focus()
            Exit Sub
        End If
        senduserData = True
        Dim saveData As New DatabaseConnection
        With saveData
            If UserPicFileDialog.FileName.Length > 0 Then
                Dim filePath As New FileInfo(UserPicFileDialog.FileName)
                .WithUpload = True
                .UploadFile = UserPicFileDialog.FileName
                .UploadUrl = Globals.UploadUserImg
                .Query = "UPDATE users SET " + _
                "user='" & MetroTextBox2.Text & "',  " + _
                "pass='" & MetroTextBox3.Text & "',  " + _
                "email='" & EmailTextBox.Text & "',  " + _
                "full_name='" & NameTextBox.Text & "',  " + _
                "is_admin='" & CheckBox2.Checked.ToString & "',  " + _
                "filename='" & filePath.Name & "',  " + _
                "user_verified='" & CheckBox3.Checked.ToString & "'  " + _
                "WHERE (id='" & MetroTextBox1.Text & "');"
            Else
                .WithUpload = False
                .Query = "UPDATE users SET " + _
                "user='" & MetroTextBox2.Text & "',  " + _
                "pass='" & MetroTextBox3.Text & "',  " + _
                "email='" & EmailTextBox.Text & "',  " + _
                "full_name='" & NameTextBox.Text & "',  " + _
                "is_admin='" & CheckBox2.Checked.ToString & "',  " + _
                "user_verified='" & CheckBox3.Checked.ToString & "'  " + _
                "WHERE (id='" & MetroTextBox1.Text & "');"

            End If
            .tableName = "users"
            .objectSender = Me
        End With
        saveData.ShowDialog()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub


    Private Sub CheckBox2_Click(sender As System.Object, e As System.EventArgs) Handles CheckBox2.Click
        Dim quesDialog As New DialogPerifikasi
        quesDialog.ShowDialog()
        If quesDialog.DialogResult = Windows.Forms.DialogResult.OK Then
            CheckBox2.Checked = True
        Else
            CheckBox2.Checked = False
        End If
    End Sub

    Private Sub MetroButton1_Click(sender As System.Object, e As System.EventArgs) Handles MetroButton1.Click
        Dim saveData As New DatabaseConnection
        With saveData
            .WithUpload = False
            .Query = "UPDATE users SET isdeleted='true'" + _
            "WHERE (id='" & MetroTextBox1.Text & "');"
            .tableName = "users"
            .objectSender = Me
        End With
        saveData.ShowDialog()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub NikTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles NikTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged

    End Sub
End Class
