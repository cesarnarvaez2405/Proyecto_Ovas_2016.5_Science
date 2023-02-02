Public Class medio
    Dim act = "C:\Program Files (x86)\HP Inc\Ovas Ciencias\act.html"
    Dim atmosfera = "C:\Program Files (x86)\HP Inc\Ovas Ciencias\atmotfera.html"
    Dim proble = "C:\Program Files (x86)\HP Inc\Ovas Ciencias\proble.html"
    Dim tiposconta = "C:\Program Files (x86)\HP Inc\Ovas Ciencias\tiposconta.html"
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Hide()
        ecosistemas.Show()

    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        ecosistemas.Show()

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Process.Start(proble)
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Process.Start(proble)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Process.Start(act)
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Process.Start(act)
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Process.Start(tiposconta)
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Process.Start(tiposconta)
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Process.Start(atmosfera)
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Process.Start(atmosfera)
    End Sub
End Class