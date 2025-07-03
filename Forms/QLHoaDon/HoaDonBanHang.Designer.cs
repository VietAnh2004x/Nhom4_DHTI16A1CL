using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLHoaDon
{
    public class FormPhieuBanHang : Form
    {
        // Khai báo các controls
        TextBox txtKhachHang, txtDienThoai, txtDiaChi, txtThoiGianGiao, txtGhiChu;
        TextBox txtTongTien, txtDatCoc, txtConLai, txtNhanVien;
        DataGridView dgvSanPham;

        public FormPhieuBanHang()
        {
            this.Text = "Phiếu Bán Hàng";
            this.Size = new Size(950, 750);
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeControls();
        }

        private void InitializeControls()
        {
            int marginLeft = 20;

            // --- Thông tin khách hàng ---
            Label lblKhachHang = new Label() { Text = "Khách hàng:", Location = new Point(marginLeft, 20), AutoSize = true };
            txtKhachHang = new TextBox() { Location = new Point(120, 20), Width = 250 };

            Label lblDienThoai = new Label() { Text = "Điện thoại:", Location = new Point(400, 20), AutoSize = true };
            txtDienThoai = new TextBox() { Location = new Point(480, 20), Width = 200 };

            Label lblDiaChi = new Label() { Text = "Địa chỉ giao hàng:", Location = new Point(marginLeft, 60), AutoSize = true };
            txtDiaChi = new TextBox() { Location = new Point(150, 60), Width = 530 };

            Label lblThoiGian = new Label() { Text = "Thời gian giao:", Location = new Point(marginLeft, 100), AutoSize = true };
            txtThoiGianGiao = new TextBox() { Location = new Point(150, 100), Width = 530 };

            Label lblGhiChu = new Label() { Text = "Ghi chú:", Location = new Point(marginLeft, 140), AutoSize = true };
            txtGhiChu = new TextBox() { Location = new Point(150, 140), Width = 530, Height = 40, Multiline = true };

            this.Controls.AddRange(new Control[] {
                lblKhachHang, txtKhachHang, lblDienThoai, txtDienThoai,
                lblDiaChi, txtDiaChi, lblThoiGian, txtThoiGianGiao,
                lblGhiChu, txtGhiChu
            });

            // --- DataGridView ---
            dgvSanPham = new DataGridView()
            {
                Location = new Point(marginLeft, 200),
                Size = new Size(890, 250),
                AllowUserToAddRows = true,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            dgvSanPham.Columns.Add("STT", "STT");
            dgvSanPham.Columns.Add("TenHang", "Tên hàng");
            dgvSanPham.Columns.Add("MaHang", "Mã hàng");
            dgvSanPham.Columns.Add("SL", "Số lượng");
            dgvSanPham.Columns.Add("Kho", "Kho");
            dgvSanPham.Columns.Add("GiaBan", "Giá bán");
            dgvSanPham.Columns.Add("ThanhTien", "Thành tiền");

            dgvSanPham.CellValueChanged += DgvSanPham_CellValueChanged;
            dgvSanPham.EditingControlShowing += DgvSanPham_EditingControlShowing;

            this.Controls.Add(dgvSanPham);

            // --- Tính tiền ---
            Label lblTong = new Label() { Text = "Tổng giá trị:", Location = new Point(marginLeft, 470) };
            txtTongTien = new TextBox() { Location = new Point(150, 470), Width = 150, ReadOnly = true };

            Label lblDatCoc = new Label() { Text = "Đã thanh toán / Đặt cọc:", Location = new Point(marginLeft, 510) };
            txtDatCoc = new TextBox() { Location = new Point(220, 510), Width = 150 };
            txtDatCoc.TextChanged += TxtDatCoc_TextChanged;

            Label lblConLai = new Label() { Text = "Còn phải thanh toán:", Location = new Point(marginLeft, 550) };
            txtConLai = new TextBox() { Location = new Point(220, 550), Width = 150, ReadOnly = true };

            Label lblNhanVien = new Label() { Text = "Nhân viên bán hàng:", Location = new Point(marginLeft, 590) };
            txtNhanVien = new TextBox() { Location = new Point(180, 590), Width = 200 };

            this.Controls.AddRange(new Control[] {
                lblTong, txtTongTien, lblDatCoc, txtDatCoc,
                lblConLai, txtConLai, lblNhanVien, txtNhanVien
            });
        }

        private void DgvSanPham_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.TextChanged -= Cell_TextChanged;
            if (dgvSanPham.CurrentCell.ColumnIndex == 3 || dgvSanPham.CurrentCell.ColumnIndex == 5) // SL hoặc Giá
            {
                e.Control.TextChanged += Cell_TextChanged;
            }
        }

        private void Cell_TextChanged(object sender, EventArgs e)
        {
            TinhLaiThanhTien();
        }

        private void DgvSanPham_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == 3 || e.ColumnIndex == 5))
            {
                TinhLaiThanhTien();
            }
        }

        private void TinhLaiThanhTien()
        {
            for (int i = 0; i < dgvSanPham.Rows.Count; i++)
            {
                try
                {
                    var row = dgvSanPham.Rows[i];
                    int sl = Convert.ToInt32(row.Cells["SL"].Value);
                    decimal gia = Convert.ToDecimal(row.Cells["GiaBan"].Value);
                    row.Cells["ThanhTien"].Value = sl * gia;
                }
                catch { }
            }

            decimal tong = 0;
            foreach (DataGridViewRow row in dgvSanPham.Rows)
            {
                if (row.Cells["ThanhTien"].Value != null)
                {
                    decimal thanhTien;
                    if (decimal.TryParse(row.Cells["ThanhTien"].Value.ToString(), out thanhTien))
                        tong += thanhTien;
                }
            }

            txtTongTien.Text = tong.ToString("N0");
            CapNhatConLai();
        }

        private void TxtDatCoc_TextChanged(object sender, EventArgs e)
        {
            CapNhatConLai();
        }

        private void CapNhatConLai()
        {
            decimal tong = 0, datcoc = 0;
            decimal.TryParse(txtTongTien.Text, out tong);
            decimal.TryParse(txtDatCoc.Text, out datcoc);
            txtConLai.Text = (tong - datcoc).ToString("N0");
        }
    }
}