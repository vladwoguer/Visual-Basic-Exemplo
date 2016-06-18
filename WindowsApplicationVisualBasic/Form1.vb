Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Muda o link
        If (Not (TextBox1.Text = "")) Then
            LinkLabel1.Text = TextBox1.Text
        End If
        'Muda a cor
        If (RadioButton1.Checked) Then
            LinkLabel1.LinkColor = Color.Red
        End If
        If (RadioButton2.Checked) Then
            LinkLabel1.LinkColor = Color.Blue
        End If
        If (RadioButton3.Checked) Then
            LinkLabel1.LinkColor = Color.Black
        End If

    End Sub
End Class
