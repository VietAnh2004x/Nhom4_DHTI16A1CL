using System.Drawing;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLTonKho
{
    partial class TonKhoForm
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
            this.tbHienThi = new System.Windows.Forms.TableLayoutPanel();
            this.tbTrai = new System.Windows.Forms.TableLayoutPanel();
            this.grpTTXe = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtNgayNhap = new System.Windows.Forms.TextBox();
            this.txtNhaSanXuat = new System.Windows.Forms.TextBox();
            this.txtDongXe = new System.Windows.Forms.TextBox();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblNhaSanXuat = new System.Windows.Forms.Label();
            this.lblDongXe = new System.Windows.Forms.Label();
            this.lblTenXe = new System.Windows.Forms.Label();
            this.lblMaXe = new System.Windows.Forms.Label();
            this.grpTacVu = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbPhai = new System.Windows.Forms.TableLayoutPanel();
            this.grpTimKiemXe = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiemXe = new System.Windows.Forms.TextBox();
            this.lblTimKiemXe = new System.Windows.Forms.Label();
            this.grpDSXe = new System.Windows.Forms.GroupBox();
            this.dgvDSXe = new System.Windows.Forms.DataGridView();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.colMaXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDongXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tbTong.SuspendLayout();
            this.tbHienThi.SuspendLayout();
            this.tbTrai.SuspendLayout();
            this.grpTTXe.SuspendLayout();
            this.grpTacVu.SuspendLayout();
            this.tbPhai.SuspendLayout();
            this.grpTimKiemXe.SuspendLayout();
            this.grpDSXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSXe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.tbTong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 686);
            this.panel1.TabIndex = 0;
            // 
            // tbTong
            // 
            this.tbTong.ColumnCount = 1;
            this.tbTong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 948F));
            this.tbTong.Controls.Add(this.tbHienThi, 0, 1);
            this.tbTong.Controls.Add(this.lblTieuDe, 0, 0);
            this.tbTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTong.Location = new System.Drawing.Point(0, 0);
            this.tbTong.Name = "tbTong";
            this.tbTong.RowCount = 2;
            this.tbTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tbTong.Size = new System.Drawing.Size(948, 686);
            this.tbTong.TabIndex = 0;
            // 
            // tbHienThi
            // 
            this.tbHienThi.AutoSize = true;
            this.tbHienThi.ColumnCount = 2;
            this.tbHienThi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tbHienThi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tbHienThi.Controls.Add(this.tbTrai, 0, 0);
            this.tbHienThi.Controls.Add(this.tbPhai, 1, 0);
            this.tbHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHienThi.Location = new System.Drawing.Point(3, 71);
            this.tbHienThi.Name = "tbHienThi";
            this.tbHienThi.RowCount = 1;
            this.tbHienThi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 612F));
            this.tbHienThi.Size = new System.Drawing.Size(942, 612);
            this.tbHienThi.TabIndex = 0;
            // 
            // tbTrai
            // 
            this.tbTrai.ColumnCount = 1;
            this.tbTrai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 370F));
            this.tbTrai.Controls.Add(this.grpTTXe, 0, 0);
            this.tbTrai.Controls.Add(this.grpTacVu, 0, 1);
            this.tbTrai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTrai.Location = new System.Drawing.Point(3, 3);
            this.tbTrai.Name = "tbTrai";
            this.tbTrai.RowCount = 2;
            this.tbTrai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tbTrai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbTrai.Size = new System.Drawing.Size(370, 606);
            this.tbTrai.TabIndex = 0;
            // 
            // grpTTXe
            // 
            this.grpTTXe.Controls.Add(this.txtSoLuong);
            this.grpTTXe.Controls.Add(this.lblSoLuong);
            this.grpTTXe.Controls.Add(this.txtNgayNhap);
            this.grpTTXe.Controls.Add(this.txtNhaSanXuat);
            this.grpTTXe.Controls.Add(this.txtDongXe);
            this.grpTTXe.Controls.Add(this.txtTenXe);
            this.grpTTXe.Controls.Add(this.txtMaXe);
            this.grpTTXe.Controls.Add(this.lblNgayNhap);
            this.grpTTXe.Controls.Add(this.lblNhaSanXuat);
            this.grpTTXe.Controls.Add(this.lblDongXe);
            this.grpTTXe.Controls.Add(this.lblTenXe);
            this.grpTTXe.Controls.Add(this.lblMaXe);
            this.grpTTXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTTXe.Location = new System.Drawing.Point(3, 3);
            this.grpTTXe.Name = "grpTTXe";
            this.grpTTXe.Size = new System.Drawing.Size(364, 478);
            this.grpTTXe.TabIndex = 0;
            this.grpTTXe.TabStop = false;
            this.grpTTXe.Text = "Thông Tin Xe";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(122, 386);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(145, 25);
            this.txtSoLuong.TabIndex = 12;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Location = new System.Drawing.Point(6, 389);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(100, 23);
            this.lblSoLuong.TabIndex = 11;
            this.lblSoLuong.Text = "Số Lượng:";
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.Location = new System.Drawing.Point(122, 324);
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.Size = new System.Drawing.Size(145, 25);
            this.txtNgayNhap.TabIndex = 10;
            // 
            // txtNhaSanXuat
            // 
            this.txtNhaSanXuat.Location = new System.Drawing.Point(122, 262);
            this.txtNhaSanXuat.Name = "txtNhaSanXuat";
            this.txtNhaSanXuat.Size = new System.Drawing.Size(145, 25);
            this.txtNhaSanXuat.TabIndex = 9;
            // 
            // txtDongXe
            // 
            this.txtDongXe.Location = new System.Drawing.Point(122, 200);
            this.txtDongXe.Name = "txtDongXe";
            this.txtDongXe.Size = new System.Drawing.Size(145, 25);
            this.txtDongXe.TabIndex = 8;
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(122, 138);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(145, 25);
            this.txtTenXe.TabIndex = 7;
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(122, 76);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(145, 25);
            this.txtMaXe.TabIndex = 6;
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.Location = new System.Drawing.Point(6, 327);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(100, 23);
            this.lblNgayNhap.TabIndex = 5;
            this.lblNgayNhap.Text = "Ngày Nhập:";
            // 
            // lblNhaSanXuat
            // 
            this.lblNhaSanXuat.Location = new System.Drawing.Point(6, 265);
            this.lblNhaSanXuat.Name = "lblNhaSanXuat";
            this.lblNhaSanXuat.Size = new System.Drawing.Size(110, 23);
            this.lblNhaSanXuat.TabIndex = 4;
            this.lblNhaSanXuat.Text = "Nhà Sản Xuất:";
            // 
            // lblDongXe
            // 
            this.lblDongXe.Location = new System.Drawing.Point(6, 203);
            this.lblDongXe.Name = "lblDongXe";
            this.lblDongXe.Size = new System.Drawing.Size(100, 23);
            this.lblDongXe.TabIndex = 3;
            this.lblDongXe.Text = "Dòng Xe:";
            // 
            // lblTenXe
            // 
            this.lblTenXe.Location = new System.Drawing.Point(6, 141);
            this.lblTenXe.Name = "lblTenXe";
            this.lblTenXe.Size = new System.Drawing.Size(100, 23);
            this.lblTenXe.TabIndex = 2;
            this.lblTenXe.Text = "Tên Xe:";
            // 
            // lblMaXe
            // 
            this.lblMaXe.Location = new System.Drawing.Point(6, 79);
            this.lblMaXe.Name = "lblMaXe";
            this.lblMaXe.Size = new System.Drawing.Size(100, 23);
            this.lblMaXe.TabIndex = 1;
            this.lblMaXe.Text = "Mã Xe:";
            // 
            // grpTacVu
            // 
            this.grpTacVu.Controls.Add(this.btnLamMoi);
            this.grpTacVu.Controls.Add(this.btnXoa);
            this.grpTacVu.Controls.Add(this.btnSua);
            this.grpTacVu.Controls.Add(this.btnThem);
            this.grpTacVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTacVu.Location = new System.Drawing.Point(3, 487);
            this.grpTacVu.Name = "grpTacVu";
            this.grpTacVu.Size = new System.Drawing.Size(364, 116);
            this.grpTacVu.TabIndex = 1;
            this.grpTacVu.TabStop = false;
            this.grpTacVu.Text = "Tác Vụ";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(144, 74);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 28);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(26, 74);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 28);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(144, 30);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 28);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(26, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 28);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // tbPhai
            // 
            this.tbPhai.ColumnCount = 1;
            this.tbPhai.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 560F));
            this.tbPhai.Controls.Add(this.grpTimKiemXe, 0, 0);
            this.tbPhai.Controls.Add(this.grpDSXe, 0, 1);
            this.tbPhai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPhai.Location = new System.Drawing.Point(379, 3);
            this.tbPhai.Name = "tbPhai";
            this.tbPhai.RowCount = 2;
            this.tbPhai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbPhai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tbPhai.Size = new System.Drawing.Size(560, 606);
            this.tbPhai.TabIndex = 1;
            // 
            // grpTimKiemXe
            // 
            this.grpTimKiemXe.Controls.Add(this.btnTimKiem);
            this.grpTimKiemXe.Controls.Add(this.txtTimKiemXe);
            this.grpTimKiemXe.Controls.Add(this.lblTimKiemXe);
            this.grpTimKiemXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTimKiemXe.Location = new System.Drawing.Point(3, 3);
            this.grpTimKiemXe.Name = "grpTimKiemXe";
            this.grpTimKiemXe.Size = new System.Drawing.Size(554, 115);
            this.grpTimKiemXe.TabIndex = 0;
            this.grpTimKiemXe.TabStop = false;
            this.grpTimKiemXe.Text = "Tìm Kiếm Xe";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Orange;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(290, 55);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 28);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtTimKiemXe
            // 
            this.txtTimKiemXe.Location = new System.Drawing.Point(106, 57);
            this.txtTimKiemXe.Name = "txtTimKiemXe";
            this.txtTimKiemXe.Size = new System.Drawing.Size(145, 25);
            this.txtTimKiemXe.TabIndex = 1;
            // 
            // lblTimKiemXe
            // 
            this.lblTimKiemXe.Location = new System.Drawing.Point(19, 60);
            this.lblTimKiemXe.Name = "lblTimKiemXe";
            this.lblTimKiemXe.Size = new System.Drawing.Size(100, 23);
            this.lblTimKiemXe.TabIndex = 0;
            this.lblTimKiemXe.Text = "Tên Xe:";
            // 
            // grpDSXe
            // 
            this.grpDSXe.Controls.Add(this.dgvDSXe);
            this.grpDSXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDSXe.Location = new System.Drawing.Point(3, 124);
            this.grpDSXe.Name = "grpDSXe";
            this.grpDSXe.Size = new System.Drawing.Size(554, 479);
            this.grpDSXe.TabIndex = 1;
            this.grpDSXe.TabStop = false;
            this.grpDSXe.Text = "Danh Sách Xe";
            // 
            // dgvDSXe
            // 
            this.dgvDSXe.AllowUserToAddRows = false;
            this.dgvDSXe.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaXe,
            this.colTenXe,
            this.colDongXe,
            this.colNhaSanXuat,
            this.colNgayNhap,
            this.colSoLuong});
            this.dgvDSXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSXe.Location = new System.Drawing.Point(3, 21);
            this.dgvDSXe.Name = "dgvDSXe";
            this.dgvDSXe.Size = new System.Drawing.Size(548, 455);
            this.dgvDSXe.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.lblTieuDe.Location = new System.Drawing.Point(3, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(942, 68);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "Quản Lý Tồn Kho";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colMaXe
            // 
            this.colMaXe.HeaderText = "Mã Xe";
            this.colMaXe.Name = "colMaXe";
            this.colMaXe.ReadOnly = true;
            // 
            // colTenXe
            // 
            this.colTenXe.HeaderText = "Tên Xe";
            this.colTenXe.Name = "colTenXe";
            this.colTenXe.ReadOnly = true;
            // 
            // colDongXe
            // 
            this.colDongXe.HeaderText = "Dòng Xe";
            this.colDongXe.Name = "colDongXe";
            this.colDongXe.ReadOnly = true;
            // 
            // colNhaSanXuat
            // 
            this.colNhaSanXuat.HeaderText = "Nhà Sản Xuất";
            this.colNhaSanXuat.Name = "colNhaSanXuat";
            this.colNhaSanXuat.ReadOnly = true;
            this.colNhaSanXuat.Width = 150;
            // 
            // colNgayNhap
            // 
            this.colNgayNhap.HeaderText = "Ngày Nhập";
            this.colNgayNhap.Name = "colNgayNhap";
            this.colNgayNhap.ReadOnly = true;
            this.colNgayNhap.Width = 125;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // TonKhoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 686);
            this.Controls.Add(this.panel1);
            this.Name = "TonKhoForm";
            this.Text = "TonKhoForm";
            this.panel1.ResumeLayout(false);
            this.tbTong.ResumeLayout(false);
            this.tbTong.PerformLayout();
            this.tbHienThi.ResumeLayout(false);
            this.tbTrai.ResumeLayout(false);
            this.grpTTXe.ResumeLayout(false);
            this.grpTTXe.PerformLayout();
            this.grpTacVu.ResumeLayout(false);
            this.tbPhai.ResumeLayout(false);
            this.grpTimKiemXe.ResumeLayout(false);
            this.grpTimKiemXe.PerformLayout();
            this.grpDSXe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSXe)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tbTong;
        private System.Windows.Forms.TableLayoutPanel tbHienThi;
        private System.Windows.Forms.TableLayoutPanel tbTrai;
        private System.Windows.Forms.TableLayoutPanel tbPhai;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpTTXe;
        private System.Windows.Forms.GroupBox grpTacVu;
        private System.Windows.Forms.GroupBox grpTimKiemXe;
        private System.Windows.Forms.GroupBox grpDSXe;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiemXe;
        private System.Windows.Forms.Label lblTimKiemXe;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblNhaSanXuat;
        private System.Windows.Forms.Label lblDongXe;
        private System.Windows.Forms.Label lblTenXe;
        private System.Windows.Forms.Label lblMaXe;
        private System.Windows.Forms.DataGridView dgvDSXe;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtNgayNhap;
        private System.Windows.Forms.TextBox txtNhaSanXuat;
        private System.Windows.Forms.TextBox txtDongXe;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.TextBox txtMaXe;
        private DataGridViewTextBoxColumn colMaXe;
        private DataGridViewTextBoxColumn colTenXe;
        private DataGridViewTextBoxColumn colDongXe;
        private DataGridViewTextBoxColumn colNhaSanXuat;
        private DataGridViewTextBoxColumn colNgayNhap;
        private DataGridViewTextBoxColumn colSoLuong;
    }
}