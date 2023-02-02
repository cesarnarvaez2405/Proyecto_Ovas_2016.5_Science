Public Class Ardoraz
    Public contador As Integer


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If contador < 100 Then
            ProgressBar1.Value = contador
            contador = contador + 1
        Else
            Timer1.Enabled = False
            Me.Hide()
            Inicio.Show()


        End If
    End Sub


    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click
        ProgressBar1.Value = 5.0
        ProgressBar1.Maximum = 100
        Timer1.Interval = 50
        Timer1.Enabled = True
    End Sub
End Class
