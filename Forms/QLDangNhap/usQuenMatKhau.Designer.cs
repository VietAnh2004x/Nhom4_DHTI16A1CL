using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLDangNhap
{
    public partial class usQuenMatKhau : Form
    {
        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblNewPass;
        private TextBox txtNewPass;
        private Label lblConfirmPass;
        private TextBox txtConfirmPass;
        private Button btnUpdate;

        private void InitializeComponent()
        {
            // Cài đặt form
            this.Text = "Quên mật khẩu";
            this.Size = new Size(400, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.White;

            // Tiêu đề
            lblTitle = new Label();
            lblTitle.Text = "KHÔI PHỤC MẬT KHẨU";
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 123, 255);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(85, 30);
            this.Controls.Add(lblTitle);

            // Label Tên đăng nhập
            lblUsername = new Label();
            lblUsername.Text = "Tên đăng nhập:";
            lblUsername.Location = new Point(50, 90);
            lblUsername.AutoSize = true;
            this.Controls.Add(lblUsername);

            txtUsername = new TextBox();
            txtUsername.Location = new Point(50, 115);
            txtUsername.Width = 300;
            this.Controls.Add(txtUsername);

            // Label mật khẩu mới
            lblNewPass = new Label();
            lblNewPass.Text = "Mật khẩu mới:";
            lblNewPass.Location = new Point(50, 160);
            lblNewPass.AutoSize = true;
            this.Controls.Add(lblNewPass);

            txtNewPass = new TextBox();
            txtNewPass.Location = new Point(50, 185);
            txtNewPass.Width = 300;
            txtNewPass.UseSystemPasswordChar = true;
            this.Controls.Add(txtNewPass);

            // Label nhập lại mật khẩu
            lblConfirmPass = new Label();
            lblConfirmPass.Text = "Nhập lại mật khẩu:";
            lblConfirmPass.Location = new Point(50, 230);
            lblConfirmPass.AutoSize = true;
            this.Controls.Add(lblConfirmPass);

            txtConfirmPass = new TextBox();
            txtConfirmPass.Location = new Point(50, 255);
            txtConfirmPass.Width = 300;
            txtConfirmPass.UseSystemPasswordChar = true;
            this.Controls.Add(txtConfirmPass);

            // Nút cập nhật mật khẩu
            btnUpdate = new Button();
            btnUpdate.Text = "Cập nhật mật khẩu";
            btnUpdate.BackColor = Color.FromArgb(0, 123, 255);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnUpdate.Location = new Point(50, 300);
            btnUpdate.Size = new Size(300, 40);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Click += BtnUpdate_Click;
            this.Controls.Add(btnUpdate);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string newPass = txtNewPass.Text;
            string confirmPass = txtConfirmPass.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Giả lập cập nhật thành công (thực tế có thể cập nhật vào DB)
            MessageBox.Show("Cập nhật mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); // Đóng form quên mật khẩu → quay lại form đăng nhập
        }
    }
}