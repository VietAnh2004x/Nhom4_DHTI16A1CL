using DoAn1_Nhom4_DHTI16A1CL.Forms.TongQuan;
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
    public partial class MainForm : Form
    {
        private Form currentFormChild;

        public MainForm()
        {
            InitializeComponent();
            InitializeSidebar();
            this.Load += FormMain_Load; // Gán sự kiện Load
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
                currentFormChild.Close();

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelContent.Controls.Clear();
            panelContent.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            OpenChildForm(new TongQuanForm());
        }

        private void btnTongQuanForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TongQuanForm());
        }

    }
}
