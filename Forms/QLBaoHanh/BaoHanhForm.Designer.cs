using System.Drawing;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLBaoHanh
{
    partial class BaoHanhForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tbTong;
        private System.Windows.Forms.TableLayoutPanel tbHienThi;
        private System.Windows.Forms.TableLayoutPanel tbTrai;
        private System.Windows.Forms.TableLayoutPanel tbPhai;
        private System.Windows.Forms.GroupBox grpTTBaoHanh;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpTacVu;
        private System.Windows.Forms.GroupBox grpTimKiemPhieuBaoHanh;
        private System.Windows.Forms.GroupBox grpDSBaoHanh;
        private System.Windows.Forms.TextBox txtThoiHan;
        private System.Windows.Forms.TextBox txtNgayBatDau;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.TextBox txtMaBaoHanh;
        private System.Windows.Forms.Label lblThoiHan;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.Label lblMaXe;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.Label lblMaBaoHanh;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTimKiemPhieuBaoHanh;
        private System.Windows.Forms.Label lblTimKiemPhieuBaoHanh;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvDSBaoHanh;

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
            this.tbHienThi = new System.Windows.Forms.TableLayoutPanel();
            this.tbTrai = new System.Windows.Forms.TableLayoutPanel();
            this.grpTTBaoHanh = new System.Windows.Forms.GroupBox();
            this.txtThoiHan = new System.Windows.Forms.TextBox();
            this.txtNgayBatDau = new System.Windows.Forms.TextBox();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.txtMaBaoHanh = new System.Windows.Forms.TextBox();
            this.lblThoiHan = new System.Windows.Forms.Label();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.lblMaXe = new System.Windows.Forms.Label();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.lblMaBaoHanh = new System.Windows.Forms.Label();
            this.grpTacVu = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbPhai = new System.Windows.Forms.TableLayoutPanel();
            this.grpTimKiemPhieuBaoHanh = new System.Windows.Forms.GroupBox();
            this.txtTimKiemPhieuBaoHanh = new System.Windows.Forms.TextBox();
            this.lblTimKiemPhieuBaoHanh = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grpDSBaoHanh = new System.Windows.Forms.GroupBox();
            this.dgvDSBaoHanh = new System.Windows.Forms.DataGridView();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.colMaBaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThoiHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tbTong.SuspendLayout();
            this.tbHienThi.SuspendLayout();
            this.tbTrai.SuspendLayout();
            this.grpTTBaoHanh.SuspendLayout();
            this.grpTacVu.SuspendLayout();
            this.tbPhai.SuspendLayout();
            this.grpTimKiemPhieuBaoHanh.SuspendLayout();
            this.grpDSBaoHanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBaoHanh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
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
            this.tbTong.Controls.Add(this.tbHienThi, 0, 1);
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
            // tbHienThi
            // 
            this.tbHienThi.ColumnCount = 2;
            this.tbHienThi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tbHienThi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tbHienThi.Controls.Add(this.tbTrai, 0, 0);
            this.tbHienThi.Controls.Add(this.tbPhai, 1, 0);
            this.tbHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHienThi.Location = new System.Drawing.Point(3, 97);
            this.tbHienThi.Name = "tbHienThi";
            this.tbHienThi.RowCount = 1;
            this.tbHienThi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 533F));
            this.tbHienThi.Size = new System.Drawing.Size(899, 533);
            this.tbHienThi.TabIndex = 0;
            // 
            // tbTrai
            // 
            this.tbTrai.ColumnCount = 1;
            this.tbTrai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 353F));
            this.tbTrai.Controls.Add(this.grpTTBaoHanh, 0, 0);
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
            // grpTTBaoHanh
            // 
            this.grpTTBaoHanh.Controls.Add(this.txtThoiHan);
            this.grpTTBaoHanh.Controls.Add(this.txtNgayBatDau);
            this.grpTTBaoHanh.Controls.Add(this.txtMaHoaDon);
            this.grpTTBaoHanh.Controls.Add(this.txtMaXe);
            this.grpTTBaoHanh.Controls.Add(this.txtMaBaoHanh);
            this.grpTTBaoHanh.Controls.Add(this.lblThoiHan);
            this.grpTTBaoHanh.Controls.Add(this.lblNgayBatDau);
            this.grpTTBaoHanh.Controls.Add(this.lblMaXe);
            this.grpTTBaoHanh.Controls.Add(this.lblMaHoaDon);
            this.grpTTBaoHanh.Controls.Add(this.lblMaBaoHanh);
            this.grpTTBaoHanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTTBaoHanh.Location = new System.Drawing.Point(3, 3);
            this.grpTTBaoHanh.Name = "grpTTBaoHanh";
            this.grpTTBaoHanh.Size = new System.Drawing.Size(347, 389);
            this.grpTTBaoHanh.TabIndex = 0;
            this.grpTTBaoHanh.TabStop = false;
            this.grpTTBaoHanh.Text = "Thông Tin Bảo Hành";
            // 
            // txtThoiHan
            // 
            this.txtThoiHan.Location = new System.Drawing.Point(139, 260);
            this.txtThoiHan.Name = "txtThoiHan";
            this.txtThoiHan.Size = new System.Drawing.Size(131, 25);
            this.txtThoiHan.TabIndex = 9;
            // 
            // txtNgayBatDau
            // 
            this.txtNgayBatDau.Location = new System.Drawing.Point(139, 206);
            this.txtNgayBatDau.Name = "txtNgayBatDau";
            this.txtNgayBatDau.Size = new System.Drawing.Size(131, 25);
            this.txtNgayBatDau.TabIndex = 8;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(139, 98);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(131, 25);
            this.txtMaHoaDon.TabIndex = 7;
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(139, 152);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(131, 25);
            this.txtMaXe.TabIndex = 6;
            // 
            // txtMaBaoHanh
            // 
            this.txtMaBaoHanh.Location = new System.Drawing.Point(139, 43);
            this.txtMaBaoHanh.Name = "txtMaBaoHanh";
            this.txtMaBaoHanh.Size = new System.Drawing.Size(131, 25);
            this.txtMaBaoHanh.TabIndex = 5;
            // 
            // lblThoiHan
            // 
            this.lblThoiHan.Location = new System.Drawing.Point(6, 263);
            this.lblThoiHan.Name = "lblThoiHan";
            this.lblThoiHan.Size = new System.Drawing.Size(103, 22);
            this.lblThoiHan.TabIndex = 4;
            this.lblThoiHan.Text = "Thời Hạn:";
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.Location = new System.Drawing.Point(6, 209);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(103, 22);
            this.lblNgayBatDau.TabIndex = 3;
            this.lblNgayBatDau.Text = "Ngày Bắt Đầu:";
            // 
            // lblMaXe
            // 
            this.lblMaXe.Location = new System.Drawing.Point(6, 155);
            this.lblMaXe.Name = "lblMaXe";
            this.lblMaXe.Size = new System.Drawing.Size(127, 22);
            this.lblMaXe.TabIndex = 2;
            this.lblMaXe.Text = "Mã Xe:";
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.Location = new System.Drawing.Point(6, 101);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(91, 22);
            this.lblMaHoaDon.TabIndex = 1;
            this.lblMaHoaDon.Text = "Mã Hóa Đơn:";
            // 
            // lblMaBaoHanh
            // 
            this.lblMaBaoHanh.Location = new System.Drawing.Point(6, 48);
            this.lblMaBaoHanh.Name = "lblMaBaoHanh";
            this.lblMaBaoHanh.Size = new System.Drawing.Size(103, 21);
            this.lblMaBaoHanh.TabIndex = 0;
            this.lblMaBaoHanh.Text = "Mã Bảo Hành:";
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
            this.btnLamMoi.BackColor = System.Drawing.Color.DarkOrange;
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
            this.btnXoa.BackColor = System.Drawing.Color.IndianRed;
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
            this.btnSua.BackColor = System.Drawing.Color.RoyalBlue;
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
            this.btnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
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
            this.tbPhai.Controls.Add(this.grpTimKiemPhieuBaoHanh, 0, 0);
            this.tbPhai.Controls.Add(this.grpDSBaoHanh, 0, 1);
            this.tbPhai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPhai.Location = new System.Drawing.Point(362, 3);
            this.tbPhai.Name = "tbPhai";
            this.tbPhai.RowCount = 2;
            this.tbPhai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbPhai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tbPhai.Size = new System.Drawing.Size(534, 527);
            this.tbPhai.TabIndex = 1;
            // 
            // grpTimKiemPhieuBaoHanh
            // 
            this.grpTimKiemPhieuBaoHanh.Controls.Add(this.txtTimKiemPhieuBaoHanh);
            this.grpTimKiemPhieuBaoHanh.Controls.Add(this.lblTimKiemPhieuBaoHanh);
            this.grpTimKiemPhieuBaoHanh.Controls.Add(this.btnTimKiem);
            this.grpTimKiemPhieuBaoHanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTimKiemPhieuBaoHanh.Location = new System.Drawing.Point(3, 3);
            this.grpTimKiemPhieuBaoHanh.Name = "grpTimKiemPhieuBaoHanh";
            this.grpTimKiemPhieuBaoHanh.Size = new System.Drawing.Size(528, 125);
            this.grpTimKiemPhieuBaoHanh.TabIndex = 0;
            this.grpTimKiemPhieuBaoHanh.TabStop = false;
            this.grpTimKiemPhieuBaoHanh.Text = "Tìm Kiếm Phiếu Bảo Hành";
            // 
            // txtTimKiemPhieuBaoHanh
            // 
            this.txtTimKiemPhieuBaoHanh.Location = new System.Drawing.Point(188, 48);
            this.txtTimKiemPhieuBaoHanh.Name = "txtTimKiemPhieuBaoHanh";
            this.txtTimKiemPhieuBaoHanh.Size = new System.Drawing.Size(131, 25);
            this.txtTimKiemPhieuBaoHanh.TabIndex = 6;
            // 
            // lblTimKiemPhieuBaoHanh
            // 
            this.lblTimKiemPhieuBaoHanh.Location = new System.Drawing.Point(30, 51);
            this.lblTimKiemPhieuBaoHanh.Name = "lblTimKiemPhieuBaoHanh";
            this.lblTimKiemPhieuBaoHanh.Size = new System.Drawing.Size(140, 22);
            this.lblTimKiemPhieuBaoHanh.TabIndex = 5;
            this.lblTimKiemPhieuBaoHanh.Text = "Mã Phiếu Bảo Hành:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(369, 43);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 33);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // grpDSBaoHanh
            // 
            this.grpDSBaoHanh.Controls.Add(this.dgvDSBaoHanh);
            this.grpDSBaoHanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDSBaoHanh.Location = new System.Drawing.Point(3, 134);
            this.grpDSBaoHanh.Name = "grpDSBaoHanh";
            this.grpDSBaoHanh.Size = new System.Drawing.Size(528, 390);
            this.grpDSBaoHanh.TabIndex = 1;
            this.grpDSBaoHanh.TabStop = false;
            this.grpDSBaoHanh.Text = "Danh Sách Bảo Hành";
            // 
            // dgvDSBaoHanh
            // 
            this.dgvDSBaoHanh.AllowUserToAddRows = false;
            this.dgvDSBaoHanh.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSBaoHanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBaoHanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaBaoHanh,
            this.colMaHoaDon,
            this.colMaXe,
            this.colNgayBatDau,
            this.colThoiHan});
            this.dgvDSBaoHanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSBaoHanh.Location = new System.Drawing.Point(3, 21);
            this.dgvDSBaoHanh.Name = "dgvDSBaoHanh";
            this.dgvDSBaoHanh.Size = new System.Drawing.Size(522, 366);
            this.dgvDSBaoHanh.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblTieuDe.Location = new System.Drawing.Point(3, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(899, 94);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "Quản Lý Bảo Hành";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colMaBaoHanh
            // 
            this.colMaBaoHanh.HeaderText = "Mã Bảo Hành";
            this.colMaBaoHanh.Name = "colMaBaoHanh";
            this.colMaBaoHanh.Width = 150;
            // 
            // colMaHoaDon
            // 
            this.colMaHoaDon.HeaderText = "Mã Hóa Đơn";
            this.colMaHoaDon.Name = "colMaHoaDon";
            this.colMaHoaDon.ReadOnly = true;
            this.colMaHoaDon.Width = 150;
            // 
            // colMaXe
            // 
            this.colMaXe.HeaderText = "Mã Xe";
            this.colMaXe.Name = "colMaXe";
            this.colMaXe.ReadOnly = true;
            this.colMaXe.Width = 150;
            // 
            // colNgayBatDau
            // 
            this.colNgayBatDau.HeaderText = "Ngày Bắt Đầu";
            this.colNgayBatDau.Name = "colNgayBatDau";
            this.colNgayBatDau.ReadOnly = true;
            this.colNgayBatDau.Width = 150;
            // 
            // colThoiHan
            // 
            this.colThoiHan.HeaderText = "Thời Hạn";
            this.colThoiHan.Name = "colThoiHan";
            this.colThoiHan.ReadOnly = true;
            this.colThoiHan.Width = 150;
            // 
            // BaoHanhForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 633);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "BaoHanhForm";
            this.Text = "DaiLyForm";
            this.panel1.ResumeLayout(false);
            this.tbTong.ResumeLayout(false);
            this.tbHienThi.ResumeLayout(false);
            this.tbTrai.ResumeLayout(false);
            this.grpTTBaoHanh.ResumeLayout(false);
            this.grpTTBaoHanh.PerformLayout();
            this.grpTacVu.ResumeLayout(false);
            this.tbPhai.ResumeLayout(false);
            this.grpTimKiemPhieuBaoHanh.ResumeLayout(false);
            this.grpTimKiemPhieuBaoHanh.PerformLayout();
            this.grpDSBaoHanh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBaoHanh)).EndInit();
            this.ResumeLayout(false);

        }

        private DataGridViewTextBoxColumn colMaBaoHanh;
        private DataGridViewTextBoxColumn colMaHoaDon;
        private DataGridViewTextBoxColumn colMaXe;
        private DataGridViewTextBoxColumn colNgayBatDau;
        private DataGridViewTextBoxColumn colThoiHan;
    }
}