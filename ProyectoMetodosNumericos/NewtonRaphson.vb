Imports info.lundin.math

Public Class Fraiz
    Dim i As Integer
    Dim c As Integer
    Dim x(50) As Single
    Dim ec As Single
    Dim err(50) As Single
    Dim redon As Integer

    Function f(x As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        Return parser.Parse(tf.Text)
    End Function
    Function fd(x As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        Return parser.Parse(td.Text)
    End Function
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
        ProyectoMetodosNumericos.Inicio.Show()
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        x(i) = Ti.Text
        c = Tc.Text
        ec = 0.5 * 10 ^ (-c)
        err(i) = 1
        redon = c + 2
        Salida.Rows.Add(i, Math.Round(x(i), redon), "------------")
        Do While err(i) > ec
            i = i + 1
            x(i) = x(i - 1) - (f(x(i - 1)) / fd(x(i - 1)))
            err(i) = Math.Abs((x(i) - x(i - 1)) / x(i))
            Salida.Rows.Add(i, Math.Round(x(i), redon), Math.Round(err(i), redon))
        Loop
        tr.Text = Math.Round(x(i), redon)
    End Sub
End Class
