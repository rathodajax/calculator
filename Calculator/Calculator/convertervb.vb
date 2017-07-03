Public Class conversion
    Dim no1 As Double = 0, no2 As Double = 0
    Dim noselect As Boolean = False

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles convertor.SelectedIndexChanged
        If convertor.SelectedItem = "Length" Then
            convertor1.Items.Insert(0, "Feet")
            convertor1.Items.Insert(1, "Millimeters")
            convertor1.Items.Insert(2, "Meters")
            convertor1.Items.Insert(3, "Centimeters")
            convertor1.Items.Insert(4, "Kilometers")
            convertor1.Items.Insert(5, "Inches")
            convertor1.Text = convertor1.Items.Item(0)
            convertor2.Items.Insert(0, "Feet")
            convertor2.Items.Insert(1, "Millimeters")
            convertor2.Items.Insert(2, "Meters")
            convertor2.Items.Insert(3, "Centimeters")
            convertor2.Items.Insert(4, "Kilometers")
            convertor2.Items.Insert(5, "Inches")
            convertor2.Text = convertor2.Items.Item(5)
        ElseIf convertor.SelectedItem = "Volume" Then
            convertor1.Items.Insert(0, "Liters")
            convertor1.Items.Insert(1, "Milliliters")
            convertor1.Items.Insert(2, "Gallons(UK)")
            convertor1.Items.Insert(3, "Gallons(US)")
            convertor1.Text = convertor1.Items.Item(0)
            convertor2.Items.Insert(0, "Liters")
            convertor2.Items.Insert(1, "Milliliters")
            convertor2.Items.Insert(2, "Gallons(UK)")
            convertor2.Items.Insert(3, "Gallons(US)")
            convertor2.Text = convertor2.Items.Item(1)
        Else


        End If
    End Sub

    Private Sub b1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1.Click, b3.Click, b2.Click, b4.Click, b5.Click, b6.Click, b7.Click, b8.Click, b9.Click, b0.Click
        If noselect Then
            If con2.Text.Length = 1 And con2.Text.Equals("0") Then
                con2.Text = ""
            End If
            con2.Text += sender.Text
        Else
            If con1.Text.Length = 1 And con1.Text.Equals("0") Then
                con1.Text = ""
            End If
            con1.Text += sender.Text
        End If

    End Sub

    Private Sub con1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles con1.Click
        noselect = False

    End Sub

    Private Sub con2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles con2.Click
        noselect = True
    End Sub

    Private Sub conversion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub con1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles con1.TextChanged, con2.TextChanged

        getanswer()
    End Sub
    Public Sub getanswer()
        Dim str As String = convertor1.SelectedItem, str1 As String = convertor2.SelectedItem
        no1 = Val(con1.Text)
        ' MsgBox("text changed")
        Select Case str
            Case "Meters"
                Select Case str1
                    Case "Millimeters"
                        no2 = no1 * 1000
                    Case "Centimeters"
                        no2 = no1 * 100
                    Case "Meters"
                        no2 = no1
                    Case "Kilometers"
                        no2 = no1 / 1000
                    Case "Inches"
                        no2 = no1 * 39.37
                    Case "Feet"
                        no2 = no1 * 3.28
                End Select
            Case "Millimeters"
                Select Case str1
                    Case "Millimeters"
                        no2 = no1
                    Case "Centimeters"
                        no2 = no1 / 10
                    Case "Meters"
                        no2 = no1 / 1000
                    Case "Kilometers"
                        no2 = (no1 * 0.01)
                        no2 /= 1000
                    Case "Inches"
                        no2 = (no1 * 39.3701) / 1000
                    Case "Feet"
                        no2 = (no1 * 3.2808) / 1000
                End Select
            Case "Centimeters"
                Select Case str1
                    Case "Millimeters"
                        no2 = no1 * 10
                    Case "Centimeters"
                        no2 = no1
                    Case "Meters"
                        no2 = no1 / 100
                    Case "Kilometers"
                        no2 = (no1 * 0.00001)
                    Case "Inches"
                        no2 = (no1 * 39.37) / 100
                    Case "Feet"
                        no2 = (no1 * 3.281) / 100
                End Select
            Case "Kilometers"
                Select Case str1
                    Case "Millimeters"
                        no2 = no1 * 1000000
                    Case "Centimeters"
                        no2 = no1 * 100000
                    Case "Meters"
                        no2 = no1 * 1000
                    Case "Kilometers"
                        no2 = no1
                    Case "Inches"
                        no2 = no1 * 39370.08
                    Case "Feet"
                        no2 = no1 * 3280.84
                End Select
            Case "Inches"
                Select Case str1
                    Case "Millimeters"
                        no2 = no1 * 25.4
                    Case "Centimeters"
                        no2 = no1 * 2.54
                    Case "Meters"
                        no2 = (no1 * 254) / 1000
                    Case "Kilometers"
                        no2 = (no1 * 0.0254) / 1000
                    Case "Inches"
                        no2 = no1
                    Case "Feet"
                        no2 = (no1 * 0.83333) / 10
                End Select
            Case "Feet"
                Select Case str1
                    Case "Millimeters"
                        no2 = no1 * 304.8
                    Case "Centimeters"
                        no2 = no1 * 30.48
                    Case "Meters"
                        no2 = (no1 * 0.3048)
                    Case "Kilometers"
                        no2 = (no1 * 0.305) / 1000
                    Case "Inches"
                        no2 = no1 * 12
                    Case "Feet"
                        no2 = no1
                End Select
            Case "Milliliters"
                Select Case str1
                    Case "Milliliters"
                        no2 = no1
                    Case "Liters"
                        no2 = no1 / 1000
                    Case "Gallons(UK)"
                        no2 = (no1 * 0.00022)
                    Case "Gallons(US)"
                        no2 = no1 * 0.000264
                End Select
            Case "Liters"
                Select Case str1
                    Case "Milliliters"
                        no2 = no1 * 1000
                    Case "Liters"
                        no2 = no1
                    Case "Gallons(UK)"
                        no2 = (no1 * 0.219979)
                    Case "Gallons(US)"
                        no2 = (no1 * 0.264172)
                End Select
            Case "Gallons(UK)"
                Select Case str1
                    Case "Milliliters"
                        no2 = no1 * 1000
                    Case "Liters"
                        no2 = no1 * 4.54609
                    Case "Gallons(UK)"
                        no2 = no1
                    Case "Gallons(US)"
                        no2 = no1 * 1.20095
                End Select
            Case "Gallons(US)"
                Select Case str1
                    Case "Milliliters"
                        no2 = no1 * 0.000264
                    Case "Liters"
                        no2 = no1 * 0.264172
                    Case "Gallons(UK)"
                        no2 = no1 * 1.20095
                    Case "Gallons(US)"
                        no2 = no1
                End Select

        End Select
        con2.Text = no2.ToString
    End Sub

    Private Sub convertor2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles convertor2.SelectedIndexChanged
        getanswer()
    End Sub

    Private Sub convertor1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles convertor1.SelectedIndexChanged
        getanswer()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        con1.Text = ""
        con2.Text = ""
        no1 = 0
        no2 = 0
        noselect = False
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If con1.Text.Length > 0 Then
            con1.Text = con1.Text.Remove(con1.Text.Length - 1, 1)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub b3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b3.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class