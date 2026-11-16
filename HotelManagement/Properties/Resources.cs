using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace HotelManagement.Properties
{
    internal static class Resources
    {
        private static readonly Dictionary<string, Image> _cache = new(StringComparer.OrdinalIgnoreCase);

        private static Image GetImage(string name)
        {
            if (_cache.TryGetValue(name, out var cached) && cached != null)
                return cached;

            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(baseDir, "Resources", name + ".png");
            if (File.Exists(path))
            {
                using var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                using var ms = new MemoryStream();
                fs.CopyTo(ms);
                ms.Position = 0;
                var img = Image.FromStream(ms);
                _cache[name] = img;
                return img;
            }

            // Fallback development path
            string devPath = Path.Combine(@"D:\Lap_Trinh_Truc_Quan\THB1\HotelManagement\Resources", name + ".png");
            if (File.Exists(devPath))
            {
                using var fs = new FileStream(devPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                using var ms = new MemoryStream();
                fs.CopyTo(ms);
                ms.Position = 0;
                var img = Image.FromStream(ms);
                _cache[name] = img;
                return img;
            }

            var dummy = new Bitmap(16, 16);
            _cache[name] = dummy;
            return dummy;
        }

        public static Image _3people => GetImage("3people");
        public static Image Add => GetImage("Add");
        public static Image Address => GetImage("Address");
        public static Image admin => GetImage("admin");
        public static Image back => GetImage("back");
        public static Image calendardark => GetImage("calendardark");
        public static Image CalendarPick => GetImage("CalendarPick");
        public static Image calendarwhite => GetImage("calendarwhite");
        public static Image CCCD => GetImage("CCCD");
        public static Image clean => GetImage("clean");
        public static Image clock => GetImage("clock");
        public static Image ClockPick => GetImage("ClockPick");
        public static Image DaDat => GetImage("DaDat");
        public static Image DangNhap => GetImage("DangNhap");
        public static Image DangSuaChua => GetImage("DangSuaChua");
        public static Image DangSuaChuaBlackMin => GetImage("DangSuaChuaBlackMin");
        public static Image database => GetImage("database");
        public static Image DatPhongChart => GetImage("DatPhongChart");
        public static Image delete => GetImage("delete");
        public static Image delete1 => GetImage("delete1");
        public static Image details => GetImage("details");
        public static Image DichVu => GetImage("DichVu");
        public static Image DichVu1 => GetImage("DichVu1");
        public static Image DichVu2 => GetImage("DichVu2");
        public static Image DichVuChart => GetImage("DichVuChart");
        public static Image DoanhThu => GetImage("DoanhThu");
        public static Image DoanhThuThue => GetImage("DoanhThuThue");
        public static Image edit => GetImage("edit");
        public static Image email => GetImage("email");
        public static Image error => GetImage("error");
        public static Image fix => GetImage("fix");
        public static Image fix50 => GetImage("fix50");
        public static Image fixedcloseresize => GetImage("fixedcloseresize");
        public static Image fixedgreenresize => GetImage("fixedgreenresize");
        public static Image fixedmaxresize => GetImage("fixedmaxresize");
        public static Image fixedminresize => GetImage("fixedminresize");
        public static Image fixednone => GetImage("fixednone");
        public static Image fixedredresize => GetImage("fixedredresize");
        public static Image fixedyellowresize => GetImage("fixedyellowresize");
        public static Image Gender => GetImage("Gender");
        public static Image Giuong => GetImage("Giuong");
        public static Image Giuong1 => GetImage("Giuong1");
        public static Image heart => GetImage("heart");
        public static Image hide => GetImage("hide");
        public static Image HoaDon => GetImage("HoaDon");
        public static Image KhachHang => GetImage("KhachHang");
        public static Image Menu => GetImage("Menu");
        public static Image Menu1 => GetImage("Menu1");
        public static Image MenuChiTietTienNghi => GetImage("MenuChiTietTienNghi");
        public static Image MenuDanhSachHoaDon => GetImage("MenuDanhSachHoaDon");
        public static Image MenuDatPhong => GetImage("MenuDatPhong");
        public static Image MenuLoaiPhong => GetImage("MenuLoaiPhong");
        public static Image MenuPhong => GetImage("MenuPhong");
        public static Image MenuQuanLy => GetImage("MenuQuanLy");
        public static Image MenuQuanLyDichVu => GetImage("MenuQuanLyDichVu");
        public static Image MenuQuanLyKhachHang => GetImage("MenuQuanLyKhachHang");
        public static Image MenuQuanLyNhanVien => GetImage("MenuQuanLyNhanVien");
        public static Image MenuQuanLyTaiKhoan => GetImage("MenuQuanLyTaiKhoan");
        public static Image MenuSoDoPhong => GetImage("MenuSoDoPhong");
        public static Image MenuThongKe => GetImage("MenuThongKe");
        public static Image MenuTienNghi => GetImage("MenuTienNghi");
        public static Image MenuTrangChu => GetImage("MenuTrangChu");
        public static Image message => GetImage("message");
        public static Image money => GetImage("money");
        public static Image Name => GetImage("Name");
        public static Image NhanVien => GetImage("NhanVien");
        public static Image NhanVien1 => GetImage("NhanVien1");
        public static Image none => GetImage("none");
        public static Image note => GetImage("note");
        public static Image password => GetImage("password");
        public static Image people => GetImage("people");
        public static Image PhieuThue => GetImage("PhieuThue");
        public static Image PhieuThueDgv => GetImage("PhieuThueDgv");
        public static Image Phone => GetImage("Phone");
        public static Image Phong => GetImage("Phong");
        public static Image phong_icon => GetImage("phong_icon");
        public static Image pictureIcon => GetImage("pictureIcon");
        public static Image pictureIconLogoHD => GetImage("pictureIconLogoHD");
        public static Image pictureIconNoneBackGroundResize => GetImage("pictureIconNoneBackGroundResize");
        public static Image pictureIconNoneBackGroundResize55 => GetImage("pictureIconNoneBackGroundResize55");
        public static Image printer => GetImage("printer");
        public static Image QuenMatKhau => GetImage("QuenMatKhau");
        public static Image question => GetImage("question");
        public static Image search => GetImage("search");
        public static Image selection => GetImage("selection");
        public static Image show => GetImage("show");
        public static Image SoLuong => GetImage("SoLuong");
        public static Image SoNguoi => GetImage("SoNguoi");
        public static Image SoPhongDat => GetImage("SoPhongDat");
        public static Image staffResize => GetImage("staffResize");
        public static Image TaiKhoan => GetImage("TaiKhoan");
        public static Image ThuePhongChart => GetImage("ThuePhongChart");
        public static Image tick => GetImage("tick");
        public static Image tickblack => GetImage("tickblack");
        public static Image TienNghi => GetImage("TienNghi");
        public static Image TimePicker => GetImage("TimePicker");
        public static Image TimePickerBlack => GetImage("TimePickerBlack");
        public static Image TimePickerWhite => GetImage("TimePickerWhite");
        public static Image top1 => GetImage("top1");
        public static Image top2 => GetImage("top2");
        public static Image top3 => GetImage("top3");
        public static Image user => GetImage("user");
        public static Image warning => GetImage("warning");
        public static Image x => GetImage("x");
    }
}
