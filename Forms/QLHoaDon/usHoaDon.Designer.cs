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
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpTacVu;
        private System.Windows.Forms.GroupBox grpTimKiemHoaDon;
        private System.Windows.Forms.GroupBox grDSHoaDon;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTimKiemHoaDon;
        private System.Windows.Forms.Label lblTimKiemHoaDon;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvDSHoaDon;

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
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.lblMaXe = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
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
            this.dgvDSHoaDon = new System.Windows.Forms.DataGridView();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.colMaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tbTong.SuspendLayout();
            this.grpTTHoaDon.SuspendLayout();
            this.tbTrai.SuspendLayout();
            this.grTTDaiLy.SuspendLayout();
            this.grpTacVu.SuspendLayout();
            this.tbPhai.SuspendLayout();
            this.grpTimKiemHoaDon.SuspendLayout();
            this.grDSHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).BeginInit();
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
            this.grTTDaiLy.Controls.Add(this.txtTenKhachHang);
            this.grTTDaiLy.Controls.Add(this.lblMaKhachHang);
            this.grTTDaiLy.Controls.Add(this.txtTenXe);
            this.grTTDaiLy.Controls.Add(this.lblMaXe);
            this.grTTDaiLy.Controls.Add(this.txtMaHoaDon);
            this.grTTDaiLy.Controls.Add(this.lblMaHoaDon);
            this.grTTDaiLy.Controls.Add(this.txtTenDangNhap);
            this.grTTDaiLy.Controls.Add(this.lblTenDangNhap);
            this.grTTDaiLy.Controls.Add(this.txtTongTien);
            this.grTTDaiLy.Controls.Add(this.txtNgayLap);
            this.grTTDaiLy.Controls.Add(this.lblTongTien);
            this.grTTDaiLy.Controls.Add(this.lblNgayLap);
            this.grTTDaiLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTTDaiLy.Location = new System.Drawing.Point(3, 3);
            this.grTTDaiLy.Name = "grTTDaiLy";
            this.grTTDaiLy.Size = new System.Drawing.Size(385, 463);
            this.grTTDaiLy.TabIndex = 0;
            this.grTTDaiLy.TabStop = false;
            this.grTTDaiLy.Text = "Thông Tin Hóa Đơn";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenKhachHang.Location = new System.Drawing.Point(188, 112);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(162, 34);
            this.txtTenKhachHang.TabIndex = 15;
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.Location = new System.Drawing.Point(10, 114);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(152, 32);
            this.lblMaKhachHang.TabIndex = 14;
            this.lblMaKhachHang.Text = "Tên Khách Hàng";
            // 
            // txtTenXe
            // 
            this.txtTenXe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenXe.Location = new System.Drawing.Point(188, 235);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(162, 34);
            this.txtTenXe.TabIndex = 15;
            // 
            // lblMaXe
            // 
            this.lblMaXe.Location = new System.Drawing.Point(10, 237);
            this.lblMaXe.Name = "lblMaXe";
            this.lblMaXe.Size = new System.Drawing.Size(152, 32);
            this.lblMaXe.TabIndex = 14;
            this.lblMaXe.Text = "Tên Xe";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHoaDon.Location = new System.Drawing.Point(188, 51);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(162, 34);
            this.txtMaHoaDon.TabIndex = 13;
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.Location = new System.Drawing.Point(10, 53);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(152, 30);
            this.lblMaHoaDon.TabIndex = 12;
            this.lblMaHoaDon.Text = "Mã Hóa Đơn:";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDangNhap.Location = new System.Drawing.Point(188, 171);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(162, 34);
            this.txtTenDangNhap.TabIndex = 11;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.Location = new System.Drawing.Point(10, 168);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(152, 37);
            this.lblTenDangNhap.TabIndex = 10;
            this.lblTenDangNhap.Text = "Tên Nhân Viên";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTien.Location = new System.Drawing.Point(188, 391);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(162, 34);
            this.txtTongTien.TabIndex = 9;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNgayLap.Location = new System.Drawing.Point(188, 326);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(162, 34);
            this.txtNgayLap.TabIndex = 8;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Location = new System.Drawing.Point(10, 393);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(152, 32);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "Tổng Tiền(VND)";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.Location = new System.Drawing.Point(10, 328);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(152, 32);
            this.lblNgayLap.TabIndex = 3;
            this.lblNgayLap.Text = "Ngày Lập:";
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
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.txtTimKiemHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiemHoaDon.Location = new System.Drawing.Point(180, 49);
            this.txtTimKiemHoaDon.Name = "txtTimKiemHoaDon";
            this.txtTimKiemHoaDon.Size = new System.Drawing.Size(196, 34);
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
            this.grDSHoaDon.Controls.Add(this.dgvDSHoaDon);
            this.grDSHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDSHoaDon.Location = new System.Drawing.Point(3, 128);
            this.grDSHoaDon.Name = "grDSHoaDon";
            this.grDSHoaDon.Size = new System.Drawing.Size(585, 495);
            this.grDSHoaDon.TabIndex = 1;
            this.grDSHoaDon.TabStop = false;
            this.grDSHoaDon.Text = "Danh Sách Hóa Đơn";
            // 
            // dgvDSHoaDon
            // 
            this.dgvDSHoaDon.AllowUserToAddRows = false;
            this.dgvDSHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHoaDon,
            this.colTenKhachHang,
            this.colTenNhanVien,
            this.colTenXe,
            this.colNgayLap,
            this.colTongTien});
            this.dgvDSHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHoaDon.Location = new System.Drawing.Point(3, 30);
            this.dgvDSHoaDon.Name = "dgvDSHoaDon";
            this.dgvDSHoaDon.RowHeadersWidth = 51;
            this.dgvDSHoaDon.Size = new System.Drawing.Size(579, 462);
            this.dgvDSHoaDon.TabIndex = 0;
            this.dgvDSHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHoaDon_CellContentClick);
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
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.HeaderText = "Tên Khách Hàng";
            this.colTenKhachHang.MinimumWidth = 6;
            this.colTenKhachHang.Name = "colTenKhachHang";
            this.colTenKhachHang.ReadOnly = true;
            // 
            // colTenNhanVien
            // 
            this.colTenNhanVien.HeaderText = "Tên Nhân Viên";
            this.colTenNhanVien.MinimumWidth = 8;
            this.colTenNhanVien.Name = "colTenNhanVien";
            // 
            // colTenXe
            // 
            this.colTenXe.HeaderText = "Tên Xe";
            this.colTenXe.MinimumWidth = 6;
            this.colTenXe.Name = "colTenXe";
            this.colTenXe.ReadOnly = true;
            // 
            // colNgayLap
            // 
            this.colNgayLap.HeaderText = "Ngày Lập";
            this.colNgayLap.MinimumWidth = 6;
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.ReadOnly = true;
            // 
            // colTongTien
            // 
            this.colTongTien.HeaderText = "Tổng Tiền(VND)";
            this.colTongTien.MinimumWidth = 6;
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.ReadOnly = true;
            // 
            // usHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).EndInit();
            this.ResumeLayout(false);

        }
        private GroupBox grTTDaiLy;
        private TextBox txtTenDangNhap;
        private Label lblTenDangNhap;
        private TextBox txtTongTien;
        private TextBox txtNgayLap;
        private Label lblTongTien;
        private Label lblNgayLap;
        private TextBox txtTenKhachHang;
        private Label lblMaKhachHang;
        private TextBox txtTenXe;
        private Label lblMaXe;
        private TextBox txtMaHoaDon;
        private Label lblMaHoaDon;
        private DataGridViewTextBoxColumn colMaHoaDon;
        private DataGridViewTextBoxColumn colTenKhachHang;
        private DataGridViewTextBoxColumn colTenNhanVien;
        private DataGridViewTextBoxColumn colTenXe;
        private DataGridViewTextBoxColumn colNgayLap;
        private DataGridViewTextBoxColumn colTongTien;
    }
}
