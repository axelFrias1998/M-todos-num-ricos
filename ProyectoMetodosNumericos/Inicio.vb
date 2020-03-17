Imports ProyectoMetodosNumericos.Fraiz
Imports ProyectoMetodosNumericos.Fimpares
Imports ProyectoMetodosNumericos.FBiseccion
Imports ProyectoMetodosNumericos.FReglaFalsa
Imports ProyectoMetodosNumericos.Jacobi
Imports ProyectoMetodosNumericos.Raizdedos
Public Class Inicio
    Private Sub RaízDeDosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RaízDeDosToolStripMenuItem.Click
        Me.Hide()
        Raizdedos.Show()
    End Sub

    Private Sub ImparesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImparesToolStripMenuItem.Click
        Me.Hide()
        Fimpares.Show()
    End Sub

    Private Sub BisecciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BisecciónToolStripMenuItem.Click
        Me.Hide()
        FBiseccion.Show()
    End Sub

    Private Sub NewtonRaphsonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewtonRaphsonToolStripMenuItem.Click
        Me.Hide()
        Fraiz.Show()
    End Sub

    Private Sub ReglaFalsaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReglaFalsaToolStripMenuItem.Click
        Me.Hide()
        FReglaFalsa.Show()
    End Sub

    Private Sub JacobiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JacobiToolStripMenuItem.Click
        Jacobi.Show()
        Me.Hide()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub
End Class
