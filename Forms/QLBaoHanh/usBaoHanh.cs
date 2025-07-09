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

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLBaoHanh
{
    public partial class usBaoHanh : UserControl
    {
        public usBaoHanh()
        {
            InitializeComponent();
            colMaBaoHanh.DataPropertyName = "MaBH";
            colMaXe.DataPropertyName = "MaXe";
           colMaHoaDon.DataPropertyName = "MaHD";
            colNgayBatDau.DataPropertyName = "NgayBatDau";
            colThoiHan.DataPropertyName = "ThoiHanThang";
            this.Load += usBaoHanh_load;
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
        private void usBaoHanh_load(object sender, EventArgs e)
        {
            loadtableBaoHanh();

        }
        private void loadtableBaoHanh()
        {

            string query = "select * from BaoHanh";

            dt.Clear();
            dt = DataProvider.loadcsdl(query);
            dgvDSBaoHanh.AutoGenerateColumns = false;
            dgvDSBaoHanh.RowHeadersVisible = false;
            dgvDSBaoHanh.DataSource = dt;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhieuBaoHanh phieuBaoHanhForm = new frmPhieuBaoHanh();
            if (phieuBaoHanhForm.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Thêm phiếu bảo hành thành công!");
            else
                MessageBox.Show("Thêm phiếu bảo hành thất bại!");
        }

        private void dgvDSBaoHanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var dongduocchon = dgvDSBaoHanh.Rows[e.RowIndex];

                txtMaHoaDon.Text = dongduocchon.Cells["colMaHoaDon"].Value?.ToString() ?? "";
                txtMaBaoHanh.Text = dongduocchon.Cells["colMaBaoHanh"].Value?.ToString() ?? "";
                txtMaXe.Text = dongduocchon.Cells["colMaXe"].Value?.ToString() ?? "";

                var ngayBatDauValue = dongduocchon.Cells["colNgayBatDau"].Value;
                if (ngayBatDauValue != null && DateTime.TryParse(ngayBatDauValue.ToString(), out DateTime ngayBatDau))
                {
                    txtNgayBatDau.Text = ngayBatDau.ToString("dd/MM/yyyy");  // Hoặc định dạng bạn muốn
                }
                else
                {
                    txtNgayBatDau.Text = "";
                }

                txtThoiHan.Text = dongduocchon.Cells["colThoiHan"].Value?.ToString() ?? "";
            }
            Enable(new List<Control> { txtMaHoaDon, txtMaBaoHanh, txtMaXe, txtNgayBatDau, txtThoiHan });
        }


    }
}
