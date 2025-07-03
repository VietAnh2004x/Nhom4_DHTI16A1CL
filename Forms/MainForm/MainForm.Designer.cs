using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.MainForm
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel sidebar;
        private Panel logoPanel;
        private Button btnQLXe;
        private Button btnSub1;
        private Button btnSub2;
        private Panel subMenuPanel;
        private Button btnTongQuan;
        private Button btnQLKhachHang;
        private Button btnQLTonKho;
        private Button btnQLHoaDon;
        private Button btnQLBaoHanh;
        private Button btnBaoCao;
        private Button btnQLDaiLy;
        private Button btnQLTaiKhoan;
        private Button btnDangXuat;
        private bool subMenuVisible = false;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 644);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        private void InitializeSidebar()
        {
            // Sidebar chính
            sidebar = new Panel
            {
                BackColor = Color.FromArgb(30, 90, 160),
                Dock = DockStyle.Left,
                Width = 200
            };
            this.Controls.Add(sidebar);

            // Logo Panel
            logoPanel = new Panel
            {
                Height = 160,
                Dock = DockStyle.Top,
                BackColor = Color.White,
            };

            PictureBox pictureLogo = new PictureBox
            {
                Image = Image.FromFile(Path.Combine(Application.StartupPath, "Resources", "image", "logo.png")),
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Top,
                Height = 120,
            };

            Label lblLogo = new Label
            {
                Text = "Xin chào Vanh Vanh",
                ForeColor = Color.FromArgb(30, 90, 160),
                Font = new Font("Arial", 12, FontStyle.Bold),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Height = 30
            };

            logoPanel.Controls.Add(lblLogo);
            logoPanel.Controls.Add(pictureLogo);

            // Nút Quản lý linh kiện
            btnQLXe = CreateButton("Quản lý Xe");
            btnQLXe.Click += BtnQLXe_Click;

            // Submenu panel
            subMenuPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 0,
                Visible = false
            };

            btnSub1 = CreateButton("   Xe Đạp Điện", 35);
            btnSub2 = CreateButton("   Xe Máy Điện", 35);

            // Thêm sub button theo thứ tự thủ công (sub2 trên cùng)
            subMenuPanel.Controls.Add(btnSub2);
            subMenuPanel.Controls.Add(btnSub1);

            // Các nút còn lại

            btnTongQuan = CreateButton("Tổng quan");
            btnQLKhachHang = CreateButton("Quản lý khách hàng");
            btnQLTonKho = CreateButton("Quản lý tồn kho");
            btnQLHoaDon = CreateButton("Quản lý hóa đơn");
            btnQLBaoHanh = CreateButton("Quản lý bảo hành");
            btnBaoCao = CreateButton("Báo cáo");
            btnQLDaiLy = CreateButton("Quản lý đại lý");
            btnQLTaiKhoan = CreateButton("Quản lý tài khoản");
            btnDangXuat = CreateButton("Đăng xuất");

            // Thêm toàn bộ control vào sidebar theo đúng thứ tự (logo trên cùng)
            sidebar.Controls.AddRange(new Control[]
            {
                btnDangXuat,
                btnQLTaiKhoan,
                btnBaoCao,
                btnQLDaiLy,
                btnQLBaoHanh,
                btnQLHoaDon,
                btnQLTonKho,
                btnQLKhachHang,
                subMenuPanel,
                btnQLXe,
                btnTongQuan,
                logoPanel
            });
        }

        private Button CreateButton(string text, int paddingLeft = 10)
        {
            return new Button
            {
                Text = text,
                Dock = DockStyle.Top,
                Height = 40,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(paddingLeft, 0, 0, 0),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                BackColor = Color.FromArgb(30, 90, 160),
                FlatAppearance = { BorderSize = 0 },
                Font = new Font("Arial", 10, FontStyle.Regular)
            };
        }

        private void BtnQLXe_Click(object sender, EventArgs e)
        {
            subMenuVisible = !subMenuVisible;
            subMenuPanel.Visible = subMenuVisible;
            subMenuPanel.Height = subMenuVisible ? 80 : 0; // 2 buttons x 40 height
        }
    }
}