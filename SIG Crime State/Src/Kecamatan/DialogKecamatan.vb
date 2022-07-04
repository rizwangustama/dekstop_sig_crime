Imports System.Windows.Forms
Imports System.IO

Public Class DialogKecamatan
    Implements IDbConnection

    Public FormSender As Object
    Public kmlName As String
    Public picture As String = ""

    Private Sub MetroButton2_Click(sender As System.Object, e As System.EventArgs) Handles MetroButton2.Click
        'INSERT INTO kecamatan (kecamatan, alamat, map_long, map_lang, geo_file,filename) VALUES 
        '('kecamatan', 'alaat', 'long', 'lang', 'geofile','filename')

        If MetroTextBox2.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input Nama Kecamatan", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MetroTextBox2.Focus()
            Exit Sub
        End If

        If MetroTextBox3.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input alamat kantor Kecamatan", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MetroTextBox3.Focus()
            Exit Sub
        End If

        If MetroTextBox4.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input latitude  Kecamatan", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MetroTextBox4.Focus()
            Exit Sub
        End If

        If MetroTextBox5.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input longitude Kecamatan", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MetroTextBox5.Focus()
            Exit Sub
        End If

        'If MetroTextBox6.Text.Length < 1 Then
        '    MessageBox.Show("Isi terlebih dahulu input geo file KML Kecamatan", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    MetroTextBox2.Focus()
        '    Exit Sub
        'End If
        Dim saveData As New DatabaseConnection
        With saveData
            If PictureFileDialog.FileName.Length < 1 Then
                .WithUpload = False
            Else
                .WithUpload = True
                Dim filepath As FileInfo = New FileInfo(PictureFileDialog.FileName)
                picture = filepath.Name
            End If


            .UploadFile = PictureFileDialog.FileName
            .UploadUrl = Globals.UploadKecamatanImg
            .Query = "INSERT INTO kecamatan (name, alamat, map_lat, map_long, geo_file,filename) VALUES " + _
                "('" & MetroTextBox2.Text & "', '" & MetroTextBox3.Text & "', '" & MetroTextBox4.Text & "', '" & MetroTextBox5.Text & "', '" & MetroTextBox6.Text & "', '" & picture & "'); SELECT * FROM kecamatan WHERE id = LAST_INSERT_ID()"
            .tableName = "kecamatan"
            .objectSender = Me
        End With
        saveData.ShowDialog()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        'Me.Close()
    End Sub

    Private Sub MetroButton3_Click(sender As System.Object, e As System.EventArgs) Handles MetroButton3.Click

        If MetroTextBox2.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input Nama Kecamatan", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MetroTextBox2.Focus()
            Exit Sub
        End If

        If MetroTextBox3.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input alamat kantor Kecamatan", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MetroTextBox3.Focus()
            Exit Sub
        End If

        If MetroTextBox4.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input latitude  Kecamatan", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MetroTextBox4.Focus()
            Exit Sub
        End If

        If MetroTextBox5.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input longitude Kecamatan", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MetroTextBox5.Focus()
            Exit Sub
        End If

        'UPDATE kecamatan SET name='dd1', alamat='dd1', map_long='01', map_lang='02', geo_file='dd11' WHERE (id='6')
        If MetroTextBox2.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input Nama Kecamatan", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MetroTextBox2.Focus()
            Exit Sub
        End If

        If MetroTextBox3.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input alamat kantor Kecamatan", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MetroTextBox2.Focus()
            Exit Sub
        End If

        If MetroTextBox4.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input latitude  Kecamatan", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MetroTextBox2.Focus()
            Exit Sub
        End If

        If MetroTextBox5.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input longitude Kecamatan", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MetroTextBox2.Focus()
            Exit Sub
        End If

        'If MetroTextBox6.Text.Length < 1 Then
        '    MessageBox.Show("Isi terlebih dahulu input geo file KML Kecamatan", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    MetroTextBox2.Focus()
        '    Exit Sub
        'End If

        Dim saveData As New DatabaseConnection
        With saveData
            If PictureFileDialog.FileName.Length > 1 Then
                saveData.WithUpload = True
                Dim filepath As FileInfo = New FileInfo(PictureFileDialog.FileName)
                picture = filepath.Name
                saveData.UploadFile = PictureFileDialog.FileName
                saveData.UploadUrl = Globals.UploadKecamatanImg
                .Query = "UPDATE kecamatan SET " + _
                "name='" & MetroTextBox2.Text & "',  " + _
                "alamat='" & MetroTextBox3.Text & "',  " + _
                "map_lat='" & MetroTextBox4.Text & "',  " + _
                "map_long='" & MetroTextBox5.Text & "',  " + _
                "geo_file='" & MetroTextBox6.Text & "',  " + _
                "filename='" & picture & "'  " + _
                "WHERE (id='" & MetroTextBox1.Text & "')"
            Else
                saveData.WithUpload = False
                .Query = "UPDATE kecamatan SET " + _
                "name='" & MetroTextBox2.Text & "',  " + _
                "alamat='" & MetroTextBox3.Text & "',  " + _
                "map_lat='" & MetroTextBox4.Text & "',  " + _
                "map_long='" & MetroTextBox5.Text & "',  " + _
                "geo_file='" & MetroTextBox6.Text & "'  " + _
                "WHERE (id='" & MetroTextBox1.Text & "')"
            End If

            .tableName = "kecamatan"
            .objectSender = Me
        End With
        saveData.ShowDialog()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub MetroButton4_Click(sender As System.Object, e As System.EventArgs) Handles MetroButton4.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub MetroButton1_Click(sender As System.Object, e As System.EventArgs) Handles MetroButton1.Click
        With OpenFileDialog
            .FileName = "Geo location"
            .Multiselect = False
            .Title = "Geo Location"
            .Filter = ("(KML Files)|*.kml")
            .ShowDialog()
        End With
    End Sub

    Private Sub OpenFileDialog_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog.FileOk
        If e.Cancel = False Then
            Dim fileName As New FileInfo(OpenFileDialog.FileName)
            MetroTextBox6.Text = fileName.Name
        End If
    End Sub

    Public Sub DatabaseResult(status As String, message As String, dt As SigDataSet) Implements Globals.IDbConnection.DatabaseResult
        If status = ResultCode.Success Then
            'CType(FormSender, ControlKecamatan).RefreshData()
            MsgBox("Data berhasil di simpan ke database", MsgBoxStyle.Information)
        Else
            MsgBox("Data gagal di simpan ke database", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub DialogKecamatan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If MetroTextBox7.Text.Length < 1 Then
            Me.MetroTextBox7.Text = Date.Now.ToString("yyyy-MM-dd hh:mm")
        End If
        If Not picture = "" Then
            Try
                PictureBox1.Load(Globals.kecPicUrl + picture)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        With PictureFileDialog
            .FileName = ""
            .Multiselect = False
            .Title = "Kecamatan Image"
            .Filter = ("JPEGs|*.png")
            .ShowDialog()
        End With
    End Sub

    Private Sub PictureFileDialog_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles PictureFileDialog.FileOk
        If e.Cancel = False Then
            Dim fileName As New FileInfo(PictureFileDialog.FileName)
            PictureBox1.Image = Image.FromFile(PictureFileDialog.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            picture = fileName.Name
        End If
    End Sub

    Private Sub MetroTextBox4_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MetroTextBox4.KeyPress
        If Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub MetroTextBox5_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MetroTextBox5.KeyPress
        If Asc(e.KeyChar) = 45 Or Asc(e.KeyChar) = 46 Then
            e.Handled = False
        Else
            If Asc(e.KeyChar) <> 8 Then
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub
End Class
