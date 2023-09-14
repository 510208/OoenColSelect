Imports System.Drawing

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim cursorPosition As Point = Cursor.Position
        Dim screenColor As Color = GetColorAt(cursorPosition)

        ' 計算RGBA值
        Dim rgbaString As String = String.Format("RGBA: ({0}, {1}, {2}, {3})", screenColor.R, screenColor.G, screenColor.B, screenColor.A)
        lblRGBAColor.Text = rgbaString

        ' 計算HEX值
        Dim hexString As String = String.Format("HEX: #{0:X2}{1:X2}{2:X2}", screenColor.R, screenColor.G, screenColor.B)
        lblHEXColor.Text = hexString

        ' 計算CMYK值（假設背景色為白色，即C=0，M=0，Y=0，K=0）
        Dim cmykString As String = String.Format("CMYK: ({0:P2}, {1:P2}, {2:P2}, 0)", 1 - (screenColor.R / 255), 1 - (screenColor.G / 255), 1 - (screenColor.B / 255))
        lblCMYKColor.Text = cmykString

        ' 獲取放大區域的內容
        Dim magnifiedArea As Bitmap = GetMagnifiedArea(cursorPosition, PictureBoxMagnifier.Size)

        ' 在PictureBox中顯示放大區域的內容
        PictureBoxMagnifier.Image = magnifiedArea

        ' imagebox背景顏色設定
        imgColorView.BackColor = screenColor
    End Sub

    Private Function GetColorAt(point As Point) As Color
        Dim screen As Bitmap = New Bitmap(1, 1)
        Using g As Graphics = Graphics.FromImage(screen)
            g.CopyFromScreen(point, New Point(0, 0), New Size(1, 1))
        End Using
        Return screen.GetPixel(0, 0)
    End Function

    Private Function GetMagnifiedArea(centerPoint As Point, size As Size) As Bitmap
        Dim screen As Bitmap = New Bitmap(size.Width, size.Height)
        Using g As Graphics = Graphics.FromImage(screen)
            g.CopyFromScreen(centerPoint.X - size.Width \ 2, centerPoint.Y - size.Height \ 2, 0, 0, size)
        End Using
        Return screen
    End Function

    Private Sub Form1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        '紀錄滑鼠點選時的視窗位置與滑鼠點選位置
        nOldWndLeft = Me.Left
        nOldWndTop = Me.Top
        nClickX = e.X
        nClickY = e.Y
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If Me.Capture = True Then      '如果滑鼠按著拖曳
            '設定新的視窗位置
            Me.Top = e.Y + nOldWndTop - nClickY
            Me.Left = e.X + nOldWndLeft - nClickX
            '更新紀錄的視窗位置
            nOldWndLeft = Me.Left
            nOldWndTop = Me.Top
        End If
    End Sub

    Dim nOldWndTop, nOldWndLeft, nClickX, nClickY
End Class
