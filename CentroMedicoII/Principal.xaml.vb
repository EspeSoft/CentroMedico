Public Class Principal
    Private Sub btp_Click(sender As Object, e As RoutedEventArgs)
        Dim Paciente As New Paciente
        Paciente.Show()
        Me.Close()

    End Sub

    Private Sub btd_Click(sender As Object, e As RoutedEventArgs)
        Dim Doc As New Doctor
        Doc.Show()
        Me.Close()
    End Sub

    Private Sub btc_Click(sender As Object, e As RoutedEventArgs) Handles btc.Click
        Dim cita As New Citas
        cita.Show()
        Me.Close()
    End Sub
End Class