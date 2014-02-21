<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aboutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aboutForm))
        Me.myName = New System.Windows.Forms.Label()
        Me.ll = New System.Windows.Forms.LinkLabel()
        Me.backGround = New System.Windows.Forms.PictureBox()
        CType(Me.backGround,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'myName
        '
        Me.myName.AutoSize = true
        Me.myName.BackColor = System.Drawing.Color.White
        Me.myName.ForeColor = System.Drawing.Color.White
        Me.myName.Location = New System.Drawing.Point(47, 29)
        Me.myName.Name = "myName"
        Me.myName.Size = New System.Drawing.Size(128, 13)
        Me.myName.TabIndex = 1
        Me.myName.Text = "Written by Dr. Peet Morris"
        '
        'll
        '
        Me.ll.ActiveLinkColor = System.Drawing.Color.White
        Me.ll.AutoSize = true
        Me.ll.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.ll.LinkColor = System.Drawing.Color.White
        Me.ll.Location = New System.Drawing.Point(83, 62)
        Me.ll.Name = "ll"
        Me.ll.Size = New System.Drawing.Size(124, 13)
        Me.ll.TabIndex = 2
        Me.ll.TabStop = true
        Me.ll.Text = "peet.morris@cs.ox.ac.uk"
        Me.ll.VisitedLinkColor = System.Drawing.Color.White
        '
        'backGround
        '
        Me.backGround.Image = Global.CreditcardValidation.My.Resources.Resources.abBkground
        Me.backGround.Location = New System.Drawing.Point(0, 0)
        Me.backGround.Name = "backGround"
        Me.backGround.Size = New System.Drawing.Size(292, 139)
        Me.backGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.backGround.TabIndex = 3
        Me.backGround.TabStop = false
        '
        'aboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 137)
        Me.Controls.Add(Me.ll)
        Me.Controls.Add(Me.myName)
        Me.Controls.Add(Me.backGround)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "aboutForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        CType(Me.backGround,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents myName As System.Windows.Forms.Label
    Friend WithEvents ll As System.Windows.Forms.LinkLabel
    Friend WithEvents backGround As System.Windows.Forms.PictureBox
End Class
