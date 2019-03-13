<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button_Scan = New System.Windows.Forms.Button()
        Me.Button_Generate = New System.Windows.Forms.Button()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Button_Load = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(378, 261)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button_Scan
        '
        Me.Button_Scan.Location = New System.Drawing.Point(12, 306)
        Me.Button_Scan.Name = "Button_Scan"
        Me.Button_Scan.Size = New System.Drawing.Size(75, 23)
        Me.Button_Scan.TabIndex = 1
        Me.Button_Scan.Text = "Scan"
        Me.Button_Scan.UseVisualStyleBackColor = True
        '
        'Button_Generate
        '
        Me.Button_Generate.Location = New System.Drawing.Point(107, 306)
        Me.Button_Generate.Name = "Button_Generate"
        Me.Button_Generate.Size = New System.Drawing.Size(75, 23)
        Me.Button_Generate.TabIndex = 2
        Me.Button_Generate.Text = "Generate"
        Me.Button_Generate.UseVisualStyleBackColor = True
        '
        'Button_Save
        '
        Me.Button_Save.Location = New System.Drawing.Point(211, 306)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(75, 23)
        Me.Button_Save.TabIndex = 3
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Button_Load
        '
        Me.Button_Load.Location = New System.Drawing.Point(315, 306)
        Me.Button_Load.Name = "Button_Load"
        Me.Button_Load.Size = New System.Drawing.Size(75, 23)
        Me.Button_Load.TabIndex = 4
        Me.Button_Load.Text = "Load"
        Me.Button_Load.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 280)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(378, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 337)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button_Load)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.Button_Generate)
        Me.Controls.Add(Me.Button_Scan)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button_Scan As Button
    Friend WithEvents Button_Generate As Button
    Friend WithEvents Button_Save As Button
    Friend WithEvents Button_Load As Button
    Friend WithEvents TextBox1 As TextBox
End Class
