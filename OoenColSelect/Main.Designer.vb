﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblRGBAColor = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxMagnifier = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHEXColor = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCMYKColor = New System.Windows.Forms.Label()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btnPickOnMouse = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnPickOnDialog = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.imgColorLook = New System.Windows.Forms.PictureBox()
        Me.btnAbout = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxMagnifier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgColorLook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'lblRGBAColor
        '
        Me.lblRGBAColor.AutoSize = True
        Me.lblRGBAColor.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblRGBAColor.Location = New System.Drawing.Point(63, 56)
        Me.lblRGBAColor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRGBAColor.Name = "lblRGBAColor"
        Me.lblRGBAColor.Size = New System.Drawing.Size(40, 16)
        Me.lblRGBAColor.TabIndex = 0
        Me.lblRGBAColor.Text = "None"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 8
        Me.Guna2Elipse1.TargetControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBoxMagnifier)
        Me.GroupBox1.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(200, 158)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(82, 104)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "放大鏡"
        '
        'PictureBoxMagnifier
        '
        Me.PictureBoxMagnifier.Location = New System.Drawing.Point(4, 19)
        Me.PictureBoxMagnifier.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBoxMagnifier.Name = "PictureBoxMagnifier"
        Me.PictureBoxMagnifier.Size = New System.Drawing.Size(75, 80)
        Me.PictureBoxMagnifier.TabIndex = 3
        Me.PictureBoxMagnifier.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "當前色碼(&C)："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 56)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "RGB："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "HEX："
        '
        'lblHEXColor
        '
        Me.lblHEXColor.AutoSize = True
        Me.lblHEXColor.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblHEXColor.Location = New System.Drawing.Point(63, 72)
        Me.lblHEXColor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHEXColor.Name = "lblHEXColor"
        Me.lblHEXColor.Size = New System.Drawing.Size(40, 16)
        Me.lblHEXColor.TabIndex = 6
        Me.lblHEXColor.Text = "None"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 88)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CMYK："
        '
        'lblCMYKColor
        '
        Me.lblCMYKColor.AutoSize = True
        Me.lblCMYKColor.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblCMYKColor.Location = New System.Drawing.Point(63, 88)
        Me.lblCMYKColor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCMYKColor.Name = "lblCMYKColor"
        Me.lblCMYKColor.Size = New System.Drawing.Size(40, 16)
        Me.lblCMYKColor.TabIndex = 8
        Me.lblCMYKColor.Text = "None"
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(246, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 11
        '
        'btnPickOnMouse
        '
        Me.btnPickOnMouse.BorderRadius = 10
        Me.btnPickOnMouse.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPickOnMouse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPickOnMouse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPickOnMouse.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPickOnMouse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPickOnMouse.Enabled = False
        Me.btnPickOnMouse.FillColor = System.Drawing.Color.Silver
        Me.btnPickOnMouse.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPickOnMouse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPickOnMouse.ForeColor = System.Drawing.Color.White
        Me.btnPickOnMouse.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.btnPickOnMouse.Location = New System.Drawing.Point(12, 197)
        Me.btnPickOnMouse.Name = "btnPickOnMouse"
        Me.btnPickOnMouse.Size = New System.Drawing.Size(180, 27)
        Me.btnPickOnMouse.TabIndex = 13
        Me.btnPickOnMouse.Text = "從游標吸取處選擇顏色(&P)"
        '
        'btnPickOnDialog
        '
        Me.btnPickOnDialog.BorderRadius = 10
        Me.btnPickOnDialog.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPickOnDialog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPickOnDialog.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPickOnDialog.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPickOnDialog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPickOnDialog.FillColor = System.Drawing.Color.Silver
        Me.btnPickOnDialog.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPickOnDialog.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPickOnDialog.ForeColor = System.Drawing.Color.White
        Me.btnPickOnDialog.Location = New System.Drawing.Point(12, 230)
        Me.btnPickOnDialog.Name = "btnPickOnDialog"
        Me.btnPickOnDialog.Size = New System.Drawing.Size(180, 27)
        Me.btnPickOnDialog.TabIndex = 14
        Me.btnPickOnDialog.Text = "從色彩選擇器選擇顏色(&G)"
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(-2, 0)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox2.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 36)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Tips:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "按下F9、F10和F11可以分別複製" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RGB、HEX和CMYK值喔！"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OoenColSelect.My.Resources.Resources.header_cover
        Me.PictureBox1.Location = New System.Drawing.Point(80, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'imgColorLook
        '
        Me.imgColorLook.Location = New System.Drawing.Point(231, 55)
        Me.imgColorLook.Name = "imgColorLook"
        Me.imgColorLook.Size = New System.Drawing.Size(48, 32)
        Me.imgColorLook.TabIndex = 12
        Me.imgColorLook.TabStop = False
        '
        'btnAbout
        '
        Me.btnAbout.BorderRadius = 10
        Me.btnAbout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAbout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAbout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAbout.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAbout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAbout.Enabled = False
        Me.btnAbout.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAbout.FillColor2 = System.Drawing.Color.Navy
        Me.btnAbout.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAbout.ForeColor = System.Drawing.Color.White
        Me.btnAbout.Location = New System.Drawing.Point(12, 164)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(91, 27)
        Me.btnAbout.TabIndex = 18
        Me.btnAbout.Text = "關於(&A)"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPickOnDialog)
        Me.Controls.Add(Me.btnPickOnMouse)
        Me.Controls.Add(Me.imgColorLook)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCMYKColor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHEXColor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblRGBAColor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Main"
        Me.Text = "OoenColSelect"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBoxMagnifier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgColorLook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblRGBAColor As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBoxMagnifier As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblCMYKColor As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHEXColor As Label
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents imgColorLook As PictureBox
    Friend WithEvents btnPickOnMouse As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnPickOnDialog As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAbout As Guna.UI2.WinForms.Guna2GradientButton
End Class
