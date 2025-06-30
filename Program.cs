using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1_Nhom4_DHTI16A1CL
{
    public partial class MainForm : Form
    {
        private string currentUserRole = "Staff"; // "Admin" hoặc "Staff"
        private Panel contentPanel; // Panel chứa nội dung chính

        public MainForm(string username, string role)
        {
            InitializeComponent();
            currentUserRole = role;
            SetupUI(username);
        }

        private void SetupUI(string username)
        {
            // Thiết lập các thuộc tính cơ bản
            this.Text = "Quản lý cửa hàng xe điện";

            // Cập nhật label username
            lblUsername.Text = username;

            // Thiết lập menu theo role
            if (currentUserRole != "Admin")
            {
                // Ẩn các mục menu chỉ dành cho admin
                treeViewMenu.Nodes[0].Nodes.RemoveByKey("Tổng quan");
                treeViewMenu.Nodes[0].Nodes.RemoveByKey("Quản lý kho");
            }
        }

        private void DropdownButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ContextMenuStrip.Show(btn, new Point(0, btn.Height));
        }

        private void DropdownMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Đăng xuất")
            {
                this.Close();
                // Mở form đăng nhập
                // LoginForm loginForm = new LoginForm();
                // loginForm.Show();
            }
            else if (e.ClickedItem.Text == "Thông tin tài khoản")
            {
                // Mở form thông tin tài khoản
                // AccountInfoForm infoForm = new AccountInfoForm();
                // infoForm.ShowDialog();
            }
        }

        private void MenuTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Xóa các form con cũ nếu có
            foreach (Control control in contentPanel.Controls)
            {
                if (control is Form)
                {
                    ((Form)control).Close();
                }
            }
            contentPanel.Controls.Clear();

            // Tạo form tương ứng với menu được chọn
            Form selectedForm = null;
            string selectedNode = e.Node.Text;

            switch (selectedNode)
            {
                case "Tổng quan":
                    selectedForm = new OverviewForm(); // Tạo form Tổng quan
                    break;
                case "Quản lý khách hàng":
                    selectedForm = new CustomerManagementForm();
                    break;
                case "Xe đạp điện":
                    selectedForm = new ElectricBikeForm();
                    break;
                case "Xe máy điện":
                    selectedForm = new ElectricMotorForm();
                    break;
                case "Quản lý tồn kho":
                    selectedForm = new InventoryForm();
                    break;
                case "Quản lý kho":
                    selectedForm = new WarehouseForm();
                    break;
                case "Quản lý hóa đơn":
                    selectedForm = new InvoiceForm();
                    break;
                case "Quản lý bảo hành":
                    selectedForm = new WarrantyForm();
                    break;
                case "Báo cáo":
                    selectedForm = new ReportForm();
                    break;
                case "Quản lý tài khoản":
                    selectedForm = new AccountManagementForm(); // Form quản lý tài khoản
                    break;
                default:
                    return; // Không làm gì nếu chọn node không xác định
            }

            // Hiển thị form được chọn trong contentPanel
            if (selectedForm != null)
            {
                selectedForm.TopLevel = false;
                selectedForm.FormBorderStyle = FormBorderStyle.None;
                selectedForm.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(selectedForm);
                selectedForm.Show();
            }
        }
    }

    // Các lớp form mẫu (bạn hoặc đồng nghiệp sẽ phát triển chi tiết)
    public class OverviewForm : Form { /* ... */ }
    public class CustomerManagementForm : Form { /* ... */ }
    public class ElectricBikeForm : Form { /* ... */ }
    public class ElectricMotorForm : Form { /* ... */ }
    public class InventoryForm : Form { /* ... */ }
    public class WarehouseForm : Form { /* ... */ }
    public class InvoiceForm : Form { /* ... */ }
    public class WarrantyForm : Form { /* ... */ }
    public class ReportForm : Form { /* ... */ }
    public class AccountManagementForm : Form { /* ... */}
    }
