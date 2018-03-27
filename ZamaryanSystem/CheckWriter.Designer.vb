<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckWriter
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.txtissuer = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtamount = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.dtdate = New MetroFramework.Controls.MetroDateTime()
        Me.lblamountinwords = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnHeaderSave = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtissuer
        '
        Me.txtissuer.Depth = 0
        Me.txtissuer.Enabled = False
        Me.txtissuer.Hint = ""
        Me.txtissuer.Location = New System.Drawing.Point(16, 102)
        Me.txtissuer.MaxLength = 32767
        Me.txtissuer.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtissuer.Name = "txtissuer"
        Me.txtissuer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtissuer.SelectedText = ""
        Me.txtissuer.SelectionLength = 0
        Me.txtissuer.SelectionStart = 0
        Me.txtissuer.Size = New System.Drawing.Size(200, 23)
        Me.txtissuer.TabIndex = 0
        Me.txtissuer.TabStop = False
        Me.txtissuer.UseSystemPasswordChar = False
        '
        'txtname
        '
        Me.txtname.Depth = 0
        Me.txtname.Hint = ""
        Me.txtname.Location = New System.Drawing.Point(155, 143)
        Me.txtname.MaxLength = 32767
        Me.txtname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtname.Name = "txtname"
        Me.txtname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtname.SelectedText = ""
        Me.txtname.SelectionLength = 0
        Me.txtname.SelectionStart = 0
        Me.txtname.Size = New System.Drawing.Size(481, 23)
        Me.txtname.TabIndex = 1
        Me.txtname.TabStop = False
        Me.txtname.UseSystemPasswordChar = False
        '
        'txtamount
        '
        Me.txtamount.Depth = 0
        Me.txtamount.Hint = ""
        Me.txtamount.Location = New System.Drawing.Point(436, 102)
        Me.txtamount.MaxLength = 10
        Me.txtamount.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtamount.Name = "txtamount"
        Me.txtamount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtamount.SelectedText = ""
        Me.txtamount.SelectionLength = 0
        Me.txtamount.SelectionStart = 0
        Me.txtamount.Size = New System.Drawing.Size(200, 23)
        Me.txtamount.TabIndex = 2
        Me.txtamount.TabStop = False
        Me.txtamount.UseSystemPasswordChar = False
        '
        'dtdate
        '
        Me.dtdate.Enabled = False
        Me.dtdate.FontWeight = MetroFramework.MetroDateTimeWeight.Light
        Me.dtdate.Location = New System.Drawing.Point(226, 96)
        Me.dtdate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtdate.Name = "dtdate"
        Me.dtdate.Size = New System.Drawing.Size(200, 29)
        Me.dtdate.Style = MetroFramework.MetroColorStyle.Teal
        Me.dtdate.TabIndex = 3
        Me.dtdate.Value = New Date(2018, 3, 20, 0, 0, 0, 0)
        '
        'lblamountinwords
        '
        Me.lblamountinwords.AutoSize = True
        Me.lblamountinwords.Depth = 0
        Me.lblamountinwords.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblamountinwords.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblamountinwords.Location = New System.Drawing.Point(151, 177)
        Me.lblamountinwords.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblamountinwords.Name = "lblamountinwords"
        Me.lblamountinwords.Size = New System.Drawing.Size(123, 19)
        Me.lblamountinwords.TabIndex = 4
        Me.lblamountinwords.Text = "Amount in words"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(12, 74)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(106, 19)
        Me.MaterialLabel2.TabIndex = 6
        Me.MaterialLabel2.Text = "Account name"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(222, 74)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(40, 19)
        Me.MaterialLabel3.TabIndex = 7
        Me.MaterialLabel3.Text = "Date"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(12, 143)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(133, 19)
        Me.MaterialLabel4.TabIndex = 8
        Me.MaterialLabel4.Text = "Pay to the order of"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(432, 74)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(62, 19)
        Me.MaterialLabel5.TabIndex = 9
        Me.MaterialLabel5.Text = "Amount"
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(22, 177)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(123, 19)
        Me.MaterialLabel6.TabIndex = 11
        Me.MaterialLabel6.Text = "Amount in words"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel6.Controls.Add(Me.btnHeaderSave)
        Me.Panel6.Location = New System.Drawing.Point(573, 288)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(93, 38)
        Me.Panel6.TabIndex = 199
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
        Me.btnHeaderSave.Text = "print"
        Me.btnHeaderSave.UseVisualStyleBackColor = False
        '
        'CheckWriter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 355)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.lblamountinwords)
        Me.Controls.Add(Me.dtdate)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtissuer)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CheckWriter"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check No."
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtissuer As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtamount As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents dtdate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents lblamountinwords As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnHeaderSave As MaterialSkin.Controls.MaterialFlatButton
End Class
