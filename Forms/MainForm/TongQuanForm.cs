using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL.Forms.MainForm
{
    public partial class TongQuanForm : Form
    {
        public TongQuanForm()
        {
            InitializeComponent();
            LoadDashboard();

            Label lblTitle = new Label();
            lblTitle.Text = "Tổng quan hệ thống";
            lblTitle.Font = new Font("Segoe UI", 16);
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.BackColor = System.Drawing.Color.White;
            this.Controls.Add(lblTitle);
        }

    }
}
