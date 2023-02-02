Public Class ques

    Dim ques = "C:\Program Files (x86)\HP Inc\Ovas Ciencias\que.html"
    Dim ani = "C:\Program Files (x86)\HP Inc\Ovas Ciencias\ani.html"
    Dim nutri = "C:\Program Files (x86)\HP Inc\Ovas Ciencias\nutri.html"


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Hide()
        ecosistemas.Show()

    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        ecosistemas.Show()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Process.Start(ques)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Process.Start(ques)
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Process.Start(ani)
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Process.Start(ani)
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Process.Start(nutri)
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Process.Start(nutri)
    End Sub


End Class