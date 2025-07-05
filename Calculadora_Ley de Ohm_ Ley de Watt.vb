Public Class Form1

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then

            If IsNumeric(TextBox2.Text) And IsNumeric(TextBox3.Text) Then
                Dim V As Single = CSng(TextBox2.Text)
                Dim C As Single = CSng(TextBox3.Text)
                Dim R As Single = V / C
                TextBox5.Text = R
            Else
                TextBox5.Text = "Error"
            End If
        ElseIf RadioButton2.Checked Then

            If IsNumeric(TextBox2.Text) And IsNumeric(TextBox4.Text) Then
                Dim V As Single = CSng(TextBox2.Text)
                Dim P As Single = CSng(TextBox4.Text)
                Dim R As Single = (V ^ 2) / P
                TextBox5.Text = R
            Else
                TextBox5.Text = "Error"
            End If
        Else
            TextBox5.Text = "Error"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton1.Checked Then

            If IsNumeric(TextBox1.Text) And IsNumeric(TextBox3.Text) Then
                Dim C As Single = CSng(TextBox3.Text)
                Dim R As Single = CSng(TextBox1.Text)
                Dim V As Single = C * R
                TextBox5.Text = V
            Else
                TextBox5.Text = "Error"
            End If
        ElseIf RadioButton2.Checked Then

            If IsNumeric(TextBox3.Text) And IsNumeric(TextBox4.Text) Then
                Dim P As Single = CSng(TextBox4.Text)
                Dim C As Single = CSng(TextBox3.Text)
                Dim V As Single = P / C
                TextBox5.Text = V
            Else
                TextBox5.Text = "Error"
            End If
        Else
            TextBox5.Text = "Error"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RadioButton1.Checked Then

            If IsNumeric(TextBox1.Text) And IsNumeric(TextBox2.Text) Then
                Dim V As Single = CSng(TextBox2.Text)
                Dim R As Single = CSng(TextBox1.Text)
                Dim C As Single = V / R
                TextBox5.Text = C
            Else
                TextBox5.Text = "Error"
            End If
        ElseIf RadioButton2.Checked Then

            If IsNumeric(TextBox2.Text) And IsNumeric(TextBox4.Text) Then
                Dim P As Single = CSng(TextBox4.Text)
                Dim V As Single = CSng(TextBox2.Text)
                Dim C As Single = P / V
                TextBox5.Text = C
            Else
                TextBox5.Text = "Error"
            End If
        Else
            TextBox5.Text = "Error"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If RadioButton1.Checked Then

            If IsNumeric(TextBox2.Text) And IsNumeric(TextBox3.Text) Then
                Dim V As Single = CSng(TextBox2.Text)
                Dim C As Single = CSng(TextBox3.Text)
                Dim P As Single = V * C
                TextBox5.Text = P
            Else
                TextBox5.Text = "Error"
            End If
        ElseIf RadioButton2.Checked Then

            If IsNumeric(TextBox1.Text) And IsNumeric(TextBox2.Text) Then
                Dim V As Single = CSng(TextBox2.Text)
                Dim R As Single = CSng(TextBox1.Text)
                Dim P As Single = (V ^ 2) / R
                TextBox5.Text = P
            Else
                TextBox5.Text = "Error"
            End If
        Else
            TextBox5.Text = "Error"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()

        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub
End Class
