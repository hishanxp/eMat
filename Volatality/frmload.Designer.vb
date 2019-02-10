<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmload
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmload))
        Me.txtfpath = New System.Windows.Forms.TextBox()
        Me.od = New System.Windows.Forms.OpenFileDialog()
        Me.lblhsash = New System.Windows.Forms.Label()
        Me.txthash = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbprofiles = New System.Windows.Forms.ComboBox()
        Me.txtas1 = New System.Windows.Forms.TextBox()
        Me.txtas2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpae = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtimgldt = New System.Windows.Forms.TextBox()
        Me.txtximgdt = New System.Windows.Forms.TextBox()
        Me.txtkuser = New System.Windows.Forms.TextBox()
        Me.txtkcpr = New System.Windows.Forms.TextBox()
        Me.txtsp = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtnop = New System.Windows.Forms.TextBox()
        Me.txtkdbg = New System.Windows.Forms.TextBox()
        Me.txtdtb = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnloadimage = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnbackupimage = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnopen = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtfpath
        '
        Me.txtfpath.Location = New System.Drawing.Point(90, 19)
        Me.txtfpath.Name = "txtfpath"
        Me.txtfpath.Size = New System.Drawing.Size(300, 20)
        Me.txtfpath.TabIndex = 0
        Me.txtfpath.Text = "Open a memory image.."
        '
        'lblhsash
        '
        Me.lblhsash.AutoSize = True
        Me.lblhsash.Location = New System.Drawing.Point(99, 46)
        Me.lblhsash.Name = "lblhsash"
        Me.lblhsash.Size = New System.Drawing.Size(56, 13)
        Me.lblhsash.TabIndex = 2
        Me.lblhsash.Text = "MD5 hash"
        '
        'txthash
        '
        Me.txthash.Location = New System.Drawing.Point(161, 43)
        Me.txthash.Name = "txthash"
        Me.txthash.ReadOnly = True
        Me.txthash.Size = New System.Drawing.Size(229, 20)
        Me.txthash.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Select Profile"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "AS Layer1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(87, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Tag = ""
        Me.Label4.Text = "AS Layer2"
        '
        'cmbprofiles
        '
        Me.cmbprofiles.FormattingEnabled = True
        Me.cmbprofiles.Location = New System.Drawing.Point(149, 25)
        Me.cmbprofiles.Name = "cmbprofiles"
        Me.cmbprofiles.Size = New System.Drawing.Size(294, 21)
        Me.cmbprofiles.TabIndex = 8
        Me.cmbprofiles.Text = "Guess Profile (Auto)"
        '
        'txtas1
        '
        Me.txtas1.Location = New System.Drawing.Point(149, 54)
        Me.txtas1.Name = "txtas1"
        Me.txtas1.ReadOnly = True
        Me.txtas1.Size = New System.Drawing.Size(246, 20)
        Me.txtas1.TabIndex = 9
        '
        'txtas2
        '
        Me.txtas2.Location = New System.Drawing.Point(149, 80)
        Me.txtas2.Name = "txtas2"
        Me.txtas2.ReadOnly = True
        Me.txtas2.Size = New System.Drawing.Size(246, 20)
        Me.txtas2.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Tag = ""
        Me.Label5.Text = "PAE type"
        '
        'txtpae
        '
        Me.txtpae.Location = New System.Drawing.Point(149, 106)
        Me.txtpae.Name = "txtpae"
        Me.txtpae.ReadOnly = True
        Me.txtpae.Size = New System.Drawing.Size(246, 20)
        Me.txtpae.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtimgldt)
        Me.GroupBox1.Controls.Add(Me.txtximgdt)
        Me.GroupBox1.Controls.Add(Me.txtkuser)
        Me.GroupBox1.Controls.Add(Me.txtkcpr)
        Me.GroupBox1.Controls.Add(Me.txtsp)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtnop)
        Me.GroupBox1.Controls.Add(Me.txtkdbg)
        Me.GroupBox1.Controls.Add(Me.txtdtb)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtpae)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtas2)
        Me.GroupBox1.Controls.Add(Me.txtas1)
        Me.GroupBox1.Controls.Add(Me.cmbprofiles)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 359)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "KDBG Search results"
        '
        'txtimgldt
        '
        Me.txtimgldt.Location = New System.Drawing.Point(149, 327)
        Me.txtimgldt.Name = "txtimgldt"
        Me.txtimgldt.ReadOnly = True
        Me.txtimgldt.Size = New System.Drawing.Size(247, 20)
        Me.txtimgldt.TabIndex = 28
        '
        'txtximgdt
        '
        Me.txtximgdt.Location = New System.Drawing.Point(149, 298)
        Me.txtximgdt.Name = "txtximgdt"
        Me.txtximgdt.ReadOnly = True
        Me.txtximgdt.Size = New System.Drawing.Size(246, 20)
        Me.txtximgdt.TabIndex = 27
        '
        'txtkuser
        '
        Me.txtkuser.Location = New System.Drawing.Point(149, 274)
        Me.txtkuser.Name = "txtkuser"
        Me.txtkuser.ReadOnly = True
        Me.txtkuser.Size = New System.Drawing.Size(133, 20)
        Me.txtkuser.TabIndex = 26
        '
        'txtkcpr
        '
        Me.txtkcpr.Location = New System.Drawing.Point(149, 245)
        Me.txtkcpr.Name = "txtkcpr"
        Me.txtkcpr.ReadOnly = True
        Me.txtkcpr.Size = New System.Drawing.Size(134, 20)
        Me.txtkcpr.TabIndex = 25
        '
        'txtsp
        '
        Me.txtsp.Location = New System.Drawing.Point(149, 219)
        Me.txtsp.Name = "txtsp"
        Me.txtsp.ReadOnly = True
        Me.txtsp.Size = New System.Drawing.Size(38, 20)
        Me.txtsp.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 330)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Image local date and time"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(40, 303)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Image date and time"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 279)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(130, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "KUSER_SHARED_DATA"
        '
        'txtnop
        '
        Me.txtnop.Location = New System.Drawing.Point(149, 192)
        Me.txtnop.Name = "txtnop"
        Me.txtnop.ReadOnly = True
        Me.txtnop.Size = New System.Drawing.Size(39, 20)
        Me.txtnop.TabIndex = 20
        '
        'txtkdbg
        '
        Me.txtkdbg.Location = New System.Drawing.Point(149, 162)
        Me.txtkdbg.Name = "txtkdbg"
        Me.txtkdbg.ReadOnly = True
        Me.txtkdbg.Size = New System.Drawing.Size(137, 20)
        Me.txtkdbg.TabIndex = 19
        '
        'txtdtb
        '
        Me.txtdtb.Location = New System.Drawing.Point(149, 132)
        Me.txtdtb.Name = "txtdtb"
        Me.txtdtb.ReadOnly = True
        Me.txtdtb.Size = New System.Drawing.Size(137, 20)
        Me.txtdtb.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = " Number of Processors"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(58, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "KPCR for CPU 0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Image Type (Service Pack)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(106, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "KDBG"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(114, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Tag = ""
        Me.Label6.Text = "DTB"
        '
        'btnloadimage
        '
        Me.btnloadimage.Enabled = False
        Me.btnloadimage.Location = New System.Drawing.Point(10, 23)
        Me.btnloadimage.Name = "btnloadimage"
        Me.btnloadimage.Size = New System.Drawing.Size(124, 23)
        Me.btnloadimage.TabIndex = 14
        Me.btnloadimage.Text = "Load image"
        Me.btnloadimage.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btncancel)
        Me.GroupBox2.Controls.Add(Me.btnbackupimage)
        Me.GroupBox2.Controls.Add(Me.btnloadimage)
        Me.GroupBox2.Location = New System.Drawing.Point(466, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(143, 126)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Image options"
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(10, 85)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(124, 23)
        Me.btncancel.TabIndex = 16
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnbackupimage
        '
        Me.btnbackupimage.Enabled = False
        Me.btnbackupimage.Location = New System.Drawing.Point(10, 54)
        Me.btnbackupimage.Name = "btnbackupimage"
        Me.btnbackupimage.Size = New System.Drawing.Size(124, 23)
        Me.btnbackupimage.TabIndex = 15
        Me.btnbackupimage.Text = "Backup Image"
        Me.btnbackupimage.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(111, -3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(518, 34)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Label14"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.txthash)
        Me.GroupBox3.Controls.Add(Me.lblhsash)
        Me.GroupBox3.Controls.Add(Me.txtfpath)
        Me.GroupBox3.Controls.Add(Me.btnopen)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 37)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(597, 79)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Open image"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Volatality.My.Resources.Resources.loading
        Me.PictureBox2.Location = New System.Drawing.Point(518, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 60)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'btnopen
        '
        Me.btnopen.AutoEllipsis = True
        Me.btnopen.Image = Global.Volatality.My.Resources.Resources.Files_New_File_icon
        Me.btnopen.Location = New System.Drawing.Point(7, 14)
        Me.btnopen.Name = "btnopen"
        Me.btnopen.Size = New System.Drawing.Size(66, 63)
        Me.btnopen.TabIndex = 0
        Me.btnopen.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'frmload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 488)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "2222222qqqqqqqqqqqqqqqq"
        Me.Text = "eMAT :Load Image"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnopen As System.Windows.Forms.Button
    Friend WithEvents txtfpath As System.Windows.Forms.TextBox
    Friend WithEvents od As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblhsash As System.Windows.Forms.Label
    Friend WithEvents txthash As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbprofiles As System.Windows.Forms.ComboBox
    Friend WithEvents txtas1 As System.Windows.Forms.TextBox
    Friend WithEvents txtas2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtpae As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtimgldt As System.Windows.Forms.TextBox
    Friend WithEvents txtximgdt As System.Windows.Forms.TextBox
    Friend WithEvents txtkuser As System.Windows.Forms.TextBox
    Friend WithEvents txtkcpr As System.Windows.Forms.TextBox
    Friend WithEvents txtsp As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtnop As System.Windows.Forms.TextBox
    Friend WithEvents txtkdbg As System.Windows.Forms.TextBox
    Friend WithEvents txtdtb As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnloadimage As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnbackupimage As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
