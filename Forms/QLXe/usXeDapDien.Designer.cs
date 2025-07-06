using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLXe
{
    partial class usXeDapDien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTong = new System.Windows.Forms.TableLayoutPanel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.tbHienThiXe = new System.Windows.Forms.TableLayoutPanel();
            this.tbHienThiBang = new System.Windows.Forms.TableLayoutPanel();
            this.grpDSXeDapDien = new System.Windows.Forms.GroupBox();
            this.dgvDSXeDapDien = new System.Windows.Forms.DataGridView();
            this.grpTacVu = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grpTTXe = new System.Windows.Forms.GroupBox();
            this.txtSoBinhAcQuy = new System.Windows.Forms.TextBox();
            this.txtDungLuongAcQuy = new System.Windows.Forms.TextBox();
            this.txtBaoHanh = new System.Windows.Forms.TextBox();
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
            this.colMaXeDapDien = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.grpDSXeDapDien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSXeDapDien)).BeginInit();
            this.grpTacVu.SuspendLayout();
            this.grpTTXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhXe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(248)))), ((int)(((byte)(233)))));
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
            this.tbTong.Controls.Add(this.lblTieuDe, 0, 0);
            this.tbTong.Controls.Add(this.tbHienThiXe, 0, 1);
            this.tbTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTong.Location = new System.Drawing.Point(0, 0);
            this.tbTong.Name = "tbTong";
            this.tbTong.RowCount = 2;
            this.tbTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tbTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tbTong.Size = new System.Drawing.Size(1000, 750);
            this.tbTong.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(105)))), ((int)(((byte)(30)))));
            this.lblTieuDe.Location = new System.Drawing.Point(3, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(994, 112);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "THÔNG TIN XE ĐẠP ĐIỆN";
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
            this.tbHienThiXe.Location = new System.Drawing.Point(3, 115);
            this.tbHienThiXe.Name = "tbHienThiXe";
            this.tbHienThiXe.RowCount = 1;
            this.tbHienThiXe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbHienThiXe.Size = new System.Drawing.Size(994, 632);
            this.tbHienThiXe.TabIndex = 1;
            // 
            // tbHienThiBang
            // 
            this.tbHienThiBang.ColumnCount = 1;
            this.tbHienThiBang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 591F));
            this.tbHienThiBang.Controls.Add(this.grpDSXeDapDien, 0, 0);
            this.tbHienThiBang.Controls.Add(this.grpTacVu, 0, 1);
            this.tbHienThiBang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHienThiBang.Location = new System.Drawing.Point(400, 3);
            this.tbHienThiBang.Name = "tbHienThiBang";
            this.tbHienThiBang.RowCount = 2;
            this.tbHienThiBang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tbHienThiBang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbHienThiBang.Size = new System.Drawing.Size(591, 626);
            this.tbHienThiBang.TabIndex = 0;
            // 
            // grpDSXeDapDien
            // 
            this.grpDSXeDapDien.Controls.Add(this.dgvDSXeDapDien);
            this.grpDSXeDapDien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDSXeDapDien.Location = new System.Drawing.Point(3, 3);
            this.grpDSXeDapDien.Name = "grpDSXeDapDien";
            this.grpDSXeDapDien.Size = new System.Drawing.Size(585, 494);
            this.grpDSXeDapDien.TabIndex = 0;
            this.grpDSXeDapDien.TabStop = false;
            this.grpDSXeDapDien.Text = "Danh sách xe đạp điện";
            // 
            // dgvDSXeDapDien
            // 
            this.dgvDSXeDapDien.AllowUserToAddRows = false;
            this.dgvDSXeDapDien.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSXeDapDien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSXeDapDien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSXeDapDien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaXeDapDien,
            this.colTenXe,
            this.colDongXe,
            this.colMauSac,
            this.colSoBinhAcQuy,
            this.colDungLuongAcQuy,
            this.colGia,
            this.colHinhAnh});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSXeDapDien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSXeDapDien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSXeDapDien.Location = new System.Drawing.Point(3, 21);
            this.dgvDSXeDapDien.Name = "dgvDSXeDapDien";
            this.dgvDSXeDapDien.RowHeadersWidth = 51;
            this.dgvDSXeDapDien.RowTemplate.Height = 24;
            this.dgvDSXeDapDien.Size = new System.Drawing.Size(579, 470);
            this.dgvDSXeDapDien.TabIndex = 0;
            // 
            // grpTacVu
            // 
            this.grpTacVu.Controls.Add(this.btnLamMoi);
            this.grpTacVu.Controls.Add(this.btnXoa);
            this.grpTacVu.Controls.Add(this.btnSua);
            this.grpTacVu.Controls.Add(this.btnThem);
            this.grpTacVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTacVu.Location = new System.Drawing.Point(3, 503);
            this.grpTacVu.Name = "grpTacVu";
            this.grpTacVu.Size = new System.Drawing.Size(585, 120);
            this.grpTacVu.TabIndex = 1;
            this.grpTacVu.TabStop = false;
            this.grpTacVu.Text = "Tác vụ";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(79)))));
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(457, 52);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 35);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(319, 52);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(181, 52);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 35);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(43, 52);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // grpTTXe
            // 
            this.grpTTXe.Controls.Add(this.txtSoBinhAcQuy);
            this.grpTTXe.Controls.Add(this.txtDungLuongAcQuy);
            this.grpTTXe.Controls.Add(this.txtBaoHanh);
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
            this.grpTTXe.Location = new System.Drawing.Point(3, 3);
            this.grpTTXe.Name = "grpTTXe";
            this.grpTTXe.Size = new System.Drawing.Size(391, 626);
            this.grpTTXe.TabIndex = 1;
            this.grpTTXe.TabStop = false;
            this.grpTTXe.Text = "Thông tin xe";
            // 
            // txtSoBinhAcQuy
            // 
            this.txtSoBinhAcQuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoBinhAcQuy.Location = new System.Drawing.Point(140, 550);
            this.txtSoBinhAcQuy.Name = "txtSoBinhAcQuy";
            this.txtSoBinhAcQuy.Size = new System.Drawing.Size(100, 25);
            this.txtSoBinhAcQuy.TabIndex = 15;
            // 
            // txtDungLuongAcQuy
            // 
            this.txtDungLuongAcQuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDungLuongAcQuy.Location = new System.Drawing.Point(150, 474);
            this.txtDungLuongAcQuy.Name = "txtDungLuongAcQuy";
            this.txtDungLuongAcQuy.Size = new System.Drawing.Size(100, 25);
            this.txtDungLuongAcQuy.TabIndex = 14;
            // 
            // txtBaoHanh
            // 
            this.txtBaoHanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBaoHanh.Location = new System.Drawing.Point(267, 401);
            this.txtBaoHanh.Name = "txtBaoHanh";
            this.txtBaoHanh.Size = new System.Drawing.Size(100, 25);
            this.txtBaoHanh.TabIndex = 13;
            // 
            // txtGia
            // 
            this.txtGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGia.Location = new System.Drawing.Point(56, 401);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 25);
            this.txtGia.TabIndex = 12;
            // 
            // txtMaXe
            // 
            this.txtMaXe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaXe.Location = new System.Drawing.Point(96, 248);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(100, 25);
            this.txtMaXe.TabIndex = 11;
            // 
            // txtTenXe
            // 
            this.txtTenXe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenXe.Location = new System.Drawing.Point(96, 175);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(100, 25);
            this.txtTenXe.TabIndex = 10;
            // 
            // cboDongXe
            // 
            this.cboDongXe.FormattingEnabled = true;
            this.cboDongXe.Location = new System.Drawing.Point(96, 320);
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
            this.lblSoBinhAcQuy.Location = new System.Drawing.Point(6, 552);
            this.lblSoBinhAcQuy.Name = "lblSoBinhAcQuy";
            this.lblSoBinhAcQuy.Size = new System.Drawing.Size(152, 28);
            this.lblSoBinhAcQuy.TabIndex = 7;
            this.lblSoBinhAcQuy.Text = "Số Bình Ắc Quy:";
            // 
            // lblDungLuongAcQuy
            // 
            this.lblDungLuongAcQuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblDungLuongAcQuy.Location = new System.Drawing.Point(6, 476);
            this.lblDungLuongAcQuy.Name = "lblDungLuongAcQuy";
            this.lblDungLuongAcQuy.Size = new System.Drawing.Size(175, 24);
            this.lblDungLuongAcQuy.TabIndex = 6;
            this.lblDungLuongAcQuy.Text = "Dung Lượng Ắc Quy:";
            // 
            // lblBaoHanh
            // 
            this.lblBaoHanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblBaoHanh.Location = new System.Drawing.Point(172, 403);
            this.lblBaoHanh.Name = "lblBaoHanh";
            this.lblBaoHanh.Size = new System.Drawing.Size(98, 21);
            this.lblBaoHanh.TabIndex = 5;
            this.lblBaoHanh.Text = "Bảo Hành:";
            // 
            // lblGia
            // 
            this.lblGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblGia.Location = new System.Drawing.Point(6, 403);
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
            this.lblMaXe.Location = new System.Drawing.Point(6, 250);
            this.lblMaXe.Name = "lblMaXe";
            this.lblMaXe.Size = new System.Drawing.Size(70, 21);
            this.lblMaXe.TabIndex = 1;
            this.lblMaXe.Text = "Mã Xe:";
            // 
            // lblDongXe
            // 
            this.lblDongXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblDongXe.Location = new System.Drawing.Point(6, 323);
            this.lblDongXe.Name = "lblDongXe";
            this.lblDongXe.Size = new System.Drawing.Size(84, 28);
            this.lblDongXe.TabIndex = 0;
            this.lblDongXe.Text = "Dòng Xe:";
            // 
            // colMaXeDapDien
            // 
            this.colMaXeDapDien.DefaultCellStyle = dataGridViewCellStyle2;
            this.colMaXeDapDien.HeaderText = "Mã Xe Đạp Điện";
            this.colMaXeDapDien.MinimumWidth = 6;
            this.colMaXeDapDien.Name = "colMaXeDapDien";
            this.colMaXeDapDien.ReadOnly = true;
            this.colMaXeDapDien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaXeDapDien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // usXeDapDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "usXeDapDien";
            this.Size = new System.Drawing.Size(1000, 750);
            this.panel1.ResumeLayout(false);
            this.tbTong.ResumeLayout(false);
            this.tbHienThiXe.ResumeLayout(false);
            this.tbHienThiBang.ResumeLayout(false);
            this.grpDSXeDapDien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSXeDapDien)).EndInit();
            this.grpTacVu.ResumeLayout(false);
            this.grpTTXe.ResumeLayout(false);
            this.grpTTXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhXe)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tbTong;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TableLayoutPanel tbHienThiXe;
        private System.Windows.Forms.TableLayoutPanel tbHienThiBang;
        private System.Windows.Forms.GroupBox grpDSXeDapDien;
        private System.Windows.Forms.GroupBox grpTTXe;
        private System.Windows.Forms.GroupBox grpTacVu;
        private System.Windows.Forms.Label lblSoBinhAcQuy;
        private System.Windows.Forms.Label lblDungLuongAcQuy;
        private System.Windows.Forms.Label lblBaoHanh;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTenXe;
        private System.Windows.Forms.Label lblMaXe;
        private System.Windows.Forms.Label lblDongXe;
        private System.Windows.Forms.DataGridView dgvDSXeDapDien;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.ComboBox cboDongXe;
        private System.Windows.Forms.PictureBox picAnhXe;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private TextBox txtSoBinhAcQuy;
        private TextBox txtDungLuongAcQuy;
        private TextBox txtBaoHanh;
        private DataGridViewButtonColumn colMaXeDapDien;
        private DataGridViewTextBoxColumn colTenXe;
        private DataGridViewTextBoxColumn colDongXe;
        private DataGridViewTextBoxColumn colMauSac;
        private DataGridViewTextBoxColumn colSoBinhAcQuy;
        private DataGridViewTextBoxColumn colDungLuongAcQuy;
        private DataGridViewTextBoxColumn colGia;
        private DataGridViewTextBoxColumn colHinhAnh;
    }
}
