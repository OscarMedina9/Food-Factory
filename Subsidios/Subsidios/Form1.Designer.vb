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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox1)
        Controls.Add(txtCodigoBarras)
        Name = "Form1"
        Text = "Subsidios"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCodigoBarras As TextBox
    Friend WithEvents TextBox1 As TextBox

End Class
