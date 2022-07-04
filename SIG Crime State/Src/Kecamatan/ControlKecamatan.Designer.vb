<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlKecamatan
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelFilter = New MetroFramework.Controls.MetroPanel()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.SigDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SigDataSet = New SIG_Crime_State.SigDataSet()
        Me.KecamatanIdDataGridView = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KecamatanNameDataGridView = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KecamatanAlamatDataGridView = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KecamatanMaplatDataGridView = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KecamatanMaplongDataGridView = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.filename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KecamatanLastupdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KecamatanAction = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PanelFilter.SuspendLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SigDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SigDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelFilter
        '
        Me.PanelFilter.Controls.Add(Me.MetroButton3)
        Me.PanelFilter.Controls.Add(Me.MetroButton2)
        Me.PanelFilter.Controls.Add(Me.MetroButton1)
        Me.PanelFilter.Controls.Add(Me.MetroTextBox1)
        Me.PanelFilter.Controls.Add(Me.MetroLabel1)
        Me.PanelFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFilter.HorizontalScrollbarBarColor = True
        Me.PanelFilter.HorizontalScrollbarHighlightOnWheel = False
        Me.PanelFilter.HorizontalScrollbarSize = 12
        Me.PanelFilter.Location = New System.Drawing.Point(0, 0)
        Me.PanelFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelFilter.Name = "PanelFilter"
        Me.PanelFilter.Size = New System.Drawing.Size(1249, 52)
        Me.PanelFilter.Style = MetroFramework.MetroColorStyle.Silver
        Me.PanelFilter.TabIndex = 9
        Me.PanelFilter.VerticalScrollbarBarColor = True
        Me.PanelFilter.VerticalScrollbarHighlightOnWheel = False
        Me.PanelFilter.VerticalScrollbarSize = 13
        '
        'MetroButton3
        '
        Me.MetroButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton3.Location = New System.Drawing.Point(1037, 12)
        Me.MetroButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(100, 28)
        Me.MetroButton3.TabIndex = 6
        Me.MetroButton3.TabStop = False
        Me.MetroButton3.Text = "Refresh"
        Me.MetroButton3.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton2.Location = New System.Drawing.Point(1145, 12)
        Me.MetroButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(100, 28)
        Me.MetroButton2.TabIndex = 5
        Me.MetroButton2.Text = "Tambah"
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(488, 12)
        Me.MetroButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(100, 28)
        Me.MetroButton1.TabIndex = 4
        Me.MetroButton1.Text = "Cari"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(398, 2)
        Me.MetroTextBox1.CustomButton.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(56, 12)
        Me.MetroTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.PromptText = "Cari"
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.ShortcutsEnabled = True
        Me.MetroTextBox1.Size = New System.Drawing.Size(424, 28)
        Me.MetroTextBox1.TabIndex = 3
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMark = "Cari"
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(4, 12)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(33, 20)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Cari"
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToAddRows = False
        Me.MetroGrid1.AllowUserToDeleteRows = False
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.AutoGenerateColumns = False
        Me.MetroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MetroGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KecamatanIdDataGridView, Me.KecamatanNameDataGridView, Me.KecamatanAlamatDataGridView, Me.KecamatanMaplatDataGridView, Me.KecamatanMaplongDataGridView, Me.filename, Me.KecamatanLastupdate, Me.KecamatanAction})
        Me.MetroGrid1.DataMember = "kecamatan"
        Me.MetroGrid1.DataSource = Me.SigDataSetBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle4
        Me.MetroGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(0, 52)
        Me.MetroGrid1.Margin = New System.Windows.Forms.Padding(4)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.ReadOnly = True
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.MetroGrid1.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(1249, 522)
        Me.MetroGrid1.TabIndex = 10
        '
        'SigDataSetBindingSource
        '
        Me.SigDataSetBindingSource.DataSource = Me.SigDataSet
        Me.SigDataSetBindingSource.Position = 0
        '
        'SigDataSet
        '
        Me.SigDataSet.DataSetName = "SigDataSet"
        Me.SigDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KecamatanIdDataGridView
        '
        Me.KecamatanIdDataGridView.DataPropertyName = "id"
        Me.KecamatanIdDataGridView.FillWeight = 20.0!
        Me.KecamatanIdDataGridView.HeaderText = "id"
        Me.KecamatanIdDataGridView.Name = "KecamatanIdDataGridView"
        Me.KecamatanIdDataGridView.ReadOnly = True
        Me.KecamatanIdDataGridView.Visible = False
        '
        'KecamatanNameDataGridView
        '
        Me.KecamatanNameDataGridView.DataPropertyName = "name"
        Me.KecamatanNameDataGridView.FillWeight = 40.0!
        Me.KecamatanNameDataGridView.HeaderText = "Kecamatan"
        Me.KecamatanNameDataGridView.Name = "KecamatanNameDataGridView"
        Me.KecamatanNameDataGridView.ReadOnly = True
        '
        'KecamatanAlamatDataGridView
        '
        Me.KecamatanAlamatDataGridView.DataPropertyName = "alamat"
        Me.KecamatanAlamatDataGridView.HeaderText = "Alamat"
        Me.KecamatanAlamatDataGridView.Name = "KecamatanAlamatDataGridView"
        Me.KecamatanAlamatDataGridView.ReadOnly = True
        '
        'KecamatanMaplatDataGridView
        '
        Me.KecamatanMaplatDataGridView.DataPropertyName = "map_lat"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.KecamatanMaplatDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.KecamatanMaplatDataGridView.FillWeight = 50.0!
        Me.KecamatanMaplatDataGridView.HeaderText = "Lat"
        Me.KecamatanMaplatDataGridView.Name = "KecamatanMaplatDataGridView"
        Me.KecamatanMaplatDataGridView.ReadOnly = True
        '
        'KecamatanMaplongDataGridView
        '
        Me.KecamatanMaplongDataGridView.DataPropertyName = "map_long"
        Me.KecamatanMaplongDataGridView.FillWeight = 50.0!
        Me.KecamatanMaplongDataGridView.HeaderText = "Long"
        Me.KecamatanMaplongDataGridView.Name = "KecamatanMaplongDataGridView"
        Me.KecamatanMaplongDataGridView.ReadOnly = True
        '
        'filename
        '
        Me.filename.DataPropertyName = "filename"
        Me.filename.HeaderText = "filename"
        Me.filename.Name = "filename"
        Me.filename.ReadOnly = True
        Me.filename.Visible = False
        '
        'KecamatanLastupdate
        '
        Me.KecamatanLastupdate.DataPropertyName = "last_update"
        Me.KecamatanLastupdate.FillWeight = 10.0!
        Me.KecamatanLastupdate.HeaderText = "last_update"
        Me.KecamatanLastupdate.Name = "KecamatanLastupdate"
        Me.KecamatanLastupdate.ReadOnly = True
        Me.KecamatanLastupdate.Visible = False
        '
        'KecamatanAction
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KecamatanAction.DefaultCellStyle = DataGridViewCellStyle3
        Me.KecamatanAction.FillWeight = 30.0!
        Me.KecamatanAction.HeaderText = "Action"
        Me.KecamatanAction.Name = "KecamatanAction"
        Me.KecamatanAction.ReadOnly = True
        Me.KecamatanAction.Text = "Edit"
        Me.KecamatanAction.UseColumnTextForButtonValue = True
        '
        'ControlKecamatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroGrid1)
        Me.Controls.Add(Me.PanelFilter)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ControlKecamatan"
        Me.Size = New System.Drawing.Size(1249, 574)
        Me.PanelFilter.ResumeLayout(False)
        Me.PanelFilter.PerformLayout()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SigDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SigDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelFilter As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents SigDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SigDataSet As SIG_Crime_State.SigDataSet
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents KecamatanIdDataGridView As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KecamatanNameDataGridView As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KecamatanAlamatDataGridView As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KecamatanMaplatDataGridView As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KecamatanMaplongDataGridView As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents filename As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KecamatanLastupdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KecamatanAction As System.Windows.Forms.DataGridViewButtonColumn

End Class
