﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bx.ALL_UserControl
{
    public partial class UC_Sale : UserControl
    {
        QLHD qlhd;
        QLSP qlsp;
        QLKH qlkh;
        public UC_Sale()
        {
            InitializeComponent();
            qlhd=new QLHD();
            qlsp=new QLSP();
            qlkh=new QLKH();
        }

        private void txtMaXe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key is pressed
            {
                try
                {

                    string maXeTK = txtMaXe.Text.Trim();
                    if (string.IsNullOrWhiteSpace(maXeTK))
                    {
                        MessageBox.Show("Vui lòng nhập mã xe!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DataTable dt = qlsp.LayDSSanPham();
                    bool timThay = false;
                    foreach (DataRow row in dt.Rows)
                    {
                        string maXe = row["MaXe"].ToString().Trim().ToUpper().Replace("\r", "").Replace("\n", "");
                        bool maXeMatch = string.IsNullOrWhiteSpace(maXeTK) || maXe == maXeTK;

                        if (maXeMatch)
                        {
                            timThay = true;
                            txtMaXe.Text = maXeTK;
                            txtTenXe.Text = row["TenXe"].ToString();
                            txtLoaiXe.Text = row["LoaiXe"].ToString();
                            txtDungTich.Text = row["DungTich"].ToString();
                            txtHangSanXuat.Text = row["HangSanXuat"].ToString();
                            txtMauSac.Text = row["MauSac"].ToString();
                            txtGiaBan.Text = row["GiaBan"].ToString();
                            txtSoLuong.Text = row["SoLuong"].ToString();
                            txtDonViTinh.Text = row["DonViTinh"].ToString();
                            // Khóa các TextBox sau khi tìm thấy
                            txtMaXe.ReadOnly = true;
                            txtTenXe.ReadOnly = true;
                            txtLoaiXe.ReadOnly = true;
                            txtDungTich.ReadOnly = true;
                            txtHangSanXuat.ReadOnly = true;
                            txtMauSac.ReadOnly = true;
                            txtGiaBan.ReadOnly = true;
                            txtDonViTinh.ReadOnly = true;
                        }
                    }
            
                    if (timThay==false)
                    {
                        MessageBox.Show("Không tìm thấy mã xe này!", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Optionally clear the other fields if the vehicle is not found
                        txtTenXe.Clear();
                        txtLoaiXe.Clear();
                        txtDungTich.Clear();
                        txtHangSanXuat.Clear();
                        txtMauSac.Clear();
                        txtGiaBan.Clear();
                        txtSoLuong.Clear();
                        txtDonViTinh.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm mã xe: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                e.Handled = true; // Prevent further processing of the Enter key
            }
        }
        private void ClearFields()
        {
            txtMaXe.Clear();
            txtTenXe.Clear();
            txtLoaiXe.Clear();
            txtDungTich.Clear();
            txtHangSanXuat.Clear();
            txtMauSac.Clear();
            txtGiaBan.Clear();
            txtSoLuong.Clear();
            txtDonViTinh.Clear();
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSoCCCD.Clear();
            txtDiachi.Clear();
            txtSDT.Clear();
            txtThanhTien.Clear();
            txtMaHD.Clear();
            dtNgayLap.Value = DateTime.Now;
        }

        private void txtMaKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Check if Enter key is pressed
            {
                try
                {

                    string maKHTK = txtMaKH.Text.Trim();
                    if (string.IsNullOrWhiteSpace(maKHTK))
                    {
                        MessageBox.Show("Vui lòng nhập mã khách hàng!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DataTable dt = qlkh.LayDSKhachHang();
                    bool timThay = false;
                    foreach (DataRow row in dt.Rows)
                    {
                        string maKH = row["MaKH"].ToString().Trim().ToUpper().Replace("\r", "").Replace("\n", "");
                        bool maKHMatch = string.IsNullOrWhiteSpace(maKHTK) || maKH == maKHTK;

                        if (maKHMatch)
                        {
                            timThay = true;
                            txtMaKH.Text = maKHTK;
                            txtTenKH.Text = row["TenKH"].ToString();
                            if (row["GioiTinh"].ToString() == "Nam")
                            {
                                rbNam.Checked = true;
                                rbNu.Checked = false;
                            }
                            else
                            {
                                rbNu.Checked = true;
                                rbNam.Checked = false;
                            }
                            txtSoCCCD.Text = row["SoCCCD"].ToString();
                            txtDiachi.Text = row["DiaChi"].ToString ();
                            txtSDT.Text = row["SoDT"].ToString () ;
                            // Khóa các TextBox sau khi tìm thấy
                            txtMaKH.ReadOnly = true;
                            txtTenKH.ReadOnly = true;
                            txtSoCCCD.ReadOnly = true;
                            txtDiachi.ReadOnly = true;
                            txtSDT.ReadOnly = true;
                            rbNam.Enabled = false; // Khóa RadioButton
                            rbNu.Enabled = false;  // Khóa RadioButton
                        }
                    }

                    if (timThay == false)
                    {
                        MessageBox.Show("Không tìm thấy mã khách hàng này!", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Optionally clear the other fields if the vehicle is not found
                        txtTenKH.Clear();
                        txtMaKH.Clear();
                        rbNam.Checked = false;
                        rbNu.Checked= false;
                        txtSoCCCD.Clear();
                        txtDiachi.Clear();
                        txtSDT.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm mã khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                e.Handled = true; // Prevent further processing of the Enter key
            }
        }
        private void HienDanhSachHoaDon()
        {
            try
            {
                // Kiểm tra và thêm các cột vào DataGridView nếu chưa có
                if (dgvQLHD.Columns.Count == 0)
                {
                    dgvQLHD.Columns.Add("MaHD", "Mã Hóa Đơn");
                    dgvQLHD.Columns.Add("NgayLap", "Ngày Lập");
                    dgvQLHD.Columns.Add("MaKH", "Mã khách hàng");
                    dgvQLHD.Columns.Add("TenKH", "Tên Khách Hàng");
                    dgvQLHD.Columns.Add("GioiTinh", "Giới Tính");
                    dgvQLHD.Columns.Add("CCCD", "CCCD");
                    dgvQLHD.Columns.Add("DiaChi", "Địa Chỉ");
                    dgvQLHD.Columns.Add("SoDT", "Số Điện Thoại");
                    dgvQLHD.Columns.Add("MaXe", "Mã Xe");
                    dgvQLHD.Columns.Add("TenXe", "Tên Xe");
                    dgvQLHD.Columns.Add("LoaiXe", "Loại Xe");
                    dgvQLHD.Columns.Add("DungTich", "Dung Tích");
                    dgvQLHD.Columns.Add("HangSanXuat", "Hãng Sản Xuất");
                    dgvQLHD.Columns.Add("MauSac", "Màu Sắc");
                    dgvQLHD.Columns.Add("GiaBan", "Giá Bán");
                    dgvQLHD.Columns.Add("SoLuong", "Số Lượng");
                    dgvQLHD.Columns.Add("DonViTinh", "Đơn Vị Tính");
                    dgvQLHD.Columns.Add("ThanhTien", "Thành Tiền");
                    dgvQLHD.Columns["NgayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                // Lấy danh sách hóa đơn từ cơ sở dữ liệu
                DataTable dt = qlhd.LayDSHoaDon(); // Giả sử bạn có hàm LayDSHoaDon()
                dgvQLHD.Rows.Clear();

                // Điền dữ liệu vào DataGridView
                foreach (DataRow row in dt.Rows)
                {
                    DataGridViewRow dgvRow = new DataGridViewRow();
                    dgvRow.CreateCells(dgvQLHD);
                    dgvRow.Cells[dgvQLHD.Columns["MaHD"].Index].Value = row["MaHD"].ToString();
                    if (row["NgayLap"] != DBNull.Value)
                    {
                        dgvRow.Cells[dgvQLHD.Columns["NgayLap"].Index].Value = Convert.ToDateTime(row["NgayLap"]).ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        dgvRow.Cells[dgvQLHD.Columns["NgayLap"].Index].Value = string.Empty;
                    }
                    dgvRow.Cells[dgvQLHD.Columns["MaKH"].Index].Value = row["MaKH"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["TenKH"].Index].Value = row["TenKH"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["GioiTinh"].Index].Value = row["GioiTinh"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["CCCD"].Index].Value = row["CCCD"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["DiaChi"].Index].Value = row["DiaChi"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["SoDT"].Index].Value = row["SoDT"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["MaXe"].Index].Value = row["MaXe"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["TenXe"].Index].Value = row["TenXe"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["LoaiXe"].Index].Value = row["LoaiXe"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["DungTich"].Index].Value = row["DungTich"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["HangSanXuat"].Index].Value = row["HangSanXuat"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["MauSac"].Index].Value = row["MauSac"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["GiaBan"].Index].Value = row["GiaBan"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["SoLuong"].Index].Value = row["SoLuong"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["DonViTinh"].Index].Value = row["DonViTinh"].ToString();
                    dgvRow.Cells[dgvQLHD.Columns["ThanhTien"].Index].Value = row["ThanhTien"].ToString();

                    dgvQLHD.Rows.Add(dgvRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị danh sách hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_Sale_Load(object sender, EventArgs e)
        {
            HienDanhSachHoaDon();
            ClearFields();
        }

        private void txtMaXe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtMaXe, "Chỉ được nhập chữ và số!");
                MessageBox.Show("Vui lòng chỉ nhập chữ và số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtMaXe, "");
            }
        }

        private void txtTenXe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTenXe, "Chỉ được nhập chữ và số!");
                MessageBox.Show("Vui lòng chỉ nhập chữ và số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtTenXe, "");
            }
        }

        private void txtLoaiXe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtLoaiXe, "Chỉ được nhập chữ và số!");
                MessageBox.Show("Vui lòng chỉ nhập chữ và số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtLoaiXe, "");
            }
        }

        private void txtMauSac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtMauSac, "Chỉ được nhập chữ!");
                MessageBox.Show("Vui lòng chỉ nhập chữ vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtMauSac, "");
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSoLuong, "Chỉ được nhập số!");
                MessageBox.Show("Vui lòng chỉ được nhập số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtSoLuong, "");
            }
        }

     

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtGiaBan, "Chỉ được nhập số!");
                MessageBox.Show("Vui lòng chỉ được nhập số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtGiaBan, "");
            }
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtMaKH, "Chỉ được nhập chữ và số!");
                MessageBox.Show("Vui lòng chỉ nhập chữ và số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtMaKH, "");
            }
        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtTenKH, "Chỉ được nhập chữ và số!");
                MessageBox.Show("Vui lòng chỉ nhập chữ và số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtTenKH, "");
            }
        }

        private void txtSoCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSoCCCD, "Chỉ được nhập số!");
                MessageBox.Show("Vui lòng chỉ được nhập số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtSoCCCD, "");
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtSDT, "Chỉ được nhập số!");
                MessageBox.Show("Vui lòng chỉ được nhập số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }
        }

        private void dgvQLHD_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvQLHD.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvQLHD.SelectedRows[0];
                    // Điền thông tin hóa đơn vào các TextBox
                    txtMaHD.Text = row.Cells["MaHD"].Value.ToString().Trim();

                    // Xử lý NgayLap kiểu DateTime
                    if (row.Cells["NgayLap"].Value != null && row.Cells["NgayLap"].Value != DBNull.Value)
                    {
                        string ngayLapStr = row.Cells["NgayLap"].Value.ToString();
                        DateTime ngayLap;
                        // Thử chuyển đổi giá trị ngày với định dạng cụ thể
                        if (DateTime.TryParseExact(ngayLapStr, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out ngayLap) ||
                            DateTime.TryParse(ngayLapStr, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out ngayLap))
                        {
                            dtNgayLap.Value = ngayLap; // Gán trực tiếp vào Value thay vì Text
                        }
                        else
                        {
                            MessageBox.Show("Giá trị ngày lập hóa đơn không hợp lệ: " + ngayLapStr + ". Đặt mặc định là ngày hiện tại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dtNgayLap.Value = DateTime.Today; // Đặt giá trị mặc định là ngày hiện tại
                        }
                    }
                    else
                    {
                        dtNgayLap.Value = DateTime.Today; // Đặt giá trị mặc định nếu dữ liệu trống
                    }
                    txtMaKH.Text = row.Cells["MaKH"].Value.ToString().Trim();
                    txtTenKH.Text = row.Cells["TenKH"].Value.ToString().Trim();
                    string gioiTinh = row.Cells["GioiTinh"].Value?.ToString()?.Trim();
                    if (gioiTinh == "Nam")
                    {
                        rbNam.Checked = true;
                        rbNu.Checked = false;
                    }
                    else if (gioiTinh == "Nu")
                    {
                        rbNu.Checked = true;
                        rbNam.Checked = false;
                    }

                    txtSoCCCD.Text = row.Cells["CCCD"].Value.ToString().Trim();
                    txtDiachi.Text = row.Cells["DiaChi"].Value.ToString().Trim();
                    txtSDT.Text = row.Cells["SoDT"].Value.ToString().Trim();
                    txtMaXe.Text = row.Cells["MaXe"].Value.ToString().Trim();
                    txtTenXe.Text = row.Cells["TenXe"].Value.ToString().Trim();
                    txtLoaiXe.Text = row.Cells["LoaiXe"].Value.ToString().Trim();
                    txtDungTich.Text = row.Cells["DungTich"].Value.ToString().Trim();
                    txtHangSanXuat.Text = row.Cells["HangSanXuat"].Value.ToString().Trim();
                    txtMauSac.Text = row.Cells["MauSac"].Value.ToString().Trim();
                    txtGiaBan.Text = row.Cells["GiaBan"].Value.ToString().Trim();
                    txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString().Trim();
                    txtDonViTinh.Text = row.Cells["DonViTinh"].Value.ToString().Trim();
                    txtThanhTien.Text = row.Cells["ThanhTien"].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienDanhSachHoaDon();
            ClearFields();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu nhập vào có đầy đủ hay không
                if (string.IsNullOrWhiteSpace(txtMaHD.Text) ||
                    string.IsNullOrWhiteSpace(txtMaKH.Text) ||
                    string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                    (!rbNam.Checked && !rbNu.Checked) ||
                    string.IsNullOrWhiteSpace(txtSoCCCD.Text) ||
                    string.IsNullOrWhiteSpace(txtDiachi.Text) ||
                    string.IsNullOrWhiteSpace(txtSDT.Text) ||
                    string.IsNullOrWhiteSpace(txtMaXe.Text) ||
                    string.IsNullOrWhiteSpace(txtTenXe.Text) ||
                    string.IsNullOrWhiteSpace(txtLoaiXe.Text) ||
                    string.IsNullOrWhiteSpace(txtDungTich.Text) ||
                    string.IsNullOrWhiteSpace(txtHangSanXuat.Text) ||
                    string.IsNullOrWhiteSpace(txtMauSac.Text) ||
                    string.IsNullOrWhiteSpace(txtGiaBan.Text) ||
                    string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                    string.IsNullOrWhiteSpace(txtDonViTinh.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra mã hóa đơn có bị trùng không
                foreach (DataGridViewRow row in dgvQLHD.Rows)
                {
                    if (row.Cells["MaHD"].Value != null &&
                        row.Cells["MaHD"].Value.ToString().Trim().ToUpper() == txtMaHD.Text.Trim().ToUpper())
                    {
                        MessageBox.Show("Mã hóa đơn đã tồn tại!", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Lấy thông tin từ các ô nhập
                string maHD = txtMaHD.Text.Trim();
                DateTime ngayLap = dtNgayLap.Value; // <-- sử dụng DateTimePicker
                string maKH = txtMaKH.Text.Trim();
                string tenKH = txtTenKH.Text.Trim();
                string gioiTinh = rbNam.Checked ? "Nam" : "Nu";
                string cccd = txtSoCCCD.Text.Trim();
                string diaChi = txtDiachi.Text.Trim();
                string soDT = txtSDT.Text.Trim();
                string maXe = txtMaXe.Text.Trim();
                string tenXe = txtTenXe.Text.Trim();
                string loaiXe = txtLoaiXe.Text.Trim();
                string dungTich = txtDungTich.Text.Trim();
                string hangSX = txtHangSanXuat.Text.Trim();
                string mauSac = txtMauSac.Text.Trim();
                decimal giaBan = decimal.Parse(txtGiaBan.Text.Trim());
                string soLuong = txtSoLuong.Text.Trim();
                string donViTinh = txtDonViTinh.Text.Trim();
                qlhd.ThemHD(maHD, ngayLap, maKH, tenKH, gioiTinh, cccd, diaChi, soDT, maXe, tenXe, loaiXe, dungTich, hangSX, mauSac, giaBan, int.Parse(soLuong), donViTinh);

                ClearFields();

                MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienDanhSachHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtMaHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtMaHD, "Chỉ được nhập chữ và số!");
                MessageBox.Show("Vui lòng chỉ nhập chữ và số vào đây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                errorProvider1.SetError(txtMaHD, "");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaHD.Text) ||
                    string.IsNullOrWhiteSpace(txtMaKH.Text) ||
                    string.IsNullOrWhiteSpace(txtTenKH.Text) ||
                    string.IsNullOrWhiteSpace(txtSoCCCD.Text) ||
                    string.IsNullOrWhiteSpace(txtDiachi.Text) ||
                    string.IsNullOrWhiteSpace(txtSDT.Text) ||
                    string.IsNullOrWhiteSpace(txtMaXe.Text) ||
                    string.IsNullOrWhiteSpace(txtTenXe.Text) ||
                    string.IsNullOrWhiteSpace(txtLoaiXe.Text) ||
                    string.IsNullOrWhiteSpace(txtDungTich.Text) ||
                    string.IsNullOrWhiteSpace(txtHangSanXuat.Text) ||
                    string.IsNullOrWhiteSpace(txtMauSac.Text) ||
                    string.IsNullOrWhiteSpace(txtGiaBan.Text) ||
                    string.IsNullOrWhiteSpace(txtSoLuong.Text) ||
                    string.IsNullOrWhiteSpace(txtDonViTinh.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maHD = txtMaHD.Text.Trim();
                DateTime ngayLap = dtNgayLap.Value; // datetimepicker
                string maKH = txtMaKH.Text.Trim();
                string tenKH = txtTenKH.Text.Trim();
                string gioiTinh = rbNam.Checked ? "Nam" : "Nu";
                string cccd = txtSoCCCD.Text.Trim();
                string diaChi = txtDiachi.Text.Trim();
                string soDT = txtSDT.Text.Trim();
                string maXe = txtMaXe.Text.Trim();
                string tenXe = txtTenXe.Text.Trim();
                string loaiXe = txtLoaiXe.Text.Trim();
                string dungTich = txtDungTich.Text.Trim();
                string hangSanXuat = txtHangSanXuat.Text.Trim();
                string mauSac = txtMauSac.Text.Trim();
                decimal giaBan = decimal.Parse(txtGiaBan.Text.Trim());
                int soLuong = int.Parse(txtSoLuong.Text.Trim());
                string donViTinh=txtDonViTinh.Text.Trim();

                

                qlhd.SuaHoaDon(maHD, ngayLap, maKH, tenKH, gioiTinh, cccd, diaChi, soDT,
                               maXe, tenXe, loaiXe, dungTich, hangSanXuat, mauSac,
                               giaBan, soLuong, donViTinh);

                ClearFields(); // Xóa dữ liệu nhập
                MessageBox.Show("Sửa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienDanhSachHoaDon(); // Cập nhật lại lưới
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvQLHD.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataGridViewRow row = dgvQLHD.SelectedRows[0];
                        string maHD = row.Cells["MaHD"].Value.ToString();
                        qlhd.XoaHD(maHD);
                        HienDanhSachHoaDon();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hóa đơn để xóa!", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }
    }
}
