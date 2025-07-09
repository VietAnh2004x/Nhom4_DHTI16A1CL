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

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLDaiLy
{
    public partial class usDaiLy : UserControl
    {
        public usDaiLy()
        {
            InitializeComponent();
            colTenDaiLy.DataPropertyName = "TenDaiLy";
            colMaDaiLy.DataPropertyName = "MaDaiLy";
            colDiaChi.DataPropertyName = "DiaChi";
            colSoDienThoai.DataPropertyName = "SoDienThoai";
            colEmail.DataPropertyName = "Email";
            this.Load += usDaiLy_load;
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
        private void usDaiLy_load(object sender, EventArgs e)
        {
            loadtableDaiLy();

        }
        private void loadtableDaiLy()
        {

            string query = "select * from DaiLy";

            dt.Clear();
            dt = DataProvider.loadcsdl(query);
            dgvDSDaiLy.AutoGenerateColumns = false;
            dgvDSDaiLy.RowHeadersVisible = false;
            dgvDSDaiLy.DataSource = dt;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemPhieuDaiLy phieuDaiLyForm = new frmThemPhieuDaiLy();
            if (phieuDaiLyForm.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Thêm đại lý thành công!");
            else
                MessageBox.Show("Thêm đại lý thất bại!");
        }

        private void dgvDSDaiLy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dongduocchon = dgvDSDaiLy.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
               txtTenDaiLy.Text = dongduocchon.Cells["colTenDaiLy"].Value.ToString();
                txtDiaChi.Text = dongduocchon.Cells["colDiaChi"].Value.ToString();
                txtSoDienThoai.Text = dongduocchon.Cells["colSoDienThoai"].Value.ToString();
                txtEmail.Text = dongduocchon.Cells["colEmail"].Value.ToString();
            }
            Enable(new List<Control> { txtTenDaiLy,txtEmail,txtDiaChi,txtSoDienThoai });
        }
    }
}
