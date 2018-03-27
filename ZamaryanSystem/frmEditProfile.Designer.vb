<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditProfile
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
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtcwt = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnsave = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnclear = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txttin = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtemail = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcontactperson = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtfax = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtphone = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtzip = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtaddress = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtwebsite = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 15
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Controls.Add(Me.Label35)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(924, 28)
        Me.Panel2.TabIndex = 9
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(4, 4)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(148, 24)
        Me.Label35.TabIndex = 1
        Me.Label35.Text = "EDIT PROFILE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(924, 28)
        Me.Panel1.TabIndex = 8
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox3.Image = Global.ZamaryanSystem.My.Resources.Resources.Minimize_White
        Me.PictureBox3.Location = New System.Drawing.Point(837, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(29, 28)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Image = Global.ZamaryanSystem.My.Resources.Resources.Maximize_White
        Me.PictureBox2.Location = New System.Drawing.Point(866, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.ZamaryanSystem.My.Resources.Resources.Close_White
        Me.PictureBox1.Location = New System.Drawing.Point(895, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 512)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(924, 46)
        Me.Panel4.TabIndex = 10
        '
        'txtcwt
        '
        Me.txtcwt.Depth = 0
        Me.txtcwt.ForeColor = System.Drawing.Color.Black
        Me.txtcwt.Hint = ""
        Me.txtcwt.Location = New System.Drawing.Point(580, 274)
        Me.txtcwt.MaxLength = 100
        Me.txtcwt.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtcwt.Name = "txtcwt"
        Me.txtcwt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcwt.SelectedText = ""
        Me.txtcwt.SelectionLength = 0
        Me.txtcwt.SelectionStart = 0
        Me.txtcwt.Size = New System.Drawing.Size(243, 23)
        Me.txtcwt.TabIndex = 45
        Me.txtcwt.TabStop = False
        Me.txtcwt.UseSystemPasswordChar = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(442, 274)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 20)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "CWT"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel5.Controls.Add(Me.btnsave)
        Me.Panel5.Location = New System.Drawing.Point(748, 411)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(83, 38)
        Me.Panel5.TabIndex = 38
        '
        'btnsave
        '
        Me.btnsave.AutoSize = True
        Me.btnsave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnsave.Depth = 0
        Me.btnsave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnsave.Icon = Nothing
        Me.btnsave.Location = New System.Drawing.Point(0, 0)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnsave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Primary = False
        Me.btnsave.Size = New System.Drawing.Size(83, 38)
        Me.btnsave.TabIndex = 46
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.AutoSize = True
        Me.btnclear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnclear.Depth = 0
        Me.btnclear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnclear.Icon = Nothing
        Me.btnclear.Location = New System.Drawing.Point(0, 0)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnclear.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Primary = False
        Me.btnclear.Size = New System.Drawing.Size(83, 38)
        Me.btnclear.TabIndex = 47
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'txttin
        '
        Me.txttin.Depth = 0
        Me.txttin.ForeColor = System.Drawing.Color.Black
        Me.txttin.Hint = ""
        Me.txttin.Location = New System.Drawing.Point(580, 234)
        Me.txttin.MaxLength = 15
        Me.txttin.MouseState = MaterialSkin.MouseState.HOVER
        Me.txttin.Name = "txttin"
        Me.txttin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttin.SelectedText = ""
        Me.txttin.SelectionLength = 0
        Me.txttin.SelectionStart = 0
        Me.txttin.Size = New System.Drawing.Size(243, 23)
        Me.txttin.TabIndex = 44
        Me.txttin.TabStop = False
        Me.txttin.UseSystemPasswordChar = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(442, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 20)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "TIN"
        '
        'txtemail
        '
        Me.txtemail.Depth = 0
        Me.txtemail.ForeColor = System.Drawing.Color.Black
        Me.txtemail.Hint = ""
        Me.txtemail.Location = New System.Drawing.Point(580, 197)
        Me.txtemail.MaxLength = 100
        Me.txtemail.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtemail.Name = "txtemail"
        Me.txtemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtemail.SelectedText = ""
        Me.txtemail.SelectionLength = 0
        Me.txtemail.SelectionStart = 0
        Me.txtemail.Size = New System.Drawing.Size(243, 23)
        Me.txtemail.TabIndex = 43
        Me.txtemail.TabStop = False
        Me.txtemail.UseSystemPasswordChar = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(442, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 20)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "E-mail"
        '
        'txtcontactperson
        '
        Me.txtcontactperson.Depth = 0
        Me.txtcontactperson.ForeColor = System.Drawing.Color.Black
        Me.txtcontactperson.Hint = ""
        Me.txtcontactperson.Location = New System.Drawing.Point(580, 157)
        Me.txtcontactperson.MaxLength = 100
        Me.txtcontactperson.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtcontactperson.Name = "txtcontactperson"
        Me.txtcontactperson.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcontactperson.SelectedText = ""
        Me.txtcontactperson.SelectionLength = 0
        Me.txtcontactperson.SelectionStart = 0
        Me.txtcontactperson.Size = New System.Drawing.Size(243, 23)
        Me.txtcontactperson.TabIndex = 42
        Me.txtcontactperson.TabStop = False
        Me.txtcontactperson.UseSystemPasswordChar = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(442, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 20)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Contact Person"
        '
        'txtfax
        '
        Me.txtfax.Depth = 0
        Me.txtfax.ForeColor = System.Drawing.Color.Black
        Me.txtfax.Hint = ""
        Me.txtfax.Location = New System.Drawing.Point(166, 274)
        Me.txtfax.MaxLength = 50
        Me.txtfax.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtfax.Name = "txtfax"
        Me.txtfax.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfax.SelectedText = ""
        Me.txtfax.SelectionLength = 0
        Me.txtfax.SelectionStart = 0
        Me.txtfax.Size = New System.Drawing.Size(243, 23)
        Me.txtfax.TabIndex = 40
        Me.txtfax.TabStop = False
        Me.txtfax.UseSystemPasswordChar = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(20, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 20)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Fax"
        '
        'txtphone
        '
        Me.txtphone.Depth = 0
        Me.txtphone.ForeColor = System.Drawing.Color.Black
        Me.txtphone.Hint = ""
        Me.txtphone.Location = New System.Drawing.Point(166, 234)
        Me.txtphone.MaxLength = 200
        Me.txtphone.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtphone.Name = "txtphone"
        Me.txtphone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtphone.SelectedText = ""
        Me.txtphone.SelectionLength = 0
        Me.txtphone.SelectionStart = 0
        Me.txtphone.Size = New System.Drawing.Size(243, 23)
        Me.txtphone.TabIndex = 39
        Me.txtphone.TabStop = False
        Me.txtphone.UseSystemPasswordChar = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(20, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Phone"
        '
        'txtzip
        '
        Me.txtzip.Depth = 0
        Me.txtzip.ForeColor = System.Drawing.Color.Black
        Me.txtzip.Hint = ""
        Me.txtzip.Location = New System.Drawing.Point(168, 197)
        Me.txtzip.MaxLength = 4
        Me.txtzip.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtzip.Name = "txtzip"
        Me.txtzip.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtzip.SelectedText = ""
        Me.txtzip.SelectionLength = 0
        Me.txtzip.SelectionStart = 0
        Me.txtzip.Size = New System.Drawing.Size(243, 23)
        Me.txtzip.TabIndex = 38
        Me.txtzip.TabStop = False
        Me.txtzip.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(20, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "ZIP Code"
        '
        'txtaddress
        '
        Me.txtaddress.Depth = 0
        Me.txtaddress.ForeColor = System.Drawing.Color.Black
        Me.txtaddress.Hint = ""
        Me.txtaddress.Location = New System.Drawing.Point(166, 157)
        Me.txtaddress.MaxLength = 500
        Me.txtaddress.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtaddress.SelectedText = ""
        Me.txtaddress.SelectionLength = 0
        Me.txtaddress.SelectionStart = 0
        Me.txtaddress.Size = New System.Drawing.Size(243, 23)
        Me.txtaddress.TabIndex = 37
        Me.txtaddress.TabStop = False
        Me.txtaddress.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(20, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Address"
        '
        'txtname
        '
        Me.txtname.Depth = 0
        Me.txtname.ForeColor = System.Drawing.Color.Black
        Me.txtname.Hint = ""
        Me.txtname.Location = New System.Drawing.Point(166, 117)
        Me.txtname.MaxLength = 100
        Me.txtname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtname.Name = "txtname"
        Me.txtname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtname.SelectedText = ""
        Me.txtname.SelectionLength = 0
        Me.txtname.SelectionStart = 0
        Me.txtname.Size = New System.Drawing.Size(243, 23)
        Me.txtname.TabIndex = 36
        Me.txtname.TabStop = False
        Me.txtname.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(20, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 20)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Company Name"
        '
        'txtwebsite
        '
        Me.txtwebsite.Depth = 0
        Me.txtwebsite.ForeColor = System.Drawing.Color.Black
        Me.txtwebsite.Hint = ""
        Me.txtwebsite.Location = New System.Drawing.Point(580, 117)
        Me.txtwebsite.MaxLength = 100
        Me.txtwebsite.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtwebsite.Name = "txtwebsite"
        Me.txtwebsite.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtwebsite.SelectedText = ""
        Me.txtwebsite.SelectionLength = 0
        Me.txtwebsite.SelectionStart = 0
        Me.txtwebsite.Size = New System.Drawing.Size(243, 23)
        Me.txtwebsite.TabIndex = 41
        Me.txtwebsite.TabStop = False
        Me.txtwebsite.UseSystemPasswordChar = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(442, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Website"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel3.Controls.Add(Me.btnclear)
        Me.Panel3.Location = New System.Drawing.Point(837, 411)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(83, 38)
        Me.Panel3.TabIndex = 58
        '
        'frmEditProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 558)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txtwebsite)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcwt)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.txttin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtcontactperson)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtfax)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtphone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtzip)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEditProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEditProfile"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtwebsite As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcwt As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnsave As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnclear As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txttin As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtemail As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcontactperson As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtfax As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtphone As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtzip As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label35 As System.Windows.Forms.Label
End Class
