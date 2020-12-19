<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateKB
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SirkusIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JudulDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SinopsisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VideoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PosterDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.SirkusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SirkusdbDataSet = New TugasKelompokVB.sirkusdbDataSet()
        Me.SirkusTableAdapter = New TugasKelompokVB.sirkusdbDataSetTableAdapters.sirkusTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DetailsirkusIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SirkusIdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeteranganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GambarDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DetailsirkusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Detail_sirkusTableAdapter = New TugasKelompokVB.sirkusdbDataSetTableAdapters.detail_sirkusTableAdapter()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.WaktusirkusIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SirkusIdDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JamMulaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JamSelesaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HariDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaktusirkusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Waktu_sirkusTableAdapter = New TugasKelompokVB.sirkusdbDataSetTableAdapters.waktu_sirkusTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SirkusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SirkusdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailsirkusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaktusirkusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SirkusIdDataGridViewTextBoxColumn, Me.JudulDataGridViewTextBoxColumn, Me.SinopsisDataGridViewTextBoxColumn, Me.VideoDataGridViewTextBoxColumn, Me.PosterDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.SirkusBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(2, -1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(648, 177)
        Me.DataGridView1.TabIndex = 0
        '
        'SirkusIdDataGridViewTextBoxColumn
        '
        Me.SirkusIdDataGridViewTextBoxColumn.DataPropertyName = "sirkusId"
        Me.SirkusIdDataGridViewTextBoxColumn.HeaderText = "sirkusId"
        Me.SirkusIdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SirkusIdDataGridViewTextBoxColumn.Name = "SirkusIdDataGridViewTextBoxColumn"
        Me.SirkusIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JudulDataGridViewTextBoxColumn
        '
        Me.JudulDataGridViewTextBoxColumn.DataPropertyName = "judul"
        Me.JudulDataGridViewTextBoxColumn.HeaderText = "judul"
        Me.JudulDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.JudulDataGridViewTextBoxColumn.Name = "JudulDataGridViewTextBoxColumn"
        '
        'SinopsisDataGridViewTextBoxColumn
        '
        Me.SinopsisDataGridViewTextBoxColumn.DataPropertyName = "sinopsis"
        Me.SinopsisDataGridViewTextBoxColumn.HeaderText = "sinopsis"
        Me.SinopsisDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SinopsisDataGridViewTextBoxColumn.Name = "SinopsisDataGridViewTextBoxColumn"
        '
        'VideoDataGridViewTextBoxColumn
        '
        Me.VideoDataGridViewTextBoxColumn.DataPropertyName = "video"
        Me.VideoDataGridViewTextBoxColumn.HeaderText = "video"
        Me.VideoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.VideoDataGridViewTextBoxColumn.Name = "VideoDataGridViewTextBoxColumn"
        '
        'PosterDataGridViewImageColumn
        '
        Me.PosterDataGridViewImageColumn.DataPropertyName = "poster"
        Me.PosterDataGridViewImageColumn.HeaderText = "poster"
        Me.PosterDataGridViewImageColumn.MinimumWidth = 8
        Me.PosterDataGridViewImageColumn.Name = "PosterDataGridViewImageColumn"
        '
        'SirkusBindingSource
        '
        Me.SirkusBindingSource.DataMember = "sirkus"
        Me.SirkusBindingSource.DataSource = Me.SirkusdbDataSet
        '
        'SirkusdbDataSet
        '
        Me.SirkusdbDataSet.DataSetName = "sirkusdbDataSet"
        Me.SirkusdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SirkusTableAdapter
        '
        Me.SirkusTableAdapter.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DetailsirkusIdDataGridViewTextBoxColumn, Me.SirkusIdDataGridViewTextBoxColumn1, Me.KeteranganDataGridViewTextBoxColumn, Me.GambarDataGridViewImageColumn})
        Me.DataGridView2.DataSource = Me.DetailsirkusBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(656, -1)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(646, 177)
        Me.DataGridView2.TabIndex = 1
        '
        'DetailsirkusIdDataGridViewTextBoxColumn
        '
        Me.DetailsirkusIdDataGridViewTextBoxColumn.DataPropertyName = "detail_sirkusId"
        Me.DetailsirkusIdDataGridViewTextBoxColumn.HeaderText = "detail_sirkusId"
        Me.DetailsirkusIdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DetailsirkusIdDataGridViewTextBoxColumn.Name = "DetailsirkusIdDataGridViewTextBoxColumn"
        Me.DetailsirkusIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SirkusIdDataGridViewTextBoxColumn1
        '
        Me.SirkusIdDataGridViewTextBoxColumn1.DataPropertyName = "sirkusId"
        Me.SirkusIdDataGridViewTextBoxColumn1.HeaderText = "sirkusId"
        Me.SirkusIdDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.SirkusIdDataGridViewTextBoxColumn1.Name = "SirkusIdDataGridViewTextBoxColumn1"
        '
        'KeteranganDataGridViewTextBoxColumn
        '
        Me.KeteranganDataGridViewTextBoxColumn.DataPropertyName = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.HeaderText = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.KeteranganDataGridViewTextBoxColumn.Name = "KeteranganDataGridViewTextBoxColumn"
        '
        'GambarDataGridViewImageColumn
        '
        Me.GambarDataGridViewImageColumn.DataPropertyName = "gambar"
        Me.GambarDataGridViewImageColumn.HeaderText = "gambar"
        Me.GambarDataGridViewImageColumn.MinimumWidth = 8
        Me.GambarDataGridViewImageColumn.Name = "GambarDataGridViewImageColumn"
        '
        'DetailsirkusBindingSource
        '
        Me.DetailsirkusBindingSource.DataMember = "detail_sirkus"
        Me.DetailsirkusBindingSource.DataSource = Me.SirkusdbDataSet
        '
        'Detail_sirkusTableAdapter
        '
        Me.Detail_sirkusTableAdapter.ClearBeforeFill = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WaktusirkusIdDataGridViewTextBoxColumn, Me.SirkusIdDataGridViewTextBoxColumn2, Me.JamMulaiDataGridViewTextBoxColumn, Me.JamSelesaiDataGridViewTextBoxColumn, Me.HariDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.WaktusirkusBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(302, 182)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 62
        Me.DataGridView3.RowTemplate.Height = 28
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(725, 174)
        Me.DataGridView3.TabIndex = 2
        '
        'WaktusirkusIdDataGridViewTextBoxColumn
        '
        Me.WaktusirkusIdDataGridViewTextBoxColumn.DataPropertyName = "waktu_sirkusId"
        Me.WaktusirkusIdDataGridViewTextBoxColumn.HeaderText = "waktu_sirkusId"
        Me.WaktusirkusIdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.WaktusirkusIdDataGridViewTextBoxColumn.Name = "WaktusirkusIdDataGridViewTextBoxColumn"
        Me.WaktusirkusIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SirkusIdDataGridViewTextBoxColumn2
        '
        Me.SirkusIdDataGridViewTextBoxColumn2.DataPropertyName = "sirkusId"
        Me.SirkusIdDataGridViewTextBoxColumn2.HeaderText = "sirkusId"
        Me.SirkusIdDataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.SirkusIdDataGridViewTextBoxColumn2.Name = "SirkusIdDataGridViewTextBoxColumn2"
        '
        'JamMulaiDataGridViewTextBoxColumn
        '
        Me.JamMulaiDataGridViewTextBoxColumn.DataPropertyName = "jamMulai"
        Me.JamMulaiDataGridViewTextBoxColumn.HeaderText = "jamMulai"
        Me.JamMulaiDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.JamMulaiDataGridViewTextBoxColumn.Name = "JamMulaiDataGridViewTextBoxColumn"
        '
        'JamSelesaiDataGridViewTextBoxColumn
        '
        Me.JamSelesaiDataGridViewTextBoxColumn.DataPropertyName = "jamSelesai"
        Me.JamSelesaiDataGridViewTextBoxColumn.HeaderText = "jamSelesai"
        Me.JamSelesaiDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.JamSelesaiDataGridViewTextBoxColumn.Name = "JamSelesaiDataGridViewTextBoxColumn"
        '
        'HariDataGridViewTextBoxColumn
        '
        Me.HariDataGridViewTextBoxColumn.DataPropertyName = "hari"
        Me.HariDataGridViewTextBoxColumn.HeaderText = "hari"
        Me.HariDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.HariDataGridViewTextBoxColumn.Name = "HariDataGridViewTextBoxColumn"
        '
        'WaktusirkusBindingSource
        '
        Me.WaktusirkusBindingSource.DataMember = "waktu_sirkus"
        Me.WaktusirkusBindingSource.DataSource = Me.SirkusdbDataSet
        '
        'Waktu_sirkusTableAdapter
        '
        Me.Waktu_sirkusTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 362)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 374)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tabel Sirkus"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(233, 327)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 37)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "DELETE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(120, 327)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 37)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "EDIT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(10, 327)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 37)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "ADD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(233, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 37)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Pilih"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(85, 194)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 116)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Poster:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(85, 162)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(227, 26)
        Me.TextBox3.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Video:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(85, 68)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(227, 89)
        Me.TextBox2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Sinopsis:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(85, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(227, 26)
        Me.TextBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Judul:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(492, 362)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 224)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tabel Waktu Sirkus"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(105, 136)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(227, 26)
        Me.TextBox7.TabIndex = 15
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(233, 172)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(99, 37)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "DELETE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(120, 172)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(99, 37)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "EDIT"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(10, 172)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(99, 37)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "ADD"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Hari:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(105, 104)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(227, 26)
        Me.TextBox4.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Jam Selesai:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(105, 72)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(227, 26)
        Me.TextBox5.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Jam Mulai:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(105, 39)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(227, 26)
        Me.TextBox6.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Sirkus ID:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.Button10)
        Me.GroupBox3.Controls.Add(Me.Button11)
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TextBox9)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.TextBox10)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(943, 362)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(348, 341)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tabel Detail Sirkus"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(243, 287)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(99, 37)
        Me.Button8.TabIndex = 14
        Me.Button8.Text = "DELETE"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(130, 287)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(99, 37)
        Me.Button9.TabIndex = 13
        Me.Button9.Text = "EDIT"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(20, 287)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(99, 37)
        Me.Button10.TabIndex = 12
        Me.Button10.Text = "ADD"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(252, 244)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(80, 37)
        Me.Button11.TabIndex = 11
        Me.Button11.Text = "Pilih"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(105, 165)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(141, 116)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Gambar:"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(104, 65)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(227, 89)
        Me.TextBox9.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 20)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Keterangan:"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(104, 34)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(227, 26)
        Me.TextBox10.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Sirkus ID:"
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(612, 635)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(99, 37)
        Me.Button12.TabIndex = 16
        Me.Button12.Text = "BACK"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'UpdateKB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1303, 777)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "UpdateKB"
        Me.Text = "UpdateKB"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SirkusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SirkusdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailsirkusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaktusirkusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SirkusdbDataSet As sirkusdbDataSet
    Friend WithEvents SirkusBindingSource As BindingSource
    Friend WithEvents SirkusTableAdapter As sirkusdbDataSetTableAdapters.sirkusTableAdapter
    Friend WithEvents SirkusIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JudulDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SinopsisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VideoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PosterDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DetailsirkusBindingSource As BindingSource
    Friend WithEvents Detail_sirkusTableAdapter As sirkusdbDataSetTableAdapters.detail_sirkusTableAdapter
    Friend WithEvents DetailsirkusIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SirkusIdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents KeteranganDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GambarDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents WaktusirkusBindingSource As BindingSource
    Friend WithEvents Waktu_sirkusTableAdapter As sirkusdbDataSetTableAdapters.waktu_sirkusTableAdapter
    Friend WithEvents WaktusirkusIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SirkusIdDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents JamMulaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JamSelesaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HariDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
End Class
