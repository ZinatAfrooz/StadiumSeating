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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtClassA = New System.Windows.Forms.TextBox()
        Me.txtClassB = New System.Windows.Forms.TextBox()
        Me.txtClassC = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblClassB = New System.Windows.Forms.Label()
        Me.lblClassC = New System.Windows.Forms.Label()
        Me.lblTotlRevVal = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblClassA = New System.Windows.Forms.Label()
        Me.btnCalRev = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtClassC)
        Me.GroupBox1.Controls.Add(Me.txtClassB)
        Me.GroupBox1.Controls.Add(Me.txtClassA)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 149)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ticket Sold"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Enter the number of tickets sold " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for each class of seat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Class A"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Class B"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Class C"
        '
        'txtClassA
        '
        Me.txtClassA.Location = New System.Drawing.Point(93, 44)
        Me.txtClassA.Name = "txtClassA"
        Me.txtClassA.Size = New System.Drawing.Size(100, 20)
        Me.txtClassA.TabIndex = 4
        '
        'txtClassB
        '
        Me.txtClassB.Location = New System.Drawing.Point(93, 71)
        Me.txtClassB.Name = "txtClassB"
        Me.txtClassB.Size = New System.Drawing.Size(100, 20)
        Me.txtClassB.TabIndex = 5
        '
        'txtClassC
        '
        Me.txtClassC.Location = New System.Drawing.Point(93, 99)
        Me.txtClassC.Name = "txtClassC"
        Me.txtClassC.Size = New System.Drawing.Size(100, 20)
        Me.txtClassC.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblClassA)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblTotlRevVal)
        Me.GroupBox2.Controls.Add(Me.lblClassC)
        Me.GroupBox2.Controls.Add(Me.lblClassB)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(245, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 149)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(245, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Revenue Generated"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Class B"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Class C"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Total Revenue"
        '
        'lblClassB
        '
        Me.lblClassB.AutoSize = True
        Me.lblClassB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassB.Location = New System.Drawing.Point(87, 47)
        Me.lblClassB.Margin = New System.Windows.Forms.Padding(0)
        Me.lblClassB.Name = "lblClassB"
        Me.lblClassB.Padding = New System.Windows.Forms.Padding(3, 2, 100, 2)
        Me.lblClassB.Size = New System.Drawing.Size(105, 19)
        Me.lblClassB.TabIndex = 10
        '
        'lblClassC
        '
        Me.lblClassC.AutoSize = True
        Me.lblClassC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassC.Location = New System.Drawing.Point(87, 78)
        Me.lblClassC.Name = "lblClassC"
        Me.lblClassC.Padding = New System.Windows.Forms.Padding(3, 2, 100, 2)
        Me.lblClassC.Size = New System.Drawing.Size(105, 19)
        Me.lblClassC.TabIndex = 11
        '
        'lblTotlRevVal
        '
        Me.lblTotlRevVal.AutoSize = True
        Me.lblTotlRevVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotlRevVal.Location = New System.Drawing.Point(87, 106)
        Me.lblTotlRevVal.Name = "lblTotlRevVal"
        Me.lblTotlRevVal.Padding = New System.Windows.Forms.Padding(3, 2, 100, 2)
        Me.lblTotlRevVal.Size = New System.Drawing.Size(105, 19)
        Me.lblTotlRevVal.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Class A"
        '
        'lblClassA
        '
        Me.lblClassA.AutoSize = True
        Me.lblClassA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassA.Location = New System.Drawing.Point(87, 16)
        Me.lblClassA.Margin = New System.Windows.Forms.Padding(0)
        Me.lblClassA.Name = "lblClassA"
        Me.lblClassA.Padding = New System.Windows.Forms.Padding(3, 2, 100, 2)
        Me.lblClassA.Size = New System.Drawing.Size(105, 19)
        Me.lblClassA.TabIndex = 14
        '
        'btnCalRev
        '
        Me.btnCalRev.Location = New System.Drawing.Point(13, 203)
        Me.btnCalRev.Name = "btnCalRev"
        Me.btnCalRev.Size = New System.Drawing.Size(106, 23)
        Me.btnCalRev.TabIndex = 4
        Me.btnCalRev.Text = "Calculate Revenue"
        Me.btnCalRev.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(163, 203)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(293, 203)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 261)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalRev)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Stadium Seating"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtClassC As TextBox
    Friend WithEvents txtClassB As TextBox
    Friend WithEvents txtClassA As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblClassA As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTotlRevVal As Label
    Friend WithEvents lblClassC As Label
    Friend WithEvents lblClassB As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCalRev As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
