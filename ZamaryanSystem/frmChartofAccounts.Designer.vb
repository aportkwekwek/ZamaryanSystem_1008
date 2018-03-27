<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChartofAccounts
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
        Me.tabChartsofAcc = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lvAccountsChart = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.MaterialFlatButton4 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.cbaccgroup = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnClearItem = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAccName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAccCode = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabChartsofAcc.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
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
        Me.Panel2.TabIndex = 5
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
        Me.Panel1.TabIndex = 4
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
        'tabChartsofAcc
        '
        Me.tabChartsofAcc.Controls.Add(Me.TabPage1)
        Me.tabChartsofAcc.Controls.Add(Me.TabPage2)
        Me.tabChartsofAcc.Depth = 0
        Me.tabChartsofAcc.Dock = System.Windows.Forms.DockStyle.Top
        Me.tabChartsofAcc.Location = New System.Drawing.Point(0, 84)
        Me.tabChartsofAcc.MouseState = MaterialSkin.MouseState.HOVER
        Me.tabChartsofAcc.Name = "tabChartsofAcc"
        Me.tabChartsofAcc.SelectedIndex = 0
        Me.tabChartsofAcc.Size = New System.Drawing.Size(924, 590)
        Me.tabChartsofAcc.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.lvAccountsChart)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(916, 564)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View Charts"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel3.Controls.Add(Me.MaterialFlatButton1)
        Me.Panel3.Location = New System.Drawing.Point(950, 550)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(146, 33)
        Me.Panel3.TabIndex = 1
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
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(146, 33)
        Me.MaterialFlatButton1.TabIndex = 0
        Me.MaterialFlatButton1.Text = "Refresh List"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'lvAccountsChart
        '
        Me.lvAccountsChart.BackColor = System.Drawing.SystemColors.Control
        Me.lvAccountsChart.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvAccountsChart.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvAccountsChart.Depth = 0
        Me.lvAccountsChart.Dock = System.Windows.Forms.DockStyle.Top
        Me.lvAccountsChart.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.lvAccountsChart.FullRowSelect = True
        Me.lvAccountsChart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvAccountsChart.Location = New System.Drawing.Point(3, 3)
        Me.lvAccountsChart.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.lvAccountsChart.MouseState = MaterialSkin.MouseState.OUT
        Me.lvAccountsChart.Name = "lvAccountsChart"
        Me.lvAccountsChart.OwnerDraw = True
        Me.lvAccountsChart.Size = New System.Drawing.Size(910, 541)
        Me.lvAccountsChart.TabIndex = 0
        Me.lvAccountsChart.UseCompatibleStateImageBehavior = False
        Me.lvAccountsChart.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Account Code"
        Me.ColumnHeader1.Width = 300
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Account Name"
        Me.ColumnHeader2.Width = 300
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Account Group"
        Me.ColumnHeader3.Width = 300
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Panel6)
        Me.TabPage2.Controls.Add(Me.cbaccgroup)
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtAccName)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtAccCode)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(916, 564)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add New Chart of Account"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel6.Controls.Add(Me.MaterialFlatButton4)
        Me.Panel6.Location = New System.Drawing.Point(748, 333)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(64, 38)
        Me.Panel6.TabIndex = 20
        '
        'MaterialFlatButton4
        '
        Me.MaterialFlatButton4.AutoSize = True
        Me.MaterialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton4.Depth = 0
        Me.MaterialFlatButton4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialFlatButton4.ForeColor = System.Drawing.Color.White
        Me.MaterialFlatButton4.Icon = Nothing
        Me.MaterialFlatButton4.Location = New System.Drawing.Point(0, 0)
        Me.MaterialFlatButton4.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton4.Name = "MaterialFlatButton4"
        Me.MaterialFlatButton4.Primary = False
        Me.MaterialFlatButton4.Size = New System.Drawing.Size(64, 38)
        Me.MaterialFlatButton4.TabIndex = 2
        Me.MaterialFlatButton4.Text = "Add"
        Me.MaterialFlatButton4.UseVisualStyleBackColor = True
        '
        'cbaccgroup
        '
        Me.cbaccgroup.BackColor = System.Drawing.Color.Transparent
        Me.cbaccgroup.BorderRadius = 3
        Me.cbaccgroup.DisabledColor = System.Drawing.Color.Gray
        Me.cbaccgroup.ForeColor = System.Drawing.Color.Black
        Me.cbaccgroup.Items = New String(-1) {}
        Me.cbaccgroup.Location = New System.Drawing.Point(186, 138)
        Me.cbaccgroup.Name = "cbaccgroup"
        Me.cbaccgroup.NomalColor = System.Drawing.SystemColors.HotTrack
        Me.cbaccgroup.onHoverColor = System.Drawing.SystemColors.Highlight
        Me.cbaccgroup.selectedIndex = -1
        Me.cbaccgroup.Size = New System.Drawing.Size(237, 28)
        Me.cbaccgroup.TabIndex = 20
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel5.Controls.Add(Me.btnClearItem)
        Me.Panel5.Location = New System.Drawing.Point(818, 333)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(61, 38)
        Me.Panel5.TabIndex = 19
        '
        'btnClearItem
        '
        Me.btnClearItem.AutoSize = True
        Me.btnClearItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnClearItem.Depth = 0
        Me.btnClearItem.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClearItem.ForeColor = System.Drawing.Color.White
        Me.btnClearItem.Icon = Nothing
        Me.btnClearItem.Location = New System.Drawing.Point(-2, 0)
        Me.btnClearItem.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnClearItem.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnClearItem.Name = "btnClearItem"
        Me.btnClearItem.Primary = False
        Me.btnClearItem.Size = New System.Drawing.Size(63, 38)
        Me.btnClearItem.TabIndex = 1
        Me.btnClearItem.Text = "Clear"
        Me.btnClearItem.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(20, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Account Group"
        '
        'txtAccName
        '
        Me.txtAccName.Depth = 0
        Me.txtAccName.ForeColor = System.Drawing.Color.Black
        Me.txtAccName.Hint = ""
        Me.txtAccName.Location = New System.Drawing.Point(186, 99)
        Me.txtAccName.MaxLength = 32767
        Me.txtAccName.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtAccName.Name = "txtAccName"
        Me.txtAccName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAccName.SelectedText = ""
        Me.txtAccName.SelectionLength = 0
        Me.txtAccName.SelectionStart = 0
        Me.txtAccName.Size = New System.Drawing.Size(243, 23)
        Me.txtAccName.TabIndex = 3
        Me.txtAccName.TabStop = False
        Me.txtAccName.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(20, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Account Name"
        '
        'txtAccCode
        '
        Me.txtAccCode.Depth = 0
        Me.txtAccCode.ForeColor = System.Drawing.Color.Black
        Me.txtAccCode.Hint = ""
        Me.txtAccCode.Location = New System.Drawing.Point(186, 59)
        Me.txtAccCode.MaxLength = 32767
        Me.txtAccCode.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtAccCode.Name = "txtAccCode"
        Me.txtAccCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAccCode.SelectedText = ""
        Me.txtAccCode.SelectionLength = 0
        Me.txtAccCode.SelectionStart = 0
        Me.txtAccCode.Size = New System.Drawing.Size(243, 23)
        Me.txtAccCode.TabIndex = 1
        Me.txtAccCode.TabStop = False
        Me.txtAccCode.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(20, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account Code"
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.tabChartsofAcc
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(0, 56)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(924, 28)
        Me.MaterialTabSelector1.TabIndex = 6
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 512)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(924, 46)
        Me.Panel4.TabIndex = 8
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(4, 4)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(234, 24)
        Me.Label35.TabIndex = 1
        Me.Label35.Text = "CHART OF ACCOUNTS"
        '
        'frmChartofAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 558)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.tabChartsofAcc)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmChartofAccounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmChartofAccounts"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabChartsofAcc.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tabChartsofAcc As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents MaterialFlatButton4 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnClearItem As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAccName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAccCode As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents lvAccountsChart As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cbaccgroup As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label35 As System.Windows.Forms.Label
End Class
