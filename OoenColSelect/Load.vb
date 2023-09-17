Imports System.Windows.Forms

Public Class Load

    Private Sub Load_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' 檢查註冊表中是否有值，如果有值，則表示已經執行過一次，無需再次彈出訊息框
        Dim registryValue As Object = ReadRegistryValue("Software\OoenColSelect", "ScaleWarningShown")

        If registryValue Is Nothing Then
            ' 彈出訊息框，提示設定顯示器縮放比例為100%
            Dim result As DialogResult = MessageBox.Show("請設定顯示器縮放比例為100%，否則系統將無法正常運行！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

            ' 如果使用者按下 "是" 按鈕，則寫入註冊表值
            If result = DialogResult.OK Then
                WriteRegistryValue("Software\OoenColSelect", "ScaleWarningShown", "Yes")
            End If
        End If

        ' 開始計時器
        Timer1.Start()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Hide()
        Main.Show()
        Me.Close()
    End Sub
End Class