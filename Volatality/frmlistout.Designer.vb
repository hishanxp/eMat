<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlistout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlistout))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtvcommand = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.context = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DlllistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HandlesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MalfindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemmapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DumpExeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VadwalkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VadinfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VadtreeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemdumpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcdumpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VaddumpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.context.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HotTracking = True
        Me.ListView1.HoverSelection = True
        Me.ListView1.LabelEdit = True
        Me.ListView1.LabelWrap = False
        Me.ListView1.Location = New System.Drawing.Point(-5, 57)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(838, 383)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(106, -4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(739, 34)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Label14"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Output"
        '
        'txtvcommand
        '
        Me.txtvcommand.Location = New System.Drawing.Point(117, 33)
        Me.txtvcommand.Name = "txtvcommand"
        Me.txtvcommand.ReadOnly = True
        Me.txtvcommand.Size = New System.Drawing.Size(461, 20)
        Me.txtvcommand.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(750, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 24)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Export"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Text", "CSV"})
        Me.ComboBox1.Location = New System.Drawing.Point(669, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(78, 21)
        Me.ComboBox1.TabIndex = 23
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(832, 24)
        Me.MenuStrip1.TabIndex = 24
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'context
        '
        Me.context.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DlllistToolStripMenuItem, Me.HandlesToolStripMenuItem, Me.MalfindToolStripMenuItem, Me.MemmapToolStripMenuItem, Me.DumpExeToolStripMenuItem, Me.VadinfoToolStripMenuItem, Me.VadwalkToolStripMenuItem, Me.VadtreeToolStripMenuItem})
        Me.context.Name = "ContextMenuStrip1"
        Me.context.Size = New System.Drawing.Size(153, 202)
        '
        'DlllistToolStripMenuItem
        '
        Me.DlllistToolStripMenuItem.Name = "DlllistToolStripMenuItem"
        Me.DlllistToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.DlllistToolStripMenuItem.Text = "dlllist"
        '
        'HandlesToolStripMenuItem
        '
        Me.HandlesToolStripMenuItem.Name = "HandlesToolStripMenuItem"
        Me.HandlesToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.HandlesToolStripMenuItem.Text = "handles"
        '
        'MalfindToolStripMenuItem
        '
        Me.MalfindToolStripMenuItem.Name = "MalfindToolStripMenuItem"
        Me.MalfindToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.MalfindToolStripMenuItem.Text = "malfind"
        '
        'MemmapToolStripMenuItem
        '
        Me.MemmapToolStripMenuItem.Name = "MemmapToolStripMenuItem"
        Me.MemmapToolStripMenuItem.ShowShortcutKeys = False
        Me.MemmapToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.MemmapToolStripMenuItem.Text = "memmap"
        '
        'DumpExeToolStripMenuItem
        '
        Me.DumpExeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MemdumpToolStripMenuItem, Me.ProcdumpToolStripMenuItem, Me.VaddumpToolStripMenuItem})
        Me.DumpExeToolStripMenuItem.Name = "DumpExeToolStripMenuItem"
        Me.DumpExeToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.DumpExeToolStripMenuItem.Text = "dumps"
        '
        'VadwalkToolStripMenuItem
        '
        Me.VadwalkToolStripMenuItem.Name = "VadwalkToolStripMenuItem"
        Me.VadwalkToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.VadwalkToolStripMenuItem.Text = "vadwalk"
        '
        'VadinfoToolStripMenuItem
        '
        Me.VadinfoToolStripMenuItem.Name = "VadinfoToolStripMenuItem"
        Me.VadinfoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VadinfoToolStripMenuItem.Text = "vadinfo"
        '
        'VadtreeToolStripMenuItem
        '
        Me.VadtreeToolStripMenuItem.Name = "VadtreeToolStripMenuItem"
        Me.VadtreeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VadtreeToolStripMenuItem.Text = "vadtree"
        '
        'MemdumpToolStripMenuItem
        '
        Me.MemdumpToolStripMenuItem.Name = "MemdumpToolStripMenuItem"
        Me.MemdumpToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MemdumpToolStripMenuItem.Text = "memdump"
        '
        'ProcdumpToolStripMenuItem
        '
        Me.ProcdumpToolStripMenuItem.Name = "ProcdumpToolStripMenuItem"
        Me.ProcdumpToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProcdumpToolStripMenuItem.Text = "procdump"
        '
        'VaddumpToolStripMenuItem
        '
        Me.VaddumpToolStripMenuItem.Name = "VaddumpToolStripMenuItem"
        Me.VaddumpToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VaddumpToolStripMenuItem.Text = "vaddump"
        '
        'frmlistout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 440)
        Me.ContextMenuStrip = Me.context
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtvcommand)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmlistout"
        Me.Text = "Plugin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.context.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtvcommand As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents context As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MemmapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DumpExeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MalfindToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DlllistToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HandlesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VadwalkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VadinfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VadtreeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemdumpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcdumpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VaddumpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
