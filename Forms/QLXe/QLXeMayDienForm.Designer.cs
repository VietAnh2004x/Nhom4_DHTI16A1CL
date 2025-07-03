using System.Drawing;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLXe
{
    partial class QLXeMayDienForm
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.tbHienThiXe = new System.Windows.Forms.TableLayoutPanel();
            this.tbHienThiBang = new System.Windows.Forms.TableLayoutPanel();
            this.grpDSXeMayDien = new System.Windows.Forms.GroupBox();
            this.grvDSXeMayDien = new System.Windows.Forms.DataGridView();
            this.grpTacVu = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grpTTXe = new System.Windows.Forms.GroupBox();
            this.nudSoBinhAcQuy = new System.Windows.Forms.NumericUpDown();
            this.nudDungLuongAcQuy = new System.Windows.Forms.NumericUpDown();
            this.nudBaoHanh = new System.Windows.Forms.NumericUpDown();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.cboDongXe = new System.Windows.Forms.ComboBox();
            this.picAnhXe = new System.Windows.Forms.PictureBox();
            this.lblSoBinhAcQuy = new System.Windows.Forms.Label();
            this.lblDungLuongAcQuy = new System.Windows.Forms.Label();
            this.lblBaoHanh = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTenXe = new System.Windows.Forms.Label();
            this.lblMaXe = new System.Windows.Forms.Label();
            this.lblDongXe = new System.Windows.Forms.Label();
            this.colMaXeDapDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDongXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoBinhAcQuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDungLuongAcQuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tbTong.SuspendLayout();
            this.tbHienThiXe.SuspendLayout();
            this.tbHienThiBang.SuspendLayout();
            this.grpDSXeMayDien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDSXeMayDien)).BeginInit();
            this.grpTacVu.SuspendLayout();
            this.grpTTXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoBinhAcQuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDungLuongAcQuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaoHanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhXe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbTong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 683);
            this.panel1.TabIndex = 0;
            // 
            // tbTong
            // 
            this.tbTong.ColumnCount = 1;
            this.tbTong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbTong.Controls.Add(this.lblTieuDe, 0, 0);
            this.tbTong.Controls.Add(this.tbHienThiXe, 0, 1);
            this.tbTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTong.Location = new System.Drawing.Point(0, 0);
            this.tbTong.Name = "tbTong";
            this.tbTong.RowCount = 2;
            this.tbTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tbTong.Size = new System.Drawing.Size(1178, 683);
            this.tbTong.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(26)))), ((int)(((byte)(139)))));
            this.lblTieuDe.Location = new System.Drawing.Point(3, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1172, 68);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Thông Tin Xe Máy Điện";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbHienThiXe
            // 
            this.tbHienThiXe.AutoScroll = true;
            this.tbHienThiXe.ColumnCount = 2;
            this.tbHienThiXe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tbHienThiXe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tbHienThiXe.Controls.Add(this.tbHienThiBang, 1, 0);
            this.tbHienThiXe.Controls.Add(this.grpTTXe, 0, 0);
            this.tbHienThiXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHienThiXe.Location = new System.Drawing.Point(3, 71);
            this.tbHienThiXe.Name = "tbHienThiXe";
            this.tbHienThiXe.RowCount = 1;
            this.tbHienThiXe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbHienThiXe.Size = new System.Drawing.Size(1172, 609);
            this.tbHienThiXe.TabIndex = 1;
            // 
            // tbHienThiBang
            // 
            this.tbHienThiBang.ColumnCount = 1;
            this.tbHienThiBang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 698F));
            this.tbHienThiBang.Controls.Add(this.grpDSXeMayDien, 0, 0);
            this.tbHienThiBang.Controls.Add(this.grpTacVu, 0, 1);
            this.tbHienThiBang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHienThiBang.Location = new System.Drawing.Point(471, 3);
            this.tbHienThiBang.Name = "tbHienThiBang";
            this.tbHienThiBang.RowCount = 2;
            this.tbHienThiBang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tbHienThiBang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tbHienThiBang.Size = new System.Drawing.Size(698, 603);
            this.tbHienThiBang.TabIndex = 0;
            // 
            // grpDSXeMayDien
            // 
            this.grpDSXeMayDien.Controls.Add(this.grvDSXeMayDien);
            this.grpDSXeMayDien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDSXeMayDien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(26)))), ((int)(((byte)(139)))));
            this.grpDSXeMayDien.Location = new System.Drawing.Point(3, 3);
            this.grpDSXeMayDien.Name = "grpDSXeMayDien";
            this.grpDSXeMayDien.Size = new System.Drawing.Size(692, 506);
            this.grpDSXeMayDien.TabIndex = 0;
            this.grpDSXeMayDien.TabStop = false;
            this.grpDSXeMayDien.Text = "Danh sách xe máy điện";
            // 
            // grvDSXeMayDien
            // 
            this.grvDSXeMayDien.AllowUserToAddRows = false;
            this.grvDSXeMayDien.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvDSXeMayDien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvDSXeMayDien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDSXeMayDien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaXeDapDien,
            this.colTenXe,
            this.colDongXe,
            this.colMauSac,
            this.colSoBinhAcQuy,
            this.colDungLuongAcQuy,
            this.colGia,
            this.colHinhAnh});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(26)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvDSXeMayDien.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvDSXeMayDien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvDSXeMayDien.Location = new System.Drawing.Point(3, 21);
            this.grvDSXeMayDien.Name = "grvDSXeMayDien";
            this.grvDSXeMayDien.RowHeadersWidth = 51;
            this.grvDSXeMayDien.RowTemplate.Height = 24;
            this.grvDSXeMayDien.Size = new System.Drawing.Size(686, 482);
            this.grvDSXeMayDien.TabIndex = 0;
            // 
            // grpTacVu
            // 
            this.grpTacVu.Controls.Add(this.btnLamMoi);
            this.grpTacVu.Controls.Add(this.btnXoa);
            this.grpTacVu.Controls.Add(this.btnSua);
            this.grpTacVu.Controls.Add(this.btnThem);
            this.grpTacVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTacVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(26)))), ((int)(((byte)(139)))));
            this.grpTacVu.Location = new System.Drawing.Point(3, 515);
            this.grpTacVu.Name = "grpTacVu";
            this.grpTacVu.Size = new System.Drawing.Size(692, 85);
            this.grpTacVu.TabIndex = 1;
            this.grpTacVu.TabStop = false;
            this.grpTacVu.Text = "Tác vụ";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(390, 29);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(103, 39);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(271, 29);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 39);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(152, 29);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 39);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(33, 29);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 39);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // grpTTXe
            // 
            this.grpTTXe.Controls.Add(this.nudSoBinhAcQuy);
            this.grpTTXe.Controls.Add(this.nudDungLuongAcQuy);
            this.grpTTXe.Controls.Add(this.nudBaoHanh);
            this.grpTTXe.Controls.Add(this.txtGia);
            this.grpTTXe.Controls.Add(this.txtMaXe);
            this.grpTTXe.Controls.Add(this.txtTenXe);
            this.grpTTXe.Controls.Add(this.cboDongXe);
            this.grpTTXe.Controls.Add(this.picAnhXe);
            this.grpTTXe.Controls.Add(this.lblSoBinhAcQuy);
            this.grpTTXe.Controls.Add(this.lblDungLuongAcQuy);
            this.grpTTXe.Controls.Add(this.lblBaoHanh);
            this.grpTTXe.Controls.Add(this.lblGia);
            this.grpTTXe.Controls.Add(this.lblTenXe);
            this.grpTTXe.Controls.Add(this.lblMaXe);
            this.grpTTXe.Controls.Add(this.lblDongXe);
            this.grpTTXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTTXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(26)))), ((int)(((byte)(139)))));
            this.grpTTXe.Location = new System.Drawing.Point(3, 3);
            this.grpTTXe.Name = "grpTTXe";
            this.grpTTXe.Size = new System.Drawing.Size(462, 603);
            this.grpTTXe.TabIndex = 1;
            this.grpTTXe.TabStop = false;
            this.grpTTXe.Text = "Thông tin xe";
            // 
            // nudSoBinhAcQuy
            // 
            this.nudSoBinhAcQuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSoBinhAcQuy.Location = new System.Drawing.Point(187, 493);
            this.nudSoBinhAcQuy.Name = "nudSoBinhAcQuy";
            this.nudSoBinhAcQuy.Size = new System.Drawing.Size(54, 25);
            this.nudSoBinhAcQuy.TabIndex = 16;
            // 
            // nudDungLuongAcQuy
            // 
            this.nudDungLuongAcQuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudDungLuongAcQuy.Location = new System.Drawing.Point(187, 427);
            this.nudDungLuongAcQuy.Name = "nudDungLuongAcQuy";
            this.nudDungLuongAcQuy.Size = new System.Drawing.Size(54, 25);
            this.nudDungLuongAcQuy.TabIndex = 15;
            // 
            // nudBaoHanh
            // 
            this.nudBaoHanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudBaoHanh.Location = new System.Drawing.Point(330, 364);
            this.nudBaoHanh.Name = "nudBaoHanh";
            this.nudBaoHanh.Size = new System.Drawing.Size(54, 25);
            this.nudBaoHanh.TabIndex = 14;
            // 
            // txtGia
            // 
            this.txtGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGia.Location = new System.Drawing.Point(58, 364);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 25);
            this.txtGia.TabIndex = 12;
            // 
            // txtMaXe
            // 
            this.txtMaXe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaXe.Location = new System.Drawing.Point(96, 240);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(100, 25);
            this.txtMaXe.TabIndex = 11;
            // 
            // txtTenXe
            // 
            this.txtTenXe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenXe.Location = new System.Drawing.Point(96, 177);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(100, 25);
            this.txtTenXe.TabIndex = 10;
            // 
            // cboDongXe
            // 
            this.cboDongXe.FormattingEnabled = true;
            this.cboDongXe.Location = new System.Drawing.Point(96, 300);
            this.cboDongXe.Name = "cboDongXe";
            this.cboDongXe.Size = new System.Drawing.Size(121, 25);
            this.cboDongXe.TabIndex = 9;
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
            // lblSoBinhAcQuy
            // 
            this.lblSoBinhAcQuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblSoBinhAcQuy.Location = new System.Drawing.Point(6, 495);
            this.lblSoBinhAcQuy.Name = "lblSoBinhAcQuy";
            this.lblSoBinhAcQuy.Size = new System.Drawing.Size(152, 28);
            this.lblSoBinhAcQuy.TabIndex = 7;
            this.lblSoBinhAcQuy.Text = "Số Bình Ắc Quy:";
            // 
            // lblDungLuongAcQuy
            // 
            this.lblDungLuongAcQuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblDungLuongAcQuy.Location = new System.Drawing.Point(6, 429);
            this.lblDungLuongAcQuy.Name = "lblDungLuongAcQuy";
            this.lblDungLuongAcQuy.Size = new System.Drawing.Size(175, 24);
            this.lblDungLuongAcQuy.TabIndex = 6;
            this.lblDungLuongAcQuy.Text = "Dung Lượng Ắc Quy:";
            // 
            // lblBaoHanh
            // 
            this.lblBaoHanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblBaoHanh.Location = new System.Drawing.Point(226, 366);
            this.lblBaoHanh.Name = "lblBaoHanh";
            this.lblBaoHanh.Size = new System.Drawing.Size(98, 21);
            this.lblBaoHanh.TabIndex = 5;
            this.lblBaoHanh.Text = "Bảo Hành:";
            // 
            // lblGia
            // 
            this.lblGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblGia.Location = new System.Drawing.Point(6, 366);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(44, 21);
            this.lblGia.TabIndex = 3;
            this.lblGia.Text = "Giá:";
            // 
            // lblTenXe
            // 
            this.lblTenXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblTenXe.Location = new System.Drawing.Point(6, 177);
            this.lblTenXe.Name = "lblTenXe";
            this.lblTenXe.Size = new System.Drawing.Size(81, 21);
            this.lblTenXe.TabIndex = 2;
            this.lblTenXe.Text = "Tên Xe:";
            // 
            // lblMaXe
            // 
            this.lblMaXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblMaXe.Location = new System.Drawing.Point(6, 240);
            this.lblMaXe.Name = "lblMaXe";
            this.lblMaXe.Size = new System.Drawing.Size(70, 21);
            this.lblMaXe.TabIndex = 1;
            this.lblMaXe.Text = "Mã Xe:";
            // 
            // lblDongXe
            // 
            this.lblDongXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblDongXe.Location = new System.Drawing.Point(6, 303);
            this.lblDongXe.Name = "lblDongXe";
            this.lblDongXe.Size = new System.Drawing.Size(84, 21);
            this.lblDongXe.TabIndex = 0;
            this.lblDongXe.Text = "Dòng Xe:";
            // 
            // colMaXeDapDien
            // 
            this.colMaXeDapDien.HeaderText = "Mã Xe Máy Điện";
            this.colMaXeDapDien.MinimumWidth = 6;
            this.colMaXeDapDien.Name = "colMaXeDapDien";
            this.colMaXeDapDien.ReadOnly = true;
            this.colMaXeDapDien.Width = 175;
            // 
            // colTenXe
            // 
            this.colTenXe.HeaderText = "Tên Xe";
            this.colTenXe.MinimumWidth = 6;
            this.colTenXe.Name = "colTenXe";
            this.colTenXe.ReadOnly = true;
            this.colTenXe.Width = 125;
            // 
            // colDongXe
            // 
            this.colDongXe.HeaderText = "Dòng Xe";
            this.colDongXe.MinimumWidth = 6;
            this.colDongXe.Name = "colDongXe";
            this.colDongXe.ReadOnly = true;
            this.colDongXe.Width = 125;
            // 
            // colMauSac
            // 
            this.colMauSac.HeaderText = "Màu Sắc";
            this.colMauSac.MinimumWidth = 6;
            this.colMauSac.Name = "colMauSac";
            this.colMauSac.ReadOnly = true;
            this.colMauSac.Width = 125;
            // 
            // colSoBinhAcQuy
            // 
            this.colSoBinhAcQuy.HeaderText = "Số Bình Ắc Quy";
            this.colSoBinhAcQuy.MinimumWidth = 6;
            this.colSoBinhAcQuy.Name = "colSoBinhAcQuy";
            this.colSoBinhAcQuy.ReadOnly = true;
            this.colSoBinhAcQuy.Width = 175;
            // 
            // colDungLuongAcQuy
            // 
            this.colDungLuongAcQuy.HeaderText = "Dung Lượng Ắc Quy";
            this.colDungLuongAcQuy.MinimumWidth = 6;
            this.colDungLuongAcQuy.Name = "colDungLuongAcQuy";
            this.colDungLuongAcQuy.ReadOnly = true;
            this.colDungLuongAcQuy.Width = 200;
            // 
            // colGia
            // 
            this.colGia.HeaderText = "Giá";
            this.colGia.MinimumWidth = 6;
            this.colGia.Name = "colGia";
            this.colGia.ReadOnly = true;
            this.colGia.Width = 125;
            // 
            // colHinhAnh
            // 
            this.colHinhAnh.HeaderText = "Hình Ảnh";
            this.colHinhAnh.MinimumWidth = 6;
            this.colHinhAnh.Name = "colHinhAnh";
            this.colHinhAnh.ReadOnly = true;
            this.colHinhAnh.Width = 125;
            // 
            // QLXeMayDienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1178, 683);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "QLXeMayDienForm";
            this.Text = "QLXeMayDienForm";
            this.panel1.ResumeLayout(false);
            this.tbTong.ResumeLayout(false);
            this.tbHienThiXe.ResumeLayout(false);
            this.tbHienThiBang.ResumeLayout(false);
            this.grpDSXeMayDien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvDSXeMayDien)).EndInit();
            this.grpTacVu.ResumeLayout(false);
            this.grpTTXe.ResumeLayout(false);
            this.grpTTXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoBinhAcQuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDungLuongAcQuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaoHanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhXe)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tbTong;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TableLayoutPanel tbHienThiXe;
        private System.Windows.Forms.TableLayoutPanel tbHienThiBang;
        private System.Windows.Forms.GroupBox grpDSXeMayDien;
        private System.Windows.Forms.GroupBox grpTTXe;
        private System.Windows.Forms.GroupBox grpTacVu;
        private System.Windows.Forms.Label lblSoBinhAcQuy;
        private System.Windows.Forms.Label lblDungLuongAcQuy;
        private System.Windows.Forms.Label lblBaoHanh;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTenXe;
        private System.Windows.Forms.Label lblMaXe;
        private System.Windows.Forms.Label lblDongXe;
        private System.Windows.Forms.DataGridView grvDSXeMayDien;
        private System.Windows.Forms.NumericUpDown nudSoBinhAcQuy;
        private System.Windows.Forms.NumericUpDown nudDungLuongAcQuy;
        private System.Windows.Forms.NumericUpDown nudBaoHanh;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.ComboBox cboDongXe;
        private System.Windows.Forms.PictureBox picAnhXe;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private DataGridViewTextBoxColumn colMaXeDapDien;
        private DataGridViewTextBoxColumn colTenXe;
        private DataGridViewTextBoxColumn colDongXe;
        private DataGridViewTextBoxColumn colMauSac;
        private DataGridViewTextBoxColumn colSoBinhAcQuy;
        private DataGridViewTextBoxColumn colDungLuongAcQuy;
        private DataGridViewTextBoxColumn colGia;
        private DataGridViewTextBoxColumn colHinhAnh;
    }
}