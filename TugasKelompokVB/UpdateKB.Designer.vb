<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateKB
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SirkusIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JudulDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SinopsisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PosterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VideoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SirkusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SirkusdbDataSet1 = New TugasKelompokVB.sirkusdbDataSet1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SirkusTableAdapter = New TugasKelompokVB.sirkusdbDataSet1TableAdapters.sirkusTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.WaktusirkusIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SirkusIdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JamMulaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JamSelesaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaktusirkusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Waktu_sirkusTableAdapter = New TugasKelompokVB.sirkusdbDataSet1TableAdapters.waktu_sirkusTableAdapter()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DetailsirkusIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SirkusIdDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GambarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeteranganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailsirkusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Detail_sirkusTableAdapter = New TugasKelompokVB.sirkusdbDataSet1TableAdapters.detail_sirkusTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SirkusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SirkusdbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaktusirkusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailsirkusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SirkusIdDataGridViewTextBoxColumn, Me.JudulDataGridViewTextBoxColumn, Me.SinopsisDataGridViewTextBoxColumn, Me.PosterDataGridViewTextBoxColumn, Me.VideoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SirkusBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1082, 166)
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
        'PosterDataGridViewTextBoxColumn
        '
        Me.PosterDataGridViewTextBoxColumn.DataPropertyName = "poster"
        Me.PosterDataGridViewTextBoxColumn.HeaderText = "poster"
        Me.PosterDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PosterDataGridViewTextBoxColumn.Name = "PosterDataGridViewTextBoxColumn"
        '
        'VideoDataGridViewTextBoxColumn
        '
        Me.VideoDataGridViewTextBoxColumn.DataPropertyName = "video"
        Me.VideoDataGridViewTextBoxColumn.HeaderText = "video"
        Me.VideoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.VideoDataGridViewTextBoxColumn.Name = "VideoDataGridViewTextBoxColumn"
        '
        'SirkusBindingSource
        '
        Me.SirkusBindingSource.DataMember = "sirkus"
        Me.SirkusBindingSource.DataSource = Me.SirkusdbDataSet1
        '
        'SirkusdbDataSet1
        '
        Me.SirkusdbDataSet1.DataSetName = "sirkusdbDataSet1"
        Me.SirkusdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Judul:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(108, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(226, 26)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sinopsis:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(108, 63)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(226, 122)
        Me.TextBox2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "File Poster:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(108, 191)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(226, 26)
        Me.TextBox3.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "File Video:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(108, 223)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(226, 26)
        Me.TextBox4.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 40)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(124, 257)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 40)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(232, 257)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 40)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(462, 572)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(209, 44)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Back"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SirkusTableAdapter
        '
        Me.SirkusTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 349)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 308)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tabel Sirkus"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WaktusirkusIdDataGridViewTextBoxColumn, Me.SirkusIdDataGridViewTextBoxColumn1, Me.JamMulaiDataGridViewTextBoxColumn, Me.JamSelesaiDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.WaktusirkusBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(12, 184)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(516, 159)
        Me.DataGridView2.TabIndex = 14
        '
        'WaktusirkusIdDataGridViewTextBoxColumn
        '
        Me.WaktusirkusIdDataGridViewTextBoxColumn.DataPropertyName = "waktu_sirkusId"
        Me.WaktusirkusIdDataGridViewTextBoxColumn.HeaderText = "waktu_sirkusId"
        Me.WaktusirkusIdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.WaktusirkusIdDataGridViewTextBoxColumn.Name = "WaktusirkusIdDataGridViewTextBoxColumn"
        Me.WaktusirkusIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SirkusIdDataGridViewTextBoxColumn1
        '
        Me.SirkusIdDataGridViewTextBoxColumn1.DataPropertyName = "sirkusId"
        Me.SirkusIdDataGridViewTextBoxColumn1.HeaderText = "sirkusId"
        Me.SirkusIdDataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.SirkusIdDataGridViewTextBoxColumn1.Name = "SirkusIdDataGridViewTextBoxColumn1"
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
        'WaktusirkusBindingSource
        '
        Me.WaktusirkusBindingSource.DataMember = "waktu_sirkus"
        Me.WaktusirkusBindingSource.DataSource = Me.SirkusdbDataSet1
        '
        'Waktu_sirkusTableAdapter
        '
        Me.Waktu_sirkusTableAdapter.ClearBeforeFill = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DetailsirkusIdDataGridViewTextBoxColumn, Me.SirkusIdDataGridViewTextBoxColumn2, Me.GambarDataGridViewTextBoxColumn, Me.KeteranganDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.DetailsirkusBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(534, 184)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 62
        Me.DataGridView3.RowTemplate.Height = 28
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(560, 159)
        Me.DataGridView3.TabIndex = 15
        '
        'DetailsirkusIdDataGridViewTextBoxColumn
        '
        Me.DetailsirkusIdDataGridViewTextBoxColumn.DataPropertyName = "detail_sirkusId"
        Me.DetailsirkusIdDataGridViewTextBoxColumn.HeaderText = "detail_sirkusId"
        Me.DetailsirkusIdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.DetailsirkusIdDataGridViewTextBoxColumn.Name = "DetailsirkusIdDataGridViewTextBoxColumn"
        Me.DetailsirkusIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SirkusIdDataGridViewTextBoxColumn2
        '
        Me.SirkusIdDataGridViewTextBoxColumn2.DataPropertyName = "sirkusId"
        Me.SirkusIdDataGridViewTextBoxColumn2.HeaderText = "sirkusId"
        Me.SirkusIdDataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.SirkusIdDataGridViewTextBoxColumn2.Name = "SirkusIdDataGridViewTextBoxColumn2"
        '
        'GambarDataGridViewTextBoxColumn
        '
        Me.GambarDataGridViewTextBoxColumn.DataPropertyName = "gambar"
        Me.GambarDataGridViewTextBoxColumn.HeaderText = "gambar"
        Me.GambarDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.GambarDataGridViewTextBoxColumn.Name = "GambarDataGridViewTextBoxColumn"
        '
        'KeteranganDataGridViewTextBoxColumn
        '
        Me.KeteranganDataGridViewTextBoxColumn.DataPropertyName = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.HeaderText = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.KeteranganDataGridViewTextBoxColumn.Name = "KeteranganDataGridViewTextBoxColumn"
        '
        'DetailsirkusBindingSource
        '
        Me.DetailsirkusBindingSource.DataMember = "detail_sirkus"
        Me.DetailsirkusBindingSource.DataSource = Me.SirkusdbDataSet1
        '
        'Detail_sirkusTableAdapter
        '
        Me.Detail_sirkusTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Location = New System.Drawing.Point(388, 358)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 192)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tabel Sirkus"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(124, 133)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 40)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Edit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Jam Selesai:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(117, 99)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(226, 26)
        Me.TextBox5.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jam Mulai:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "sirkus ID:"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(16, 133)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(102, 40)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Add"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(117, 64)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(226, 26)
        Me.TextBox6.TabIndex = 6
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(232, 133)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(102, 40)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "Delete"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(117, 31)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(226, 26)
        Me.TextBox8.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TextBox7)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.TextBox9)
        Me.GroupBox3.Controls.Add(Me.Button10)
        Me.GroupBox3.Controls.Add(Me.TextBox10)
        Me.GroupBox3.Location = New System.Drawing.Point(744, 358)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(350, 316)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detail Sirkus"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(124, 259)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(102, 40)
        Me.Button8.TabIndex = 10
        Me.Button8.Text = "Edit"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Keterangan Gambar:"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(16, 128)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(318, 125)
        Me.TextBox7.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 20)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "File Gambar:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 34)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 20)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "sirkus ID:"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(16, 259)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(102, 40)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "Add"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(117, 64)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(226, 26)
        Me.TextBox9.TabIndex = 6
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(232, 259)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(102, 40)
        Me.Button10.TabIndex = 11
        Me.Button10.Text = "Delete"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(117, 31)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(226, 26)
        Me.TextBox10.TabIndex = 2
        '
        'UpdateKB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 775)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Name = "UpdateKB"
        Me.Text = "UpdateKB"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SirkusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SirkusdbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaktusirkusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailsirkusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents SirkusdbDataSet1 As sirkusdbDataSet1
    Friend WithEvents SirkusBindingSource As BindingSource
    Friend WithEvents SirkusTableAdapter As sirkusdbDataSet1TableAdapters.sirkusTableAdapter
    Friend WithEvents SirkusIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JudulDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SinopsisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PosterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VideoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents WaktusirkusBindingSource As BindingSource
    Friend WithEvents Waktu_sirkusTableAdapter As sirkusdbDataSet1TableAdapters.waktu_sirkusTableAdapter
    Friend WithEvents WaktusirkusIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SirkusIdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents JamMulaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JamSelesaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DetailsirkusBindingSource As BindingSource
    Friend WithEvents Detail_sirkusTableAdapter As sirkusdbDataSet1TableAdapters.detail_sirkusTableAdapter
    Friend WithEvents DetailsirkusIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SirkusIdDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents GambarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KeteranganDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Button10 As Button
    Friend WithEvents TextBox10 As TextBox
End Class
