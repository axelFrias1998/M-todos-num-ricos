Imports info.lundin.math

Public Class FReglaFalsa
    Dim a As Single
    Dim b As Single
    Dim c As Integer
    Dim x(50) As Single
    Dim err(50) As Single
    Dim ec As Single
    Dim i As Integer
    Dim redon As Integer

    Function f(x As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        Return parser.Parse(tf.Text)
    End Function

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
        ProyectoMetodosNumericos.Inicio.Show()
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        a = ta.Text
        b = tb.Text
        c = tc.Text
        ec = 0.5 * 10 ^ (-c)
        redon = c + 2
        x(i) = ((a * f(b)) - (b * f(a))) / (f(b) - f(a))
        err(i) = 1
        'Regla Falsa
        Salida.Rows.Add(i, Math.Round(a, redon), Math.Round(x(i), redon), Math.Round(b, redon), Math.Round(f(a), redon), Math.Round(f(x(i)), redon), Math.Round(f(b), redon), Math.Round(err(i), redon))

        Do While err(i) > ec
            If f(a) * f(x(i)) > 0 Then
                a = x(i)
            Else
                b = x(i)
            End If
            '
            i = i + 1
            x(i) = ((a * f(b)) - (b * f(a))) / (f(b) - f(a))
            err(i) = Math.Abs((x(i) - x(i - 1)) / x(i))
            Salida.Rows.Add(i, Math.Round(a, redon), Math.Round(x(i), redon), Math.Round(b, redon), Math.Round(f(a), redon), Math.Round(f(x(i)), redon), Math.Round(f(b), redon), Math.Round(err(i), redon))
        Loop
    End Sub
End Class
