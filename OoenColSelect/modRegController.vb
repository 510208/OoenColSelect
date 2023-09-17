Imports Microsoft.Win32

Module modRegController
    ' 讀取Reg內容
    Public Function ReadRegistryValue(ByVal keyPath As String, ByVal valueName As String) As Object
        Try
            Using key As RegistryKey = Registry.CurrentUser.OpenSubKey(keyPath)
                If key IsNot Nothing Then
                    Dim value As Object = key.GetValue(valueName)
                    Return value
                Else
                    Return Nothing ' 如果鍵不存在，返回Nothing
                End If
            End Using
        Catch ex As Exception
            ' 處理例外情況，例如註冊表鍵不存在或無法訪問
            Console.WriteLine("讀取註冊表值時發生錯誤：" & ex.Message)
            Return Nothing
        End Try
    End Function

    ' 建立註冊表值
    Public Sub WriteRegistryValue(ByVal keyPath As String, ByVal valueName As String, ByVal value As Object)
        Try
            Using key As RegistryKey = Registry.CurrentUser.CreateSubKey(keyPath)
                If key IsNot Nothing Then
                    key.SetValue(valueName, value)
                End If
            End Using
        Catch ex As Exception
            ' 處理例外情況，例如無法寫入註冊表
            Console.WriteLine("寫入註冊表值時發生錯誤：" & ex.Message)
        End Try
    End Sub

    ' 移除註冊表值
    Public Sub DeleteRegistryValue(ByVal keyPath As String, ByVal valueName As String)
        Try
            Using key As RegistryKey = Registry.CurrentUser.OpenSubKey(keyPath, True)
                If key IsNot Nothing Then
                    key.DeleteValue(valueName, False)
                End If
            End Using
        Catch ex As Exception
            ' 處理例外情況，例如無法刪除註冊表值
            Console.WriteLine("刪除註冊表值時發生錯誤：" & ex.Message)
        End Try
    End Sub

    ' 建立註冊表鍵
    Public Sub CreateRegistryKey(ByVal keyPath As String)
        Try
            Registry.CurrentUser.CreateSubKey(keyPath)
        Catch ex As Exception
            ' 處理例外情況，例如無法創建註冊表鍵
            Console.WriteLine("建立註冊表鍵時發生錯誤：" & ex.Message)
        End Try
    End Sub

    ' 移除註冊表鍵
    Public Sub DeleteRegistryKey(ByVal keyPath As String)
        Try
            Registry.CurrentUser.DeleteSubKeyTree(keyPath)
        Catch ex As Exception
            ' 處理例外情況，例如無法刪除註冊表鍵
            Console.WriteLine("刪除註冊表鍵時發生錯誤：" & ex.Message)
        End Try
    End Sub
End Module
