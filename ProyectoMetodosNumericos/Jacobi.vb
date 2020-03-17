Public Class Jacobi
    Dim i As Integer
    Dim X(50) As Single
    Dim y(50) As Single
    Dim z(50) As Single
    Dim ex(50) As Single
    Dim ey(50) As Single
    Dim ez(50) As Single
    Dim ec As Single
    Dim redon As Integer
    Dim c As Integer
    Dim a(5, 5) As Single
    Dim b(5) As Single
    Dim j As Integer

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        c = tc.Text
        ec = 0.5 * 10 ^ (-c)
        redon = c + 2
        For i = 1 To 3
            For j = 1 To 3
                a(i, j) = InputBox("a(" & i & "," & j & ")=")
            Next
            b(i) = InputBox("b(" & i & ")=")
        Next
        i = 0
        ex(i) = 1
        ey(i) = 1
        ez(i) = 1
        Do While ex(i) > ec Or ey(i) > ec Or ez(i) > ec
            i = i + 1
            X(i) = (b(1) - a(1, 2) * y(i - 1) - a(1, 3) * z(i - 1)) / a(1, 1)
            y(i) = (b(2) - a(2, 1) * y(i - 1) - a(2, 3) * z(i - 1)) / a(2, 2)
            z(i) = (b(3) - a(3, 1) * y(i - 1) - a(3, 2) * z(i - 1)) / a(3, 3)
            ex(i) = Math.Abs((X(i) - X(i - 1)) / X(i))
            ey(i) = Math.Abs((y(i) - y(i - 1)) / y(i))
            ez(i) = Math.Abs((z(i) - z(i - 1)) / z(i))
            Salida.Rows.Add(i, Math.Round(X(i), redon), Math.Round(y(i), redon), Math.Round(z(i), redon), Math.Round(ex(i), redon), Math.Round(ey(i), redon), Math.Round(ez(i), redon))
        Loop
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
        ProyectoMetodosNumericos.Inicio.Show()
    End Sub
End Class