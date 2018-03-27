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
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txtentrydate = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnadd = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txtdebitcredit = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.cbaccountname = New System.Windows.Forms.ComboBox()
        Me.txtjournaldesc = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtgenjrnlno = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblaccountcode = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel65 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel64 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel63 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel61 = New MaterialSkin.Controls.MaterialLabel()
        Me.DateTo = New System.Windows.Forms.DateTimePicker()
        Me.MaterialLabel62 = New MaterialSkin.Controls.MaterialLabel()
        Me.dateFrom = New System.Windows.Forms.DateTimePicker()
        Me.dgvjournal = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtsource = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.cbdebitcredit = New System.Windows.Forms.ComboBox()
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
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvjournal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvcalamba, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 15
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 23)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(920, 28)
        Me.Panel2.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(920, 23)
        Me.Panel1.TabIndex = 8
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox3.Image = Global.ZamaryanSystem.My.Resources.Resources.icons8_minimize_window_48
        Me.PictureBox3.Location = New System.Drawing.Point(803, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(39, 23)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Image = Global.ZamaryanSystem.My.Resources.Resources.icons8_maximize_window_filled_48__1_
        Me.PictureBox2.Location = New System.Drawing.Point(842, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.ZamaryanSystem.My.Resources.Resources.icons8_cancel_48
        Me.PictureBox1.Location = New System.Drawing.Point(881, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Panel4.Controls.Add(Me.MaterialFlatButton1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 703)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(920, 46)
        Me.Panel4.TabIndex = 10
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.MaterialFlatButton1.Icon = Nothing
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(847, 0)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(73, 46)
        Me.MaterialFlatButton1.TabIndex = 0
        Me.MaterialFlatButton1.Text = "Cancel"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'txtentrydate
        '
        Me.txtentrydate.Depth = 0
        Me.txtentrydate.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtentrydate.ForeColor = System.Drawing.Color.White
        Me.txtentrydate.Hint = ""
        Me.txtentrydate.Location = New System.Drawing.Point(118, 424)
        Me.txtentrydate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtentrydate.MaxLength = 32767
        Me.txtentrydate.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtentrydate.Name = "txtentrydate"
        Me.txtentrydate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtentrydate.SelectedText = ""
        Me.txtentrydate.SelectionLength = 0
        Me.txtentrydate.SelectionStart = 0
        Me.txtentrydate.Size = New System.Drawing.Size(233, 23)
        Me.txtentrydate.TabIndex = 61
        Me.txtentrydate.TabStop = False
        Me.txtentrydate.UseSystemPasswordChar = False
        '
        'btnadd
        '
        Me.btnadd.AutoSize = True
        Me.btnadd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnadd.Depth = 0
        Me.btnadd.Enabled = False
        Me.btnadd.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Icon = Nothing
        Me.btnadd.Location = New System.Drawing.Point(665, 447)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.btnadd.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Primary = False
        Me.btnadd.Size = New System.Drawing.Size(48, 36)
        Me.btnadd.TabIndex = 60
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txtdebitcredit
        '
        Me.txtdebitcredit.Depth = 0
        Me.txtdebitcredit.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtdebitcredit.ForeColor = System.Drawing.Color.White
        Me.txtdebitcredit.Hint = ""
        Me.txtdebitcredit.Location = New System.Drawing.Point(435, 455)
        Me.txtdebitcredit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdebitcredit.MaxLength = 32767
        Me.txtdebitcredit.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtdebitcredit.Name = "txtdebitcredit"
        Me.txtdebitcredit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdebitcredit.SelectedText = ""
        Me.txtdebitcredit.SelectionLength = 0
        Me.txtdebitcredit.SelectionStart = 0
        Me.txtdebitcredit.Size = New System.Drawing.Size(221, 23)
        Me.txtdebitcredit.TabIndex = 58
        Me.txtdebitcredit.TabStop = False
        Me.txtdebitcredit.UseSystemPasswordChar = False
        '
        'cbaccountname
        '
        Me.cbaccountname.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.cbaccountname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbaccountname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbaccountname.FormattingEnabled = True
        Me.cbaccountname.Location = New System.Drawing.Point(363, 424)
        Me.cbaccountname.Margin = New System.Windows.Forms.Padding(4)
        Me.cbaccountname.Name = "cbaccountname"
        Me.cbaccountname.Size = New System.Drawing.Size(247, 25)
        Me.cbaccountname.TabIndex = 56
        '
        'txtjournaldesc
        '
        Me.txtjournaldesc.Depth = 0
        Me.txtjournaldesc.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtjournaldesc.ForeColor = System.Drawing.Color.White
        Me.txtjournaldesc.Hint = ""
        Me.txtjournaldesc.Location = New System.Drawing.Point(190, 97)
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
        Me.txtgenjrnlno.Location = New System.Drawing.Point(190, 68)
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
        'lblaccountcode
        '
        Me.lblaccountcode.AutoSize = True
        Me.lblaccountcode.Depth = 0
        Me.lblaccountcode.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblaccountcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblaccountcode.Location = New System.Drawing.Point(617, 424)
        Me.lblaccountcode.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblaccountcode.Name = "lblaccountcode"
        Me.lblaccountcode.Size = New System.Drawing.Size(101, 23)
        Me.lblaccountcode.TabIndex = 50
        Me.lblaccountcode.Text = "Account Code"
        Me.lblaccountcode.UseCompatibleTextRendering = True
        '
        'MaterialLabel65
        '
        Me.MaterialLabel65.AutoSize = True
        Me.MaterialLabel65.Depth = 0
        Me.MaterialLabel65.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel65.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel65.Location = New System.Drawing.Point(12, 424)
        Me.MaterialLabel65.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel65.Name = "MaterialLabel65"
        Me.MaterialLabel65.Size = New System.Drawing.Size(78, 19)
        Me.MaterialLabel65.TabIndex = 49
        Me.MaterialLabel65.Text = "Entry Date"
        '
        'MaterialLabel64
        '
        Me.MaterialLabel64.AutoSize = True
        Me.MaterialLabel64.Depth = 0
        Me.MaterialLabel64.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel64.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel64.Location = New System.Drawing.Point(97, 100)
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
        Me.MaterialLabel63.Location = New System.Drawing.Point(12, 71)
        Me.MaterialLabel63.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel63.Name = "MaterialLabel63"
        Me.MaterialLabel63.Size = New System.Drawing.Size(171, 19)
        Me.MaterialLabel63.TabIndex = 47
        Me.MaterialLabel63.Text = "General Journal Number"
        '
        'MaterialLabel61
        '
        Me.MaterialLabel61.AutoSize = True
        Me.MaterialLabel61.Depth = 0
        Me.MaterialLabel61.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel61.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel61.Location = New System.Drawing.Point(403, 100)
        Me.MaterialLabel61.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel61.Name = "MaterialLabel61"
        Me.MaterialLabel61.Size = New System.Drawing.Size(62, 19)
        Me.MaterialLabel61.TabIndex = 46
        Me.MaterialLabel61.Text = "To Date"
        '
        'DateTo
        '
        Me.DateTo.CustomFormat = "yyyy-MM-dd"
        Me.DateTo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTo.Location = New System.Drawing.Point(471, 97)
        Me.DateTo.Name = "DateTo"
        Me.DateTo.Size = New System.Drawing.Size(309, 23)
        Me.DateTo.TabIndex = 45
        '
        'MaterialLabel62
        '
        Me.MaterialLabel62.AutoSize = True
        Me.MaterialLabel62.Depth = 0
        Me.MaterialLabel62.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel62.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel62.Location = New System.Drawing.Point(386, 71)
        Me.MaterialLabel62.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel62.Name = "MaterialLabel62"
        Me.MaterialLabel62.Size = New System.Drawing.Size(79, 19)
        Me.MaterialLabel62.TabIndex = 44
        Me.MaterialLabel62.Text = "From Date"
        '
        'dateFrom
        '
        Me.dateFrom.CustomFormat = "yyyy-MM-dd"
        Me.dateFrom.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateFrom.Location = New System.Drawing.Point(471, 68)
        Me.dateFrom.Name = "dateFrom"
        Me.dateFrom.Size = New System.Drawing.Size(309, 23)
        Me.dateFrom.TabIndex = 43
        '
        'dgvjournal
        '
        Me.dgvjournal.AllowUserToAddRows = False
        Me.dgvjournal.AllowUserToDeleteRows = False
        Me.dgvjournal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvjournal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvjournal.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvjournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvjournal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvjournal.Location = New System.Drawing.Point(16, 128)
        Me.dgvjournal.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvjournal.Name = "dgvjournal"
        Me.dgvjournal.ReadOnly = True
        Me.dgvjournal.Size = New System.Drawing.Size(897, 240)
        Me.dgvjournal.TabIndex = 62
        '
        'Column1
        '
        Me.Column1.HeaderText = "Date"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Source"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Account Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Debit"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Credit"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(35, 455)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(56, 19)
        Me.MaterialLabel1.TabIndex = 63
        Me.MaterialLabel1.Text = "Source"
        '
        'txtsource
        '
        Me.txtsource.Depth = 0
        Me.txtsource.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtsource.ForeColor = System.Drawing.Color.White
        Me.txtsource.Hint = ""
        Me.txtsource.Location = New System.Drawing.Point(118, 455)
        Me.txtsource.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsource.MaxLength = 32767
        Me.txtsource.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtsource.Name = "txtsource"
        Me.txtsource.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsource.SelectedText = ""
        Me.txtsource.SelectionLength = 0
        Me.txtsource.SelectionStart = 0
        Me.txtsource.Size = New System.Drawing.Size(233, 23)
        Me.txtsource.TabIndex = 64
        Me.txtsource.TabStop = False
        Me.txtsource.UseSystemPasswordChar = False
        '
        'cbdebitcredit
        '
        Me.cbdebitcredit.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.cbdebitcredit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbdebitcredit.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbdebitcredit.FormattingEnabled = True
        Me.cbdebitcredit.Items.AddRange(New Object() {"Debit", "Credit"})
        Me.cbdebitcredit.Location = New System.Drawing.Point(363, 454)
        Me.cbdebitcredit.Margin = New System.Windows.Forms.Padding(4)
        Me.cbdebitcredit.Name = "cbdebitcredit"
        Me.cbdebitcredit.Size = New System.Drawing.Size(64, 25)
        Me.cbdebitcredit.TabIndex = 65
        '
        'btnnew
        '
        Me.btnnew.AutoSize = True
        Me.btnnew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnnew.Depth = 0
        Me.btnnew.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.btnnew.ForeColor = System.Drawing.Color.White
        Me.btnnew.Icon = Nothing
        Me.btnnew.Location = New System.Drawing.Point(327, 63)
        Me.btnnew.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.btnnew.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Primary = False
        Me.btnnew.Size = New System.Drawing.Size(51, 36)
        Me.btnnew.TabIndex = 66
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'lbltotaldebit
        '
        Me.lbltotaldebit.AutoSize = True
        Me.lbltotaldebit.Depth = 0
        Me.lbltotaldebit.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lbltotaldebit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbltotaldebit.Location = New System.Drawing.Point(570, 387)
        Me.lbltotaldebit.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbltotaldebit.Name = "lbltotaldebit"
        Me.lbltotaldebit.Size = New System.Drawing.Size(17, 19)
        Me.lbltotaldebit.TabIndex = 67
        Me.lbltotaldebit.Text = "0"
        '
        'lbltotalcredit
        '
        Me.lbltotalcredit.AutoSize = True
        Me.lbltotalcredit.Depth = 0
        Me.lbltotalcredit.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lbltotalcredit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbltotalcredit.Location = New System.Drawing.Point(741, 387)
        Me.lbltotalcredit.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbltotalcredit.Name = "lbltotalcredit"
        Me.lbltotalcredit.Size = New System.Drawing.Size(17, 19)
        Me.lbltotalcredit.TabIndex = 68
        Me.lbltotalcredit.Text = "0"
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
        Me.MaterialLabel2.Location = New System.Drawing.Point(481, 388)
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
        Me.MaterialLabel3.Location = New System.Drawing.Point(647, 388)
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
        Me.btnsave.Enabled = False
        Me.btnsave.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Icon = Nothing
        Me.btnsave.Location = New System.Drawing.Point(723, 447)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.btnsave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Primary = False
        Me.btnsave.Size = New System.Drawing.Size(119, 36)
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
        Me.btndelete.Location = New System.Drawing.Point(16, 380)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(5, 8, 5, 8)
        Me.btndelete.MouseState = MaterialSkin.MouseState.HOVER
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Primary = False
        Me.btndelete.Size = New System.Drawing.Size(69, 36)
        Me.btndelete.TabIndex = 75
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'frmJournalEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 749)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.lbltotalbalance)
        Me.Controls.Add(Me.dgvcalamba)
        Me.Controls.Add(Me.lbltotalcredit)
        Me.Controls.Add(Me.lbltotaldebit)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.cbdebitcredit)
        Me.Controls.Add(Me.txtsource)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.dgvjournal)
        Me.Controls.Add(Me.txtentrydate)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txtdebitcredit)
        Me.Controls.Add(Me.cbaccountname)
        Me.Controls.Add(Me.txtjournaldesc)
        Me.Controls.Add(Me.txtgenjrnlno)
        Me.Controls.Add(Me.lblaccountcode)
        Me.Controls.Add(Me.MaterialLabel65)
        Me.Controls.Add(Me.MaterialLabel64)
        Me.Controls.Add(Me.MaterialLabel63)
        Me.Controls.Add(Me.MaterialLabel61)
        Me.Controls.Add(Me.DateTo)
        Me.Controls.Add(Me.MaterialLabel62)
        Me.Controls.Add(Me.dateFrom)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmJournalEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmJournalEntry"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgvjournal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvcalamba, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txtentrydate As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnadd As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txtdebitcredit As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents cbaccountname As System.Windows.Forms.ComboBox
    Friend WithEvents txtjournaldesc As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtgenjrnlno As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblaccountcode As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel65 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel64 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel63 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel61 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents DateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents MaterialLabel62 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvjournal As System.Windows.Forms.DataGridView
    Friend WithEvents txtsource As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbdebitcredit As System.Windows.Forms.ComboBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
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
End Class
