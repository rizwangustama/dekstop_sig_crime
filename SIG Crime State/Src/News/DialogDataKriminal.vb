Imports System.Windows.Forms
Imports System.IO

Public Class DialogDataKriminal
    Implements IDbConnection

    Public FormSender As Object
    Public docID As String

    Sub getData(ByVal id As String)
        Dim dbConn As New DatabaseConnection
        dbConn.Query = "SELECT * FROM kriminal WHERE id = '" & docID & "';"
        dbConn.tableName = "kriminal"
        dbConn.objectSender = Me
        dbConn.ShowDialog()
    End Sub

    Sub getDataUser(ByVal userID As String)
        Dim dbConn As New DatabaseConnection
        dbConn.Query = "SELECT * FROM users WHERE id = '" & userID & "';"
        dbConn.tableName = "users"
        dbConn.objectSender = Me
        dbConn.ShowDialog()
    End Sub


    Sub getLampiran(ByVal id As String)
        Dim dbConn As New DatabaseConnection
        dbConn.Query = "SELECT * FROM lampiran WHERE kriminal_id = '" & id & "';"
        dbConn.tableName = "lampiran"
        dbConn.objectSender = Me
        dbConn.ShowDialog()
    End Sub

    Sub GetDataKlasifikasiKriminal()
        Dim dbConn As New DatabaseConnection
        dbConn.Query = "SELECT * FROM klasifikasi_kriminal"
        dbConn.tableName = "klasifikasikriminal"
        dbConn.objectSender = Me
        dbConn.ShowDialog()
    End Sub

    Sub getDataKecamatan()
        Dim dbConn As New DatabaseConnection
        dbConn.Query = "SELECT * FROM kecamatan"
        dbConn.tableName = "kecamatan"
        dbConn.objectSender = Me
        dbConn.ShowDialog()
    End Sub



    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub DatabaseResult(ByVal status As String, ByVal message As String, ByVal dt As SigDataSet) Implements Globals.IDbConnection.DatabaseResult

        If dt.Tables("klasifikasikriminal").Rows.Count > 0 Then
            Try
                Me.ComboBox1.Items.Clear()
                Me.ComboBox1.DataSource = dt.Tables("klasifikasikriminal")
                Me.ComboBox1.DisplayMember = "name"
                Me.ComboBox1.ValueMember = "id"
                getDataKecamatan()
            Catch ex As Exception

            End Try
        End If

        If dt.Tables("kecamatan").Rows.Count > 0 Then
            Try
                Me.ComboBox2.Items.Clear()
                Me.ComboBox2.DataSource = dt.Tables("kecamatan")
                Me.ComboBox2.DisplayMember = "name"
                Me.ComboBox2.ValueMember = "id"
                If docID.Length > 0 Then
                    getData(docID)
                End If
            Catch ex As Exception

            End Try
        End If

        If dt.Tables("kriminal").Rows.Count > 0 Then
            SigDataSet = dt
            TextBox_judul.DataBindings.Clear()
            TextBox_judul.DataBindings.Add("Text", Me.SigDataSet.Tables("kriminal"), "title", True)
            IdTextBox.DataBindings.Clear()
            IdTextBox.DataBindings.Add("Text", Me.SigDataSet.Tables("kriminal"), "id", True)
            Id_kecamatanTextBox.DataBindings.Clear()
            Id_kecamatanTextBox.DataBindings.Add("Text", Me.SigDataSet.Tables("kriminal"), "id_kecamatan", True)
            Id_klassifikasi_kriminalTextBox.DataBindings.Clear()
            Id_klassifikasi_kriminalTextBox.DataBindings.Add("Text", Me.SigDataSet.Tables("kriminal"), "id_klassifikasi_kriminal", True)
            Kasus_kriminalTextBox.DataBindings.Clear()
            Kasus_kriminalTextBox.DataBindings.Add("Text", Me.SigDataSet.Tables("kriminal"), "kasus_kriminal", True)

            Tanggal_kejadianDateTimePicker.DataBindings.Clear()
            Tanggal_kejadianDateTimePicker.DataBindings.Add("Value", Me.SigDataSet.Tables("kriminal"), "tanggal_kejadian", True)

            WaktuKejadianDateTimePicker.DataBindings.Clear()
            WaktuKejadianDateTimePicker.DataBindings.Add("Value", Me.SigDataSet.Tables("kriminal"), "waktu_kejadian", True)

            AlamatTextBox.DataBindings.Clear()
            AlamatTextBox.DataBindings.Add("Text", Me.SigDataSet.Tables("kriminal"), "alamat", True)

            Map_latTextBox.DataBindings.Clear()
            Map_latTextBox.DataBindings.Add("Text", Me.SigDataSet.Tables("kriminal"), "map_lat", True)


            Map_langTextBox.DataBindings.Clear()
            Map_langTextBox.DataBindings.Add("Text", Me.SigDataSet.Tables("kriminal"), "map_lang", True)

            Is_verifiedCheckBox.DataBindings.Clear()
            Is_verifiedCheckBox.DataBindings.Add("Checked", Me.SigDataSet.Tables("kriminal"), "is_verified", True)

            Try
                For Each comboItem As DataRowView In ComboBox2.Items
                    If comboItem.Item(0).ToString.Contains(Id_kecamatanTextBox.Text) Then
                        ComboBox2.SelectedValue = comboItem.Item(0)
                        Exit For
                    End If
                Next

                For Each comboItem As DataRowView In ComboBox1.Items
                    If comboItem.Item(0).ToString.Contains(Id_klassifikasi_kriminalTextBox.Text) Then
                        ComboBox1.SelectedValue = comboItem.Item(0)
                        Exit For
                    End If
                Next
            Catch ex As Exception

            End Try
        End If

        If dt.Tables("lampiran").Rows.Count > 0 Then
            MetroGrid1.DataBindings.Clear()
            Me.SigDataSet = dt
            MetroGrid1.DataSource = Me.SigDataSet
            MetroGrid1.DataMember = "lampiran"
            MetroGrid1.Refresh()
        End If

        If dt.Tables("users").Rows.Count > 0 Then
            Create_byTextBox.Text = dt.Tables("users").Rows(0).Item(4).ToString
        End If
    End Sub

    Private Sub DialogDataKriminal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetDataKlasifikasiKriminal()
        If Me.Text = "Tambah Data" Then
            Create_byTextBox.Text = userLogin
            MetroButton1.Visible = False
        Else
            getData(docID)
            MetroButton1.Visible = True
        End If
    End Sub

    Private Sub MetroButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton2.Click
        'INSERT INTO kriminal (id_kecamatan, id_klassifikasi_kriminal, kasus_kriminal, tanggal_kejadian, waktu_kejadian, alamat, map_lat, map_lang, create_by, created, is_verified) VALUES 
        '('1', '1', '1', '2022-05-26', '06:26:59', '1', '1', '1', '1', '2022-05-26 06:27:08', 'False')
        If Id_kecamatanTextBox.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input Kecamatan", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Id_kecamatanTextBox.Focus()
            Exit Sub
        End If

        If Id_klassifikasi_kriminalTextBox.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input Klasifikasi Kriminal", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Id_klassifikasi_kriminalTextBox.Focus()
            Exit Sub
        End If

        If Kasus_kriminalTextBox.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input Kasus Kriminal", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Kasus_kriminalTextBox.Focus()
            Exit Sub
        End If

        Dim saveData As New DatabaseConnection
        With saveData
            .WithUpload = False
            .Query = "INSERT INTO kriminal (id_kecamatan, title, id_klassifikasi_kriminal, kasus_kriminal, tanggal_kejadian, waktu_kejadian, alamat, map_lat, map_lang, create_by, created, is_verified) VALUES " + _
                "('" & Id_kecamatanTextBox.Text & "', " + _
                 "'" & TextBox_judul.Text & "', " + _
                "'" & Id_klassifikasi_kriminalTextBox.Text & "', " + _
                "'" & Kasus_kriminalTextBox.Text & "', " + _
                "'" & Tanggal_kejadianDateTimePicker.Value.ToString("yyyy-MM-dd") & "', " + _
                "'" & WaktuKejadianDateTimePicker.Value.ToString("HH:mm:ss") & "', " + _
                "'" & AlamatTextBox.Text & "', " + _
                "'" & Map_latTextBox.Text & "', " + _
                "'" & Map_langTextBox.Text & "', " + _
                "'" & userLogin & "', " + _
                "'" & DateTime.Now.ToString("yyyy-MM-dd") & "', " + _
                "'" & Is_verifiedCheckBox.Checked.ToString & "'); SELECT * FROM kriminal WHERE id = LAST_INSERT_ID();"
            .tableName = "kriminal"
            .objectSender = Me
        End With
        saveData.ShowDialog()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Not IsNothing(ComboBox1.SelectedValue) Then
            Dim drow As DataRowView
            drow = ComboBox1.SelectedItem
            Id_klassifikasi_kriminalTextBox.Text = drow.Item(0).ToString
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If Not IsNothing(ComboBox2.SelectedValue) Then
            Dim drow As DataRowView
            drow = ComboBox2.SelectedItem
            Id_kecamatanTextBox.Text = drow.Item(0).ToString
        End If
    End Sub

    Private Sub MetroButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton3.Click
        'UPDATE kriminal SET kasus_kriminal='Pencurian1', alamat='Sukabumi1', map_lat='121', map_lang='121', is_verified='True' WHERE (id='3')
        If Id_kecamatanTextBox.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input Kecamatan", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Id_kecamatanTextBox.Focus()
            Exit Sub
        End If

        If Id_klassifikasi_kriminalTextBox.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input Klasifikasi Kriminal", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Id_klassifikasi_kriminalTextBox.Focus()
            Exit Sub
        End If

        If Kasus_kriminalTextBox.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input Kasus Kriminal", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Kasus_kriminalTextBox.Focus()
            Exit Sub
        End If
        Dim saveData As New DatabaseConnection
        saveData.WithUpload = False
        With saveData
            .Query = "UPDATE kriminal SET " + _
                 "id_kecamatan='" & Id_kecamatanTextBox.Text & "',  " + _
                "id_klassifikasi_kriminal='" & Id_klassifikasi_kriminalTextBox.Text & "',  " + _
                "kasus_kriminal='" & Kasus_kriminalTextBox.Text & "',  " + _
                "alamat='" & AlamatTextBox.Text & "',  " + _
                "map_lat='" & Map_latTextBox.Text & "',  " + _
                "map_lang='" & Map_langTextBox.Text & "',  " + _
                "title='" & TextBox_judul.Text & "',  " + _
                "is_verified='" & Is_verifiedCheckBox.Checked.ToString & "'  " + _
                "WHERE (id='" & IdTextBox.Text & "')"
            .tableName = "kriminal"
            .objectSender = Me
        End With
        saveData.ShowDialog()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub IdTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdTextBox.TextChanged
        If IdTextBox.TextLength > 0 Then
            Try
                getDataUser(SigDataSet.Tables("kriminal").Rows(0).Item(10))
                getLampiran(IdTextBox.Text)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim saveData As New DatabaseConnection
            Dim fileName As New FileInfo(OpenFileDialog1.FileName)
            With saveData
                .WithUpload = True
                .UploadFile = OpenFileDialog1.FileName
                .UploadUrl = UploadAssets
                .Query = "INSERT INTO lampiran (kriminal_id, filename) VALUES ('" & IdTextBox.Text & "', '" & fileName.Name & "'); SELECT * FROM lampiran WHERE id = LAST_INSERT_ID()"
                .tableName = "lampiran"
                .objectSender = Me
            End With
            saveData.ShowDialog()
            If saveData.DialogResult = Windows.Forms.DialogResult.Abort Then
                getLampiran(IdTextBox.Text)
            End If
        End If
    End Sub

    Private Sub MetroGrid1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso
            e.RowIndex >= 0 Then

            If e.ColumnIndex = 3 Then
                Dim saveData As New DatabaseConnection
                With saveData
                    .WithUpload = False
                    .Query = "DELETE FROM lampiran WHERE (id='" & MetroGrid1.Rows(e.RowIndex).Cells(0).Value & "');SELECT * FROM lampiran WHERE kriminal_id = '" & IdTextBox.TextLength & "';"
                    .tableName = "lampiran"
                    .objectSender = Me
                End With
                saveData.ShowDialog()
                If saveData.DialogResult = Windows.Forms.DialogResult.Abort Then
                    getLampiran(IdTextBox.Text)
                End If
            End If

            If e.ColumnIndex = 2 Then
                MsgBox("download image")
            End If
        End If
    End Sub

    Private Sub Map_latTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Map_latTextBox.KeyPress
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

    Private Sub Map_langTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Map_langTextBox.KeyPress
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
