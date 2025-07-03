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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTong = new System.Windows.Forms.TableLayoutPanel();
            this.txtTieuDe = new System.Windows.Forms.Label();
            this.tbHienThiXe = new System.Windows.Forms.TableLayoutPanel();
            this.tbHienThiBang = new System.Windows.Forms.TableLayoutPanel();
            this.grTTBang = new System.Windows.Forms.GroupBox();
            this.grTacVu = new System.Windows.Forms.GroupBox();
            this.grTTXe = new System.Windows.Forms.GroupBox();
            this.txtSLAcQuy = new System.Windows.Forms.Label();
            this.txtDLAcQuy = new System.Windows.Forms.Label();
            this.txtBaoHanh = new System.Windows.Forms.Label();
            this.txtGiaSauThue = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.Label();
            this.txtTenXe = new System.Windows.Forms.Label();
            this.txtMaXe = new System.Windows.Forms.Label();
            this.txtDongXe = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnMaXeDapDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDongXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSLAcQuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDLAcQuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGiaSauThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tbTong.SuspendLayout();
            this.tbHienThiXe.SuspendLayout();
            this.tbHienThiBang.SuspendLayout();
            this.grTTBang.SuspendLayout();
            this.grTacVu.SuspendLayout();
            this.grTTXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbTong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 605);
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
            this.tbTong.Size = new System.Drawing.Size(1023, 605);
            this.tbTong.TabIndex = 0;
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTieuDe.Location = new System.Drawing.Point(3, 0);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(1017, 60);
            this.txtTieuDe.TabIndex = 0;
            this.txtTieuDe.Text = "Thông Tin Xe Đạp Điện";
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
            this.tbHienThiXe.Location = new System.Drawing.Point(3, 63);
            this.tbHienThiXe.Name = "tbHienThiXe";
            this.tbHienThiXe.RowCount = 1;
            this.tbHienThiXe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbHienThiXe.Size = new System.Drawing.Size(1017, 539);
            this.tbHienThiXe.TabIndex = 1;
            // 
            // tbHienThiBang
            // 
            this.tbHienThiBang.ColumnCount = 1;
            this.tbHienThiBang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 605F));
            this.tbHienThiBang.Controls.Add(this.grTTBang, 0, 0);
            this.tbHienThiBang.Controls.Add(this.grTacVu, 0, 1);
            this.tbHienThiBang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHienThiBang.Location = new System.Drawing.Point(409, 3);
            this.tbHienThiBang.Name = "tbHienThiBang";
            this.tbHienThiBang.RowCount = 2;
            this.tbHienThiBang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tbHienThiBang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbHienThiBang.Size = new System.Drawing.Size(605, 533);
            this.tbHienThiBang.TabIndex = 0;
            // 
            // grTTBang
            // 
            this.grTTBang.Controls.Add(this.dataGridView1);
            this.grTTBang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTTBang.Location = new System.Drawing.Point(3, 3);
            this.grTTBang.Name = "grTTBang";
            this.grTTBang.Size = new System.Drawing.Size(599, 473);
            this.grTTBang.TabIndex = 0;
            this.grTTBang.TabStop = false;
            this.grTTBang.Text = "Danh sách xe đạp điện";
            // 
            // grTacVu
            // 
            this.grTacVu.Controls.Add(this.btnLamMoi);
            this.grTacVu.Controls.Add(this.btnXoa);
            this.grTacVu.Controls.Add(this.btnSua);
            this.grTacVu.Controls.Add(this.btnThem);
            this.grTacVu.Location = new System.Drawing.Point(3, 482);
            this.grTacVu.Name = "grTacVu";
            this.grTacVu.Size = new System.Drawing.Size(334, 48);
            this.grTacVu.TabIndex = 1;
            this.grTacVu.TabStop = false;
            this.grTacVu.Text = "Tác vụ";
            // 
            // grTTXe
            // 
            this.grTTXe.Controls.Add(this.numericUpDown3);
            this.grTTXe.Controls.Add(this.numericUpDown2);
            this.grTTXe.Controls.Add(this.numericUpDown1);
            this.grTTXe.Controls.Add(this.textBox4);
            this.grTTXe.Controls.Add(this.textBox3);
            this.grTTXe.Controls.Add(this.textBox2);
            this.grTTXe.Controls.Add(this.textBox1);
            this.grTTXe.Controls.Add(this.comboBox1);
            this.grTTXe.Controls.Add(this.pictureBox1);
            this.grTTXe.Controls.Add(this.txtSLAcQuy);
            this.grTTXe.Controls.Add(this.txtDLAcQuy);
            this.grTTXe.Controls.Add(this.txtBaoHanh);
            this.grTTXe.Controls.Add(this.txtGiaSauThue);
            this.grTTXe.Controls.Add(this.txtGia);
            this.grTTXe.Controls.Add(this.txtTenXe);
            this.grTTXe.Controls.Add(this.txtMaXe);
            this.grTTXe.Controls.Add(this.txtDongXe);
            this.grTTXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grTTXe.Location = new System.Drawing.Point(3, 3);
            this.grTTXe.Name = "grTTXe";
            this.grTTXe.Size = new System.Drawing.Size(400, 533);
            this.grTTXe.TabIndex = 1;
            this.grTTXe.TabStop = false;
            this.grTTXe.Text = "Thông tin xe";
            // 
            // txtSLAcQuy
            // 
            this.txtSLAcQuy.Location = new System.Drawing.Point(220, 481);
            this.txtSLAcQuy.Name = "txtSLAcQuy";
            this.txtSLAcQuy.Size = new System.Drawing.Size(114, 21);
            this.txtSLAcQuy.TabIndex = 7;
            this.txtSLAcQuy.Text = "Số Bình Ắc Quy:";
            // 
            // txtDLAcQuy
            // 
            this.txtDLAcQuy.Location = new System.Drawing.Point(6, 482);
            this.txtDLAcQuy.Name = "txtDLAcQuy";
            this.txtDLAcQuy.Size = new System.Drawing.Size(131, 21);
            this.txtDLAcQuy.TabIndex = 6;
            this.txtDLAcQuy.Text = "Dung Lượng Ắc Quy:";
            // 
            // txtBaoHanh
            // 
            this.txtBaoHanh.Location = new System.Drawing.Point(6, 421);
            this.txtBaoHanh.Name = "txtBaoHanh";
            this.txtBaoHanh.Size = new System.Drawing.Size(73, 21);
            this.txtBaoHanh.TabIndex = 5;
            this.txtBaoHanh.Text = "Bảo Hành:";
            // 
            // txtGiaSauThue
            // 
            this.txtGiaSauThue.Location = new System.Drawing.Point(171, 360);
            this.txtGiaSauThue.Name = "txtGiaSauThue";
            this.txtGiaSauThue.Size = new System.Drawing.Size(103, 22);
            this.txtGiaSauThue.TabIndex = 4;
            this.txtGiaSauThue.Text = "Giá Sau Thuế:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(6, 360);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(44, 21);
            this.txtGia.TabIndex = 3;
            this.txtGia.Text = "Giá:";
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(6, 177);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(81, 21);
            this.txtTenXe.TabIndex = 2;
            this.txtTenXe.Text = "Tên Xe:";
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(6, 238);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(70, 21);
            this.txtMaXe.TabIndex = 1;
            this.txtMaXe.Text = "Mã Xe:";
            // 
            // txtDongXe
            // 
            this.txtDongXe.Location = new System.Drawing.Point(6, 299);
            this.txtDongXe.Name = "txtDongXe";
            this.txtDongXe.Size = new System.Drawing.Size(84, 21);
            this.txtDongXe.TabIndex = 0;
            this.txtDongXe.Text = "Dòng Xe:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(111, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 95);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 296);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 237);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(56, 357);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(273, 357);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(85, 419);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 22);
            this.numericUpDown1.TabIndex = 14;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(143, 480);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(54, 22);
            this.numericUpDown2.TabIndex = 15;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(340, 480);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(54, 22);
            this.numericUpDown3.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnMaXeDapDien,
            this.columnTenXe,
            this.columnDongXe,
            this.columnMauSac,
            this.columnSLAcQuy,
            this.columnDLAcQuy,
            this.columnGia,
            this.columnThue,
            this.columnGiaSauThue,
            this.columnHinhAnh});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(593, 452);
            this.dataGridView1.TabIndex = 0;
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
            // columnThue
            // 
            this.columnThue.HeaderText = "Thuế";
            this.columnThue.MinimumWidth = 6;
            this.columnThue.Name = "columnThue";
            this.columnThue.ReadOnly = true;
            this.columnThue.Width = 125;
            // 
            // columnGiaSauThue
            // 
            this.columnGiaSauThue.HeaderText = "Giá Sau Thuế";
            this.columnGiaSauThue.MinimumWidth = 6;
            this.columnGiaSauThue.Name = "columnGiaSauThue";
            this.columnGiaSauThue.ReadOnly = true;
            this.columnGiaSauThue.Width = 125;
            // 
            // columnHinhAnh
            // 
            this.columnHinhAnh.HeaderText = "Hình Ảnh";
            this.columnHinhAnh.MinimumWidth = 6;
            this.columnHinhAnh.Name = "columnHinhAnh";
            this.columnHinhAnh.ReadOnly = true;
            this.columnHinhAnh.Width = 125;
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
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(87, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
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
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(249, 19);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // QLXeDapDienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 605);
            this.Controls.Add(this.panel1);
            this.Name = "QLXeDapDienForm";
            this.Text = "QLXeDapDienForm";
            this.panel1.ResumeLayout(false);
            this.tbTong.ResumeLayout(false);
            this.tbHienThiXe.ResumeLayout(false);
            this.tbHienThiBang.ResumeLayout(false);
            this.grTTBang.ResumeLayout(false);
            this.grTacVu.ResumeLayout(false);
            this.grTTXe.ResumeLayout(false);
            this.grTTXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label txtGiaSauThue;
        private System.Windows.Forms.Label txtGia;
        private System.Windows.Forms.Label txtTenXe;
        private System.Windows.Forms.Label txtMaXe;
        private System.Windows.Forms.Label txtDongXe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMaXeDapDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDongXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSLAcQuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDLAcQuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGiaSauThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnHinhAnh;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}