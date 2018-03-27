<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchases
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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPurchases))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtAccountGroupAPV = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tabInventory = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSearchItem = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtQuantityPO = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtUnitCostPO = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton3 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txtComments = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lblAmtTotalPO = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.lblTotal = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblOutputVat = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblTotalPO = New System.Windows.Forms.Label()
        Me.lblInputVATPO1 = New System.Windows.Forms.Label()
        Me.lblpoidformat = New System.Windows.Forms.Label()
        Me.lblAmountinWord = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblSuppID = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lvPOItems = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader54 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblDateRequest = New System.Windows.Forms.Label()
        Me.dgvItems = New System.Windows.Forms.DataGridView()
        Me.cmbSupplier = New Bunifu.Framework.UI.BunifuDropdown()
        Me.txtTermsPO = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEmailPO = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtWebsitePO = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtContactPO = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFaxPO = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtTinPO = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtTelephonePO = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtAddress = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPOID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.btnCancelAll = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.btnSendPurchase = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.btnDeletefromList = New MaterialSkin.Controls.MaterialFlatButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnRefreshView = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton4 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lblPOIDitem = New System.Windows.Forms.Label()
        Me.pnlRequestItems = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton6 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton19 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton11 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lvDetailedRequest = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlViewRequest = New System.Windows.Forms.Panel()
        Me.lvRequestPO = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader33 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader34 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader38 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader75 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader35 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader36 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.MaterialFlatButton10 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lvInventoryItems1 = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader29 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader30 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader31 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader32 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabEdit = New System.Windows.Forms.TabPage()
        Me.lvRequestStatus = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader74 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton9 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblGrandTotal = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblInputVAT = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblGrandTotal1 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblInputVat1 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblPOtrueID = New MaterialSkin.Controls.MaterialLabel()
        Me.lbloutputvatot = New MaterialSkin.Controls.MaterialLabel()
        Me.lblinventorychart = New MaterialSkin.Controls.MaterialLabel()
        Me.lblAmtinWordsRR = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.cmbPOReceive = New Bunifu.Framework.UI.BunifuDropdown()
        Me.cmbItemCodeRR = New Bunifu.Framework.UI.BunifuDropdown()
        Me.lblTermsSupplier = New MaterialSkin.Controls.MaterialLabel()
        Me.lblJournalID = New MaterialSkin.Controls.MaterialLabel()
        Me.lblQuantityNeededRR = New MaterialSkin.Controls.MaterialLabel()
        Me.lblQuantityArrivedRR = New MaterialSkin.Controls.MaterialLabel()
        Me.lblUnitCostRR = New MaterialSkin.Controls.MaterialLabel()
        Me.lvReceivingInvi = New System.Windows.Forms.ListView()
        Me.ColumnHeader39 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader40 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader41 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader42 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader43 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader44 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader45 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader46 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader47 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MaterialLabel21 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel18 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtDateReceivedRR = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel17 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtQuantityReceivedRR = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel16 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtDescription = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel15 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtItemID = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel14 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel13 = New MaterialSkin.Controls.MaterialLabel()
        Me.lvReceivingReport = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader37 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader53 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblReceivingReport = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel12 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel11 = New MaterialSkin.Controls.MaterialLabel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton15 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton16 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.btnCancelRR = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton18 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lvRetainedEarnings = New System.Windows.Forms.ListView()
        Me.ColumnHeader72 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblTotalAPVoucher = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lbltotalvat = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lbltotalamount = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTerms1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtZip1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtCP1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtContact1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtAddress1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbPayee = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnCancelAPV = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton17 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbAccountName = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton14 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txtAccountCode = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.MaterialSingleLineTextField1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.MaterialSingleLineTextField2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialCheckBox1 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.lbltotalvat1 = New System.Windows.Forms.Label()
        Me.dtpBilling = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblAVPID = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblAmtInword = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblSupplierID = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.MaterialListView1 = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader48 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader49 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader50 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader51 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader52 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton12 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton8 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lvbilling = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader55 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader56 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader57 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader71 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader76 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader58 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton7 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton5 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.dgvrecievingreport = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader59 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader60 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader61 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader69 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader62 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton2 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lvpurchase = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader63 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader64 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader65 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader66 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader67 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader73 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader68 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader70 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.tabInventory.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.BunifuGradientPanel2.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.pnlRequestItems.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnlViewRequest.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.tabEdit.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Panel25.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel6.SuspendLayout()
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
        Me.BunifuTransition1.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1121, 28)
        Me.Panel2.TabIndex = 12
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label35, BunifuAnimatorNS.DecorationType.None)
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(4, 4)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(277, 24)
        Me.Label35.TabIndex = 1
        Me.Label35.Text = "PURCHASES AND BILLINGS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.BunifuTransition1.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1121, 28)
        Me.Panel1.TabIndex = 11
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.PictureBox3, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox3.Image = Global.ZamaryanSystem.My.Resources.Resources.Minimize_White
        Me.PictureBox3.Location = New System.Drawing.Point(1034, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(29, 28)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Image = Global.ZamaryanSystem.My.Resources.Resources.Maximize_White
        Me.PictureBox2.Location = New System.Drawing.Point(1063, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.ZamaryanSystem.My.Resources.Resources.Close_White
        Me.PictureBox1.Location = New System.Drawing.Point(1092, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.txtAccountGroupAPV)
        Me.Panel4.Controls.Add(Me.TextBox6)
        Me.Panel4.Controls.Add(Me.TextBox5)
        Me.Panel4.Controls.Add(Me.TextBox4)
        Me.Panel4.Controls.Add(Me.TextBox3)
        Me.Panel4.Controls.Add(Me.TextBox2)
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.BunifuTransition1.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 696)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1121, 46)
        Me.Panel4.TabIndex = 13
        '
        'txtAccountGroupAPV
        '
        Me.BunifuTransition1.SetDecoration(Me.txtAccountGroupAPV, BunifuAnimatorNS.DecorationType.None)
        Me.txtAccountGroupAPV.Location = New System.Drawing.Point(819, 23)
        Me.txtAccountGroupAPV.Name = "txtAccountGroupAPV"
        Me.txtAccountGroupAPV.Size = New System.Drawing.Size(101, 20)
        Me.txtAccountGroupAPV.TabIndex = 105
        Me.txtAccountGroupAPV.Visible = False
        '
        'TextBox6
        '
        Me.BunifuTransition1.SetDecoration(Me.TextBox6, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox6.Location = New System.Drawing.Point(615, 14)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 6
        Me.TextBox6.Visible = False
        '
        'TextBox5
        '
        Me.BunifuTransition1.SetDecoration(Me.TextBox5, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox5.Location = New System.Drawing.Point(132, 14)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 5
        Me.TextBox5.Visible = False
        '
        'TextBox4
        '
        Me.BunifuTransition1.SetDecoration(Me.TextBox4, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox4.Location = New System.Drawing.Point(251, 14)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.Visible = False
        '
        'TextBox3
        '
        Me.BunifuTransition1.SetDecoration(Me.TextBox3, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox3.Location = New System.Drawing.Point(383, 14)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Visible = False
        '
        'TextBox2
        '
        Me.BunifuTransition1.SetDecoration(Me.TextBox2, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox2.Location = New System.Drawing.Point(489, 14)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Visible = False
        '
        'TextBox1
        '
        Me.BunifuTransition1.SetDecoration(Me.TextBox1, BunifuAnimatorNS.DecorationType.None)
        Me.TextBox1.Location = New System.Drawing.Point(12, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Visible = False
        '
        'tabInventory
        '
        Me.tabInventory.Controls.Add(Me.TabPage1)
        Me.tabInventory.Controls.Add(Me.TabPage2)
        Me.tabInventory.Controls.Add(Me.tabEdit)
        Me.tabInventory.Controls.Add(Me.TabPage3)
        Me.tabInventory.Controls.Add(Me.TabPage4)
        Me.tabInventory.Controls.Add(Me.TabPage5)
        Me.tabInventory.Controls.Add(Me.TabPage6)
        Me.tabInventory.Controls.Add(Me.TabPage7)
        Me.BunifuTransition1.SetDecoration(Me.tabInventory, BunifuAnimatorNS.DecorationType.None)
        Me.tabInventory.Depth = 0
        Me.tabInventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabInventory.Location = New System.Drawing.Point(0, 84)
        Me.tabInventory.MouseState = MaterialSkin.MouseState.HOVER
        Me.tabInventory.Name = "tabInventory"
        Me.tabInventory.SelectedIndex = 0
        Me.tabInventory.Size = New System.Drawing.Size(1121, 610)
        Me.tabInventory.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.txtComments)
        Me.TabPage1.Controls.Add(Me.Label34)
        Me.TabPage1.Controls.Add(Me.lblAmtTotalPO)
        Me.TabPage1.Controls.Add(Me.Label36)
        Me.TabPage1.Controls.Add(Me.lblTotal)
        Me.TabPage1.Controls.Add(Me.lblOutputVat)
        Me.TabPage1.Controls.Add(Me.lblTotalPO)
        Me.TabPage1.Controls.Add(Me.lblInputVATPO1)
        Me.TabPage1.Controls.Add(Me.lblpoidformat)
        Me.TabPage1.Controls.Add(Me.lblAmountinWord)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.lblSuppID)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.lvPOItems)
        Me.TabPage1.Controls.Add(Me.lblDateRequest)
        Me.TabPage1.Controls.Add(Me.dgvItems)
        Me.TabPage1.Controls.Add(Me.cmbSupplier)
        Me.TabPage1.Controls.Add(Me.txtTermsPO)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txtEmailPO)
        Me.TabPage1.Controls.Add(Me.txtWebsitePO)
        Me.TabPage1.Controls.Add(Me.txtContactPO)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txtFaxPO)
        Me.TabPage1.Controls.Add(Me.txtTinPO)
        Me.TabPage1.Controls.Add(Me.txtTelephonePO)
        Me.TabPage1.Controls.Add(Me.txtAddress)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.lblPOID)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Panel13)
        Me.TabPage1.Controls.Add(Me.Panel12)
        Me.TabPage1.Controls.Add(Me.Panel11)
        Me.BunifuTransition1.SetDecoration(Me.TabPage1, BunifuAnimatorNS.DecorationType.None)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1113, 584)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Request order"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox3.Controls.Add(Me.txtSearchItem)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtQuantityPO)
        Me.GroupBox3.Controls.Add(Me.txtUnitCostPO)
        Me.GroupBox3.Controls.Add(Me.Panel3)
        Me.BunifuTransition1.SetDecoration(Me.GroupBox3, BunifuAnimatorNS.DecorationType.None)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(735, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(370, 228)
        Me.GroupBox3.TabIndex = 84
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Order Items"
        '
        'txtSearchItem
        '
        Me.BunifuTransition1.SetDecoration(Me.txtSearchItem, BunifuAnimatorNS.DecorationType.None)
        Me.txtSearchItem.Depth = 0
        Me.txtSearchItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchItem.ForeColor = System.Drawing.Color.Black
        Me.txtSearchItem.Hint = ""
        Me.txtSearchItem.Location = New System.Drawing.Point(133, 29)
        Me.txtSearchItem.MaxLength = 32767
        Me.txtSearchItem.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtSearchItem.Name = "txtSearchItem"
        Me.txtSearchItem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchItem.SelectedText = ""
        Me.txtSearchItem.SelectionLength = 0
        Me.txtSearchItem.SelectionStart = 0
        Me.txtSearchItem.Size = New System.Drawing.Size(198, 23)
        Me.txtSearchItem.TabIndex = 75
        Me.txtSearchItem.TabStop = False
        Me.txtSearchItem.UseSystemPasswordChar = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label17, BunifuAnimatorNS.DecorationType.None)
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(18, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 18)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Search Item"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label16, BunifuAnimatorNS.DecorationType.None)
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(17, 68)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 18)
        Me.Label16.TabIndex = 54
        Me.Label16.Text = "Quantity"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label15, BunifuAnimatorNS.DecorationType.None)
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(17, 105)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 18)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Unit Cost"
        '
        'txtQuantityPO
        '
        Me.BunifuTransition1.SetDecoration(Me.txtQuantityPO, BunifuAnimatorNS.DecorationType.None)
        Me.txtQuantityPO.Depth = 0
        Me.txtQuantityPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantityPO.ForeColor = System.Drawing.Color.Black
        Me.txtQuantityPO.Hint = ""
        Me.txtQuantityPO.Location = New System.Drawing.Point(133, 64)
        Me.txtQuantityPO.MaxLength = 32767
        Me.txtQuantityPO.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtQuantityPO.Name = "txtQuantityPO"
        Me.txtQuantityPO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQuantityPO.SelectedText = ""
        Me.txtQuantityPO.SelectionLength = 0
        Me.txtQuantityPO.SelectionStart = 0
        Me.txtQuantityPO.Size = New System.Drawing.Size(198, 23)
        Me.txtQuantityPO.TabIndex = 57
        Me.txtQuantityPO.TabStop = False
        Me.txtQuantityPO.UseSystemPasswordChar = False
        '
        'txtUnitCostPO
        '
        Me.BunifuTransition1.SetDecoration(Me.txtUnitCostPO, BunifuAnimatorNS.DecorationType.None)
        Me.txtUnitCostPO.Depth = 0
        Me.txtUnitCostPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitCostPO.ForeColor = System.Drawing.Color.Black
        Me.txtUnitCostPO.Hint = ""
        Me.txtUnitCostPO.Location = New System.Drawing.Point(133, 100)
        Me.txtUnitCostPO.MaxLength = 32767
        Me.txtUnitCostPO.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtUnitCostPO.Name = "txtUnitCostPO"
        Me.txtUnitCostPO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUnitCostPO.SelectedText = ""
        Me.txtUnitCostPO.SelectionLength = 0
        Me.txtUnitCostPO.SelectionStart = 0
        Me.txtUnitCostPO.Size = New System.Drawing.Size(198, 23)
        Me.txtUnitCostPO.TabIndex = 58
        Me.txtUnitCostPO.TabStop = False
        Me.txtUnitCostPO.UseSystemPasswordChar = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel3.Controls.Add(Me.MaterialFlatButton3)
        Me.BunifuTransition1.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.Panel3.Location = New System.Drawing.Point(189, 159)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(104, 38)
        Me.Panel3.TabIndex = 74
        '
        'MaterialFlatButton3
        '
        Me.MaterialFlatButton3.AutoSize = True
        Me.MaterialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.MaterialFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialFlatButton3.Depth = 0
        Me.MaterialFlatButton3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialFlatButton3.Icon = Nothing
        Me.MaterialFlatButton3.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton3.Name = "MaterialFlatButton3"
        Me.MaterialFlatButton3.Primary = False
        Me.MaterialFlatButton3.Size = New System.Drawing.Size(104, 38)
        Me.MaterialFlatButton3.TabIndex = 62
        Me.MaterialFlatButton3.Text = "Add to list"
        Me.MaterialFlatButton3.UseVisualStyleBackColor = True
        '
        'txtComments
        '
        Me.BunifuTransition1.SetDecoration(Me.txtComments, BunifuAnimatorNS.DecorationType.None)
        Me.txtComments.Depth = 0
        Me.txtComments.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComments.ForeColor = System.Drawing.Color.Black
        Me.txtComments.Hint = ""
        Me.txtComments.Location = New System.Drawing.Point(430, 470)
        Me.txtComments.MaxLength = 100
        Me.txtComments.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtComments.Name = "txtComments"
        Me.txtComments.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtComments.SelectedText = ""
        Me.txtComments.SelectionLength = 0
        Me.txtComments.SelectionStart = 0
        Me.txtComments.Size = New System.Drawing.Size(217, 23)
        Me.txtComments.TabIndex = 83
        Me.txtComments.TabStop = False
        Me.txtComments.UseSystemPasswordChar = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label34, BunifuAnimatorNS.DecorationType.None)
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(350, 479)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(62, 13)
        Me.Label34.TabIndex = 82
        Me.Label34.Text = "Comment(s)"
        '
        'lblAmtTotalPO
        '
        Me.BunifuTransition1.SetDecoration(Me.lblAmtTotalPO, BunifuAnimatorNS.DecorationType.None)
        Me.lblAmtTotalPO.Depth = 0
        Me.lblAmtTotalPO.Enabled = False
        Me.lblAmtTotalPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmtTotalPO.ForeColor = System.Drawing.Color.Black
        Me.lblAmtTotalPO.Hint = ""
        Me.lblAmtTotalPO.Location = New System.Drawing.Point(115, 470)
        Me.lblAmtTotalPO.MaxLength = 32767
        Me.lblAmtTotalPO.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblAmtTotalPO.Name = "lblAmtTotalPO"
        Me.lblAmtTotalPO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblAmtTotalPO.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblAmtTotalPO.SelectedText = ""
        Me.lblAmtTotalPO.SelectionLength = 0
        Me.lblAmtTotalPO.SelectionStart = 0
        Me.lblAmtTotalPO.Size = New System.Drawing.Size(217, 23)
        Me.lblAmtTotalPO.TabIndex = 81
        Me.lblAmtTotalPO.TabStop = False
        Me.lblAmtTotalPO.UseSystemPasswordChar = False
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label36, BunifuAnimatorNS.DecorationType.None)
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(10, 479)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(31, 13)
        Me.Label36.TabIndex = 80
        Me.Label36.Text = "Total"
        '
        'lblTotal
        '
        Me.BunifuTransition1.SetDecoration(Me.lblTotal, BunifuAnimatorNS.DecorationType.None)
        Me.lblTotal.Depth = 0
        Me.lblTotal.Enabled = False
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Hint = ""
        Me.lblTotal.Location = New System.Drawing.Point(115, 521)
        Me.lblTotal.MaxLength = 32767
        Me.lblTotal.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTotal.SelectedText = ""
        Me.lblTotal.SelectionLength = 0
        Me.lblTotal.SelectionStart = 0
        Me.lblTotal.Size = New System.Drawing.Size(217, 23)
        Me.lblTotal.TabIndex = 79
        Me.lblTotal.TabStop = False
        Me.lblTotal.UseSystemPasswordChar = False
        '
        'lblOutputVat
        '
        Me.BunifuTransition1.SetDecoration(Me.lblOutputVat, BunifuAnimatorNS.DecorationType.None)
        Me.lblOutputVat.Depth = 0
        Me.lblOutputVat.Enabled = False
        Me.lblOutputVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputVat.ForeColor = System.Drawing.Color.Black
        Me.lblOutputVat.Hint = ""
        Me.lblOutputVat.Location = New System.Drawing.Point(115, 496)
        Me.lblOutputVat.MaxLength = 32767
        Me.lblOutputVat.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblOutputVat.Name = "lblOutputVat"
        Me.lblOutputVat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblOutputVat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblOutputVat.SelectedText = ""
        Me.lblOutputVat.SelectionLength = 0
        Me.lblOutputVat.SelectionStart = 0
        Me.lblOutputVat.Size = New System.Drawing.Size(217, 23)
        Me.lblOutputVat.TabIndex = 78
        Me.lblOutputVat.TabStop = False
        Me.lblOutputVat.UseSystemPasswordChar = False
        '
        'lblTotalPO
        '
        Me.lblTotalPO.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblTotalPO, BunifuAnimatorNS.DecorationType.None)
        Me.lblTotalPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPO.ForeColor = System.Drawing.Color.Black
        Me.lblTotalPO.Location = New System.Drawing.Point(482, 481)
        Me.lblTotalPO.Name = "lblTotalPO"
        Me.lblTotalPO.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalPO.TabIndex = 76
        Me.lblTotalPO.Text = "."
        Me.lblTotalPO.Visible = False
        '
        'lblInputVATPO1
        '
        Me.lblInputVATPO1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblInputVATPO1, BunifuAnimatorNS.DecorationType.None)
        Me.lblInputVATPO1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInputVATPO1.ForeColor = System.Drawing.Color.Black
        Me.lblInputVATPO1.Location = New System.Drawing.Point(482, 506)
        Me.lblInputVATPO1.Name = "lblInputVATPO1"
        Me.lblInputVATPO1.Size = New System.Drawing.Size(10, 13)
        Me.lblInputVATPO1.TabIndex = 75
        Me.lblInputVATPO1.Text = "."
        Me.lblInputVATPO1.Visible = False
        '
        'lblpoidformat
        '
        Me.lblpoidformat.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblpoidformat, BunifuAnimatorNS.DecorationType.None)
        Me.lblpoidformat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpoidformat.ForeColor = System.Drawing.Color.Black
        Me.lblpoidformat.Location = New System.Drawing.Point(129, 21)
        Me.lblpoidformat.Name = "lblpoidformat"
        Me.lblpoidformat.Size = New System.Drawing.Size(10, 15)
        Me.lblpoidformat.TabIndex = 73
        Me.lblpoidformat.Text = "."
        '
        'lblAmountinWord
        '
        Me.lblAmountinWord.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblAmountinWord, BunifuAnimatorNS.DecorationType.None)
        Me.lblAmountinWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountinWord.ForeColor = System.Drawing.Color.Black
        Me.lblAmountinWord.Location = New System.Drawing.Point(112, 550)
        Me.lblAmountinWord.Name = "lblAmountinWord"
        Me.lblAmountinWord.Size = New System.Drawing.Size(10, 13)
        Me.lblAmountinWord.TabIndex = 72
        Me.lblAmountinWord.Text = "."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label18, BunifuAnimatorNS.DecorationType.None)
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(9, 550)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 13)
        Me.Label18.TabIndex = 71
        Me.Label18.Text = "Amount in Words"
        '
        'lblSuppID
        '
        Me.lblSuppID.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblSuppID, BunifuAnimatorNS.DecorationType.None)
        Me.lblSuppID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuppID.ForeColor = System.Drawing.Color.White
        Me.lblSuppID.Location = New System.Drawing.Point(343, 470)
        Me.lblSuppID.Name = "lblSuppID"
        Me.lblSuppID.Size = New System.Drawing.Size(57, 13)
        Me.lblSuppID.TabIndex = 70
        Me.lblSuppID.Text = "Input Data"
        Me.lblSuppID.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label14, BunifuAnimatorNS.DecorationType.None)
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(9, 502)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "Input Vat"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label13, BunifuAnimatorNS.DecorationType.None)
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(9, 527)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "Grand Total"
        '
        'lvPOItems
        '
        Me.lvPOItems.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lvPOItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvPOItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader11, Me.ColumnHeader10, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader54})
        Me.BunifuTransition1.SetDecoration(Me.lvPOItems, BunifuAnimatorNS.DecorationType.None)
        Me.lvPOItems.Depth = 0
        Me.lvPOItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lvPOItems.FullRowSelect = True
        Me.lvPOItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvPOItems.Location = New System.Drawing.Point(8, 330)
        Me.lvPOItems.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.lvPOItems.MouseState = MaterialSkin.MouseState.OUT
        Me.lvPOItems.Name = "lvPOItems"
        Me.lvPOItems.OwnerDraw = True
        Me.lvPOItems.Size = New System.Drawing.Size(974, 127)
        Me.lvPOItems.TabIndex = 65
        Me.lvPOItems.UseCompatibleStateImageBehavior = False
        Me.lvPOItems.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Description"
        Me.ColumnHeader7.Width = 265
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Unit Price"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 137
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Quantity"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 140
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Base Amount"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader11.Width = 140
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "12% Vat"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader10.Width = 140
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Sub Total"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader12.Width = 140
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "POID"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader13.Width = 1
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "itemid"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader14.Width = 1
        '
        'ColumnHeader54
        '
        Me.ColumnHeader54.Text = "Invito"
        Me.ColumnHeader54.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader54.Width = 1
        '
        'lblDateRequest
        '
        Me.lblDateRequest.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblDateRequest, BunifuAnimatorNS.DecorationType.None)
        Me.lblDateRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateRequest.ForeColor = System.Drawing.Color.Black
        Me.lblDateRequest.Location = New System.Drawing.Point(513, 163)
        Me.lblDateRequest.Name = "lblDateRequest"
        Me.lblDateRequest.Size = New System.Drawing.Size(96, 15)
        Me.lblDateRequest.TabIndex = 64
        Me.lblDateRequest.Text = "Date Requested"
        '
        'dgvItems
        '
        Me.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvItems.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuTransition1.SetDecoration(Me.dgvItems, BunifuAnimatorNS.DecorationType.None)
        Me.dgvItems.Location = New System.Drawing.Point(6, 234)
        Me.dgvItems.MultiSelect = False
        Me.dgvItems.Name = "dgvItems"
        Me.dgvItems.ReadOnly = True
        Me.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItems.Size = New System.Drawing.Size(976, 90)
        Me.dgvItems.TabIndex = 63
        '
        'cmbSupplier
        '
        Me.cmbSupplier.AllowDrop = True
        Me.cmbSupplier.BackColor = System.Drawing.Color.Transparent
        Me.cmbSupplier.BorderRadius = 3
        Me.BunifuTransition1.SetDecoration(Me.cmbSupplier, BunifuAnimatorNS.DecorationType.None)
        Me.cmbSupplier.DisabledColor = System.Drawing.Color.Gray
        Me.cmbSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSupplier.ForeColor = System.Drawing.Color.White
        Me.cmbSupplier.Items = New String(-1) {}
        Me.cmbSupplier.Location = New System.Drawing.Point(131, 53)
        Me.cmbSupplier.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.NomalColor = System.Drawing.SystemColors.HotTrack
        Me.cmbSupplier.onHoverColor = System.Drawing.SystemColors.Highlight
        Me.cmbSupplier.selectedIndex = -1
        Me.cmbSupplier.Size = New System.Drawing.Size(219, 29)
        Me.cmbSupplier.TabIndex = 59
        '
        'txtTermsPO
        '
        Me.BunifuTransition1.SetDecoration(Me.txtTermsPO, BunifuAnimatorNS.DecorationType.None)
        Me.txtTermsPO.Depth = 0
        Me.txtTermsPO.Enabled = False
        Me.txtTermsPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTermsPO.ForeColor = System.Drawing.Color.Black
        Me.txtTermsPO.Hint = ""
        Me.txtTermsPO.Location = New System.Drawing.Point(515, 196)
        Me.txtTermsPO.MaxLength = 32767
        Me.txtTermsPO.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtTermsPO.Name = "txtTermsPO"
        Me.txtTermsPO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTermsPO.SelectedText = ""
        Me.txtTermsPO.SelectionLength = 0
        Me.txtTermsPO.SelectionStart = 0
        Me.txtTermsPO.Size = New System.Drawing.Size(186, 23)
        Me.txtTermsPO.TabIndex = 52
        Me.txtTermsPO.TabStop = False
        Me.txtTermsPO.UseSystemPasswordChar = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label12, BunifuAnimatorNS.DecorationType.None)
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(392, 204)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 15)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Terms in Days"
        '
        'txtEmailPO
        '
        Me.BunifuTransition1.SetDecoration(Me.txtEmailPO, BunifuAnimatorNS.DecorationType.None)
        Me.txtEmailPO.Depth = 0
        Me.txtEmailPO.Enabled = False
        Me.txtEmailPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailPO.ForeColor = System.Drawing.Color.Black
        Me.txtEmailPO.Hint = ""
        Me.txtEmailPO.Location = New System.Drawing.Point(516, 114)
        Me.txtEmailPO.MaxLength = 32767
        Me.txtEmailPO.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtEmailPO.Name = "txtEmailPO"
        Me.txtEmailPO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailPO.SelectedText = ""
        Me.txtEmailPO.SelectionLength = 0
        Me.txtEmailPO.SelectionStart = 0
        Me.txtEmailPO.Size = New System.Drawing.Size(186, 23)
        Me.txtEmailPO.TabIndex = 49
        Me.txtEmailPO.TabStop = False
        Me.txtEmailPO.UseSystemPasswordChar = False
        '
        'txtWebsitePO
        '
        Me.BunifuTransition1.SetDecoration(Me.txtWebsitePO, BunifuAnimatorNS.DecorationType.None)
        Me.txtWebsitePO.Depth = 0
        Me.txtWebsitePO.Enabled = False
        Me.txtWebsitePO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWebsitePO.ForeColor = System.Drawing.Color.Black
        Me.txtWebsitePO.Hint = ""
        Me.txtWebsitePO.Location = New System.Drawing.Point(516, 78)
        Me.txtWebsitePO.MaxLength = 32767
        Me.txtWebsitePO.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtWebsitePO.Name = "txtWebsitePO"
        Me.txtWebsitePO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtWebsitePO.SelectedText = ""
        Me.txtWebsitePO.SelectionLength = 0
        Me.txtWebsitePO.SelectionStart = 0
        Me.txtWebsitePO.Size = New System.Drawing.Size(186, 23)
        Me.txtWebsitePO.TabIndex = 48
        Me.txtWebsitePO.TabStop = False
        Me.txtWebsitePO.UseSystemPasswordChar = False
        '
        'txtContactPO
        '
        Me.BunifuTransition1.SetDecoration(Me.txtContactPO, BunifuAnimatorNS.DecorationType.None)
        Me.txtContactPO.Depth = 0
        Me.txtContactPO.Enabled = False
        Me.txtContactPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactPO.ForeColor = System.Drawing.Color.Black
        Me.txtContactPO.Hint = ""
        Me.txtContactPO.Location = New System.Drawing.Point(516, 49)
        Me.txtContactPO.MaxLength = 32767
        Me.txtContactPO.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtContactPO.Name = "txtContactPO"
        Me.txtContactPO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContactPO.SelectedText = ""
        Me.txtContactPO.SelectionLength = 0
        Me.txtContactPO.SelectionStart = 0
        Me.txtContactPO.Size = New System.Drawing.Size(186, 23)
        Me.txtContactPO.TabIndex = 47
        Me.txtContactPO.TabStop = False
        Me.txtContactPO.UseSystemPasswordChar = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(391, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 15)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Date Requested"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label9, BunifuAnimatorNS.DecorationType.None)
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(392, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 15)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Email"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label10, BunifuAnimatorNS.DecorationType.None)
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(393, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 15)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Website"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label11, BunifuAnimatorNS.DecorationType.None)
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(393, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 15)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Contact Person"
        '
        'txtFaxPO
        '
        Me.BunifuTransition1.SetDecoration(Me.txtFaxPO, BunifuAnimatorNS.DecorationType.None)
        Me.txtFaxPO.Depth = 0
        Me.txtFaxPO.Enabled = False
        Me.txtFaxPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaxPO.ForeColor = System.Drawing.Color.Black
        Me.txtFaxPO.Hint = ""
        Me.txtFaxPO.Location = New System.Drawing.Point(132, 196)
        Me.txtFaxPO.MaxLength = 32767
        Me.txtFaxPO.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtFaxPO.Name = "txtFaxPO"
        Me.txtFaxPO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFaxPO.SelectedText = ""
        Me.txtFaxPO.SelectionLength = 0
        Me.txtFaxPO.SelectionStart = 0
        Me.txtFaxPO.Size = New System.Drawing.Size(217, 23)
        Me.txtFaxPO.TabIndex = 42
        Me.txtFaxPO.TabStop = False
        Me.txtFaxPO.UseSystemPasswordChar = False
        '
        'txtTinPO
        '
        Me.BunifuTransition1.SetDecoration(Me.txtTinPO, BunifuAnimatorNS.DecorationType.None)
        Me.txtTinPO.Depth = 0
        Me.txtTinPO.Enabled = False
        Me.txtTinPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTinPO.ForeColor = System.Drawing.Color.Black
        Me.txtTinPO.Hint = ""
        Me.txtTinPO.Location = New System.Drawing.Point(132, 158)
        Me.txtTinPO.MaxLength = 32767
        Me.txtTinPO.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtTinPO.Name = "txtTinPO"
        Me.txtTinPO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTinPO.SelectedText = ""
        Me.txtTinPO.SelectionLength = 0
        Me.txtTinPO.SelectionStart = 0
        Me.txtTinPO.Size = New System.Drawing.Size(217, 23)
        Me.txtTinPO.TabIndex = 41
        Me.txtTinPO.TabStop = False
        Me.txtTinPO.UseSystemPasswordChar = False
        '
        'txtTelephonePO
        '
        Me.BunifuTransition1.SetDecoration(Me.txtTelephonePO, BunifuAnimatorNS.DecorationType.None)
        Me.txtTelephonePO.Depth = 0
        Me.txtTelephonePO.Enabled = False
        Me.txtTelephonePO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelephonePO.ForeColor = System.Drawing.Color.Black
        Me.txtTelephonePO.Hint = ""
        Me.txtTelephonePO.Location = New System.Drawing.Point(132, 122)
        Me.txtTelephonePO.MaxLength = 32767
        Me.txtTelephonePO.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtTelephonePO.Name = "txtTelephonePO"
        Me.txtTelephonePO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelephonePO.SelectedText = ""
        Me.txtTelephonePO.SelectionLength = 0
        Me.txtTelephonePO.SelectionStart = 0
        Me.txtTelephonePO.Size = New System.Drawing.Size(217, 23)
        Me.txtTelephonePO.TabIndex = 40
        Me.txtTelephonePO.TabStop = False
        Me.txtTelephonePO.UseSystemPasswordChar = False
        '
        'txtAddress
        '
        Me.BunifuTransition1.SetDecoration(Me.txtAddress, BunifuAnimatorNS.DecorationType.None)
        Me.txtAddress.Depth = 0
        Me.txtAddress.Enabled = False
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Hint = ""
        Me.txtAddress.Location = New System.Drawing.Point(132, 93)
        Me.txtAddress.MaxLength = 32767
        Me.txtAddress.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.SelectionLength = 0
        Me.txtAddress.SelectionStart = 0
        Me.txtAddress.Size = New System.Drawing.Size(217, 23)
        Me.txtAddress.TabIndex = 39
        Me.txtAddress.TabStop = False
        Me.txtAddress.UseSystemPasswordChar = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 15)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Fax #"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(9, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 15)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Tin #"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(9, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 15)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Telephone #"
        '
        'lblPOID
        '
        Me.lblPOID.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblPOID, BunifuAnimatorNS.DecorationType.None)
        Me.lblPOID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOID.ForeColor = System.Drawing.Color.Black
        Me.lblPOID.Location = New System.Drawing.Point(129, 0)
        Me.lblPOID.Name = "lblPOID"
        Me.lblPOID.Size = New System.Drawing.Size(10, 15)
        Me.lblPOID.TabIndex = 34
        Me.lblPOID.Text = "."
        Me.lblPOID.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Supplier"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 15)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Purchase Order ID"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel13.Controls.Add(Me.btnCancelAll)
        Me.BunifuTransition1.SetDecoration(Me.Panel13, BunifuAnimatorNS.DecorationType.None)
        Me.Panel13.Location = New System.Drawing.Point(915, 475)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(66, 38)
        Me.Panel13.TabIndex = 39
        '
        'btnCancelAll
        '
        Me.btnCancelAll.AutoSize = True
        Me.btnCancelAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.btnCancelAll, BunifuAnimatorNS.DecorationType.None)
        Me.btnCancelAll.Depth = 0
        Me.btnCancelAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancelAll.Icon = Nothing
        Me.btnCancelAll.Location = New System.Drawing.Point(0, 0)
        Me.btnCancelAll.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancelAll.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancelAll.Name = "btnCancelAll"
        Me.btnCancelAll.Primary = False
        Me.btnCancelAll.Size = New System.Drawing.Size(66, 38)
        Me.btnCancelAll.TabIndex = 0
        Me.btnCancelAll.Text = "Cancel"
        Me.btnCancelAll.UseVisualStyleBackColor = True
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel12.Controls.Add(Me.btnSendPurchase)
        Me.BunifuTransition1.SetDecoration(Me.Panel12, BunifuAnimatorNS.DecorationType.None)
        Me.Panel12.Location = New System.Drawing.Point(843, 475)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(66, 38)
        Me.Panel12.TabIndex = 39
        '
        'btnSendPurchase
        '
        Me.btnSendPurchase.AutoSize = True
        Me.btnSendPurchase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.btnSendPurchase, BunifuAnimatorNS.DecorationType.None)
        Me.btnSendPurchase.Depth = 0
        Me.btnSendPurchase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSendPurchase.Enabled = False
        Me.btnSendPurchase.Icon = Nothing
        Me.btnSendPurchase.Location = New System.Drawing.Point(0, 0)
        Me.btnSendPurchase.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSendPurchase.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSendPurchase.Name = "btnSendPurchase"
        Me.btnSendPurchase.Primary = False
        Me.btnSendPurchase.Size = New System.Drawing.Size(66, 38)
        Me.btnSendPurchase.TabIndex = 1
        Me.btnSendPurchase.Text = "Save"
        Me.btnSendPurchase.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel11.Controls.Add(Me.btnDeletefromList)
        Me.BunifuTransition1.SetDecoration(Me.Panel11, BunifuAnimatorNS.DecorationType.None)
        Me.Panel11.Location = New System.Drawing.Point(703, 475)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(134, 38)
        Me.Panel11.TabIndex = 39
        '
        'btnDeletefromList
        '
        Me.btnDeletefromList.AutoSize = True
        Me.btnDeletefromList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDeletefromList.BackColor = System.Drawing.Color.CadetBlue
        Me.BunifuTransition1.SetDecoration(Me.btnDeletefromList, BunifuAnimatorNS.DecorationType.None)
        Me.btnDeletefromList.Depth = 0
        Me.btnDeletefromList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDeletefromList.Enabled = False
        Me.btnDeletefromList.Icon = Nothing
        Me.btnDeletefromList.Location = New System.Drawing.Point(0, 0)
        Me.btnDeletefromList.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnDeletefromList.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnDeletefromList.Name = "btnDeletefromList"
        Me.btnDeletefromList.Primary = False
        Me.btnDeletefromList.Size = New System.Drawing.Size(134, 38)
        Me.btnDeletefromList.TabIndex = 2
        Me.btnDeletefromList.Text = "Delete from list"
        Me.btnDeletefromList.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.BunifuGradientPanel2)
        Me.TabPage2.Controls.Add(Me.Panel19)
        Me.TabPage2.Controls.Add(Me.lblPOIDitem)
        Me.TabPage2.Controls.Add(Me.pnlRequestItems)
        Me.TabPage2.Controls.Add(Me.pnlViewRequest)
        Me.TabPage2.Controls.Add(Me.BunifuGradientPanel1)
        Me.TabPage2.Controls.Add(Me.lvInventoryItems1)
        Me.BunifuTransition1.SetDecoration(Me.TabPage2, BunifuAnimatorNS.DecorationType.None)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1113, 584)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "View Request"
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackColor = System.Drawing.Color.CadetBlue
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.btnRefreshView)
        Me.BunifuTransition1.SetDecoration(Me.BunifuGradientPanel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(842, 527)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(76, 38)
        Me.BunifuGradientPanel2.TabIndex = 10
        '
        'btnRefreshView
        '
        Me.btnRefreshView.AutoSize = True
        Me.btnRefreshView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.btnRefreshView, BunifuAnimatorNS.DecorationType.None)
        Me.btnRefreshView.Depth = 0
        Me.btnRefreshView.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRefreshView.Icon = Nothing
        Me.btnRefreshView.Location = New System.Drawing.Point(0, 0)
        Me.btnRefreshView.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnRefreshView.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRefreshView.Name = "btnRefreshView"
        Me.btnRefreshView.Primary = False
        Me.btnRefreshView.Size = New System.Drawing.Size(79, 38)
        Me.btnRefreshView.TabIndex = 7
        Me.btnRefreshView.Text = "Refresh"
        Me.btnRefreshView.UseVisualStyleBackColor = True
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel19.Controls.Add(Me.MaterialFlatButton4)
        Me.BunifuTransition1.SetDecoration(Me.Panel19, BunifuAnimatorNS.DecorationType.None)
        Me.Panel19.Location = New System.Drawing.Point(933, 221)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(106, 38)
        Me.Panel19.TabIndex = 11
        '
        'MaterialFlatButton4
        '
        Me.MaterialFlatButton4.AutoSize = True
        Me.MaterialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.MaterialFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialFlatButton4.Depth = 0
        Me.MaterialFlatButton4.Dock = System.Windows.Forms.DockStyle.Left
        Me.MaterialFlatButton4.Icon = Nothing
        Me.MaterialFlatButton4.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton4.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton4.Name = "MaterialFlatButton4"
        Me.MaterialFlatButton4.Primary = False
        Me.MaterialFlatButton4.Size = New System.Drawing.Size(111, 38)
        Me.MaterialFlatButton4.TabIndex = 3
        Me.MaterialFlatButton4.Text = "Refresh list"
        Me.MaterialFlatButton4.UseVisualStyleBackColor = True
        '
        'lblPOIDitem
        '
        Me.lblPOIDitem.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblPOIDitem, BunifuAnimatorNS.DecorationType.None)
        Me.lblPOIDitem.Location = New System.Drawing.Point(8, 490)
        Me.lblPOIDitem.Name = "lblPOIDitem"
        Me.lblPOIDitem.Size = New System.Drawing.Size(95, 13)
        Me.lblPOIDitem.TabIndex = 5
        Me.lblPOIDitem.Text = "Purchase Order ID"
        Me.lblPOIDitem.Visible = False
        '
        'pnlRequestItems
        '
        Me.pnlRequestItems.Controls.Add(Me.Panel20)
        Me.pnlRequestItems.Controls.Add(Me.Panel21)
        Me.pnlRequestItems.Controls.Add(Me.Panel5)
        Me.pnlRequestItems.Controls.Add(Me.lvDetailedRequest)
        Me.BunifuTransition1.SetDecoration(Me.pnlRequestItems, BunifuAnimatorNS.DecorationType.None)
        Me.pnlRequestItems.Location = New System.Drawing.Point(6, 266)
        Me.pnlRequestItems.Name = "pnlRequestItems"
        Me.pnlRequestItems.Size = New System.Drawing.Size(1033, 246)
        Me.pnlRequestItems.TabIndex = 8
        Me.pnlRequestItems.Visible = False
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel20.Controls.Add(Me.MaterialFlatButton6)
        Me.BunifuTransition1.SetDecoration(Me.Panel20, BunifuAnimatorNS.DecorationType.None)
        Me.Panel20.Location = New System.Drawing.Point(871, 203)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(74, 36)
        Me.Panel20.TabIndex = 11
        '
        'MaterialFlatButton6
        '
        Me.MaterialFlatButton6.AutoSize = True
        Me.MaterialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.MaterialFlatButton6, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialFlatButton6.Depth = 0
        Me.MaterialFlatButton6.Dock = System.Windows.Forms.DockStyle.Right
        Me.MaterialFlatButton6.Icon = Nothing
        Me.MaterialFlatButton6.Location = New System.Drawing.Point(-1, 0)
        Me.MaterialFlatButton6.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton6.Name = "MaterialFlatButton6"
        Me.MaterialFlatButton6.Primary = False
        Me.MaterialFlatButton6.Size = New System.Drawing.Size(75, 36)
        Me.MaterialFlatButton6.TabIndex = 3
        Me.MaterialFlatButton6.Text = "Decline"
        Me.MaterialFlatButton6.UseVisualStyleBackColor = True
        '
        'Panel21
        '
        Me.Panel21.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel21.Controls.Add(Me.MaterialFlatButton19)
        Me.BunifuTransition1.SetDecoration(Me.Panel21, BunifuAnimatorNS.DecorationType.None)
        Me.Panel21.Location = New System.Drawing.Point(785, 203)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(80, 36)
        Me.Panel21.TabIndex = 11
        '
        'MaterialFlatButton19
        '
        Me.MaterialFlatButton19.AutoSize = True
        Me.MaterialFlatButton19.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.MaterialFlatButton19, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialFlatButton19.Depth = 0
        Me.MaterialFlatButton19.Dock = System.Windows.Forms.DockStyle.Right
        Me.MaterialFlatButton19.Icon = Nothing
        Me.MaterialFlatButton19.Location = New System.Drawing.Point(-2, 0)
        Me.MaterialFlatButton19.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton19.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton19.Name = "MaterialFlatButton19"
        Me.MaterialFlatButton19.Primary = False
        Me.MaterialFlatButton19.Size = New System.Drawing.Size(82, 36)
        Me.MaterialFlatButton19.TabIndex = 4
        Me.MaterialFlatButton19.Text = "Approve"
        Me.MaterialFlatButton19.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel5.Controls.Add(Me.MaterialFlatButton11)
        Me.BunifuTransition1.SetDecoration(Me.Panel5, BunifuAnimatorNS.DecorationType.None)
        Me.Panel5.Location = New System.Drawing.Point(951, 203)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(61, 36)
        Me.Panel5.TabIndex = 10
        '
        'MaterialFlatButton11
        '
        Me.MaterialFlatButton11.AutoSize = True
        Me.MaterialFlatButton11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.MaterialFlatButton11, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialFlatButton11.Depth = 0
        Me.MaterialFlatButton11.Dock = System.Windows.Forms.DockStyle.Right
        Me.MaterialFlatButton11.Icon = Nothing
        Me.MaterialFlatButton11.Location = New System.Drawing.Point(-2, 0)
        Me.MaterialFlatButton11.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton11.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton11.Name = "MaterialFlatButton11"
        Me.MaterialFlatButton11.Primary = False
        Me.MaterialFlatButton11.Size = New System.Drawing.Size(63, 36)
        Me.MaterialFlatButton11.TabIndex = 2
        Me.MaterialFlatButton11.Text = "Close"
        Me.MaterialFlatButton11.UseVisualStyleBackColor = True
        '
        'lvDetailedRequest
        '
        Me.lvDetailedRequest.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvDetailedRequest.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.BunifuTransition1.SetDecoration(Me.lvDetailedRequest, BunifuAnimatorNS.DecorationType.None)
        Me.lvDetailedRequest.Depth = 0
        Me.lvDetailedRequest.Dock = System.Windows.Forms.DockStyle.Top
        Me.lvDetailedRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lvDetailedRequest.FullRowSelect = True
        Me.lvDetailedRequest.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvDetailedRequest.Location = New System.Drawing.Point(0, 0)
        Me.lvDetailedRequest.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.lvDetailedRequest.MouseState = MaterialSkin.MouseState.OUT
        Me.lvDetailedRequest.Name = "lvDetailedRequest"
        Me.lvDetailedRequest.OwnerDraw = True
        Me.lvDetailedRequest.Size = New System.Drawing.Size(1033, 246)
        Me.lvDetailedRequest.TabIndex = 1
        Me.lvDetailedRequest.UseCompatibleStateImageBehavior = False
        Me.lvDetailedRequest.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item Code"
        Me.ColumnHeader1.Width = 170
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Description"
        Me.ColumnHeader2.Width = 340
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Quantity"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Unit Cost"
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Sub Total"
        Me.ColumnHeader5.Width = 170
        '
        'pnlViewRequest
        '
        Me.pnlViewRequest.Controls.Add(Me.lvRequestPO)
        Me.BunifuTransition1.SetDecoration(Me.pnlViewRequest, BunifuAnimatorNS.DecorationType.None)
        Me.pnlViewRequest.Location = New System.Drawing.Point(6, 266)
        Me.pnlViewRequest.Name = "pnlViewRequest"
        Me.pnlViewRequest.Size = New System.Drawing.Size(1033, 249)
        Me.pnlViewRequest.TabIndex = 5
        '
        'lvRequestPO
        '
        Me.lvRequestPO.BackColor = System.Drawing.SystemColors.Window
        Me.lvRequestPO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvRequestPO.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader33, Me.ColumnHeader34, Me.ColumnHeader38, Me.ColumnHeader75, Me.ColumnHeader35, Me.ColumnHeader36})
        Me.BunifuTransition1.SetDecoration(Me.lvRequestPO, BunifuAnimatorNS.DecorationType.None)
        Me.lvRequestPO.Depth = 0
        Me.lvRequestPO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvRequestPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lvRequestPO.FullRowSelect = True
        Me.lvRequestPO.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvRequestPO.Location = New System.Drawing.Point(0, 0)
        Me.lvRequestPO.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.lvRequestPO.MouseState = MaterialSkin.MouseState.OUT
        Me.lvRequestPO.MultiSelect = False
        Me.lvRequestPO.Name = "lvRequestPO"
        Me.lvRequestPO.OwnerDraw = True
        Me.lvRequestPO.Size = New System.Drawing.Size(1033, 249)
        Me.lvRequestPO.TabIndex = 0
        Me.lvRequestPO.UseCompatibleStateImageBehavior = False
        Me.lvRequestPO.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader33
        '
        Me.ColumnHeader33.Text = "Purchase Order ID"
        Me.ColumnHeader33.Width = 165
        '
        'ColumnHeader34
        '
        Me.ColumnHeader34.Text = "Date Requested"
        Me.ColumnHeader34.Width = 227
        '
        'ColumnHeader38
        '
        Me.ColumnHeader38.Text = "Supplier Name"
        Me.ColumnHeader38.Width = 173
        '
        'ColumnHeader75
        '
        Me.ColumnHeader75.Text = "Sub Amount"
        Me.ColumnHeader75.Width = 150
        '
        'ColumnHeader35
        '
        Me.ColumnHeader35.Text = "Input Vat"
        Me.ColumnHeader35.Width = 200
        '
        'ColumnHeader36
        '
        Me.ColumnHeader36.Text = "Grand Total"
        Me.ColumnHeader36.Width = 170
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.CadetBlue
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.MaterialFlatButton10)
        Me.BunifuTransition1.SetDecoration(Me.BunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(924, 527)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(115, 38)
        Me.BunifuGradientPanel1.TabIndex = 9
        '
        'MaterialFlatButton10
        '
        Me.MaterialFlatButton10.AutoSize = True
        Me.MaterialFlatButton10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.MaterialFlatButton10, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialFlatButton10.Depth = 0
        Me.MaterialFlatButton10.Dock = System.Windows.Forms.DockStyle.Left
        Me.MaterialFlatButton10.Icon = Nothing
        Me.MaterialFlatButton10.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton10.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton10.Name = "MaterialFlatButton10"
        Me.MaterialFlatButton10.Primary = False
        Me.MaterialFlatButton10.Size = New System.Drawing.Size(116, 38)
        Me.MaterialFlatButton10.TabIndex = 6
        Me.MaterialFlatButton10.Text = "View request"
        Me.MaterialFlatButton10.UseVisualStyleBackColor = True
        '
        'lvInventoryItems1
        '
        Me.lvInventoryItems1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvInventoryItems1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27, Me.ColumnHeader28, Me.ColumnHeader29, Me.ColumnHeader30, Me.ColumnHeader31, Me.ColumnHeader32})
        Me.BunifuTransition1.SetDecoration(Me.lvInventoryItems1, BunifuAnimatorNS.DecorationType.None)
        Me.lvInventoryItems1.Depth = 0
        Me.lvInventoryItems1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lvInventoryItems1.FullRowSelect = True
        Me.lvInventoryItems1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvInventoryItems1.Location = New System.Drawing.Point(3, 17)
        Me.lvInventoryItems1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.lvInventoryItems1.MouseState = MaterialSkin.MouseState.OUT
        Me.lvInventoryItems1.MultiSelect = False
        Me.lvInventoryItems1.Name = "lvInventoryItems1"
        Me.lvInventoryItems1.OwnerDraw = True
        Me.lvInventoryItems1.Size = New System.Drawing.Size(1036, 198)
        Me.lvInventoryItems1.TabIndex = 1
        Me.lvInventoryItems1.UseCompatibleStateImageBehavior = False
        Me.lvInventoryItems1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "Item Code"
        Me.ColumnHeader25.Width = 140
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "Description"
        Me.ColumnHeader26.Width = 240
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "Unit of Measurement"
        Me.ColumnHeader27.Width = 170
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "Number in Stocks"
        Me.ColumnHeader28.Width = 140
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "Min Stocks"
        Me.ColumnHeader29.Width = 130
        '
        'ColumnHeader30
        '
        Me.ColumnHeader30.Text = "Max Stocks"
        Me.ColumnHeader30.Width = 134
        '
        'ColumnHeader31
        '
        Me.ColumnHeader31.Width = 1
        '
        'ColumnHeader32
        '
        Me.ColumnHeader32.Width = 1
        '
        'tabEdit
        '
        Me.tabEdit.BackColor = System.Drawing.SystemColors.Control
        Me.tabEdit.Controls.Add(Me.lvRequestStatus)
        Me.tabEdit.Controls.Add(Me.Panel14)
        Me.BunifuTransition1.SetDecoration(Me.tabEdit, BunifuAnimatorNS.DecorationType.None)
        Me.tabEdit.Location = New System.Drawing.Point(4, 22)
        Me.tabEdit.Name = "tabEdit"
        Me.tabEdit.Size = New System.Drawing.Size(1113, 584)
        Me.tabEdit.TabIndex = 2
        Me.tabEdit.Text = "Request Status"
        '
        'lvRequestStatus
        '
        Me.lvRequestStatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvRequestStatus.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader74, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20})
        Me.BunifuTransition1.SetDecoration(Me.lvRequestStatus, BunifuAnimatorNS.DecorationType.None)
        Me.lvRequestStatus.Depth = 0
        Me.lvRequestStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.lvRequestStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lvRequestStatus.FullRowSelect = True
        Me.lvRequestStatus.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvRequestStatus.Location = New System.Drawing.Point(0, 0)
        Me.lvRequestStatus.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.lvRequestStatus.MouseState = MaterialSkin.MouseState.OUT
        Me.lvRequestStatus.MultiSelect = False
        Me.lvRequestStatus.Name = "lvRequestStatus"
        Me.lvRequestStatus.OwnerDraw = True
        Me.lvRequestStatus.Size = New System.Drawing.Size(1113, 521)
        Me.lvRequestStatus.TabIndex = 1
        Me.lvRequestStatus.UseCompatibleStateImageBehavior = False
        Me.lvRequestStatus.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Purchase Order ID"
        Me.ColumnHeader15.Width = 160
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Date Requested"
        Me.ColumnHeader16.Width = 160
        '
        'ColumnHeader74
        '
        Me.ColumnHeader74.Text = "Sub Amount"
        Me.ColumnHeader74.Width = 150
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "12% Vat"
        Me.ColumnHeader17.Width = 160
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Total"
        Me.ColumnHeader18.Width = 160
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Status"
        Me.ColumnHeader19.Width = 157
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Remarks"
        Me.ColumnHeader20.Width = 158
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel14.Controls.Add(Me.MaterialFlatButton9)
        Me.BunifuTransition1.SetDecoration(Me.Panel14, BunifuAnimatorNS.DecorationType.None)
        Me.Panel14.Location = New System.Drawing.Point(934, 527)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(83, 38)
        Me.Panel14.TabIndex = 39
        '
        'MaterialFlatButton9
        '
        Me.MaterialFlatButton9.AutoSize = True
        Me.MaterialFlatButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.MaterialFlatButton9, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialFlatButton9.Depth = 0
        Me.MaterialFlatButton9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialFlatButton9.Icon = Nothing
        Me.MaterialFlatButton9.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton9.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton9.Name = "MaterialFlatButton9"
        Me.MaterialFlatButton9.Primary = False
        Me.MaterialFlatButton9.Size = New System.Drawing.Size(83, 38)
        Me.MaterialFlatButton9.TabIndex = 2
        Me.MaterialFlatButton9.Text = "Refresh"
        Me.MaterialFlatButton9.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.lblGrandTotal)
        Me.TabPage3.Controls.Add(Me.lblInputVAT)
        Me.TabPage3.Controls.Add(Me.lblGrandTotal1)
        Me.TabPage3.Controls.Add(Me.lblInputVat1)
        Me.TabPage3.Controls.Add(Me.lblPOtrueID)
        Me.TabPage3.Controls.Add(Me.lbloutputvatot)
        Me.TabPage3.Controls.Add(Me.lblinventorychart)
        Me.TabPage3.Controls.Add(Me.lblAmtinWordsRR)
        Me.TabPage3.Controls.Add(Me.MaterialLabel2)
        Me.TabPage3.Controls.Add(Me.cmbPOReceive)
        Me.TabPage3.Controls.Add(Me.cmbItemCodeRR)
        Me.TabPage3.Controls.Add(Me.lblTermsSupplier)
        Me.TabPage3.Controls.Add(Me.lblJournalID)
        Me.TabPage3.Controls.Add(Me.lblQuantityNeededRR)
        Me.TabPage3.Controls.Add(Me.lblQuantityArrivedRR)
        Me.TabPage3.Controls.Add(Me.lblUnitCostRR)
        Me.TabPage3.Controls.Add(Me.lvReceivingInvi)
        Me.TabPage3.Controls.Add(Me.MaterialLabel21)
        Me.TabPage3.Controls.Add(Me.MaterialLabel18)
        Me.TabPage3.Controls.Add(Me.txtDateReceivedRR)
        Me.TabPage3.Controls.Add(Me.MaterialLabel17)
        Me.TabPage3.Controls.Add(Me.txtQuantityReceivedRR)
        Me.TabPage3.Controls.Add(Me.MaterialLabel16)
        Me.TabPage3.Controls.Add(Me.txtDescription)
        Me.TabPage3.Controls.Add(Me.MaterialLabel15)
        Me.TabPage3.Controls.Add(Me.txtItemID)
        Me.TabPage3.Controls.Add(Me.MaterialLabel14)
        Me.TabPage3.Controls.Add(Me.MaterialLabel13)
        Me.TabPage3.Controls.Add(Me.lvReceivingReport)
        Me.TabPage3.Controls.Add(Me.lblReceivingReport)
        Me.TabPage3.Controls.Add(Me.MaterialLabel12)
        Me.TabPage3.Controls.Add(Me.MaterialLabel11)
        Me.TabPage3.Controls.Add(Me.Panel15)
        Me.TabPage3.Controls.Add(Me.Panel16)
        Me.TabPage3.Controls.Add(Me.Panel17)
        Me.TabPage3.Controls.Add(Me.Panel18)
        Me.BunifuTransition1.SetDecoration(Me.TabPage3, BunifuAnimatorNS.DecorationType.None)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1113, 584)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Receiving"
        '
        'lblGrandTotal
        '
        Me.BunifuTransition1.SetDecoration(Me.lblGrandTotal, BunifuAnimatorNS.DecorationType.None)
        Me.lblGrandTotal.Depth = 0
        Me.lblGrandTotal.Enabled = False
        Me.lblGrandTotal.Hint = ""
        Me.lblGrandTotal.Location = New System.Drawing.Point(523, 368)
        Me.lblGrandTotal.MaxLength = 32767
        Me.lblGrandTotal.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblGrandTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblGrandTotal.SelectedText = ""
        Me.lblGrandTotal.SelectionLength = 0
        Me.lblGrandTotal.SelectionStart = 0
        Me.lblGrandTotal.Size = New System.Drawing.Size(222, 23)
        Me.lblGrandTotal.TabIndex = 75
        Me.lblGrandTotal.TabStop = False
        Me.lblGrandTotal.UseSystemPasswordChar = False
        '
        'lblInputVAT
        '
        Me.BunifuTransition1.SetDecoration(Me.lblInputVAT, BunifuAnimatorNS.DecorationType.None)
        Me.lblInputVAT.Depth = 0
        Me.lblInputVAT.Enabled = False
        Me.lblInputVAT.Hint = ""
        Me.lblInputVAT.Location = New System.Drawing.Point(521, 341)
        Me.lblInputVAT.MaxLength = 32767
        Me.lblInputVAT.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblInputVAT.Name = "lblInputVAT"
        Me.lblInputVAT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblInputVAT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblInputVAT.SelectedText = ""
        Me.lblInputVAT.SelectionLength = 0
        Me.lblInputVAT.SelectionStart = 0
        Me.lblInputVAT.Size = New System.Drawing.Size(222, 23)
        Me.lblInputVAT.TabIndex = 74
        Me.lblInputVAT.TabStop = False
        Me.lblInputVAT.UseSystemPasswordChar = False
        '
        'lblGrandTotal1
        '
        Me.lblGrandTotal1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblGrandTotal1, BunifuAnimatorNS.DecorationType.None)
        Me.lblGrandTotal1.Depth = 0
        Me.lblGrandTotal1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblGrandTotal1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGrandTotal1.Location = New System.Drawing.Point(647, 483)
        Me.lblGrandTotal1.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblGrandTotal1.Name = "lblGrandTotal1"
        Me.lblGrandTotal1.Size = New System.Drawing.Size(37, 19)
        Me.lblGrandTotal1.TabIndex = 71
        Me.lblGrandTotal1.Text = "0.00"
        Me.lblGrandTotal1.Visible = False
        '
        'lblInputVat1
        '
        Me.lblInputVat1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblInputVat1, BunifuAnimatorNS.DecorationType.None)
        Me.lblInputVat1.Depth = 0
        Me.lblInputVat1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblInputVat1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInputVat1.Location = New System.Drawing.Point(647, 448)
        Me.lblInputVat1.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblInputVat1.Name = "lblInputVat1"
        Me.lblInputVat1.Size = New System.Drawing.Size(37, 19)
        Me.lblInputVat1.TabIndex = 70
        Me.lblInputVat1.Text = "0.00"
        Me.lblInputVat1.Visible = False
        '
        'lblPOtrueID
        '
        Me.lblPOtrueID.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblPOtrueID, BunifuAnimatorNS.DecorationType.None)
        Me.lblPOtrueID.Depth = 0
        Me.lblPOtrueID.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblPOtrueID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPOtrueID.Location = New System.Drawing.Point(564, 23)
        Me.lblPOtrueID.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblPOtrueID.Name = "lblPOtrueID"
        Me.lblPOtrueID.Size = New System.Drawing.Size(13, 19)
        Me.lblPOtrueID.TabIndex = 69
        Me.lblPOtrueID.Text = "."
        Me.lblPOtrueID.Visible = False
        '
        'lbloutputvatot
        '
        Me.lbloutputvatot.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbloutputvatot, BunifuAnimatorNS.DecorationType.None)
        Me.lbloutputvatot.Depth = 0
        Me.lbloutputvatot.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lbloutputvatot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbloutputvatot.Location = New System.Drawing.Point(486, 522)
        Me.lbloutputvatot.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbloutputvatot.Name = "lbloutputvatot"
        Me.lbloutputvatot.Size = New System.Drawing.Size(13, 19)
        Me.lbloutputvatot.TabIndex = 68
        Me.lbloutputvatot.Text = "."
        Me.lbloutputvatot.Visible = False
        '
        'lblinventorychart
        '
        Me.lblinventorychart.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblinventorychart, BunifuAnimatorNS.DecorationType.None)
        Me.lblinventorychart.Depth = 0
        Me.lblinventorychart.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblinventorychart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblinventorychart.Location = New System.Drawing.Point(486, 482)
        Me.lblinventorychart.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblinventorychart.Name = "lblinventorychart"
        Me.lblinventorychart.Size = New System.Drawing.Size(13, 19)
        Me.lblinventorychart.TabIndex = 67
        Me.lblinventorychart.Text = "."
        Me.lblinventorychart.Visible = False
        '
        'lblAmtinWordsRR
        '
        Me.lblAmtinWordsRR.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblAmtinWordsRR, BunifuAnimatorNS.DecorationType.None)
        Me.lblAmtinWordsRR.Depth = 0
        Me.lblAmtinWordsRR.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblAmtinWordsRR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAmtinWordsRR.Location = New System.Drawing.Point(547, 412)
        Me.lblAmtinWordsRR.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblAmtinWordsRR.Name = "lblAmtinWordsRR"
        Me.lblAmtinWordsRR.Size = New System.Drawing.Size(13, 19)
        Me.lblAmtinWordsRR.TabIndex = 64
        Me.lblAmtinWordsRR.Text = "."
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.MaterialLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(418, 412)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(123, 19)
        Me.MaterialLabel2.TabIndex = 63
        Me.MaterialLabel2.Text = "Amount in words"
        '
        'cmbPOReceive
        '
        Me.cmbPOReceive.BackColor = System.Drawing.Color.Transparent
        Me.cmbPOReceive.BorderRadius = 3
        Me.BunifuTransition1.SetDecoration(Me.cmbPOReceive, BunifuAnimatorNS.DecorationType.None)
        Me.cmbPOReceive.DisabledColor = System.Drawing.Color.Gray
        Me.cmbPOReceive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPOReceive.ForeColor = System.Drawing.Color.White
        Me.cmbPOReceive.Items = New String(-1) {}
        Me.cmbPOReceive.Location = New System.Drawing.Point(150, 55)
        Me.cmbPOReceive.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbPOReceive.Name = "cmbPOReceive"
        Me.cmbPOReceive.NomalColor = System.Drawing.SystemColors.HotTrack
        Me.cmbPOReceive.onHoverColor = System.Drawing.SystemColors.Highlight
        Me.cmbPOReceive.selectedIndex = -1
        Me.cmbPOReceive.Size = New System.Drawing.Size(219, 26)
        Me.cmbPOReceive.TabIndex = 62
        '
        'cmbItemCodeRR
        '
        Me.cmbItemCodeRR.BackColor = System.Drawing.Color.Transparent
        Me.cmbItemCodeRR.BorderRadius = 3
        Me.BunifuTransition1.SetDecoration(Me.cmbItemCodeRR, BunifuAnimatorNS.DecorationType.None)
        Me.cmbItemCodeRR.DisabledColor = System.Drawing.Color.Gray
        Me.cmbItemCodeRR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItemCodeRR.ForeColor = System.Drawing.Color.White
        Me.cmbItemCodeRR.Items = New String(-1) {}
        Me.cmbItemCodeRR.Location = New System.Drawing.Point(147, 328)
        Me.cmbItemCodeRR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbItemCodeRR.Name = "cmbItemCodeRR"
        Me.cmbItemCodeRR.NomalColor = System.Drawing.SystemColors.HotTrack
        Me.cmbItemCodeRR.onHoverColor = System.Drawing.SystemColors.Highlight
        Me.cmbItemCodeRR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbItemCodeRR.selectedIndex = -1
        Me.cmbItemCodeRR.Size = New System.Drawing.Size(219, 29)
        Me.cmbItemCodeRR.TabIndex = 61
        '
        'lblTermsSupplier
        '
        Me.lblTermsSupplier.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblTermsSupplier, BunifuAnimatorNS.DecorationType.None)
        Me.lblTermsSupplier.Depth = 0
        Me.lblTermsSupplier.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblTermsSupplier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTermsSupplier.Location = New System.Drawing.Point(467, 463)
        Me.lblTermsSupplier.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblTermsSupplier.Name = "lblTermsSupplier"
        Me.lblTermsSupplier.Size = New System.Drawing.Size(13, 19)
        Me.lblTermsSupplier.TabIndex = 55
        Me.lblTermsSupplier.Text = "."
        Me.lblTermsSupplier.Visible = False
        '
        'lblJournalID
        '
        Me.lblJournalID.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblJournalID, BunifuAnimatorNS.DecorationType.None)
        Me.lblJournalID.Depth = 0
        Me.lblJournalID.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblJournalID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblJournalID.Location = New System.Drawing.Point(486, 541)
        Me.lblJournalID.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblJournalID.Name = "lblJournalID"
        Me.lblJournalID.Size = New System.Drawing.Size(13, 19)
        Me.lblJournalID.TabIndex = 54
        Me.lblJournalID.Text = "."
        Me.lblJournalID.Visible = False
        '
        'lblQuantityNeededRR
        '
        Me.lblQuantityNeededRR.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblQuantityNeededRR, BunifuAnimatorNS.DecorationType.None)
        Me.lblQuantityNeededRR.Depth = 0
        Me.lblQuantityNeededRR.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblQuantityNeededRR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblQuantityNeededRR.Location = New System.Drawing.Point(428, 503)
        Me.lblQuantityNeededRR.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblQuantityNeededRR.Name = "lblQuantityNeededRR"
        Me.lblQuantityNeededRR.Size = New System.Drawing.Size(13, 19)
        Me.lblQuantityNeededRR.TabIndex = 53
        Me.lblQuantityNeededRR.Text = "."
        Me.lblQuantityNeededRR.Visible = False
        '
        'lblQuantityArrivedRR
        '
        Me.lblQuantityArrivedRR.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblQuantityArrivedRR, BunifuAnimatorNS.DecorationType.None)
        Me.lblQuantityArrivedRR.Depth = 0
        Me.lblQuantityArrivedRR.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblQuantityArrivedRR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblQuantityArrivedRR.Location = New System.Drawing.Point(437, 542)
        Me.lblQuantityArrivedRR.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblQuantityArrivedRR.Name = "lblQuantityArrivedRR"
        Me.lblQuantityArrivedRR.Size = New System.Drawing.Size(13, 19)
        Me.lblQuantityArrivedRR.TabIndex = 52
        Me.lblQuantityArrivedRR.Text = "."
        Me.lblQuantityArrivedRR.Visible = False
        '
        'lblUnitCostRR
        '
        Me.lblUnitCostRR.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblUnitCostRR, BunifuAnimatorNS.DecorationType.None)
        Me.lblUnitCostRR.Depth = 0
        Me.lblUnitCostRR.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblUnitCostRR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblUnitCostRR.Location = New System.Drawing.Point(428, 461)
        Me.lblUnitCostRR.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblUnitCostRR.Name = "lblUnitCostRR"
        Me.lblUnitCostRR.Size = New System.Drawing.Size(13, 19)
        Me.lblUnitCostRR.TabIndex = 51
        Me.lblUnitCostRR.Text = "."
        Me.lblUnitCostRR.Visible = False
        '
        'lvReceivingInvi
        '
        Me.lvReceivingInvi.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader39, Me.ColumnHeader40, Me.ColumnHeader41, Me.ColumnHeader42, Me.ColumnHeader43, Me.ColumnHeader44, Me.ColumnHeader45, Me.ColumnHeader46, Me.ColumnHeader47})
        Me.BunifuTransition1.SetDecoration(Me.lvReceivingInvi, BunifuAnimatorNS.DecorationType.None)
        Me.lvReceivingInvi.Location = New System.Drawing.Point(868, 333)
        Me.lvReceivingInvi.Name = "lvReceivingInvi"
        Me.lvReceivingInvi.Size = New System.Drawing.Size(136, 113)
        Me.lvReceivingInvi.TabIndex = 50
        Me.lvReceivingInvi.UseCompatibleStateImageBehavior = False
        Me.lvReceivingInvi.View = System.Windows.Forms.View.Details
        Me.lvReceivingInvi.Visible = False
        '
        'ColumnHeader39
        '
        Me.ColumnHeader39.Text = "POID"
        '
        'ColumnHeader40
        '
        Me.ColumnHeader40.Text = "itemnumber"
        '
        'ColumnHeader41
        '
        Me.ColumnHeader41.Text = "quantityReceived"
        Me.ColumnHeader41.Width = 102
        '
        'ColumnHeader42
        '
        Me.ColumnHeader42.Text = "UnitCost"
        '
        'ColumnHeader43
        '
        Me.ColumnHeader43.Text = "12% vat"
        '
        'ColumnHeader44
        '
        Me.ColumnHeader44.Text = "subtotal"
        '
        'ColumnHeader45
        '
        Me.ColumnHeader45.Text = "total"
        '
        'ColumnHeader46
        '
        Me.ColumnHeader46.Text = "RRnumber"
        '
        'ColumnHeader47
        '
        Me.ColumnHeader47.Text = "qtyNow"
        '
        'MaterialLabel21
        '
        Me.MaterialLabel21.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.MaterialLabel21, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialLabel21.Depth = 0
        Me.MaterialLabel21.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel21.Location = New System.Drawing.Point(418, 380)
        Me.MaterialLabel21.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel21.Name = "MaterialLabel21"
        Me.MaterialLabel21.Size = New System.Drawing.Size(87, 19)
        Me.MaterialLabel21.TabIndex = 48
        Me.MaterialLabel21.Text = "Grand Total"
        '
        'MaterialLabel18
        '
        Me.MaterialLabel18.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.MaterialLabel18, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialLabel18.Depth = 0
        Me.MaterialLabel18.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel18.Location = New System.Drawing.Point(418, 345)
        Me.MaterialLabel18.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel18.Name = "MaterialLabel18"
        Me.MaterialLabel18.Size = New System.Drawing.Size(75, 19)
        Me.MaterialLabel18.TabIndex = 46
        Me.MaterialLabel18.Text = "Input VAT"
        '
        'txtDateReceivedRR
        '
        Me.BunifuTransition1.SetDecoration(Me.txtDateReceivedRR, BunifuAnimatorNS.DecorationType.None)
        Me.txtDateReceivedRR.Depth = 0
        Me.txtDateReceivedRR.Enabled = False
        Me.txtDateReceivedRR.Hint = ""
        Me.txtDateReceivedRR.Location = New System.Drawing.Point(147, 495)
        Me.txtDateReceivedRR.MaxLength = 32767
        Me.txtDateReceivedRR.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtDateReceivedRR.Name = "txtDateReceivedRR"
        Me.txtDateReceivedRR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDateReceivedRR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDateReceivedRR.SelectedText = ""
        Me.txtDateReceivedRR.SelectionLength = 0
        Me.txtDateReceivedRR.SelectionStart = 0
        Me.txtDateReceivedRR.Size = New System.Drawing.Size(222, 23)
        Me.txtDateReceivedRR.TabIndex = 45
        Me.txtDateReceivedRR.TabStop = False
        Me.txtDateReceivedRR.UseSystemPasswordChar = False
        '
        'MaterialLabel17
        '
        Me.MaterialLabel17.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.MaterialLabel17, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialLabel17.Depth = 0
        Me.MaterialLabel17.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel17.Location = New System.Drawing.Point(19, 498)
        Me.MaterialLabel17.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel17.Name = "MaterialLabel17"
        Me.MaterialLabel17.Size = New System.Drawing.Size(104, 19)
        Me.MaterialLabel17.TabIndex = 44
        Me.MaterialLabel17.Text = "Date Received"
        '
        'txtQuantityReceivedRR
        '
        Me.BunifuTransition1.SetDecoration(Me.txtQuantityReceivedRR, BunifuAnimatorNS.DecorationType.None)
        Me.txtQuantityReceivedRR.Depth = 0
        Me.txtQuantityReceivedRR.Hint = ""
        Me.txtQuantityReceivedRR.Location = New System.Drawing.Point(147, 455)
        Me.txtQuantityReceivedRR.MaxLength = 32767
        Me.txtQuantityReceivedRR.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtQuantityReceivedRR.Name = "txtQuantityReceivedRR"
        Me.txtQuantityReceivedRR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQuantityReceivedRR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtQuantityReceivedRR.SelectedText = ""
        Me.txtQuantityReceivedRR.SelectionLength = 0
        Me.txtQuantityReceivedRR.SelectionStart = 0
        Me.txtQuantityReceivedRR.Size = New System.Drawing.Size(222, 23)
        Me.txtQuantityReceivedRR.TabIndex = 43
        Me.txtQuantityReceivedRR.TabStop = False
        Me.txtQuantityReceivedRR.UseSystemPasswordChar = False
        '
        'MaterialLabel16
        '
        Me.MaterialLabel16.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.MaterialLabel16, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialLabel16.Depth = 0
        Me.MaterialLabel16.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel16.Location = New System.Drawing.Point(19, 458)
        Me.MaterialLabel16.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel16.Name = "MaterialLabel16"
        Me.MaterialLabel16.Size = New System.Drawing.Size(128, 19)
        Me.MaterialLabel16.TabIndex = 42
        Me.MaterialLabel16.Text = "Quantity Received"
        '
        'txtDescription
        '
        Me.BunifuTransition1.SetDecoration(Me.txtDescription, BunifuAnimatorNS.DecorationType.None)
        Me.txtDescription.Depth = 0
        Me.txtDescription.Enabled = False
        Me.txtDescription.Hint = ""
        Me.txtDescription.Location = New System.Drawing.Point(147, 409)
        Me.txtDescription.MaxLength = 32767
        Me.txtDescription.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.SelectionLength = 0
        Me.txtDescription.SelectionStart = 0
        Me.txtDescription.Size = New System.Drawing.Size(222, 23)
        Me.txtDescription.TabIndex = 41
        Me.txtDescription.TabStop = False
        Me.txtDescription.UseSystemPasswordChar = False
        '
        'MaterialLabel15
        '
        Me.MaterialLabel15.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.MaterialLabel15, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialLabel15.Depth = 0
        Me.MaterialLabel15.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel15.Location = New System.Drawing.Point(19, 412)
        Me.MaterialLabel15.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel15.Name = "MaterialLabel15"
        Me.MaterialLabel15.Size = New System.Drawing.Size(86, 19)
        Me.MaterialLabel15.TabIndex = 40
        Me.MaterialLabel15.Text = "Description"
        '
        'txtItemID
        '
        Me.BunifuTransition1.SetDecoration(Me.txtItemID, BunifuAnimatorNS.DecorationType.None)
        Me.txtItemID.Depth = 0
        Me.txtItemID.Enabled = False
        Me.txtItemID.Hint = ""
        Me.txtItemID.Location = New System.Drawing.Point(147, 369)
        Me.txtItemID.MaxLength = 32767
        Me.txtItemID.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtItemID.Name = "txtItemID"
        Me.txtItemID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtItemID.SelectedText = ""
        Me.txtItemID.SelectionLength = 0
        Me.txtItemID.SelectionStart = 0
        Me.txtItemID.Size = New System.Drawing.Size(222, 23)
        Me.txtItemID.TabIndex = 38
        Me.txtItemID.TabStop = False
        Me.txtItemID.UseSystemPasswordChar = False
        '
        'MaterialLabel14
        '
        Me.MaterialLabel14.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.MaterialLabel14, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialLabel14.Depth = 0
        Me.MaterialLabel14.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel14.Location = New System.Drawing.Point(19, 372)
        Me.MaterialLabel14.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel14.Name = "MaterialLabel14"
        Me.MaterialLabel14.Size = New System.Drawing.Size(57, 19)
        Me.MaterialLabel14.TabIndex = 37
        Me.MaterialLabel14.Text = "Item ID"
        '
        'MaterialLabel13
        '
        Me.MaterialLabel13.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.MaterialLabel13, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialLabel13.Depth = 0
        Me.MaterialLabel13.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel13.Location = New System.Drawing.Point(19, 333)
        Me.MaterialLabel13.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel13.Name = "MaterialLabel13"
        Me.MaterialLabel13.Size = New System.Drawing.Size(78, 19)
        Me.MaterialLabel13.TabIndex = 36
        Me.MaterialLabel13.Text = "Item Code"
        '
        'lvReceivingReport
        '
        Me.lvReceivingReport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvReceivingReport.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader37, Me.ColumnHeader53})
        Me.BunifuTransition1.SetDecoration(Me.lvReceivingReport, BunifuAnimatorNS.DecorationType.None)
        Me.lvReceivingReport.Depth = 0
        Me.lvReceivingReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lvReceivingReport.FullRowSelect = True
        Me.lvReceivingReport.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvReceivingReport.Location = New System.Drawing.Point(16, 89)
        Me.lvReceivingReport.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.lvReceivingReport.MouseState = MaterialSkin.MouseState.OUT
        Me.lvReceivingReport.Name = "lvReceivingReport"
        Me.lvReceivingReport.OwnerDraw = True
        Me.lvReceivingReport.Size = New System.Drawing.Size(988, 217)
        Me.lvReceivingReport.TabIndex = 34
        Me.lvReceivingReport.UseCompatibleStateImageBehavior = False
        Me.lvReceivingReport.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Item Code"
        Me.ColumnHeader21.Width = 200
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Item Description"
        Me.ColumnHeader22.Width = 200
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Quantity Ordered"
        Me.ColumnHeader23.Width = 200
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Quantity Received"
        Me.ColumnHeader24.Width = 200
        '
        'ColumnHeader37
        '
        Me.ColumnHeader37.Text = "itemid"
        Me.ColumnHeader37.Width = 1
        '
        'ColumnHeader53
        '
        Me.ColumnHeader53.Text = "Unit Cost"
        Me.ColumnHeader53.Width = 180
        '
        'lblReceivingReport
        '
        Me.lblReceivingReport.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblReceivingReport, BunifuAnimatorNS.DecorationType.None)
        Me.lblReceivingReport.Depth = 0
        Me.lblReceivingReport.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblReceivingReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblReceivingReport.Location = New System.Drawing.Point(145, 16)
        Me.lblReceivingReport.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblReceivingReport.Name = "lblReceivingReport"
        Me.lblReceivingReport.Size = New System.Drawing.Size(13, 19)
        Me.lblReceivingReport.TabIndex = 33
        Me.lblReceivingReport.Text = "."
        '
        'MaterialLabel12
        '
        Me.MaterialLabel12.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.MaterialLabel12, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialLabel12.Depth = 0
        Me.MaterialLabel12.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel12.Location = New System.Drawing.Point(14, 16)
        Me.MaterialLabel12.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel12.Name = "MaterialLabel12"
        Me.MaterialLabel12.Size = New System.Drawing.Size(91, 19)
        Me.MaterialLabel12.TabIndex = 32
        Me.MaterialLabel12.Text = "Receiving ID"
        '
        'MaterialLabel11
        '
        Me.MaterialLabel11.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.MaterialLabel11, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialLabel11.Depth = 0
        Me.MaterialLabel11.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel11.Location = New System.Drawing.Point(14, 59)
        Me.MaterialLabel11.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel11.Name = "MaterialLabel11"
        Me.MaterialLabel11.Size = New System.Drawing.Size(129, 19)
        Me.MaterialLabel11.TabIndex = 30
        Me.MaterialLabel11.Text = "Purchase Order ID"
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel15.Controls.Add(Me.MaterialFlatButton15)
        Me.BunifuTransition1.SetDecoration(Me.Panel15, BunifuAnimatorNS.DecorationType.None)
        Me.Panel15.Location = New System.Drawing.Point(396, 42)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(221, 36)
        Me.Panel15.TabIndex = 72
        '
        'MaterialFlatButton15
        '
        Me.MaterialFlatButton15.AutoSize = True
        Me.MaterialFlatButton15.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.MaterialFlatButton15, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialFlatButton15.Depth = 0
        Me.MaterialFlatButton15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialFlatButton15.Icon = Nothing
        Me.MaterialFlatButton15.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton15.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton15.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton15.Name = "MaterialFlatButton15"
        Me.MaterialFlatButton15.Primary = False
        Me.MaterialFlatButton15.Size = New System.Drawing.Size(221, 36)
        Me.MaterialFlatButton15.TabIndex = 35
        Me.MaterialFlatButton15.Text = "Create New receiving report"
        Me.MaterialFlatButton15.UseVisualStyleBackColor = True
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel16.Controls.Add(Me.MaterialFlatButton16)
        Me.BunifuTransition1.SetDecoration(Me.Panel16, BunifuAnimatorNS.DecorationType.None)
        Me.Panel16.Location = New System.Drawing.Point(283, 527)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(86, 38)
        Me.Panel16.TabIndex = 73
        '
        'MaterialFlatButton16
        '
        Me.MaterialFlatButton16.AutoSize = True
        Me.MaterialFlatButton16.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.MaterialFlatButton16, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialFlatButton16.Depth = 0
        Me.MaterialFlatButton16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialFlatButton16.Icon = Nothing
        Me.MaterialFlatButton16.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton16.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton16.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton16.Name = "MaterialFlatButton16"
        Me.MaterialFlatButton16.Primary = False
        Me.MaterialFlatButton16.Size = New System.Drawing.Size(86, 38)
        Me.MaterialFlatButton16.TabIndex = 56
        Me.MaterialFlatButton16.Text = "Confirm"
        Me.MaterialFlatButton16.UseVisualStyleBackColor = True
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel17.Controls.Add(Me.btnCancelRR)
        Me.BunifuTransition1.SetDecoration(Me.Panel17, BunifuAnimatorNS.DecorationType.None)
        Me.Panel17.Location = New System.Drawing.Point(960, 527)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(73, 38)
        Me.Panel17.TabIndex = 57
        '
        'btnCancelRR
        '
        Me.btnCancelRR.AutoSize = True
        Me.btnCancelRR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.btnCancelRR, BunifuAnimatorNS.DecorationType.None)
        Me.btnCancelRR.Depth = 0
        Me.btnCancelRR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancelRR.Icon = Nothing
        Me.btnCancelRR.Location = New System.Drawing.Point(0, 0)
        Me.btnCancelRR.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancelRR.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancelRR.Name = "btnCancelRR"
        Me.btnCancelRR.Primary = False
        Me.btnCancelRR.Size = New System.Drawing.Size(73, 38)
        Me.btnCancelRR.TabIndex = 65
        Me.btnCancelRR.Text = "Cancel"
        Me.btnCancelRR.UseVisualStyleBackColor = True
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel18.Controls.Add(Me.MaterialFlatButton18)
        Me.BunifuTransition1.SetDecoration(Me.Panel18, BunifuAnimatorNS.DecorationType.None)
        Me.Panel18.Location = New System.Drawing.Point(880, 527)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(73, 38)
        Me.Panel18.TabIndex = 66
        '
        'MaterialFlatButton18
        '
        Me.MaterialFlatButton18.AutoSize = True
        Me.MaterialFlatButton18.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.MaterialFlatButton18, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialFlatButton18.Depth = 0
        Me.MaterialFlatButton18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialFlatButton18.Icon = Nothing
        Me.MaterialFlatButton18.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton18.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton18.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton18.Name = "MaterialFlatButton18"
        Me.MaterialFlatButton18.Primary = False
        Me.MaterialFlatButton18.Size = New System.Drawing.Size(73, 38)
        Me.MaterialFlatButton18.TabIndex = 66
        Me.MaterialFlatButton18.Text = "Save"
        Me.MaterialFlatButton18.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.Controls.Add(Me.lvRetainedEarnings)
        Me.TabPage4.Controls.Add(Me.lblTotalAPVoucher)
        Me.TabPage4.Controls.Add(Me.lbltotalvat)
        Me.TabPage4.Controls.Add(Me.lbltotalamount)
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Controls.Add(Me.Panel9)
        Me.TabPage4.Controls.Add(Me.Panel8)
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Controls.Add(Me.lbltotalvat1)
        Me.TabPage4.Controls.Add(Me.dtpBilling)
        Me.TabPage4.Controls.Add(Me.Label29)
        Me.TabPage4.Controls.Add(Me.lblAVPID)
        Me.TabPage4.Controls.Add(Me.Label25)
        Me.TabPage4.Controls.Add(Me.lblAmtInword)
        Me.TabPage4.Controls.Add(Me.Label27)
        Me.TabPage4.Controls.Add(Me.lblSupplierID)
        Me.TabPage4.Controls.Add(Me.Label26)
        Me.TabPage4.Controls.Add(Me.Label24)
        Me.TabPage4.Controls.Add(Me.MaterialListView1)
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.BunifuTransition1.SetDecoration(Me.TabPage4, BunifuAnimatorNS.DecorationType.None)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1113, 584)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "AP Voucher"
        '
        'lvRetainedEarnings
        '
        Me.lvRetainedEarnings.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader72})
        Me.BunifuTransition1.SetDecoration(Me.lvRetainedEarnings, BunifuAnimatorNS.DecorationType.None)
        Me.lvRetainedEarnings.Location = New System.Drawing.Point(970, 495)
        Me.lvRetainedEarnings.Name = "lvRetainedEarnings"
        Me.lvRetainedEarnings.Size = New System.Drawing.Size(111, 58)
        Me.lvRetainedEarnings.TabIndex = 104
        Me.lvRetainedEarnings.UseCompatibleStateImageBehavior = False
        Me.lvRetainedEarnings.View = System.Windows.Forms.View.Details
        Me.lvRetainedEarnings.Visible = False
        '
        'ColumnHeader72
        '
        Me.ColumnHeader72.Text = "RetainedEarnings"
        Me.ColumnHeader72.Width = 100
        '
        'lblTotalAPVoucher
        '
        Me.BunifuTransition1.SetDecoration(Me.lblTotalAPVoucher, BunifuAnimatorNS.DecorationType.None)
        Me.lblTotalAPVoucher.Depth = 0
        Me.lblTotalAPVoucher.Enabled = False
        Me.lblTotalAPVoucher.Hint = ""
        Me.lblTotalAPVoucher.Location = New System.Drawing.Point(144, 548)
        Me.lblTotalAPVoucher.MaxLength = 32767
        Me.lblTotalAPVoucher.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblTotalAPVoucher.Name = "lblTotalAPVoucher"
        Me.lblTotalAPVoucher.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblTotalAPVoucher.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTotalAPVoucher.SelectedText = ""
        Me.lblTotalAPVoucher.SelectionLength = 0
        Me.lblTotalAPVoucher.SelectionStart = 0
        Me.lblTotalAPVoucher.Size = New System.Drawing.Size(219, 23)
        Me.lblTotalAPVoucher.TabIndex = 101
        Me.lblTotalAPVoucher.TabStop = False
        Me.lblTotalAPVoucher.UseSystemPasswordChar = False
        '
        'lbltotalvat
        '
        Me.BunifuTransition1.SetDecoration(Me.lbltotalvat, BunifuAnimatorNS.DecorationType.None)
        Me.lbltotalvat.Depth = 0
        Me.lbltotalvat.Enabled = False
        Me.lbltotalvat.Hint = ""
        Me.lbltotalvat.Location = New System.Drawing.Point(144, 521)
        Me.lbltotalvat.MaxLength = 32767
        Me.lbltotalvat.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbltotalvat.Name = "lbltotalvat"
        Me.lbltotalvat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lbltotalvat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbltotalvat.SelectedText = ""
        Me.lbltotalvat.SelectionLength = 0
        Me.lbltotalvat.SelectionStart = 0
        Me.lbltotalvat.Size = New System.Drawing.Size(219, 23)
        Me.lbltotalvat.TabIndex = 100
        Me.lbltotalvat.TabStop = False
        Me.lbltotalvat.UseSystemPasswordChar = False
        '
        'lbltotalamount
        '
        Me.BunifuTransition1.SetDecoration(Me.lbltotalamount, BunifuAnimatorNS.DecorationType.None)
        Me.lbltotalamount.Depth = 0
        Me.lbltotalamount.Enabled = False
        Me.lbltotalamount.Hint = ""
        Me.lbltotalamount.Location = New System.Drawing.Point(144, 495)
        Me.lbltotalamount.MaxLength = 32767
        Me.lbltotalamount.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbltotalamount.Name = "lbltotalamount"
        Me.lbltotalamount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lbltotalamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbltotalamount.SelectedText = ""
        Me.lbltotalamount.SelectionLength = 0
        Me.lbltotalamount.SelectionStart = 0
        Me.lbltotalamount.Size = New System.Drawing.Size(219, 23)
        Me.lbltotalamount.TabIndex = 99
        Me.lbltotalamount.TabStop = False
        Me.lbltotalamount.UseSystemPasswordChar = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTerms1)
        Me.GroupBox2.Controls.Add(Me.txtZip1)
        Me.GroupBox2.Controls.Add(Me.txtCP1)
        Me.GroupBox2.Controls.Add(Me.txtContact1)
        Me.GroupBox2.Controls.Add(Me.txtAddress1)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.cmbPayee)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.BunifuTransition1.SetDecoration(Me.GroupBox2, BunifuAnimatorNS.DecorationType.None)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(383, 222)
        Me.GroupBox2.TabIndex = 98
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payee Information"
        '
        'txtTerms1
        '
        Me.BunifuTransition1.SetDecoration(Me.txtTerms1, BunifuAnimatorNS.DecorationType.None)
        Me.txtTerms1.Depth = 0
        Me.txtTerms1.Enabled = False
        Me.txtTerms1.Hint = ""
        Me.txtTerms1.Location = New System.Drawing.Point(139, 175)
        Me.txtTerms1.MaxLength = 32767
        Me.txtTerms1.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtTerms1.Name = "txtTerms1"
        Me.txtTerms1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTerms1.SelectedText = ""
        Me.txtTerms1.SelectionLength = 0
        Me.txtTerms1.SelectionStart = 0
        Me.txtTerms1.Size = New System.Drawing.Size(215, 23)
        Me.txtTerms1.TabIndex = 102
        Me.txtTerms1.TabStop = False
        Me.txtTerms1.UseSystemPasswordChar = False
        '
        'txtZip1
        '
        Me.BunifuTransition1.SetDecoration(Me.txtZip1, BunifuAnimatorNS.DecorationType.None)
        Me.txtZip1.Depth = 0
        Me.txtZip1.Enabled = False
        Me.txtZip1.Hint = ""
        Me.txtZip1.Location = New System.Drawing.Point(139, 146)
        Me.txtZip1.MaxLength = 32767
        Me.txtZip1.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtZip1.Name = "txtZip1"
        Me.txtZip1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtZip1.SelectedText = ""
        Me.txtZip1.SelectionLength = 0
        Me.txtZip1.SelectionStart = 0
        Me.txtZip1.Size = New System.Drawing.Size(215, 23)
        Me.txtZip1.TabIndex = 101
        Me.txtZip1.TabStop = False
        Me.txtZip1.UseSystemPasswordChar = False
        '
        'txtCP1
        '
        Me.BunifuTransition1.SetDecoration(Me.txtCP1, BunifuAnimatorNS.DecorationType.None)
        Me.txtCP1.Depth = 0
        Me.txtCP1.Enabled = False
        Me.txtCP1.Hint = ""
        Me.txtCP1.Location = New System.Drawing.Point(139, 117)
        Me.txtCP1.MaxLength = 32767
        Me.txtCP1.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCP1.Name = "txtCP1"
        Me.txtCP1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCP1.SelectedText = ""
        Me.txtCP1.SelectionLength = 0
        Me.txtCP1.SelectionStart = 0
        Me.txtCP1.Size = New System.Drawing.Size(215, 23)
        Me.txtCP1.TabIndex = 100
        Me.txtCP1.TabStop = False
        Me.txtCP1.UseSystemPasswordChar = False
        '
        'txtContact1
        '
        Me.BunifuTransition1.SetDecoration(Me.txtContact1, BunifuAnimatorNS.DecorationType.None)
        Me.txtContact1.Depth = 0
        Me.txtContact1.Enabled = False
        Me.txtContact1.Hint = ""
        Me.txtContact1.Location = New System.Drawing.Point(139, 92)
        Me.txtContact1.MaxLength = 32767
        Me.txtContact1.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtContact1.Name = "txtContact1"
        Me.txtContact1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContact1.SelectedText = ""
        Me.txtContact1.SelectionLength = 0
        Me.txtContact1.SelectionStart = 0
        Me.txtContact1.Size = New System.Drawing.Size(215, 23)
        Me.txtContact1.TabIndex = 99
        Me.txtContact1.TabStop = False
        Me.txtContact1.UseSystemPasswordChar = False
        '
        'txtAddress1
        '
        Me.BunifuTransition1.SetDecoration(Me.txtAddress1, BunifuAnimatorNS.DecorationType.None)
        Me.txtAddress1.Depth = 0
        Me.txtAddress1.Enabled = False
        Me.txtAddress1.Hint = ""
        Me.txtAddress1.Location = New System.Drawing.Point(140, 63)
        Me.txtAddress1.MaxLength = 32767
        Me.txtAddress1.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress1.SelectedText = ""
        Me.txtAddress1.SelectionLength = 0
        Me.txtAddress1.SelectionStart = 0
        Me.txtAddress1.Size = New System.Drawing.Size(215, 23)
        Me.txtAddress1.TabIndex = 98
        Me.txtAddress1.TabStop = False
        Me.txtAddress1.UseSystemPasswordChar = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label33, BunifuAnimatorNS.DecorationType.None)
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(9, 151)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(63, 16)
        Me.Label33.TabIndex = 97
        Me.Label33.Text = "Zip Code"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label32, BunifuAnimatorNS.DecorationType.None)
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(9, 123)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(99, 16)
        Me.Label32.TabIndex = 96
        Me.Label32.Text = "Contact Person"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label31, BunifuAnimatorNS.DecorationType.None)
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(4, 182)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(130, 16)
        Me.Label31.TabIndex = 95
        Me.Label31.Text = "Terms of Agreement"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label30, BunifuAnimatorNS.DecorationType.None)
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(8, 92)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(104, 16)
        Me.Label30.TabIndex = 94
        Me.Label30.Text = "Contact Number"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label23, BunifuAnimatorNS.DecorationType.None)
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(9, 64)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(59, 16)
        Me.Label23.TabIndex = 93
        Me.Label23.Text = "Address"
        '
        'cmbPayee
        '
        Me.cmbPayee.BackColor = System.Drawing.Color.Transparent
        Me.cmbPayee.BorderRadius = 3
        Me.BunifuTransition1.SetDecoration(Me.cmbPayee, BunifuAnimatorNS.DecorationType.None)
        Me.cmbPayee.DisabledColor = System.Drawing.Color.Gray
        Me.cmbPayee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPayee.ForeColor = System.Drawing.Color.White
        Me.cmbPayee.Items = New String(-1) {}
        Me.cmbPayee.Location = New System.Drawing.Point(135, 20)
        Me.cmbPayee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbPayee.Name = "cmbPayee"
        Me.cmbPayee.NomalColor = System.Drawing.SystemColors.HotTrack
        Me.cmbPayee.onHoverColor = System.Drawing.SystemColors.Highlight
        Me.cmbPayee.selectedIndex = -1
        Me.cmbPayee.Size = New System.Drawing.Size(219, 29)
        Me.cmbPayee.TabIndex = 92
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label28, BunifuAnimatorNS.DecorationType.None)
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(9, 28)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(48, 16)
        Me.Label28.TabIndex = 91
        Me.Label28.Text = "Payee"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel9.Controls.Add(Me.btnCancelAPV)
        Me.BunifuTransition1.SetDecoration(Me.Panel9, BunifuAnimatorNS.DecorationType.None)
        Me.Panel9.Location = New System.Drawing.Point(1276, 515)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(70, 38)
        Me.Panel9.TabIndex = 97
        '
        'btnCancelAPV
        '
        Me.btnCancelAPV.AutoSize = True
        Me.btnCancelAPV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.btnCancelAPV, BunifuAnimatorNS.DecorationType.None)
        Me.btnCancelAPV.Depth = 0
        Me.btnCancelAPV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancelAPV.Icon = Nothing
        Me.btnCancelAPV.Location = New System.Drawing.Point(0, 0)
        Me.btnCancelAPV.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancelAPV.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancelAPV.Name = "btnCancelAPV"
        Me.btnCancelAPV.Primary = False
        Me.btnCancelAPV.Size = New System.Drawing.Size(70, 38)
        Me.btnCancelAPV.TabIndex = 85
        Me.btnCancelAPV.Text = "Cancel"
        Me.btnCancelAPV.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel8.Controls.Add(Me.MaterialFlatButton17)
        Me.BunifuTransition1.SetDecoration(Me.Panel8, BunifuAnimatorNS.DecorationType.None)
        Me.Panel8.Location = New System.Drawing.Point(1200, 515)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(70, 38)
        Me.Panel8.TabIndex = 96
        '
        'MaterialFlatButton17
        '
        Me.MaterialFlatButton17.AutoSize = True
        Me.MaterialFlatButton17.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.MaterialFlatButton17, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialFlatButton17.Depth = 0
        Me.MaterialFlatButton17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialFlatButton17.Icon = Nothing
        Me.MaterialFlatButton17.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton17.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton17.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton17.Name = "MaterialFlatButton17"
        Me.MaterialFlatButton17.Primary = False
        Me.MaterialFlatButton17.Size = New System.Drawing.Size(70, 38)
        Me.MaterialFlatButton17.TabIndex = 71
        Me.MaterialFlatButton17.Text = "Save"
        Me.MaterialFlatButton17.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbAccountName)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Panel7)
        Me.GroupBox1.Controls.Add(Me.txtAccountCode)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.MaterialSingleLineTextField1)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.MaterialSingleLineTextField2)
        Me.GroupBox1.Controls.Add(Me.MaterialCheckBox1)
        Me.BunifuTransition1.SetDecoration(Me.GroupBox1, BunifuAnimatorNS.DecorationType.None)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 288)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 204)
        Me.GroupBox1.TabIndex = 95
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "APV Information"
        '
        'cmbAccountName
        '
        Me.cmbAccountName.BackColor = System.Drawing.Color.Transparent
        Me.cmbAccountName.BorderRadius = 3
        Me.BunifuTransition1.SetDecoration(Me.cmbAccountName, BunifuAnimatorNS.DecorationType.None)
        Me.cmbAccountName.DisabledColor = System.Drawing.Color.Gray
        Me.cmbAccountName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccountName.ForeColor = System.Drawing.Color.White
        Me.cmbAccountName.Items = New String(-1) {}
        Me.cmbAccountName.Location = New System.Drawing.Point(137, 20)
        Me.cmbAccountName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbAccountName.Name = "cmbAccountName"
        Me.cmbAccountName.NomalColor = System.Drawing.SystemColors.HotTrack
        Me.cmbAccountName.onHoverColor = System.Drawing.SystemColors.Highlight
        Me.cmbAccountName.selectedIndex = -1
        Me.cmbAccountName.Size = New System.Drawing.Size(219, 29)
        Me.cmbAccountName.TabIndex = 60
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label19, BunifuAnimatorNS.DecorationType.None)
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(11, 29)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 16)
        Me.Label19.TabIndex = 61
        Me.Label19.Text = "Account Name"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label20, BunifuAnimatorNS.DecorationType.None)
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(11, 67)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(92, 16)
        Me.Label20.TabIndex = 62
        Me.Label20.Text = "Account Code"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel7.Controls.Add(Me.MaterialFlatButton14)
        Me.BunifuTransition1.SetDecoration(Me.Panel7, BunifuAnimatorNS.DecorationType.None)
        Me.Panel7.Location = New System.Drawing.Point(240, 150)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(108, 38)
        Me.Panel7.TabIndex = 94
        '
        'MaterialFlatButton14
        '
        Me.MaterialFlatButton14.AutoSize = True
        Me.MaterialFlatButton14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton14.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.MaterialFlatButton14, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialFlatButton14.Depth = 0
        Me.MaterialFlatButton14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialFlatButton14.Icon = Nothing
        Me.MaterialFlatButton14.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton14.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton14.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton14.Name = "MaterialFlatButton14"
        Me.MaterialFlatButton14.Primary = False
        Me.MaterialFlatButton14.Size = New System.Drawing.Size(108, 38)
        Me.MaterialFlatButton14.TabIndex = 69
        Me.MaterialFlatButton14.Text = "Add to list"
        Me.MaterialFlatButton14.UseVisualStyleBackColor = False
        '
        'txtAccountCode
        '
        Me.BunifuTransition1.SetDecoration(Me.txtAccountCode, BunifuAnimatorNS.DecorationType.None)
        Me.txtAccountCode.Depth = 0
        Me.txtAccountCode.Enabled = False
        Me.txtAccountCode.Hint = ""
        Me.txtAccountCode.Location = New System.Drawing.Point(137, 61)
        Me.txtAccountCode.MaxLength = 32767
        Me.txtAccountCode.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtAccountCode.Name = "txtAccountCode"
        Me.txtAccountCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAccountCode.SelectedText = ""
        Me.txtAccountCode.SelectionLength = 0
        Me.txtAccountCode.SelectionStart = 0
        Me.txtAccountCode.Size = New System.Drawing.Size(219, 23)
        Me.txtAccountCode.TabIndex = 63
        Me.txtAccountCode.TabStop = False
        Me.txtAccountCode.UseSystemPasswordChar = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label21, BunifuAnimatorNS.DecorationType.None)
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(11, 98)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(76, 16)
        Me.Label21.TabIndex = 64
        Me.Label21.Text = "Description"
        '
        'MaterialSingleLineTextField1
        '
        Me.BunifuTransition1.SetDecoration(Me.MaterialSingleLineTextField1, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialSingleLineTextField1.Depth = 0
        Me.MaterialSingleLineTextField1.Hint = ""
        Me.MaterialSingleLineTextField1.Location = New System.Drawing.Point(137, 92)
        Me.MaterialSingleLineTextField1.MaxLength = 32767
        Me.MaterialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField1.Name = "MaterialSingleLineTextField1"
        Me.MaterialSingleLineTextField1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField1.SelectedText = ""
        Me.MaterialSingleLineTextField1.SelectionLength = 0
        Me.MaterialSingleLineTextField1.SelectionStart = 0
        Me.MaterialSingleLineTextField1.Size = New System.Drawing.Size(219, 23)
        Me.MaterialSingleLineTextField1.TabIndex = 65
        Me.MaterialSingleLineTextField1.TabStop = False
        Me.MaterialSingleLineTextField1.UseSystemPasswordChar = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label22, BunifuAnimatorNS.DecorationType.None)
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(11, 127)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 16)
        Me.Label22.TabIndex = 66
        Me.Label22.Text = "Amount"
        '
        'MaterialSingleLineTextField2
        '
        Me.BunifuTransition1.SetDecoration(Me.MaterialSingleLineTextField2, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialSingleLineTextField2.Depth = 0
        Me.MaterialSingleLineTextField2.Hint = ""
        Me.MaterialSingleLineTextField2.Location = New System.Drawing.Point(137, 121)
        Me.MaterialSingleLineTextField2.MaxLength = 32767
        Me.MaterialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField2.Name = "MaterialSingleLineTextField2"
        Me.MaterialSingleLineTextField2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField2.SelectedText = ""
        Me.MaterialSingleLineTextField2.SelectionLength = 0
        Me.MaterialSingleLineTextField2.SelectionStart = 0
        Me.MaterialSingleLineTextField2.Size = New System.Drawing.Size(219, 23)
        Me.MaterialSingleLineTextField2.TabIndex = 67
        Me.MaterialSingleLineTextField2.TabStop = False
        Me.MaterialSingleLineTextField2.UseSystemPasswordChar = False
        '
        'MaterialCheckBox1
        '
        Me.MaterialCheckBox1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.MaterialCheckBox1, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialCheckBox1.Depth = 0
        Me.MaterialCheckBox1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialCheckBox1.Location = New System.Drawing.Point(111, 162)
        Me.MaterialCheckBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialCheckBox1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialCheckBox1.Name = "MaterialCheckBox1"
        Me.MaterialCheckBox1.Ripple = True
        Me.MaterialCheckBox1.Size = New System.Drawing.Size(101, 30)
        Me.MaterialCheckBox1.TabIndex = 68
        Me.MaterialCheckBox1.Text = "Enable VAT"
        Me.MaterialCheckBox1.UseVisualStyleBackColor = True
        '
        'lbltotalvat1
        '
        Me.lbltotalvat1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lbltotalvat1, BunifuAnimatorNS.DecorationType.None)
        Me.lbltotalvat1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalvat1.Location = New System.Drawing.Point(594, 527)
        Me.lbltotalvat1.Name = "lbltotalvat1"
        Me.lbltotalvat1.Size = New System.Drawing.Size(15, 16)
        Me.lbltotalvat1.TabIndex = 93
        Me.lbltotalvat1.Text = "0"
        Me.lbltotalvat1.Visible = False
        '
        'dtpBilling
        '
        Me.dtpBilling.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.dtpBilling, BunifuAnimatorNS.DecorationType.None)
        Me.dtpBilling.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBilling.Location = New System.Drawing.Point(789, 19)
        Me.dtpBilling.Name = "dtpBilling"
        Me.dtpBilling.Size = New System.Drawing.Size(37, 16)
        Me.dtpBilling.TabIndex = 90
        Me.dtpBilling.Text = "Date"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label29, BunifuAnimatorNS.DecorationType.None)
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(16, 548)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(79, 16)
        Me.Label29.TabIndex = 88
        Me.Label29.Text = "Grand Total"
        '
        'lblAVPID
        '
        Me.lblAVPID.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblAVPID, BunifuAnimatorNS.DecorationType.None)
        Me.lblAVPID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAVPID.Location = New System.Drawing.Point(236, 19)
        Me.lblAVPID.Name = "lblAVPID"
        Me.lblAVPID.Size = New System.Drawing.Size(11, 16)
        Me.lblAVPID.TabIndex = 87
        Me.lblAVPID.Text = "."
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label25, BunifuAnimatorNS.DecorationType.None)
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(17, 19)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(186, 16)
        Me.Label25.TabIndex = 86
        Me.Label25.Text = "Accounts Payable Voucher ID"
        '
        'lblAmtInword
        '
        Me.lblAmtInword.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblAmtInword, BunifuAnimatorNS.DecorationType.None)
        Me.lblAmtInword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmtInword.Location = New System.Drawing.Point(499, 548)
        Me.lblAmtInword.Name = "lblAmtInword"
        Me.lblAmtInword.Size = New System.Drawing.Size(0, 16)
        Me.lblAmtInword.TabIndex = 84
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label27, BunifuAnimatorNS.DecorationType.None)
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(374, 548)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(109, 16)
        Me.Label27.TabIndex = 83
        Me.Label27.Text = "Amount in Words"
        '
        'lblSupplierID
        '
        Me.lblSupplierID.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblSupplierID, BunifuAnimatorNS.DecorationType.None)
        Me.lblSupplierID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplierID.Location = New System.Drawing.Point(650, 15)
        Me.lblSupplierID.Name = "lblSupplierID"
        Me.lblSupplierID.Size = New System.Drawing.Size(18, 20)
        Me.lblSupplierID.TabIndex = 82
        Me.lblSupplierID.Text = "0"
        Me.lblSupplierID.Visible = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label26, BunifuAnimatorNS.DecorationType.None)
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(16, 527)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(69, 16)
        Me.Label26.TabIndex = 80
        Me.Label26.Text = "Total VAT"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label24, BunifuAnimatorNS.DecorationType.None)
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(16, 501)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 16)
        Me.Label24.TabIndex = 78
        Me.Label24.Text = "Sub Amount"
        '
        'MaterialListView1
        '
        Me.MaterialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader48, Me.ColumnHeader49, Me.ColumnHeader50, Me.ColumnHeader51, Me.ColumnHeader52})
        Me.BunifuTransition1.SetDecoration(Me.MaterialListView1, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialListView1.Depth = 0
        Me.MaterialListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.MaterialListView1.FullRowSelect = True
        Me.MaterialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.MaterialListView1.Location = New System.Drawing.Point(459, 63)
        Me.MaterialListView1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialListView1.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialListView1.Name = "MaterialListView1"
        Me.MaterialListView1.OwnerDraw = True
        Me.MaterialListView1.Size = New System.Drawing.Size(900, 423)
        Me.MaterialListView1.TabIndex = 70
        Me.MaterialListView1.UseCompatibleStateImageBehavior = False
        Me.MaterialListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader48
        '
        Me.ColumnHeader48.Text = "Account Number"
        Me.ColumnHeader48.Width = 259
        '
        'ColumnHeader49
        '
        Me.ColumnHeader49.Text = "Account Name"
        Me.ColumnHeader49.Width = 233
        '
        'ColumnHeader50
        '
        Me.ColumnHeader50.Text = "Description"
        Me.ColumnHeader50.Width = 181
        '
        'ColumnHeader51
        '
        Me.ColumnHeader51.Text = "Amount"
        Me.ColumnHeader51.Width = 126
        '
        'ColumnHeader52
        '
        Me.ColumnHeader52.Text = "VAT"
        Me.ColumnHeader52.Width = 90
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(742, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Date"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Panel25)
        Me.TabPage5.Controls.Add(Me.Panel24)
        Me.TabPage5.Controls.Add(Me.lvbilling)
        Me.BunifuTransition1.SetDecoration(Me.TabPage5, BunifuAnimatorNS.DecorationType.None)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1113, 584)
        Me.TabPage5.TabIndex = 5
        Me.TabPage5.Text = "APV Report"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel25.Controls.Add(Me.MaterialFlatButton12)
        Me.BunifuTransition1.SetDecoration(Me.Panel25, BunifuAnimatorNS.DecorationType.None)
        Me.Panel25.Location = New System.Drawing.Point(975, 540)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(84, 38)
        Me.Panel25.TabIndex = 44
        '
        'MaterialFlatButton12
        '
        Me.MaterialFlatButton12.AutoSize = True
        Me.MaterialFlatButton12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.MaterialFlatButton12, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialFlatButton12.Depth = 0
        Me.MaterialFlatButton12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialFlatButton12.Icon = Nothing
        Me.MaterialFlatButton12.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton12.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton12.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton12.Name = "MaterialFlatButton12"
        Me.MaterialFlatButton12.Primary = False
        Me.MaterialFlatButton12.Size = New System.Drawing.Size(84, 38)
        Me.MaterialFlatButton12.TabIndex = 0
        Me.MaterialFlatButton12.Text = "refresh"
        Me.MaterialFlatButton12.UseVisualStyleBackColor = True
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel24.Controls.Add(Me.MaterialFlatButton8)
        Me.BunifuTransition1.SetDecoration(Me.Panel24, BunifuAnimatorNS.DecorationType.None)
        Me.Panel24.Location = New System.Drawing.Point(884, 540)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(84, 38)
        Me.Panel24.TabIndex = 44
        '
        'MaterialFlatButton8
        '
        Me.MaterialFlatButton8.AutoSize = True
        Me.MaterialFlatButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.MaterialFlatButton8, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialFlatButton8.Depth = 0
        Me.MaterialFlatButton8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialFlatButton8.Icon = Nothing
        Me.MaterialFlatButton8.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton8.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton8.Name = "MaterialFlatButton8"
        Me.MaterialFlatButton8.Primary = False
        Me.MaterialFlatButton8.Size = New System.Drawing.Size(84, 38)
        Me.MaterialFlatButton8.TabIndex = 0
        Me.MaterialFlatButton8.Text = "print all"
        Me.MaterialFlatButton8.UseVisualStyleBackColor = True
        '
        'lvbilling
        '
        Me.lvbilling.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvbilling.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader55, Me.ColumnHeader56, Me.ColumnHeader57, Me.ColumnHeader71, Me.ColumnHeader76, Me.ColumnHeader58, Me.ColumnHeader6})
        Me.BunifuTransition1.SetDecoration(Me.lvbilling, BunifuAnimatorNS.DecorationType.None)
        Me.lvbilling.Depth = 0
        Me.lvbilling.Dock = System.Windows.Forms.DockStyle.Top
        Me.lvbilling.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lvbilling.FullRowSelect = True
        Me.lvbilling.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvbilling.Location = New System.Drawing.Point(3, 3)
        Me.lvbilling.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.lvbilling.MouseState = MaterialSkin.MouseState.OUT
        Me.lvbilling.Name = "lvbilling"
        Me.lvbilling.OwnerDraw = True
        Me.lvbilling.Size = New System.Drawing.Size(1107, 578)
        Me.lvbilling.TabIndex = 23
        Me.lvbilling.UseCompatibleStateImageBehavior = False
        Me.lvbilling.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader55
        '
        Me.ColumnHeader55.Text = "APV ID"
        Me.ColumnHeader55.Width = 140
        '
        'ColumnHeader56
        '
        Me.ColumnHeader56.Text = "Date Request"
        Me.ColumnHeader56.Width = 150
        '
        'ColumnHeader57
        '
        Me.ColumnHeader57.Text = "Due Date"
        Me.ColumnHeader57.Width = 150
        '
        'ColumnHeader71
        '
        Me.ColumnHeader71.Text = "Supplier Name"
        Me.ColumnHeader71.Width = 200
        '
        'ColumnHeader76
        '
        Me.ColumnHeader76.Text = "Base Amount"
        Me.ColumnHeader76.Width = 150
        '
        'ColumnHeader58
        '
        Me.ColumnHeader58.Text = "Input VAT"
        Me.ColumnHeader58.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Total"
        Me.ColumnHeader6.Width = 150
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Panel23)
        Me.TabPage6.Controls.Add(Me.Panel22)
        Me.TabPage6.Controls.Add(Me.dgvrecievingreport)
        Me.BunifuTransition1.SetDecoration(Me.TabPage6, BunifuAnimatorNS.DecorationType.None)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1113, 584)
        Me.TabPage6.TabIndex = 6
        Me.TabPage6.Text = "Receiving Report"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel23.Controls.Add(Me.MaterialFlatButton7)
        Me.BunifuTransition1.SetDecoration(Me.Panel23, BunifuAnimatorNS.DecorationType.None)
        Me.Panel23.Location = New System.Drawing.Point(953, 550)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(84, 38)
        Me.Panel23.TabIndex = 43
        '
        'MaterialFlatButton7
        '
        Me.MaterialFlatButton7.AutoSize = True
        Me.MaterialFlatButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.MaterialFlatButton7, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialFlatButton7.Depth = 0
        Me.MaterialFlatButton7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialFlatButton7.Icon = Nothing
        Me.MaterialFlatButton7.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton7.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton7.Name = "MaterialFlatButton7"
        Me.MaterialFlatButton7.Primary = False
        Me.MaterialFlatButton7.Size = New System.Drawing.Size(84, 38)
        Me.MaterialFlatButton7.TabIndex = 0
        Me.MaterialFlatButton7.Text = "refresh"
        Me.MaterialFlatButton7.UseVisualStyleBackColor = True
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel22.Controls.Add(Me.MaterialFlatButton5)
        Me.BunifuTransition1.SetDecoration(Me.Panel22, BunifuAnimatorNS.DecorationType.None)
        Me.Panel22.Location = New System.Drawing.Point(863, 550)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(84, 38)
        Me.Panel22.TabIndex = 42
        '
        'MaterialFlatButton5
        '
        Me.MaterialFlatButton5.AutoSize = True
        Me.MaterialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.MaterialFlatButton5, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialFlatButton5.Depth = 0
        Me.MaterialFlatButton5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialFlatButton5.Icon = Nothing
        Me.MaterialFlatButton5.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton5.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton5.Name = "MaterialFlatButton5"
        Me.MaterialFlatButton5.Primary = False
        Me.MaterialFlatButton5.Size = New System.Drawing.Size(84, 38)
        Me.MaterialFlatButton5.TabIndex = 0
        Me.MaterialFlatButton5.Text = "print all"
        Me.MaterialFlatButton5.UseVisualStyleBackColor = True
        '
        'dgvrecievingreport
        '
        Me.dgvrecievingreport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvrecievingreport.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader59, Me.ColumnHeader60, Me.ColumnHeader61, Me.ColumnHeader69, Me.ColumnHeader62})
        Me.BunifuTransition1.SetDecoration(Me.dgvrecievingreport, BunifuAnimatorNS.DecorationType.None)
        Me.dgvrecievingreport.Depth = 0
        Me.dgvrecievingreport.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvrecievingreport.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.dgvrecievingreport.FullRowSelect = True
        Me.dgvrecievingreport.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.dgvrecievingreport.Location = New System.Drawing.Point(3, 3)
        Me.dgvrecievingreport.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.dgvrecievingreport.MouseState = MaterialSkin.MouseState.OUT
        Me.dgvrecievingreport.Name = "dgvrecievingreport"
        Me.dgvrecievingreport.OwnerDraw = True
        Me.dgvrecievingreport.Size = New System.Drawing.Size(1107, 585)
        Me.dgvrecievingreport.TabIndex = 24
        Me.dgvrecievingreport.UseCompatibleStateImageBehavior = False
        Me.dgvrecievingreport.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader59
        '
        Me.ColumnHeader59.Text = "Report ID"
        Me.ColumnHeader59.Width = 150
        '
        'ColumnHeader60
        '
        Me.ColumnHeader60.Text = "Supplier Name"
        Me.ColumnHeader60.Width = 250
        '
        'ColumnHeader61
        '
        Me.ColumnHeader61.Text = "Date Delivered"
        Me.ColumnHeader61.Width = 250
        '
        'ColumnHeader69
        '
        Me.ColumnHeader69.DisplayIndex = 4
        Me.ColumnHeader69.Text = "Total"
        Me.ColumnHeader69.Width = 120
        '
        'ColumnHeader62
        '
        Me.ColumnHeader62.DisplayIndex = 3
        Me.ColumnHeader62.Text = "Status"
        Me.ColumnHeader62.Width = 250
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.Panel10)
        Me.TabPage7.Controls.Add(Me.Panel6)
        Me.TabPage7.Controls.Add(Me.lvpurchase)
        Me.BunifuTransition1.SetDecoration(Me.TabPage7, BunifuAnimatorNS.DecorationType.None)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(1113, 584)
        Me.TabPage7.TabIndex = 7
        Me.TabPage7.Text = "P.O Report"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel10.Controls.Add(Me.MaterialFlatButton2)
        Me.BunifuTransition1.SetDecoration(Me.Panel10, BunifuAnimatorNS.DecorationType.None)
        Me.Panel10.Location = New System.Drawing.Point(848, 531)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(84, 38)
        Me.Panel10.TabIndex = 41
        '
        'MaterialFlatButton2
        '
        Me.MaterialFlatButton2.AutoSize = True
        Me.MaterialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.MaterialFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialFlatButton2.Depth = 0
        Me.MaterialFlatButton2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialFlatButton2.Icon = Nothing
        Me.MaterialFlatButton2.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton2.Name = "MaterialFlatButton2"
        Me.MaterialFlatButton2.Primary = False
        Me.MaterialFlatButton2.Size = New System.Drawing.Size(84, 38)
        Me.MaterialFlatButton2.TabIndex = 0
        Me.MaterialFlatButton2.Text = "print all"
        Me.MaterialFlatButton2.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel6.Controls.Add(Me.MaterialFlatButton1)
        Me.BunifuTransition1.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.Panel6.Location = New System.Drawing.Point(938, 531)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(84, 38)
        Me.Panel6.TabIndex = 40
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.MaterialFlatButton1, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialFlatButton1.Icon = Nothing
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(84, 38)
        Me.MaterialFlatButton1.TabIndex = 0
        Me.MaterialFlatButton1.Text = "Refresh"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'lvpurchase
        '
        Me.lvpurchase.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvpurchase.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader63, Me.ColumnHeader64, Me.ColumnHeader65, Me.ColumnHeader66, Me.ColumnHeader67, Me.ColumnHeader73, Me.ColumnHeader68, Me.ColumnHeader70})
        Me.BunifuTransition1.SetDecoration(Me.lvpurchase, BunifuAnimatorNS.DecorationType.None)
        Me.lvpurchase.Depth = 0
        Me.lvpurchase.Dock = System.Windows.Forms.DockStyle.Top
        Me.lvpurchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lvpurchase.FullRowSelect = True
        Me.lvpurchase.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvpurchase.Location = New System.Drawing.Point(3, 3)
        Me.lvpurchase.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.lvpurchase.MouseState = MaterialSkin.MouseState.OUT
        Me.lvpurchase.Name = "lvpurchase"
        Me.lvpurchase.OwnerDraw = True
        Me.lvpurchase.Size = New System.Drawing.Size(1107, 585)
        Me.lvpurchase.TabIndex = 4
        Me.lvpurchase.UseCompatibleStateImageBehavior = False
        Me.lvpurchase.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader63
        '
        Me.ColumnHeader63.Text = "Purchase Order ID"
        Me.ColumnHeader63.Width = 130
        '
        'ColumnHeader64
        '
        Me.ColumnHeader64.Text = "Order Date"
        Me.ColumnHeader64.Width = 150
        '
        'ColumnHeader65
        '
        Me.ColumnHeader65.Text = "Supplier"
        Me.ColumnHeader65.Width = 150
        '
        'ColumnHeader66
        '
        Me.ColumnHeader66.Text = "Terms in Days"
        Me.ColumnHeader66.Width = 190
        '
        'ColumnHeader67
        '
        Me.ColumnHeader67.Text = "Remarks"
        Me.ColumnHeader67.Width = 160
        '
        'ColumnHeader73
        '
        Me.ColumnHeader73.Text = "Sub amount"
        Me.ColumnHeader73.Width = 120
        '
        'ColumnHeader68
        '
        Me.ColumnHeader68.Text = "Input Vat"
        Me.ColumnHeader68.Width = 150
        '
        'ColumnHeader70
        '
        Me.ColumnHeader70.Text = "Total"
        Me.ColumnHeader70.Width = 150
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.tabInventory
        Me.BunifuTransition1.SetDecoration(Me.MaterialTabSelector1, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaterialTabSelector1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 56)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(1121, 28)
        Me.MaterialTabSelector1.TabIndex = 14
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'Timer1
        '
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.BunifuTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0.0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0.0!
        Animation1.RotateLimit = 0.0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0.0!
        Animation1.TransparencyCoeff = 0.0!
        Me.BunifuTransition1.DefaultAnimation = Animation1
        '
        'ContextMenuStrip1
        '
        Me.BunifuTransition1.SetDecoration(Me.ContextMenuStrip1, BunifuAnimatorNS.DecorationType.None)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'frmPurchases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 742)
        Me.Controls.Add(Me.tabInventory)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPurchases"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPurchases"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.tabInventory.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        Me.pnlRequestItems.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.Panel21.ResumeLayout(False)
        Me.Panel21.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnlViewRequest.ResumeLayout(False)
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.tabEdit.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.Panel25.ResumeLayout(False)
        Me.Panel25.PerformLayout()
        Me.Panel24.ResumeLayout(False)
        Me.Panel24.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.Panel23.ResumeLayout(False)
        Me.Panel23.PerformLayout()
        Me.Panel22.ResumeLayout(False)
        Me.Panel22.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents tabInventory As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtUnitCostPO As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtQuantityPO As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtTermsPO As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtEmailPO As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtWebsitePO As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtContactPO As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFaxPO As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtTinPO As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtTelephonePO As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtAddress As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPOID As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents tabEdit As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents cmbSupplier As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents MaterialFlatButton3 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents dgvItems As System.Windows.Forms.DataGridView
    Friend WithEvents lblDateRequest As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnDeletefromList As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnSendPurchase As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lblSuppID As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lvPOItems As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvInventoryItems1 As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader30 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader31 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader32 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MaterialFlatButton10 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents pnlViewRequest As System.Windows.Forms.Panel
    Friend WithEvents lvRequestPO As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader33 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader34 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader35 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader36 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader38 As System.Windows.Forms.ColumnHeader
    Friend WithEvents pnlRequestItems As System.Windows.Forms.Panel
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents lblPOIDitem As System.Windows.Forms.Label
    Friend WithEvents lvDetailedRequest As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MaterialFlatButton11 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton9 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lvRequestStatus As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblAmountinWord As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbAccountName As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents MaterialCheckBox1 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents MaterialSingleLineTextField2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents MaterialSingleLineTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtAccountCode As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents MaterialListView1 As MaterialSkin.Controls.MaterialListView
    Friend WithEvents MaterialFlatButton14 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton16 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lblTermsSupplier As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblJournalID As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblQuantityNeededRR As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblQuantityArrivedRR As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblUnitCostRR As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lvReceivingInvi As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader39 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader40 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader41 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader42 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader43 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader44 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader45 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader46 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader47 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MaterialLabel21 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel18 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtDateReceivedRR As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel17 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtQuantityReceivedRR As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel16 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtDescription As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel15 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtItemID As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel14 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel13 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialFlatButton15 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lvReceivingReport As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader37 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblReceivingReport As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel12 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel11 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cmbItemCodeRR As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents cmbPOReceive As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents lblAmtinWordsRR As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnCancelRR As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton18 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents ColumnHeader48 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader49 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader50 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader51 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader52 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MaterialFlatButton17 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lblpoidformat As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblSupplierID As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader53 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblinventorychart As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lbloutputvatot As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblPOtrueID As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblAmtInword As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents btnCancelAPV As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lblAVPID As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPO As System.Windows.Forms.Label
    Friend WithEvents lblInputVATPO1 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader54 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblGrandTotal1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblInputVat1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents lvbilling As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader55 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader56 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader57 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader58 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents dgvrecievingreport As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader59 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader60 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader61 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader62 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvpurchase As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader63 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader64 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader65 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader66 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader67 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader68 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents ColumnHeader69 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader70 As System.Windows.Forms.ColumnHeader
    Friend WithEvents dtpBilling As System.Windows.Forms.Label
    Friend WithEvents cmbPayee As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lbltotalvat1 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTerms1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtZip1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtCP1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtContact1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtAddress1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader71 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents btnCancelAll As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnRefreshView As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents MaterialFlatButton4 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents MaterialFlatButton6 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents MaterialFlatButton19 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lblTotalAPVoucher As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lbltotalvat As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lbltotalamount As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lvRetainedEarnings As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader72 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtAccountGroupAPV As System.Windows.Forms.TextBox
    Friend WithEvents lblAmtTotalPO As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblOutputVat As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblGrandTotal As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblInputVAT As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents ColumnHeader73 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader74 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader75 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtComments As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearchItem As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents MaterialFlatButton2 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents MaterialFlatButton5 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents MaterialFlatButton7 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Panel25 As System.Windows.Forms.Panel
    Friend WithEvents MaterialFlatButton12 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Panel24 As System.Windows.Forms.Panel
    Friend WithEvents MaterialFlatButton8 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader76 As System.Windows.Forms.ColumnHeader
End Class
