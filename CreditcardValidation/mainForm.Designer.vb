<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.lb = New System.Windows.Forms.ListBox()
        Me.validate = New System.Windows.Forms.Button()
        Me.cardNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ll = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'lb
        '
        Me.lb.FormattingEnabled = true
        Me.lb.Items.AddRange(New Object() {"    377781397235946", "    376964394805306", "    378256475312072", "    348976280559321", "    347781813241764", "    6011837172070723", "    6011827204212344", "    6011160357778568", "    6011894351095393", "    6011057589027097", "    5383642282364145", "    5162400199206280", "    5135441177287615", "    5201591067734214", "    5215482782658074", "    4539318497740991", "    4716162760417639", "    4916812887065319", "    4716585656871172", "    4916672956172655"})
        Me.lb.Location = New System.Drawing.Point(14, 68)
        Me.lb.MultiColumn = true
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(383, 108)
        Me.lb.TabIndex = 0
        '
        'validate
        '
        Me.validate.Location = New System.Drawing.Point(232, 21)
        Me.validate.Name = "validate"
        Me.validate.Size = New System.Drawing.Size(150, 23)
        Me.validate.TabIndex = 1
        Me.validate.Text = "Validate Card Number"
        Me.validate.UseVisualStyleBackColor = true
        '
        'cardNumber
        '
        Me.cardNumber.Location = New System.Drawing.Point(104, 23)
        Me.cardNumber.Name = "cardNumber"
        Me.cardNumber.Size = New System.Drawing.Size(122, 20)
        Me.cardNumber.TabIndex = 2
        Me.cardNumber.Text = "4222781215330738"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(28, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Card Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Test numbers from"
        '
        'll
        '
        Me.ll.ActiveLinkColor = System.Drawing.Color.Blue
        Me.ll.AutoSize = true
        Me.ll.Location = New System.Drawing.Point(101, 52)
        Me.ll.Name = "ll"
        Me.ll.Size = New System.Drawing.Size(159, 13)
        Me.ll.TabIndex = 5
        Me.ll.TabStop = true
        Me.ll.Text = "www.getcreditcardnumbers.com"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(411, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.AboutToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A),System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.AboutToolStripMenuItem1.Text = "&About ..."
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 193)
        Me.Controls.Add(Me.ll)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cardNumber)
        Me.Controls.Add(Me.validate)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = false
        Me.Name = "mainForm"
        Me.Text = "Credit Card Validator"
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lb As System.Windows.Forms.ListBox
    Friend WithEvents validate As System.Windows.Forms.Button
    Friend WithEvents cardNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ll As System.Windows.Forms.LinkLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
