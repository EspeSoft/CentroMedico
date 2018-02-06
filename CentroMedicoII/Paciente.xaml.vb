Public Class Paciente
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub btnagregar_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs)

    End Sub

    Private Sub txtbusqueda_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs)

    End Sub

    Private Sub btn_volver_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs)
        Dim Principal As New Principal
        Principal.Show()
        Me.Close()
    End Sub

    Private Sub ListView_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs)
        'en esta parte se toma el valor del item seleccionado'
        Dim ficha As New FichaPaciente
        ficha.Show()
        Me.Close()


    End Sub

End Class
