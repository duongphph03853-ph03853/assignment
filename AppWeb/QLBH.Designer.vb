<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLBH
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
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.cboLuaChon = New System.Windows.Forms.ComboBox()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grvSQLData = New System.Windows.Forms.DataGridView()
        Me.cboDanhMuc = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboBang = New System.Windows.Forms.ComboBox()
        CType(Me.grvSQLData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(225, 16)
        Me.txtTimKiem.Multiline = True
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(378, 23)
        Me.txtTimKiem.TabIndex = 11
        '
        'cboLuaChon
        '
        Me.cboLuaChon.FormattingEnabled = True
        Me.cboLuaChon.Items.AddRange(New Object() {"Mã Sản Phẩm", "Tên Sản Phẩm"})
        Me.cboLuaChon.Location = New System.Drawing.Point(98, 18)
        Me.cboLuaChon.Name = "cboLuaChon"
        Me.cboLuaChon.Size = New System.Drawing.Size(121, 21)
        Me.cboLuaChon.TabIndex = 10
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(646, 181)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(95, 31)
        Me.btnXoa.TabIndex = 7
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(646, 120)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(95, 31)
        Me.btnSua.TabIndex = 8
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(646, 56)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(95, 31)
        Me.btnThem.TabIndex = 9
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Tìm Kiếm"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grvSQLData
        '
        Me.grvSQLData.AllowUserToAddRows = False
        Me.grvSQLData.AllowUserToDeleteRows = False
        Me.grvSQLData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grvSQLData.Location = New System.Drawing.Point(12, 56)
        Me.grvSQLData.MultiSelect = False
        Me.grvSQLData.Name = "grvSQLData"
        Me.grvSQLData.ReadOnly = True
        Me.grvSQLData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grvSQLData.Size = New System.Drawing.Size(604, 308)
        Me.grvSQLData.TabIndex = 5
        '
        'cboDanhMuc
        '
        Me.cboDanhMuc.FormattingEnabled = True
        Me.cboDanhMuc.Items.AddRange(New Object() {"Tất cả"})
        Me.cboDanhMuc.Location = New System.Drawing.Point(625, 333)
        Me.cboDanhMuc.Name = "cboDanhMuc"
        Me.cboDanhMuc.Size = New System.Drawing.Size(145, 21)
        Me.cboDanhMuc.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(622, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Danh Mục"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(622, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Bảng"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboBang
        '
        Me.cboBang.FormattingEnabled = True
        Me.cboBang.Items.AddRange(New Object() {"Khách Hàng", "Sản Phẩm", "Loại Sản Phẩm"})
        Me.cboBang.Location = New System.Drawing.Point(625, 256)
        Me.cboBang.Name = "cboBang"
        Me.cboBang.Size = New System.Drawing.Size(145, 21)
        Me.cboBang.TabIndex = 12
        '
        'frmQLBH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 382)
        Me.Controls.Add(Me.cboBang)
        Me.Controls.Add(Me.cboDanhMuc)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.cboLuaChon)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grvSQLData)
        Me.Name = "frmQLBH"
        Me.Text = "Quan Ly Ban Hang"
        CType(Me.grvSQLData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents cboLuaChon As ComboBox
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents grvSQLData As DataGridView
    Friend WithEvents cboDanhMuc As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboBang As ComboBox
End Class
