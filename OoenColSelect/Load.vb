Imports System.Windows.Forms

Public Class Load
    Private Sub Load_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' 取得主顯示器的縮放比例
        Dim primaryScreen As Screen = Screen.PrimaryScreen
        Dim scalingFactor As Double = primaryScreen.Bounds.Width / primaryScreen.WorkingArea.Width

        ' 檢查縮放比例是否等於100%
        If scalingFactor <> 1.0 Then
            Dim result As DialogResult = MessageBox.Show("請設定顯示器縮放比例為100%，然後重新啟動應用程式。", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

            If result = DialogResult.OK Then
                ' 開啟Windows 10設定中的顯示器設定
                System.Diagnostics.Process.Start("ms-settings:display")
                Application.Exit()
            Else
                ' 關閉應用程式
                Application.Exit()
            End If
        End If
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Hide()
        Main.Show()
        Me.Close()
    End Sub
End Class