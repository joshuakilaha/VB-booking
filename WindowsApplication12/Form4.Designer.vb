<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnfinish = New System.Windows.Forms.Button()
        Me.lstDetails = New System.Windows.Forms.ListBox()
        Me.btnback = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Viner Hand ITC", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(521, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "THANK YOU FOR BOOKING WITH US"
        '
        'btnfinish
        '
        Me.btnfinish.Location = New System.Drawing.Point(477, 246)
        Me.btnfinish.Name = "btnfinish"
        Me.btnfinish.Size = New System.Drawing.Size(75, 23)
        Me.btnfinish.TabIndex = 1
        Me.btnfinish.Text = "FINISH"
        Me.btnfinish.UseVisualStyleBackColor = True
        '
        'lstDetails
        '
        Me.lstDetails.FormattingEnabled = True
        Me.lstDetails.Location = New System.Drawing.Point(408, 54)
        Me.lstDetails.Name = "lstDetails"
        Me.lstDetails.Size = New System.Drawing.Size(144, 173)
        Me.lstDetails.TabIndex = 2
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(12, 246)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(75, 23)
        Me.btnback.TabIndex = 4
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(568, 321)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.lstDetails)
        Me.Controls.Add(Me.btnfinish)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnfinish As System.Windows.Forms.Button
    Friend WithEvents lstDetails As System.Windows.Forms.ListBox
    Friend WithEvents btnback As System.Windows.Forms.Button
End Class
