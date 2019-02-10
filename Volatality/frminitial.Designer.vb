<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminitial
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(245, 345)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(271, 33)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Create New Investigation"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(245, 380)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(271, 37)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Open Exisiting investigation"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Image = Global.Volatality.My.Resources.Resources.smalllogo
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(766, 130)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.Volatality.My.Resources.Resources.investigator
        Me.Button3.Location = New System.Drawing.Point(245, 118)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(271, 221)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.Volatality.My.Resources.Resources.reporter
        Me.Button2.Location = New System.Drawing.Point(543, 118)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(205, 299)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.Volatality.My.Resources.Resources.explorer
        Me.Button1.Location = New System.Drawing.Point(12, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(205, 299)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Image = Global.Volatality.My.Resources.Resources.shutdown__1_
        Me.CloseButton.Location = New System.Drawing.Point(656, 8)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(95, 84)
        Me.CloseButton.TabIndex = 6
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'frminitial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 434)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frminitial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chose operation mode"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CloseButton As System.Windows.Forms.Button
End Class
