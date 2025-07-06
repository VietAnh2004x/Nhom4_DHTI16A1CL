using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DoAn1_Nhom4_DHTI16A1CL;
namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLDangNhap
{
    public partial class usDangNhap : Form
    {
        private PictureBox picLogo;
        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel linkRegister;
        private LinkLabel linkForgot;


        private void InitializeComponent()
        {
            // Cài đặt form
            this.Text = "Đăng nhập";
            this.Size = new Size(400, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.White;

            // Logo
            picLogo = new PictureBox();
            picLogo.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Resources", "image", "logo.png")); // Hãy chắc logo.jpg có trong bin\Debug hoặc đường dẫn đúng
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.Location = new Point(130, 20);
            picLogo.Size = new Size(120, 120);
            this.Controls.Add(picLogo);

            // Tiêu đề
            lblTitle = new Label();
            lblTitle.Text = "ĐĂNG NHẬP";
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 123, 255);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(135, 150);
            this.Controls.Add(lblTitle);

            // Label Tên đăng nhập
            lblUsername = new Label();
            lblUsername.Text = "Tên đăng nhập:";
            lblUsername.Location = new Point(50, 200);
            lblUsername.AutoSize = true;
            this.Controls.Add(lblUsername);

            // TextBox Tên đăng nhập
            txtUsername = new TextBox();
            txtUsername.Location = new Point(50, 225);
            txtUsername.Width = 300;
            this.Controls.Add(txtUsername);

            // Label Mật khẩu
            lblPassword = new Label();
            lblPassword.Text = "Mật khẩu:";
            lblPassword.Location = new Point(50, 270);
            lblPassword.AutoSize = true;
            this.Controls.Add(lblPassword);

            // TextBox Mật khẩu
            txtPassword = new TextBox();
            txtPassword.Location = new Point(50, 295);
            txtPassword.Width = 300;
            txtPassword.UseSystemPasswordChar = true;
            this.Controls.Add(txtPassword);

            // Nút Đăng nhập
            btnLogin = new Button();
            btnLogin.Text = "Đăng nhập";
            btnLogin.BackColor = Color.FromArgb(0, 123, 255);
            btnLogin.ForeColor = Color.White;
            btnLogin.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnLogin.Location = new Point(50, 340);
            btnLogin.Size = new Size(300, 40);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Click += BtnLogin_Click;
            this.Controls.Add(btnLogin);

            // Link Quên mật khẩu
            linkForgot = new LinkLabel();
            linkForgot.Text = "Quên mật khẩu?";
            linkForgot.Location = new Point(260, 400);
            linkForgot.AutoSize = true;
            linkForgot.Click += LinkForgot_Click;
            this.Controls.Add(linkForgot);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text;

            if (user == "admin" && pass == "123")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");

                // Ẩn form đăng nhập
                this.Hide();

                // Mở MainForm (đang test, ko khuyến khích dùng cách này vì dễ rối)
                DoAn1_Nhom4_DHTI16A1CL.Forms.MainForm.MainForm form = new DoAn1_Nhom4_DHTI16A1CL.Forms.MainForm.MainForm();
                form.FormClosed += (s, args) => this.Close(); // Đóng form chính thì thoát toàn bộ
                form.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LinkForgot_Click(object sender, EventArgs e)
        {
            usQuenMatKhau forgotForm = new usQuenMatKhau();
            forgotForm.ShowDialog(); // Hiển thị form quên mật khẩu dưới dạng dialog
        }
    }
}