using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.MainForm
{
    partial class TongQuanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopSanPham;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label1;
        private Label lbXeDapDien;
        private Label label3;
        private Label lbXeMayDien;
        private Label label5;
        private Label lbDoanhThu;
        private Label label7;
        private Label lbKhachHang;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbXeDapDien = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbXeMayDien = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDoanhThu = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopSanPham = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopSanPham)).BeginInit();
            this.SuspendLayout();

            // 
            // table trên
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel2.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1497, 345);
            this.tableLayoutPanel2.TabIndex = 0;
                // 
                // panelXeDapDien
                // 
                this.panel1.BackColor = Color.FromArgb(204, 229, 255);
                this.panel1.Controls.Add(this.tableLayoutPanel4);
                this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
                this.panel1.Location = new System.Drawing.Point(3, 3);
                this.panel1.Name = "panelXeDapDien";
                this.panel1.Size = new System.Drawing.Size(368, 339);
                this.panel1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
                this.panel1.TabIndex = 0;
                // 
                // tbXeDapDien
                // 
                this.tableLayoutPanel4.ColumnCount = 1;
                this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
                this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
                this.tableLayoutPanel4.Controls.Add(this.lbXeDapDien, 0, 1);
                this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
                this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
                this.tableLayoutPanel4.Name = "tbXeDapDien";
                this.tableLayoutPanel4.RowCount = 2;
                this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
                this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
                this.tableLayoutPanel4.Size = new System.Drawing.Size(368, 339);
                this.tableLayoutPanel4.TabIndex = 0;
                    // 
                    // lbHienThiXeDapDien
                    // 
                    this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
                    this.label1.Location = new System.Drawing.Point(3, 0);
                    this.label1.ForeColor = Color.DarkBlue;
                    this.label1.Name = "lbHienThiXeDapDien";
                    this.label1.Size = new System.Drawing.Size(362, 203);
                    this.label1.TabIndex = 0;
                    this.label1.Text = "Tổng số xe đạp điện hiện có";
                    this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    // 
                    // lbXeDapDien
                    // 
                    this.lbXeDapDien.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.lbXeDapDien.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
                    this.lbXeDapDien.Location = new System.Drawing.Point(3, 203);
                    this.lbXeDapDien.Name = "lbXeDapDien";
                    this.lbXeMayDien.ForeColor = Color.DarkGreen;
                    this.lbXeDapDien.Size = new System.Drawing.Size(362, 136);
                    this.lbXeDapDien.TabIndex = 1;
                    this.lbXeDapDien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // panelXeMayDien
                // 
                this.panel2.BackColor = Color.FromArgb(204, 255, 229);
                this.panel2.Controls.Add(this.tableLayoutPanel5);
                this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
                this.panel2.Location = new System.Drawing.Point(377, 3);
                this.panel2.Name = "panelXeMayDien";
                this.panel2.Size = new System.Drawing.Size(368, 339);
                this.panel2.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
                this.panel2.TabIndex = 1;
                // 
                // tbXeMayDien
                // 
                this.tableLayoutPanel5.ColumnCount = 1;
                this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
                this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
                this.tableLayoutPanel5.Controls.Add(this.lbXeMayDien, 0, 1);
                this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
                this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
                this.tableLayoutPanel5.Name = "tbXeMayDien";
                this.tableLayoutPanel5.RowCount = 2;
                this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
                this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
                this.tableLayoutPanel5.Size = new System.Drawing.Size(368, 339);
                this.tableLayoutPanel5.TabIndex = 0;
                    // 
                    // lbHienThiXeMayDien
                    // 
                    this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
                    this.label3.Location = new System.Drawing.Point(3, 0);
                    this.label3.ForeColor = Color.DarkGreen;
                    this.label3.Name = "lbHienThiXeMayDien";
                    this.label3.Size = new System.Drawing.Size(362, 203);
                    this.label3.TabIndex = 0;
                    this.label3.Text = "Tổng số xe máy điện hiện có";
                    this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    // 
                    // lbXeMayDien
                    // 
                    this.lbXeMayDien.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.lbXeMayDien.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
                    this.lbXeDapDien.ForeColor = Color.DarkBlue;
                    this.lbXeMayDien.Location = new System.Drawing.Point(3, 203);
                    this.lbXeMayDien.Name = "lbXeMayDien";
                    this.lbXeMayDien.Size = new System.Drawing.Size(362, 136);
                    this.lbXeMayDien.TabIndex = 1;
                    this.lbXeMayDien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // panelDoanhThu
                // 
                this.panel3.BackColor = Color.FromArgb(255, 255, 204);
                this.panel3.Controls.Add(this.tableLayoutPanel6);
                this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
                this.panel3.Location = new System.Drawing.Point(751, 3);
                this.panel3.Name = "panelDoanhThu";
                this.panel3.Size = new System.Drawing.Size(368, 339);
                this.panel3.TabIndex = 2;
                this.panel3.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
                // 
                // tbDoanhThu
                // 
                this.tableLayoutPanel6.ColumnCount = 1;
                this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
                this.tableLayoutPanel6.Controls.Add(this.label5, 0, 0);
                this.tableLayoutPanel6.Controls.Add(this.lbDoanhThu, 0, 1);
                this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
                this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
                this.tableLayoutPanel6.Name = "tbDoanhThu";
                this.tableLayoutPanel6.RowCount = 2;
                this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
                this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
                this.tableLayoutPanel6.Size = new System.Drawing.Size(368, 339);
                this.tableLayoutPanel6.TabIndex = 0;
                    // 
                    // lbHienThiDoanhThu
                    // 
                    this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
                    this.label5.Location = new System.Drawing.Point(3, 0);
                    this.label5.Name = "lbHienThiDoanhThu";
                    this.label5.Size = new System.Drawing.Size(362, 203);
                    this.label5.TabIndex = 0;
                    this.label5.ForeColor = Color.DarkOrange;
                    this.label5.Text = "Doanh thu";
                    this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    // 
                    // lbDoanhThu
                    // 
                    this.lbDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.lbDoanhThu.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
                    this.lbDoanhThu.Location = new System.Drawing.Point(3, 203);
                    this.lbDoanhThu.ForeColor = Color.DarkOrange;
                    this.lbDoanhThu.Name = "lbDoanhThu";
                    this.lbDoanhThu.Size = new System.Drawing.Size(362, 136);
                    this.lbDoanhThu.TabIndex = 1;
                    this.lbDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // panelTongSoKhachHang
                // 
                this.panel4.BackColor = Color.FromArgb(255, 204, 229);
                this.panel4.Controls.Add(this.tableLayoutPanel7);
                this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
                this.panel4.Location = new System.Drawing.Point(1125, 3);
                this.panel4.Name = "panelTongSoKhachHang";
                this.panel4.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
                this.panel4.Size = new System.Drawing.Size(369, 339);
                this.panel4.TabIndex = 3;
                // 
                // tbTongSoKhachHang
                // 
                this.tableLayoutPanel7.ColumnCount = 1;
                this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
                this.tableLayoutPanel7.Controls.Add(this.label7, 0, 0);
                this.tableLayoutPanel7.Controls.Add(this.lbKhachHang, 0, 1);
                this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
                this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
                this.tableLayoutPanel7.Name = "tbTongSoKhachHang";
                this.tableLayoutPanel7.RowCount = 2;
                this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
                this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
                this.tableLayoutPanel7.Size = new System.Drawing.Size(369, 339);
                this.tableLayoutPanel7.TabIndex = 0;
                    // 
                    // lbHienThiTongSoKhachHang
                    // 
                    this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
                    this.label7.Location = new System.Drawing.Point(3, 0);
                    this.label7.Name = "lbHienThiTongSoKhachHang";
                    this.label7.Size = new System.Drawing.Size(363, 203);
                    this.label7.ForeColor = Color.DarkRed;
                    this.label7.TabIndex = 0;
                    this.label7.Text = "Tổng số khách ngày hôm nay";
                    this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    // 
                    // lbKhachHang
                    // 
                    this.lbKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.lbKhachHang.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
                    this.lbKhachHang.Location = new System.Drawing.Point(3, 203);
                    this.lbKhachHang.Name = "lbKhachHang";
                    this.lbKhachHang.ForeColor = Color.DarkRed;
                    this.lbKhachHang.Size = new System.Drawing.Size(363, 136);
                    this.lbKhachHang.TabIndex = 1;
                    this.lbKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTong
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1503, 878);
            this.tableLayoutPanel1.Padding = new Padding(20, 20, 20, 20);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbBenTrongPanelChuaLabel
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.chartDoanhThu, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.chartTopSanPham, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 354);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1497, 521);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // chartDoanhThu
            // 
            this.chartDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(751, 3);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "SoLuong";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(743, 515);
            this.chartDoanhThu.TabIndex = 1;
            this.chartDoanhThu.Text = "chartDoanhThu";
            // 
            // chartTopSanPham
            // 
            this.chartTopSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartTopSanPham.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTopSanPham.Legends.Add(legend2);
            this.chartTopSanPham.Location = new System.Drawing.Point(3, 3);
            this.chartTopSanPham.Name = "chartTopSanPham";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Doanh Thu";
            this.chartTopSanPham.Series.Add(series2);
            this.chartTopSanPham.Size = new System.Drawing.Size(742, 515);
            this.chartTopSanPham.TabIndex = 0;
            this.chartTopSanPham.Text = "chartTopSanPham";
            // 
            // TongQuanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1503, 878);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TongQuanForm";
            this.Text = "TongQuanForm";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        private void LoadDashboard()
        {
            // Gán số liệu
            lbXeDapDien.Text = "45";
            lbXeMayDien.Text = "30";
            lbDoanhThu.Text = "12,000,000 VNĐ";
            lbKhachHang.Text = "9";

            // Bar Chart - Top sản phẩm bán chạy
            chartTopSanPham.Series.Clear();
            Series barSeries = new Series("Sản phẩm")
            {
                ChartType = SeriesChartType.Column,
            };
            barSeries.Points.AddXY("VinFast Feliz", 15);
            barSeries.Points.AddXY("Yadea G5", 10);
            barSeries.Points.AddXY("DatBike Weaver", 8);
            chartTopSanPham.Series.Add(barSeries);

            // Column Chart - Doanh thu theo tháng
            chartDoanhThu.Series.Clear();
            Series columnSeries = new Series("Doanh thu")
            {
                ChartType = SeriesChartType.Column
            };
            columnSeries.Points.AddXY("Tháng 1", 5000000);
            columnSeries.Points.AddXY("Tháng 2", 7000000);
            columnSeries.Points.AddXY("Tháng 3", 8500000);
            columnSeries.Points.AddXY("Tháng 4", 12000000);
            chartDoanhThu.Series.Add(columnSeries);
        }

    }
}