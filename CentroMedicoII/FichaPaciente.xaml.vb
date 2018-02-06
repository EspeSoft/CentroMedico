Public Class FichaPaciente
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub btn_volver_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs)
        Dim paciente As New Paciente
        paciente.Show()
        Me.Close()
    End Sub

    Private Sub btn_modifica_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs)

    End Sub

    Private Sub btn_elimina_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs)

    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

    End Sub
End Class
