using DoAn1_Nhom4_DHTI16A1CL.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLHoaDon
{
    public partial class usHoaDon : UserControl
    {
        public usHoaDon()
        {
            InitializeComponent();
            colMaHoaDon.DataPropertyName = "MaHD";
            colTenXe.DataPropertyName = "TenXe";
            colTenKhachHang.DataPropertyName = "HoTen";
            colTenNhanVien.DataPropertyName = "HoTen";
            colNgayLap.DataPropertyName = "NgayLap";
            colTongTien.DataPropertyName = "TongTien";
            this.Load += usHoaDon_load;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhieuHoaDon frmPhieuHoaDon = new frmPhieuHoaDon();
            if (frmPhieuHoaDon.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Thêm hóa đơn thành công!");
            else
                MessageBox.Show("Thêm hóa đơn thất bại!");
        }
        DataTable dt = new DataTable();
        private void Enable(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                control.Enabled = true;
            }
        }
        private void UnEnable(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                control.Enabled = false;
            }
        }
        private void resetText(List<Control> controls)
        {
            foreach (var control in controls)
            {
                control.Text = "";
            }
        }
        private void usHoaDon_load(object sender, EventArgs e)
        {
            loadtableHoaDon();

        }
        private void loadtableHoaDon()
        {

            string query = "SELECT h.MaHD,h.TenDangNhap,kh.HoTen ,h.NgayLap,x.TenXe,h.TongTien FROM HoaDon h JOIN ChiTietHoaDon c ON h.MaHD = c.MaHD JOIN Xe x ON c.MaXe = x.MaXe JOIN KhachHang kh ON h.MaKH = kh.MaKH;";

            dt.Clear();
            dt = DataProvider.loadcsdl(query);
            dgvDSHoaDon.AutoGenerateColumns = false;
            dgvDSHoaDon.RowHeadersVisible = false;
            dgvDSHoaDon.DataSource = dt;

        }

        private void dgvDSHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dongduocchon = dgvDSHoaDon.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                txtMaHoaDon.Text = dongduocchon.Cells["colMaHoaDon"].Value.ToString();
                txtTenXe.Text = dongduocchon.Cells["colTenXe"].Value.ToString();
                txtTenKhachHang.Text = dongduocchon.Cells["colTenKhachHang"].Value.ToString();
                txtTenDangNhap.Text = dongduocchon.Cells["colTenNhanVien"].Value.ToString();
                txtNgayLap.Text = dongduocchon.Cells["colNgayLap"].Value.ToString();
                txtTongTien.Text = dongduocchon.Cells["colTongTien"].Value.ToString();
            }
            Enable(new List<Control> { txtTongTien, txtMaHoaDon,  txtTenKhachHang, txtTenDangNhap, txtNgayLap });
        }

       
    }
}
