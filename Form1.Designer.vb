<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lcircus = New System.Windows.Forms.Label()
        Me.labelpassword = New System.Windows.Forms.Label()
        Me.labelakun = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.labelkangsirkus = New System.Windows.Forms.Label()
        Me.pbbatas = New System.Windows.Forms.PictureBox()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.btnmember = New System.Windows.Forms.Button()
        Me.btnguest = New System.Windows.Forms.Button()
        Me.labelcostumer = New System.Windows.Forms.Label()
        CType(Me.pbbatas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lcircus
        '
        Me.lcircus.AutoSize = True
        Me.lcircus.CausesValidation = False
        Me.lcircus.Enabled = False
        Me.lcircus.Font = New System.Drawing.Font("Ravie", 15.0!)
        Me.lcircus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lcircus.Location = New System.Drawing.Point(152, 186)
        Me.lcircus.Name = "lcircus"
        Me.lcircus.Size = New System.Drawing.Size(226, 27)
        Me.lcircus.TabIndex = 27
        Me.lcircus.Text = "The Vera Circus"
        '
        'labelpassword
        '
        Me.labelpassword.AutoSize = True
        Me.labelpassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelpassword.Location = New System.Drawing.Point(280, 283)
        Me.labelpassword.Name = "labelpassword"
        Me.labelpassword.Size = New System.Drawing.Size(78, 18)
        Me.labelpassword.TabIndex = 26
        Me.labelpassword.Text = "Password"
        '
        'labelakun
        '
        Me.labelakun.AutoSize = True
        Me.labelakun.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelakun.Location = New System.Drawing.Point(280, 256)
        Me.labelakun.Name = "labelakun"
        Me.labelakun.Size = New System.Drawing.Size(43, 18)
        Me.labelakun.TabIndex = 25
        Me.labelakun.Text = "Akun"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(359, 283)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 24
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(359, 257)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 23
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(359, 309)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(79, 23)
        Me.btnlogin.TabIndex = 22
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'labelkangsirkus
        '
        Me.labelkangsirkus.AutoSize = True
        Me.labelkangsirkus.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelkangsirkus.Location = New System.Drawing.Point(279, 225)
        Me.labelkangsirkus.Name = "labelkangsirkus"
        Me.labelkangsirkus.Size = New System.Drawing.Size(93, 20)
        Me.labelkangsirkus.TabIndex = 21
        Me.labelkangsirkus.Text = "Kang Sirkus :"
        '
        'pbbatas
        '
        Me.pbbatas.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pbbatas.Location = New System.Drawing.Point(263, 225)
        Me.pbbatas.Name = "pbbatas"
        Me.pbbatas.Size = New System.Drawing.Size(10, 109)
        Me.pbbatas.TabIndex = 20
        Me.pbbatas.TabStop = False
        '
        'pb1
        '
        Me.pb1.Image = CType(resources.GetObject("pb1.Image"), System.Drawing.Image)
        Me.pb1.Location = New System.Drawing.Point(1, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(529, 219)
        Me.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb1.TabIndex = 19
        Me.pb1.TabStop = False
        '
        'btnmember
        '
        Me.btnmember.Location = New System.Drawing.Point(149, 275)
        Me.btnmember.Name = "btnmember"
        Me.btnmember.Size = New System.Drawing.Size(75, 40)
        Me.btnmember.TabIndex = 18
        Me.btnmember.Text = "Create Member"
        Me.btnmember.UseVisualStyleBackColor = True
        '
        'btnguest
        '
        Me.btnguest.Location = New System.Drawing.Point(49, 275)
        Me.btnguest.Name = "btnguest"
        Me.btnguest.Size = New System.Drawing.Size(75, 40)
        Me.btnguest.TabIndex = 17
        Me.btnguest.Text = "Guest"
        Me.btnguest.UseVisualStyleBackColor = True
        '
        'labelcostumer
        '
        Me.labelcostumer.AutoSize = True
        Me.labelcostumer.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelcostumer.Location = New System.Drawing.Point(100, 239)
        Me.labelcostumer.Name = "labelcostumer"
        Me.labelcostumer.Size = New System.Drawing.Size(77, 20)
        Me.labelcostumer.TabIndex = 16
        Me.labelcostumer.Text = "Costumer :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(529, 340)
        Me.Controls.Add(Me.lcircus)
        Me.Controls.Add(Me.labelpassword)
        Me.Controls.Add(Me.labelakun)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.labelkangsirkus)
        Me.Controls.Add(Me.pbbatas)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.btnmember)
        Me.Controls.Add(Me.btnguest)
        Me.Controls.Add(Me.labelcostumer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbbatas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lcircus As Label
    Friend WithEvents labelpassword As Label
    Friend WithEvents labelakun As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents labelkangsirkus As Label
    Friend WithEvents pbbatas As PictureBox
    Friend WithEvents pb1 As PictureBox
    Friend WithEvents btnmember As Button
    Friend WithEvents btnguest As Button
    Friend WithEvents labelcostumer As Label
End Class
