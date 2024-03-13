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
        btnExit = New Button()
        lblEarth = New Label()
        Label1 = New Label()
        txtEarth = New TextBox()
        hscrollbar = New HScrollBar()
        btnGuide = New Button()
        txtMoon = New TextBox()
        btnClear = New Button()
        SuspendLayout()
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        btnExit.Font = New Font("Franklin Gothic Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(804, 12)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(112, 59)
        btnExit.TabIndex = 0
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' lblEarth
        ' 
        lblEarth.AutoSize = True
        lblEarth.Font = New Font("Franklin Gothic Medium", 16F, FontStyle.Bold)
        lblEarth.Location = New Point(171, 127)
        lblEarth.Name = "lblEarth"
        lblEarth.Size = New Size(206, 37)
        lblEarth.TabIndex = 1
        lblEarth.Text = "Earth Weight"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Franklin Gothic Medium", 16F, FontStyle.Bold)
        Label1.Location = New Point(501, 127)
        Label1.Name = "Label1"
        Label1.Size = New Size(210, 37)
        Label1.TabIndex = 2
        Label1.Text = "Moon Weight"
        ' 
        ' txtEarth
        ' 
        txtEarth.Font = New Font("Franklin Gothic Medium", 16F, FontStyle.Bold)
        txtEarth.Location = New Point(156, 182)
        txtEarth.Multiline = True
        txtEarth.Name = "txtEarth"
        txtEarth.Size = New Size(239, 75)
        txtEarth.TabIndex = 3
        ' 
        ' hscrollbar
        ' 
        hscrollbar.LargeChange = 5
        hscrollbar.Location = New Point(25, 330)
        hscrollbar.Maximum = 204
        hscrollbar.Name = "hscrollbar"
        hscrollbar.Size = New Size(875, 39)
        hscrollbar.TabIndex = 4
        ' 
        ' btnGuide
        ' 
        btnGuide.BackColor = Color.Yellow
        btnGuide.Font = New Font("Franklin Gothic Medium", 16F, FontStyle.Bold)
        btnGuide.Location = New Point(587, 12)
        btnGuide.Name = "btnGuide"
        btnGuide.Size = New Size(211, 59)
        btnGuide.TabIndex = 5
        btnGuide.Text = "User Guide"
        btnGuide.UseVisualStyleBackColor = False
        ' 
        ' txtMoon
        ' 
        txtMoon.Font = New Font("Franklin Gothic Medium", 16F, FontStyle.Bold)
        txtMoon.Location = New Point(491, 182)
        txtMoon.Multiline = True
        txtMoon.Name = "txtMoon"
        txtMoon.Size = New Size(239, 75)
        txtMoon.TabIndex = 6
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnClear.Font = New Font("Franklin Gothic Medium", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(469, 12)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 59)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        ClientSize = New Size(928, 455)
        Controls.Add(btnClear)
        Controls.Add(txtMoon)
        Controls.Add(btnGuide)
        Controls.Add(hscrollbar)
        Controls.Add(txtEarth)
        Controls.Add(Label1)
        Controls.Add(lblEarth)
        Controls.Add(btnExit)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents lblEarth As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEarth As TextBox
    Friend WithEvents hscrollbar As HScrollBar
    Friend WithEvents btnGuide As Button
    Friend WithEvents txtMoon As TextBox
    Friend WithEvents btnClear As Button

End Class
