using DoAn1_Nhom4_DHTI16A1CL.Data_Transfer_Objects;
using System.Drawing;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLXe
{
    partial class QLXeDapDienForm
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
            this.tbHienThiXe = new System.Windows.Forms.TableLayoutPanel();
            this.tbHienThiBang = new System.Windows.Forms.TableLayoutPanel();
            this.grTTBang = new System.Windows.Forms.GroupBox();
            this.dataDSXe = new System.Windows.Forms.DataGridView();
            this.grTacVu = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grTTXe = new System.Windows.Forms.GroupBox();
            this.lbSoBinhAcQuy = new System.Windows.Forms.NumericUpDown();
            this.lbSLAcQuy = new System.Windows.Forms.NumericUpDown();
            this.lbBaoHanh = new System.Windows.Forms.NumericUpDown();
            this.lbGia = new System.Windows.Forms.TextBox();
            this.lbMaXe = new System.Windows.Forms.TextBox();
            this.lbTenXe = new System.Windows.Forms.TextBox();
            this.lbDongXe = new System.Windows.Forms.ComboBox();
            this.picAnhXe = new System.Windows.Forms.PictureBox();
            this.txtSLAcQuy = new System.Windows.Forms.Label();
            this.txtDLAcQuy = new System.Windows.Forms.Label();
            this.txtBaoHanh = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.Label();
            this.txtTenXe = new System.Windows.Forms.Label();
            this.txtMaXe = new System.Windows.Forms.Label();
            this.txtDongXe = new System.Windows.Forms.Label();
            this.columnMaXeDapDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDongXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSLAcQuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDLAcQuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tbTong.SuspendLayout();
            this.tbHienThiXe.SuspendLayout();
            this.tbHienThiBang.SuspendLayout();
            this.grTTBang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDSXe)).BeginInit();
            this.grTacVu.SuspendLayout();
            this.grTTXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbSoBinhAcQuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbSLAcQuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbBaoHanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhXe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbTong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 658);
            this.panel1.TabIndex = 0;
            // 
            // tbTong
            // 
            this.tbTong.ColumnCount = 1;
            this.tbTong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbTong.Controls.Add(this.txtTieuDe, 0, 0);
            this.tbTong.Controls.Add(this.tbHienThiXe, 0, 1);
            this.tbTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTong.Location = new System.Drawing.Point(0, 0);
            this.tbTong.Name = "tbTong";
            this.tbTong.RowCount = 2;
            this.tbTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tbTong.Size = new System.Drawing.Size(1087, 658);
            this.tbTong.TabIndex = 0;
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.txtTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.txtTieuDe.Location = new System.Drawing.Point(3, 0);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(1081, 65);
            this.txtTieuDe.TabIndex = 0;
            this.txtTieuDe.Text = "Thông Tin Xe Đạp Điện";
            this.txtTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbHienThiXe
            // 
            this.tbHienThiXe.AutoScroll = true;
            this.tbHienThiXe.ColumnCount = 2;
            this.tbHienThiXe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tbHienThiXe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tbHienThiXe.Controls.Add(this.tbHienThiBang, 1, 0);
            this.tbHienThiXe.Controls.Add(this.grTTXe, 0, 0);
            this.tbHienThiXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHienThiXe.Location = new System.Drawing.Point(3, 68);
            this.tbHienThiXe.Name = "tbHienThiXe";
            this.tbHienThiXe.RowCount = 1;
            this.tbHienThiXe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbHienThiXe.Size = new System.Drawing.Size(1081, 587);
            this.tbHienThiXe.TabIndex = 1;
            // 
            // tbHienThiBang
            // 
            this.tbHienThiBang.ColumnCount = 1;
            this.tbHienThiBang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 643F));
            this.tbHienThiBang.Controls.Add(this.grTTBang, 0, 0);
            this.tbHienThiBang.Controls.Add(this.grTacVu, 0, 1);
            this.tbHienThiBang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHienThiBang.Location = new System.Drawing.Point(435, 3);
            this.tbHienThiBang.Name = "tbHienThiBang";
            this.tbHienThiBang.RowCount = 2;
            this.tbHienThiBang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tbHienThiBang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tbHienThiBang.Size = new System.Drawing.Size(643, 581);
            this.tbHienThiBang.TabIndex = 0;
            // 
            // grTTBang
            // 
            this.grTTBang.Controls.Add(this.dataDSXe);
            this.grTTBang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTTBang.Location = new System.Drawing.Point(3, 3);
            this.grTTBang.Name = "grTTBang";
            this.grTTBang.Size = new System.Drawing.Size(637, 487);
            this.grTTBang.TabIndex = 0;
            this.grTTBang.TabStop = false;
            this.grTTBang.Text = "Danh sách xe đạp điện";
            // 
            // dataDSXe
            // 
            this.dataDSXe.AllowUserToAddRows = false;
            this.dataDSXe.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDSXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataDSXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDSXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnMaXeDapDien,
            this.columnTenXe,
            this.columnDongXe,
            this.columnMauSac,
            this.columnSLAcQuy,
            this.columnDLAcQuy,
            this.columnGia,
            this.columnHinhAnh});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDSXe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataDSXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDSXe.Location = new System.Drawing.Point(3, 26);
            this.dataDSXe.Name = "dataDSXe";
            this.dataDSXe.RowHeadersWidth = 51;
            this.dataDSXe.RowTemplate.Height = 24;
            this.dataDSXe.Size = new System.Drawing.Size(631, 458);
            this.dataDSXe.TabIndex = 0;
            // 
            // grTacVu
            // 
            this.grTacVu.Controls.Add(this.btnLamMoi);
            this.grTacVu.Controls.Add(this.btnXoa);
            this.grTacVu.Controls.Add(this.btnSua);
            this.grTacVu.Controls.Add(this.btnThem);
            this.grTacVu.Location = new System.Drawing.Point(3, 496);
            this.grTacVu.Name = "grTacVu";
            this.grTacVu.Size = new System.Drawing.Size(397, 79);
            this.grTacVu.TabIndex = 1;
            this.grTacVu.TabStop = false;
            this.grTacVu.Text = "Tác vụ";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(285, 29);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(103, 39);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(192, 29);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 39);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(99, 29);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 39);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(6, 29);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 39);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // grTTXe
            // 
            this.grTTXe.Controls.Add(this.lbSoBinhAcQuy);
            this.grTTXe.Controls.Add(this.lbSLAcQuy);
            this.grTTXe.Controls.Add(this.lbBaoHanh);
            this.grTTXe.Controls.Add(this.lbGia);
            this.grTTXe.Controls.Add(this.lbMaXe);
            this.grTTXe.Controls.Add(this.lbTenXe);
            this.grTTXe.Controls.Add(this.lbDongXe);
            this.grTTXe.Controls.Add(this.picAnhXe);
            this.grTTXe.Controls.Add(this.txtSLAcQuy);
            this.grTTXe.Controls.Add(this.txtDLAcQuy);
            this.grTTXe.Controls.Add(this.txtBaoHanh);
            this.grTTXe.Controls.Add(this.txtGia);
            this.grTTXe.Controls.Add(this.txtTenXe);
            this.grTTXe.Controls.Add(this.txtMaXe);
            this.grTTXe.Controls.Add(this.txtDongXe);
            this.grTTXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTTXe.Location = new System.Drawing.Point(3, 3);
            this.grTTXe.Name = "grTTXe";
            this.grTTXe.Size = new System.Drawing.Size(426, 581);
            this.grTTXe.TabIndex = 1;
            this.grTTXe.TabStop = false;
            this.grTTXe.Text = "Thông tin xe";
            // 
            // lbSoBinhAcQuy
            // 
            this.lbSoBinhAcQuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSoBinhAcQuy.Location = new System.Drawing.Point(193, 490);
            this.lbSoBinhAcQuy.Name = "lbSoBinhAcQuy";
            this.lbSoBinhAcQuy.Size = new System.Drawing.Size(54, 30);
            this.lbSoBinhAcQuy.TabIndex = 16;
            // 
            // lbSLAcQuy
            // 
            this.lbSLAcQuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSLAcQuy.Location = new System.Drawing.Point(193, 426);
            this.lbSLAcQuy.Name = "lbSLAcQuy";
            this.lbSLAcQuy.Size = new System.Drawing.Size(54, 30);
            this.lbSLAcQuy.TabIndex = 15;
            // 
            // lbBaoHanh
            // 
            this.lbBaoHanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBaoHanh.Location = new System.Drawing.Point(293, 365);
            this.lbBaoHanh.Name = "lbBaoHanh";
            this.lbBaoHanh.Size = new System.Drawing.Size(54, 30);
            this.lbBaoHanh.TabIndex = 14;
            // 
            // lbGia
            // 
            this.lbGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbGia.Location = new System.Drawing.Point(58, 365);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(100, 30);
            this.lbGia.TabIndex = 12;
            // 
            // lbMaXe
            // 
            this.lbMaXe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMaXe.Location = new System.Drawing.Point(93, 236);
            this.lbMaXe.Name = "lbMaXe";
            this.lbMaXe.Size = new System.Drawing.Size(100, 30);
            this.lbMaXe.TabIndex = 11;
            // 
            // lbTenXe
            // 
            this.lbTenXe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTenXe.Location = new System.Drawing.Point(93, 175);
            this.lbTenXe.Name = "lbTenXe";
            this.lbTenXe.Size = new System.Drawing.Size(100, 30);
            this.lbTenXe.TabIndex = 10;
            // 
            // lbDongXe
            // 
            this.lbDongXe.FormattingEnabled = true;
            this.lbDongXe.Location = new System.Drawing.Point(93, 296);
            this.lbDongXe.Name = "lbDongXe";
            this.lbDongXe.Size = new System.Drawing.Size(121, 31);
            this.lbDongXe.TabIndex = 9;
            // 
            // picAnhXe
            // 
            this.picAnhXe.BackColor = System.Drawing.Color.White;
            this.picAnhXe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhXe.Location = new System.Drawing.Point(111, 45);
            this.picAnhXe.Name = "picAnhXe";
            this.picAnhXe.Size = new System.Drawing.Size(176, 95);
            this.picAnhXe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhXe.TabIndex = 8;
            this.picAnhXe.TabStop = false;
            // 
            // txtSLAcQuy
            // 
            this.txtSLAcQuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.txtSLAcQuy.Location = new System.Drawing.Point(6, 492);
            this.txtSLAcQuy.Name = "txtSLAcQuy";
            this.txtSLAcQuy.Size = new System.Drawing.Size(152, 28);
            this.txtSLAcQuy.TabIndex = 7;
            this.txtSLAcQuy.Text = "Số Bình Ắc Quy:";
            // 
            // txtDLAcQuy
            // 
            this.txtDLAcQuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.txtDLAcQuy.Location = new System.Drawing.Point(6, 428);
            this.txtDLAcQuy.Name = "txtDLAcQuy";
            this.txtDLAcQuy.Size = new System.Drawing.Size(175, 24);
            this.txtDLAcQuy.TabIndex = 6;
            this.txtDLAcQuy.Text = "Dung Lượng Ắc Quy:";
            // 
            // txtBaoHanh
            // 
            this.txtBaoHanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.txtBaoHanh.Location = new System.Drawing.Point(189, 367);
            this.txtBaoHanh.Name = "txtBaoHanh";
            this.txtBaoHanh.Size = new System.Drawing.Size(98, 21);
            this.txtBaoHanh.TabIndex = 5;
            this.txtBaoHanh.Text = "Bảo Hành:";
            // 
            // txtGia
            // 
            this.txtGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.txtGia.Location = new System.Drawing.Point(6, 367);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(44, 21);
            this.txtGia.TabIndex = 3;
            this.txtGia.Text = "Giá:";
            // 
            // txtTenXe
            // 
            this.txtTenXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.txtTenXe.Location = new System.Drawing.Point(6, 177);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(81, 21);
            this.txtTenXe.TabIndex = 2;
            this.txtTenXe.Text = "Tên Xe:";
            // 
            // txtMaXe
            // 
            this.txtMaXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.txtMaXe.Location = new System.Drawing.Point(6, 238);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(70, 21);
            this.txtMaXe.TabIndex = 1;
            this.txtMaXe.Text = "Mã Xe:";
            // 
            // txtDongXe
            // 
            this.txtDongXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.txtDongXe.Location = new System.Drawing.Point(6, 299);
            this.txtDongXe.Name = "txtDongXe";
            this.txtDongXe.Size = new System.Drawing.Size(84, 28);
            this.txtDongXe.TabIndex = 0;
            this.txtDongXe.Text = "Dòng Xe:";
            // 
            // columnMaXeDapDien
            // 
            this.columnMaXeDapDien.HeaderText = "Mã Xe Đạp Điện";
            this.columnMaXeDapDien.MinimumWidth = 6;
            this.columnMaXeDapDien.Name = "columnMaXeDapDien";
            this.columnMaXeDapDien.ReadOnly = true;
            this.columnMaXeDapDien.Width = 125;
            // 
            // columnTenXe
            // 
            this.columnTenXe.HeaderText = "Tên Xe";
            this.columnTenXe.MinimumWidth = 6;
            this.columnTenXe.Name = "columnTenXe";
            this.columnTenXe.ReadOnly = true;
            this.columnTenXe.Width = 125;
            // 
            // columnDongXe
            // 
            this.columnDongXe.HeaderText = "Dòng Xe";
            this.columnDongXe.MinimumWidth = 6;
            this.columnDongXe.Name = "columnDongXe";
            this.columnDongXe.ReadOnly = true;
            this.columnDongXe.Width = 125;
            // 
            // columnMauSac
            // 
            this.columnMauSac.HeaderText = "Màu Sắc";
            this.columnMauSac.MinimumWidth = 6;
            this.columnMauSac.Name = "columnMauSac";
            this.columnMauSac.ReadOnly = true;
            this.columnMauSac.Width = 125;
            // 
            // columnSLAcQuy
            // 
            this.columnSLAcQuy.HeaderText = "Số Bình Ắc Quy";
            this.columnSLAcQuy.MinimumWidth = 6;
            this.columnSLAcQuy.Name = "columnSLAcQuy";
            this.columnSLAcQuy.ReadOnly = true;
            this.columnSLAcQuy.Width = 125;
            // 
            // columnDLAcQuy
            // 
            this.columnDLAcQuy.HeaderText = "Dung Lượng Ắc Quy";
            this.columnDLAcQuy.MinimumWidth = 6;
            this.columnDLAcQuy.Name = "columnDLAcQuy";
            this.columnDLAcQuy.ReadOnly = true;
            this.columnDLAcQuy.Width = 125;
            // 
            // columnGia
            // 
            this.columnGia.HeaderText = "Giá";
            this.columnGia.MinimumWidth = 6;
            this.columnGia.Name = "columnGia";
            this.columnGia.ReadOnly = true;
            this.columnGia.Width = 125;
            // 
            // columnHinhAnh
            // 
            this.columnHinhAnh.HeaderText = "Hình Ảnh";
            this.columnHinhAnh.MinimumWidth = 6;
            this.columnHinhAnh.Name = "columnHinhAnh";
            this.columnHinhAnh.ReadOnly = true;
            this.columnHinhAnh.Width = 125;
            // 
            // QLXeDapDienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1087, 658);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "QLXeDapDienForm";
            this.Text = "QLXeDapDienForm";
            this.panel1.ResumeLayout(false);
            this.tbTong.ResumeLayout(false);
            this.tbHienThiXe.ResumeLayout(false);
            this.tbHienThiBang.ResumeLayout(false);
            this.grTTBang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDSXe)).EndInit();
            this.grTacVu.ResumeLayout(false);
            this.grTTXe.ResumeLayout(false);
            this.grTTXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbSoBinhAcQuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbSLAcQuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbBaoHanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhXe)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tbTong;
        private System.Windows.Forms.Label txtTieuDe;
        private System.Windows.Forms.TableLayoutPanel tbHienThiXe;
        private System.Windows.Forms.TableLayoutPanel tbHienThiBang;
        private System.Windows.Forms.GroupBox grTTBang;
        private System.Windows.Forms.GroupBox grTTXe;
        private System.Windows.Forms.GroupBox grTacVu;
        private System.Windows.Forms.Label txtSLAcQuy;
        private System.Windows.Forms.Label txtDLAcQuy;
        private System.Windows.Forms.Label txtBaoHanh;
        private System.Windows.Forms.Label txtGia;
        private System.Windows.Forms.Label txtTenXe;
        private System.Windows.Forms.Label txtMaXe;
        private System.Windows.Forms.Label txtDongXe;
        private System.Windows.Forms.DataGridView dataDSXe;
        private System.Windows.Forms.NumericUpDown lbSoBinhAcQuy;
        private System.Windows.Forms.NumericUpDown lbSLAcQuy;
        private System.Windows.Forms.NumericUpDown lbBaoHanh;
        private System.Windows.Forms.TextBox lbGia;
        private System.Windows.Forms.TextBox lbMaXe;
        private System.Windows.Forms.TextBox lbTenXe;
        private System.Windows.Forms.ComboBox lbDongXe;
        private System.Windows.Forms.PictureBox picAnhXe;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private DataGridViewTextBoxColumn columnMaXeDapDien;
        private DataGridViewTextBoxColumn columnTenXe;
        private DataGridViewTextBoxColumn columnDongXe;
        private DataGridViewTextBoxColumn columnMauSac;
        private DataGridViewTextBoxColumn columnSLAcQuy;
        private DataGridViewTextBoxColumn columnDLAcQuy;
        private DataGridViewTextBoxColumn columnGia;
        private DataGridViewTextBoxColumn columnHinhAnh;
    }
}