Public Class Calculator
    Dim opselect As Boolean = False, flag As Boolean = False
    Dim op As String = "", data As String
    Dim no1 As Double = 0, no2 As Double = 0, his As String
    Public Sub dig(ByVal input As System.Object, ByVal e As System.EventArgs) Handles one.Click, two.Click, three.Click, four.Click, five.Click, six.Click, seven.Click, eight.Click, nine.Click, zero.Click
        If flag Then
            dis1.Text = input.text + ""
            flag = False
        ElseIf input.Text.Equals("0") And input.Text = "0" Then
            dis1.Text = "0"
        ElseIf dis1.Text.Equals("0") And Val(input.Text) > 0 Then
            dis1.Text = input.text
            ' dis1.Text = String.Format(",", dis1.ToString)
        Else
            dis1.Text += input.Text
        End If
    End Sub
    Public Sub GetAnswer()
        If opselect Then
            no2 = Val(dis1.Text)
        End If
        Select Case op
            Case "+"
                no1 = no1 + no2
            Case "-"
                no1 = no1 - no2
            Case "*"
                no1 = no1 * no2
            Case "/"
                If no2 <> 0 Then
                    no1 = no1 / no2
                Else
                    no1 = 0
                End If
        End Select
        dis1.Text = no1.ToString
    End Sub
    Public Sub operation(ByVal str As String)
        If flag = False Then
            flag = True
            dis2.Text += dis1.Text
            If opselect = False Then
                no1 = Val(dis1.Text)
                opselect = True
            Else
                GetAnswer()
            End If
            dis2.Text += str
        Else
            If dis2.Text.Length > 1 Then
                dis2.Text = dis2.Text.Remove(dis2.Text.Length - 1, 1)
                dis2.Text += str

            End If
        End If

        op = str
    End Sub

    Private Sub div_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles div.Click
        operation("/")
    End Sub

    Private Sub add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add.Click
        operation("+")
    End Sub

    Private Sub minus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minus.Click
        operation("-")
    End Sub

    Private Sub equal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles equal.Click
        his += dis2.Text + dis1.Text + vbNewLine
        GetAnswer()
        his += "="
        his += dis1.Text + vbNewLine
        opselect = False
        histry.Enabled = True
        flag = True
        dis2.Text = ""
    End Sub

    Private Sub dot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dot.Click
        If InStr(dis1.Text, ".") Then
            Exit Sub
        Else
            dis1.Text += "."
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If dis1.Text.Length > 0 And Val(dis1.Text) > 0 Then
            dis1.Text = dis1.Text.Remove(dis1.Text.Length - 1, 1)
            If dis1.Text = "" Then
                dis1.Text = "0"
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dis1.Text = "0"
        dis2.Text = ""
        no1 = 0
        no2 = 0
        opselect = False
        flag = True
    End Sub

    Private Sub mul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mul.Click
        operation("*")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If InStr(dis1.Text, "-") Then
            dis1.Text = dis1.Text.Remove(0, 1)
        Else
            dis1.Text = dis1.Text.Insert(0, "-")
        End If
    End Sub

    Private Sub Calculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Visible = False
        flag = opselect = False
        op = his = ""
        no2 = no1 = 0
        histry.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        dis1.Text = "0"
    End Sub

    Private Sub histry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles histry.Click
        If GroupBox1.Visible = False Then
            GroupBox1.Visible = True

            RichTextBox1.Text = his.ToString
        Else
            GroupBox1.Visible = False
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If his.Length > 0 Then
            his = ""
            RichTextBox1.Clear()
            GroupBox1.Visible = False
        End If
    End Sub

    Private Sub histry_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles histry.MouseHover
        Label1.Visible = True
    End Sub

    Private Sub histry_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles histry.MouseLeave
        Label1.Visible = False
    End Sub

    Private Sub dis2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dis2.Click

    End Sub

    Private Sub Button5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseHover
        Label2.Visible = True
    End Sub
    Private Sub Button5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave
        Label2.Visible = False
    End Sub

    Private Sub dis1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dis1.Click

    End Sub
End Class
