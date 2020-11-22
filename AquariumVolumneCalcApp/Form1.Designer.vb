<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LBWidth = New System.Windows.Forms.Label()
        Me.LBHeight = New System.Windows.Forms.Label()
        Me.LBDepth = New System.Windows.Forms.Label()
        Me.LBVolumne = New System.Windows.Forms.Label()
        Me.BTNCalcVolumne = New System.Windows.Forms.Button()
        Me.TBWidth = New System.Windows.Forms.TextBox()
        Me.TBDepth = New System.Windows.Forms.TextBox()
        Me.TBHeight = New System.Windows.Forms.TextBox()
        Me.TBVolumne = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LBWidth
        '
        Me.LBWidth.AutoSize = True
        Me.LBWidth.ForeColor = System.Drawing.Color.Crimson
        Me.LBWidth.Location = New System.Drawing.Point(42, 39)
        Me.LBWidth.Name = "LBWidth"
        Me.LBWidth.Size = New System.Drawing.Size(75, 15)
        Me.LBWidth.TabIndex = 0
        Me.LBWidth.Text = "Width (cm): "
        '
        'LBHeight
        '
        Me.LBHeight.AutoSize = True
        Me.LBHeight.Location = New System.Drawing.Point(42, 89)
        Me.LBHeight.Name = "LBHeight"
        Me.LBHeight.Size = New System.Drawing.Size(76, 15)
        Me.LBHeight.TabIndex = 1
        Me.LBHeight.Text = "Height (cm):"
        '
        'LBDepth
        '
        Me.LBDepth.AutoSize = True
        Me.LBDepth.Location = New System.Drawing.Point(42, 144)
        Me.LBDepth.Name = "LBDepth"
        Me.LBDepth.Size = New System.Drawing.Size(73, 15)
        Me.LBDepth.TabIndex = 2
        Me.LBDepth.Text = "Depth (cm):"
        '
        'LBVolumne
        '
        Me.LBVolumne.AutoSize = True
        Me.LBVolumne.Location = New System.Drawing.Point(42, 194)
        Me.LBVolumne.Name = "LBVolumne"
        Me.LBVolumne.Size = New System.Drawing.Size(101, 15)
        Me.LBVolumne.TabIndex = 3
        Me.LBVolumne.Text = "Volumne (litres): "
        '
        'BTNCalcVolumne
        '
        Me.BTNCalcVolumne.Location = New System.Drawing.Point(133, 249)
        Me.BTNCalcVolumne.Name = "BTNCalcVolumne"
        Me.BTNCalcVolumne.Size = New System.Drawing.Size(75, 23)
        Me.BTNCalcVolumne.TabIndex = 4
        Me.BTNCalcVolumne.Text = "="
        Me.BTNCalcVolumne.UseVisualStyleBackColor = True
        '
        'TBWidth
        '
        Me.TBWidth.BackColor = System.Drawing.SystemColors.Control
        Me.TBWidth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TBWidth.Location = New System.Drawing.Point(190, 36)
        Me.TBWidth.Name = "TBWidth"
        Me.TBWidth.Size = New System.Drawing.Size(100, 23)
        Me.TBWidth.TabIndex = 0
        '
        'TBDepth
        '
        Me.TBDepth.BackColor = System.Drawing.SystemColors.Control
        Me.TBDepth.Location = New System.Drawing.Point(190, 141)
        Me.TBDepth.Name = "TBDepth"
        Me.TBDepth.Size = New System.Drawing.Size(100, 23)
        Me.TBDepth.TabIndex = 2
        '
        'TBHeight
        '
        Me.TBHeight.BackColor = System.Drawing.SystemColors.Control
        Me.TBHeight.Location = New System.Drawing.Point(190, 86)
        Me.TBHeight.Name = "TBHeight"
        Me.TBHeight.Size = New System.Drawing.Size(100, 23)
        Me.TBHeight.TabIndex = 1
        '
        'TBVolumne
        '
        Me.TBVolumne.BackColor = System.Drawing.SystemColors.Control
        Me.TBVolumne.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TBVolumne.Location = New System.Drawing.Point(190, 191)
        Me.TBVolumne.Name = "TBVolumne"
        Me.TBVolumne.Size = New System.Drawing.Size(100, 23)
        Me.TBVolumne.TabIndex = 3
        Me.TBVolumne.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(334, 311)
        Me.Controls.Add(Me.TBVolumne)
        Me.Controls.Add(Me.TBHeight)
        Me.Controls.Add(Me.TBDepth)
        Me.Controls.Add(Me.BTNCalcVolumne)
        Me.Controls.Add(Me.LBVolumne)
        Me.Controls.Add(Me.LBDepth)
        Me.Controls.Add(Me.LBHeight)
        Me.Controls.Add(Me.LBWidth)
        Me.Controls.Add(Me.TBWidth)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.Crimson
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aquarium Volumne Calculator"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBWidth As Label
    Friend WithEvents LBHeight As Label
    Friend WithEvents LBDepth As Label
    Friend WithEvents LBVolumne As Label
    Friend WithEvents BTNCalcVolumne As Button
    Friend WithEvents TBWidth As TextBox
    Friend WithEvents TBDepth As TextBox
    Friend WithEvents TBHeight As TextBox
    Friend WithEvents TBVolumne As TextBox
End Class
