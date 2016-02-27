Public Class frmQLBH
    Private _DBAccess As New DataBaseAccess

    Private _isLoading As Boolean = False

    Private Sub LoadDataOnComboBox1() 'Đổ dữ liệu từ bảng loại sản phẩm vào combo box
        Dim sqlQuery As String = "Select MaLoaiSP,TenLoaiSP From LoaiSP"
        Dim dbTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        cboDanhMuc.DataSource = dbTable
        cboDanhMuc.ValueMember = "MaLoaiSP"
        cboDanhMuc.DisplayMember = "TenLoaiSP"
    End Sub

    Private Sub LoadGridView1(MaLoaiSP As String) 'Đổ dữ liệu vào data grid view
        Dim sqlQuery As String = String.Format("Select MaSP,LoaiSP_MaLoaiSP,TenSP,GiaBan From SanPham Where LoaiSP_MaLoaiSP = '{0}' ", MaLoaiSP)
        Dim dbTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        grvSQLData.DataSource = dbTable
        With grvSQLData
            .Columns(0).HeaderText = "MaSP"
            .Columns(1).HeaderText = "MaLoaiSP"
            .Columns(2).HeaderText = "TenSP"
            .Columns(3).HeaderText = "GiaBan"
            .Columns(2).Width = 250
        End With
    End Sub

    Private Sub LoadGridView2() 'Đổ dữ liệu vào data grid view
        Dim sqlQuery As String = String.Format("Select MaKH,TenKH,DiaChi,SDT From KhachHang")
        Dim dbTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        grvSQLData.DataSource = dbTable
        With grvSQLData
            .Columns(0).HeaderText = "MaKH"
            .Columns(1).HeaderText = "TenKH"
            .Columns(2).HeaderText = "DiaChi"
            .Columns(3).HeaderText = "SDT"
            .Columns(2).Width = 250
        End With
    End Sub
    Private Sub LoadGridView3() 'Đổ dữ liệu vào data grid view
        Dim sqlQuery As String = String.Format("Select MaLoaiSP,TenLoaiSP From LoaiSP")
        Dim dbTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        grvSQLData.DataSource = dbTable
        With grvSQLData
            .Columns(0).HeaderText = "Mã Loại"
            .Columns(1).HeaderText = "Loại Sản Phẩm"
            .Columns(1).Width = 250
        End With
    End Sub

    Private Sub frmQLBH_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub cboDanhMuc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDanhMuc.SelectedIndexChanged
        If Not _isLoading Then
            LoadGridView1(cboDanhMuc.SelectedValue)
        End If
    End Sub

    Private Sub cboBang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBang.SelectedIndexChanged
        If cboBang.SelectedIndex = 0 Then
            cboDanhMuc.ResetText()
            LoadGridView2()
        ElseIf cboBang.SelectedIndex = 1 Then
            _isLoading = True
                LoadDataOnComboBox1()
            _isLoading = False
        ElseIf cboBang.SelectedIndex = 2 Then
            cboDanhMuc.ResetText()
            LoadGridView3()
        End If
    End Sub

    Private Sub Search(MaLoaiSP As String, values As String)
        Dim sqlQuery As String = String.Format("Select MaSP, LoaiSP_MaLoaiSP, TenSP, GiaBan From SanPham Where LoaiSP_MaLoaiSP = '{0}' ", MaLoaiSP)
        If cboLuaChon.SelectedIndex = 0 Then
            sqlQuery += String.Format(" AND MaSP like'{0}%' ", values)
        ElseIf cboLuaChon.SelectedIndex = 1 Then
            sqlQuery += String.Format(" AND TenSP like'{0}%' ", values)
        End If
        Dim dbTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        grvSQLData.DataSource = dbTable
        With grvSQLData
            .Columns(0).HeaderText = "MaSP"
            .Columns(1).HeaderText = "MaLoaiSP"
            .Columns(2).HeaderText = "TenSP"
            .Columns(3).HeaderText = "GiaBan"
            .Columns(2).Width = 250
        End With
    End Sub
    Private Sub txtTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiem.TextChanged
        Search(cboDanhMuc.SelectedValue, txtTimKiem.Text)
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If cboBang.SelectedIndex = 0 Then
            frmKhachHang.ShowDialog()
        ElseIf cboBang.SelectedIndex = 1 Then
            Dim frm As New frmSanPham(False)
            frm.ShowDialog()

            If frm.DialogResult = DialogResult.OK Then
                LoadGridView3()
            End If
        ElseIf cboBang.SelectedIndex = 2 Then
            frmLoaiSanPham.ShowDialog()
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If cboBang.SelectedIndex = 0 Then
            Dim frm1 As New frmKhachHang
            frm1.ShowDialog()
        ElseIf cboBang.SelectedIndex = 1 Then
            Dim frm2 As New frmSanPham(True)
            With grvSQLData
                frm2.txtMaSP.Text = .Rows(.CurrentCell.RowIndex).Cells("MaSP").Value
                frm2.txtTenSP.Text = .Rows(.CurrentCell.RowIndex).Cells("TenSP").Value
                frm2.txtGiaBan.Text = .Rows(.CurrentCell.RowIndex).Cells("GiaBan").Value
            End With
            frm2.ShowDialog()
            If frm2.DialogResult = DialogResult.OK Then
                LoadGridView1(cboDanhMuc.SelectedValue)
            End If
        ElseIf cboBang.SelectedIndex = 2 Then
                frmLoaiSanPham.ShowDialog()
        End If
    End Sub
End Class
