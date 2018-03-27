<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forpassword
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
        Me.txtpassword = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'txtpassword
        '
        Me.txtpassword.Depth = 0
        Me.txtpassword.Hint = ""
        Me.txtpassword.Location = New System.Drawing.Point(13, 13)
        Me.txtpassword.MaxLength = 32767
        Me.txtpassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.SelectedText = ""
        Me.txtpassword.SelectionLength = 0
        Me.txtpassword.SelectionStart = 0
        Me.txtpassword.Size = New System.Drawing.Size(267, 23)
        Me.txtpassword.TabIndex = 0
        Me.txtpassword.TabStop = False
        Me.txtpassword.UseSystemPasswordChar = False
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.AutoSize = True
        Me.MaterialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Icon = Nothing
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(13, 43)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(98, 36)
        Me.MaterialRaisedButton1.TabIndex = 1
        Me.MaterialRaisedButton1.Text = "Grant Edit"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'forpassword
        '
        Me.AcceptButton = Me.MaterialRaisedButton1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 190)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.txtpassword)
        Me.Name = "forpassword"
        Me.Text = "Re-enter Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpassword As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
End Class
