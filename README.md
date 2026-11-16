# Hotel Management - Lập Trình Trực Quan (LAB 1)

Ứng dụng Quản lý khách sạn trên nền tảng **Windows Forms C# .NET 10**, sử dụng **Entity Framework Core (Database-First)**, **SQL Server LocalDB**, và **ClosedXML**.

- **Mã số sinh viên:** `6551071011`
- **Môn học:** Lập trình trực quan
- **Mục tiêu:** Hoàn thành bài thực hành Buổi 1 (LAB 1)

---

## Các chức năng chính đã triển khai:
1. **Cơ sở dữ liệu (Database.sql):**
   - Thiết lập CSDL `HotelManagement` trên SQL Server `(localdb)\MSSQLLocalDB`.
   - Bao gồm các bảng: `NhanVien`, `TaiKhoan`, `KhachHang`, `Phong`, `LoaiPhong`, `CTDP`, `PhieuThue`, `HoaDon`, `DichVu`, `CTDV`, `TienNghi`, `CTTN`.
   - Ràng buộc toàn vẹn khóa ngoại, trigger tính tiền tự động và nạp dữ liệu mẫu ban đầu.

2. **Xác thực & Phân quyền (DangNhap):**
   - Form Đăng nhập kiểm tra tên đăng nhập và mật khẩu qua EF Core.
   - Quản lý phiên đăng nhập (`MaNV_DangNhap`, `TenNV_DangNhap`, `CapDoQuyen_DangNhap`).
   - Hỗ trợ phím Enter để đăng nhập nhanh.

3. **Màn hình chính & Điều hướng (FormMain & FormTrangChu):**
   - Bố cục MDI dạng container linh hoạt (`panelMain`).
   - Hiển thị thông tin người dùng đang đăng nhập và chức năng Đăng xuất an toàn.
   - Điều hướng các phân hệ: Trang chủ, Sơ đồ phòng, Phòng, Loại phòng, v.v.

4. **Sơ đồ phòng (SoDoPhong):**
   - Bộ lọc đa tiêu chí: Trạng thái phòng (Bình thường, Đã đặt, Đang thuê, Đang sửa chữa), Loại phòng (Thường đơn/đôi, VIP đơn/đôi), Tình trạng dọn dẹp (Đã dọn dẹp, Chưa dọn dẹp).
   - Lọc phòng trống theo ngày (`dtNgayChon`) kiểm tra không trùng lịch đặt `CTDP`.
   - Tìm kiếm phòng tức thì theo mã phòng (`txtSearchMaPhong`).
   - Hiển thị danh sách phòng trực quan với tầng tự động tính từ mã phòng.

5. **Quản lý phòng (Phong):**
   - Danh sách phòng kèm icon trực quan, nút sửa/xóa trên từng dòng.
   - Thêm phòng mới: nạp danh mục loại phòng, kiểm tra trùng mã phòng và hỗ trợ khôi phục phòng đã xóa mềm.
   - Cập nhật thông tin phòng: trạng thái, dọn dẹp, loại phòng, ghi chú.
   - Xóa phòng: kiểm tra ràng buộc không cho xóa phòng đang thuê/đã đặt, thực hiện xóa mềm (`DaXoa = true`).
   - Xuất danh sách phòng ra file Excel `.xlsx` chuyên nghiệp với ClosedXML.

6. **Quản lý loại phòng (LoaiPhong):**
   - Hiển thị danh sách loại phòng với định dạng tiền tệ `N0` cho giá ngày và giá giờ.
   - Thêm loại phòng: ràng buộc chỉ cho phép nhập số cho giường, số người, giá ngày, giá giờ.
   - Cập nhật thông tin loại phòng vào CSDL.
   - Xuất dữ liệu loại phòng ra file Excel `.xlsx` với định dạng số và tự động căn chỉnh độ rộng cột.

---

## Hướng dẫn chạy ứng dụng:
1. Mở Solution `HotelManagement.sln` bằng Visual Studio 2022 / 2026 hoặc Rider.
2. Hoặc chạy bằng dòng lệnh:
   ```powershell
   dotnet run --project HotelManagement\HotelManagement.csproj
   ```
3. Tài khoản đăng nhập mẫu:
   - **Tài khoản:** `admin` | **Mật khẩu:** `1234`
   - **Tài khoản:** `Quanly` | **Mật khẩu:** `1234`
   - **Tài khoản:** `NhanVien` | **Mật khẩu:** `1234`
