<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.tabInventory = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lvInventory = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton2 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnClearItem = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton4 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.chkVat = New MaterialSkin.Controls.MaterialCheckBox()
        Me.txtUOMItem = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMinStocksItem = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMaxStocksItem = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtUnitCostItem = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSellingPriceItem = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQuantityItem = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescriptionItem = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtItemCodeItem = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabEdit = New System.Windows.Forms.TabPage()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.btnSaveEdit = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtItemCodeEdit = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.pnlEditInventory = New System.Windows.Forms.Panel()
        Me.txtMinimumStocksEdit = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtMaximumStocksEdit = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtEditSellingPrice = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtDescriptionEdit = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtItemIDtoEdit = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Button2 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnClearEdit = New MaterialSkin.Controls.MaterialFlatButton()
        Me.dgvEditItems = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabInventory.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.tabEdit.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.pnlEditInventory.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgvEditItems, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BunifuTransition1.SetDecoration(Me.Panel2, BunifuAnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1378, 28)
        Me.Panel2.TabIndex = 5
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label35, BunifuAnimatorNS.DecorationType.None)
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(4, 4)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(129, 24)
        Me.Label35.TabIndex = 1
        Me.Label35.Text = "INVENTORY"
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
        Me.Panel1.Size = New System.Drawing.Size(1378, 28)
        Me.Panel1.TabIndex = 4
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTransition1.SetDecoration(Me.PictureBox3, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox3.Image = Global.ZamaryanSystem.My.Resources.Resources.Minimize_White
        Me.PictureBox3.Location = New System.Drawing.Point(1291, 0)
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
        Me.PictureBox2.Location = New System.Drawing.Point(1320, 0)
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
        Me.PictureBox1.Location = New System.Drawing.Point(1349, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.BunifuTransition1.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0.0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0.0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0.0!
        Animation2.RotateLimit = 0.0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0.0!
        Animation2.TransparencyCoeff = 0.0!
        Me.BunifuTransition1.DefaultAnimation = Animation2
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.tabInventory
        Me.BunifuTransition1.SetDecoration(Me.MaterialTabSelector1, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 0)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(1380, 28)
        Me.MaterialTabSelector1.TabIndex = 0
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'tabInventory
        '
        Me.tabInventory.Controls.Add(Me.TabPage1)
        Me.tabInventory.Controls.Add(Me.TabPage2)
        Me.tabInventory.Controls.Add(Me.tabEdit)
        Me.BunifuTransition1.SetDecoration(Me.tabInventory, BunifuAnimatorNS.DecorationType.None)
        Me.tabInventory.Depth = 0
        Me.tabInventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabInventory.Location = New System.Drawing.Point(0, 28)
        Me.tabInventory.MouseState = MaterialSkin.MouseState.HOVER
        Me.tabInventory.Name = "tabInventory"
        Me.tabInventory.SelectedIndex = 0
        Me.tabInventory.Size = New System.Drawing.Size(1380, 653)
        Me.tabInventory.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Panel9)
        Me.TabPage1.Controls.Add(Me.lvInventory)
        Me.TabPage1.Controls.Add(Me.Panel7)
        Me.BunifuTransition1.SetDecoration(Me.TabPage1, BunifuAnimatorNS.DecorationType.None)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1372, 627)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inventory"
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel9.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel9.Controls.Add(Me.MaterialFlatButton1)
        Me.BunifuTransition1.SetDecoration(Me.Panel9, BunifuAnimatorNS.DecorationType.None)
        Me.Panel9.Location = New System.Drawing.Point(820, 549)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(123, 42)
        Me.Panel9.TabIndex = 41
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
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(123, 42)
        Me.MaterialFlatButton1.TabIndex = 1
        Me.MaterialFlatButton1.Text = "Print all"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'lvInventory
        '
        Me.lvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvInventory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.BunifuTransition1.SetDecoration(Me.lvInventory, BunifuAnimatorNS.DecorationType.None)
        Me.lvInventory.Depth = 0
        Me.lvInventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.lvInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lvInventory.FullRowSelect = True
        Me.lvInventory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvInventory.Location = New System.Drawing.Point(3, 3)
        Me.lvInventory.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.lvInventory.MouseState = MaterialSkin.MouseState.OUT
        Me.lvInventory.Name = "lvInventory"
        Me.lvInventory.OwnerDraw = True
        Me.lvInventory.Size = New System.Drawing.Size(1366, 540)
        Me.lvInventory.TabIndex = 0
        Me.lvInventory.UseCompatibleStateImageBehavior = False
        Me.lvInventory.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Item Code"
        Me.ColumnHeader1.Width = 140
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Description"
        Me.ColumnHeader2.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Number in Stocks"
        Me.ColumnHeader3.Width = 190
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Max Stocks"
        Me.ColumnHeader4.Width = 130
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Min Stocks"
        Me.ColumnHeader5.Width = 130
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Running Balance"
        Me.ColumnHeader6.Width = 140
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel7.Controls.Add(Me.MaterialFlatButton2)
        Me.BunifuTransition1.SetDecoration(Me.Panel7, BunifuAnimatorNS.DecorationType.None)
        Me.Panel7.Location = New System.Drawing.Point(955, 550)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(123, 42)
        Me.Panel7.TabIndex = 39
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
        Me.MaterialFlatButton2.Size = New System.Drawing.Size(123, 42)
        Me.MaterialFlatButton2.TabIndex = 1
        Me.MaterialFlatButton2.Text = "Refresh Items"
        Me.MaterialFlatButton2.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Panel8)
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Controls.Add(Me.chkVat)
        Me.TabPage2.Controls.Add(Me.txtUOMItem)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtMinStocksItem)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txtMaxStocksItem)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txtUnitCostItem)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtSellingPriceItem)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtQuantityItem)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtDescriptionItem)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtItemCodeItem)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.BunifuTransition1.SetDecoration(Me.TabPage2, BunifuAnimatorNS.DecorationType.None)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1372, 627)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add New Item"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel8.Controls.Add(Me.btnClearItem)
        Me.BunifuTransition1.SetDecoration(Me.Panel8, BunifuAnimatorNS.DecorationType.None)
        Me.Panel8.Location = New System.Drawing.Point(813, 344)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(83, 37)
        Me.Panel8.TabIndex = 39
        '
        'btnClearItem
        '
        Me.btnClearItem.AutoSize = True
        Me.btnClearItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.btnClearItem, BunifuAnimatorNS.DecorationType.None)
        Me.btnClearItem.Depth = 0
        Me.btnClearItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClearItem.Icon = Nothing
        Me.btnClearItem.Location = New System.Drawing.Point(0, 0)
        Me.btnClearItem.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnClearItem.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClearItem.Name = "btnClearItem"
        Me.btnClearItem.Primary = False
        Me.btnClearItem.Size = New System.Drawing.Size(83, 37)
        Me.btnClearItem.TabIndex = 1
        Me.btnClearItem.Text = "Clear"
        Me.btnClearItem.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel5.Controls.Add(Me.MaterialFlatButton4)
        Me.BunifuTransition1.SetDecoration(Me.Panel5, BunifuAnimatorNS.DecorationType.None)
        Me.Panel5.Location = New System.Drawing.Point(723, 344)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(83, 37)
        Me.Panel5.TabIndex = 39
        '
        'MaterialFlatButton4
        '
        Me.MaterialFlatButton4.AutoSize = True
        Me.MaterialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.MaterialFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.MaterialFlatButton4.Depth = 0
        Me.MaterialFlatButton4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialFlatButton4.Icon = Nothing
        Me.MaterialFlatButton4.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton4.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton4.Name = "MaterialFlatButton4"
        Me.MaterialFlatButton4.Primary = False
        Me.MaterialFlatButton4.Size = New System.Drawing.Size(83, 37)
        Me.MaterialFlatButton4.TabIndex = 2
        Me.MaterialFlatButton4.Text = "Save"
        Me.MaterialFlatButton4.UseVisualStyleBackColor = True
        '
        'chkVat
        '
        Me.chkVat.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.chkVat, BunifuAnimatorNS.DecorationType.None)
        Me.chkVat.Depth = 0
        Me.chkVat.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.chkVat.ForeColor = System.Drawing.Color.Black
        Me.chkVat.Location = New System.Drawing.Point(436, 173)
        Me.chkVat.Margin = New System.Windows.Forms.Padding(0)
        Me.chkVat.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.chkVat.MouseState = MaterialSkin.MouseState.HOVER
        Me.chkVat.Name = "chkVat"
        Me.chkVat.Ripple = True
        Me.chkVat.Size = New System.Drawing.Size(77, 30)
        Me.chkVat.TabIndex = 18
        Me.chkVat.Text = "Vatable"
        Me.chkVat.UseCompatibleTextRendering = True
        Me.chkVat.UseVisualStyleBackColor = True
        '
        'txtUOMItem
        '
        Me.BunifuTransition1.SetDecoration(Me.txtUOMItem, BunifuAnimatorNS.DecorationType.None)
        Me.txtUOMItem.Depth = 0
        Me.txtUOMItem.ForeColor = System.Drawing.Color.Black
        Me.txtUOMItem.Hint = ""
        Me.txtUOMItem.Location = New System.Drawing.Point(604, 144)
        Me.txtUOMItem.MaxLength = 32767
        Me.txtUOMItem.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtUOMItem.Name = "txtUOMItem"
        Me.txtUOMItem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUOMItem.SelectedText = ""
        Me.txtUOMItem.SelectionLength = 0
        Me.txtUOMItem.SelectionStart = 0
        Me.txtUOMItem.Size = New System.Drawing.Size(243, 23)
        Me.txtUOMItem.TabIndex = 17
        Me.txtUOMItem.TabStop = False
        Me.txtUOMItem.UseSystemPasswordChar = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(432, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Unit of Measurement"
        '
        'txtMinStocksItem
        '
        Me.BunifuTransition1.SetDecoration(Me.txtMinStocksItem, BunifuAnimatorNS.DecorationType.None)
        Me.txtMinStocksItem.Depth = 0
        Me.txtMinStocksItem.ForeColor = System.Drawing.Color.Black
        Me.txtMinStocksItem.Hint = ""
        Me.txtMinStocksItem.Location = New System.Drawing.Point(604, 106)
        Me.txtMinStocksItem.MaxLength = 32767
        Me.txtMinStocksItem.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtMinStocksItem.Name = "txtMinStocksItem"
        Me.txtMinStocksItem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMinStocksItem.SelectedText = ""
        Me.txtMinStocksItem.SelectionLength = 0
        Me.txtMinStocksItem.SelectionStart = 0
        Me.txtMinStocksItem.Size = New System.Drawing.Size(243, 23)
        Me.txtMinStocksItem.TabIndex = 15
        Me.txtMinStocksItem.TabStop = False
        Me.txtMinStocksItem.UseSystemPasswordChar = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(432, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Minimum Stocks"
        '
        'txtMaxStocksItem
        '
        Me.BunifuTransition1.SetDecoration(Me.txtMaxStocksItem, BunifuAnimatorNS.DecorationType.None)
        Me.txtMaxStocksItem.Depth = 0
        Me.txtMaxStocksItem.ForeColor = System.Drawing.Color.Black
        Me.txtMaxStocksItem.Hint = ""
        Me.txtMaxStocksItem.Location = New System.Drawing.Point(604, 63)
        Me.txtMaxStocksItem.MaxLength = 32767
        Me.txtMaxStocksItem.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtMaxStocksItem.Name = "txtMaxStocksItem"
        Me.txtMaxStocksItem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMaxStocksItem.SelectedText = ""
        Me.txtMaxStocksItem.SelectionLength = 0
        Me.txtMaxStocksItem.SelectionStart = 0
        Me.txtMaxStocksItem.Size = New System.Drawing.Size(243, 23)
        Me.txtMaxStocksItem.TabIndex = 13
        Me.txtMaxStocksItem.TabStop = False
        Me.txtMaxStocksItem.UseSystemPasswordChar = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label9, BunifuAnimatorNS.DecorationType.None)
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(432, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Maximum Stocks"
        '
        'txtUnitCostItem
        '
        Me.BunifuTransition1.SetDecoration(Me.txtUnitCostItem, BunifuAnimatorNS.DecorationType.None)
        Me.txtUnitCostItem.Depth = 0
        Me.txtUnitCostItem.ForeColor = System.Drawing.Color.Black
        Me.txtUnitCostItem.Hint = ""
        Me.txtUnitCostItem.Location = New System.Drawing.Point(138, 216)
        Me.txtUnitCostItem.MaxLength = 32767
        Me.txtUnitCostItem.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtUnitCostItem.Name = "txtUnitCostItem"
        Me.txtUnitCostItem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUnitCostItem.SelectedText = ""
        Me.txtUnitCostItem.SelectionLength = 0
        Me.txtUnitCostItem.SelectionStart = 0
        Me.txtUnitCostItem.Size = New System.Drawing.Size(243, 23)
        Me.txtUnitCostItem.TabIndex = 9
        Me.txtUnitCostItem.TabStop = False
        Me.txtUnitCostItem.UseSystemPasswordChar = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(29, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Unit Cost"
        '
        'txtSellingPriceItem
        '
        Me.BunifuTransition1.SetDecoration(Me.txtSellingPriceItem, BunifuAnimatorNS.DecorationType.None)
        Me.txtSellingPriceItem.Depth = 0
        Me.txtSellingPriceItem.ForeColor = System.Drawing.Color.Black
        Me.txtSellingPriceItem.Hint = ""
        Me.txtSellingPriceItem.Location = New System.Drawing.Point(138, 176)
        Me.txtSellingPriceItem.MaxLength = 32767
        Me.txtSellingPriceItem.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtSellingPriceItem.Name = "txtSellingPriceItem"
        Me.txtSellingPriceItem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSellingPriceItem.SelectedText = ""
        Me.txtSellingPriceItem.SelectionLength = 0
        Me.txtSellingPriceItem.SelectionStart = 0
        Me.txtSellingPriceItem.Size = New System.Drawing.Size(243, 23)
        Me.txtSellingPriceItem.TabIndex = 7
        Me.txtSellingPriceItem.TabStop = False
        Me.txtSellingPriceItem.UseSystemPasswordChar = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(29, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Selling Price"
        '
        'txtQuantityItem
        '
        Me.BunifuTransition1.SetDecoration(Me.txtQuantityItem, BunifuAnimatorNS.DecorationType.None)
        Me.txtQuantityItem.Depth = 0
        Me.txtQuantityItem.ForeColor = System.Drawing.Color.Black
        Me.txtQuantityItem.Hint = ""
        Me.txtQuantityItem.Location = New System.Drawing.Point(140, 139)
        Me.txtQuantityItem.MaxLength = 32767
        Me.txtQuantityItem.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtQuantityItem.Name = "txtQuantityItem"
        Me.txtQuantityItem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQuantityItem.SelectedText = ""
        Me.txtQuantityItem.SelectionLength = 0
        Me.txtQuantityItem.SelectionStart = 0
        Me.txtQuantityItem.Size = New System.Drawing.Size(243, 23)
        Me.txtQuantityItem.TabIndex = 5
        Me.txtQuantityItem.TabStop = False
        Me.txtQuantityItem.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(31, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Quantity"
        '
        'txtDescriptionItem
        '
        Me.BunifuTransition1.SetDecoration(Me.txtDescriptionItem, BunifuAnimatorNS.DecorationType.None)
        Me.txtDescriptionItem.Depth = 0
        Me.txtDescriptionItem.ForeColor = System.Drawing.Color.Black
        Me.txtDescriptionItem.Hint = ""
        Me.txtDescriptionItem.Location = New System.Drawing.Point(138, 99)
        Me.txtDescriptionItem.MaxLength = 32767
        Me.txtDescriptionItem.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtDescriptionItem.Name = "txtDescriptionItem"
        Me.txtDescriptionItem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescriptionItem.SelectedText = ""
        Me.txtDescriptionItem.SelectionLength = 0
        Me.txtDescriptionItem.SelectionStart = 0
        Me.txtDescriptionItem.Size = New System.Drawing.Size(243, 23)
        Me.txtDescriptionItem.TabIndex = 3
        Me.txtDescriptionItem.TabStop = False
        Me.txtDescriptionItem.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(29, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description"
        '
        'txtItemCodeItem
        '
        Me.BunifuTransition1.SetDecoration(Me.txtItemCodeItem, BunifuAnimatorNS.DecorationType.None)
        Me.txtItemCodeItem.Depth = 0
        Me.txtItemCodeItem.Enabled = False
        Me.txtItemCodeItem.ForeColor = System.Drawing.Color.Black
        Me.txtItemCodeItem.Hint = ""
        Me.txtItemCodeItem.Location = New System.Drawing.Point(138, 59)
        Me.txtItemCodeItem.MaxLength = 32767
        Me.txtItemCodeItem.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtItemCodeItem.Name = "txtItemCodeItem"
        Me.txtItemCodeItem.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemCodeItem.SelectedText = ""
        Me.txtItemCodeItem.SelectionLength = 0
        Me.txtItemCodeItem.SelectionStart = 0
        Me.txtItemCodeItem.Size = New System.Drawing.Size(243, 23)
        Me.txtItemCodeItem.TabIndex = 1
        Me.txtItemCodeItem.TabStop = False
        Me.txtItemCodeItem.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(29, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item Code"
        '
        'tabEdit
        '
        Me.tabEdit.BackColor = System.Drawing.SystemColors.Control
        Me.tabEdit.Controls.Add(Me.Panel10)
        Me.tabEdit.Controls.Add(Me.Label6)
        Me.tabEdit.Controls.Add(Me.txtItemCodeEdit)
        Me.tabEdit.Controls.Add(Me.pnlEditInventory)
        Me.tabEdit.Controls.Add(Me.Panel6)
        Me.tabEdit.Controls.Add(Me.dgvEditItems)
        Me.BunifuTransition1.SetDecoration(Me.tabEdit, BunifuAnimatorNS.DecorationType.None)
        Me.tabEdit.Location = New System.Drawing.Point(4, 22)
        Me.tabEdit.Name = "tabEdit"
        Me.tabEdit.Size = New System.Drawing.Size(1372, 627)
        Me.tabEdit.TabIndex = 2
        Me.tabEdit.Text = "Edit Item"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel10.Controls.Add(Me.btnSaveEdit)
        Me.BunifuTransition1.SetDecoration(Me.Panel10, BunifuAnimatorNS.DecorationType.None)
        Me.Panel10.Location = New System.Drawing.Point(925, 549)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(78, 39)
        Me.Panel10.TabIndex = 32
        '
        'btnSaveEdit
        '
        Me.btnSaveEdit.AutoSize = True
        Me.btnSaveEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.btnSaveEdit, BunifuAnimatorNS.DecorationType.None)
        Me.btnSaveEdit.Depth = 0
        Me.btnSaveEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSaveEdit.Icon = Nothing
        Me.btnSaveEdit.Location = New System.Drawing.Point(0, 0)
        Me.btnSaveEdit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSaveEdit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSaveEdit.Name = "btnSaveEdit"
        Me.btnSaveEdit.Primary = False
        Me.btnSaveEdit.Size = New System.Drawing.Size(78, 39)
        Me.btnSaveEdit.TabIndex = 2
        Me.btnSaveEdit.Text = "Edit"
        Me.btnSaveEdit.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(24, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Search"
        '
        'txtItemCodeEdit
        '
        Me.BunifuTransition1.SetDecoration(Me.txtItemCodeEdit, BunifuAnimatorNS.DecorationType.None)
        Me.txtItemCodeEdit.Depth = 0
        Me.txtItemCodeEdit.ForeColor = System.Drawing.Color.Black
        Me.txtItemCodeEdit.Hint = ""
        Me.txtItemCodeEdit.Location = New System.Drawing.Point(81, 13)
        Me.txtItemCodeEdit.MaxLength = 32767
        Me.txtItemCodeEdit.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtItemCodeEdit.Name = "txtItemCodeEdit"
        Me.txtItemCodeEdit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemCodeEdit.SelectedText = ""
        Me.txtItemCodeEdit.SelectionLength = 0
        Me.txtItemCodeEdit.SelectionStart = 0
        Me.txtItemCodeEdit.Size = New System.Drawing.Size(177, 23)
        Me.txtItemCodeEdit.TabIndex = 30
        Me.txtItemCodeEdit.TabStop = False
        Me.txtItemCodeEdit.UseSystemPasswordChar = False
        '
        'pnlEditInventory
        '
        Me.pnlEditInventory.BackColor = System.Drawing.SystemColors.Control
        Me.pnlEditInventory.Controls.Add(Me.txtMinimumStocksEdit)
        Me.pnlEditInventory.Controls.Add(Me.txtMaximumStocksEdit)
        Me.pnlEditInventory.Controls.Add(Me.txtEditSellingPrice)
        Me.pnlEditInventory.Controls.Add(Me.txtDescriptionEdit)
        Me.pnlEditInventory.Controls.Add(Me.txtItemIDtoEdit)
        Me.pnlEditInventory.Controls.Add(Me.Button2)
        Me.pnlEditInventory.Controls.Add(Me.Label14)
        Me.pnlEditInventory.Controls.Add(Me.Label13)
        Me.pnlEditInventory.Controls.Add(Me.Label10)
        Me.pnlEditInventory.Controls.Add(Me.Label12)
        Me.pnlEditInventory.Controls.Add(Me.Label11)
        Me.BunifuTransition1.SetDecoration(Me.pnlEditInventory, BunifuAnimatorNS.DecorationType.None)
        Me.pnlEditInventory.Location = New System.Drawing.Point(27, 43)
        Me.pnlEditInventory.Name = "pnlEditInventory"
        Me.pnlEditInventory.Size = New System.Drawing.Size(538, 500)
        Me.pnlEditInventory.TabIndex = 29
        Me.pnlEditInventory.Visible = False
        '
        'txtMinimumStocksEdit
        '
        Me.BunifuTransition1.SetDecoration(Me.txtMinimumStocksEdit, BunifuAnimatorNS.DecorationType.None)
        Me.txtMinimumStocksEdit.Depth = 0
        Me.txtMinimumStocksEdit.Enabled = False
        Me.txtMinimumStocksEdit.ForeColor = System.Drawing.Color.Black
        Me.txtMinimumStocksEdit.Hint = ""
        Me.txtMinimumStocksEdit.Location = New System.Drawing.Point(143, 218)
        Me.txtMinimumStocksEdit.MaxLength = 32767
        Me.txtMinimumStocksEdit.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtMinimumStocksEdit.Name = "txtMinimumStocksEdit"
        Me.txtMinimumStocksEdit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMinimumStocksEdit.SelectedText = ""
        Me.txtMinimumStocksEdit.SelectionLength = 0
        Me.txtMinimumStocksEdit.SelectionStart = 0
        Me.txtMinimumStocksEdit.Size = New System.Drawing.Size(177, 23)
        Me.txtMinimumStocksEdit.TabIndex = 37
        Me.txtMinimumStocksEdit.TabStop = False
        Me.txtMinimumStocksEdit.UseSystemPasswordChar = False
        '
        'txtMaximumStocksEdit
        '
        Me.BunifuTransition1.SetDecoration(Me.txtMaximumStocksEdit, BunifuAnimatorNS.DecorationType.None)
        Me.txtMaximumStocksEdit.Depth = 0
        Me.txtMaximumStocksEdit.Enabled = False
        Me.txtMaximumStocksEdit.ForeColor = System.Drawing.Color.Black
        Me.txtMaximumStocksEdit.Hint = ""
        Me.txtMaximumStocksEdit.Location = New System.Drawing.Point(143, 168)
        Me.txtMaximumStocksEdit.MaxLength = 32767
        Me.txtMaximumStocksEdit.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtMaximumStocksEdit.Name = "txtMaximumStocksEdit"
        Me.txtMaximumStocksEdit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMaximumStocksEdit.SelectedText = ""
        Me.txtMaximumStocksEdit.SelectionLength = 0
        Me.txtMaximumStocksEdit.SelectionStart = 0
        Me.txtMaximumStocksEdit.Size = New System.Drawing.Size(177, 23)
        Me.txtMaximumStocksEdit.TabIndex = 36
        Me.txtMaximumStocksEdit.TabStop = False
        Me.txtMaximumStocksEdit.UseSystemPasswordChar = False
        '
        'txtEditSellingPrice
        '
        Me.BunifuTransition1.SetDecoration(Me.txtEditSellingPrice, BunifuAnimatorNS.DecorationType.None)
        Me.txtEditSellingPrice.Depth = 0
        Me.txtEditSellingPrice.Enabled = False
        Me.txtEditSellingPrice.ForeColor = System.Drawing.Color.Black
        Me.txtEditSellingPrice.Hint = ""
        Me.txtEditSellingPrice.Location = New System.Drawing.Point(143, 126)
        Me.txtEditSellingPrice.MaxLength = 32767
        Me.txtEditSellingPrice.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtEditSellingPrice.Name = "txtEditSellingPrice"
        Me.txtEditSellingPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEditSellingPrice.SelectedText = ""
        Me.txtEditSellingPrice.SelectionLength = 0
        Me.txtEditSellingPrice.SelectionStart = 0
        Me.txtEditSellingPrice.Size = New System.Drawing.Size(177, 23)
        Me.txtEditSellingPrice.TabIndex = 35
        Me.txtEditSellingPrice.TabStop = False
        Me.txtEditSellingPrice.UseSystemPasswordChar = False
        '
        'txtDescriptionEdit
        '
        Me.BunifuTransition1.SetDecoration(Me.txtDescriptionEdit, BunifuAnimatorNS.DecorationType.None)
        Me.txtDescriptionEdit.Depth = 0
        Me.txtDescriptionEdit.Enabled = False
        Me.txtDescriptionEdit.ForeColor = System.Drawing.Color.Black
        Me.txtDescriptionEdit.Hint = ""
        Me.txtDescriptionEdit.Location = New System.Drawing.Point(143, 84)
        Me.txtDescriptionEdit.MaxLength = 32767
        Me.txtDescriptionEdit.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtDescriptionEdit.Name = "txtDescriptionEdit"
        Me.txtDescriptionEdit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescriptionEdit.SelectedText = ""
        Me.txtDescriptionEdit.SelectionLength = 0
        Me.txtDescriptionEdit.SelectionStart = 0
        Me.txtDescriptionEdit.Size = New System.Drawing.Size(177, 23)
        Me.txtDescriptionEdit.TabIndex = 34
        Me.txtDescriptionEdit.TabStop = False
        Me.txtDescriptionEdit.UseSystemPasswordChar = False
        '
        'txtItemIDtoEdit
        '
        Me.BunifuTransition1.SetDecoration(Me.txtItemIDtoEdit, BunifuAnimatorNS.DecorationType.None)
        Me.txtItemIDtoEdit.Depth = 0
        Me.txtItemIDtoEdit.Enabled = False
        Me.txtItemIDtoEdit.ForeColor = System.Drawing.Color.Black
        Me.txtItemIDtoEdit.Hint = ""
        Me.txtItemIDtoEdit.Location = New System.Drawing.Point(143, 39)
        Me.txtItemIDtoEdit.MaxLength = 32767
        Me.txtItemIDtoEdit.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtItemIDtoEdit.Name = "txtItemIDtoEdit"
        Me.txtItemIDtoEdit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemIDtoEdit.SelectedText = ""
        Me.txtItemIDtoEdit.SelectionLength = 0
        Me.txtItemIDtoEdit.SelectionStart = 0
        Me.txtItemIDtoEdit.Size = New System.Drawing.Size(177, 23)
        Me.txtItemIDtoEdit.TabIndex = 33
        Me.txtItemIDtoEdit.TabStop = False
        Me.txtItemIDtoEdit.UseSystemPasswordChar = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.Button2, BunifuAnimatorNS.DecorationType.None)
        Me.Button2.Depth = 0
        Me.Button2.Icon = Nothing
        Me.Button2.Location = New System.Drawing.Point(208, 260)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button2.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button2.Name = "Button2"
        Me.Button2.Primary = False
        Me.Button2.Size = New System.Drawing.Size(112, 36)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Request Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label14, BunifuAnimatorNS.DecorationType.None)
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(20, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 17)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "ID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label13, BunifuAnimatorNS.DecorationType.None)
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(20, 132)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 17)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Selling Price"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label10, BunifuAnimatorNS.DecorationType.None)
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(20, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 17)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Description"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label12, BunifuAnimatorNS.DecorationType.None)
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(20, 224)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 17)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Minimum Stocks"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label11, BunifuAnimatorNS.DecorationType.None)
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(20, 174)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 17)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Maximum Stocks"
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel6.Controls.Add(Me.btnClearEdit)
        Me.BunifuTransition1.SetDecoration(Me.Panel6, BunifuAnimatorNS.DecorationType.None)
        Me.Panel6.Location = New System.Drawing.Point(1010, 548)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(83, 40)
        Me.Panel6.TabIndex = 20
        Me.Panel6.Visible = False
        '
        'btnClearEdit
        '
        Me.btnClearEdit.AutoSize = True
        Me.btnClearEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuTransition1.SetDecoration(Me.btnClearEdit, BunifuAnimatorNS.DecorationType.None)
        Me.btnClearEdit.Depth = 0
        Me.btnClearEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClearEdit.Icon = Nothing
        Me.btnClearEdit.Location = New System.Drawing.Point(0, 0)
        Me.btnClearEdit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnClearEdit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClearEdit.Name = "btnClearEdit"
        Me.btnClearEdit.Primary = False
        Me.btnClearEdit.Size = New System.Drawing.Size(83, 40)
        Me.btnClearEdit.TabIndex = 1
        Me.btnClearEdit.Text = "Clear"
        Me.btnClearEdit.UseVisualStyleBackColor = True
        '
        'dgvEditItems
        '
        Me.dgvEditItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEditItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvEditItems.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvEditItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuTransition1.SetDecoration(Me.dgvEditItems, BunifuAnimatorNS.DecorationType.None)
        Me.dgvEditItems.Location = New System.Drawing.Point(27, 43)
        Me.dgvEditItems.MultiSelect = False
        Me.dgvEditItems.Name = "dgvEditItems"
        Me.dgvEditItems.ReadOnly = True
        Me.dgvEditItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEditItems.Size = New System.Drawing.Size(1066, 500)
        Me.dgvEditItems.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuTransition1.SetDecoration(Me.Panel4, BunifuAnimatorNS.DecorationType.None)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 687)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1380, 45)
        Me.Panel4.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.tabInventory)
        Me.Panel3.Controls.Add(Me.MaterialTabSelector1)
        Me.BunifuTransition1.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.Panel3.Location = New System.Drawing.Point(0, 56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1380, 732)
        Me.Panel3.TabIndex = 6
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 780)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "."
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabInventory.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.tabEdit.ResumeLayout(False)
        Me.tabEdit.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.pnlEditInventory.ResumeLayout(False)
        Me.pnlEditInventory.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.dgvEditItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents tabInventory As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lvInventory As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents MaterialFlatButton2 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents btnClearItem As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents MaterialFlatButton4 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents chkVat As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents txtUOMItem As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMinStocksItem As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMaxStocksItem As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtUnitCostItem As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSellingPriceItem As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtQuantityItem As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescriptionItem As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtItemCodeItem As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabEdit As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtItemCodeEdit As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents pnlEditInventory As System.Windows.Forms.Panel
    Friend WithEvents txtMinimumStocksEdit As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtMaximumStocksEdit As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtEditSellingPrice As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtDescriptionEdit As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtItemIDtoEdit As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Button2 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnSaveEdit As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnClearEdit As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents dgvEditItems As System.Windows.Forms.DataGridView
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
End Class
