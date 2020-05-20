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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(162, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 43)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Calculate MPG"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(257, 241)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 43)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(352, 241)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 43)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(159, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Gallons of gas the car hold:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(159, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 39)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Number of miles it can be driven on a full tank."
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(159, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Miles per gallon:"
        '
        'txtGallons
        '
        Me.txtGallons.Location = New System.Drawing.Point(301, 83)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(86, 20)
        Me.txtGallons.TabIndex = 6
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(301, 125)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(112, 20)
        Me.txtMiles.TabIndex = 7
        '
        'lblResults
        '
        Me.lblResults.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResults.Location = New System.Drawing.Point(257, 167)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(170, 23)
        Me.lblResults.TabIndex = 8
        Me.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.txtGallons)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGallons As TextBox
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents lblResults As Label
End Class
