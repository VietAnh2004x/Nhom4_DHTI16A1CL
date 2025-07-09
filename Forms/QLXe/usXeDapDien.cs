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

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLXe
{
    public partial class usXeDapDien : UserControl
    {
        public usXeDapDien()
        {
            InitializeComponent();
            colMaXeDapDien.DataPropertyName = "MaXe";
            colTenXe.DataPropertyName = "TenXe";
            colMaDaiLy.DataPropertyName = "MaDaiLy";
            colMauSac.DataPropertyName = "MauSac";
            colSoBinhAcQuy.DataPropertyName = "SoBinhAcQuy";
            colDungLuongAcQuy.DataPropertyName = "DungLuongAcQuy";
            colGia.DataPropertyName = "GiaNhap";
            colHinhAnh.DataPropertyName = "HinhAnh";
            this.Load += usXeDapDien_load;
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
        private void usXeDapDien_load(object sender, EventArgs e)
        {
            loadtableXeDapDien();

        }
        private void loadtableXeDapDien()
        {

            string query = "select * from Xe where MaDongXe=2";

            dt.Clear();
            dt = DataProvider.loadcsdl(query);
            dgvDSXeDapDien.AutoGenerateColumns = false;
            dgvDSXeDapDien.RowHeadersVisible = false;
            dgvDSXeDapDien.DataSource = dt;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmPhieuThemXe phieuThemXeForm = new frmPhieuThemXe();
            if (phieuThemXeForm.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Thêm xe đạp điện thành công!");
            else
                MessageBox.Show("Thêm xe đạp điện thất bại!");
        }

        private void dgvDSXeDapDien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                var dongduocchon = dgvDSXeDapDien.Rows[e.RowIndex];
                DataGridViewRow row = dgvDSXeDapDien.Rows[e.RowIndex];

                txtMauSac.Text = dongduocchon.Cells["colMauSac"].Value?.ToString();
                txtTenXe.Text = dongduocchon.Cells["colTenXe"].Value?.ToString();
                txtGia.Text = dongduocchon.Cells["colGia"].Value?.ToString();
                txtSoBinhAcQuy.Text = dongduocchon.Cells["colSoBinhAcQuy"].Value?.ToString();
                txtDungLuongAcQuy.Text = dongduocchon.Cells["colDungLuongAcQuy"].Value?.ToString();

                Enable(new List<Control> { txtMauSac, txtTenXe, txtGia, txtSoBinhAcQuy, txtDungLuongAcQuy });
                string hinhAnh = row.Cells["colHinhAnh"].Value?.ToString();

                if (!string.IsNullOrEmpty(hinhAnh))
                {
                    try
                    {
                        if (hinhAnh.StartsWith("http"))
                        {
                            // Ảnh online
                            System.Net.WebRequest request = System.Net.WebRequest.Create(hinhAnh);
                            using (var response = request.GetResponse())
                            using (var stream = response.GetResponseStream())
                            {
                                picAnhXe.Image = Image.FromStream(stream);
                                picAnhXe.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                        }
                        else if (System.IO.File.Exists(hinhAnh))
                        {
                            // Ảnh trong máy
                            picAnhXe.Image = Image.FromFile(hinhAnh);
                            picAnhXe.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        else
                        {
                            picAnhXe.Image = null;
                        }
                    }
                    catch
                    {
                        picAnhXe.Image = null;
                    }
                }
                else
                {
                    picAnhXe.Image = null;
                }
            }
        }
    }
}
