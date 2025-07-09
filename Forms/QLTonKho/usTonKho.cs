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

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLTonKho
{
    public partial class usTonKho : UserControl
    {
        public usTonKho()
        {
            InitializeComponent();
            colMaNhap.DataPropertyName = "MaNhap";
            colMaXe.DataPropertyName = "MaXe";
            colTenXe.DataPropertyName = "TenXe";
            colNgayNhap.DataPropertyName = "NgayNhap";
            colSoLuong.DataPropertyName = "SoLuong";
            this.Load += usTonKho_load;

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
        private void usTonKho_load(object sender, EventArgs e)
        {
            loadtableTonKho();

        }
        private void loadtableTonKho()
        {

            string query = "select t.*, x.TenXe from TonXe t join Xe x on x.MaXe=t.MaXe";

            dt.Clear();
            dt = DataProvider.loadcsdl(query);
            dgvDSTonKho.AutoGenerateColumns = false;
            dgvDSTonKho.RowHeadersVisible = false;
            dgvDSTonKho.DataSource = dt;

        }

        private void dgvDSTonKho_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var dongduocchon = dgvDSTonKho.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                txtTenXe.Text = dongduocchon.Cells["colTenXe"].Value.ToString();
                txtNgayNhap.Text = Convert.ToDateTime(dongduocchon.Cells["colNgayNhap"].Value).ToString("dd/MM/yyyy");
                txtSoLuong.Text = dongduocchon.Cells["colSoLuong"].Value.ToString();
            }
            Enable(new List<Control> { txtTenXe, txtNgayNhap, txtSoLuong });
        }
    }
}
