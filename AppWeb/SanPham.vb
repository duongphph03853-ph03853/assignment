Public Class frmSanPham
    Private _DBAccess As New DataBaseAccess

    Private _isEdit As Boolean = False
    Public Sub New(IsEdit As Boolean)

        'This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _isEdit = IsEdit
    End Sub

    Private Sub LoadDataOnComboBox1() 'Đổ dữ liệu từ bảng loại sản phẩm vào combo box
        Dim sqlQuery As String = "Select MaLoaiSP,TenLoaiSP From LoaiSP"
        Dim dbTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        cboMaLoaiSP.DataSource = dbTable
        cboMaLoaiSP.ValueMember = "TenLoaiSP"
        cboMaLoaiSP.DisplayMember = "MaLoaiSP"
    End Sub
    Private Function InsertSanPham() As Boolean
        Dim sqlQuery As String = "Insert Into SanPham (MaSP,TenSP,GiaBan,LoaiSP_MaLoaiSP)"
        sqlQuery += String.Format("Values ('{0}','{1}','{2}','{3}')", txtGiaBan.Text, txtTenSP.Text, txtGiaBan.Text, cboMaLoaiSP.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    Private Function UpdateSanPham() As Boolean
        Dim sqlquery As String = String.Format("UPDATE SanPham SET TenSP = '{0}', GiaBan = '{1}' Where MaSP = '{2}'", txtTenSP.Text, txtGiaBan.Text, txtMaSP.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlquery)
    End Function


    Private Function IsEmpty() As Boolean
        Return String.IsNullOrEmpty(txtMaSP.Text) OrElse String.IsNullOrEmpty(txtTenSP.Text) _
            OrElse String.IsNullOrEmpty(txtGiaBan.Text) OrElse String.IsNullOrEmpty(cboMaLoaiSP.Text)
    End Function

    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataOnComboBox1()
    End Sub

    Private Sub btnNhapLai_Click(sender As Object, e As EventArgs) Handles btnNhapLai.Click
        cboMaLoaiSP.ResetText()
        txtMaSP.Clear()
        txtTenSP.Clear()
        txtGiaBan.Clear()
    End Sub

    Private Sub btnChapNhan_Click(sender As Object, e As EventArgs) Handles btnChapNhan.Click
        If IsEmpty() Then
            MessageBox.Show("Dữ liệu chưa nhập đủ", "Error", MessageBoxButtons.OK)
        Else
            If _isEdit Then
                If UpdateSanPham() Then
                    MessageBox.Show("Sửa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK)
                    DialogResult = DialogResult.OK
                Else
                    MessageBox.Show("Lỗi Sửa dữ liệu", "Thông báo", MessageBoxButtons.OK)
                    DialogResult = DialogResult.No
                End If
            Else
                If InsertSanPham() Then
                    MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK)
                    DialogResult = DialogResult.OK
                Else
                    MessageBox.Show("Lỗi thêm dữ liệu", "Thông báo", MessageBoxButtons.OK)
                    DialogResult = DialogResult.No
                End If
            End If
        End If

        Close()
    End Sub
End Class
