Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtCodigoBarras_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoBarras.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Leer el código de barras y buscar el producto en la base de datos
            Dim codigoBarras As String = txtCodigoBarras.Text
            ' Llamar a la función para buscar el producto BuscarProducto(codigoBarras)
        End If
    End Sub
End Class
