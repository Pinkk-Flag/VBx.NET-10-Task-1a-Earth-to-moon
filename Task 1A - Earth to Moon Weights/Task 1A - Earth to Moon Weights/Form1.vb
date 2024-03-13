Public Class Form1

    ' Hi, this is an application that converts Earth weight to moon weight

    ' For reference, when you see <summary>, and the other stuff, it contains the internal documentation.

    Dim value As Single
    Dim answer As Single

    ''' <summary>
    ''' Event handler for the Exit button. Terminates the application.
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    ''' <summary>
    ''' Event handler for the Guide button. Provides a brief guide on how to use the application.
    ''' </summary>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuide.Click
        MsgBox("Welcome! This is the Earth to Moon weights task. To use it, simply enter the weight in kilograms in the Earth weight textbox or adjust the scrollbar. All values are between 0 and 200 kg. Have fun :]")
    End Sub

    ''' <summary>
    ''' Event handler for the scrollbar value change. Updates the Earth weight textbox and calculates the corresponding Moon weight.
    ''' </summary>
    Private Sub hscrollbar_Scroll(sender As Object, e As ScrollEventArgs) Handles hscrollbar.Scroll
        Dim value = hscrollbar.Value
        txtEarth.Text = Format(value, "#.0kg")
        txtMoon.Text = Format(value * 0.165, "#.0kg")
    End Sub

    ''' <summary>
    ''' Event handler for the Clear button. Clears the Moon weight and Earth weight textboxes, and resets the scrollbar value to 0.
    ''' </summary>
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMoon.Clear()
        txtEarth.Clear()
        hscrollbar.Value = 0
    End Sub
End Class
