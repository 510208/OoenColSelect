Public Class About
    Private Sub btnPickOnMouse_Click(sender As Object, e As EventArgs) Handles btnPickOnMouse.Click
        Me.Close()
    End Sub

    Private Sub btnDeveloper_Click(sender As Object, e As EventArgs) Handles btnDeveloper.Click
        Shell("explorer https://github.com/510208/ "), vbNormalFocus
    End Sub

    Private Sub btnEULA_Click(sender As Object, e As EventArgs) Handles btnEULA.Click
        Shell("explorer https://www.gnu.org/licenses/gpl-3.0.zh-tw.html "), vbNormalFocus
    End Sub
End Class