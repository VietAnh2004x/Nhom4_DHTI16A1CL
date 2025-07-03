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
        private Panel panelContent;
        private Button btnQLXe;
        private Button btnQLXeMayDien;
        private Button btnQLXeDapDien;
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1236, 673);
            this.panelContent.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 673);
            this.Controls.Add(this.panelContent);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Quản lí kinh doanh cửa hàng";
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
            btnQLXe = CreateButton("Quản Lý Xe");
            btnQLXe.Click += BtnQLXe_Click;

            // Submenu panel
            subMenuPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 0,
                Visible = false
            };

            btnQLXeMayDien = CreateButton("   Xe Máy Điện", 35);
            btnQLXeMayDien.Click += btnQLXeMayDien_Click;
            btnQLXeDapDien = CreateButton("   Xe Đạp Điện", 35);
            btnQLXeDapDien.Click += btnQLXeDapDien_Click;

            // Thêm sub button theo thứ tự thủ công (sub2 trên cùng)
            subMenuPanel.Controls.Add(btnQLXeMayDien);
            subMenuPanel.Controls.Add(btnQLXeDapDien);
            

            // Các nút còn lại

            btnTongQuan = CreateButton("Tổng Quan");
            btnTongQuan.Click += btnTongQuanForm_Click;
            btnQLKhachHang = CreateButton("Quản Lý Khách Hàng");
            btnQLKhachHang.Click += btnQLKhachHang_Click;
            btnQLTonKho = CreateButton("Quản Lý Tồn Kho");
            btnQLHoaDon = CreateButton("Quản Lý Hóa Đơn");
            btnQLBaoHanh = CreateButton("Quản Lý Bảo Hành");
            btnBaoCao = CreateButton("Báo Cáo");
            btnQLDaiLy = CreateButton("Quản Lý Đại Lý");
            btnQLTaiKhoan = CreateButton("Quản Lý Tài Khoản");
            btnDangXuat = CreateButton("Đăng Xuất");

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