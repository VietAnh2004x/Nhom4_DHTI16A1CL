using System.Drawing;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLKhachHang
{
    partial class KhachHangForm
    {
        private System.ComponentModel.IContainer components = null;
 
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTong = new System.Windows.Forms.TableLayoutPanel();
            this.txtTieuDe = new System.Windows.Forms.Label();
            this.tbHienThiChung = new System.Windows.Forms.TableLayoutPanel();
            this.tbTrai = new System.Windows.Forms.TableLayoutPanel();
            this.grTTKhachHang = new System.Windows.Forms.GroupBox();
            this.lbEmail = new System.Windows.Forms.TextBox();
            this.lbSDT = new System.Windows.Forms.TextBox();
            this.lbHoTen = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.TextBox();
            this.lbMaKH = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.Label();
            this.txtSoDT = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtMaKhachHang1 = new System.Windows.Forms.Label();
            this.grTacVu = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbPhai = new System.Windows.Forms.TableLayoutPanel();
            this.grTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtMaKhachHang = new System.Windows.Forms.Label();
            this.grDSKhachHang = new System.Windows.Forms.GroupBox();
            this.dataHienThi = new System.Windows.Forms.DataGridView();
            this.columnMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tbTong.SuspendLayout();
            this.tbHienThiChung.SuspendLayout();
            this.tbTrai.SuspendLayout();
            this.grTTKhachHang.SuspendLayout();
            this.grTacVu.SuspendLayout();
            this.tbPhai.SuspendLayout();
            this.grTimKiem.SuspendLayout();
            this.grDSKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbTong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 736);
            this.panel1.TabIndex = 0;
            // 
            // tbTong
            // 
            this.tbTong.ColumnCount = 1;
            this.tbTong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbTong.Controls.Add(this.txtTieuDe, 0, 0);
            this.tbTong.Controls.Add(this.tbHienThiChung, 0, 1);
            this.tbTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTong.Location = new System.Drawing.Point(0, 0);
            this.tbTong.Name = "tbTong";
            this.tbTong.RowCount = 2;
            this.tbTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tbTong.Size = new System.Drawing.Size(1209, 736);
            this.tbTong.TabIndex = 0;
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txtTieuDe.Location = new System.Drawing.Point(3, 0);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(1203, 73);
            this.txtTieuDe.TabIndex = 0;
            this.txtTieuDe.Text = "KHÁCH HÀNG";
            this.txtTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbHienThiChung
            // 
            this.tbHienThiChung.ColumnCount = 2;
            this.tbHienThiChung.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tbHienThiChung.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tbHienThiChung.Controls.Add(this.tbTrai, 0, 0);
            this.tbHienThiChung.Controls.Add(this.tbPhai, 1, 0);
            this.tbHienThiChung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHienThiChung.Location = new System.Drawing.Point(3, 76);
            this.tbHienThiChung.Name = "tbHienThiChung";
            this.tbHienThiChung.RowCount = 1;
            this.tbHienThiChung.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbHienThiChung.Size = new System.Drawing.Size(1203, 657);
            this.tbHienThiChung.TabIndex = 1;
            // 
            // tbTrai
            // 
            this.tbTrai.ColumnCount = 1;
            this.tbTrai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbTrai.Controls.Add(this.grTTKhachHang, 0, 0);
            this.tbTrai.Controls.Add(this.grTacVu, 0, 1);
            this.tbTrai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTrai.Location = new System.Drawing.Point(3, 3);
            this.tbTrai.Name = "tbTrai";
            this.tbTrai.RowCount = 2;
            this.tbTrai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tbTrai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbTrai.Size = new System.Drawing.Size(535, 651);
            this.tbTrai.TabIndex = 0;
            // 
            // grTTKhachHang
            // 
            this.grTTKhachHang.Controls.Add(this.lbEmail);
            this.grTTKhachHang.Controls.Add(this.lbSDT);
            this.grTTKhachHang.Controls.Add(this.lbHoTen);
            this.grTTKhachHang.Controls.Add(this.lbDiaChi);
            this.grTTKhachHang.Controls.Add(this.lbMaKH);
            this.grTTKhachHang.Controls.Add(this.txtDiaChi);
            this.grTTKhachHang.Controls.Add(this.txtHoTen);
            this.grTTKhachHang.Controls.Add(this.txtSoDT);
            this.grTTKhachHang.Controls.Add(this.txtEmail);
            this.grTTKhachHang.Controls.Add(this.txtMaKhachHang1);
            this.grTTKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTTKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.grTTKhachHang.Location = new System.Drawing.Point(3, 3);
            this.grTTKhachHang.Name = "grTTKhachHang";
            this.grTTKhachHang.Size = new System.Drawing.Size(529, 514);
            this.grTTKhachHang.TabIndex = 0;
            this.grTTKhachHang.TabStop = false;
            this.grTTKhachHang.Text = "Thông tin khách hàng";
            // 
            // lbEmail
            // 
            this.lbEmail.Location = new System.Drawing.Point(170, 314);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(196, 25);
            this.lbEmail.TabIndex = 10;
            // 
            // lbSDT
            // 
            this.lbSDT.Location = new System.Drawing.Point(170, 252);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(196, 25);
            this.lbSDT.TabIndex = 9;
            // 
            // lbHoTen
            // 
            this.lbHoTen.Location = new System.Drawing.Point(170, 120);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(196, 25);
            this.lbHoTen.TabIndex = 8;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.Location = new System.Drawing.Point(170, 186);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(196, 25);
            this.lbDiaChi.TabIndex = 7;
            // 
            // lbMaKH
            // 
            this.lbMaKH.Location = new System.Drawing.Point(170, 54);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(196, 25);
            this.lbMaKH.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(6, 189);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(100, 23);
            this.txtDiaChi.TabIndex = 5;
            this.txtDiaChi.Text = "Địa chỉ:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(6, 123);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(100, 23);
            this.txtHoTen.TabIndex = 4;
            this.txtHoTen.Text = "Họ tên:";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(6, 255);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(121, 23);
            this.txtSoDT.TabIndex = 3;
            this.txtSoDT.Text = "Số điện thoại:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 321);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "Email:";
            // 
            // txtMaKhachHang1
            // 
            this.txtMaKhachHang1.Location = new System.Drawing.Point(6, 57);
            this.txtMaKhachHang1.Name = "txtMaKhachHang1";
            this.txtMaKhachHang1.Size = new System.Drawing.Size(140, 23);
            this.txtMaKhachHang1.TabIndex = 0;
            this.txtMaKhachHang1.Text = "Mã khách hàng:";
            // 
            // grTacVu
            // 
            this.grTacVu.Controls.Add(this.btnLamMoi);
            this.grTacVu.Controls.Add(this.btnXoa);
            this.grTacVu.Controls.Add(this.btnSua);
            this.grTacVu.Controls.Add(this.btnThem);
            this.grTacVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTacVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.grTacVu.Location = new System.Drawing.Point(3, 523);
            this.grTacVu.Name = "grTacVu";
            this.grTacVu.Size = new System.Drawing.Size(529, 125);
            this.grTacVu.TabIndex = 1;
            this.grTacVu.TabStop = false;
            this.grTacVu.Text = "Tác vụ";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(336, 54);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 33);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(234, 54);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 33);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(127, 54);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 33);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(23, 54);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 33);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // tbPhai
            // 
            this.tbPhai.ColumnCount = 1;
            this.tbPhai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbPhai.Controls.Add(this.grTimKiem, 0, 0);
            this.tbPhai.Controls.Add(this.grDSKhachHang, 0, 1);
            this.tbPhai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPhai.Location = new System.Drawing.Point(544, 3);
            this.tbPhai.Name = "tbPhai";
            this.tbPhai.RowCount = 2;
            this.tbPhai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tbPhai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tbPhai.Size = new System.Drawing.Size(656, 651);
            this.tbPhai.TabIndex = 1;
            // 
            // grTimKiem
            // 
            this.grTimKiem.Controls.Add(this.btnTimKiem);
            this.grTimKiem.Controls.Add(this.textBox6);
            this.grTimKiem.Controls.Add(this.txtMaKhachHang);
            this.grTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.grTimKiem.Location = new System.Drawing.Point(3, 3);
            this.grTimKiem.Name = "grTimKiem";
            this.grTimKiem.Size = new System.Drawing.Size(650, 91);
            this.grTimKiem.TabIndex = 0;
            this.grTimKiem.TabStop = false;
            this.grTimKiem.Text = "Tìm kiếm khách hàng";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(434, 31);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 30);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(177, 35);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(196, 25);
            this.textBox6.TabIndex = 7;
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(11, 38);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(160, 23);
            this.txtMaKhachHang.TabIndex = 0;
            this.txtMaKhachHang.Text = "Mã khách hàng:";
            // 
            // grDSKhachHang
            // 
            this.grDSKhachHang.Controls.Add(this.dataHienThi);
            this.grDSKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDSKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.grDSKhachHang.Location = new System.Drawing.Point(3, 100);
            this.grDSKhachHang.Name = "grDSKhachHang";
            this.grDSKhachHang.Size = new System.Drawing.Size(650, 548);
            this.grDSKhachHang.TabIndex = 1;
            this.grDSKhachHang.TabStop = false;
            this.grDSKhachHang.Text = "Danh sách khách hàng";
            // 
            // dataHienThi
            // 
            this.dataHienThi.AllowUserToAddRows = false;
            this.dataHienThi.BackgroundColor = System.Drawing.Color.White;
            this.dataHienThi.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataHienThi.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dataHienThi.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataHienThi.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataHienThi.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dataHienThi.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataHienThi.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHienThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnMaKH,
            this.columnHoTen,
            this.columnDiaChi,
            this.columnSDT,
            this.columnEmail});
            this.dataHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataHienThi.EnableHeadersVisualStyles = false;
            this.dataHienThi.GridColor = System.Drawing.Color.LightGray;
            this.dataHienThi.Location = new System.Drawing.Point(3, 21);
            this.dataHienThi.Name = "dataHienThi";
            this.dataHienThi.RowHeadersWidth = 51;
            this.dataHienThi.RowTemplate.Height = 24;
            this.dataHienThi.Size = new System.Drawing.Size(644, 524);
            this.dataHienThi.TabIndex = 0;
            // 
            // columnMaKH
            // 
            this.columnMaKH.HeaderText = "Mã Khách Hàng";
            this.columnMaKH.MinimumWidth = 6;
            this.columnMaKH.Name = "columnMaKH";
            this.columnMaKH.ReadOnly = true;
            this.columnMaKH.Width = 175;
            // 
            // columnHoTen
            // 
            this.columnHoTen.HeaderText = "Họ Tên";
            this.columnHoTen.MinimumWidth = 6;
            this.columnHoTen.Name = "columnHoTen";
            this.columnHoTen.ReadOnly = true;
            this.columnHoTen.Width = 125;
            // 
            // columnDiaChi
            // 
            this.columnDiaChi.HeaderText = "Địa Chỉ";
            this.columnDiaChi.MinimumWidth = 6;
            this.columnDiaChi.Name = "columnDiaChi";
            this.columnDiaChi.ReadOnly = true;
            this.columnDiaChi.Width = 125;
            // 
            // columnSDT
            // 
            this.columnSDT.HeaderText = "Số Điện Thoại";
            this.columnSDT.MinimumWidth = 6;
            this.columnSDT.Name = "columnSDT";
            this.columnSDT.ReadOnly = true;
            this.columnSDT.Width = 150;
            // 
            // columnEmail
            // 
            this.columnEmail.HeaderText = "Email";
            this.columnEmail.MinimumWidth = 6;
            this.columnEmail.Name = "columnEmail";
            this.columnEmail.ReadOnly = true;
            this.columnEmail.Width = 125;
            // 
            // KhachHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1209, 736);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "KhachHangForm";
            this.Text = "KhachHangForm";
            this.panel1.ResumeLayout(false);
            this.tbTong.ResumeLayout(false);
            this.tbHienThiChung.ResumeLayout(false);
            this.tbTrai.ResumeLayout(false);
            this.grTTKhachHang.ResumeLayout(false);
            this.grTTKhachHang.PerformLayout();
            this.grTacVu.ResumeLayout(false);
            this.tbPhai.ResumeLayout(false);
            this.grTimKiem.ResumeLayout(false);
            this.grTimKiem.PerformLayout();
            this.grDSKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataHienThi)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tbTong;
        private System.Windows.Forms.Label txtTieuDe;
        private System.Windows.Forms.TableLayoutPanel tbHienThiChung;
        private System.Windows.Forms.TableLayoutPanel tbTrai;
        private System.Windows.Forms.TableLayoutPanel tbPhai;
        private System.Windows.Forms.GroupBox grTTKhachHang;
        private System.Windows.Forms.GroupBox grTacVu;
        private System.Windows.Forms.GroupBox grTimKiem;
        private System.Windows.Forms.GroupBox grDSKhachHang;
        private System.Windows.Forms.Label txtDiaChi;
        private System.Windows.Forms.Label txtHoTen;
        private System.Windows.Forms.Label txtSoDT;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtMaKhachHang1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox lbEmail;
        private System.Windows.Forms.TextBox lbSDT;
        private System.Windows.Forms.TextBox lbHoTen;
        private System.Windows.Forms.TextBox lbDiaChi;
        private System.Windows.Forms.TextBox lbMaKH;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label txtMaKhachHang;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dataHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmail;
    }
}