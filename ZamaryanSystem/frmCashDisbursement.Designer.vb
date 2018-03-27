<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashDisbursement
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCashDisbursement))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblTotalCWT2 = New System.Windows.Forms.Label()
        Me.lblTotalCWT1 = New System.Windows.Forms.Label()
        Me.cmbUpdateCashReceipts = New System.Windows.Forms.ComboBox()
        Me.cmbAddcashReceipts = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtAmtPdrr = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtCheckNumber = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lbltotalcwt = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblamountwords = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblamountpaid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblAmountPaid1 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnCancelIventory = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnHeaderSave = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lvcashdisbursement = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblDisbursmentID = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbModeofPayment = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbSupplierBilling = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCDSWebsite = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtCDSTin = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCDSEmail = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtCDSID = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCDSFax = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtCDSAddress = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtCDSZip = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCDSContact = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCDSNumber = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblcwt = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.dgvUnpaidBalance = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtAmtPd1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtCheckNumber2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbltotalcwt3 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblamountwords2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblamountpaid2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnHeaderSave1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancelAPV = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.dgvUnpaidBalance1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblDateAPV = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmbModeofPayment1 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCDSWebsite1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCDSEmail1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtCDSFax1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtCDSZip1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lblcwt1 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtCDSTin1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCDSAddress1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCDSContact1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCDSNumber1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCDSID1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSupplierBilling1 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.lblCashdisbursment1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton2 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lvbilling = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader55 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader56 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader57 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader58 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.MaterialFlatButton4 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.BunifuGradientPanel4 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.MaterialFlatButton3 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lvcashrr = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgvUnpaidBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvUnpaidBalance1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.BunifuGradientPanel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 15
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.btnClose)
        Me.Panel4.Controls.Add(Me.TextBox2)
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Controls.Add(Me.lblTotalCWT2)
        Me.Panel4.Controls.Add(Me.lblTotalCWT1)
        Me.Panel4.Controls.Add(Me.cmbUpdateCashReceipts)
        Me.Panel4.Controls.Add(Me.cmbAddcashReceipts)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 704)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1070, 46)
        Me.Panel4.TabIndex = 13
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(660, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 164
        Me.btnClose.Text = "Button1"
        Me.btnClose.UseVisualStyleBackColor = True
        Me.btnClose.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(418, 11)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 163
        Me.TextBox2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(315, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 162
        Me.TextBox1.Visible = False
        '
        'lblTotalCWT2
        '
        Me.lblTotalCWT2.AutoSize = True
        Me.lblTotalCWT2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblTotalCWT2.Location = New System.Drawing.Point(524, 12)
        Me.lblTotalCWT2.Name = "lblTotalCWT2"
        Me.lblTotalCWT2.Size = New System.Drawing.Size(32, 16)
        Me.lblTotalCWT2.TabIndex = 161
        Me.lblTotalCWT2.Text = "0.00"
        Me.lblTotalCWT2.Visible = False
        '
        'lblTotalCWT1
        '
        Me.lblTotalCWT1.AutoSize = True
        Me.lblTotalCWT1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblTotalCWT1.Location = New System.Drawing.Point(821, 12)
        Me.lblTotalCWT1.Name = "lblTotalCWT1"
        Me.lblTotalCWT1.Size = New System.Drawing.Size(32, 16)
        Me.lblTotalCWT1.TabIndex = 160
        Me.lblTotalCWT1.Text = "0.00"
        Me.lblTotalCWT1.Visible = False
        '
        'cmbUpdateCashReceipts
        '
        Me.cmbUpdateCashReceipts.FormattingEnabled = True
        Me.cmbUpdateCashReceipts.Location = New System.Drawing.Point(159, 11)
        Me.cmbUpdateCashReceipts.Name = "cmbUpdateCashReceipts"
        Me.cmbUpdateCashReceipts.Size = New System.Drawing.Size(121, 21)
        Me.cmbUpdateCashReceipts.TabIndex = 76
        Me.cmbUpdateCashReceipts.Visible = False
        '
        'cmbAddcashReceipts
        '
        Me.cmbAddcashReceipts.FormattingEnabled = True
        Me.cmbAddcashReceipts.Location = New System.Drawing.Point(33, 11)
        Me.cmbAddcashReceipts.Name = "cmbAddcashReceipts"
        Me.cmbAddcashReceipts.Size = New System.Drawing.Size(121, 21)
        Me.cmbAddcashReceipts.TabIndex = 75
        Me.cmbAddcashReceipts.Visible = False
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
        Me.Panel1.Size = New System.Drawing.Size(1070, 28)
        Me.Panel1.TabIndex = 11
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox3.Image = Global.ZamaryanSystem.My.Resources.Resources.Minimize_White
        Me.PictureBox3.Location = New System.Drawing.Point(983, 0)
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
        Me.PictureBox2.Location = New System.Drawing.Point(1012, 0)
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
        Me.PictureBox1.Location = New System.Drawing.Point(1041, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 56)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(1070, 28)
        Me.MaterialTabSelector1.TabIndex = 15
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage3)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage4)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialTabControl1.Location = New System.Drawing.Point(0, 84)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(1070, 620)
        Me.MaterialTabControl1.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.txtAmtPdrr)
        Me.TabPage1.Controls.Add(Me.Label38)
        Me.TabPage1.Controls.Add(Me.txtCheckNumber)
        Me.TabPage1.Controls.Add(Me.Label32)
        Me.TabPage1.Controls.Add(Me.lbltotalcwt)
        Me.TabPage1.Controls.Add(Me.lblamountwords)
        Me.TabPage1.Controls.Add(Me.lblamountpaid)
        Me.TabPage1.Controls.Add(Me.lblAmountPaid1)
        Me.TabPage1.Controls.Add(Me.Panel7)
        Me.TabPage1.Controls.Add(Me.Panel6)
        Me.TabPage1.Controls.Add(Me.lblDate)
        Me.TabPage1.Controls.Add(Me.Label25)
        Me.TabPage1.Controls.Add(Me.lvcashdisbursement)
        Me.TabPage1.Controls.Add(Me.lblDisbursmentID)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.cmbModeofPayment)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.cmbSupplierBilling)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.txtCDSWebsite)
        Me.TabPage1.Controls.Add(Me.txtCDSTin)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.txtCDSEmail)
        Me.TabPage1.Controls.Add(Me.txtCDSID)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.txtCDSFax)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.txtCDSAddress)
        Me.TabPage1.Controls.Add(Me.txtCDSZip)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.txtCDSContact)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.txtCDSNumber)
        Me.TabPage1.Controls.Add(Me.lblcwt)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.Label28)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.Label26)
        Me.TabPage1.Controls.Add(Me.dgvUnpaidBalance)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(1)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabPage1.Size = New System.Drawing.Size(1062, 594)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inventory - CD"
        '
        'txtAmtPdrr
        '
        Me.txtAmtPdrr.Depth = 0
        Me.txtAmtPdrr.Enabled = False
        Me.txtAmtPdrr.Hint = ""
        Me.txtAmtPdrr.Location = New System.Drawing.Point(155, 563)
        Me.txtAmtPdrr.MaxLength = 32767
        Me.txtAmtPdrr.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtAmtPdrr.Name = "txtAmtPdrr"
        Me.txtAmtPdrr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAmtPdrr.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAmtPdrr.SelectedText = ""
        Me.txtAmtPdrr.SelectionLength = 0
        Me.txtAmtPdrr.SelectionStart = 0
        Me.txtAmtPdrr.Size = New System.Drawing.Size(217, 23)
        Me.txtAmtPdrr.TabIndex = 241
        Me.txtAmtPdrr.TabStop = False
        Me.txtAmtPdrr.UseSystemPasswordChar = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label38.Location = New System.Drawing.Point(23, 569)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(84, 16)
        Me.Label38.TabIndex = 240
        Me.Label38.Text = "Amount Paid"
        '
        'txtCheckNumber
        '
        Me.txtCheckNumber.Depth = 0
        Me.txtCheckNumber.Hint = ""
        Me.txtCheckNumber.Location = New System.Drawing.Point(572, 215)
        Me.txtCheckNumber.MaxLength = 10
        Me.txtCheckNumber.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCheckNumber.Name = "txtCheckNumber"
        Me.txtCheckNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCheckNumber.SelectedText = ""
        Me.txtCheckNumber.SelectionLength = 0
        Me.txtCheckNumber.SelectionStart = 0
        Me.txtCheckNumber.Size = New System.Drawing.Size(217, 23)
        Me.txtCheckNumber.TabIndex = 239
        Me.txtCheckNumber.TabStop = False
        Me.txtCheckNumber.UseSystemPasswordChar = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(440, 219)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(97, 16)
        Me.Label32.TabIndex = 238
        Me.Label32.Text = "Check Number"
        '
        'lbltotalcwt
        '
        Me.lbltotalcwt.Depth = 0
        Me.lbltotalcwt.Enabled = False
        Me.lbltotalcwt.Hint = ""
        Me.lbltotalcwt.Location = New System.Drawing.Point(155, 537)
        Me.lbltotalcwt.MaxLength = 32767
        Me.lbltotalcwt.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbltotalcwt.Name = "lbltotalcwt"
        Me.lbltotalcwt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lbltotalcwt.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbltotalcwt.SelectedText = ""
        Me.lbltotalcwt.SelectionLength = 0
        Me.lbltotalcwt.SelectionStart = 0
        Me.lbltotalcwt.Size = New System.Drawing.Size(217, 23)
        Me.lbltotalcwt.TabIndex = 203
        Me.lbltotalcwt.TabStop = False
        Me.lbltotalcwt.UseSystemPasswordChar = False
        '
        'lblamountwords
        '
        Me.lblamountwords.Depth = 0
        Me.lblamountwords.Enabled = False
        Me.lblamountwords.Hint = ""
        Me.lblamountwords.Location = New System.Drawing.Point(523, 510)
        Me.lblamountwords.MaxLength = 32767
        Me.lblamountwords.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblamountwords.Name = "lblamountwords"
        Me.lblamountwords.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblamountwords.SelectedText = ""
        Me.lblamountwords.SelectionLength = 0
        Me.lblamountwords.SelectionStart = 0
        Me.lblamountwords.Size = New System.Drawing.Size(319, 23)
        Me.lblamountwords.TabIndex = 202
        Me.lblamountwords.TabStop = False
        Me.lblamountwords.UseSystemPasswordChar = False
        '
        'lblamountpaid
        '
        Me.lblamountpaid.Depth = 0
        Me.lblamountpaid.Enabled = False
        Me.lblamountpaid.Hint = ""
        Me.lblamountpaid.Location = New System.Drawing.Point(155, 510)
        Me.lblamountpaid.MaxLength = 32767
        Me.lblamountpaid.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblamountpaid.Name = "lblamountpaid"
        Me.lblamountpaid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblamountpaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblamountpaid.SelectedText = ""
        Me.lblamountpaid.SelectionLength = 0
        Me.lblamountpaid.SelectionStart = 0
        Me.lblamountpaid.Size = New System.Drawing.Size(217, 23)
        Me.lblamountpaid.TabIndex = 201
        Me.lblamountpaid.TabStop = False
        Me.lblamountpaid.UseSystemPasswordChar = False
        '
        'lblAmountPaid1
        '
        Me.lblAmountPaid1.AutoSize = True
        Me.lblAmountPaid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblAmountPaid1.Location = New System.Drawing.Point(770, 559)
        Me.lblAmountPaid1.Name = "lblAmountPaid1"
        Me.lblAmountPaid1.Size = New System.Drawing.Size(32, 16)
        Me.lblAmountPaid1.TabIndex = 200
        Me.lblAmountPaid1.Text = "0.00"
        Me.lblAmountPaid1.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel7.Controls.Add(Me.btnCancelIventory)
        Me.Panel7.Location = New System.Drawing.Point(962, 509)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(93, 38)
        Me.Panel7.TabIndex = 199
        '
        'btnCancelIventory
        '
        Me.btnCancelIventory.AutoSize = True
        Me.btnCancelIventory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancelIventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCancelIventory.Depth = 0
        Me.btnCancelIventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancelIventory.Icon = Nothing
        Me.btnCancelIventory.Location = New System.Drawing.Point(0, 0)
        Me.btnCancelIventory.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancelIventory.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancelIventory.Name = "btnCancelIventory"
        Me.btnCancelIventory.Primary = False
        Me.btnCancelIventory.Size = New System.Drawing.Size(93, 38)
        Me.btnCancelIventory.TabIndex = 0
        Me.btnCancelIventory.Text = "Cancel"
        Me.btnCancelIventory.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel6.Controls.Add(Me.btnHeaderSave)
        Me.Panel6.Location = New System.Drawing.Point(862, 509)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(93, 38)
        Me.Panel6.TabIndex = 198
        '
        'btnHeaderSave
        '
        Me.btnHeaderSave.AutoSize = True
        Me.btnHeaderSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHeaderSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnHeaderSave.Depth = 0
        Me.btnHeaderSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHeaderSave.Icon = Nothing
        Me.btnHeaderSave.Location = New System.Drawing.Point(0, 0)
        Me.btnHeaderSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnHeaderSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnHeaderSave.Name = "btnHeaderSave"
        Me.btnHeaderSave.Primary = False
        Me.btnHeaderSave.Size = New System.Drawing.Size(93, 38)
        Me.btnHeaderSave.TabIndex = 0
        Me.btnHeaderSave.Text = "Save"
        Me.btnHeaderSave.UseVisualStyleBackColor = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(500, 40)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(11, 16)
        Me.lblDate.TabIndex = 197
        Me.lblDate.Text = "."
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(437, 40)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(37, 16)
        Me.Label25.TabIndex = 196
        Me.Label25.Text = "Date"
        '
        'lvcashdisbursement
        '
        Me.lvcashdisbursement.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lvcashdisbursement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lvcashdisbursement.Location = New System.Drawing.Point(879, 38)
        Me.lvcashdisbursement.Name = "lvcashdisbursement"
        Me.lvcashdisbursement.Size = New System.Drawing.Size(59, 60)
        Me.lvcashdisbursement.TabIndex = 195
        Me.lvcashdisbursement.UseCompatibleStateImageBehavior = False
        Me.lvcashdisbursement.View = System.Windows.Forms.View.Details
        Me.lvcashdisbursement.Visible = False
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Disbursement ID"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Report ID"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "CWT"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Amount Paid"
        '
        'lblDisbursmentID
        '
        Me.lblDisbursmentID.AutoSize = True
        Me.lblDisbursmentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisbursmentID.Location = New System.Drawing.Point(168, 9)
        Me.lblDisbursmentID.Name = "lblDisbursmentID"
        Me.lblDisbursmentID.Size = New System.Drawing.Size(11, 16)
        Me.lblDisbursmentID.TabIndex = 194
        Me.lblDisbursmentID.Text = "."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 16)
        Me.Label12.TabIndex = 193
        Me.Label12.Text = "Cash Disbursment"
        '
        'cmbModeofPayment
        '
        Me.cmbModeofPayment.BackColor = System.Drawing.Color.Transparent
        Me.cmbModeofPayment.BorderRadius = 3
        Me.cmbModeofPayment.DisabledColor = System.Drawing.Color.Gray
        Me.cmbModeofPayment.ForeColor = System.Drawing.Color.White
        Me.cmbModeofPayment.Items = New String(-1) {}
        Me.cmbModeofPayment.Location = New System.Drawing.Point(569, 186)
        Me.cmbModeofPayment.Name = "cmbModeofPayment"
        Me.cmbModeofPayment.NomalColor = System.Drawing.SystemColors.HotTrack
        Me.cmbModeofPayment.onHoverColor = System.Drawing.SystemColors.Highlight
        Me.cmbModeofPayment.selectedIndex = -1
        Me.cmbModeofPayment.Size = New System.Drawing.Size(217, 28)
        Me.cmbModeofPayment.TabIndex = 192
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 16)
        Me.Label13.TabIndex = 172
        Me.Label13.Text = "Payee"
        '
        'cmbSupplierBilling
        '
        Me.cmbSupplierBilling.AllowDrop = True
        Me.cmbSupplierBilling.BackColor = System.Drawing.Color.Turquoise
        Me.cmbSupplierBilling.BorderRadius = 3
        Me.cmbSupplierBilling.DisabledColor = System.Drawing.Color.Gray
        Me.cmbSupplierBilling.ForeColor = System.Drawing.Color.White
        Me.cmbSupplierBilling.Items = New String(-1) {}
        Me.cmbSupplierBilling.Location = New System.Drawing.Point(169, 38)
        Me.cmbSupplierBilling.Name = "cmbSupplierBilling"
        Me.cmbSupplierBilling.NomalColor = System.Drawing.SystemColors.HotTrack
        Me.cmbSupplierBilling.onHoverColor = System.Drawing.SystemColors.Highlight
        Me.cmbSupplierBilling.selectedIndex = -1
        Me.cmbSupplierBilling.Size = New System.Drawing.Size(217, 28)
        Me.cmbSupplierBilling.TabIndex = 171
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(437, 191)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(113, 16)
        Me.Label23.TabIndex = 191
        Me.Label23.Text = "Mode of Payment"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 16)
        Me.Label14.TabIndex = 173
        Me.Label14.Text = "Payee ID"
        '
        'txtCDSWebsite
        '
        Me.txtCDSWebsite.Depth = 0
        Me.txtCDSWebsite.Enabled = False
        Me.txtCDSWebsite.Hint = ""
        Me.txtCDSWebsite.Location = New System.Drawing.Point(569, 157)
        Me.txtCDSWebsite.MaxLength = 32767
        Me.txtCDSWebsite.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCDSWebsite.Name = "txtCDSWebsite"
        Me.txtCDSWebsite.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCDSWebsite.SelectedText = ""
        Me.txtCDSWebsite.SelectionLength = 0
        Me.txtCDSWebsite.SelectionStart = 0
        Me.txtCDSWebsite.Size = New System.Drawing.Size(217, 23)
        Me.txtCDSWebsite.TabIndex = 188
        Me.txtCDSWebsite.TabStop = False
        Me.txtCDSWebsite.UseSystemPasswordChar = False
        '
        'txtCDSTin
        '
        Me.txtCDSTin.Depth = 0
        Me.txtCDSTin.Enabled = False
        Me.txtCDSTin.Hint = ""
        Me.txtCDSTin.Location = New System.Drawing.Point(172, 183)
        Me.txtCDSTin.MaxLength = 32767
        Me.txtCDSTin.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCDSTin.Name = "txtCDSTin"
        Me.txtCDSTin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCDSTin.SelectedText = ""
        Me.txtCDSTin.SelectionLength = 0
        Me.txtCDSTin.SelectionStart = 0
        Me.txtCDSTin.Size = New System.Drawing.Size(217, 23)
        Me.txtCDSTin.TabIndex = 190
        Me.txtCDSTin.TabStop = False
        Me.txtCDSTin.UseSystemPasswordChar = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(437, 161)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 16)
        Me.Label18.TabIndex = 187
        Me.Label18.Text = "Website"
        '
        'txtCDSEmail
        '
        Me.txtCDSEmail.Depth = 0
        Me.txtCDSEmail.Enabled = False
        Me.txtCDSEmail.Hint = ""
        Me.txtCDSEmail.Location = New System.Drawing.Point(569, 131)
        Me.txtCDSEmail.MaxLength = 32767
        Me.txtCDSEmail.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCDSEmail.Name = "txtCDSEmail"
        Me.txtCDSEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCDSEmail.SelectedText = ""
        Me.txtCDSEmail.SelectionLength = 0
        Me.txtCDSEmail.SelectionStart = 0
        Me.txtCDSEmail.Size = New System.Drawing.Size(217, 23)
        Me.txtCDSEmail.TabIndex = 186
        Me.txtCDSEmail.TabStop = False
        Me.txtCDSEmail.UseSystemPasswordChar = False
        '
        'txtCDSID
        '
        Me.txtCDSID.Depth = 0
        Me.txtCDSID.Enabled = False
        Me.txtCDSID.Hint = ""
        Me.txtCDSID.Location = New System.Drawing.Point(172, 75)
        Me.txtCDSID.MaxLength = 32767
        Me.txtCDSID.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCDSID.Name = "txtCDSID"
        Me.txtCDSID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCDSID.SelectedText = ""
        Me.txtCDSID.SelectionLength = 0
        Me.txtCDSID.SelectionStart = 0
        Me.txtCDSID.Size = New System.Drawing.Size(217, 23)
        Me.txtCDSID.TabIndex = 174
        Me.txtCDSID.TabStop = False
        Me.txtCDSID.UseSystemPasswordChar = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(437, 135)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 16)
        Me.Label19.TabIndex = 185
        Me.Label19.Text = "Email"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(24, 187)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(27, 16)
        Me.Label22.TabIndex = 189
        Me.Label22.Text = "Tin"
        '
        'txtCDSFax
        '
        Me.txtCDSFax.Depth = 0
        Me.txtCDSFax.Enabled = False
        Me.txtCDSFax.Hint = ""
        Me.txtCDSFax.Location = New System.Drawing.Point(569, 105)
        Me.txtCDSFax.MaxLength = 32767
        Me.txtCDSFax.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCDSFax.Name = "txtCDSFax"
        Me.txtCDSFax.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCDSFax.SelectedText = ""
        Me.txtCDSFax.SelectionLength = 0
        Me.txtCDSFax.SelectionStart = 0
        Me.txtCDSFax.Size = New System.Drawing.Size(217, 23)
        Me.txtCDSFax.TabIndex = 184
        Me.txtCDSFax.TabStop = False
        Me.txtCDSFax.UseSystemPasswordChar = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(24, 109)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 16)
        Me.Label15.TabIndex = 175
        Me.Label15.Text = "Address"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(437, 109)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(30, 16)
        Me.Label20.TabIndex = 183
        Me.Label20.Text = "Fax"
        '
        'txtCDSAddress
        '
        Me.txtCDSAddress.Depth = 0
        Me.txtCDSAddress.Enabled = False
        Me.txtCDSAddress.Hint = ""
        Me.txtCDSAddress.Location = New System.Drawing.Point(172, 105)
        Me.txtCDSAddress.MaxLength = 32767
        Me.txtCDSAddress.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCDSAddress.Name = "txtCDSAddress"
        Me.txtCDSAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCDSAddress.SelectedText = ""
        Me.txtCDSAddress.SelectionLength = 0
        Me.txtCDSAddress.SelectionStart = 0
        Me.txtCDSAddress.Size = New System.Drawing.Size(217, 23)
        Me.txtCDSAddress.TabIndex = 176
        Me.txtCDSAddress.TabStop = False
        Me.txtCDSAddress.UseSystemPasswordChar = False
        '
        'txtCDSZip
        '
        Me.txtCDSZip.Depth = 0
        Me.txtCDSZip.Enabled = False
        Me.txtCDSZip.Hint = ""
        Me.txtCDSZip.Location = New System.Drawing.Point(569, 75)
        Me.txtCDSZip.MaxLength = 32767
        Me.txtCDSZip.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCDSZip.Name = "txtCDSZip"
        Me.txtCDSZip.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCDSZip.SelectedText = ""
        Me.txtCDSZip.SelectionLength = 0
        Me.txtCDSZip.SelectionStart = 0
        Me.txtCDSZip.Size = New System.Drawing.Size(217, 23)
        Me.txtCDSZip.TabIndex = 182
        Me.txtCDSZip.TabStop = False
        Me.txtCDSZip.UseSystemPasswordChar = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(24, 135)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(99, 16)
        Me.Label16.TabIndex = 177
        Me.Label16.Text = "Contact Person"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(437, 79)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 16)
        Me.Label21.TabIndex = 181
        Me.Label21.Text = "Zip Code"
        '
        'txtCDSContact
        '
        Me.txtCDSContact.Depth = 0
        Me.txtCDSContact.Enabled = False
        Me.txtCDSContact.Hint = ""
        Me.txtCDSContact.Location = New System.Drawing.Point(172, 131)
        Me.txtCDSContact.MaxLength = 32767
        Me.txtCDSContact.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCDSContact.Name = "txtCDSContact"
        Me.txtCDSContact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCDSContact.SelectedText = ""
        Me.txtCDSContact.SelectionLength = 0
        Me.txtCDSContact.SelectionStart = 0
        Me.txtCDSContact.Size = New System.Drawing.Size(217, 23)
        Me.txtCDSContact.TabIndex = 178
        Me.txtCDSContact.TabStop = False
        Me.txtCDSContact.UseSystemPasswordChar = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(24, 161)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 16)
        Me.Label17.TabIndex = 179
        Me.Label17.Text = "Phone Number"
        '
        'txtCDSNumber
        '
        Me.txtCDSNumber.Depth = 0
        Me.txtCDSNumber.Enabled = False
        Me.txtCDSNumber.Hint = ""
        Me.txtCDSNumber.Location = New System.Drawing.Point(172, 157)
        Me.txtCDSNumber.MaxLength = 32767
        Me.txtCDSNumber.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCDSNumber.Name = "txtCDSNumber"
        Me.txtCDSNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCDSNumber.SelectedText = ""
        Me.txtCDSNumber.SelectionLength = 0
        Me.txtCDSNumber.SelectionStart = 0
        Me.txtCDSNumber.Size = New System.Drawing.Size(217, 23)
        Me.txtCDSNumber.TabIndex = 180
        Me.txtCDSNumber.TabStop = False
        Me.txtCDSNumber.UseSystemPasswordChar = False
        '
        'lblcwt
        '
        Me.lblcwt.AutoSize = True
        Me.lblcwt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblcwt.Location = New System.Drawing.Point(883, 163)
        Me.lblcwt.Name = "lblcwt"
        Me.lblcwt.Size = New System.Drawing.Size(15, 16)
        Me.lblcwt.TabIndex = 169
        Me.lblcwt.Text = "0"
        Me.lblcwt.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label24.Location = New System.Drawing.Point(395, 516)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(105, 16)
        Me.Label24.TabIndex = 168
        Me.Label24.Text = "Amount in words"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label28.Location = New System.Drawing.Point(24, 516)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 16)
        Me.Label28.TabIndex = 163
        Me.Label28.Text = "Sub Amount"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label27.Location = New System.Drawing.Point(26, 543)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(73, 16)
        Me.Label27.TabIndex = 164
        Me.Label27.Text = "Total CWT"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label26.Location = New System.Drawing.Point(840, 163)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(39, 16)
        Me.Label26.TabIndex = 167
        Me.Label26.Text = "CWT"
        Me.Label26.Visible = False
        '
        'dgvUnpaidBalance
        '
        Me.dgvUnpaidBalance.AllowUserToAddRows = False
        Me.dgvUnpaidBalance.AllowUserToDeleteRows = False
        Me.dgvUnpaidBalance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUnpaidBalance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvUnpaidBalance.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvUnpaidBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUnpaidBalance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column8, Me.Column4, Me.Column5, Me.Column7, Me.Column6})
        Me.dgvUnpaidBalance.Location = New System.Drawing.Point(21, 241)
        Me.dgvUnpaidBalance.Name = "dgvUnpaidBalance"
        Me.dgvUnpaidBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUnpaidBalance.Size = New System.Drawing.Size(1090, 250)
        Me.dgvUnpaidBalance.TabIndex = 162
        '
        'Column1
        '
        Me.Column1.HeaderText = "Paid"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Receiving Report ID"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Due Date"
        Me.Column3.Name = "Column3"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Base Amount"
        Me.Column8.Name = "Column8"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Input VAT"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total"
        Me.Column5.Name = "Column5"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Withholding Tax Payable"
        Me.Column7.Name = "Column7"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Amount Paid"
        Me.Column6.Name = "Column6"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.txtAmtPd1)
        Me.TabPage2.Controls.Add(Me.Label39)
        Me.TabPage2.Controls.Add(Me.txtCheckNumber2)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.lbltotalcwt3)
        Me.TabPage2.Controls.Add(Me.lblamountwords2)
        Me.TabPage2.Controls.Add(Me.lblamountpaid2)
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Controls.Add(Me.Label34)
        Me.TabPage2.Controls.Add(Me.Label36)
        Me.TabPage2.Controls.Add(Me.Label37)
        Me.TabPage2.Controls.Add(Me.dgvUnpaidBalance1)
        Me.TabPage2.Controls.Add(Me.lblDateAPV)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.ListView1)
        Me.TabPage2.Controls.Add(Me.cmbModeofPayment1)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtCDSWebsite1)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txtCDSEmail1)
        Me.TabPage2.Controls.Add(Me.Label29)
        Me.TabPage2.Controls.Add(Me.txtCDSFax1)
        Me.TabPage2.Controls.Add(Me.Label30)
        Me.TabPage2.Controls.Add(Me.txtCDSZip1)
        Me.TabPage2.Controls.Add(Me.Label31)
        Me.TabPage2.Controls.Add(Me.lblcwt1)
        Me.TabPage2.Controls.Add(Me.Label33)
        Me.TabPage2.Controls.Add(Me.txtCDSTin1)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtCDSAddress1)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtCDSContact1)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtCDSNumber1)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtCDSID1)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.cmbSupplierBilling1)
        Me.TabPage2.Controls.Add(Me.lblCashdisbursment1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(1)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabPage2.Size = New System.Drawing.Size(1062, 594)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Accounts payable voucher - CD"
        '
        'txtAmtPd1
        '
        Me.txtAmtPd1.Depth = 0
        Me.txtAmtPd1.Enabled = False
        Me.txtAmtPd1.Hint = ""
        Me.txtAmtPd1.Location = New System.Drawing.Point(119, 536)
        Me.txtAmtPd1.MaxLength = 32767
        Me.txtAmtPd1.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtAmtPd1.Name = "txtAmtPd1"
        Me.txtAmtPd1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAmtPd1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAmtPd1.SelectedText = ""
        Me.txtAmtPd1.SelectionLength = 0
        Me.txtAmtPd1.SelectionStart = 0
        Me.txtAmtPd1.Size = New System.Drawing.Size(217, 23)
        Me.txtAmtPd1.TabIndex = 239
        Me.txtAmtPd1.TabStop = False
        Me.txtAmtPd1.UseSystemPasswordChar = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label39.Location = New System.Drawing.Point(26, 542)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(84, 16)
        Me.Label39.TabIndex = 238
        Me.Label39.Text = "Amount Paid"
        '
        'txtCheckNumber2
        '
        Me.txtCheckNumber2.Depth = 0
        Me.txtCheckNumber2.Hint = ""
        Me.txtCheckNumber2.Location = New System.Drawing.Point(539, 194)
        Me.txtCheckNumber2.MaxLength = 10
        Me.txtCheckNumber2.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCheckNumber2.Name = "txtCheckNumber2"
        Me.txtCheckNumber2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCheckNumber2.SelectedText = ""
        Me.txtCheckNumber2.SelectionLength = 0
        Me.txtCheckNumber2.SelectionStart = 0
        Me.txtCheckNumber2.Size = New System.Drawing.Size(217, 23)
        Me.txtCheckNumber2.TabIndex = 237
        Me.txtCheckNumber2.TabStop = False
        Me.txtCheckNumber2.UseSystemPasswordChar = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(407, 198)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 16)
        Me.Label8.TabIndex = 236
        Me.Label8.Text = "Check Number"
        '
        'lbltotalcwt3
        '
        Me.lbltotalcwt3.Depth = 0
        Me.lbltotalcwt3.Enabled = False
        Me.lbltotalcwt3.Hint = ""
        Me.lbltotalcwt3.Location = New System.Drawing.Point(119, 505)
        Me.lbltotalcwt3.MaxLength = 32767
        Me.lbltotalcwt3.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbltotalcwt3.Name = "lbltotalcwt3"
        Me.lbltotalcwt3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lbltotalcwt3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbltotalcwt3.SelectedText = ""
        Me.lbltotalcwt3.SelectionLength = 0
        Me.lbltotalcwt3.SelectionStart = 0
        Me.lbltotalcwt3.Size = New System.Drawing.Size(217, 23)
        Me.lbltotalcwt3.TabIndex = 235
        Me.lbltotalcwt3.TabStop = False
        Me.lbltotalcwt3.UseSystemPasswordChar = False
        '
        'lblamountwords2
        '
        Me.lblamountwords2.Depth = 0
        Me.lblamountwords2.Enabled = False
        Me.lblamountwords2.Hint = ""
        Me.lblamountwords2.Location = New System.Drawing.Point(498, 480)
        Me.lblamountwords2.MaxLength = 32767
        Me.lblamountwords2.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblamountwords2.Name = "lblamountwords2"
        Me.lblamountwords2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblamountwords2.SelectedText = ""
        Me.lblamountwords2.SelectionLength = 0
        Me.lblamountwords2.SelectionStart = 0
        Me.lblamountwords2.Size = New System.Drawing.Size(296, 23)
        Me.lblamountwords2.TabIndex = 234
        Me.lblamountwords2.TabStop = False
        Me.lblamountwords2.UseSystemPasswordChar = False
        '
        'lblamountpaid2
        '
        Me.lblamountpaid2.Depth = 0
        Me.lblamountpaid2.Enabled = False
        Me.lblamountpaid2.Hint = ""
        Me.lblamountpaid2.Location = New System.Drawing.Point(119, 476)
        Me.lblamountpaid2.MaxLength = 32767
        Me.lblamountpaid2.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblamountpaid2.Name = "lblamountpaid2"
        Me.lblamountpaid2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblamountpaid2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblamountpaid2.SelectedText = ""
        Me.lblamountpaid2.SelectionLength = 0
        Me.lblamountpaid2.SelectionStart = 0
        Me.lblamountpaid2.Size = New System.Drawing.Size(217, 23)
        Me.lblamountpaid2.TabIndex = 233
        Me.lblamountpaid2.TabStop = False
        Me.lblamountpaid2.UseSystemPasswordChar = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel5.Controls.Add(Me.btnHeaderSave1)
        Me.Panel5.Location = New System.Drawing.Point(849, 479)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(93, 38)
        Me.Panel5.TabIndex = 231
        '
        'btnHeaderSave1
        '
        Me.btnHeaderSave1.AutoSize = True
        Me.btnHeaderSave1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHeaderSave1.Depth = 0
        Me.btnHeaderSave1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnHeaderSave1.Icon = Nothing
        Me.btnHeaderSave1.Location = New System.Drawing.Point(0, 0)
        Me.btnHeaderSave1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnHeaderSave1.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnHeaderSave1.Name = "btnHeaderSave1"
        Me.btnHeaderSave1.Primary = False
        Me.btnHeaderSave1.Size = New System.Drawing.Size(93, 38)
        Me.btnHeaderSave1.TabIndex = 0
        Me.btnHeaderSave1.Text = "Save"
        Me.btnHeaderSave1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel3.Controls.Add(Me.btnCancelAPV)
        Me.Panel3.Location = New System.Drawing.Point(948, 479)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(93, 38)
        Me.Panel3.TabIndex = 232
        '
        'btnCancelAPV
        '
        Me.btnCancelAPV.AutoSize = True
        Me.btnCancelAPV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancelAPV.Depth = 0
        Me.btnCancelAPV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancelAPV.Icon = Nothing
        Me.btnCancelAPV.Location = New System.Drawing.Point(0, 0)
        Me.btnCancelAPV.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancelAPV.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancelAPV.Name = "btnCancelAPV"
        Me.btnCancelAPV.Primary = False
        Me.btnCancelAPV.Size = New System.Drawing.Size(93, 38)
        Me.btnCancelAPV.TabIndex = 0
        Me.btnCancelAPV.Text = "Cancel"
        Me.btnCancelAPV.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label34.Location = New System.Drawing.Point(369, 486)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(105, 16)
        Me.Label34.TabIndex = 229
        Me.Label34.Text = "Amount in words"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label36.Location = New System.Drawing.Point(26, 480)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(80, 16)
        Me.Label36.TabIndex = 225
        Me.Label36.Text = "Sub Amount"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label37.Location = New System.Drawing.Point(26, 511)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(73, 16)
        Me.Label37.TabIndex = 226
        Me.Label37.Text = "Total CWT"
        '
        'dgvUnpaidBalance1
        '
        Me.dgvUnpaidBalance1.AllowUserToAddRows = False
        Me.dgvUnpaidBalance1.AllowUserToDeleteRows = False
        Me.dgvUnpaidBalance1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUnpaidBalance1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvUnpaidBalance1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvUnpaidBalance1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUnpaidBalance1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Column9, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.dgvUnpaidBalance1.Location = New System.Drawing.Point(22, 220)
        Me.dgvUnpaidBalance1.Name = "dgvUnpaidBalance1"
        Me.dgvUnpaidBalance1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUnpaidBalance1.Size = New System.Drawing.Size(1090, 250)
        Me.dgvUnpaidBalance1.TabIndex = 224
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Paid"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Accounts Payable Voucher ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "Due Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Base Amount"
        Me.Column9.Name = "Column9"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Input VAT"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Withholding Tax Payable"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Amount Paid"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'lblDateAPV
        '
        Me.lblDateAPV.AutoSize = True
        Me.lblDateAPV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateAPV.Location = New System.Drawing.Point(470, 18)
        Me.lblDateAPV.Name = "lblDateAPV"
        Me.lblDateAPV.Size = New System.Drawing.Size(11, 16)
        Me.lblDateAPV.TabIndex = 223
        Me.lblDateAPV.Text = "."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(407, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 16)
        Me.Label9.TabIndex = 222
        Me.Label9.Text = "Date"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ListView1.Location = New System.Drawing.Point(798, 16)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(51, 60)
        Me.ListView1.TabIndex = 221
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        Me.ListView1.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Disbursement ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Report ID"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "CWT"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Amount Paid"
        '
        'cmbModeofPayment1
        '
        Me.cmbModeofPayment1.BackColor = System.Drawing.Color.Transparent
        Me.cmbModeofPayment1.BorderRadius = 3
        Me.cmbModeofPayment1.DisabledColor = System.Drawing.Color.Gray
        Me.cmbModeofPayment1.ForeColor = System.Drawing.Color.White
        Me.cmbModeofPayment1.Items = New String(-1) {}
        Me.cmbModeofPayment1.Location = New System.Drawing.Point(539, 164)
        Me.cmbModeofPayment1.Name = "cmbModeofPayment1"
        Me.cmbModeofPayment1.NomalColor = System.Drawing.SystemColors.HotTrack
        Me.cmbModeofPayment1.onHoverColor = System.Drawing.SystemColors.Highlight
        Me.cmbModeofPayment1.selectedIndex = -1
        Me.cmbModeofPayment1.Size = New System.Drawing.Size(217, 28)
        Me.cmbModeofPayment1.TabIndex = 220
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(407, 169)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 16)
        Me.Label10.TabIndex = 219
        Me.Label10.Text = "Mode of Payment"
        '
        'txtCDSWebsite1
        '
        Me.txtCDSWebsite1.Depth = 0
        Me.txtCDSWebsite1.Enabled = False
        Me.txtCDSWebsite1.Hint = ""
        Me.txtCDSWebsite1.Location = New System.Drawing.Point(539, 135)
        Me.txtCDSWebsite1.MaxLength = 32767
        Me.txtCDSWebsite1.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCDSWebsite1.Name = "txtCDSWebsite1"
        Me.txtCDSWebsite1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCDSWebsite1.SelectedText = ""
        Me.txtCDSWebsite1.SelectionLength = 0
        Me.txtCDSWebsite1.SelectionStart = 0
        Me.txtCDSWebsite1.Size = New System.Drawing.Size(217, 23)
        Me.txtCDSWebsite1.TabIndex = 218
        Me.txtCDSWebsite1.TabStop = False
        Me.txtCDSWebsite1.UseSystemPasswordChar = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(407, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 16)
        Me.Label11.TabIndex = 217
        Me.Label11.Text = "Website"
        '
        'txtCDSEmail1
        '
        Me.txtCDSEmail1.Depth = 0
        Me.txtCDSEmail1.Enabled = False
        Me.txtCDSEmail1.Hint = ""
        Me.txtCDSEmail1.Location = New System.Drawing.Point(539, 109)
        Me.txtCDSEmail1.MaxLength = 32767
        Me.txtCDSEmail1.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCDSEmail1.Name = "txtCDSEmail1"
        Me.txtCDSEmail1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCDSEmail1.SelectedText = ""
        Me.txtCDSEmail1.SelectionLength = 0
        Me.txtCDSEmail1.SelectionStart = 0
        Me.txtCDSEmail1.Size = New System.Drawing.Size(217, 23)
        Me.txtCDSEmail1.TabIndex = 216
        Me.txtCDSEmail1.TabStop = False
        Me.txtCDSEmail1.UseSystemPasswordChar = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(407, 113)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(42, 16)
        Me.Label29.TabIndex = 215
        Me.Label29.Text = "Email"
        '
        'txtCDSFax1
        '
        Me.txtCDSFax1.Depth = 0
        Me.txtCDSFax1.Enabled = False
        Me.txtCDSFax1.Hint = ""
        Me.txtCDSFax1.Location = New System.Drawing.Point(539, 83)
        Me.txtCDSFax1.MaxLength = 32767
        Me.txtCDSFax1.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCDSFax1.Name = "txtCDSFax1"
        Me.txtCDSFax1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCDSFax1.SelectedText = ""
        Me.txtCDSFax1.SelectionLength = 0
        Me.txtCDSFax1.SelectionStart = 0
        Me.txtCDSFax1.Size = New System.Drawing.Size(217, 23)
        Me.txtCDSFax1.TabIndex = 214
        Me.txtCDSFax1.TabStop = False
        Me.txtCDSFax1.UseSystemPasswordChar = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(407, 87)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(30, 16)
        Me.Label30.TabIndex = 213
        Me.Label30.Text = "Fax"
        '
        'txtCDSZip1
        '
        Me.txtCDSZip1.Depth = 0
        Me.txtCDSZip1.Enabled = False
        Me.txtCDSZip1.Hint = ""
        Me.txtCDSZip1.Location = New System.Drawing.Point(539, 53)
        Me.txtCDSZip1.MaxLength = 32767
        Me.txtCDSZip1.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCDSZip1.Name = "txtCDSZip1"
        Me.txtCDSZip1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCDSZip1.SelectedText = ""
        Me.txtCDSZip1.SelectionLength = 0
        Me.txtCDSZip1.SelectionStart = 0
        Me.txtCDSZip1.Size = New System.Drawing.Size(217, 23)
        Me.txtCDSZip1.TabIndex = 212
        Me.txtCDSZip1.TabStop = False
        Me.txtCDSZip1.UseSystemPasswordChar = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(407, 57)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(63, 16)
        Me.Label31.TabIndex = 211
        Me.Label31.Text = "Zip Code"
        '
        'lblcwt1
        '
        Me.lblcwt1.AutoSize = True
        Me.lblcwt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblcwt1.Location = New System.Drawing.Point(853, 141)
        Me.lblcwt1.Name = "lblcwt1"
        Me.lblcwt1.Size = New System.Drawing.Size(15, 16)
        Me.lblcwt1.TabIndex = 210
        Me.lblcwt1.Text = "0"
        Me.lblcwt1.Visible = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label33.Location = New System.Drawing.Point(810, 141)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(39, 16)
        Me.Label33.TabIndex = 209
        Me.Label33.Text = "CWT"
        Me.Label33.Visible = False
        '
        'txtCDSTin1
        '
        Me.txtCDSTin1.Depth = 0
        Me.txtCDSTin1.Enabled = False
        Me.txtCDSTin1.Hint = ""
        Me.txtCDSTin1.Location = New System.Drawing.Point(164, 190)
        Me.txtCDSTin1.MaxLength = 32767
        Me.txtCDSTin1.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCDSTin1.Name = "txtCDSTin1"
        Me.txtCDSTin1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCDSTin1.SelectedText = ""
        Me.txtCDSTin1.SelectionLength = 0
        Me.txtCDSTin1.SelectionStart = 0
        Me.txtCDSTin1.Size = New System.Drawing.Size(217, 23)
        Me.txtCDSTin1.TabIndex = 208
        Me.txtCDSTin1.TabStop = False
        Me.txtCDSTin1.UseSystemPasswordChar = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 207
        Me.Label4.Text = "Tin Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 16)
        Me.Label5.TabIndex = 201
        Me.Label5.Text = "Address"
        '
        'txtCDSAddress1
        '
        Me.txtCDSAddress1.Depth = 0
        Me.txtCDSAddress1.Enabled = False
        Me.txtCDSAddress1.Hint = ""
        Me.txtCDSAddress1.Location = New System.Drawing.Point(164, 112)
        Me.txtCDSAddress1.MaxLength = 32767
        Me.txtCDSAddress1.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCDSAddress1.Name = "txtCDSAddress1"
        Me.txtCDSAddress1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCDSAddress1.SelectedText = ""
        Me.txtCDSAddress1.SelectionLength = 0
        Me.txtCDSAddress1.SelectionStart = 0
        Me.txtCDSAddress1.Size = New System.Drawing.Size(217, 23)
        Me.txtCDSAddress1.TabIndex = 202
        Me.txtCDSAddress1.TabStop = False
        Me.txtCDSAddress1.UseSystemPasswordChar = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 203
        Me.Label6.Text = "Contact Person"
        '
        'txtCDSContact1
        '
        Me.txtCDSContact1.Depth = 0
        Me.txtCDSContact1.Enabled = False
        Me.txtCDSContact1.Hint = ""
        Me.txtCDSContact1.Location = New System.Drawing.Point(164, 138)
        Me.txtCDSContact1.MaxLength = 32767
        Me.txtCDSContact1.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCDSContact1.Name = "txtCDSContact1"
        Me.txtCDSContact1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCDSContact1.SelectedText = ""
        Me.txtCDSContact1.SelectionLength = 0
        Me.txtCDSContact1.SelectionStart = 0
        Me.txtCDSContact1.Size = New System.Drawing.Size(217, 23)
        Me.txtCDSContact1.TabIndex = 204
        Me.txtCDSContact1.TabStop = False
        Me.txtCDSContact1.UseSystemPasswordChar = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 16)
        Me.Label7.TabIndex = 205
        Me.Label7.Text = "Phone Number"
        '
        'txtCDSNumber1
        '
        Me.txtCDSNumber1.Depth = 0
        Me.txtCDSNumber1.Enabled = False
        Me.txtCDSNumber1.Hint = ""
        Me.txtCDSNumber1.Location = New System.Drawing.Point(164, 164)
        Me.txtCDSNumber1.MaxLength = 32767
        Me.txtCDSNumber1.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCDSNumber1.Name = "txtCDSNumber1"
        Me.txtCDSNumber1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCDSNumber1.SelectedText = ""
        Me.txtCDSNumber1.SelectionLength = 0
        Me.txtCDSNumber1.SelectionStart = 0
        Me.txtCDSNumber1.Size = New System.Drawing.Size(217, 23)
        Me.txtCDSNumber1.TabIndex = 206
        Me.txtCDSNumber1.TabStop = False
        Me.txtCDSNumber1.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 199
        Me.Label3.Text = "Payee ID"
        '
        'txtCDSID1
        '
        Me.txtCDSID1.Depth = 0
        Me.txtCDSID1.Enabled = False
        Me.txtCDSID1.Hint = ""
        Me.txtCDSID1.Location = New System.Drawing.Point(164, 85)
        Me.txtCDSID1.MaxLength = 32767
        Me.txtCDSID1.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCDSID1.Name = "txtCDSID1"
        Me.txtCDSID1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCDSID1.SelectedText = ""
        Me.txtCDSID1.SelectionLength = 0
        Me.txtCDSID1.SelectionStart = 0
        Me.txtCDSID1.Size = New System.Drawing.Size(217, 23)
        Me.txtCDSID1.TabIndex = 200
        Me.txtCDSID1.TabStop = False
        Me.txtCDSID1.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 198
        Me.Label1.Text = "Payee"
        '
        'cmbSupplierBilling1
        '
        Me.cmbSupplierBilling1.AllowDrop = True
        Me.cmbSupplierBilling1.BackColor = System.Drawing.Color.Turquoise
        Me.cmbSupplierBilling1.BorderRadius = 3
        Me.cmbSupplierBilling1.DisabledColor = System.Drawing.Color.Gray
        Me.cmbSupplierBilling1.ForeColor = System.Drawing.Color.White
        Me.cmbSupplierBilling1.Items = New String(-1) {}
        Me.cmbSupplierBilling1.Location = New System.Drawing.Point(161, 53)
        Me.cmbSupplierBilling1.Name = "cmbSupplierBilling1"
        Me.cmbSupplierBilling1.NomalColor = System.Drawing.SystemColors.HotTrack
        Me.cmbSupplierBilling1.onHoverColor = System.Drawing.SystemColors.Highlight
        Me.cmbSupplierBilling1.selectedIndex = -1
        Me.cmbSupplierBilling1.Size = New System.Drawing.Size(217, 28)
        Me.cmbSupplierBilling1.TabIndex = 197
        '
        'lblCashdisbursment1
        '
        Me.lblCashdisbursment1.AutoSize = True
        Me.lblCashdisbursment1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashdisbursment1.Location = New System.Drawing.Point(163, 23)
        Me.lblCashdisbursment1.Name = "lblCashdisbursment1"
        Me.lblCashdisbursment1.Size = New System.Drawing.Size(11, 16)
        Me.lblCashdisbursment1.TabIndex = 196
        Me.lblCashdisbursment1.Text = "."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 16)
        Me.Label2.TabIndex = 195
        Me.Label2.Text = "Cash Disbursment"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel9)
        Me.TabPage3.Controls.Add(Me.Panel8)
        Me.TabPage3.Controls.Add(Me.lvbilling)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(1)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(1)
        Me.TabPage3.Size = New System.Drawing.Size(1062, 594)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Inventory CD Report"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel9.Controls.Add(Me.MaterialFlatButton2)
        Me.Panel9.Location = New System.Drawing.Point(954, 541)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(93, 38)
        Me.Panel9.TabIndex = 233
        '
        'MaterialFlatButton2
        '
        Me.MaterialFlatButton2.AutoSize = True
        Me.MaterialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton2.Depth = 0
        Me.MaterialFlatButton2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialFlatButton2.Icon = Nothing
        Me.MaterialFlatButton2.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton2.Name = "MaterialFlatButton2"
        Me.MaterialFlatButton2.Primary = False
        Me.MaterialFlatButton2.Size = New System.Drawing.Size(93, 38)
        Me.MaterialFlatButton2.TabIndex = 0
        Me.MaterialFlatButton2.Text = "refresh"
        Me.MaterialFlatButton2.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel8.Controls.Add(Me.MaterialFlatButton1)
        Me.Panel8.Location = New System.Drawing.Point(855, 541)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(93, 38)
        Me.Panel8.TabIndex = 232
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialFlatButton1.Icon = Nothing
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(93, 38)
        Me.MaterialFlatButton1.TabIndex = 0
        Me.MaterialFlatButton1.Text = "print all"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'lvbilling
        '
        Me.lvbilling.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvbilling.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader55, Me.ColumnHeader56, Me.ColumnHeader57, Me.ColumnHeader58})
        Me.lvbilling.Depth = 0
        Me.lvbilling.Dock = System.Windows.Forms.DockStyle.Top
        Me.lvbilling.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lvbilling.FullRowSelect = True
        Me.lvbilling.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvbilling.Location = New System.Drawing.Point(1, 1)
        Me.lvbilling.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.lvbilling.MouseState = MaterialSkin.MouseState.OUT
        Me.lvbilling.Name = "lvbilling"
        Me.lvbilling.OwnerDraw = True
        Me.lvbilling.Size = New System.Drawing.Size(1060, 578)
        Me.lvbilling.TabIndex = 24
        Me.lvbilling.UseCompatibleStateImageBehavior = False
        Me.lvbilling.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader55
        '
        Me.ColumnHeader55.Text = "Reference Number"
        Me.ColumnHeader55.Width = 200
        '
        'ColumnHeader56
        '
        Me.ColumnHeader56.Text = "Date"
        Me.ColumnHeader56.Width = 250
        '
        'ColumnHeader57
        '
        Me.ColumnHeader57.Text = "Grand Total"
        Me.ColumnHeader57.Width = 250
        '
        'ColumnHeader58
        '
        Me.ColumnHeader58.Text = "Payee"
        Me.ColumnHeader58.Width = 250
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.BunifuGradientPanel1)
        Me.TabPage4.Controls.Add(Me.BunifuGradientPanel4)
        Me.TabPage4.Controls.Add(Me.lvcashrr)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(1)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(1)
        Me.TabPage4.Size = New System.Drawing.Size(1062, 594)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Accounts payable voucher CD Report"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.CadetBlue
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.MaterialFlatButton4)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(838, 534)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(81, 38)
        Me.BunifuGradientPanel1.TabIndex = 146
        '
        'MaterialFlatButton4
        '
        Me.MaterialFlatButton4.AutoSize = True
        Me.MaterialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton4.Depth = 0
        Me.MaterialFlatButton4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialFlatButton4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MaterialFlatButton4.Icon = Nothing
        Me.MaterialFlatButton4.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton4.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton4.Name = "MaterialFlatButton4"
        Me.MaterialFlatButton4.Primary = False
        Me.MaterialFlatButton4.Size = New System.Drawing.Size(81, 38)
        Me.MaterialFlatButton4.TabIndex = 140
        Me.MaterialFlatButton4.Text = "refresh"
        Me.MaterialFlatButton4.UseVisualStyleBackColor = True
        '
        'BunifuGradientPanel4
        '
        Me.BunifuGradientPanel4.BackColor = System.Drawing.Color.CadetBlue
        Me.BunifuGradientPanel4.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel4.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel4.Controls.Add(Me.MaterialFlatButton3)
        Me.BunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel4.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel4.Location = New System.Drawing.Point(750, 534)
        Me.BunifuGradientPanel4.Name = "BunifuGradientPanel4"
        Me.BunifuGradientPanel4.Quality = 10
        Me.BunifuGradientPanel4.Size = New System.Drawing.Size(81, 38)
        Me.BunifuGradientPanel4.TabIndex = 145
        '
        'MaterialFlatButton3
        '
        Me.MaterialFlatButton3.AutoSize = True
        Me.MaterialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton3.Depth = 0
        Me.MaterialFlatButton3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialFlatButton3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MaterialFlatButton3.Icon = Nothing
        Me.MaterialFlatButton3.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton3.Name = "MaterialFlatButton3"
        Me.MaterialFlatButton3.Primary = False
        Me.MaterialFlatButton3.Size = New System.Drawing.Size(81, 38)
        Me.MaterialFlatButton3.TabIndex = 140
        Me.MaterialFlatButton3.Text = "print all"
        Me.MaterialFlatButton3.UseVisualStyleBackColor = True
        '
        'lvcashrr
        '
        Me.lvcashrr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvcashrr.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader12})
        Me.lvcashrr.Depth = 0
        Me.lvcashrr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvcashrr.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lvcashrr.FullRowSelect = True
        Me.lvcashrr.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvcashrr.Location = New System.Drawing.Point(1, 1)
        Me.lvcashrr.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.lvcashrr.MouseState = MaterialSkin.MouseState.OUT
        Me.lvcashrr.Name = "lvcashrr"
        Me.lvcashrr.OwnerDraw = True
        Me.lvcashrr.Size = New System.Drawing.Size(1060, 592)
        Me.lvcashrr.TabIndex = 25
        Me.lvcashrr.UseCompatibleStateImageBehavior = False
        Me.lvcashrr.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Reference Number"
        Me.ColumnHeader6.Width = 200
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Date"
        Me.ColumnHeader7.Width = 250
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Grand Total"
        Me.ColumnHeader8.Width = 250
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Payee"
        Me.ColumnHeader12.Width = 250
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Controls.Add(Me.Label35)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1070, 28)
        Me.Panel2.TabIndex = 12
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(4, 4)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(231, 24)
        Me.Label35.TabIndex = 0
        Me.Label35.Text = "CASH DISBURSEMENT"
        '
        'frmCashDisbursement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 750)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCashDisbursement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCashDisbursement"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.dgvUnpaidBalance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvUnpaidBalance1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.BunifuGradientPanel4.ResumeLayout(False)
        Me.BunifuGradientPanel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbUpdateCashReceipts As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAddcashReceipts As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lblAmountPaid1 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnCancelIventory As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnHeaderSave As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lvcashdisbursement As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblDisbursmentID As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbModeofPayment As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbSupplierBilling As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCDSWebsite As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtCDSTin As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtCDSEmail As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtCDSID As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtCDSFax As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtCDSAddress As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtCDSZip As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCDSContact As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCDSNumber As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblcwt As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents dgvUnpaidBalance As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents lblTotalCWT1 As System.Windows.Forms.Label
    Friend WithEvents lblCashdisbursment1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDateAPV As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbModeofPayment1 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCDSWebsite1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCDSEmail1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtCDSFax1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtCDSZip1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents lblcwt1 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtCDSTin1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCDSAddress1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCDSContact1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCDSNumber1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCDSID1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSupplierBilling1 As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents dgvUnpaidBalance1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnHeaderSave1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnCancelAPV As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lblTotalCWT2 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents lvbilling As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader55 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader56 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader57 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader58 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents lvcashrr As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbltotalcwt As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblamountwords As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblamountpaid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblamountwords2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblamountpaid2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbltotalcwt3 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtCheckNumber2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCheckNumber As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents MaterialFlatButton2 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents MaterialFlatButton4 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents BunifuGradientPanel4 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents MaterialFlatButton3 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txtAmtPdrr As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtAmtPd1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label39 As System.Windows.Forms.Label
End Class
