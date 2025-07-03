using System.Drawing;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLDaiLy
{
    partial class DaiLyForm
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
            this.grTTDaiLy = new System.Windows.Forms.GroupBox();
            this.tbSoDienThoai = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTenDaiLy = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbMaDaiLy = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.Label();
            this.txtTenDaiLy = new System.Windows.Forms.Label();
            this.txtMaDaiLy = new System.Windows.Forms.Label();
            this.grTacVu = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbPhai = new System.Windows.Forms.TableLayoutPanel();
            this.grDaiLy = new System.Windows.Forms.GroupBox();
            this.tbTimKiemDaiLy = new System.Windows.Forms.TextBox();
            this.lbTimKiemDaiLy = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grDSDaiLy = new System.Windows.Forms.GroupBox();
            this.dataDSDaiLy = new System.Windows.Forms.DataGridView();
            this.txtHienThi = new System.Windows.Forms.Label();
            this.columnMaDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTenDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tbTong.SuspendLayout();
            this.tbHienThi.SuspendLayout();
            this.tbTrai.SuspendLayout();
            this.grTTDaiLy.SuspendLayout();
            this.grTacVu.SuspendLayout();
            this.tbPhai.SuspendLayout();
            this.grDaiLy.SuspendLayout();
            this.grDSDaiLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDSDaiLy)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
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
            this.tbTong.Controls.Add(this.txtHienThi, 0, 0);
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
            this.tbTrai.Controls.Add(this.grTTDaiLy, 0, 0);
            this.tbTrai.Controls.Add(this.grTacVu, 0, 1);
            this.tbTrai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTrai.Location = new System.Drawing.Point(3, 3);
            this.tbTrai.Name = "tbTrai";
            this.tbTrai.RowCount = 2;
            this.tbTrai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tbTrai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbTrai.Size = new System.Drawing.Size(353, 527);
            this.tbTrai.TabIndex = 0;
            // 
            // grTTDaiLy
            // 
            this.grTTDaiLy.Controls.Add(this.tbSoDienThoai);
            this.grTTDaiLy.Controls.Add(this.tbEmail);
            this.grTTDaiLy.Controls.Add(this.tbTenDaiLy);
            this.grTTDaiLy.Controls.Add(this.tbDiaChi);
            this.grTTDaiLy.Controls.Add(this.tbMaDaiLy);
            this.grTTDaiLy.Controls.Add(this.txtSoDienThoai);
            this.grTTDaiLy.Controls.Add(this.txtEmail);
            this.grTTDaiLy.Controls.Add(this.txtDiaChi);
            this.grTTDaiLy.Controls.Add(this.txtTenDaiLy);
            this.grTTDaiLy.Controls.Add(this.txtMaDaiLy);
            this.grTTDaiLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTTDaiLy.Location = new System.Drawing.Point(3, 3);
            this.grTTDaiLy.Name = "grTTDaiLy";
            this.grTTDaiLy.Size = new System.Drawing.Size(347, 389);
            this.grTTDaiLy.TabIndex = 0;
            this.grTTDaiLy.TabStop = false;
            this.grTTDaiLy.Text = "Thông Tin Đại Lý";
            // 
            // tbSoDienThoai
            // 
            this.tbSoDienThoai.Location = new System.Drawing.Point(129, 260);
            this.tbSoDienThoai.Name = "tbSoDienThoai";
            this.tbSoDienThoai.Size = new System.Drawing.Size(131, 25);
            this.tbSoDienThoai.TabIndex = 9;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(129, 206);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(131, 25);
            this.tbEmail.TabIndex = 8;
            // 
            // tbTenDaiLy
            // 
            this.tbTenDaiLy.Location = new System.Drawing.Point(129, 98);
            this.tbTenDaiLy.Name = "tbTenDaiLy";
            this.tbTenDaiLy.Size = new System.Drawing.Size(131, 25);
            this.tbTenDaiLy.TabIndex = 7;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(129, 152);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(131, 25);
            this.tbDiaChi.TabIndex = 6;
            // 
            // tbMaDaiLy
            // 
            this.tbMaDaiLy.Location = new System.Drawing.Point(129, 45);
            this.tbMaDaiLy.Name = "tbMaDaiLy";
            this.tbMaDaiLy.Size = new System.Drawing.Size(131, 25);
            this.tbMaDaiLy.TabIndex = 5;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(6, 263);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(103, 22);
            this.txtSoDienThoai.TabIndex = 4;
            this.txtSoDienThoai.Text = "Số Điện Thoại:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 209);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(54, 22);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "Email:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(6, 155);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(79, 22);
            this.txtDiaChi.TabIndex = 2;
            this.txtDiaChi.Text = "Địa Chỉ:";
            // 
            // txtTenDaiLy
            // 
            this.txtTenDaiLy.Location = new System.Drawing.Point(6, 101);
            this.txtTenDaiLy.Name = "txtTenDaiLy";
            this.txtTenDaiLy.Size = new System.Drawing.Size(91, 22);
            this.txtTenDaiLy.TabIndex = 1;
            this.txtTenDaiLy.Text = "Tên Đại Lý:";
            // 
            // txtMaDaiLy
            // 
            this.txtMaDaiLy.Location = new System.Drawing.Point(6, 48);
            this.txtMaDaiLy.Name = "txtMaDaiLy";
            this.txtMaDaiLy.Size = new System.Drawing.Size(91, 21);
            this.txtMaDaiLy.TabIndex = 0;
            this.txtMaDaiLy.Text = "Mã Đại Lý:";
            // 
            // grTacVu
            // 
            this.grTacVu.Controls.Add(this.btnLamMoi);
            this.grTacVu.Controls.Add(this.btnXoa);
            this.grTacVu.Controls.Add(this.btnSua);
            this.grTacVu.Controls.Add(this.btnThem);
            this.grTacVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTacVu.Location = new System.Drawing.Point(3, 398);
            this.grTacVu.Name = "grTacVu";
            this.grTacVu.Size = new System.Drawing.Size(347, 126);
            this.grTacVu.TabIndex = 1;
            this.grTacVu.TabStop = false;
            this.grTacVu.Text = "Tác Vụ";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Goldenrod;
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
            this.btnSua.BackColor = System.Drawing.Color.CornflowerBlue;
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
            this.tbPhai.Controls.Add(this.grDaiLy, 0, 0);
            this.tbPhai.Controls.Add(this.grDSDaiLy, 0, 1);
            this.tbPhai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPhai.Location = new System.Drawing.Point(362, 3);
            this.tbPhai.Name = "tbPhai";
            this.tbPhai.RowCount = 2;
            this.tbPhai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbPhai.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tbPhai.Size = new System.Drawing.Size(534, 527);
            this.tbPhai.TabIndex = 1;
            // 
            // grDaiLy
            // 
            this.grDaiLy.Controls.Add(this.tbTimKiemDaiLy);
            this.grDaiLy.Controls.Add(this.lbTimKiemDaiLy);
            this.grDaiLy.Controls.Add(this.btnTimKiem);
            this.grDaiLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDaiLy.Location = new System.Drawing.Point(3, 3);
            this.grDaiLy.Name = "grDaiLy";
            this.grDaiLy.Size = new System.Drawing.Size(528, 125);
            this.grDaiLy.TabIndex = 0;
            this.grDaiLy.TabStop = false;
            this.grDaiLy.Text = "Tìm Kiếm Đại Lý";
            // 
            // tbTimKiemDaiLy
            // 
            this.tbTimKiemDaiLy.Location = new System.Drawing.Point(118, 48);
            this.tbTimKiemDaiLy.Name = "tbTimKiemDaiLy";
            this.tbTimKiemDaiLy.Size = new System.Drawing.Size(131, 25);
            this.tbTimKiemDaiLy.TabIndex = 6;
            // 
            // lbTimKiemDaiLy
            // 
            this.lbTimKiemDaiLy.Location = new System.Drawing.Point(30, 51);
            this.lbTimKiemDaiLy.Name = "lbTimKiemDaiLy";
            this.lbTimKiemDaiLy.Size = new System.Drawing.Size(82, 22);
            this.lbTimKiemDaiLy.TabIndex = 5;
            this.lbTimKiemDaiLy.Text = "Mã Đại Lý:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(367, 43);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 33);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // grDSDaiLy
            // 
            this.grDSDaiLy.Controls.Add(this.dataDSDaiLy);
            this.grDSDaiLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDSDaiLy.Location = new System.Drawing.Point(3, 134);
            this.grDSDaiLy.Name = "grDSDaiLy";
            this.grDSDaiLy.Size = new System.Drawing.Size(528, 390);
            this.grDSDaiLy.TabIndex = 1;
            this.grDSDaiLy.TabStop = false;
            this.grDSDaiLy.Text = "Danh Sách Đại Lý";
            // 
            // dataDSDaiLy
            // 
            this.dataDSDaiLy.AllowUserToAddRows = false;
            this.dataDSDaiLy.BackgroundColor = System.Drawing.Color.White;
            this.dataDSDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDSDaiLy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnMaDaiLy,
            this.columnTenDaiLy,
            this.columnDiaChi,
            this.columnEmail,
            this.columnSoDienThoai});
            this.dataDSDaiLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDSDaiLy.Location = new System.Drawing.Point(3, 21);
            this.dataDSDaiLy.Name = "dataDSDaiLy";
            this.dataDSDaiLy.Size = new System.Drawing.Size(522, 366);
            this.dataDSDaiLy.TabIndex = 0;
            // 
            // txtHienThi
            // 
            this.txtHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHienThi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtHienThi.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtHienThi.Location = new System.Drawing.Point(3, 0);
            this.txtHienThi.Name = "txtHienThi";
            this.txtHienThi.Size = new System.Drawing.Size(899, 94);
            this.txtHienThi.TabIndex = 1;
            this.txtHienThi.Text = "Quản Lý Đại Lý";
            this.txtHienThi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // columnMaDaiLy
            // 
            this.columnMaDaiLy.HeaderText = "Mã Đại Lý";
            this.columnMaDaiLy.Name = "columnMaDaiLy";
            // 
            // columnTenDaiLy
            // 
            this.columnTenDaiLy.HeaderText = "Tên Đại Lý";
            this.columnTenDaiLy.Name = "columnTenDaiLy";
            this.columnTenDaiLy.ReadOnly = true;
            // 
            // columnDiaChi
            // 
            this.columnDiaChi.HeaderText = "Địa Chỉ";
            this.columnDiaChi.Name = "columnDiaChi";
            this.columnDiaChi.ReadOnly = true;
            // 
            // columnEmail
            // 
            this.columnEmail.HeaderText = "Email";
            this.columnEmail.Name = "columnEmail";
            this.columnEmail.ReadOnly = true;
            // 
            // columnSoDienThoai
            // 
            this.columnSoDienThoai.HeaderText = "Số Điện Thoại";
            this.columnSoDienThoai.Name = "columnSoDienThoai";
            this.columnSoDienThoai.ReadOnly = true;
            this.columnSoDienThoai.Width = 150;
            // 
            // DaiLyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 633);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "DaiLyForm";
            this.Text = "DaiLyForm";
            this.panel1.ResumeLayout(false);
            this.tbTong.ResumeLayout(false);
            this.tbHienThi.ResumeLayout(false);
            this.tbTrai.ResumeLayout(false);
            this.grTTDaiLy.ResumeLayout(false);
            this.grTTDaiLy.PerformLayout();
            this.grTacVu.ResumeLayout(false);
            this.tbPhai.ResumeLayout(false);
            this.grDaiLy.ResumeLayout(false);
            this.grDaiLy.PerformLayout();
            this.grDSDaiLy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDSDaiLy)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tbTong;
        private System.Windows.Forms.TableLayoutPanel tbHienThi;
        private System.Windows.Forms.TableLayoutPanel tbTrai;
        private System.Windows.Forms.TableLayoutPanel tbPhai;
        private System.Windows.Forms.GroupBox grTTDaiLy;
        private System.Windows.Forms.Label txtHienThi;
        private System.Windows.Forms.GroupBox grTacVu;
        private System.Windows.Forms.GroupBox grDaiLy;
        private System.Windows.Forms.GroupBox grDSDaiLy;
        private System.Windows.Forms.TextBox tbSoDienThoai;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTenDaiLy;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbMaDaiLy;
        private System.Windows.Forms.Label txtSoDienThoai;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtDiaChi;
        private System.Windows.Forms.Label txtTenDaiLy;
        private System.Windows.Forms.Label txtMaDaiLy;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox tbTimKiemDaiLy;
        private System.Windows.Forms.Label lbTimKiemDaiLy;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dataDSDaiLy;
        private DataGridViewTextBoxColumn columnMaDaiLy;
        private DataGridViewTextBoxColumn columnTenDaiLy;
        private DataGridViewTextBoxColumn columnDiaChi;
        private DataGridViewTextBoxColumn columnEmail;
        private DataGridViewTextBoxColumn columnSoDienThoai;
    }
}