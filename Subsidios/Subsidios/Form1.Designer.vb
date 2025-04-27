<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtCodigoBarras = New TextBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        SuspendLayout()
        ' 
        ' txtCodigoBarras
        ' 
        txtCodigoBarras.Location = New Point(432, 122)
        txtCodigoBarras.Name = "txtCodigoBarras"
        txtCodigoBarras.Size = New Size(231, 27)
        txtCodigoBarras.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(432, 182)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(231, 27)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(285, 212)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(231, 27)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(293, 220)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(231, 27)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(301, 228)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(231, 27)
        TextBox4.TabIndex = 4
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(309, 236)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(231, 27)
        TextBox5.TabIndex = 5
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(317, 244)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(231, 27)
        TextBox6.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(txtCodigoBarras)
        Name = "Form1"
        Text = "Subsidios"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCodigoBarras As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox

End Class
