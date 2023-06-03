Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "버튼을 클릭하면 텍스트가 추가돼요!"
        TextBox1.Text = ""
    End Sub

    Private line As Integer = 1  '출력할 줄 번호

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = line & "번째 줄 추가됐어요!"
        TextBox1.Text += line & "번째 줄" & Environment.NewLine
        line += 1  '다음 줄 번호 계산
    End Sub
End Class
