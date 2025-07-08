﻿using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLXe
{
    partial class usXeMayDien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTong = new System.Windows.Forms.TableLayoutPanel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.tbHienThiXe = new System.Windows.Forms.TableLayoutPanel();
            this.tbHienThiBang = new System.Windows.Forms.TableLayoutPanel();
            this.grpDSXeMayDien = new System.Windows.Forms.GroupBox();
            this.dgvDSXeMayDien = new System.Windows.Forms.DataGridView();
            this.colMaXeDapDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoBinhAcQuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDungLuongAcQuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.picAnhXe = new System.Windows.Forms.PictureBox();
            this.lblSoBinhAcQuy = new System.Windows.Forms.Label();
            this.lblDungLuongAcQuy = new System.Windows.Forms.Label();
            this.lblMauSac = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTenXe = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tbTong.SuspendLayout();
            this.tbHienThiXe.SuspendLayout();
            this.tbHienThiBang.SuspendLayout();
            this.grpDSXeMayDien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSXeMayDien)).BeginInit();
            this.grpTacVu.SuspendLayout();
            this.grpTTXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhXe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(26)))), ((int)(((byte)(139)))));
            this.lblTieuDe.Location = new System.Drawing.Point(3, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(994, 112);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "THÔNG TIN XE MÁY ĐIỆN";
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
            this.tbHienThiBang.Controls.Add(this.grpDSXeMayDien, 0, 0);
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
            // grpDSXeMayDien
            // 
            this.grpDSXeMayDien.Controls.Add(this.dgvDSXeMayDien);
            this.grpDSXeMayDien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDSXeMayDien.Location = new System.Drawing.Point(3, 3);
            this.grpDSXeMayDien.Name = "grpDSXeMayDien";
            this.grpDSXeMayDien.Size = new System.Drawing.Size(585, 494);
            this.grpDSXeMayDien.TabIndex = 0;
            this.grpDSXeMayDien.TabStop = false;
            this.grpDSXeMayDien.Text = "Danh sách xe máy điện";
            // 
            // dgvDSXeMayDien
            // 
            this.dgvDSXeMayDien.AllowUserToAddRows = false;
            this.dgvDSXeMayDien.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSXeMayDien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSXeMayDien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaXeDapDien,
            this.colMaDaiLy,
            this.colTenXe,
            this.colMauSac,
            this.colSoBinhAcQuy,
            this.colDungLuongAcQuy,
            this.colGia,
            this.colHinhAnh});
            this.dgvDSXeMayDien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSXeMayDien.Location = new System.Drawing.Point(3, 26);
            this.dgvDSXeMayDien.Name = "dgvDSXeMayDien";
            this.dgvDSXeMayDien.RowHeadersWidth = 51;
            this.dgvDSXeMayDien.Size = new System.Drawing.Size(579, 465);
            this.dgvDSXeMayDien.TabIndex = 0;
            // 
            // colMaXeDapDien
            // 
            this.colMaXeDapDien.HeaderText = "Mã Xe Máy Điện";
            this.colMaXeDapDien.MinimumWidth = 6;
            this.colMaXeDapDien.Name = "colMaXeDapDien";
            this.colMaXeDapDien.ReadOnly = true;
            this.colMaXeDapDien.Width = 175;
            // 
            // colMaDaiLy
            // 
            this.colMaDaiLy.HeaderText = "Mã Đại Lý";
            this.colMaDaiLy.MinimumWidth = 6;
            this.colMaDaiLy.Name = "colMaDaiLy";
            this.colMaDaiLy.ReadOnly = true;
            this.colMaDaiLy.Width = 125;
            // 
            // colTenXe
            // 
            this.colTenXe.HeaderText = "Tên Xe";
            this.colTenXe.MinimumWidth = 6;
            this.colTenXe.Name = "colTenXe";
            this.colTenXe.ReadOnly = true;
            this.colTenXe.Width = 125;
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
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
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
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
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
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
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
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
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
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grpTTXe
            // 
            this.grpTTXe.Controls.Add(this.txtSoBinhAcQuy);
            this.grpTTXe.Controls.Add(this.txtDungLuongAcQuy);
            this.grpTTXe.Controls.Add(this.txtBaoHanh);
            this.grpTTXe.Controls.Add(this.txtGia);
            this.grpTTXe.Controls.Add(this.txtTenXe);
            this.grpTTXe.Controls.Add(this.picAnhXe);
            this.grpTTXe.Controls.Add(this.lblSoBinhAcQuy);
            this.grpTTXe.Controls.Add(this.lblDungLuongAcQuy);
            this.grpTTXe.Controls.Add(this.lblMauSac);
            this.grpTTXe.Controls.Add(this.lblGia);
            this.grpTTXe.Controls.Add(this.lblTenXe);
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
            this.txtSoBinhAcQuy.Location = new System.Drawing.Point(187, 547);
            this.txtSoBinhAcQuy.Name = "txtSoBinhAcQuy";
            this.txtSoBinhAcQuy.Size = new System.Drawing.Size(117, 30);
            this.txtSoBinhAcQuy.TabIndex = 15;
            // 
            // txtDungLuongAcQuy
            // 
            this.txtDungLuongAcQuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDungLuongAcQuy.Location = new System.Drawing.Point(187, 457);
            this.txtDungLuongAcQuy.Name = "txtDungLuongAcQuy";
            this.txtDungLuongAcQuy.Size = new System.Drawing.Size(117, 30);
            this.txtDungLuongAcQuy.TabIndex = 14;
            // 
            // txtBaoHanh
            // 
            this.txtBaoHanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBaoHanh.Location = new System.Drawing.Point(110, 370);
            this.txtBaoHanh.Name = "txtBaoHanh";
            this.txtBaoHanh.Size = new System.Drawing.Size(118, 30);
            this.txtBaoHanh.TabIndex = 13;
            // 
            // txtGia
            // 
            this.txtGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGia.Location = new System.Drawing.Point(110, 283);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(118, 30);
            this.txtGia.TabIndex = 12;
            // 
            // txtTenXe
            // 
            this.txtTenXe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenXe.Location = new System.Drawing.Point(111, 196);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(117, 30);
            this.txtTenXe.TabIndex = 10;
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
            this.lblSoBinhAcQuy.Location = new System.Drawing.Point(6, 549);
            this.lblSoBinhAcQuy.Name = "lblSoBinhAcQuy";
            this.lblSoBinhAcQuy.Size = new System.Drawing.Size(152, 28);
            this.lblSoBinhAcQuy.TabIndex = 7;
            this.lblSoBinhAcQuy.Text = "Số Bình Ắc Quy:";
            // 
            // lblDungLuongAcQuy
            // 
            this.lblDungLuongAcQuy.Location = new System.Drawing.Point(6, 459);
            this.lblDungLuongAcQuy.Name = "lblDungLuongAcQuy";
            this.lblDungLuongAcQuy.Size = new System.Drawing.Size(175, 24);
            this.lblDungLuongAcQuy.TabIndex = 6;
            this.lblDungLuongAcQuy.Text = "Dung Lượng Ắc Quy:";
            // 
            // lblMauSac
            // 
            this.lblMauSac.Location = new System.Drawing.Point(8, 372);
            this.lblMauSac.Name = "lblMauSac";
            this.lblMauSac.Size = new System.Drawing.Size(98, 21);
            this.lblMauSac.TabIndex = 5;
            this.lblMauSac.Text = "Màu Sắc:";
            // 
            // lblGia
            // 
            this.lblGia.Location = new System.Drawing.Point(8, 285);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(44, 21);
            this.lblGia.TabIndex = 3;
            this.lblGia.Text = "Giá:";
            // 
            // lblTenXe
            // 
            this.lblTenXe.Location = new System.Drawing.Point(6, 198);
            this.lblTenXe.Name = "lblTenXe";
            this.lblTenXe.Size = new System.Drawing.Size(81, 21);
            this.lblTenXe.TabIndex = 2;
            this.lblTenXe.Text = "Tên Xe:";
            // 
            // usXeMayDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "usXeMayDien";
            this.Size = new System.Drawing.Size(1000, 750);
            this.panel1.ResumeLayout(false);
            this.tbTong.ResumeLayout(false);
            this.tbHienThiXe.ResumeLayout(false);
            this.tbHienThiBang.ResumeLayout(false);
            this.grpDSXeMayDien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSXeMayDien)).EndInit();
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
        private System.Windows.Forms.GroupBox grpDSXeMayDien;
        private System.Windows.Forms.GroupBox grpTTXe;
        private System.Windows.Forms.GroupBox grpTacVu;
        private System.Windows.Forms.Label lblSoBinhAcQuy;
        private System.Windows.Forms.Label lblDungLuongAcQuy;
        private System.Windows.Forms.Label lblMauSac;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTenXe;
        private System.Windows.Forms.DataGridView dgvDSXeMayDien;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.PictureBox picAnhXe;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private TextBox txtSoBinhAcQuy;
        private TextBox txtDungLuongAcQuy;
        private TextBox txtBaoHanh;
        private DataGridViewTextBoxColumn colMaXeDapDien;
        private DataGridViewTextBoxColumn colMaDaiLy;
        private DataGridViewTextBoxColumn colTenXe;
        private DataGridViewTextBoxColumn colMauSac;
        private DataGridViewTextBoxColumn colSoBinhAcQuy;
        private DataGridViewTextBoxColumn colDungLuongAcQuy;
        private DataGridViewTextBoxColumn colGia;
        private DataGridViewTextBoxColumn colHinhAnh;
    }
}
