using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLHoaDon
{
    partial class usHoaDon
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
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Label lblMaXe;
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
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.lblMaXe = new System.Windows.Forms.Label();
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.colMaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(1000, 750);
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
            this.tbTong.Size = new System.Drawing.Size(1000, 750);
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
            this.grpTTHoaDon.Location = new System.Drawing.Point(3, 115);
            this.grpTTHoaDon.Name = "grpTTHoaDon";
            this.grpTTHoaDon.RowCount = 1;
            this.grpTTHoaDon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 632F));
            this.grpTTHoaDon.Size = new System.Drawing.Size(994, 632);
            this.grpTTHoaDon.TabIndex = 0;
            // 
            // tbTrai
            // 
            this.tbTrai.ColumnCount = 1;
            this.tbTrai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 391F));
            this.tbTrai.Controls.Add(this.grTTDaiLy, 0, 0);
            this.tbTrai.Controls.Add(this.grpTacVu, 0, 1);
            this.tbTrai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTrai.Location = new System.Drawing.Point(3, 3);
            this.tbTrai.Name = "tbTrai";
            this.tbTrai.RowCount = 2;
            this.tbTrai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tbTrai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTrai.Size = new System.Drawing.Size(391, 626);
            this.tbTrai.TabIndex = 0;
            // 
            // grTTDaiLy
            // 
            this.grTTDaiLy.Controls.Add(this.txtTenDangNhap);
            this.grTTDaiLy.Controls.Add(this.lblTenDangNhap);
            this.grTTDaiLy.Controls.Add(this.txtTongTien);
            this.grTTDaiLy.Controls.Add(this.txtNgayLap);
            this.grTTDaiLy.Controls.Add(this.txtMaKhach);
            this.grTTDaiLy.Controls.Add(this.txtMaXe);
            this.grTTDaiLy.Controls.Add(this.txtMaHoaDon);
            this.grTTDaiLy.Controls.Add(this.lblTongTien);
            this.grTTDaiLy.Controls.Add(this.lblNgayLap);
            this.grTTDaiLy.Controls.Add(this.lblMaXe);
            this.grTTDaiLy.Controls.Add(this.lblMaKhachHang);
            this.grTTDaiLy.Controls.Add(this.lblMaHoaDon);
            this.grTTDaiLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTTDaiLy.Location = new System.Drawing.Point(3, 3);
            this.grTTDaiLy.Name = "grTTDaiLy";
            this.grTTDaiLy.Size = new System.Drawing.Size(385, 463);
            this.grTTDaiLy.TabIndex = 0;
            this.grTTDaiLy.TabStop = false;
            this.grTTDaiLy.Text = "Thông Tin Hóa Đơn";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(164, 384);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(163, 25);
            this.txtTongTien.TabIndex = 9;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(164, 316);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(163, 25);
            this.txtNgayLap.TabIndex = 8;
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(165, 112);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(163, 25);
            this.txtMaKhach.TabIndex = 7;
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(164, 180);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(163, 25);
            this.txtMaXe.TabIndex = 6;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(164, 45);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(163, 25);
            this.txtMaHoaDon.TabIndex = 5;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Location = new System.Drawing.Point(6, 387);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(152, 22);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "Tổng Tiền:";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.Location = new System.Drawing.Point(6, 319);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(152, 22);
            this.lblNgayLap.TabIndex = 3;
            this.lblNgayLap.Text = "Ngày Lập:";
            // 
            // lblMaXe
            // 
            this.lblMaXe.Location = new System.Drawing.Point(6, 183);
            this.lblMaXe.Name = "lblMaXe";
            this.lblMaXe.Size = new System.Drawing.Size(152, 22);
            this.lblMaXe.TabIndex = 2;
            this.lblMaXe.Text = "Mã Xe:";
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.Location = new System.Drawing.Point(6, 115);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(152, 22);
            this.lblMaKhachHang.TabIndex = 1;
            this.lblMaKhachHang.Text = "Mã Khách Hàng:";
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.Location = new System.Drawing.Point(6, 48);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(152, 21);
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
            this.grpTacVu.Location = new System.Drawing.Point(3, 472);
            this.grpTacVu.Name = "grpTacVu";
            this.grpTacVu.Size = new System.Drawing.Size(385, 151);
            this.grpTacVu.TabIndex = 1;
            this.grpTacVu.TabStop = false;
            this.grpTacVu.Text = "Tác Vụ";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(224, 97);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 35);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(59, 97);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(224, 36);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 35);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(59, 36);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // tbPhai
            // 
            this.tbPhai.ColumnCount = 1;
            this.tbPhai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 591F));
            this.tbPhai.Controls.Add(this.grpTimKiemHoaDon, 0, 0);
            this.tbPhai.Controls.Add(this.grDSHoaDon, 0, 1);
            this.tbPhai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPhai.Location = new System.Drawing.Point(400, 3);
            this.tbPhai.Name = "tbPhai";
            this.tbPhai.RowCount = 2;
            this.tbPhai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbPhai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tbPhai.Size = new System.Drawing.Size(591, 626);
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
            this.grpTimKiemHoaDon.Size = new System.Drawing.Size(585, 119);
            this.grpTimKiemHoaDon.TabIndex = 0;
            this.grpTimKiemHoaDon.TabStop = false;
            this.grpTimKiemHoaDon.Text = "Tìm Kiếm Hóa Đơn";
            // 
            // txtTimKiemHoaDon
            // 
            this.txtTimKiemHoaDon.Location = new System.Drawing.Point(180, 49);
            this.txtTimKiemHoaDon.Name = "txtTimKiemHoaDon";
            this.txtTimKiemHoaDon.Size = new System.Drawing.Size(196, 25);
            this.txtTimKiemHoaDon.TabIndex = 6;
            // 
            // lblTimKiemHoaDon
            // 
            this.lblTimKiemHoaDon.Location = new System.Drawing.Point(14, 52);
            this.lblTimKiemHoaDon.Name = "lblTimKiemHoaDon";
            this.lblTimKiemHoaDon.Size = new System.Drawing.Size(160, 23);
            this.lblTimKiemHoaDon.TabIndex = 5;
            this.lblTimKiemHoaDon.Text = "Mã Hóa Đơn:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(433, 43);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 35);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // grDSHoaDon
            // 
            this.grDSHoaDon.Controls.Add(this.dgvDSDaiLy);
            this.grDSHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDSHoaDon.Location = new System.Drawing.Point(3, 128);
            this.grDSHoaDon.Name = "grDSHoaDon";
            this.grDSHoaDon.Size = new System.Drawing.Size(585, 495);
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
            this.colMaXe,
            this.colNgayLap,
            this.colTongTien});
            this.dgvDSDaiLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSDaiLy.Location = new System.Drawing.Point(3, 21);
            this.dgvDSDaiLy.Name = "dgvDSDaiLy";
            this.dgvDSDaiLy.RowHeadersWidth = 51;
            this.dgvDSDaiLy.Size = new System.Drawing.Size(579, 471);
            this.dgvDSDaiLy.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTieuDe.Location = new System.Drawing.Point(3, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(994, 112);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "QUẢN LÝ HÓA ĐƠN";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colMaHoaDon
            // 
            this.colMaHoaDon.HeaderText = "Mã Hóa Đơn";
            this.colMaHoaDon.MinimumWidth = 6;
            this.colMaHoaDon.Name = "colMaHoaDon";
            this.colMaHoaDon.Width = 150;
            // 
            // colMaKhachHang
            // 
            this.colMaKhachHang.HeaderText = "Mã Khách Hàng";
            this.colMaKhachHang.MinimumWidth = 6;
            this.colMaKhachHang.Name = "colMaKhachHang";
            this.colMaKhachHang.ReadOnly = true;
            this.colMaKhachHang.Width = 175;
            // 
            // colMaXe
            // 
            this.colMaXe.HeaderText = "Mã Xe";
            this.colMaXe.MinimumWidth = 6;
            this.colMaXe.Name = "colMaXe";
            this.colMaXe.ReadOnly = true;
            this.colMaXe.Width = 175;
            // 
            // colNgayLap
            // 
            this.colNgayLap.HeaderText = "Ngày Lập";
            this.colNgayLap.MinimumWidth = 6;
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.ReadOnly = true;
            this.colNgayLap.Width = 125;
            // 
            // colTongTien
            // 
            this.colTongTien.HeaderText = "Tổng Tiền";
            this.colTongTien.MinimumWidth = 6;
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.ReadOnly = true;
            this.colTongTien.Width = 150;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(164, 248);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(163, 25);
            this.txtTenDangNhap.TabIndex = 11;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.Location = new System.Drawing.Point(6, 251);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(152, 22);
            this.lblTenDangNhap.TabIndex = 10;
            this.lblTenDangNhap.Text = "Tên Đăng Nhập:";
            // 
            // usHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "usHoaDon";
            this.Size = new System.Drawing.Size(1000, 750);
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
        private DataGridViewTextBoxColumn colMaXe;
        private DataGridViewTextBoxColumn colNgayLap;
        private DataGridViewTextBoxColumn colTongTien;
        private TextBox txtTenDangNhap;
        private Label lblTenDangNhap;
    }
}
