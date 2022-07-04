Imports System.Windows.Forms

Public Class DialogKlasifikasiKecamatan
    Implements IDbConnection


    Public FormSender As Object

    Public Sub DatabaseResult(status As String, message As String, dt As SigDataSet) Implements Globals.IDbConnection.DatabaseResult

    End Sub

    Private Sub MetroButton2_Click(sender As System.Object, e As System.EventArgs) Handles MetroButton2.Click
        'INSERT INTO `klasifikasi_kriminal` (`klasifikasi_kriminal`, `desc`) VALUES ('Perkelahian', 'Perkelahian')

        If MetroTextBox2.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input Nama Klasifikasi Kriminal", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MetroTextBox2.Focus()
            Exit Sub
        End If

        If MetroTextBox3.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input Deskripsi Klasifikasi Kriminal", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MetroTextBox2.Focus()
            Exit Sub
        End If

        Dim saveData As New DatabaseConnection
        With saveData
            .WithUpload = False
            .Query = "INSERT INTO klasifikasi_kriminal (klasifikasi_kriminal.name, klasifikasi_kriminal.desc) VALUES " + _
                "('" & MetroTextBox2.Text & "', '" & MetroTextBox3.Text & "'); SELECT * FROM klasifikasi_kriminal WHERE id = LAST_INSERT_ID();"
            .tableName = "klasifikasi_kriminal"
            .objectSender = Me
        End With
        saveData.ShowDialog()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub MetroButton3_Click(sender As System.Object, e As System.EventArgs) Handles MetroButton3.Click
        If MetroTextBox2.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input Nama Klasifikasi Kriminal", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MetroTextBox2.Focus()
            Exit Sub
        End If

        If MetroTextBox3.Text.Length < 1 Then
            MessageBox.Show("Isi terlebih dahulu input Deskripsi Klasifikasi Kriminal", "Input tidak boleh kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MetroTextBox2.Focus()
            Exit Sub
        End If


        Dim saveData As New DatabaseConnection
        saveData.WithUpload = False
        With saveData
            .Query = "UPDATE klasifikasi_kriminal SET " + _
                "klasifikasi_kriminal.name='" & MetroTextBox2.Text & "',  " + _
                "klasifikasi_kriminal.desc='" & MetroTextBox3.Text & "' " + _
                "WHERE (id='" & MetroTextBox1.Text & "')"
            .tableName = "klasifikasi_kriminal"
            .objectSender = Me
        End With
        saveData.ShowDialog()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub DialogKlasifikasiKecamatan_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If MetroTextBox4.Text.Length < 1 Then
            Me.MetroTextBox4.Text = Date.Now.ToString("yyyy-MM-dd hh:mm")
        End If
    End Sub

    Private Sub MetroButton4_Click(sender As System.Object, e As System.EventArgs) Handles MetroButton4.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
