﻿Imports System.Drawing
Imports System.Windows.Forms

Public Class Main
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

        ' 設定顏色預覽
        imgColorLook.BackColor = screenColor

        '將整個表單的內容皆設定元此顏色
        ' SetForeColorForControls(Me, screenColor)
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

            ' 在放大的區域上繪製紅色的十字準心
            Dim crosshairColor As Color = Color.Red
            Dim crosshairWidth As Integer = 2 ' 十字準心的寬度

            ' 繪製水平線
            g.DrawLine(New Pen(crosshairColor, crosshairWidth), size.Width \ 2, size.Height \ 2, 0, size.Height \ 2)
            g.DrawLine(New Pen(crosshairColor, crosshairWidth), size.Width \ 2, size.Height \ 2, size.Width, size.Height \ 2)

            ' 繪製垂直線
            g.DrawLine(New Pen(crosshairColor, crosshairWidth), size.Width \ 2, size.Height \ 2, size.Width \ 2, 0)
            g.DrawLine(New Pen(crosshairColor, crosshairWidth), size.Width \ 2, size.Height \ 2, size.Width \ 2, size.Height)
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

    Private Sub btnPickOnDialog_Click(sender As Object, e As EventArgs) Handles btnPickOnDialog.Click
        Timer1.Enabled = False
        ColorDialog1.ShowDialog()

        Dim screenColor As Color = ColorDialog1.Color

        ' 計算RGBA值
        Dim rgbaString As String = String.Format("RGBA: ({0}, {1}, {2}, {3})", screenColor.R, screenColor.G, screenColor.B, screenColor.A)
        lblRGBAColor.Text = rgbaString

        ' 計算HEX值
        Dim hexString As String = String.Format("HEX: #{0:X2}{1:X2}{2:X2}", screenColor.R, screenColor.G, screenColor.B)
        lblHEXColor.Text = hexString

        ' 計算CMYK值（假設背景色為白色，即C=0，M=0，Y=0，K=0）
        Dim cmykString As String = String.Format("CMYK: ({0:P2}, {1:P2}, {2:P2}, 0)", 1 - (screenColor.R / 255), 1 - (screenColor.G / 255), 1 - (screenColor.B / 255))
        lblCMYKColor.Text = cmykString

        ' 設定顏色預覽
        imgColorLook.BackColor = screenColor

        btnPickOnMouse.Enabled = True
    End Sub

    Private Sub btnPickOnMouse_Click(sender As Object, e As EventArgs) Handles btnPickOnMouse.Click
        Timer1.Enabled = Not (Timer1.Enabled)
        btnPickOnDialog.Enabled = True
    End Sub

    Public Sub SetForeColorForControls(ByVal container As Control, ByVal screenColor As Color)
        ' 取得表單的客戶區域
        Dim clientRect As Rectangle = container.ClientRectangle

        ' 取得游標在表單客戶區域的位置
        Dim cursorPos As Point = container.PointToClient(Cursor.Position)

        ' 檢查游標是否在表單內部
        If clientRect.Contains(cursorPos) Then
            For Each control As Control In container.Controls
                Dim supportedControl As Control = TryCast(control, Control)
                If supportedControl IsNot Nothing Then
                    If TypeOf supportedControl Is Label OrElse
                   TypeOf supportedControl Is TextBox OrElse
                   TypeOf supportedControl Is Button OrElse
                   TypeOf supportedControl Is ComboBox OrElse
                   TypeOf supportedControl Is ListBox OrElse
                   TypeOf supportedControl Is DataGridView Then
                        ' 設定前景色
                        supportedControl.ForeColor = screenColor
                    ElseIf TypeOf supportedControl Is Guna.UI2.WinForms.Guna2ControlBox OrElse
                       TypeOf supportedControl Is Guna.UI2.WinForms.Guna2Button OrElse
                       TypeOf supportedControl Is Guna.UI2.WinForms.Guna2CheckBox OrElse
                       TypeOf supportedControl Is Guna.UI2.WinForms.Guna2RadioButton Then
                        ' 設定背景色
                        supportedControl.BackColor = screenColor
                    End If

                    ' 遞迴處理容器控制項
                    If supportedControl.HasChildren Then
                        SetForeColorForControls(supportedControl, screenColor)
                    End If
                End If
            Next
        End If
    End Sub
End Class
