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
            this.grTTXe = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtNgayNhap = new System.Windows.Forms.Label();
            this.txtNSX = new System.Windows.Forms.Label();
            this.txtDongXe = new System.Windows.Forms.Label();
            this.txtTenXe = new System.Windows.Forms.Label();
            this.txtMaXe = new System.Windows.Forms.Label();
            this.grTacVu = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbPhai = new System.Windows.Forms.TableLayoutPanel();
            this.grTimKiemXe = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTenXe1 = new System.Windows.Forms.Label();
            this.grDSXe = new System.Windows.Forms.GroupBox();
            this.dataDSXe = new System.Windows.Forms.DataGridView();
            this.column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDongXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNXS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTieuDe = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tbTong.SuspendLayout();
            this.tbHienThi.SuspendLayout();
            this.tbTrai.SuspendLayout();
            this.grTTXe.SuspendLayout();
            this.grTacVu.SuspendLayout();
            this.tbPhai.SuspendLayout();
            this.grTimKiemXe.SuspendLayout();
            this.grDSXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDSXe)).BeginInit();
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
            this.tbTong.Controls.Add(this.txtTieuDe, 0, 0);
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
            this.tbTrai.Controls.Add(this.grTTXe, 0, 0);
            this.tbTrai.Controls.Add(this.grTacVu, 0, 1);
            this.tbTrai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTrai.Location = new System.Drawing.Point(3, 3);
            this.tbTrai.Name = "tbTrai";
            this.tbTrai.RowCount = 2;
            this.tbTrai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tbTrai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbTrai.Size = new System.Drawing.Size(370, 606);
            this.tbTrai.TabIndex = 0;
            // 
            // grTTXe
            // 
            this.grTTXe.Controls.Add(this.textBox7);
            this.grTTXe.Controls.Add(this.txtSoLuong);
            this.grTTXe.Controls.Add(this.textBox6);
            this.grTTXe.Controls.Add(this.textBox5);
            this.grTTXe.Controls.Add(this.textBox4);
            this.grTTXe.Controls.Add(this.textBox3);
            this.grTTXe.Controls.Add(this.textBox2);
            this.grTTXe.Controls.Add(this.txtNgayNhap);
            this.grTTXe.Controls.Add(this.txtNSX);
            this.grTTXe.Controls.Add(this.txtDongXe);
            this.grTTXe.Controls.Add(this.txtTenXe);
            this.grTTXe.Controls.Add(this.txtMaXe);
            this.grTTXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTTXe.Location = new System.Drawing.Point(3, 3);
            this.grTTXe.Name = "grTTXe";
            this.grTTXe.Size = new System.Drawing.Size(364, 478);
            this.grTTXe.TabIndex = 0;
            this.grTTXe.TabStop = false;
            this.grTTXe.Text = "Thông Tin Xe";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(122, 386);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(145, 25);
            this.textBox7.TabIndex = 12;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(6, 389);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 23);
            this.txtSoLuong.TabIndex = 11;
            this.txtSoLuong.Text = "Số Lượng:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(122, 324);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(145, 25);
            this.textBox6.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(122, 262);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(145, 25);
            this.textBox5.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(122, 200);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 25);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(122, 138);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(145, 25);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 25);
            this.textBox2.TabIndex = 6;
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.Location = new System.Drawing.Point(6, 327);
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.Size = new System.Drawing.Size(100, 23);
            this.txtNgayNhap.TabIndex = 5;
            this.txtNgayNhap.Text = "Ngày Nhập:";
            // 
            // txtNSX
            // 
            this.txtNSX.Location = new System.Drawing.Point(6, 265);
            this.txtNSX.Name = "txtNSX";
            this.txtNSX.Size = new System.Drawing.Size(110, 23);
            this.txtNSX.TabIndex = 4;
            this.txtNSX.Text = "Nhà Sản Xuất:";
            // 
            // txtDongXe
            // 
            this.txtDongXe.Location = new System.Drawing.Point(6, 203);
            this.txtDongXe.Name = "txtDongXe";
            this.txtDongXe.Size = new System.Drawing.Size(100, 23);
            this.txtDongXe.TabIndex = 3;
            this.txtDongXe.Text = "Dòng Xe:";
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(6, 141);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(100, 23);
            this.txtTenXe.TabIndex = 2;
            this.txtTenXe.Text = "Tên Xe:";
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(6, 79);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(100, 23);
            this.txtMaXe.TabIndex = 1;
            this.txtMaXe.Text = "Mã Xe:";
            // 
            // grTacVu
            // 
            this.grTacVu.Controls.Add(this.btnLamMoi);
            this.grTacVu.Controls.Add(this.btnXoa);
            this.grTacVu.Controls.Add(this.btnSua);
            this.grTacVu.Controls.Add(this.btnThem);
            this.grTacVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTacVu.Location = new System.Drawing.Point(3, 487);
            this.grTacVu.Name = "grTacVu";
            this.grTacVu.Size = new System.Drawing.Size(364, 116);
            this.grTacVu.TabIndex = 1;
            this.grTacVu.TabStop = false;
            this.grTacVu.Text = "Tác Vụ";
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
            this.tbPhai.Controls.Add(this.grTimKiemXe, 0, 0);
            this.tbPhai.Controls.Add(this.grDSXe, 0, 1);
            this.tbPhai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPhai.Location = new System.Drawing.Point(379, 3);
            this.tbPhai.Name = "tbPhai";
            this.tbPhai.RowCount = 2;
            this.tbPhai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbPhai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tbPhai.Size = new System.Drawing.Size(560, 606);
            this.tbPhai.TabIndex = 1;
            // 
            // grTimKiemXe
            // 
            this.grTimKiemXe.Controls.Add(this.btnTimKiem);
            this.grTimKiemXe.Controls.Add(this.textBox1);
            this.grTimKiemXe.Controls.Add(this.txtTenXe1);
            this.grTimKiemXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTimKiemXe.Location = new System.Drawing.Point(3, 3);
            this.grTimKiemXe.Name = "grTimKiemXe";
            this.grTimKiemXe.Size = new System.Drawing.Size(554, 115);
            this.grTimKiemXe.TabIndex = 0;
            this.grTimKiemXe.TabStop = false;
            this.grTimKiemXe.Text = "Tìm Kiếm Xe";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 25);
            this.textBox1.TabIndex = 1;
            // 
            // txtTenXe1
            // 
            this.txtTenXe1.Location = new System.Drawing.Point(19, 60);
            this.txtTenXe1.Name = "txtTenXe1";
            this.txtTenXe1.Size = new System.Drawing.Size(100, 23);
            this.txtTenXe1.TabIndex = 0;
            this.txtTenXe1.Text = "Tên Xe:";
            // 
            // grDSXe
            // 
            this.grDSXe.Controls.Add(this.dataDSXe);
            this.grDSXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDSXe.Location = new System.Drawing.Point(3, 124);
            this.grDSXe.Name = "grDSXe";
            this.grDSXe.Size = new System.Drawing.Size(554, 479);
            this.grDSXe.TabIndex = 1;
            this.grDSXe.TabStop = false;
            this.grDSXe.Text = "Danh Sách Xe";
            // 
            // dataDSXe
            // 
            this.dataDSXe.AllowUserToAddRows = false;
            this.dataDSXe.BackgroundColor = System.Drawing.Color.White;
            this.dataDSXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDSXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column,
            this.columnTenXe,
            this.columnDongXe,
            this.columnNXS,
            this.columnNgayNhap,
            this.columnSoLuong});
            this.dataDSXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDSXe.Location = new System.Drawing.Point(3, 21);
            this.dataDSXe.Name = "dataDSXe";
            this.dataDSXe.Size = new System.Drawing.Size(548, 455);
            this.dataDSXe.TabIndex = 0;
            // 
            // column
            // 
            this.column.HeaderText = "Mã Xe";
            this.column.Name = "column";
            this.column.ReadOnly = true;
            // 
            // columnTenXe
            // 
            this.columnTenXe.HeaderText = "Tên Xe";
            this.columnTenXe.Name = "columnTenXe";
            this.columnTenXe.ReadOnly = true;
            // 
            // columnDongXe
            // 
            this.columnDongXe.HeaderText = "Dòng Xe";
            this.columnDongXe.Name = "columnDongXe";
            this.columnDongXe.ReadOnly = true;
            // 
            // columnNXS
            // 
            this.columnNXS.HeaderText = "Nhà Sản Xuất";
            this.columnNXS.Name = "columnNXS";
            this.columnNXS.ReadOnly = true;
            this.columnNXS.Width = 150;
            // 
            // columnNgayNhap
            // 
            this.columnNgayNhap.HeaderText = "Ngày Nhập";
            this.columnNgayNhap.Name = "columnNgayNhap";
            this.columnNgayNhap.ReadOnly = true;
            this.columnNgayNhap.Width = 125;
            // 
            // columnSoLuong
            // 
            this.columnSoLuong.HeaderText = "Số Lượng";
            this.columnSoLuong.Name = "columnSoLuong";
            this.columnSoLuong.ReadOnly = true;
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTieuDe.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.txtTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.txtTieuDe.Location = new System.Drawing.Point(3, 0);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(942, 68);
            this.txtTieuDe.TabIndex = 1;
            this.txtTieuDe.Text = "Quản Lý Tồn Kho";
            this.txtTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.grTTXe.ResumeLayout(false);
            this.grTTXe.PerformLayout();
            this.grTacVu.ResumeLayout(false);
            this.tbPhai.ResumeLayout(false);
            this.grTimKiemXe.ResumeLayout(false);
            this.grTimKiemXe.PerformLayout();
            this.grDSXe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDSXe)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tbTong;
        private System.Windows.Forms.TableLayoutPanel tbHienThi;
        private System.Windows.Forms.TableLayoutPanel tbTrai;
        private System.Windows.Forms.TableLayoutPanel tbPhai;
        private System.Windows.Forms.Label txtTieuDe;
        private System.Windows.Forms.GroupBox grTTXe;
        private System.Windows.Forms.GroupBox grTacVu;
        private System.Windows.Forms.GroupBox grTimKiemXe;
        private System.Windows.Forms.GroupBox grDSXe;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtTenXe1;
        private System.Windows.Forms.Label txtNgayNhap;
        private System.Windows.Forms.Label txtNSX;
        private System.Windows.Forms.Label txtDongXe;
        private System.Windows.Forms.Label txtTenXe;
        private System.Windows.Forms.Label txtMaXe;
        private System.Windows.Forms.DataGridView dataDSXe;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label txtSoLuong;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private DataGridViewTextBoxColumn column;
        private DataGridViewTextBoxColumn columnTenXe;
        private DataGridViewTextBoxColumn columnDongXe;
        private DataGridViewTextBoxColumn columnNXS;
        private DataGridViewTextBoxColumn columnNgayNhap;
        private DataGridViewTextBoxColumn columnSoLuong;
    }
}