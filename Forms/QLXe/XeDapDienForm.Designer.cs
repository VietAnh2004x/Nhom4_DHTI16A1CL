using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.QLXe
{
    partial class XeDapDienForm
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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTong = new System.Windows.Forms.TableLayoutPanel();
            this.tbHienThiXe = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbSoBinhAcQuy = new System.Windows.Forms.Label();
            this.lbDLAcQuy = new System.Windows.Forms.Label();
            this.lbBaoHanh = new System.Windows.Forms.Label();
            this.lbGiaSauThue = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbTenXe = new System.Windows.Forms.Label();
            this.lbMaXe = new System.Windows.Forms.Label();
            this.lbDongXe = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbHienThiDanhSach = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtQLXeDapDien = new System.Windows.Forms.Label();
            this.columnMaXeDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDongXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSoBinhAcQuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDLAcQuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGiaSauThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tbTong.SuspendLayout();
            this.tbHienThiXe.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbHienThiDanhSach.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbTong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 642);
            this.panel1.TabIndex = 7;
            // 
            // tbTong
            // 
            this.tbTong.ColumnCount = 1;
            this.tbTong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tbTong.Controls.Add(this.tbHienThiXe, 0, 1);
            this.tbTong.Controls.Add(this.txtQLXeDapDien, 0, 0);
            this.tbTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTong.Location = new System.Drawing.Point(0, 0);
            this.tbTong.Name = "tbTong";
            this.tbTong.RowCount = 2;
            this.tbTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tbTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tbTong.Size = new System.Drawing.Size(1022, 642);
            this.tbTong.TabIndex = 0;
            // 
            // tbHienThiXe
            // 
            this.tbHienThiXe.ColumnCount = 2;
            this.tbHienThiXe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tbHienThiXe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tbHienThiXe.Controls.Add(this.groupBox1, 0, 0);
            this.tbHienThiXe.Controls.Add(this.tbHienThiDanhSach, 1, 0);
            this.tbHienThiXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHienThiXe.Location = new System.Drawing.Point(3, 99);
            this.tbHienThiXe.Name = "tbHienThiXe";
            this.tbHienThiXe.RowCount = 1;
            this.tbHienThiXe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 540F));
            this.tbHienThiXe.Size = new System.Drawing.Size(1016, 540);
            this.tbHienThiXe.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lbSoBinhAcQuy);
            this.groupBox1.Controls.Add(this.lbDLAcQuy);
            this.groupBox1.Controls.Add(this.lbBaoHanh);
            this.groupBox1.Controls.Add(this.lbGiaSauThue);
            this.groupBox1.Controls.Add(this.lbGia);
            this.groupBox1.Controls.Add(this.lbTenXe);
            this.groupBox1.Controls.Add(this.lbMaXe);
            this.groupBox1.Controls.Add(this.lbDongXe);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 534);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin xe";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(291, 454);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown3.TabIndex = 16;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(130, 455);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown2.TabIndex = 15;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(130, 395);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown1.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(272, 335);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(51, 335);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 276);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(88, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // lbSoBinhAcQuy
            // 
            this.lbSoBinhAcQuy.Location = new System.Drawing.Point(195, 457);
            this.lbSoBinhAcQuy.Name = "lbSoBinhAcQuy";
            this.lbSoBinhAcQuy.Size = new System.Drawing.Size(100, 23);
            this.lbSoBinhAcQuy.TabIndex = 8;
            this.lbSoBinhAcQuy.Text = "Số Bình Ắc Quy:";
            // 
            // lbDLAcQuy
            // 
            this.lbDLAcQuy.Location = new System.Drawing.Point(6, 456);
            this.lbDLAcQuy.Name = "lbDLAcQuy";
            this.lbDLAcQuy.Size = new System.Drawing.Size(118, 23);
            this.lbDLAcQuy.TabIndex = 7;
            this.lbDLAcQuy.Text = "Dung Lượng Ắc Quy:";
            // 
            // lbBaoHanh
            // 
            this.lbBaoHanh.Location = new System.Drawing.Point(6, 397);
            this.lbBaoHanh.Name = "lbBaoHanh";
            this.lbBaoHanh.Size = new System.Drawing.Size(100, 23);
            this.lbBaoHanh.TabIndex = 6;
            this.lbBaoHanh.Text = "Bảo Hành:";
            // 
            // lbGiaSauThue
            // 
            this.lbGiaSauThue.Location = new System.Drawing.Point(166, 338);
            this.lbGiaSauThue.Name = "lbGiaSauThue";
            this.lbGiaSauThue.Size = new System.Drawing.Size(100, 23);
            this.lbGiaSauThue.TabIndex = 5;
            this.lbGiaSauThue.Text = "Giá Sau Thuế:";
            // 
            // lbGia
            // 
            this.lbGia.Location = new System.Drawing.Point(6, 338);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(39, 23);
            this.lbGia.TabIndex = 4;
            this.lbGia.Text = "Giá:";
            // 
            // lbTenXe
            // 
            this.lbTenXe.Location = new System.Drawing.Point(6, 279);
            this.lbTenXe.Name = "lbTenXe";
            this.lbTenXe.Size = new System.Drawing.Size(100, 23);
            this.lbTenXe.TabIndex = 3;
            this.lbTenXe.Text = "Tên Xe:";
            // 
            // lbMaXe
            // 
            this.lbMaXe.Location = new System.Drawing.Point(6, 220);
            this.lbMaXe.Name = "lbMaXe";
            this.lbMaXe.Size = new System.Drawing.Size(100, 23);
            this.lbMaXe.TabIndex = 2;
            this.lbMaXe.Text = "Mã Xe:";
            // 
            // lbDongXe
            // 
            this.lbDongXe.Location = new System.Drawing.Point(6, 161);
            this.lbDongXe.Name = "lbDongXe";
            this.lbDongXe.Size = new System.Drawing.Size(100, 23);
            this.lbDongXe.TabIndex = 1;
            this.lbDongXe.Text = "Dòng Xe:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(96, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 105);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbHienThiDanhSach
            // 
            this.tbHienThiDanhSach.AutoSize = true;
            this.tbHienThiDanhSach.ColumnCount = 1;
            this.tbHienThiDanhSach.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 604F));
            this.tbHienThiDanhSach.Controls.Add(this.groupBox2, 0, 0);
            this.tbHienThiDanhSach.Controls.Add(this.groupBox3, 0, 1);
            this.tbHienThiDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHienThiDanhSach.Location = new System.Drawing.Point(409, 3);
            this.tbHienThiDanhSach.Name = "tbHienThiDanhSach";
            this.tbHienThiDanhSach.RowCount = 2;
            this.tbHienThiDanhSach.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tbHienThiDanhSach.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbHienThiDanhSach.Size = new System.Drawing.Size(604, 534);
            this.tbHienThiDanhSach.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.data);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 474);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách xe đạp điện";
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnMaXeDien,
            this.columnTenXe,
            this.columnDongXe,
            this.columnMauSac,
            this.columnSoBinhAcQuy,
            this.columnDLAcQuy,
            this.columnGiaNhap,
            this.columnThue,
            this.columnGiaSauThue,
            this.columnHinhAnh});
            this.data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data.Location = new System.Drawing.Point(3, 16);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(592, 455);
            this.data.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLamMoi);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Location = new System.Drawing.Point(3, 483);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 48);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tác vụ";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(249, 19);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(168, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(87, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(6, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtQLXeDapDien
            // 
            this.txtQLXeDapDien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQLXeDapDien.Location = new System.Drawing.Point(3, 0);
            this.txtQLXeDapDien.Name = "txtQLXeDapDien";
            this.txtQLXeDapDien.Size = new System.Drawing.Size(1016, 96);
            this.txtQLXeDapDien.TabIndex = 1;
            this.txtQLXeDapDien.Text = "Quản Lý Xe Đạp Điện";
            // 
            // columnMaXeDien
            // 
            this.columnMaXeDien.HeaderText = "Mã Xe Đạp Điện";
            this.columnMaXeDien.Name = "columnMaXeDien";
            this.columnMaXeDien.ReadOnly = true;
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
            // columnMauSac
            // 
            this.columnMauSac.HeaderText = "Màu Sắc";
            this.columnMauSac.Name = "columnMauSac";
            this.columnMauSac.ReadOnly = true;
            // 
            // columnSoBinhAcQuy
            // 
            this.columnSoBinhAcQuy.HeaderText = "Số Bình Ắc Quy";
            this.columnSoBinhAcQuy.Name = "columnSoBinhAcQuy";
            this.columnSoBinhAcQuy.ReadOnly = true;
            // 
            // columnDLAcQuy
            // 
            this.columnDLAcQuy.HeaderText = "Dung Lượng Ắc Quy";
            this.columnDLAcQuy.Name = "columnDLAcQuy";
            this.columnDLAcQuy.ReadOnly = true;
            // 
            // columnGiaNhap
            // 
            this.columnGiaNhap.HeaderText = "Giá Nhập";
            this.columnGiaNhap.Name = "columnGiaNhap";
            this.columnGiaNhap.ReadOnly = true;
            // 
            // columnThue
            // 
            this.columnThue.HeaderText = "Thuế";
            this.columnThue.Name = "columnThue";
            this.columnThue.ReadOnly = true;
            // 
            // columnGiaSauThue
            // 
            this.columnGiaSauThue.HeaderText = "Giá Sau Thuế";
            this.columnGiaSauThue.Name = "columnGiaSauThue";
            this.columnGiaSauThue.ReadOnly = true;
            // 
            // columnHinhAnh
            // 
            this.columnHinhAnh.HeaderText = "Hình Ảnh";
            this.columnHinhAnh.Name = "columnHinhAnh";
            this.columnHinhAnh.ReadOnly = true;
            // 
            // XeDapDienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1022, 642);
            this.Controls.Add(this.panel1);
            this.Name = "XeDapDienForm";
            this.Text = "FormXeDapDien";
            this.panel1.ResumeLayout(false);
            this.tbTong.ResumeLayout(false);
            this.tbHienThiXe.ResumeLayout(false);
            this.tbHienThiXe.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbHienThiDanhSach.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private Panel panel1;
        private TableLayoutPanel tbTong;
        private TableLayoutPanel tbHienThiXe;
        private GroupBox groupBox1;
        private TableLayoutPanel tbHienThiDanhSach;
        private Label txtQLXeDapDien;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label lbSoBinhAcQuy;
        private Label lbDLAcQuy;
        private Label lbBaoHanh;
        private Label lbGiaSauThue;
        private Label lbGia;
        private Label lbTenXe;
        private Label lbMaXe;
        private Label lbDongXe;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private DataGridView data;
        private GroupBox groupBox3;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridViewTextBoxColumn columnMaXeDien;
        private DataGridViewTextBoxColumn columnTenXe;
        private DataGridViewTextBoxColumn columnDongXe;
        private DataGridViewTextBoxColumn columnMauSac;
        private DataGridViewTextBoxColumn columnSoBinhAcQuy;
        private DataGridViewTextBoxColumn columnDLAcQuy;
        private DataGridViewTextBoxColumn columnGiaNhap;
        private DataGridViewTextBoxColumn columnThue;
        private DataGridViewTextBoxColumn columnGiaSauThue;
        private DataGridViewTextBoxColumn columnHinhAnh;
    }
}