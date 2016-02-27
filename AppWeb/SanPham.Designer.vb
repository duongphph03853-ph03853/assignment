<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSanPham
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.txtGiaBan = New System.Windows.Forms.TextBox()
        Me.cboMaLoaiSP = New System.Windows.Forms.ComboBox()
        Me.btnChapNhan = New System.Windows.Forms.Button()
        Me.btnNhapLai = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Loại Sản Phẩm"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 27)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã Sản Phẩm"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 27)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tên Sản Phẩm"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 27)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Giá Bán"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(127, 82)
        Me.txtMaSP.Multiline = True
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(203, 27)
        Me.txtMaSP.TabIndex = 1
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(127, 140)
        Me.txtTenSP.Multiline = True
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(203, 27)
        Me.txtTenSP.TabIndex = 1
        '
        'txtGiaBan
        '
        Me.txtGiaBan.Location = New System.Drawing.Point(127, 198)
        Me.txtGiaBan.Multiline = True
        Me.txtGiaBan.Name = "txtGiaBan"
        Me.txtGiaBan.Size = New System.Drawing.Size(203, 27)
        Me.txtGiaBan.TabIndex = 1
        '
        'cboMaLoaiSP
        '
        Me.cboMaLoaiSP.FormattingEnabled = True
        Me.cboMaLoaiSP.Location = New System.Drawing.Point(127, 23)
        Me.cboMaLoaiSP.Name = "cboMaLoaiSP"
        Me.cboMaLoaiSP.Size = New System.Drawing.Size(203, 21)
        Me.cboMaLoaiSP.TabIndex = 2
        '
        'btnChapNhan
        '
        Me.btnChapNhan.Location = New System.Drawing.Point(46, 286)
        Me.btnChapNhan.Name = "btnChapNhan"
        Me.btnChapNhan.Size = New System.Drawing.Size(103, 29)
        Me.btnChapNhan.TabIndex = 3
        Me.btnChapNhan.Text = "Chấp Nhận"
        Me.btnChapNhan.UseVisualStyleBackColor = True
        '
        'btnNhapLai
        '
        Me.btnNhapLai.Location = New System.Drawing.Point(227, 286)
        Me.btnNhapLai.Name = "btnNhapLai"
        Me.btnNhapLai.Size = New System.Drawing.Size(103, 29)
        Me.btnNhapLai.TabIndex = 3
        Me.btnNhapLai.Text = "Nhập Lại"
        Me.btnNhapLai.UseVisualStyleBackColor = True
        '
        'frmSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 353)
        Me.Controls.Add(Me.btnNhapLai)
        Me.Controls.Add(Me.btnChapNhan)
        Me.Controls.Add(Me.cboMaLoaiSP)
        Me.Controls.Add(Me.txtGiaBan)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSanPham"
        Me.Text = "SanPham"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMaSP As TextBox
    Friend WithEvents txtTenSP As TextBox
    Friend WithEvents txtGiaBan As TextBox
    Friend WithEvents cboMaLoaiSP As ComboBox
    Friend WithEvents btnChapNhan As Button
    Friend WithEvents btnNhapLai As Button
End Class
