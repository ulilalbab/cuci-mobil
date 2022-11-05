Public Class Form1

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Start()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then

            TextBox2.UseSystemPasswordChar = False

        Else

            TextBox2.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then

            ProgressBar1.Increment(10)

            If ProgressBar1.Value = ProgressBar1.Maximum Then

                Timer1.Stop()

                ProgressBar1.Value = 0

                MsgBox("Your Logged", MsgBoxStyle.Information)

                Form2.Show()

            End If

        Else

            Timer1.Start()

            ProgressBar1.Increment(10)

            If ProgressBar1.Value = ProgressBar1.Maximum Then

                Timer1.Stop()

                ProgressBar1.Value = 0

                MsgBox("Login Not Succes", MsgBoxStyle.Critical)

            End If

        End If
    End Sub
End Class
