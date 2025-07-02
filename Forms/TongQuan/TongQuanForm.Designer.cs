using DoAn1_Nhom4_DHTI16A1CL.Data_Transfer_Objects;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.TongQuan
{
    partial class TongQuanForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTong = new System.Windows.Forms.TableLayoutPanel();
            this.tbHienThi = new System.Windows.Forms.TableLayoutPanel();
            this.lbSLKH = new System.Windows.Forms.Label();
            this.lbDoanhThu = new System.Windows.Forms.Label();
            this.lbSLXeMay = new System.Windows.Forms.Label();
            this.lbSLXeDap = new System.Windows.Forms.Label();
            this.txtSLKhachHang = new System.Windows.Forms.Label();
            this.txtDoanhThu = new System.Windows.Forms.Label();
            this.txtSLXeMay = new System.Windows.Forms.Label();
            this.txtSLXeDap = new System.Windows.Forms.Label();
            this.tbBangBieu = new System.Windows.Forms.TableLayoutPanel();
            this.chartTopSanPham = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.tbTong.SuspendLayout();
            this.tbHienThi.SuspendLayout();
            this.tbBangBieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.tbTong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // tbTong
            // 
            this.tbTong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tbTong.ColumnCount = 1;
            this.tbTong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbTong.Controls.Add(this.tbHienThi, 0, 0);
            this.tbTong.Controls.Add(this.tbBangBieu, 0, 1);
            this.tbTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTong.Location = new System.Drawing.Point(0, 0);
            this.tbTong.Name = "tbTong";
            this.tbTong.RowCount = 2;
            this.tbTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tbTong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tbTong.Size = new System.Drawing.Size(800, 450);
            this.tbTong.TabIndex = 0;
            this.tbTong.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
            // 
            // tbHienThi
            // 
            this.tbHienThi.ColumnCount = 4;
            this.tbHienThi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbHienThi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbHienThi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbHienThi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbHienThi.Controls.Add(this.lbSLKH, 3, 1);
            this.tbHienThi.Controls.Add(this.lbDoanhThu, 2, 1);
            this.tbHienThi.Controls.Add(this.lbSLXeMay, 1, 1);
            this.tbHienThi.Controls.Add(this.lbSLXeDap, 0, 1);
            this.tbHienThi.Controls.Add(this.txtSLKhachHang, 3, 0);
            this.tbHienThi.Controls.Add(this.txtDoanhThu, 2, 0);
            this.tbHienThi.Controls.Add(this.txtSLXeMay, 1, 0);
            this.tbHienThi.Controls.Add(this.txtSLXeDap, 0, 0);
            this.tbHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHienThi.Location = new System.Drawing.Point(3, 3);
            this.tbHienThi.Name = "tbHienThi";
            this.tbHienThi.RowCount = 2;
            this.tbHienThi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tbHienThi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tbHienThi.Size = new System.Drawing.Size(794, 219);
            this.tbHienThi.TabIndex = 0;
            // 
            // lbSLKH
            // 
            this.lbSLKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSLKH.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lbSLKH.Location = new System.Drawing.Point(597, 131);
            this.lbSLKH.Name = "lbSLKH";
            this.lbSLKH.Size = new System.Drawing.Size(194, 88);
            this.lbSLKH.TabIndex = 7;
            this.lbSLKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSLKH.BackColor = Color.FromArgb(255, 204, 229);
            this.lbSLKH.ForeColor = Color.DarkRed;
            // 
            // lbDoanhThu
            // 
            this.lbDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDoanhThu.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lbDoanhThu.Location = new System.Drawing.Point(399, 131);
            this.lbDoanhThu.Name = "lbDoanhThu";
            this.lbDoanhThu.Size = new System.Drawing.Size(192, 88);
            this.lbDoanhThu.TabIndex = 6;
            this.lbDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDoanhThu.BackColor = Color.FromArgb(255, 255, 204);
            this.lbDoanhThu.ForeColor = Color.DarkOrange;
            // 
            // lbSLXeMay
            // 
            this.lbSLXeMay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSLXeMay.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lbSLXeMay.Location = new System.Drawing.Point(201, 131);
            this.lbSLXeMay.Name = "lbSLXeMay";
            this.lbSLXeMay.Size = new System.Drawing.Size(192, 88);
            this.lbSLXeMay.BackColor = Color.FromArgb(204, 255, 229);
            this.lbSLXeMay.TabIndex = 5;
            this.lbSLXeMay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSLXeMay.ForeColor = Color.DarkGreen;
            // 
            // lbSLXeDap
            // 
            this.lbSLXeDap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSLXeDap.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.lbSLXeDap.Location = new System.Drawing.Point(3, 131);
            this.lbSLXeDap.Name = "lbSLXeDap";
            this.lbSLXeDap.Size = new System.Drawing.Size(192, 88);
            this.lbSLXeDap.TabIndex = 4;
            this.lbSLXeDap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSLXeDap.BackColor = Color.FromArgb(204, 229, 255);
            this.lbSLXeDap.ForeColor = Color.DarkBlue;
            // 
            // txtSLKhachHang
            // 
            this.txtSLKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSLKhachHang.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.txtSLKhachHang.Location = new System.Drawing.Point(597, 0);
            this.txtSLKhachHang.Name = "txtSLKhachHang";
            this.txtSLKhachHang.Size = new System.Drawing.Size(194, 131);
            this.txtSLKhachHang.TabIndex = 3;
            this.txtSLKhachHang.Text = "Tổng số khách hàng mua hôm nay";
            this.txtSLKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtSLKhachHang.BackColor = Color.FromArgb(255, 204, 229);
            this.txtSLKhachHang.ForeColor = Color.DarkRed;
            this.txtSLKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDoanhThu.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.txtDoanhThu.Location = new System.Drawing.Point(399, 0);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(192, 131);
            this.txtDoanhThu.TabIndex = 2;
            this.txtDoanhThu.BackColor = Color.FromArgb(255, 255, 204);
            this.txtDoanhThu.Text = "Doanh thu hôm nay";
            this.txtDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtDoanhThu.ForeColor = Color.DarkOrange;
            this.txtDoanhThu.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            // 
            // txtSLXeMay
            // 
            this.txtSLXeMay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSLXeMay.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.txtSLXeMay.Location = new System.Drawing.Point(201, 0);
            this.txtSLXeMay.Name = "txtSLXeMay";
            this.txtSLXeMay.Size = new System.Drawing.Size(192, 131);
            this.txtSLXeMay.TabIndex = 1;
            this.txtSLXeMay.Text = "Tổng số xe máy điện hiện có";
            this.txtSLXeMay.BackColor = Color.FromArgb(204, 255, 229);
            this.txtSLXeMay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtSLXeMay.ForeColor = Color.DarkGreen;
            this.txtSLXeMay.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            // 
            // txtSLXeDap
            // 
            this.txtSLXeDap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSLXeDap.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.txtSLXeDap.Location = new System.Drawing.Point(3, 0);
            this.txtSLXeDap.Name = "txtSLXeDap";
            this.txtSLXeDap.Size = new System.Drawing.Size(192, 131);
            this.txtSLXeDap.TabIndex = 0;
            this.txtSLXeDap.Text = "Tổng số xe đạp điện hiện có";
            this.txtSLXeDap.BackColor = Color.FromArgb(204, 229, 255);
            this.txtSLXeDap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtSLXeDap.ForeColor = Color.DarkBlue;
            this.txtSLXeDap.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            // 
            // tbBangBieu
            // 
            this.tbBangBieu.ColumnCount = 2;
            this.tbBangBieu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBangBieu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbBangBieu.Controls.Add(this.chartTopSanPham, 0, 0);
            this.tbBangBieu.Controls.Add(this.chartDoanhThu, 1, 0);
            this.tbBangBieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBangBieu.Location = new System.Drawing.Point(3, 228);
            this.tbBangBieu.Name = "tbBangBieu";
            this.tbBangBieu.RowCount = 1;
            this.tbBangBieu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.tbBangBieu.Size = new System.Drawing.Size(794, 219);
            this.tbBangBieu.TabIndex = 1;
            // 
            // chartTopSanPham
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTopSanPham.ChartAreas.Add(chartArea1);
            this.chartTopSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartTopSanPham.Legends.Add(legend1);
            this.chartTopSanPham.Location = new System.Drawing.Point(3, 3);
            this.chartTopSanPham.Name = "chartTopSanPham";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTopSanPham.Series.Add(series1);
            this.chartTopSanPham.Size = new System.Drawing.Size(391, 213);
            this.chartTopSanPham.TabIndex = 0;
            this.chartTopSanPham.Text = "chart1";
            // 
            // chartDoanhThu
            // 
            chartArea2.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea2);
            this.chartDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend2);
            this.chartDoanhThu.Location = new System.Drawing.Point(400, 3);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDoanhThu.Series.Add(series2);
            this.chartDoanhThu.Size = new System.Drawing.Size(391, 213);
            this.chartDoanhThu.TabIndex = 1;
            this.chartDoanhThu.Text = "chart2";
            // 
            // TongQuanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "TongQuanForm";
            this.Text = "TongQuanForm";
            this.panel1.ResumeLayout(false);
            this.tbTong.ResumeLayout(false);
            this.tbHienThi.ResumeLayout(false);
            this.tbBangBieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTopSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tbTong;
        private System.Windows.Forms.TableLayoutPanel tbHienThi;
        private System.Windows.Forms.TableLayoutPanel tbBangBieu;
        private System.Windows.Forms.Label lbSLKH;
        private System.Windows.Forms.Label lbDoanhThu;
        private System.Windows.Forms.Label lbSLXeMay;
        private System.Windows.Forms.Label lbSLXeDap;
        private System.Windows.Forms.Label txtSLKhachHang;
        private System.Windows.Forms.Label txtDoanhThu;
        private System.Windows.Forms.Label txtSLXeMay;
        private System.Windows.Forms.Label txtSLXeDap;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopSanPham;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;

        private void LoadDashboard()
        {
            // Gán số liệu
            lbSLXeDap.Text = "45 Xe";
            lbSLXeMay.Text = "30 Xe";
            lbDoanhThu.Text = "12,000,000 VNĐ";
            lbSLKH.Text = "9 Khách Hàng";

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