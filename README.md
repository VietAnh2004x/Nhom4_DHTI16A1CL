# Đồ án: Xây dựng phần mềm quản lý kinh doanh của một cửa hàng bán xe máy điện, xe đạp điện

## 📌 Giới thiệu
Đây là đồ án môn học nhằm xây dựng một phần mềm quản lý kinh doanh cho cửa hàng chuyên bán **xe máy điện** và **xe đạp điện**, hỗ trợ các hoạt động như quản lý khách hàng, bán hàng, kiểm soát tồn kho, thống kê – báo cáo doanh số và phân quyền người dùng. Phần mềm được phát triển và triển khai trên nền tảng PC

---

## 🎯 Mục tiêu
- Vận dụng kiến thức về **phân tích thiết kế hệ thống**, **cơ sở dữ liệu**, **lập trình giao diện người dùng trên PC**
- Rèn luyện kỹ năng **xây dựng phần mềm theo quy trình chuẩn**, từ khảo sát – phân tích – thiết kế – lập trình – kiểm thử – đóng gói
- Thực hành kỹ năng **làm việc nhóm**, **viết báo cáo kỹ thuật** và **trình bày kết quả**

---

## 🛠️ Các chức năng chính

### 1. Quản lý danh mục
- Quản lý khách hàng
- Quản lý xe
- Quản lý tồn kho
- Quản lý đại lí

### 2. Bán xe
- Xử lý giao dịch bán xe
- Quản lí hóa đơn
- Quản lý bảo hành

### 3. Báo cáo
- Báo cáo doanh thu tuần, tháng, quý, năm
- Xuất báo cáo Excel

### 4. Phân quyền người dùng
- Đăng nhập hệ thống
- Tạo tài khoản
- Phân quyền truy cập
- Đổi mật khẩu

---

## 🧩 Công nghệ sử dụng
- Ngôn ngữ lập trình: `C#`
- Cơ sở dữ liệu: `SQL Server`
- Môi trường phát triển: `Visual Studio`
- Thư viện hỗ trợ: Windows Forms, Office Interop (xuất Excel)...

---

## 📊 Kết quả đầu ra
- Báo cáo phân tích và thiết kế hệ thống (biểu đồ chức năng, DFD, ERD...)
- Hệ quản trị cơ sở dữ liệu (file `.bak`)
- Phần mềm chạy trên máy tính (có thể cài đặt hoặc chạy trực tiếp)
- Tài liệu hướng dẫn sử dụng
- Báo cáo kết quả thực hiện đồ án

---

## 🗂️ Cấu trúc thư mục dự án
<pre> ## 🗂️ Cấu trúc thư mục dự án Dự án được xây dựng theo mô hình 3 lớp (DTO – DAL – BLL), với cấu trúc thư mục rõ ràng, dễ mở rộng và bảo trì: ```plaintext 📁 DoAn1_Nhom4_DHTI16A1CL ├── 📂 Business_Logic_Layer → Xử lý nghiệp vụ (BLL) ├── 📂 Data_Access_Layer → Truy cập và thao tác dữ liệu (DAL) ├── 📂 Data_Transfer_Objects → Các đối tượng trung gian truyền dữ liệu (DTO) ├── 📂 Forms → Giao diện người dùng (Windows Forms) ├── 📂 Reports → Báo cáo thống kê (doanh thu, tồn kho, ...) ├── 📂 Resources → Tài nguyên: hình ảnh, icon, v.v. ├── 📂 Properties → Cấu hình mặc định cho project ├── 📂 References → Thư viện và gói tham chiếu ├── 📄 App.config → File cấu hình kết nối CSDL └── 📄 Program.cs → File khởi tạo và chạy chương trình ``` > ✅ **Ưu điểm:** Cấu trúc này giúp dễ dàng chia nhỏ chức năng, kiểm soát logic xử lý, và đảm bảo code sạch – rõ ràng – dễ bảo trì. </pre>

---

## 👨‍💻 Nhóm thực hiện
- Nguyễn Việt Anh (Trưởng nhóm) – Phân tích thiết kế hệ thống
- Phạm Trần Ngọc Chiến – Tạo cơ sở dữ liệu
- Trần Văn Huy – Code giao diện Windows Forms
- Nguyễn Ngọc Tú - Làm báo cáo, kiểm thử

---

## 📅 Thời gian thực hiện
Từ ngày 25/06/2025 đến 25/07/2025

---

> Mọi góp ý xin vui lòng liên hệ nhóm phát triển để hỗ trợ thêm.
