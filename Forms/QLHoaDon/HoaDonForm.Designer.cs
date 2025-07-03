using System.Drawing;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLHoaDon
{
    partial class HoaDonForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tbTong;
        private System.Windows.Forms.TableLayoutPanel grpTTHoaDon;
        private System.Windows.Forms.TableLayoutPanel tbTrai;
        private System.Windows.Forms.TableLayoutPanel tbPhai;
        private System.Windows.Forms.GroupBox grTTDaiLy;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpTacVu;
        private System.Windows.Forms.GroupBox grpTimKiemHoaDon;
        private System.Windows.Forms.GroupBox grDSHoaDon;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTimKiemHoaDon;
        private System.Windows.Forms.Label lblTimKiemHoaDon;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvDSDaiLy;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTong = new System.Windows.Forms.TableLayoutPanel();
            this.grpTTHoaDon = new System.Windows.Forms.TableLayoutPanel();
            this.tbTrai = new System.Windows.Forms.TableLayoutPanel();
            this.grTTDaiLy = new System.Windows.Forms.GroupBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.grpTacVu = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbPhai = new System.Windows.Forms.TableLayoutPanel();
            this.grpTimKiemHoaDon = new System.Windows.Forms.GroupBox();
            this.txtTimKiemHoaDon = new System.Windows.Forms.TextBox();
            this.lblTimKiemHoaDon = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grDSHoaDon = new System.Windows.Forms.GroupBox();
            this.dgvDSDaiLy = new System.Windows.Forms.DataGridView();
            this.colMaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tbTong.SuspendLayout();
            this.grpTTHoaDon.SuspendLayout();
            this.tbTrai.SuspendLayout();
            this.grTTDaiLy.SuspendLayout();
            this.grpTacVu.SuspendLayout();
            this.tbPhai.SuspendLayout();
            this.grpTimKiemHoaDon.SuspendLayout();
            this.grDSHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDaiLy)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.tbTong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 633);
            this.panel1.TabIndex = 0;
            // 
            // tbTong
            // 
            this.tbTong.ColumnCount = 1;
            this.tbTong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbTong.Controls.Add(this.grpTTHoaDon, 0, 1);
            this.tbTong.Controls.Add(this.lblTieuDe, 0, 0);
            this.tbTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTong.Location = new System.Drawing.Point(0, 0);
            this.tbTong.Name = "tbTong";
            this.tbTong.RowCount = 2;
            this.tbTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tbTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tbTong.Size = new System.Drawing.Size(905, 633);
            this.tbTong.TabIndex = 0;
            // 
            // grpTTHoaDon
            // 
            this.grpTTHoaDon.ColumnCount = 2;
            this.grpTTHoaDon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.grpTTHoaDon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.grpTTHoaDon.Controls.Add(this.tbTrai, 0, 0);
            this.grpTTHoaDon.Controls.Add(this.tbPhai, 1, 0);
            this.grpTTHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTTHoaDon.Location = new System.Drawing.Point(3, 97);
            this.grpTTHoaDon.Name = "grpTTHoaDon";
            this.grpTTHoaDon.RowCount = 1;
            this.grpTTHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 533F));
            this.grpTTHoaDon.Size = new System.Drawing.Size(899, 533);
            this.grpTTHoaDon.TabIndex = 0;
            // 
            // tbTrai
            // 
            this.tbTrai.ColumnCount = 1;
            this.tbTrai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 353F));
            this.tbTrai.Controls.Add(this.grTTDaiLy, 0, 0);
            this.tbTrai.Controls.Add(this.grpTacVu, 0, 1);
            this.tbTrai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTrai.Location = new System.Drawing.Point(3, 3);
            this.tbTrai.Name = "tbTrai";
            this.tbTrai.RowCount = 2;
            this.tbTrai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tbTrai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTrai.Size = new System.Drawing.Size(353, 527);
            this.tbTrai.TabIndex = 0;
            // 
            // grTTDaiLy
            // 
            this.grTTDaiLy.Controls.Add(this.txtTongTien);
            this.grTTDaiLy.Controls.Add(this.txtNgayLap);
            this.grTTDaiLy.Controls.Add(this.txtMaKhach);
            this.grTTDaiLy.Controls.Add(this.txtTenDangNhap);
            this.grTTDaiLy.Controls.Add(this.txtMaHoaDon);
            this.grTTDaiLy.Controls.Add(this.lblTongTien);
            this.grTTDaiLy.Controls.Add(this.lblNgayLap);
            this.grTTDaiLy.Controls.Add(this.lblTenDangNhap);
            this.grTTDaiLy.Controls.Add(this.lblMaKhachHang);
            this.grTTDaiLy.Controls.Add(this.lblMaHoaDon);
            this.grTTDaiLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTTDaiLy.Location = new System.Drawing.Point(3, 3);
            this.grTTDaiLy.Name = "grTTDaiLy";
            this.grTTDaiLy.Size = new System.Drawing.Size(347, 389);
            this.grTTDaiLy.TabIndex = 0;
            this.grTTDaiLy.TabStop = false;
            this.grTTDaiLy.Text = "Thông Tin Hóa Đơn";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(139, 260);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(131, 25);
            this.txtTongTien.TabIndex = 9;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(139, 206);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(131, 25);
            this.txtNgayLap.TabIndex = 8;
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(139, 98);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(131, 25);
            this.txtMaKhach.TabIndex = 7;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(139, 152);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(131, 25);
            this.txtTenDangNhap.TabIndex = 6;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(139, 43);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(131, 25);
            this.txtMaHoaDon.TabIndex = 5;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Location = new System.Drawing.Point(6, 263);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(103, 22);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "Tổng Tiền:";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.Location = new System.Drawing.Point(6, 209);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(81, 22);
            this.lblNgayLap.TabIndex = 3;
            this.lblNgayLap.Text = "Ngày Lập:";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.Location = new System.Drawing.Point(6, 155);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(127, 22);
            this.lblTenDangNhap.TabIndex = 2;
            this.lblTenDangNhap.Text = "Tên Đăng Nhập:";
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.Location = new System.Drawing.Point(6, 101);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(91, 22);
            this.lblMaKhachHang.TabIndex = 1;
            this.lblMaKhachHang.Text = "Mã Khách Hàng:";
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.Location = new System.Drawing.Point(6, 48);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(91, 21);
            this.lblMaHoaDon.TabIndex = 0;
            this.lblMaHoaDon.Text = "Mã Hóa Đơn:";
            // 
            // grpTacVu
            // 
            this.grpTacVu.Controls.Add(this.btnLamMoi);
            this.grpTacVu.Controls.Add(this.btnXoa);
            this.grpTacVu.Controls.Add(this.btnSua);
            this.grpTacVu.Controls.Add(this.btnThem);
            this.grpTacVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTacVu.Location = new System.Drawing.Point(3, 398);
            this.grpTacVu.Name = "grpTacVu";
            this.grpTacVu.Size = new System.Drawing.Size(347, 126);
            this.grpTacVu.TabIndex = 1;
            this.grpTacVu.TabStop = false;
            this.grpTacVu.Text = "Tác Vụ";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Goldenrod;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(164, 77);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(85, 33);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Crimson;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(24, 77);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 31);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(164, 26);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 33);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.ForestGreen;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(24, 26);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 33);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // tbPhai
            // 
            this.tbPhai.ColumnCount = 1;
            this.tbPhai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 534F));
            this.tbPhai.Controls.Add(this.grpTimKiemHoaDon, 0, 0);
            this.tbPhai.Controls.Add(this.grDSHoaDon, 0, 1);
            this.tbPhai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPhai.Location = new System.Drawing.Point(362, 3);
            this.tbPhai.Name = "tbPhai";
            this.tbPhai.RowCount = 2;
            this.tbPhai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbPhai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tbPhai.Size = new System.Drawing.Size(534, 527);
            this.tbPhai.TabIndex = 1;
            // 
            // grpTimKiemHoaDon
            // 
            this.grpTimKiemHoaDon.Controls.Add(this.txtTimKiemHoaDon);
            this.grpTimKiemHoaDon.Controls.Add(this.lblTimKiemHoaDon);
            this.grpTimKiemHoaDon.Controls.Add(this.btnTimKiem);
            this.grpTimKiemHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTimKiemHoaDon.Location = new System.Drawing.Point(3, 3);
            this.grpTimKiemHoaDon.Name = "grpTimKiemHoaDon";
            this.grpTimKiemHoaDon.Size = new System.Drawing.Size(528, 125);
            this.grpTimKiemHoaDon.TabIndex = 0;
            this.grpTimKiemHoaDon.TabStop = false;
            this.grpTimKiemHoaDon.Text = "Tìm Kiếm Hóa Đơn";
            // 
            // txtTimKiemHoaDon
            // 
            this.txtTimKiemHoaDon.Location = new System.Drawing.Point(134, 48);
            this.txtTimKiemHoaDon.Name = "txtTimKiemHoaDon";
            this.txtTimKiemHoaDon.Size = new System.Drawing.Size(131, 25);
            this.txtTimKiemHoaDon.TabIndex = 6;
            // 
            // lblTimKiemHoaDon
            // 
            this.lblTimKiemHoaDon.Location = new System.Drawing.Point(30, 51);
            this.lblTimKiemHoaDon.Name = "lblTimKiemHoaDon";
            this.lblTimKiemHoaDon.Size = new System.Drawing.Size(98, 22);
            this.lblTimKiemHoaDon.TabIndex = 5;
            this.lblTimKiemHoaDon.Text = "Mã Hóa Đơn:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(344, 43);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 33);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // grDSHoaDon
            // 
            this.grDSHoaDon.Controls.Add(this.dgvDSDaiLy);
            this.grDSHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDSHoaDon.Location = new System.Drawing.Point(3, 134);
            this.grDSHoaDon.Name = "grDSHoaDon";
            this.grDSHoaDon.Size = new System.Drawing.Size(528, 390);
            this.grDSHoaDon.TabIndex = 1;
            this.grDSHoaDon.TabStop = false;
            this.grDSHoaDon.Text = "Danh Sách Hóa Đơn";
            // 
            // dgvDSDaiLy
            // 
            this.dgvDSDaiLy.AllowUserToAddRows = false;
            this.dgvDSDaiLy.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDaiLy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHoaDon,
            this.colMaKhachHang,
            this.colTenDangNhap,
            this.colNgayLap,
            this.colTongTien});
            this.dgvDSDaiLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSDaiLy.Location = new System.Drawing.Point(3, 21);
            this.dgvDSDaiLy.Name = "dgvDSDaiLy";
            this.dgvDSDaiLy.Size = new System.Drawing.Size(522, 366);
            this.dgvDSDaiLy.TabIndex = 0;
            // 
            // colMaHoaDon
            // 
            this.colMaHoaDon.HeaderText = "Mã Hóa Đơn";
            this.colMaHoaDon.Name = "colMaHoaDon";
            this.colMaHoaDon.Width = 150;
            // 
            // colMaKhachHang
            // 
            this.colMaKhachHang.HeaderText = "Mã Khách Hàng";
            this.colMaKhachHang.Name = "colMaKhachHang";
            this.colMaKhachHang.ReadOnly = true;
            this.colMaKhachHang.Width = 150;
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.HeaderText = "Tên Đăng Nhập";
            this.colTenDangNhap.Name = "colTenDangNhap";
            this.colTenDangNhap.ReadOnly = true;
            this.colTenDangNhap.Width = 150;
            // 
            // colNgayLap
            // 
            this.colNgayLap.HeaderText = "Ngày Lập";
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.ReadOnly = true;
            // 
            // colTongTien
            // 
            this.colTongTien.HeaderText = "Tổng Tiền";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.ReadOnly = true;
            this.colTongTien.Width = 150;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTieuDe.Location = new System.Drawing.Point(3, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(899, 94);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "Quản Lý Hóa Đơn";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HoaDonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 633);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "HoaDonForm";
            this.Text = "DaiLyForm";
            this.panel1.ResumeLayout(false);
            this.tbTong.ResumeLayout(false);
            this.grpTTHoaDon.ResumeLayout(false);
            this.tbTrai.ResumeLayout(false);
            this.grTTDaiLy.ResumeLayout(false);
            this.grTTDaiLy.PerformLayout();
            this.grpTacVu.ResumeLayout(false);
            this.tbPhai.ResumeLayout(false);
            this.grpTimKiemHoaDon.ResumeLayout(false);
            this.grpTimKiemHoaDon.PerformLayout();
            this.grDSHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDaiLy)).EndInit();
            this.ResumeLayout(false);

        }

        private DataGridViewTextBoxColumn colMaHoaDon;
        private DataGridViewTextBoxColumn colMaKhachHang;
        private DataGridViewTextBoxColumn colTenDangNhap;
        private DataGridViewTextBoxColumn colNgayLap;
        private DataGridViewTextBoxColumn colTongTien;
    }
}