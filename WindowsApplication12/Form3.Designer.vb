<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.ComboBox2Airline = New System.Windows.Forms.ComboBox()
        Me.lblAirline = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstComputing = New System.Windows.Forms.ListBox()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.lblPassengers = New System.Windows.Forms.Label()
        Me.txtpassengers = New System.Windows.Forms.TextBox()
        Me.txtcost = New System.Windows.Forms.TextBox()
        Me.lblcost = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox2Airline
        '
        Me.ComboBox2Airline.FormattingEnabled = True
        Me.ComboBox2Airline.Items.AddRange(New Object() {"Kenya Airways", "FLY 540", "Skieline"})
        Me.ComboBox2Airline.Location = New System.Drawing.Point(158, 128)
        Me.ComboBox2Airline.Name = "ComboBox2Airline"
        Me.ComboBox2Airline.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2Airline.TabIndex = 4
        '
        'lblAirline
        '
        Me.lblAirline.AutoSize = True
        Me.lblAirline.Location = New System.Drawing.Point(24, 131)
        Me.lblAirline.Name = "lblAirline"
        Me.lblAirline.Size = New System.Drawing.Size(35, 13)
        Me.lblAirline.TabIndex = 3
        Me.lblAirline.Text = "Airline"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Continue "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstComputing
        '
        Me.lstComputing.FormattingEnabled = True
        Me.lstComputing.Location = New System.Drawing.Point(373, 40)
        Me.lstComputing.Name = "lstComputing"
        Me.lstComputing.Size = New System.Drawing.Size(155, 199)
        Me.lstComputing.TabIndex = 6
        '
        'btnProceed
        '
        Me.btnProceed.Location = New System.Drawing.Point(424, 296)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(75, 23)
        Me.btnProceed.TabIndex = 7
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(12, 296)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 8
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'lblPassengers
        '
        Me.lblPassengers.AutoSize = True
        Me.lblPassengers.Location = New System.Drawing.Point(12, 77)
        Me.lblPassengers.Name = "lblPassengers"
        Me.lblPassengers.Size = New System.Drawing.Size(114, 13)
        Me.lblPassengers.TabIndex = 1
        Me.lblPassengers.Text = "Number of Passangers"
        '
        'txtpassengers
        '
        Me.txtpassengers.Location = New System.Drawing.Point(179, 77)
        Me.txtpassengers.Name = "txtpassengers"
        Me.txtpassengers.Size = New System.Drawing.Size(100, 20)
        Me.txtpassengers.TabIndex = 9
        '
        'txtcost
        '
        Me.txtcost.Location = New System.Drawing.Point(373, 245)
        Me.txtcost.Name = "txtcost"
        Me.txtcost.Size = New System.Drawing.Size(144, 20)
        Me.txtcost.TabIndex = 11
        '
        'lblcost
        '
        Me.lblcost.AutoSize = True
        Me.lblcost.Location = New System.Drawing.Point(302, 248)
        Me.lblcost.Name = "lblcost"
        Me.lblcost.Size = New System.Drawing.Size(55, 13)
        Me.lblcost.TabIndex = 10
        Me.lblcost.Text = "Total Cost"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(442, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Log out"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(292, 100)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(292, 146)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 14
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(529, 331)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtcost)
        Me.Controls.Add(Me.lblcost)
        Me.Controls.Add(Me.txtpassengers)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.lstComputing)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox2Airline)
        Me.Controls.Add(Me.lblAirline)
        Me.Controls.Add(Me.lblPassengers)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox2Airline As System.Windows.Forms.ComboBox
    Friend WithEvents lblAirline As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lstComputing As System.Windows.Forms.ListBox
    Friend WithEvents btnProceed As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents lblPassengers As System.Windows.Forms.Label
    Friend WithEvents txtpassengers As System.Windows.Forms.TextBox
    Friend WithEvents txtcost As System.Windows.Forms.TextBox
    Friend WithEvents lblcost As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
End Class
