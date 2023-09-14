<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.imgColorView = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxMagnifier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgColorView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'lblRGBAColor
        '
        Me.lblRGBAColor.AutoSize = True
        Me.lblRGBAColor.Location = New System.Drawing.Point(119, 24)
        Me.lblRGBAColor.Name = "lblRGBAColor"
        Me.lblRGBAColor.Size = New System.Drawing.Size(37, 15)
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
        Me.GroupBox1.Location = New System.Drawing.Point(269, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(110, 130)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "放大鏡"
        '
        'PictureBoxMagnifier
        '
        Me.PictureBoxMagnifier.Location = New System.Drawing.Point(6, 24)
        Me.PictureBoxMagnifier.Name = "PictureBoxMagnifier"
        Me.PictureBoxMagnifier.Size = New System.Drawing.Size(100, 100)
        Me.PictureBoxMagnifier.TabIndex = 3
        Me.PictureBoxMagnifier.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "當前色碼(&C)："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "RGB："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "HEX："
        '
        'lblHEXColor
        '
        Me.lblHEXColor.AutoSize = True
        Me.lblHEXColor.Location = New System.Drawing.Point(119, 39)
        Me.lblHEXColor.Name = "lblHEXColor"
        Me.lblHEXColor.Size = New System.Drawing.Size(37, 15)
        Me.lblHEXColor.TabIndex = 6
        Me.lblHEXColor.Text = "None"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CMYK："
        '
        'lblCMYKColor
        '
        Me.lblCMYKColor.AutoSize = True
        Me.lblCMYKColor.Location = New System.Drawing.Point(119, 54)
        Me.lblCMYKColor.Name = "lblCMYKColor"
        Me.lblCMYKColor.Size = New System.Drawing.Size(37, 15)
        Me.lblCMYKColor.TabIndex = 8
        Me.lblCMYKColor.Text = "None"
        '
        'imgColorView
        '
        Me.imgColorView.Location = New System.Drawing.Point(15, 72)
        Me.imgColorView.Name = "imgColorView"
        Me.imgColorView.Size = New System.Drawing.Size(364, 22)
        Me.imgColorView.TabIndex = 10
        Me.imgColorView.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 270)
        Me.Controls.Add(Me.imgColorView)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCMYKColor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHEXColor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblRGBAColor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBoxMagnifier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgColorView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents imgColorView As PictureBox
End Class
