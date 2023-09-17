Module modClipboard

    ' 複製文本到剪貼簿
    Public Sub CopyTextToClipboard(ByVal text As String)
        Try
            Clipboard.SetText(text)
            MsgBox($"成功複製{text}")
        Catch ex As Exception
            ' 處理例外情況，例如無法設定剪貼簿內容
            Console.WriteLine("複製文本到剪貼簿時發生錯誤：" & ex.Message)
        End Try
    End Sub

    ' 從剪貼簿粘貼文本
    Public Function PasteTextFromClipboard() As String
        Try
            If Clipboard.ContainsText() Then
                Dim text As String = Clipboard.GetText()
                Return text
            Else
                Return String.Empty ' 如果剪貼簿不包含文本，返回空字符串
            End If
        Catch ex As Exception
            ' 處理例外情況，例如無法獲取剪貼簿內容
            Console.WriteLine("從剪貼簿粘貼文本時發生錯誤：" & ex.Message)
            Return String.Empty
        End Try
    End Function
End Module
