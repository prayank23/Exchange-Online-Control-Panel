<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ecp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ecp))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Recipients"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(12, 41)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(84, 23)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Permissions"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(12, 70)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(84, 23)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "Compliance"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(12, 99)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(84, 23)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "Sharing"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(12, 128)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(84, 23)
        Me.Button10.TabIndex = 10
        Me.Button10.Text = "Protection"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(12, 157)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(84, 23)
        Me.Button11.TabIndex = 11
        Me.Button11.Text = "Mail Flow"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(12, 186)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(84, 23)
        Me.Button12.TabIndex = 12
        Me.Button12.Text = "Mobile"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(12, 215)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(84, 23)
        Me.Button13.TabIndex = 13
        Me.Button13.Text = "Public Folders"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(12, 244)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(84, 23)
        Me.Button14.TabIndex = 14
        Me.Button14.Text = "Unified Msg"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(12, 302)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(84, 23)
        Me.Button15.TabIndex = 15
        Me.Button15.Text = "Tools"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 273)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Migration"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ecp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 328)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "ecp"
        Me.Text = "Office365/ecp"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
