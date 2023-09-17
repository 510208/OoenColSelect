<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnPickOnMouse = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnDeveloper = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnEULA = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(13, 91)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(784, 295)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = resources.GetString("Guna2HtmlLabel1.Text")
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
        Me.btnPickOnMouse.FillColor = System.Drawing.Color.Green
        Me.btnPickOnMouse.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPickOnMouse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPickOnMouse.ForeColor = System.Drawing.Color.White
        Me.btnPickOnMouse.Location = New System.Drawing.Point(13, 392)
        Me.btnPickOnMouse.Name = "btnPickOnMouse"
        Me.btnPickOnMouse.Size = New System.Drawing.Size(181, 33)
        Me.btnPickOnMouse.TabIndex = 14
        Me.btnPickOnMouse.Text = "知道了(&O)"
        '
        'btnDeveloper
        '
        Me.btnDeveloper.BorderRadius = 10
        Me.btnDeveloper.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDeveloper.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDeveloper.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeveloper.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDeveloper.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDeveloper.Enabled = False
        Me.btnDeveloper.FillColor = System.Drawing.Color.Silver
        Me.btnDeveloper.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDeveloper.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDeveloper.ForeColor = System.Drawing.Color.White
        Me.btnDeveloper.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.btnDeveloper.Location = New System.Drawing.Point(560, 392)
        Me.btnDeveloper.Name = "btnDeveloper"
        Me.btnDeveloper.Size = New System.Drawing.Size(116, 33)
        Me.btnDeveloper.TabIndex = 15
        Me.btnDeveloper.Text = "關於作者(&D)"
        '
        'btnEULA
        '
        Me.btnEULA.BorderRadius = 10
        Me.btnEULA.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEULA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEULA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEULA.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEULA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEULA.Enabled = False
        Me.btnEULA.FillColor = System.Drawing.Color.Silver
        Me.btnEULA.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEULA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEULA.ForeColor = System.Drawing.Color.White
        Me.btnEULA.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.btnEULA.Location = New System.Drawing.Point(682, 392)
        Me.btnEULA.Name = "btnEULA"
        Me.btnEULA.Size = New System.Drawing.Size(116, 33)
        Me.btnEULA.TabIndex = 16
        Me.btnEULA.Text = "EULA(&E)"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = Global.OoenColSelect.My.Resources.Resources._107909497__1_
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(549, 12)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(73, 73)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 17
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.OoenColSelect.My.Resources.Resources.header_cover
        Me.PictureBox1.Location = New System.Drawing.Point(196, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(347, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(810, 437)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.btnEULA)
        Me.Controls.Add(Me.btnDeveloper)
        Me.Controls.Add(Me.btnPickOnMouse)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "About"
        Me.Text = "關於軟體"
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnEULA As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnDeveloper As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnPickOnMouse As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
End Class
