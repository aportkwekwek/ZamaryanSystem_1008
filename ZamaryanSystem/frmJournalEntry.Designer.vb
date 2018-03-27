<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJournalEntry
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnadd = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txtdebit = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.cbaccountname = New System.Windows.Forms.ComboBox()
        Me.txtjournaldesc = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtgenjrnlno = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel64 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel63 = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvjournal = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnnew = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lbltotaldebit = New MaterialSkin.Controls.MaterialLabel()
        Me.lbltotalcredit = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvcalamba = New System.Windows.Forms.DataGridView()
        Me.lbltotalbalance = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnsave = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btndelete = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txtcredit = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblrunningbalance = New MaterialSkin.Controls.MaterialLabel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton2 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvjournal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvcalamba, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
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
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(920, 28)
        Me.Panel2.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(920, 28)
        Me.Panel1.TabIndex = 8
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox3.Image = Global.ZamaryanSystem.My.Resources.Resources.Minimize_White
        Me.PictureBox3.Location = New System.Drawing.Point(833, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
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
        Me.PictureBox2.Location = New System.Drawing.Point(862, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
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
        Me.PictureBox1.Location = New System.Drawing.Point(891, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
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
        Me.Panel4.Location = New System.Drawing.Point(0, 703)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(920, 46)
        Me.Panel4.TabIndex = 10
        '
        'btnadd
        '
        Me.btnadd.AutoSize = True
        Me.btnadd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnadd.Depth = 0
        Me.btnadd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnadd.Enabled = False
        Me.btnadd.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Icon = Nothing
        Me.btnadd.Location = New System.Drawing.Point(0, 0)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.btnadd.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Primary = False
        Me.btnadd.Size = New System.Drawing.Size(50, 38)
        Me.btnadd.TabIndex = 60
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txtdebit
        '
        Me.txtdebit.Depth = 0
        Me.txtdebit.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtdebit.ForeColor = System.Drawing.Color.White
        Me.txtdebit.Hint = "Debit"
        Me.txtdebit.Location = New System.Drawing.Point(261, 411)
        Me.txtdebit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdebit.MaxLength = 32767
        Me.txtdebit.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtdebit.Name = "txtdebit"
        Me.txtdebit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdebit.SelectedText = ""
        Me.txtdebit.SelectionLength = 0
        Me.txtdebit.SelectionStart = 0
        Me.txtdebit.Size = New System.Drawing.Size(210, 23)
        Me.txtdebit.TabIndex = 58
        Me.txtdebit.TabStop = False
        Me.txtdebit.UseSystemPasswordChar = False
        '
        'cbaccountname
        '
        Me.cbaccountname.BackColor = System.Drawing.Color.White
        Me.cbaccountname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbaccountname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbaccountname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbaccountname.FormattingEnabled = True
        Me.cbaccountname.Location = New System.Drawing.Point(13, 411)
        Me.cbaccountname.Margin = New System.Windows.Forms.Padding(4)
        Me.cbaccountname.Name = "cbaccountname"
        Me.cbaccountname.Size = New System.Drawing.Size(240, 25)
        Me.cbaccountname.TabIndex = 56
        '
        'txtjournaldesc
        '
        Me.txtjournaldesc.Depth = 0
        Me.txtjournaldesc.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtjournaldesc.ForeColor = System.Drawing.Color.White
        Me.txtjournaldesc.Hint = ""
        Me.txtjournaldesc.Location = New System.Drawing.Point(517, 68)
        Me.txtjournaldesc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtjournaldesc.MaxLength = 32767
        Me.txtjournaldesc.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtjournaldesc.Name = "txtjournaldesc"
        Me.txtjournaldesc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtjournaldesc.SelectedText = ""
        Me.txtjournaldesc.SelectionLength = 0
        Me.txtjournaldesc.SelectionStart = 0
        Me.txtjournaldesc.Size = New System.Drawing.Size(206, 23)
        Me.txtjournaldesc.TabIndex = 53
        Me.txtjournaldesc.TabStop = False
        Me.txtjournaldesc.UseSystemPasswordChar = False
        '
        'txtgenjrnlno
        '
        Me.txtgenjrnlno.Depth = 0
        Me.txtgenjrnlno.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtgenjrnlno.ForeColor = System.Drawing.Color.White
        Me.txtgenjrnlno.Hint = ""
        Me.txtgenjrnlno.Location = New System.Drawing.Point(317, 68)
        Me.txtgenjrnlno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtgenjrnlno.MaxLength = 32767
        Me.txtgenjrnlno.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtgenjrnlno.Name = "txtgenjrnlno"
        Me.txtgenjrnlno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtgenjrnlno.SelectedText = ""
        Me.txtgenjrnlno.SelectionLength = 0
        Me.txtgenjrnlno.SelectionStart = 0
        Me.txtgenjrnlno.Size = New System.Drawing.Size(100, 23)
        Me.txtgenjrnlno.TabIndex = 52
        Me.txtgenjrnlno.TabStop = False
        Me.txtgenjrnlno.UseSystemPasswordChar = False
        '
        'MaterialLabel64
        '
        Me.MaterialLabel64.AutoSize = True
        Me.MaterialLabel64.Depth = 0
        Me.MaterialLabel64.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel64.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel64.Location = New System.Drawing.Point(424, 71)
        Me.MaterialLabel64.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel64.Name = "MaterialLabel64"
        Me.MaterialLabel64.Size = New System.Drawing.Size(86, 19)
        Me.MaterialLabel64.TabIndex = 48
        Me.MaterialLabel64.Text = "Description"
        '
        'MaterialLabel63
        '
        Me.MaterialLabel63.AutoSize = True
        Me.MaterialLabel63.Depth = 0
        Me.MaterialLabel63.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel63.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel63.Location = New System.Drawing.Point(139, 71)
        Me.MaterialLabel63.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel63.Name = "MaterialLabel63"
        Me.MaterialLabel63.Size = New System.Drawing.Size(171, 19)
        Me.MaterialLabel63.TabIndex = 47
        Me.MaterialLabel63.Text = "General Journal Number"
        '
        'dgvjournal
        '
        Me.dgvjournal.AllowUserToAddRows = False
        Me.dgvjournal.AllowUserToDeleteRows = False
        Me.dgvjournal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvjournal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvjournal.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvjournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvjournal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvjournal.Location = New System.Drawing.Point(13, 99)
        Me.dgvjournal.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvjournal.Name = "dgvjournal"
        Me.dgvjournal.ReadOnly = True
        Me.dgvjournal.Size = New System.Drawing.Size(897, 240)
        Me.dgvjournal.TabIndex = 62
        '
        'Column1
        '
        Me.Column1.HeaderText = "Account Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Debit"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Credit"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Description"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'btnnew
        '
        Me.btnnew.AutoSize = True
        Me.btnnew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnnew.Depth = 0
        Me.btnnew.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnnew.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.btnnew.ForeColor = System.Drawing.Color.White
        Me.btnnew.Icon = Nothing
        Me.btnnew.Location = New System.Drawing.Point(0, 0)
        Me.btnnew.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.btnnew.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Primary = False
        Me.btnnew.Size = New System.Drawing.Size(120, 34)
        Me.btnnew.TabIndex = 66
        Me.btnnew.Text = "New Journal"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'lbltotaldebit
        '
        Me.lbltotaldebit.AutoSize = True
        Me.lbltotaldebit.Depth = 0
        Me.lbltotaldebit.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lbltotaldebit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbltotaldebit.Location = New System.Drawing.Point(271, 370)
        Me.lbltotaldebit.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbltotaldebit.Name = "lbltotaldebit"
        Me.lbltotaldebit.Size = New System.Drawing.Size(13, 19)
        Me.lbltotaldebit.TabIndex = 67
        Me.lbltotaldebit.Text = "."
        '
        'lbltotalcredit
        '
        Me.lbltotalcredit.AutoSize = True
        Me.lbltotalcredit.Depth = 0
        Me.lbltotalcredit.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lbltotalcredit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbltotalcredit.Location = New System.Drawing.Point(484, 369)
        Me.lbltotalcredit.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbltotalcredit.Name = "lbltotalcredit"
        Me.lbltotalcredit.Size = New System.Drawing.Size(13, 19)
        Me.lbltotalcredit.TabIndex = 68
        Me.lbltotalcredit.Text = "."
        '
        'dgvcalamba
        '
        Me.dgvcalamba.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvcalamba.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvcalamba.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvcalamba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcalamba.Location = New System.Drawing.Point(921, 128)
        Me.dgvcalamba.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvcalamba.Name = "dgvcalamba"
        Me.dgvcalamba.Size = New System.Drawing.Size(432, 240)
        Me.dgvcalamba.TabIndex = 69
        Me.dgvcalamba.Visible = False
        '
        'lbltotalbalance
        '
        Me.lbltotalbalance.AutoSize = True
        Me.lbltotalbalance.Depth = 0
        Me.lbltotalbalance.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lbltotalbalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbltotalbalance.Location = New System.Drawing.Point(1272, 372)
        Me.lbltotalbalance.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbltotalbalance.Name = "lbltotalbalance"
        Me.lbltotalbalance.Size = New System.Drawing.Size(17, 19)
        Me.lbltotalbalance.TabIndex = 70
        Me.lbltotalbalance.Text = "0"
        Me.lbltotalbalance.Visible = False
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(182, 370)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(83, 19)
        Me.MaterialLabel2.TabIndex = 71
        Me.MaterialLabel2.Text = "Total Debit"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(390, 370)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(88, 19)
        Me.MaterialLabel3.TabIndex = 72
        Me.MaterialLabel3.Text = "Total Credit"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(1165, 372)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(101, 19)
        Me.MaterialLabel4.TabIndex = 73
        Me.MaterialLabel4.Text = "Total Balance"
        Me.MaterialLabel4.Visible = False
        '
        'btnsave
        '
        Me.btnsave.AutoSize = True
        Me.btnsave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnsave.Depth = 0
        Me.btnsave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnsave.Enabled = False
        Me.btnsave.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Icon = Nothing
        Me.btnsave.Location = New System.Drawing.Point(0, 0)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.btnsave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Primary = False
        Me.btnsave.Size = New System.Drawing.Size(116, 38)
        Me.btnsave.TabIndex = 74
        Me.btnsave.Text = "Save Journal"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.AutoSize = True
        Me.btndelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btndelete.Depth = 0
        Me.btndelete.Enabled = False
        Me.btndelete.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Icon = Nothing
        Me.btndelete.Location = New System.Drawing.Point(13, 363)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.btndelete.MouseState = MaterialSkin.MouseState.HOVER
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Primary = False
        Me.btndelete.Size = New System.Drawing.Size(69, 36)
        Me.btndelete.TabIndex = 75
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'txtcredit
        '
        Me.txtcredit.Depth = 0
        Me.txtcredit.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtcredit.ForeColor = System.Drawing.Color.White
        Me.txtcredit.Hint = "Credit"
        Me.txtcredit.Location = New System.Drawing.Point(479, 411)
        Me.txtcredit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcredit.MaxLength = 32767
        Me.txtcredit.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtcredit.Name = "txtcredit"
        Me.txtcredit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcredit.SelectedText = ""
        Me.txtcredit.SelectionLength = 0
        Me.txtcredit.SelectionStart = 0
        Me.txtcredit.Size = New System.Drawing.Size(210, 23)
        Me.txtcredit.TabIndex = 76
        Me.txtcredit.TabStop = False
        Me.txtcredit.UseSystemPasswordChar = False
        '
        'lblrunningbalance
        '
        Me.lblrunningbalance.AutoSize = True
        Me.lblrunningbalance.Depth = 0
        Me.lblrunningbalance.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblrunningbalance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblrunningbalance.Location = New System.Drawing.Point(697, 371)
        Me.lblrunningbalance.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblrunningbalance.Name = "lblrunningbalance"
        Me.lblrunningbalance.Size = New System.Drawing.Size(0, 19)
        Me.lblrunningbalance.TabIndex = 78
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel5.Controls.Add(Me.btnadd)
        Me.Panel5.Location = New System.Drawing.Point(696, 404)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(50, 38)
        Me.Panel5.TabIndex = 79
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel3.Controls.Add(Me.btnsave)
        Me.Panel3.Location = New System.Drawing.Point(759, 404)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(116, 38)
        Me.Panel3.TabIndex = 80
        '
        'MaterialFlatButton2
        '
        Me.MaterialFlatButton2.AutoSize = True
        Me.MaterialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton2.Depth = 0
        Me.MaterialFlatButton2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialFlatButton2.Enabled = False
        Me.MaterialFlatButton2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.MaterialFlatButton2.ForeColor = System.Drawing.Color.White
        Me.MaterialFlatButton2.Icon = Nothing
        Me.MaterialFlatButton2.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton2.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.MaterialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton2.Name = "MaterialFlatButton2"
        Me.MaterialFlatButton2.Primary = False
        Me.MaterialFlatButton2.Size = New System.Drawing.Size(142, 38)
        Me.MaterialFlatButton2.TabIndex = 81
        Me.MaterialFlatButton2.Text = "Add Account"
        Me.MaterialFlatButton2.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel6.Controls.Add(Me.MaterialFlatButton2)
        Me.Panel6.Location = New System.Drawing.Point(13, 443)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(142, 38)
        Me.Panel6.TabIndex = 82
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel7.Controls.Add(Me.btnnew)
        Me.Panel7.Location = New System.Drawing.Point(13, 61)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(120, 34)
        Me.Panel7.TabIndex = 83
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(673, 377)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(119, 19)
        Me.MaterialLabel1.TabIndex = 77
        Me.MaterialLabel1.Text = "Running Balance"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(4, 4)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(104, 24)
        Me.Label35.TabIndex = 1
        Me.Label35.Text = "JOURNAL"
        '
        'frmJournalEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 749)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.lblrunningbalance)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.txtcredit)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.lbltotalbalance)
        Me.Controls.Add(Me.dgvcalamba)
        Me.Controls.Add(Me.lbltotalcredit)
        Me.Controls.Add(Me.lbltotaldebit)
        Me.Controls.Add(Me.dgvjournal)
        Me.Controls.Add(Me.txtdebit)
        Me.Controls.Add(Me.cbaccountname)
        Me.Controls.Add(Me.txtjournaldesc)
        Me.Controls.Add(Me.txtgenjrnlno)
        Me.Controls.Add(Me.MaterialLabel64)
        Me.Controls.Add(Me.MaterialLabel63)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmJournalEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmJournalEntry"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvjournal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvcalamba, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
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
    Friend WithEvents btnadd As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txtdebit As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents cbaccountname As System.Windows.Forms.ComboBox
    Friend WithEvents txtjournaldesc As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtgenjrnlno As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel64 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel63 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvjournal As System.Windows.Forms.DataGridView
    Friend WithEvents btnnew As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lbltotalcredit As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbltotaldebit As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvcalamba As System.Windows.Forms.DataGridView
    Friend WithEvents lbltotalbalance As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnsave As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btndelete As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txtcredit As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblrunningbalance As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents MaterialFlatButton2 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label35 As System.Windows.Forms.Label
End Class
