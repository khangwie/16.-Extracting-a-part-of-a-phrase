Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myphrase As String
        Dim pos, n As Integer
        myphrase = TextBox1.Text
        pos = TextBox2.Text
        n = TextBox3.Text

        TextBox4.Text = Mid(myphrase, pos, n)


    End Sub
End Class
