CREATE DATABASE OGCCinema
ON 
	(NAME ='Cinema_datst', FILENAME = 'D:\Project1\OGCst.mdf', -- first
	 SIZE = 20, MAXSIZE = 100, FILEGROWTH = 5),
	 (NAME ='Cinema_datnd', FILENAME = 'D:\Project1\OGCnd.ndf',-- second
	 SIZE = 20, MAXSIZE = 100, FILEGROWTH = 5)
LOG ON
	(NAME ='Cinema_logst', FILENAME = 'D:\Project1\OGCst.ldf', -- log first
	 SIZE = 15, MAXSIZE = 75, FILEGROWTH = 5),
	 (NAME ='Cinema_lognd', FILENAME = 'D:\Project1\OGCnd.ldf',-- log second
	 SIZE = 15, MAXSIZE = 75, FILEGROWTH = 5)
GO

USE OGCCinema

GO

--1. Bảng tài khoản khách hàng

CREATE TABLE TKKHACHHANG (
    Username NVARCHAR(50) PRIMARY KEY,            -- Tên đăng nhập (username), khóa chính
    Password VARBINARY(MAX) NOT NULL,                 -- Mật khẩu của khách hàng
    NgayTao DATETIME DEFAULT GETDATE()           -- Ngày tạo tài khoản
);
GO

--2. Bảng Khách Hàng
CREATE TABLE KHACHHANG (
    ID INT IDENTITY(1,1) PRIMARY KEY,              -- Khóa chính, tự động tăng
    Username NVARCHAR(50) NOT NULL UNIQUE,                 -- Tên đăng nhập của khách hàng (khóa ngoại)
    HoTen NVARCHAR(100) NULL,                         -- Tên khách hàng
    Tuoi INT NULL CHECK (Tuoi >= 12),                 -- Tuổi khách hàng phải >= 0
    DiaChi NVARCHAR(255) NULL,                      -- Địa chỉ khách hàng
    SDT NVARCHAR(15) NULL CHECK (SDT LIKE '0[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'), -- Ràng buộc số điện thoại
    Email NVARCHAR(100) NULL CHECK (Email LIKE '%@gmail.com'),  -- Ràng buộc email
    DiemThuong INT DEFAULT 0, -- 'Dùng để đổi điểm thưởng' ,
	FOREIGN KEY (Username) REFERENCES TKKHACHHANG(Username) -- Liên kết với bảng TKKhachHang
);
GO

--3. Bảng chức vụ
CREATE TABLE CHUCVU (
    ID INT PRIMARY KEY IDENTITY(1,1), -- Khóa chính, tự động tăng
    TenChucVu NVARCHAR(100) NULL CHECK (TenChucVu IN(N'Nhân viên bán vé', N'Nhân viên dịch vụ', N'Quản lý', N'Chủ rạp', N'Kế toán')) UNIQUE -- có 3 loại nhân viên: bán vé, dịch vụ (ăn uống), quản lý lịch chiếu
);
GO


--4. Bảng tài khoản nhân viên
CREATE TABLE TKNHANVIEN (
    Username NVARCHAR(50) PRIMARY KEY NOT NULL, --tên đăng nhập của nhân viên, khóa chính
    Password VARBINARY(MAX) NOT NULL,  --mật khẩu của tên đăng nhập
	TrangThai NVARCHAR(20) NULL
);
GO

--Bảng lưu trữ tạm thời tài khoản nv
CREATE TABLE LuuTruTam_TKNhanVien_DangDangNhap (
    Username NVARCHAR(50) PRIMARY KEY
);
GO

--5. Bảng nhân viên
CREATE TABLE NHANVIEN (
    ID INT PRIMARY KEY IDENTITY(1,1), -- Khóa chính, tự động tăng
	Username NVARCHAR(50) NOT NULL UNIQUE, --Khóa ngoại, liên kết với bảng TKNHANVIEN
	IDChucVu INT NULL, --Khóa ngoại, liên kết với bảng CHUCVU
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE,
	NgayVao DATE default '2025-5-1',
    GioiTinh NVARCHAR(10),
    SDT NVARCHAR(15),
    Email NVARCHAR(100),
    DiaChi NVARCHAR(200),
	AnhNV NVARCHAR(200),
	
	FOREIGN KEY (Username) REFERENCES TKNHANVIEN(Username),
	FOREIGN KEY (IDChucVu) REFERENCES CHUCVU(ID)

);
GO



--6. Bảng thể loại phim
CREATE TABLE THELOAIPHIM(
	ID INT PRIMARY KEY IDENTITY(1,1),
	TenTheLoai NVARCHAR(50) NOT NULL UNIQUE CHECK (TenTheLoai IN (N'Kinh dị', N'Hài hước', N'Tình cảm', N'Khoa học viễn tưởng'))  -- Ràng buộc thể loại phim
)
GO

--7. Bảng định dạng phim
CREATE TABLE DINHDANGPHIM (
    ID INT PRIMARY KEY IDENTITY(1,1),
    TenDinhDang NVARCHAR(20) NOT NULL UNIQUE CHECK (TenDinhDang IN (N'2D', N'3D', N'IMAX', N'4DX'))
);
GO

-- Table DoTuoi
CREATE TABLE DOTUOI (
    ID NVARCHAR(10) PRIMARY KEY,         -- Ví dụ: 'P', 'C13', 'C16', 'C18'
    TenDoTuoi NVARCHAR(100) NOT NULL     -- Ví dụ: 'Phổ biến', 'Cấm dưới 13 tuổi'
);
GO

--7. Bảng Phim 
CREATE TABLE PHIM (
    ID INT IDENTITY(1,1) PRIMARY KEY,                  -- Khóa chính, tự động tăng
    TenPhim NVARCHAR(100) NOT NULL UNIQUE,                     -- Tên phim
    DaoDien NVARCHAR(100) NULL,                         -- Tên đạo diễn
    DienVien NVARCHAR(255) NULL,                        -- Tên diễn viên
    IDTheLoaiPhim INT NOT NULL, 
	IDDinhDang INT NOT NULL,
	IDDoTuoi NVARCHAR(10) NULL,
    ThoiLuong INT NOT NULL CHECK (ThoiLuong >= 60 AND ThoiLuong <= 240),     -- Thời lượng phim phải > 100 phút
    MoTa NVARCHAR(500) NULL,                            -- Mô tả phim
    NgayKhoiChieu DATETIME NOT NULL,                    -- Ngày khởi chiếu
    TrangThai INT DEFAULT 1 CHECK (TrangThai IN (0, 1)),  -- Trang thái phim (1: đang chiếu, 0: không chiếu),
    Trailer_Url NVARCHAR(255) NULL,
    Poster_Url NVARCHAR(255) NULL, -- ảnh poster (link)
    Anh NVARCHAR(255) NULL,         -- trường mới để lưu link ảnh phim (có thể khác poster)
	

	FOREIGN KEY (IDTheLoaiPhim) REFERENCES THELOAIPHIM(ID),
	FOREIGN KEY (IDDinhDang) REFERENCES DINHDANGPHIM(ID),
	FOREIGN KEY (IDDoTuoi) REFERENCES DOTUOI(ID)
);
GO


--8. Bảng Loại phòng chiếu
CREATE TABLE LOAIPHONG(
	ID INT PRIMARY KEY IDENTITY(1,1), -- Khóa chính, tự động tăng
	TenLoaiPhong NVARCHAR(20) NOT NULL CHECK (TenLoaiPhong IN (N'Thuờng', N'VIP', N'Couple')) UNIQUE, --Có 3 loại phòng: Thường, VIP, 'Khác'
	SucChua INT NOT NULL CHECK  (SucChua >= 0) DEFAULT 0       -- Sức chứa phòng chiếu phải >= 0
)
GO



-- 9. Bảng PhongChieu
CREATE TABLE PHONGCHIEU (
    ID INT IDENTITY(1,1) PRIMARY KEY,                -- Khóa chính, tự động tăng
    TenPhong NVARCHAR(50) NOT NULL CHECK (TenPhong LIKE 'OGC%' AND LEN(TenPhong) = 4) UNIQUE, -- Ràng buộc tên phòng chiếu theo dạng OGC1, OGC2, ...

    TrangThai INT DEFAULT 1 CHECK (TrangThai IN (0, 1)),  -- Trang thái phòng (1: hoạt động, 0: không hoạt động)
	MaLoaiPhong INT NOT NULL,
	AnhPhong NVARCHAR(255) NULL,
    FOREIGN KEY (MaLoaiPhong) REFERENCES LOAIPHONG(ID) --liên kết tới bảng LOAIPHONG
);
GO



--10. Bảng Ghe
CREATE TABLE GHE (
    ID INT PRIMARY KEY IDENTITY(1,1),
    IDPhong INT NOT NULL,
    MaGhe NVARCHAR(10) NOT NULL, UNIQUE (MaGhe, IDPhong), 
	TrangThai int default 0 Check (TrangThai IN (0,1)) , --Nếu 0 là trống, 1 là đã đặt
    FOREIGN KEY (IDPhong) REFERENCES PHONGCHIEU(ID)
);
GO

--11. Bảng Lịch chiếu
CREATE TABLE LICHCHIEU (
    ID INT IDENTITY(1,1) PRIMARY KEY,                 -- Khóa chính, tự động tăng
    IDPhim INT NOT NULL,                              -- Khóa ngoại liên kết với bảng PHIM

	TenPhim NVARCHAR(100) NULL,				-- trường rỗng lưu trữ tên phim khi xóa ID (PHIM) (TenPhim = PHIM.TenPhim)
	TenPhong NVARCHAR(50) NULL,				-- trường rỗng lưu trữ tên phim khi xóa ID (PHONGCHIEU) (TenPhong = PHONG.TenPhong)

    IDPhong INT NOT NULL,							  -- Khóa ngoại liên kết với bảng PHONGCHIEU
    NgayGio DATETIME NOT NULL,                        -- Thời gian chiếu
    GiaVe DECIMAL(6, 0) NOT NULL CHECK (GiaVe > 0),  -- Giá vé phải > 50.000 VNĐ và < 200.000 VNĐ
	DiaDiem NVARCHAR(255) NULL,                   -- Địa điểm chiếu
    FOREIGN KEY (IDPhim) REFERENCES PHIM(ID),        -- Liên kết với bảng PHIM
	FOREIGN KEY (IDPhong) REFERENCES PHONGCHIEU(ID)     -- Liên kết với bảng PHONGCHIEU
);
GO




--18. Bảng khuyến mãi
CREATE TABLE KHUYENMAI (
    MaKM NVARCHAR(20) PRIMARY KEY, 
    TenKM NVARCHAR(100) NULL,
	MucGiam INT NULL,
    NgayBatDau DATE NULL,
    NgayKetThuc DATE NULL,
	MoTa NVARCHAR(255) NULL,
	LoaiApDung NVARCHAR(50) CHECK (LoaiApDung IN (N'Vé', N'Dịch vụ'))
);
GO

INSERT INTO KHUYENMAI (MaKM, TenKM, MucGiam, NgayBatDau, NgayKetThuc, MoTa, LoaiApDung)
VALUES 
('KM01', N'Khuyến mãi dịch vụ hè', 15, '2025-06-01', '2025-06-30', N'Giảm 15% cho dịch vụ', N'Dịch vụ'),
('KM02', N'Ưu đãi dịch vụ VIP', 20, '2025-06-05', '2025-06-20', N'Giảm 20% cho dịch vụ VIP', N'Dịch vụ'),
('KM03', N'Giảm giá vé tháng 6', 10, '2025-06-10', '2025-06-25', N'Giảm 10% cho vé', N'Vé');

GO

--12. Bảng hóa đơn bán vé
CREATE TABLE HD_VE (
    ID INT PRIMARY KEY IDENTITY(1,1), -- Khóa chính, tự động tăng
	MaKM NVARCHAR(20) NULL, --Khóa ngoại, liên kết với bảng KHUYENMAI

	IDNhanVien INT NULL, 
	TenNV NVARCHAR(50) DEFAULT N'Đang cập nhật', --trường rỗng lưu trữ tên nhân viên khi xóa IDNhanVien (NHANVIEN) (TenNV = NHANVIEN.Ten)
	SdtNV  NVARCHAR(15) NULL, --trường rỗng lưu trữ sđt nhân viên khi xóa IDNhanVien (NHANVIEN) (SdtNV = NHANVIEN.SDT)

    IDKhachHang INT NULL, --Khóa ngoại, liên kết với bảng KHACHHANG
	TenKH NVARCHAR(50) DEFAULT N'Đang cập nhật', --trường rỗng lưu trữ tên kháchh hàng khi xóa IDKhachHang (KHACHHANG)
	SdtKH  NVARCHAR(15) NULL, --trường rỗng lưu trữ sđt khách hàng khi xóa IDKhachHang (KHACHHANG)

    NgayDat DATETIME NOT NULL DEFAULT GETDATE(), --ngày đặt vé
    TongTien DECIMAL(10,2) NULL CHECK (TongTien >= 0), --tổng tiền vé

	FOREIGN KEY (MaKM) REFERENCES KHUYENMAI(MaKM), --liên kết với bảng KHUYENMAI
    FOREIGN KEY (IDKhachHang) REFERENCES KHACHHANG(ID), --liên kết với bảng KHACHHANG
	FOREIGN KEY (IDNhanVien) REFERENCES NHANVIEN(ID) --liên kết với bảng NHANVIEN
);
GO


-- 13. Bảng Ve
CREATE TABLE VE (
    ID INT IDENTITY(1,1) PRIMARY KEY,            -- Khóa chính, tự động tăng
	IDHoaDonVe INT NOT NULL, --Khóa ngoại, liên kết với bảng HD_VE
    IDLichChieu INT NOT NULL,                     -- ID của suất chiếu (khóa ngoại)
    IDGhe INT NOT NULL,							-- Khóa ngoại, liên kết với bảng GHE
    SoLuong INT NOT NULL CHECK (SoLuong > 0),     -- Số lượng vé phải > 0
	GiaVe DECIMAL(6,0) NOT NULL,  --giá vé phải từ 50000

	GioChieu DATETIME NULL,    --trường dữ liệu rỗng lưu trữ Giờ chiếu (GioChieu = LICHCHIEU.NgayGio)

    NgayMua DATETIME DEFAULT GETDATE(),          -- Ngày mua vé

    FOREIGN KEY (IDLichChieu) REFERENCES LichChieu(ID),  -- Liên kết với bảng SUATCHIEU
	FOREIGN KEY (IDGhe) REFERENCES GHE(ID), -- Liên kết với bảng GHE
	FOREIGN KEY (IDHoaDonVe) REFERENCES HD_VE(ID) --Khóa ngoại, liên kết với bảng HD_VE
);
GO



--14. Bảng loại đồ ăn
CREATE TABLE LOAIMONAN (
    ID INT PRIMARY KEY IDENTITY(1,1), -- Khóa chính, tự động tăng
    TenLoai NVARCHAR(100) NOT NULL CHECK (TenLoai IN (N'Nước uống', N'Thức ăn', N'Khác')) UNIQUE --Có 3 loại đồ ăn: nước uống, thức ăn, 'khác'
);
GO

--15. Bảng đồ ăn
CREATE TABLE MONAN (
    ID INT PRIMARY KEY IDENTITY(1,1), -- Khóa chính, tự động tăng
    TenMonAn NVARCHAR(100) NOT NULL UNIQUE, --cần bổ sung ràng buộc CHECK
	IDLoaiMonAn INT NOT NULL, --Khóa ngoại, liên kết với bảng LOAIMONAN
    Gia DECIMAL(8,0) NULL CHECK (Gia >= 0), --Giá vé phải lớn hơn 0
    MoTa NVARCHAR(255) NULL, --mô tả món ăn
	Anh NVARCHAR(MAX) NULL, -- Lưu đường dẫn hoặc tên file ảnh

	FOREIGN KEY (IDLoaiMonAn) REFERENCES LOAIMONAN(ID) --liên kết với bảng LOAIMONAN
);
GO


--16. Bảng hóa đơn đồ ăn
CREATE TABLE HD_MONAN (
    ID INT PRIMARY KEY IDENTITY(1,1), -- Khóa chính, tự động tăng
	MaKM NVARCHAR(20) NULL, --Khóa ngoại, liên kết với bảng KHUYENMAI

	IDNhanVien INT NULL, ----Khóa ngoại, liên kết với bảng NHANVIEN
	TenNV NVARCHAR(50) DEFAULT N'Đang cập nhật',
	SdtNV  NVARCHAR(15) NULL, -- Ràng buộc số điện thoại

    IDKhachHang INT NULL, --Khóa ngoại, liên kết với bảng KHACHHANG
	TenKH NVARCHAR(50) DEFAULT N'Đang cập nhật',
	SdtKH  NVARCHAR(15) NULL, 

    NgayMua DATETIME NOT NULL DEFAULT GETDATE(), --Ngày mua món ăn
    TongTien DECIMAL(10,0) NULL CHECK (TongTien >= 0), --tổng tiền hóa đơn món ăn
	
	FOREIGN KEY (MaKM) REFERENCES KHUYENMAI(MaKM), --liên kết với bảng KHUYENMAI
    FOREIGN KEY (IDKhachHang) REFERENCES KHACHHANG(ID), --liên kết với bảng LOAIMONAN
	FOREIGN KEY (IDNhanVien) REFERENCES NHANVIEN(ID) --liên kết với bảng NHANVIEN
);
GO


--17. Bảng chi tiết hóa đơn đồ ăn
CREATE TABLE CTHD_MONAN (
    ID INT PRIMARY KEY IDENTITY(1,1), -- Khóa chính, tự động tăng

	TenMonAn NVARCHAR(100) NULL, --trường dữ liệu rỗng lưu trữ TenMonAn = MONAN.TenMonAn khi ID (MONAN) bị xóa
	Gia DECIMAL(8,0) NULL, --trường dữ liệu rỗng lưu trữ Gia = MONAN.Gia khi ID (MONAN) bị xóa
	SoLuong INT NOT NULL CHECK (SoLuong >0 ), 

	NgayMua DATETIME DEFAULT GETDATE(),          -- Ngày mua vé

    IDHoaDon INT NOT NULL, --Khóa ngoại, liên kết với bảng HD_MONAN
    IDMonAn INT NULL, --Khóa ngoại, liên kết với bảng MONAN
	TrangThai NVARCHAR(20) NULL,

    FOREIGN KEY (IDHoaDon) REFERENCES HD_MONAN(ID), --liên kết với bảng HD_MONAN
    FOREIGN KEY (IDMonAn) REFERENCES MONAN(ID) --liên kết với bảng MONAN
);
GO


CREATE TABLE KHO (
    ID INT PRIMARY KEY IDENTITY(1,1),
    IDMonAn INT NULL, -- Mỗi món ứng với 1 dòng trong KHO
    SoLuongTon INT NOT NULL CHECK (SoLuongTon >= 0),
    NgayCapNhat DATETIME DEFAULT GETDATE(),
	TenMonAn NVARCHAR(50) NULL

    FOREIGN KEY (IDMonAn) REFERENCES MONAN(ID)
);
GO

--Tạo bảng LOG_NHANVIEN ===> lưu trữ nhật ký hoạt động của nhân viên
CREATE TABLE LOG_NHANVIEN (
    ID INT IDENTITY(1,1) PRIMARY KEY,              -- Mã log tự tăng
    Username NVARCHAR(50) NULL,                -- Tên đăng nhập nhân viên
    IDChucVu INT NULL,                             -- Mã chức vụ của nhân viên
    ThaoTac NVARCHAR(200) NULL,                -- Mô tả thao tác (Thêm/Sửa/Xóa gì)
    ThoiGian DATETIME DEFAULT GETDATE(),           -- Thời gian thực hiện
    ChucNang NVARCHAR(100) NULL,                   -- Phân loại chức năng (Phim, Dịch vụ,...)

    FOREIGN KEY (Username) REFERENCES TKNHANVIEN(Username),
    FOREIGN KEY (IDChucVu) REFERENCES CHUCVU(ID)
);
GO

--Thêm Table TRANGTHAIGHE để lưu trạng thái của ghế vì cần nhiều trạng thái trong 1 ngày 
CREATE TABLE TRANGTHAIGHE (
    ID INT IDENTITY PRIMARY KEY,
    IDGhe INT NOT NULL,
    NgayChieu DATE NOT NULL,
    GioChieu TIME NOT NULL,
    TrangThai INT CHECK (TrangThai IN (0, 1)) DEFAULT 0,
    FOREIGN KEY (IDGhe) REFERENCES GHE(ID)
);
GO

-- Phiên bản trigger có kiểm tra tồn kho
CREATE TRIGGER trg_TruKhoSauKhiBan
ON CTHD_MONAN
AFTER INSERT
AS
BEGIN
    -- Nếu có món nào không đủ tồn kho thì rollback
    IF EXISTS (
        SELECT 1
        FROM KHO k
        JOIN INSERTED i ON k.IDMonAn = i.IDMonAn
        WHERE k.SoLuongTon < i.SoLuong
    )
    BEGIN
        RAISERROR (N'Số lượng tồn kho không đủ.', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END

    -- Nếu đủ thì cập nhật
    UPDATE KHO
    SET SoLuongTon = SoLuongTon - i.SoLuong,
        NgayCapNhat = GETDATE()
    FROM KHO
    JOIN INSERTED i ON KHO.IDMonAn = i.IDMonAn
END
GO

CREATE TRIGGER trg_RestoreStock_AfterDelete --hoàn lại số lượng tồn khi xóa cthd_monan
ON CTHD_MONAN
AFTER DELETE
AS
BEGIN
    UPDATE KHO
    SET SoLuongTon = SoLuongTon + d.SoLuong
    FROM KHO k
    INNER JOIN DELETED d ON k.IDMonAn = d.IDMonAn;
END;
GO





--------------------------------- TẠO DỮ LIỆU MẪU ---------------------------------

--------------- TABLE KHo ----------------
INSERT INTO KHO (IDMonAn, SoLuongTon) 
VALUES 
(1, 10),
(2, 10),
(3, 10);

------------TABLE Tài khoản khách hàng -------------------
INSERT INTO TKKHACHHANG (Username, Password)
VALUES 
(N'khach1', CONVERT(VARBINARY, '123456')),
(N'khach2', CONVERT(VARBINARY, 'abcdef')),
(N'khach3', CONVERT(VARBINARY, 'matkhau'));
GO

--------------------    Thông tin khách hàng      --------------------
INSERT INTO KHACHHANG (Username, HoTen, Tuoi, DiaChi, SDT, Email, DiemThuong)
VALUES 
(N'khach1', N'Nguyễn Văn A', 25, N'123 Đường 1, Q1, TP.HCM', '0901234567', 'nva@gmail.com', 0),
(N'khach2', N'Trần Thị B', 30, N'456 Đường 2, Q3, TP.HCM', '0912345678', 'ttb@gmail.com', 0),
(N'khach3', N'Lê Văn C', 22, N'789 Đường 3, Q5, TP.HCM', '0923456789', 'lvc@gmail.com', 0);
GO

--------------------     Chức vụ nhân viên     --------------------
INSERT INTO CHUCVU (TenChucVu)
VALUES 
(N'Nhân viên bán vé'),
(N'Nhân viên dịch vụ'),
(N'Quản lý');
GO

INSERT INTO CHUCVU (TenChucVu)
VALUES 
(N'Chủ rạp'),
(N'Kế toán');
GO

--------------------    Tài khoản nhân viên      --------------------
INSERT INTO TKNHANVIEN (Username, Password)
VALUES 
('hnghia', HASHBYTES('SHA2_256', 'hnghia')),
('tnghia', HASHBYTES('SHA2_256', 'tnghia')),
(N'admin', HASHBYTES('SHA2_256', 'admin')),
(N'ketoan', HASHBYTES('SHA2_256', 'ketoan'));
GO



--------------------     Thông tin nhân viên     --------------------
INSERT INTO NHANVIEN (Username, IDChucVu, HoTen, NgaySinh, GioiTinh, SDT, Email, DiaChi, AnhNV)
VALUES 
(N'hnghia', 2, N'Nguyễn Hoàng Nghĩa', '2004-4-21', N'Nam', '0397419555', 'hoangnghia@gmail.com', N'111 Đường A, Q1', N'C:/CinemaManagement/OGC/Image/iconNguoi1.png'),
(N'tnghia', 1, N'Phan Trung Nghĩa', '2004-9-14', N'Nam', '0333701410', 'trungnghia@gmail.com', N'222 Đường B, Q2', N'C:/CinemaManagement/OGC/Image/iconNguoi1.png'),
(N'admin', 3, N'Đặng Văn F', '1990-01-15', N'Nam', '0956789012', 'dvf@gmail.com', N'333 Đường C, Q3', N'C:/CinemaManagement/OGC/Image/iconNguoi1.png'),
(N'ketoan', 5, N'Đặng Văn G', '1990-01-15', N'Nam', '0956789012', 'dvf@gmail.com', N'333 Đường C, Q3', N'C:/CinemaManagement/OGC/Image/iconNguoi1.png');
GO





--------------------    Thể loại phim      --------------------
INSERT INTO THELOAIPHIM (TenTheLoai)
VALUES 
(N'Kinh dị'),
(N'Hài hước'),
(N'Khoa học viễn tưởng');
GO
--------------------    Định dạng phim      --------------------
INSERT INTO DINHDANGPHIM (TenDinhDang)
VALUES 
(N'2D'),
(N'3D'),
(N'IMAX');
GO

--------------------    Độ tuổi xem phim      --------------------
INSERT INTO DOTUOI (ID, TenDoTuoi)
VALUES 
('P', N'Phổ biến – Mọi lứa tuổi'),
('C13', N'Cấm dưới 13 tuổi'),
('C18', N'Cấm dưới 18 tuổi');
GO

--------------------    Danh sách phim      --------------------
INSERT INTO PHIM (TenPhim, DaoDien, DienVien, IDTheLoaiPhim, IDDinhDang, IDDoTuoi, ThoiLuong, MoTa, NgayKhoiChieu, TrangThai, Trailer_Url, Poster_Url, Anh)
VALUES 
(N'EndGame', N'Jon Watts', N'Tom Holland, Zendaya', 1, 1, 'P', 135, N'Phim siêu anh hùng Marvel nổi tiếng.', '2025-06-01', 1, NULL, NULL, N'C:/CinemaManagement/OGC/Image/PosterPhim/EndGame.jpg'),

(N'Ba mặt lật kèo', N'Nguyễn Hữu Tuấn', N'Truong Giang, Trấn Thành', 2, 2, 'C13', 100, N'Phim hài nhẹ nhàng, giải trí cuối tuần.', '2025-06-02', 1, NULL , NULL , N'C:/CinemaManagement/OGC/Image/PosterPhim/Test1.jpg'),

(N'Ma Quái: Bóng Tối', N'James Wan', N'Patrick Wilson, Vera Farmiga', 3, 3, 'C18', 110, N'Phim kinh dị đầy ám ảnh và giật gân.', '2025-06-03', 1, NULL, NULL, N'C:/CinemaManagement/OGC/Image/PosterPhim/Test1.jpg');

 
 --------------------    Loại phòng chiếu     --------------------
 INSERT INTO LOAIPHONG (TenLoaiPhong)
VALUES 
(N'Thuờng'),
(N'VIP'),
(N'Couple');
 GO


  --------------------   Danh sách phòng chiếu     --------------------
 INSERT INTO PHONGCHIEU (TenPhong, SucChua, TrangThai, MaLoaiPhong, AnhPhong)
VALUES 
('OGC1', 100, 1, 1, N'C:/CinemaManagement/OGC/Image/AnhPhongChieu/Thuong.jpg'),
('OGC2', 120, 1, 2, N'C:/CinemaManagement/OGC/Image/AnhPhongChieu/VIP.png'),
('OGC3', 80, 1, 3, N'C:/CinemaManagement/OGC/Image/AnhPhongChieu/couple.jpg');
 GO


  --------------------   Ghế ngồi trong phòng chiếu    --------------------
 -- Giả sử mỗi phòng có ít nhất 3 ghế để test
INSERT INTO GHE (IDPhong, MaGhe, TrangThai)
VALUES 
(2, 'A1', 0),
(2, 'A2', 1),
(2, 'B1', 0),

(2, 'B2', 1),
(2, 'C1', 0),
(2, 'C2', 1);
 GO


  --------------------  Lịch chiếu phim     --------------------
 INSERT INTO LICHCHIEU (IDPhim, TenPhim, IDPhong, TenPhong, NgayGio, GiaVe, DiaDiem)
VALUES 
(2, N'EndGame', 2, 'OGC1', '2025-06-05 18:00:00', 600, N'Rạp CGV Quận 1'),

(3, N'Ba mặt lật kèo', 2, 'OGC2', '2025-06-05 20:00:00', 600, N'Lotte Cinema Gò Vấp'),

(4, N'Ma Quái: Bóng Tối', 2, 'OGC3', '2025-06-06 21:30:00', 600, N'Galaxy Nguyễn Du');
 GO


  --------------------   Danh sách khuyến mãi   --------------------
 INSERT INTO KHUYENMAI (MaKM, TenKM, MucGiam, NgayBatDau, NgayKetThuc, MoTa)
VALUES 
('KM01', N'Giảm giá hè', 10, '2025-06-01', '2025-06-30', N'Giảm 10% giá vé trong tháng 6'),
('KM02', N'Ưu đãi VIP', 20, '2025-06-05', '2025-06-20', N'Giảm 20% cho vé phòng VIP'),
('KM03', N'Thành viên mới', 15, '2025-06-10', '2025-07-10', N'Giảm 15% cho khách hàng mới');
 GO


   --------------------    Hóa đơn bán vé   --------------------
 INSERT INTO HD_VE ( IDNhanVien, IDKhachHang, NgayDat, TongTien)
VALUES 
(3, 1, '2025-06-01 10:00:00', 1800),
(3, 2, '2025-06-02 12:00:00', 2000),
(3, 3, '2025-06-03 14:00:00', 1700);
 GO


   --------------------   Chi tiết vé đã đặt     --------------------
 INSERT INTO VE (IDHoaDonVe, IDLichChieu, IDGhe, SoLuong, GiaVe, GioChieu, NgayMua)
VALUES 
(2, 1, 6, 3, 600, '2025-06-05 18:00:00', '2025-06-01 10:00:00'),
(3, 2, 3, 2, 1000, '2025-06-05 20:00:00', '2025-06-02 12:00:00'),
(4, 3, 5, 1, 1700, '2025-06-06 21:30:00', '2025-06-03 14:00:00');
 GO



 --------------------    Loại món ăn     --------------------
INSERT INTO LOAIMONAN(TenLoai)
VALUES 
(N'Thức ăn'),
(N'Nước uống');
GO

    --------------------   Danh sách món ăn     --------------------
INSERT INTO MONAN (TenMonAn, IDLoaiMonAn, Gia, MoTa, Anh)
VALUES 
(N'Bắp rang bơ', 1, 5000, N'Bắp rang bơ truyền thống', 'C:/CinemaManagement/OGC/Image/DichVu/bap.png'),
(N'Coca Cola', 2, 2000, N'Nước giải khát có ga', 'C:/CinemaManagement/OGC/Image/DichVu/cocacola.png'),
(N'Trà sữa', 2, 4000, N'Trà sữa trân châu đường đen', 'C:/CinemaManagement/OGC/Image/DichVu/trasua.png');
GO


    --------------------   Hóa đơn món ăn    --------------------
INSERT INTO HD_MONAN (IDNhanVien, IDKhachHang, NgayMua, TongTien)
VALUES 
(2, 1, '2025-06-01 15:00:00', 7000),
(2, 1, '2025-06-02 16:00:00', 6000);
GO


    --------------------   Chi tiết hóa đơn món ăn    --------------------
-- HD_MONAN.ID = 1 -> Tổng 100000
INSERT INTO CTHD_MONAN ( IDMonAn, IDHoaDon, Gia, SoLuong, NgayMua)
VALUES 
(1, 2, 5000, 1, '2025-06-01 15:00:00'), -- 50k
(2, 2, 2000, 1, '2025-06-01 15:00:00'); -- 50k

-- HD_MONAN.ID = 2 -> Tổng 60000
INSERT INTO CTHD_MONAN (IDMonAn, IDHoaDon, Gia, SoLuong, NgayMua)
VALUES 
(2, 3, 2000, 1, '2025-06-02 16:00:00'),  -- 40k
(3, 3, 4000, 1, '2025-06-02 16:00:00');     -- 20k (giá gốc 40k nhưng giảm giá để đủ 60k)
GO













--------------------------------- DANH SÁCH CÁC PROC ---------------------------------

	---------- TABLE CHUCVU ----------
CREATE PROCEDURE usp_themCHUCVU --Thêm chức vụ
    @TenChucVu NVARCHAR(100)
AS
BEGIN
        INSERT INTO CHUCVU (TenChucVu)
        VALUES (@TenChucVu)
END
GO

CREATE PROCEDURE usp_danhsachCHUCVU --Load danh sách chức vụ
AS
BEGIN
    SELECT ID, TenChucVu
    FROM CHUCVU
END
GO

CREATE PROCEDURE sp_LayTenChucVuTheoUsername --Lấy chức vụ theo tên tài khoản nhân viên
    @Username NVARCHAR(50)
AS
BEGIN
    SELECT cv.TenChucVu
    FROM NHANVIEN nv
    JOIN CHUCVU cv ON nv.IDChucVu = cv.ID
    WHERE nv.Username = @Username;
END
GO

CREATE PROCEDURE usp_XoaTenChucVu --Xóa tên chức vụ
    @TenChucVu NVARCHAR(100)
AS
BEGIN
    DELETE FROM CHUCVU
    WHERE TenChucVu = @TenChucVu;
END
GO

CREATE PROCEDURE usp_suaCHUCVU --sửa tên chức vụ
    @ID INT,
    @TenChucVuMoi NVARCHAR(50)
AS
BEGIN
        UPDATE CHUCVU
        SET TenChucVu = @TenChucVuMoi
        WHERE ID = @ID
END
GO


	---------- TABLE TKNHANVIEN ----------
CREATE PROCEDURE usp_layTKNHANVIEN_theoUsername --lấy tài khoản dựa trên Username trong bảng NHANVIEN
    @Username NVARCHAR(50)
AS
BEGIN
    SELECT * FROM NHANVIEN WHERE Username = @Username
END
GO


CREATE PROCEDURE usp_themTKNHANVIEN --Thêm tài khoản nhân viên
    @Username NVARCHAR(50),
    @Password VARBINARY(MAX)
AS
BEGIN
    INSERT INTO TKNHANVIEN (Username, Password)
    VALUES (@Username, @Password)
END 
GO

CREATE PROCEDURE usp_danhsachTKNHANVIEN -- Lấy danh sách tài khoản
AS
BEGIN
    SELECT Username, Password FROM TKNHANVIEN
END
GO

CREATE PROCEDURE usp_xoaTKNHANVIEN --Xóa tài khoản
    @Username NVARCHAR(50)
AS
BEGIN
    DELETE FROM TKNHANVIEN WHERE Username = @Username
END
GO

CREATE PROCEDURE usp_suaTKNHANVIEN --Sửa mật khẩu tài khoản
    @Username NVARCHAR(50),
    @Password VARBINARY(MAX)
AS
BEGIN
    UPDATE TKNHANVIEN
    SET Password = @Password
    WHERE Username = @Username
END
GO




---------- TABLE NHANVIEN ----------
CREATE PROCEDURE usp_themNHANVIEN --Thêm nhân viên
    @Username NVARCHAR(50),
    @IDChucVu INT,
    @HoTen NVARCHAR(100),
    @NgaySinh DATE = NULL,
    @GioiTinh NVARCHAR(10) = NULL,
    @SDT NVARCHAR(15) = NULL,
    @Email NVARCHAR(100) = NULL,
    @DiaChi NVARCHAR(200) = NULL
AS
BEGIN
    INSERT INTO NHANVIEN (Username, IDChucVu, HoTen, NgaySinh, GioiTinh, SDT, Email, DiaChi)
    VALUES (@Username , @IDChucVu , @HoTen , @NgaySinh , @GioiTinh , @SDT , @Email , @DiaChi )
END
GO

CREATE PROCEDURE usp_danhsachNHANVIEN --Lấy danh sách nhân viên
AS
BEGIN
    SELECT NV.ID, NV.Username, CV.TenChucVu, NV.HoTen, NV.NgaySinh, 
       NV.GioiTinh, NV.SDT, NV.Email, NV.DiaChi
	FROM NHANVIEN NV
	JOIN CHUCVU CV ON NV.IDChucVu = CV.ID
	JOIN TKNHANVIEN TK ON NV.Username = TK.Username
END
GO

CREATE PROCEDURE usp_xoaNHANVIEN --XÓA nhân viên
    @ID INT
AS
BEGIN
    DELETE FROM NHANVIEN
    WHERE ID = @ID;
END
GO

CREATE PROCEDURE usp_suaNHANVIEN --sửa thông tin nhân viên
    @Username NVARCHAR(50),
    @HoTen NVARCHAR(100),
    @NgaySinh DATE = NULL,
    @GioiTinh NVARCHAR(10) = NULL,
    @SDT NVARCHAR(15) = NULL,
    @Email NVARCHAR(100) = NULL,
    @DiaChi NVARCHAR(200) = NULL,
    @TenChucVu NVARCHAR(100),
	@AnhNV  NVARCHAR(200)
AS
BEGIN

    -- Kiểm tra xem TenChucVu có hợp lệ và lấy IDChucVu tương ứng
    DECLARE @IDChucVu INT;
    SELECT @IDChucVu = ID FROM CHUCVU WHERE TenChucVu = @TenChucVu;

    -- Cập nhật thông tin nhân viên
    UPDATE NHANVIEN
    SET 
        HoTen = @HoTen,
        NgaySinh = @NgaySinh,
        GioiTinh = @GioiTinh,
        SDT = @SDT,
        Email = @Email,
        DiaChi = @DiaChi,
        IDChucVu = @IDChucVu,
		AnhNV = @AnhNV
    WHERE Username = @Username;

END
GO



		-- TABLE THELOAIPHIM --
CREATE PROCEDURE usp_danhsachTHELOAIPHIM --lấy danh sách các thể loại phim
AS
BEGIN
    SELECT ID, TenTheLoai
    FROM THELOAIPHIM
END
GO

CREATE PROCEDURE usp_themTHELOAIPHIM --thêm thể loại phim vào hệ thống
    @TenTheLoai NVARCHAR(50)
AS
BEGIN
            INSERT INTO THELOAIPHIM (TenTheLoai)
            VALUES (@TenTheLoai)
END
GO

CREATE PROCEDURE usp_xoaTHELOAIPHIM --xóa thể loại phim ra khỏi hệ thống
    @TenTheLoai NVARCHAR(50)
AS
BEGIN
    DELETE FROM THELOAIPHIM
    WHERE TenTheLoai = @TenTheLoai
END
GO

CREATE PROCEDURE usp_suaTHELOAIPHIM --sửa thể loại phim
    @ID INT,
    @TenTheLoaiMoi NVARCHAR(50)
AS
BEGIN
        UPDATE THELOAIPHIM
        SET TenTheLoai = @TenTheLoaiMoi
        WHERE ID = @ID
END
GO



				-- TABLE LOAIMONAN --
CREATE PROCEDURE usp_danhsachLOAIMONAN --Lấy danh sách loại món ăn
AS
BEGIN
    SELECT ID, TenLoai
    FROM LOAIMONAN
END
GO

CREATE PROCEDURE usp_themLOAIMONAN --Thêm loại món ăn
    @TenLoai NVARCHAR(100)
AS
BEGIN
    BEGIN
        BEGIN
            INSERT INTO LOAIMONAN (TenLoai)
            VALUES (@TenLoai)
        END
    END
END
GO

CREATE PROCEDURE usp_xoaLOAIMONAN --Xóa loại món ăn
    @TenLoai NVARCHAR(100)
AS
BEGIN
    DELETE FROM LOAIMONAN WHERE TenLoai = @TenLoai
END
GO

CREATE PROCEDURE usp_suaLOAIMONAN --Cập nhật tên loại món ăn
    @ID INT,
    @TenLoaiMoi NVARCHAR(100)
AS
BEGIN
    BEGIN
        UPDATE LOAIMONAN
        SET TenLoai = @TenLoaiMoi
        WHERE ID = @ID
    END
END
GO


			--TABLE LOAIPHONG--
CREATE PROCEDURE usp_danhsachLOAIPHONG --Lấy danh sách loại phòng
AS
BEGIN
    SELECT ID, TenLoaiPhong
    FROM LOAIPHONG
END
GO

CREATE PROCEDURE usp_themLOAIPHONG --Thêm loại phòng
    @TenLoaiPhong NVARCHAR(20)
AS
BEGIN
     INSERT INTO LOAIPHONG (TenLoaiPhong)
     VALUES (@TenLoaiPhong)
END
GO

CREATE PROCEDURE usp_xoaLOAIPHONG --Xóa loại phòng
    @TenLoaiPhong NVARCHAR(20)
AS
BEGIN
    DELETE FROM LOAIPHONG WHERE TenLoaiPhong = @TenLoaiPhong
END
GO

CREATE PROCEDURE usp_suaLOAIPHONG --Cập nhật tên loại phòng
    @ID INT,
    @TenLoaiPhongMoi NVARCHAR(20)
AS
BEGIN
    BEGIN
        UPDATE LOAIPHONG
        SET TenLoaiPhong = @TenLoaiPhongMoi
        WHERE ID = @ID
    END
END
GO


		--TABLE DINHDANGPHIM --
CREATE PROCEDURE usp_danhsachDINHDANGPHIM --load danh sách các định dạng phim
	AS
	BEGIN
    		SELECT ID, TenDinhDang
    		FROM DINHDANGPHIM
	END
GO

CREATE PROCEDURE usp_themDINHDANGPHIM --thêm định dạng phim
    @TenDinhDang NVARCHAR(20)
AS
BEGIN
            INSERT INTO DINHDANGPHIM (TenDinhDang)
            VALUES (@TenDinhDang)
END
GO

CREATE PROCEDURE usp_xoaDINHDANGPHIM  --xóa định dạng phim
    @TenDinhDang NVARCHAR(20)
AS
BEGIN
    DELETE FROM DINHDANGPHIM WHERE TenDinhDang = @TenDinhDang
END
GO

CREATE PROCEDURE usp_suaDINHDANGPHIM --sửa định dạng phim
    @ID INT,
    @TenDinhDangMoi NVARCHAR(20)
AS
BEGIN
        UPDATE DINHDANGPHIM
        SET TenDinhDang = @TenDinhDangMoi
        WHERE ID = @ID
END
GO



			--TABLE LICHCHIEU --
CREATE PROCEDURE usp_danhsachLICHCHIEU --danh sách các lịch chiếu
AS
BEGIN
    SELECT
		lc.ID,
		lc.IDPhim,
		lc.IDPhong,
        p.TenPhim,
        pc.TenPhong,
		p.Anh,
		pc.AnhPhong,
        lc.NgayGio,
        lc.GiaVe,
        lc.DiaDiem
    FROM LICHCHIEU lc
    INNER JOIN PHIM p ON lc.IDPhim = p.ID
    INNER JOIN PHONGCHIEU pc ON lc.IDPhong = pc.ID
    ORDER BY lc.NgayGio;
END
GO


CREATE PROCEDURE usp_themLICHCHIEU --thêm lịch chiếu mới
    @TenPhim NVARCHAR(100),
    @TenPhong NVARCHAR(50),
    @NgayGio DATETIME,
    @GiaVe DECIMAL(6,0),
    @DiaDiem NVARCHAR(255)
AS
BEGIN
    DECLARE @IDPhim INT, @IDPhong INT

    SELECT @IDPhim = ID FROM PHIM WHERE TenPhim = @TenPhim
    SELECT @IDPhong = ID FROM PHONGCHIEU WHERE TenPhong = @TenPhong

    INSERT INTO LICHCHIEU (IDPhim, TenPhim, IDPhong, NgayGio, GiaVe, DiaDiem)
    VALUES (@IDPhim, @TenPhim, @IDPhong, @NgayGio, @GiaVe, @DiaDiem)
END
GO

CREATE PROCEDURE usp_suaLICHCHIEU --sửa thông tin lịch chiếu
    @ID INT,
    @TenPhim NVARCHAR(100),
    @TenPhong NVARCHAR(50),
    @NgayGio DATETIME,
    @GiaVe DECIMAL(6, 0),
    @DiaDiem NVARCHAR(255)
AS
BEGIN

    -- Tìm IDPhim và IDPhong từ tên
    DECLARE @IDPhim INT = (SELECT TOP 1 ID FROM PHIM WHERE TenPhim = @TenPhim);
    DECLARE @IDPhong INT = (SELECT TOP 1 ID FROM PHONGCHIEU WHERE TenPhong = @TenPhong);

    -- Cập nhật lịch chiếu
    UPDATE LICHCHIEU
    SET
        IDPhim = @IDPhim,
        TenPhim = @TenPhim,
        IDPhong = @IDPhong,
        NgayGio = @NgayGio,
        GiaVe = @GiaVe,
        DiaDiem = @DiaDiem
    WHERE ID = @ID;
END
GO

CREATE PROCEDURE usp_xoaLICHCHIEU --xóa lịch chiếu
    @ID INT
AS
BEGIN
    DELETE FROM LICHCHIEU WHERE ID = @ID
END
GO

------------PROC ĐẶT VÉ-----------------------
CREATE PROCEDURE usp_GetGioChieuTheoPhimNgayDinhDang
    @TenPhim NVARCHAR(100),
    @NgayChieu DATE,
    @TenDinhDang NVARCHAR(20)
AS
BEGIN
    SELECT 
        lc.ID AS IDLichChieu,
        p.TenPhim,
        CONVERT(DATE, lc.NgayGio) AS NgayChieu,
        CONVERT(TIME, lc.NgayGio) AS GioChieu,
        pc.TenPhong,
        ddp.TenDinhDang,
        lc.GiaVe,
        lc.DiaDiem
    FROM LICHCHIEU lc
    INNER JOIN PHIM p ON lc.IDPhim = p.ID
    INNER JOIN PHONGCHIEU pc ON lc.IDPhong = pc.ID
    INNER JOIN DINHDANGPHIM ddp ON p.IDDinhDang = ddp.ID
    WHERE 
        p.TenPhim = @TenPhim AND
        ddp.TenDinhDang = @TenDinhDang AND
        CAST(lc.NgayGio AS DATE) = @NgayChieu AND
        p.TrangThai = 1 AND pc.TrangThai = 1
    ORDER BY GioChieu
END
GO

--EXEC usp_GetGioChieuTheoPhimNgayDinhDang 
--    @TenPhim = N'Avengers: Endgame',
--    @NgayChieu = '2025-06-01',
--    @TenDinhDang = N'3D'

-----------Proc table KHO ----------
CREATE PROCEDURE usp_danhsachKHO --Lấy danh sách thông tin kho
AS
BEGIN
    SELECT *
    FROM KHO 
END
GO

CREATE PROCEDURE usp_ThemKHO -- thêm món mới vào kho
    @IDMonAn NVARCHAR(100),
	@TenMonAn NVARCHAR(50),
    @SoLuongTon INT,
	@NgayCapNhat DATETIME
AS
BEGIN
    SELECT @IDMonAn = ID FROM MONAN WHERE TenMonAn = @TenMonAn

    IF @IDMonAn IS NULL
    BEGIN
        RAISERROR(N'Món ăn không tồn tại.', 16, 1)
        RETURN
    END

    IF EXISTS (SELECT 1 FROM KHO WHERE IDMonAn = @IDMonAn)
    BEGIN
        RAISERROR(N'Món ăn đã có trong kho.', 16, 1)
        RETURN
    END

    INSERT INTO KHO (IDMonAn, TenMonAn, SoLuongTon, NgayCapNhat)
    VALUES (@IDMonAn, @TenMonAn, @SoLuongTon, @NgayCapNhat)
END
GO

CREATE PROCEDURE sp_SuaKHO --sửa thông tin kho
    @TenMonAn NVARCHAR(100),
    @SoLuongThem INT -- số lượng nhập thêm vào, chứ không phải ghi đè
AS
BEGIN
    DECLARE @IDMonAn INT
    SELECT @IDMonAn = ID FROM MONAN WHERE TenMonAn = @TenMonAn

    IF @IDMonAn IS NULL
    BEGIN
        RAISERROR(N'Món ăn không tồn tại.', 16, 1)
        RETURN
    END

    IF NOT EXISTS (SELECT 1 FROM KHO WHERE IDMonAn = @IDMonAn)
    BEGIN
        RAISERROR(N'Món ăn chưa có trong kho.', 16, 1)
        RETURN
    END

    UPDATE KHO
    SET  SoLuongTon = SoLuongTon + @SoLuongThem, -- Cộng thêm số lượng mới nhập
	     NgayCapNhat = GETDATE() -- Cập nhật ngày hiện tại
    WHERE IDMonAn = @IDMonAn
END
GO

CREATE PROCEDURE sp_XoaKHO --xóa tên món ăn khỏi kho
    @TenMonAn NVARCHAR(100)
AS
BEGIN
    DECLARE @IDMonAn INT
    SELECT @IDMonAn = ID FROM MONAN WHERE TenMonAn = @TenMonAn

    IF @IDMonAn IS NULL
    BEGIN
        RAISERROR(N'Món ăn không tồn tại.', 16, 1)
        RETURN
    END

    IF NOT EXISTS (SELECT 1 FROM KHO WHERE IDMonAn = @IDMonAn)
    BEGIN
        RAISERROR(N'Món ăn chưa có trong kho.', 16, 1)
        RETURN
    END

    DELETE FROM KHO
    WHERE IDMonAn = @IDMonAn
END
GO




					---------------CÁC PROC THỐNG KÊ-----------------

CREATE PROCEDURE usp_NhanVienNoiTroiNhatThang --Proc trả về nhân viên bán vé nổi trội nhất trong tháng
AS
BEGIN
	SELECT nv.HoTen FROM HD_VE hd JOIN NHANVIEN nv ON hd.IDNhanVien = nv.ID WHERE MONTH(hd.NgayDat) = MONTH(GETDATE())  AND YEAR(hd.NgayDat) = YEAR(GETDATE())
	GROUP BY nv.HoTen
	HAVING COUNT(*) = (
		SELECT MAX(SoLuong)
		FROM (
			SELECT COUNT(*) AS SoLuong
			FROM HD_VE
			WHERE MONTH(NgayDat) = MONTH(GETDATE()) 
			AND YEAR(NgayDat) = YEAR(GETDATE())
			GROUP BY IDNhanVien
		) AS Sub
	)
END
GO


CREATE PROCEDURE usp_NhanVienDichVuNoiTroiNhatThang --Proc trả về nhân viên dịch vụ nổi trội nhất trong tháng
AS
BEGIN
SELECT nv.HoTen FROM HD_MONAN hd JOIN NHANVIEN nv ON hd.IDNhanVien = nv.ID WHERE MONTH(hd.NgayMua) = MONTH(GETDATE())  AND YEAR(hd.NgayMua) = YEAR(GETDATE())
	GROUP BY nv.HoTen
	HAVING COUNT(*) = (
		SELECT MAX(SoLuong)
		FROM (
			SELECT COUNT(*) AS SoLuong
			FROM HD_MONAN
			WHERE MONTH(NgayMua) = MONTH(GETDATE()) 
			AND YEAR(NgayMua) = YEAR(GETDATE())
			GROUP BY IDNhanVien
		) AS Sub
	)
END
GO

CREATE PROCEDURE usp_PhimChieuNhieuNhat --Phim được chiếu nhiều nhất trong tháng hiện tại
AS
BEGIN
	SELECT TOP 1 IDPhim, TenPhim, COUNT(*) AS SoSuatChieu
	FROM LICHCHIEU 
	WHERE MONTH(NgayGio) = MONTH(GETDATE()) 
				AND YEAR(NgayGio) = YEAR(GETDATE())
	GROUP BY IDPhim, TenPhim
	ORDER BY SoSuatChieu DESC
END
GO

CREATE PROCEDURE usp_PhimChieuItNhat --Phim được chiếu ít nhất trong tháng hiện tại
AS
BEGIN
	SELECT TOP 1 IDPhim, TenPhim, COUNT(*) AS SoSuatChieu
	FROM LICHCHIEU 
	WHERE MONTH(NgayGio) = MONTH(GETDATE()) 
				AND YEAR(NgayGio) = YEAR(GETDATE())
	GROUP BY IDPhim, TenPhim
	ORDER BY SoSuatChieu ASC
END
GO

CREATE PROCEDURE usp_PhimDoanhThuCaoNhatThang --Phim có doanh thu cao nhất tháng hiện tại
AS
BEGIN
	SELECT TOP 1 
		p.ID AS IDPhim, 
		p.TenPhim, 
		SUM(v.GiaVe) AS DoanhThuPhim
	FROM VE v
	JOIN LICHCHIEU lc ON v.IDLichChieu = lc.ID
	JOIN PHIM p ON lc.IDPhim = p.ID
	WHERE MONTH(v.NgayMua) = MONTH(GETDATE()) 
	  AND YEAR(v.NgayMua) = YEAR(GETDATE())
	GROUP BY p.ID, p.TenPhim
	ORDER BY DoanhThuPhim DESC
END
GO



CREATE PROCEDURE usp_TinhTongDoanhThu --tính tổng doanh thu (HD_VE.TongTien + HD_MON.TongTien)
    @Ngay INT = NULL,
    @Thang INT = NULL,
    @Nam INT = NULL
AS
BEGIN
	DECLARE @DoanhThuVe DECIMAL(18,2);
    DECLARE @DoanhThuDichVu DECIMAL(18,2);

	--trả về doanh thu vé
    SELECT 
        @DoanhThuVe = ISNULL(SUM(hd_ve.TongTien), 0)
    FROM HD_VE hd_ve
    WHERE 
        (@Ngay IS NULL OR DAY(NgayDat) = @Ngay)
        AND (@Thang IS NULL OR MONTH(NgayDat) = @Thang)
        AND (@Nam IS NULL OR YEAR(NgayDat) = @Nam);

	--trả về doanh thu dịch vu
    SELECT 
        @DoanhThuDichVu = ISNULL(SUM(hd_mon.TongTien), 0)
    FROM HD_MONAN hd_mon
    WHERE 
        (@Ngay IS NULL OR DAY(NgayMua) = @Ngay)
        AND (@Thang IS NULL OR MONTH(NgayMua) = @Thang)
        AND (@Nam IS NULL OR YEAR(NgayMua) = @Nam);

    SELECT (@DoanhThuVe + @DoanhThuDichVu) AS TongDoanhThu;
END
GO

CREATE PROCEDURE usp_DoanhThuTheoTungNhanVien --Doanh thu theo từng nhân viên
AS
BEGIN
	SELECT nv.HoTen, nv.Username, cv.TenChucVu, nv.SDT,
       SUM(ISNULL(hv.TongTien, 0) + ISNULL(hm.TongTien, 0)) AS TongTien
	FROM NHANVIEN nv
	JOIN CHUCVU cv ON nv.IDChucVu = cv.ID
	LEFT JOIN HD_VE hv ON hv.IDNhanVien = nv.ID 
		AND cv.TenChucVu = N'Nhân viên bán vé'
		AND MONTH(hv.NgayDat) = MONTH(GETDATE())
		AND YEAR(hv.NgayDat) = YEAR(GETDATE())
	LEFT JOIN HD_MONAN hm ON hm.IDNhanVien = nv.ID 
		AND cv.TenChucVu = N'Nhân viên dịch vụ'
		AND MONTH(hm.NgayMua) = MONTH(GETDATE())
		AND YEAR(hm.NgayMua) = YEAR(GETDATE())
	WHERE ( cv.TenChucVu IN (N'Nhân viên bán vé', N'Nhân viên dịch vụ') )
	GROUP BY nv.HoTen, nv.Username, cv.TenChucVu, nv.SDT
END
GO



CREATE PROCEDURE usp_DoanhThuTheoTungPhim -- doanh thu theo từng phim
AS
BEGIN
	SELECT 
    p.TenPhim,

		-- Đếm số suất chiếu (LICHCHIEU) trong tháng hiện tại
		COUNT(DISTINCT lc.ID) AS SoSuatChieu_TrongThang,

		-- Đếm số suất chiếu (LICHCHIEU) trong năm hiện tại
		COUNT(DISTINCT CASE WHEN YEAR(hv.NgayDat) = YEAR(GETDATE()) THEN lc.ID END) AS SoSuatChieu_TrongNam,

		-- Doanh thu trong tháng hiện tại
		SUM(CASE 
			WHEN MONTH(hv.NgayDat) = MONTH(GETDATE()) AND YEAR(hv.NgayDat) = YEAR(GETDATE()) 
			THEN ve.GiaVe * ve.SoLuong 
			ELSE 0 
		END) AS DoanhThu_TrongThang,

		-- Doanh thu trong năm hiện tại
		SUM(CASE 
			WHEN YEAR(hv.NgayDat) = YEAR(GETDATE()) 
			THEN ve.GiaVe * ve.SoLuong 
			ELSE 0 
		END) AS DoanhThu_TrongNam,

		-- Tỷ lệ phần trăm doanh thu phim này trong tổng doanh thu tháng hiện tại
		CAST(
			100.0 * SUM(CASE 
				WHEN MONTH(hv.NgayDat) = MONTH(GETDATE()) AND YEAR(hv.NgayDat) = YEAR(GETDATE()) 
				THEN ve.GiaVe * ve.SoLuong 
				ELSE 0 
			END) 
			/ NULLIF((
				SELECT SUM(ve2.GiaVe * ve2.SoLuong)
				FROM VE ve2
				JOIN HD_VE hv2 ON ve2.IDHoaDonVe = hv2.ID
				WHERE MONTH(hv2.NgayDat) = MONTH(GETDATE()) AND YEAR(hv2.NgayDat) = YEAR(GETDATE())
			), 0)
		AS DECIMAL(5,2)) AS PhanTram_DoanhThu_Thang

	FROM PHIM p
	JOIN LICHCHIEU lc ON p.ID = lc.IDPhim
	JOIN VE ve ON ve.IDLichChieu = lc.ID
	JOIN HD_VE hv ON hv.ID = ve.IDHoaDonVe

	-- Chỉ tính các vé trong tháng và năm hiện tại
	WHERE MONTH(hv.NgayDat) = MONTH(GETDATE())  
	  AND YEAR(hv.NgayDat) = YEAR(GETDATE())

	GROUP BY p.TenPhim
	ORDER BY DoanhThu_TrongThang DESC;
END
GO

CREATE PROCEDURE usp_GetNgayChieuTheoPhim
    @TenPhim NVARCHAR(100)
AS
BEGIN
    SELECT DISTINCT LC.NgayGio
    FROM LICHCHIEU LC
    INNER JOIN PHIM P ON LC.IDPhim = P.ID
    WHERE P.TenPhim = @TenPhim
    ORDER BY LC.NgayGio
END
GO

CREATE PROCEDURE usp_GetGioChieuTheoPhimVaNgay
    @TenPhim NVARCHAR(100),
    @NgayGio DATE
AS
BEGIN
    SELECT LC.ID, LC.NgayGio, LC.IDPhong
    FROM LICHCHIEU LC
    INNER JOIN PHIM P ON LC.IDPhim = P.ID
    WHERE P.TenPhim = @TenPhim AND CAST(LC.NgayGio AS DATE) = @NgayGio
    ORDER BY LC.NgayGio
END
GO

CREATE PROCEDURE usp_GetDinhDangPhimTheoTenPhim
    @TenPhim NVARCHAR(100)
AS
BEGIN
    SELECT DDP.ID, DDP.TenDinhDang
    FROM PHIM P
    INNER JOIN DINHDANGPHIM DDP ON P.IDDinhDang = DDP.ID
    WHERE P.TenPhim = @TenPhim
END;
GO


CREATE PROCEDURE usp_DoanhThuTheoTungSuatChieu -- doanh thu theo từng suất chiếu
AS
BEGIN
	SELECT 
		lc.ID AS IDSuatChieu,
		p.TenPhim,
		lc.NgayGio,
		SUM(v.SoLuong) AS TongSoVe,
		SUM(v.GiaVe * v.SoLuong) AS DoanhThu
	FROM VE v
		INNER JOIN LICHCHIEU lc ON v.IDLichChieu = lc.ID
		INNER JOIN PHIM p ON lc.IDPhim = p.ID
		INNER JOIN HD_VE hv ON v.IDHoaDonVe = hv.ID
	WHERE MONTH(hv.NgayDat) = MONTH(GETDATE())
		AND YEAR(hv.NgayDat) = YEAR(GETDATE())
	GROUP BY lc.ID, p.TenPhim, lc.NgayGio
	ORDER BY lc.NgayGio;
END
GO


CREATE PROCEDURE usp_TinhTongSoVe --tính tổng số vé theo ngày, tháng hoặc năm
    @Ngay INT = NULL,
    @Thang INT = NULL,
    @Nam INT = NULL
AS
BEGIN
	DECLARE @TongSoVe INT;

	--trả về doanh thu vé
    SELECT 
        @TongSoVe = ISNULL(SUM(ve.SoLuong), 0)
    FROM VE ve
    WHERE 
        (@Ngay IS NULL OR DAY(NgayMua) = @Ngay)
        AND (@Thang IS NULL OR MONTH(NgayMua ) = @Thang)
        AND (@Nam IS NULL OR YEAR(NgayMua ) = @Nam);
	SELECT @TongSoVe AS N'Tổng số vé'
END
GO

CREATE PROCEDURE usp_SoVeDaBanTheoPhim -- số vé đã bán theo từng phim
AS
BEGIN
	SELECT 
		p.ID,
		p.TenPhim,
		SUM(v.SoLuong) AS SoVeDaBan
	FROM VE v
	JOIN LICHCHIEU lc ON v.IDLichChieu = lc.ID
	JOIN PHIM p ON lc.IDPhim = p.ID
	GROUP BY p.ID, p.TenPhim;
END
GO

CREATE PROCEDURE usp_SoVeDaBanTheoSuatChieu -- số vé đã bán theo từng phim
AS
BEGIN
	SELECT 
		lc.ID,
		FORMAT(lc.NgayGio, 'dd/MM/yyyy HH:mm') AS N'Ngày Giờ' ,
		SUM(v.SoLuong) AS SoVeDaBan
	FROM VE v
	JOIN LICHCHIEU lc ON v.IDLichChieu = lc.ID
	GROUP BY lc.ID, FORMAT(lc.NgayGio, 'dd/MM/yyyy HH:mm')
END
GO

CREATE PROCEDURE usp_SoVeDaBanTheoLoaiPhong -- số vé đã bán theo từng phim
AS
BEGIN
	SELECT 
		lp.TenLoaiPhong,
		SUM(v.SoLuong) AS SoVeDaBan
	FROM VE v
	JOIN LICHCHIEU lc ON v.IDLichChieu = lc.ID
	JOIN PHONGCHIEU pc ON lc.IDPhong = pc.ID
	JOIN LOAIPHONG lp ON lp.ID = pc.MaLoaiPhong
	GROUP BY lp.TenLoaiPhong;
END
GO
---------------------------------
CREATE PROCEDURE usp_KhachHangTheoTungKhuVuc --Danh sách khách hàng theo từng khu vực
AS
BEGIN
	SELECT DiaChi, COUNT(*) AS SoLuongKhach
    FROM KhachHang
    GROUP BY DiaChi
END
GO

CREATE PROCEDURE usp_DanhSachKhachHangChuaTungDatVe --Danh sách khách hàng chưa từng đặt vé
AS
BEGIN
	SELECT * FROM KhachHang
    WHERE ID NOT IN (
         SELECT DISTINCT IDKhachHang
          FROM HD_VE
           WHERE IDKhachHang IS NOT NULL)
END
GO

CREATE PROCEDURE usp_DanhSachKhachHangCoDiemThuongCaoNhat --Danh sách khách hàng có điểm thưởng cao nhất
AS
BEGIN
	SELECT TOP 10 *
    FROM KhachHang
    ORDER BY DiemThuong DESC
END
GO

CREATE PROCEDURE usp_DanhSachKhachHangDatVeNhieuNhat --Danh sách khách hàng đặt vé nhiều nhất
	@Ngay INT,
    @Thang INT,
    @Nam INT
AS
BEGIN
	SELECT kh.ID, kh.HoTen, COUNT(*) AS SoLuotDatVe
    FROM HD_VE hd
    JOIN KhachHang kh ON hd.IDKhachHang = kh.ID
    WHERE DAY(hd.NgayDat) = @Ngay AND MONTH(hd.NgayDat) = @Thang AND YEAR(hd.NgayDat) = @Nam
    GROUP BY kh.ID, kh.HoTen
    ORDER BY SoLuotDatVe DESC
END
GO

CREATE PROCEDURE usp_ThongKeKhachHangDaMua --Số khách hàng đã sử dụng dịch vụ (mua vé, dịch vụ) trong ngày, tháng, năm
    @Ngay INT = NULL,
    @Thang INT = NULL,
    @Nam INT = NULL
AS
BEGIN
    DECLARE @SoKhachHang INT;

    SELECT @SoKhachHang = COUNT(DISTINCT kh.ID)
    FROM (
        -- Khách mua vé
        SELECT ISNULL(ve.IDKhachHang, 0) AS ID
        FROM HD_VE ve
        WHERE 
            (@Ngay IS NULL OR DAY(ve.NgayDat) = @Ngay)
            AND (@Thang IS NULL OR MONTH(ve.NgayDat) = @Thang)
            AND (@Nam IS NULL OR YEAR(ve.NgayDat) = @Nam)

        UNION

        -- Khách mua dịch vụ
        SELECT ISNULL(dv.IDKhachHang, 0) AS ID
        FROM HD_MONAN dv
        WHERE 
            (@Ngay IS NULL OR DAY(dv.NgayMua) = @Ngay)
            AND (@Thang IS NULL OR MONTH(dv.NgayMua) = @Thang)
            AND (@Nam IS NULL OR YEAR(dv.NgayMua) = @Nam)
    ) kh;

    SELECT @SoKhachHang AS N'Số khách hàng đã mua';
END
GO
-----------------------

CREATE PROCEDURE usp_ThongKePhim --danh sách phim đang chiếu, lọc theo ngày, tháng, năm
    @Ngay INT = NULL,
    @Thang INT = NULL,
    @Nam INT = NULL
AS
BEGIN
	SELECT DISTINCT p.ID, p.TenPhim 
	FROM PHIM p
	JOIN LICHCHIEU lc ON p.ID = lc.IDPhim
	WHERE (@Ngay IS NULL OR DAY(lc.NgayGio) = @Ngay)
		AND (@Thang IS NULL OR MONTH(lc.NgayGio) = @Thang)
		AND (@Nam IS NULL OR YEAR(lc.NgayGio) = @Nam);
END
GO

CREATE PROCEDURE usp_PhimDoanhThuCaoNhat --Top 5 Phim có doanh thu cao nhất
    @Ngay INT = NULL,
    @Thang INT = NULL,
    @Nam INT = NULL
AS
BEGIN
	SELECT TOP 5 p.ID, p.TenPhim, SUM(hd.TongTien) AS DoanhThu
    FROM PHIM p
    JOIN LICHCHIEU lc ON p.ID = lc.IDPhim
    JOIN VE v ON lc.ID = v.IDLichChieu
    JOIN HD_VE hd ON v.IDHoaDonVe = hd.ID
	WHERE (@Ngay IS NULL OR DAY(lc.NgayGio) = @Ngay)
		AND (@Thang IS NULL OR MONTH(lc.NgayGio) = @Thang)
		AND (@Nam IS NULL OR YEAR(lc.NgayGio) = @Nam)
    GROUP BY p.ID, p.TenPhim
    ORDER BY DoanhThu DESC;
END
GO

CREATE PROCEDURE PhimDoanhThuThapNhat --Top 5 Phim có doanh thu thấp nhất
    @Ngay INT = NULL,
    @Thang INT = NULL,
    @Nam INT = NULL
AS
BEGIN
	SELECT TOP 5 p.ID, p.TenPhim, SUM(hd.TongTien) AS DoanhThu
                                FROM PHIM p
                                JOIN LICHCHIEU lc ON p.ID = lc.IDPhim
                                JOIN VE v ON lc.ID = v.IDLichChieu
                                JOIN HD_VE hd ON v.IDHoaDonVe = hd.ID
								WHERE (@Ngay IS NULL OR DAY(lc.NgayGio) = @Ngay)
		AND (@Thang IS NULL OR MONTH(lc.NgayGio) = @Thang)
		AND (@Nam IS NULL OR YEAR(lc.NgayGio) = @Nam)
                                GROUP BY p.ID, p.TenPhim

                                ORDER BY DoanhThu ASC;
END
GO

CREATE PROCEDURE usp_PhimDuocDatVeNhieuNhat --Top 5 Phim được đặt vé nhiều nhất
    @Ngay INT = NULL,
    @Thang INT = NULL,
    @Nam INT = NULL
AS
BEGIN
	SELECT TOP 5 p.ID, p.TenPhim, SUM(v.SoLuong) AS SoVe
                                FROM PHIM p
                                JOIN LICHCHIEU lc ON p.ID = lc.IDPhim
                                JOIN VE v ON lc.ID = v.IDLichChieu
								WHERE (@Ngay IS NULL OR DAY(lc.NgayGio) = @Ngay)
		AND (@Thang IS NULL OR MONTH(lc.NgayGio) = @Thang)
		AND (@Nam IS NULL OR YEAR(lc.NgayGio) = @Nam)
                                GROUP BY p.ID, p.TenPhim
                                ORDER BY SoVe DESC;
END
GO


-----------------------------

CREATE PROCEDURE usp_DanhSachNhanVienMoi --danh sách nhân viên mới
    @Thang INT = NULL,
    @Nam INT = NULL
AS
BEGIN
    SELECT * 
    FROM NHANVIEN
    WHERE 
        (@Thang IS NULL OR MONTH(NgayVao) = @Thang)
        AND (@Nam IS NULL OR YEAR(NgayVao) = @Nam)
END
GO


CREATE PROCEDURE usp_SoLuongHoaDonVe_TheoNhanVien --só lượng hóa đơn vé của từng nhân viên
AS
BEGIN
    SELECT nv.ID, nv.HoTen, nv.Username, cv.TenChucVu , COUNT(hd.ID) AS SoHoaDonVe
    FROM NHANVIEN nv
	LEFT JOIN CHUCVU cv ON nv.IDChucVu = cv.ID
    LEFT JOIN HD_VE hd ON nv.ID = hd.IDNhanVien
	WHERE cv.TenChucVu = N'Nhân viên bán vé'

    GROUP BY nv.ID, nv.HoTen,  nv.Username, cv.TenChucVu 
	ORDER BY  COUNT(hd.ID) DESC
END
GO



CREATE PROCEDURE usp_NhanVien_DoanhThuCaoNhat --danh sách nhân viên mang lại doanh thu cao nhất
AS
BEGIN
		SELECT TOP 5 
		nv.ID, 
		nv.HoTen, 
		cv.TenChucVu,
		(ISNULL(ve.TongTienVe, 0) + ISNULL(dv.TongTienDichVu, 0)) AS TongDoanhThu
	FROM NHANVIEN nv
	JOIN CHUCVU cv ON nv.IDChucVu = cv.ID 
	LEFT JOIN (
		SELECT 
			IDNhanVien, 
			SUM(TongTien) AS TongTienVe
		FROM HD_VE
		GROUP BY IDNhanVien
	) ve ON nv.ID = ve.IDNhanVien
	LEFT JOIN (
		SELECT 
			IDNhanVien,
			SUM(TongTien) AS TongTienDichVu
		FROM HD_MONAN
		GROUP BY IDNhanVien
	) dv ON nv.ID = dv.IDNhanVien

	ORDER BY TongDoanhThu DESC
END
GO


CREATE PROCEDURE usp_SoLuongHoaDonMonAn_TheoNhanVien --số hóa đơn món ăn mà nhân viên dịch vụ đã lập
AS
BEGIN
    SELECT nv.ID, nv.HoTen, nv.Username, cv.TenChucVu , COUNT(hd.ID) AS SoHoaDonMonAn
    FROM NHANVIEN nv
	LEFT JOIN CHUCVU cv ON nv.IDChucVu = cv.ID
    LEFT JOIN HD_MONAN hd ON nv.ID = hd.IDNhanVien
	WHERE cv.TenChucVu = N'Nhân viên dịch vụ'

    GROUP BY nv.ID, nv.HoTen, nv.Username, cv.TenChucVu 
END
GO



CREATE PROCEDURE usp_ThongKeSoLuongVeDat_MoiPhong --thống kê số lượng vé đặt của mỗi phòng
    @Ngay INT = NULL,
    @Thang INT = NULL,
    @Nam INT = NULL
AS
BEGIN
    SELECT 
        pc.ID AS IDPhong,
        pc.TenPhong,
        COUNT(ve.ID) AS SoLuongVeDaDat
    FROM PHONGCHIEU pc
    JOIN GHE g ON pc.ID = g.IDPhong
    JOIN VE ve ON ve.IDGhe = g.ID
    WHERE 
        (@Ngay IS NULL OR DAY(ve.NgayMua) = @Ngay) AND
        (@Thang IS NULL OR MONTH(ve.NgayMua) = @Thang) AND
        (@Nam IS NULL OR YEAR(ve.NgayMua) = @Nam)
    GROUP BY pc.ID, pc.TenPhong
    ORDER BY pc.ID
END
GO


CREATE PROCEDURE usp_ThongKeSoLuongSuatChieu_MoiPhong -- thống kê số lượng suất chiếu của mỗi phòng
    @Ngay INT = NULL,
    @Thang INT = NULL,
    @Nam INT = NULL
AS
BEGIN
    SELECT 
        pc.ID AS IDPhong,
        pc.TenPhong,
        COUNT(lc.ID) AS SoLuongSuatChieu
    FROM PHONGCHIEU pc
    LEFT JOIN LICHCHIEU lc ON pc.ID = lc.IDPhong
    WHERE 
        (@Ngay IS NULL OR DAY(lc.NgayGio) = @Ngay) AND
        (@Thang IS NULL OR MONTH(lc.NgayGio) = @Thang) AND
        (@Nam IS NULL OR YEAR(lc.NgayGio) = @Nam)
    GROUP BY pc.ID, pc.TenPhong
    ORDER BY pc.ID
END
GO


CREATE PROCEDURE usp_ThongKeTiLePhongSuDung --thống kê tỷ lệ phòng được sử dụng (có ít nhất 1 suất chiếu) trong khoảng thời gian
    @Ngay INT = NULL,
    @Thang INT = NULL,
    @Nam INT = NULL
AS
BEGIN
   -- Tổng số suất chiếu trong khoảng thời gian
    DECLARE @TongSoSuatChieu INT = (
        SELECT COUNT(*) 
        FROM LICHCHIEU lc
        JOIN PHONGCHIEU pc ON pc.ID = lc.IDPhong
        WHERE pc.TrangThai = 1
            AND (@Ngay IS NULL OR DAY(lc.NgayGio) = @Ngay)
            AND (@Thang IS NULL OR MONTH(lc.NgayGio) = @Thang)
            AND (@Nam IS NULL OR YEAR(lc.NgayGio) = @Nam)
    );

    -- Trả về ID, TenPhong, và tỷ lệ sử dụng của từng phòng
    SELECT 
        pc.ID AS IDPhong,
        pc.TenPhong,
        COUNT(lc.ID) AS SoSuatChieu,
        CAST(COUNT(lc.ID) * 100.0 / NULLIF(@TongSoSuatChieu, 0) AS DECIMAL(5,2)) AS TiLeSuDung_PhanTram
    FROM PHONGCHIEU pc
    LEFT JOIN LICHCHIEU lc ON lc.IDPhong = pc.ID
        AND (@Ngay IS NULL OR DAY(lc.NgayGio) = @Ngay)
        AND (@Thang IS NULL OR MONTH(lc.NgayGio) = @Thang)
        AND (@Nam IS NULL OR YEAR(lc.NgayGio) = @Nam)
    WHERE pc.TrangThai = 1
    GROUP BY pc.ID, pc.TenPhong
    ORDER BY TiLeSuDung_PhanTram DESC
END
GO


CREATE PROCEDURE usp_ThongKeSoLuongKhach_MoiLichChieu --Thống kê số lượng khách mỗi lịch chiếu
    @Ngay INT = NULL,
    @Thang INT = NULL,
    @Nam INT = NULL
AS
BEGIN
    SELECT 
        lc.ID AS IDLichChieu,
        lc.NgayGio,
        COUNT(v.ID) AS SoLuongKhach
    FROM LICHCHIEU lc
    LEFT JOIN VE v ON lc.ID = v.IDLichChieu
    WHERE 
        (@Ngay IS NULL OR DAY(lc.NgayGio) = @Ngay) AND
        (@Thang IS NULL OR MONTH(lc.NgayGio) = @Thang) AND
        (@Nam IS NULL OR YEAR(lc.NgayGio) = @Nam)
    GROUP BY lc.ID, lc.NgayGio
    ORDER BY lc.NgayGio
END
GO


CREATE PROCEDURE usp_ThongKeLichChieu_VangKhach --Thống kê danh sách lịch chiếu vắng khách 
    @Ngay INT = NULL,
    @Thang INT = NULL,
    @Nam INT = NULL
AS
BEGIN
    SELECT 
        lc.ID AS IDLichChieu,
        lc.NgayGio,
        COUNT(v.ID) AS SoLuongKhach
    FROM LICHCHIEU lc
    LEFT JOIN VE v ON lc.ID = v.IDLichChieu
    WHERE 
        (@Ngay IS NULL OR DAY(lc.NgayGio) = @Ngay) AND
        (@Thang IS NULL OR MONTH(lc.NgayGio) = @Thang) AND
        (@Nam IS NULL OR YEAR(lc.NgayGio) = @Nam)
    GROUP BY lc.ID, lc.NgayGio
    ORDER BY SoLuongKhach ASC
END
GO


CREATE PROCEDURE usp_ThongKeLichChieu_DongKhach --Thống kê danh sách lịch chiếu đông khách
    @Ngay INT = NULL,
    @Thang INT = NULL,
    @Nam INT = NULL
AS
BEGIN
    SELECT 
        lc.ID AS IDLichChieu,
        lc.NgayGio,
        COUNT(v.ID) AS SoLuongKhach
    FROM LICHCHIEU lc
    LEFT JOIN VE v ON lc.ID = v.IDLichChieu
    WHERE 
        (@Ngay IS NULL OR DAY(lc.NgayGio) = @Ngay) AND
        (@Thang IS NULL OR MONTH(lc.NgayGio) = @Thang) AND
        (@Nam IS NULL OR YEAR(lc.NgayGio) = @Nam)
    GROUP BY lc.ID, lc.NgayGio
    ORDER BY SoLuongKhach DESC
END
GO


CREATE PROCEDURE usp_ThongKeSoLuongPhim_MoiLichChieu --Thống kê số lượng phim có trong các lịch chiếu trong ngày đó
    @Ngay INT = NULL,
    @Thang INT = NULL,
    @Nam INT = NULL
AS
BEGIN
    SELECT 
        lc.NgayGio,
        COUNT(DISTINCT lc.IDPhim) AS SoLuongPhim
    FROM LICHCHIEU lc
    WHERE 
        (@Ngay IS NULL OR DAY(lc.NgayGio) = @Ngay) AND
        (@Thang IS NULL OR MONTH(lc.NgayGio) = @Thang) AND
        (@Nam IS NULL OR YEAR(lc.NgayGio) = @Nam)
    GROUP BY lc.NgayGio
    ORDER BY lc.NgayGio
END
GO


CREATE PROCEDURE usp_ThongKeSoLuongDichVu --Thống kê số lượng dịch vụ đã bán
    @Ngay INT = NULL,
    @Thang INT = NULL,
    @Nam INT = NULL
AS
BEGIN
    SELECT 
        ma.ID,
        ma.TenMonAn,
        SUM(ct.SoLuong) AS SoLuongDaBan
    FROM CTHD_MONAN ct
    JOIN MONAN ma ON ct.IDMonAn = ma.ID
    JOIN HD_MONAN hd ON ct.IDHoaDon = hd.ID
    WHERE 
        (@Ngay IS NULL OR DAY(hd.NgayMua) = @Ngay) AND
        (@Thang IS NULL OR MONTH(hd.NgayMua) = @Thang) AND
        (@Nam IS NULL OR YEAR(hd.NgayMua) = @Nam)
    GROUP BY ma.ID, ma.TenMonAn
    ORDER BY SoLuongDaBan DESC
END
GO

CREATE PROCEDURE usp_ThongKeDoanhThuDichVu -- Thống kê doanh thu theo từng dịch vụ
    @Ngay INT = NULL,
    @Thang INT = NULL,
    @Nam INT = NULL
AS
BEGIN
    SELECT 
        ma.ID,
        ma.TenMonAn,
        SUM(ct.SoLuong * ct.Gia) AS DoanhThu
    FROM CTHD_MONAN ct
    JOIN MONAN ma ON ct.IDMonAn = ma.ID
    JOIN HD_MONAN hd ON ct.IDHoaDon = hd.ID
    WHERE 
        (@Ngay IS NULL OR DAY(hd.NgayMua) = @Ngay) AND
        (@Thang IS NULL OR MONTH(hd.NgayMua) = @Thang) AND
        (@Nam IS NULL OR YEAR(hd.NgayMua) = @Nam)
    GROUP BY ma.ID, ma.TenMonAn
    ORDER BY DoanhThu DESC
END
GO

CREATE PROCEDURE usp_ThongKeDoanhThuTheoLoai --Thống kê doanh thu theo loại dịch vụ
    @Ngay INT = NULL,
    @Thang INT = NULL,
    @Nam INT = NULL
AS
BEGIN
    SELECT 
        lma.ID AS IDLoai,
        lma.TenLoai,
        SUM(ct.SoLuong * ct.Gia) AS DoanhThu
    FROM CTHD_MONAN ct
    JOIN MONAN ma ON ct.IDMonAn = ma.ID
    JOIN LOAIMONAN lma ON ma.IDLoaiMonAn = lma.ID
    JOIN HD_MONAN hd ON ct.IDHoaDon = hd.ID
    WHERE 
        (@Ngay IS NULL OR DAY(hd.NgayMua) = @Ngay) AND
        (@Thang IS NULL OR MONTH(hd.NgayMua) = @Thang) AND
        (@Nam IS NULL OR YEAR(hd.NgayMua) = @Nam)
    GROUP BY lma.ID, lma.TenLoai
    ORDER BY DoanhThu DESC
END
GO


CREATE PROCEDURE LayIDBySDT --lấy id khách hàng dựa trên số điện thoại được nhân viên nhập
    @SDT NVARCHAR(15)
AS
BEGIN
    SELECT ID
    FROM KHACHHANG
    WHERE SDT = @SDT;
END;
GO

CREATE PROCEDURE ThemHoaDonMonAn --thêm vào hóa đơn món ăn
    @IDNhanVien INT,
    @IDKhachHang INT,
    @TongTien DECIMAL(10,0)
AS
BEGIN
    INSERT INTO HD_MONAN (IDNhanVien, IDKhachHang, TongTien)
    VALUES (@IDNhanVien, @IDKhachHang, @TongTien);

	 SELECT SCOPE_IDENTITY();
END;
GO


CREATE PROCEDURE usp_LayIDByTenMonAn --lấy mã món ăn dựa trên tên món ăn đó
    @TenMonAn NVARCHAR(100)
AS
BEGIN

    SELECT ID
    FROM MONAN
    WHERE TenMonAn = @TenMonAn;
END;
GO

CREATE PROCEDURE usp_ThemCTHDMONAN --thêm chi tiết hóa đơn món ăn (CTHD_MONAN)
    @IDHoaDon INT,
    @IDMonAn INT,
    @SoLuong INT,
    @DonGia DECIMAL(8,0)
AS
BEGIN
    -- Lấy thông tin tên món ăn tại thời điểm thêm (đề phòng sau này bị xóa)
    DECLARE @TenMonAn NVARCHAR(100);
    SELECT @TenMonAn = TenMonAn
    FROM MONAN
    WHERE ID = @IDMonAn;

    -- Thêm vào chi tiết hóa đơn món ăn
    INSERT INTO CTHD_MONAN (TenMonAn, Gia, SoLuong, IDHoaDon, IDMonAn)
    VALUES (@TenMonAn, @DonGia, @SoLuong, @IDHoaDon, @IDMonAn);
END;
GO

CREATE PROCEDURE usp_DanhSachCTHD_MONAN --hiển thị danh sách chi tiết hóa đơn món ăn
	@IDHoaDon INT
AS
BEGIN
		SELECT  
		cthd.IDHoaDon AS ID, 
		m.TenMonAn AS Ten,
		cthd.SoLuong AS SL,
		cthd.Gia,
		(cthd.SoLuong * cthd.Gia) AS ThanhTien
	FROM 
		CTHD_MONAN cthd
	JOIN 
		MONAN m ON cthd.IDMonAn = m.ID
	WHERE 
		cthd.IDHoaDon =  @IDHoaDon 
END
GO



CREATE PROCEDURE usp_GetTrangThaiGheTheoPhongVaSuatChieu
    @IDPhong INT,
    @MaGhe NVARCHAR(10),
    @NgayChieu DATE,
    @GioChieu TIME
AS
BEGIN

    SELECT TOP 1 t.TrangThai
    FROM TRANGTHAIGHE t
    JOIN GHE g ON t.IDGhe = g.ID
    WHERE g.IDPhong = @IDPhong
      AND g.MaGhe = @MaGhe
      AND t.NgayChieu = @NgayChieu
      AND t.GioChieu = @GioChieu;
END;
GO


CREATE PROCEDURE usp_DatGhe
    @IDGhe INT,
    @NgayChieu DATE,
    @GioChieu TIME
AS
BEGIN
    -- Kiểm tra ghế đã được đặt chưa
    IF EXISTS (
        SELECT 1 FROM TRANGTHAIGHE
        WHERE IDGhe = @IDGhe AND NgayChieu = @NgayChieu AND GioChieu = @GioChieu
    )
    BEGIN
        -- Nếu đã tồn tại thì cập nhật trạng thái
        UPDATE TRANGTHAIGHE
        SET TrangThai = 1
        WHERE IDGhe = @IDGhe AND NgayChieu = @NgayChieu AND GioChieu = @GioChieu;
    END
    ELSE
    BEGIN
        -- Nếu chưa có thì thêm mới
        INSERT INTO TRANGTHAIGHE (IDGhe, NgayChieu, GioChieu, TrangThai)
        VALUES (@IDGhe, @NgayChieu, @GioChieu, 1);
    END
END;
GO








--------------------------------- DANH SÁCH CÁC TRIGGER ---------------------------------

--------------- TẠO SỰ KIỆN KHI XÓA DỮ LIỆU Ở BẢNG GỐC ---------------

--CREATE TRIGGER trg_BeforeDelete_Phim --cập nhật TenPhim (LICHCHIEU) trước khi xóa ID (PHIM)
--ON PHIM
--INSTEAD OF DELETE
--AS
--BEGIN
--    -- Cập nhật TenPhim vào bảng LICHCHIEU trước khi xóa
--    UPDATE LICHCHIEU
--    SET TenPhim = P.TenPhim,
--		IDPhim = NULL
--    FROM LICHCHIEU LC
--    INNER JOIN DELETED D ON LC.IDPhim = D.ID
--    INNER JOIN PHIM P ON P.ID = D.ID;

--    -- Tiến hành xóa PHIM sau khi đã cập nhật
--    DELETE FROM PHIM
--    WHERE ID IN (SELECT ID FROM DELETED);
--END;
--GO


CREATE TRIGGER trg_BeforeDelete_LichChieu_VE -- cập nhật GioChieu (VE) trước khi xóa ID (LICHCHIEU)
ON LICHCHIEU
INSTEAD OF DELETE
AS
BEGIN
    -- Cập nhật dữ liệu GioChieu trong bảng VE
    UPDATE VE
    SET GioChieu = LC.NgayGio
    FROM VE V
    INNER JOIN DELETED D ON V.IDLichChieu = D.ID
    INNER JOIN LICHCHIEU LC ON LC.ID = D.ID;

    -- Sau khi cập nhật, xóa lịch chiếu
    DELETE FROM LICHCHIEU
    WHERE ID IN (SELECT ID FROM DELETED);
END;
GO

CREATE TRIGGER trg_BeforeDelete_KhachHang --cập nhật TenNV, SdtNV trong 2 bảng HD_MONAN và HD_VE trước khi xóa ID (NHANVIEN)
ON KHACHHANG
INSTEAD OF DELETE
AS
BEGIN
    -- Cập nhật dữ liệu TenKH, SdtKH trong HD_VE
    UPDATE HD_VE
    SET
        TenKH = KH.HoTen,
        SdtKH = KH.SDT,
		IDKhachHang = NULL
    FROM HD_VE HV
    INNER JOIN DELETED D ON HV.IDKhachHang = D.ID
    INNER JOIN KHACHHANG KH ON KH.ID = D.ID;

    -- Cập nhật dữ liệu TenKH, SdtKH trong HD_MONAN
    UPDATE HD_MONAN
    SET 
        TenKH = D.HoTen,
        SdtKH = D.SDT,
		IDKhachHang = NULL
    FROM HD_MONAN H
    INNER JOIN DELETED D ON H.IDKhachHang = D.ID;

    -- Sau khi đã cập nhật đầy đủ, tiến hành xóa KHACHHANG
    DELETE FROM KHACHHANG
    WHERE ID IN (SELECT ID FROM DELETED);
END;
GO

CREATE TRIGGER trg_BeforeDelete_NhanVien --cập nhật TenNV, SdtNV trong 2 bảng HD_MONAN và HD_VE trước khi xóa ID (NHANVIEN)
ON NHANVIEN
INSTEAD OF DELETE
AS
BEGIN
    -- Cập nhật dữ liệu TenNV, SdtNV trong HD_MONAN
    UPDATE HD_MONAN
    SET 
        TenNV = NV.HoTen,
        SdtNV = NV.SDT,
		IDNhanVien = NULL
    FROM HD_MONAN H
    INNER JOIN DELETED D ON H.IDNhanVien = D.ID
    INNER JOIN NHANVIEN NV ON NV.ID = D.ID;

    -- Cập nhật dữ liệu TenNV, SdtNV trong HD_VE
    UPDATE HD_VE
    SET
        TenNV = NV.HoTen,
        SdtNV = NV.SDT,
		IDNhanVien = NULL
    FROM HD_VE HD
    INNER JOIN DELETED D ON HD.IDNhanVien = D.ID
    INNER JOIN NHANVIEN NV ON NV.ID = D.ID;

    -- Sau khi đã cập nhật đầy đủ, tiến hành xóa nhân viên
    DELETE FROM NHANVIEN
    WHERE ID IN (SELECT ID FROM DELETED);
END;
GO

CREATE TRIGGER trg_BeforeDelete_MonAn_CTHD_MONAN --Cập nhật TenMonAn, Gia (CTHD_MONAN) trước khi xóa ID (MONAN)
ON MONAN
INSTEAD OF DELETE
AS
BEGIN
    -- Bước 1: Kiểm tra còn tồn kho không
    IF EXISTS (
        SELECT 1
        FROM deleted d
        JOIN KHO k ON k.IDMonAn = d.ID
        WHERE k.SoLuongTon > 0
    )
    BEGIN
        RAISERROR(N'Không thể xóa món ăn vì vẫn còn tồn kho.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END

	-- Bước 2: Cập nhật CTHD_MONAN trước khi xóa món ăn
    UPDATE CTHD_MONAN
    SET 
        TenMonAn = MA.TenMonAn,
        Gia = MA.Gia,
        IDMonAn = NULL
    FROM CTHD_MONAN C
    INNER JOIN deleted D ON C.IDMonAn = D.ID
    INNER JOIN MONAN MA ON MA.ID = D.ID;

    -- Bước 3: Xóa trong kho
    DELETE FROM KHO
    WHERE IDMonAn IN (SELECT ID FROM deleted);

    -- Bước 4: Xóa món ăn
    DELETE FROM MONAN
    WHERE ID IN (SELECT ID FROM deleted);

END; 
GO


CREATE TRIGGER trg_InsertMonAn_ToKho --trigger tự động thêm vào kho sau khi thêm mới món ăn (MONAN)
ON MONAN
AFTER INSERT
AS
BEGIN

    INSERT INTO KHO (IDMonAn, SoLuongTon, NgayCapNhat, TenMonAn)
    SELECT 
        i.ID, 
        0, 
        GETDATE(),
        i.TenMonAn
    FROM inserted i;
END
GO


CREATE TRIGGER trg_UpdateMonAn_ToKho --trigger cập nhật lại tên món ăn (KHO) nếu tên món ăn (MONAN) thay đổi
ON MONAN
AFTER UPDATE
AS
BEGIN

    -- Chỉ thực hiện nếu tên món ăn bị thay đổi
    IF UPDATE(TenMonAn)
    BEGIN
        UPDATE KHO
        SET TenMonAn = i.TenMonAn
        FROM KHO k
        INNER JOIN inserted i ON k.IDMonAn = i.ID;
    END
END
GO



--CÁC TRIGGER LƯU TRỮ TRẠNG THÁI HOẠT ĐỘNG CỦA NHÂN VIÊN

CREATE TRIGGER trg_Log_CHUCVU_InsertUpdateDelete --Khi thực hiện thao tác trên bảng CHUCVU
ON CHUCVU
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    -- Lấy username từ phiên làm việc (do C# truyền vào)
    DECLARE @username NVARCHAR(50) = (SELECT TOP 1 Username FROM LuuTruTam_TKNhanVien_DangDangNhap);
    DECLARE @idChucVu INT = (SELECT IDChucVu FROM NHANVIEN WHERE Username = @username);

    -- Khai báo nội dung log
    DECLARE @thaoTac NVARCHAR(200);
    DECLARE @chucNang NVARCHAR(100) = N'Quản lý chức vụ';

    IF EXISTS (SELECT * FROM INSERTED) AND EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Cập nhật chức vụ';
    ELSE IF EXISTS (SELECT * FROM INSERTED)
        SET @thaoTac = N'Thêm chức vụ';
    ELSE IF EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Xóa chức vụ';

    -- Ghi log
    INSERT INTO LOG_NHANVIEN (Username, IDChucVu, ThaoTac, ChucNang)
    VALUES (@username, @idChucVu, @thaoTac, @chucNang);
END;
GO

CREATE TRIGGER trg_Log_TKNHANVIEN_InsertUpdateDelete --Khi thực hiện thao tác trên bảng TKNHANVIEN
ON TKNHANVIEN
AFTER INSERT, DELETE
AS
BEGIN
    DECLARE @username NVARCHAR(50) = (SELECT TOP 1 Username FROM LuuTruTam_TKNhanVien_DangDangNhap);
    DECLARE @idChucVu INT = (SELECT IDChucVu FROM NHANVIEN WHERE Username = @username);
    DECLARE @thaoTac NVARCHAR(200);
    DECLARE @chucNang NVARCHAR(100) = N'Quản lý TKNV ';

    IF EXISTS (SELECT * FROM INSERTED) AND EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Cập nhật tài khoản';
    ELSE IF EXISTS (SELECT * FROM INSERTED)
        SET @thaoTac = N'Thêm tài khoản';
    ELSE IF EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Xóa tài khoản';

    INSERT INTO LOG_NHANVIEN (Username, IDChucVu, ThaoTac, ChucNang)
    VALUES (@username, @idChucVu, @thaoTac, @chucNang);
END;
GO

CREATE TRIGGER trg_Log_NHANVIEN_InsertUpdateDelete --Khi thực hiện thao tác trên bảng NHANVIEN
ON NHANVIEN
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @username NVARCHAR(50) = (SELECT TOP 1 Username FROM LuuTruTam_TKNhanVien_DangDangNhap);
    DECLARE @idChucVu INT = (SELECT IDChucVu FROM NHANVIEN WHERE Username = @username);
    DECLARE @thaoTac NVARCHAR(200);
    DECLARE @chucNang NVARCHAR(100) = N'Quản lý nhân viên';

    IF EXISTS (SELECT * FROM INSERTED) AND EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Cập nhật nhân viên';
    ELSE IF EXISTS (SELECT * FROM INSERTED)
        SET @thaoTac = N'Thêm nhân viên';
    ELSE IF EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Xóa nhân viên';

    INSERT INTO LOG_NHANVIEN (Username, IDChucVu, ThaoTac, ChucNang)
    VALUES (@username, @idChucVu, @thaoTac, @chucNang);
END;
GO

CREATE TRIGGER trg_Log_THELOAIPHIM_InsertUpdateDelete --Khi thực hiện thao tác trên bảng THELOAIPHIM
ON THELOAIPHIM
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @username NVARCHAR(50) = (SELECT TOP 1 Username FROM LuuTruTam_TKNhanVien_DangDangNhap);
    DECLARE @idChucVu INT = (SELECT IDChucVu FROM NHANVIEN WHERE Username = @username);
    DECLARE @thaoTac NVARCHAR(200);
    DECLARE @chucNang NVARCHAR(100) = N'Quản lý tl phim';

    IF EXISTS (SELECT * FROM INSERTED) AND EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Cập nhật thể loại phim';
    ELSE IF EXISTS (SELECT * FROM INSERTED)
        SET @thaoTac = N'Thêm thể loại phim';
    ELSE IF EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Xóa thể loại phim';

    INSERT INTO LOG_NHANVIEN (Username, IDChucVu, ThaoTac, ChucNang)
    VALUES (@username, @idChucVu, @thaoTac, @chucNang);
END;
GO

CREATE TRIGGER trg_Log_DINHDANGPHIM_InsertUpdateDelete --Khi thực hiện thao tác trên bảng DINHDANGPHIM
ON DINHDANGPHIM
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @username NVARCHAR(50) = (SELECT TOP 1 Username FROM LuuTruTam_TKNhanVien_DangDangNhap);
    DECLARE @idChucVu INT = (SELECT IDChucVu FROM NHANVIEN WHERE Username = @username);
    DECLARE @thaoTac NVARCHAR(200);
    DECLARE @chucNang NVARCHAR(100) = N'Quản lý dd phim';

    IF EXISTS (SELECT * FROM INSERTED) AND EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Cập nhật định dạng phim';
    ELSE IF EXISTS (SELECT * FROM INSERTED)
        SET @thaoTac = N'Thêm định dạng phim';
    ELSE IF EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Xóa định dạng phim';

    INSERT INTO LOG_NHANVIEN (Username, IDChucVu, ThaoTac, ChucNang)
    VALUES (@username, @idChucVu, @thaoTac, @chucNang);
END;
GO

CREATE TRIGGER trg_Log_PHIM_InsertUpdateDelete --Khi thực hiện thao tác trên bảng PHIM
ON PHIM
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @username NVARCHAR(50) = (SELECT TOP 1 Username FROM LuuTruTam_TKNhanVien_DangDangNhap);
    DECLARE @idChucVu INT = (SELECT IDChucVu FROM NHANVIEN WHERE Username = @username);
    DECLARE @thaoTac NVARCHAR(200);
    DECLARE @chucNang NVARCHAR(100) = N'Quản lý phim';

    IF EXISTS (SELECT * FROM INSERTED) AND EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Cập nhật phim';
    ELSE IF EXISTS (SELECT * FROM INSERTED)
        SET @thaoTac = N'Thêm phim';
    ELSE IF EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Xóa phim';

    INSERT INTO LOG_NHANVIEN (Username, IDChucVu, ThaoTac, ChucNang)
    VALUES (@username, @idChucVu, @thaoTac, @chucNang);
END;
GO

CREATE TRIGGER trg_Log_LOAIPHONG_InsertUpdateDelete --Khi thực hiện thao tác trên bảng LOAIPHONG
ON LOAIPHONG
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @username NVARCHAR(50) = (SELECT TOP 1 Username FROM LuuTruTam_TKNhanVien_DangDangNhap);
    DECLARE @idChucVu INT = (SELECT IDChucVu FROM NHANVIEN WHERE Username = @username);
    DECLARE @thaoTac NVARCHAR(200);
    DECLARE @chucNang NVARCHAR(100) = N'Quản lý loại phòng';

    IF EXISTS (SELECT * FROM INSERTED) AND EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Cập nhật loại phòng';
    ELSE IF EXISTS (SELECT * FROM INSERTED)
        SET @thaoTac = N'Thêm loại phòng';
    ELSE IF EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Xóa loại phòng';

    INSERT INTO LOG_NHANVIEN (Username, IDChucVu, ThaoTac, ChucNang)
    VALUES (@username, @idChucVu, @thaoTac, @chucNang);
END;
GO

CREATE TRIGGER trg_Log_PHONGCHIEU_InsertUpdateDelete --Khi thực hiện thao tác trên bảng PHONGCHIEU
ON PHONGCHIEU
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @username NVARCHAR(50) = (SELECT TOP 1 Username FROM LuuTruTam_TKNhanVien_DangDangNhap);
    DECLARE @idChucVu INT = (SELECT IDChucVu FROM NHANVIEN WHERE Username = @username);
    DECLARE @thaoTac NVARCHAR(200);
    DECLARE @chucNang NVARCHAR(100) = N'Quản lý phòng chiếu';

    IF EXISTS (SELECT * FROM INSERTED) AND EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Cập nhật phòng chiếu';
    ELSE IF EXISTS (SELECT * FROM INSERTED)
        SET @thaoTac = N'Thêm phòng chiếu';
    ELSE IF EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Xóa phòng chiếu';

    INSERT INTO LOG_NHANVIEN (Username, IDChucVu, ThaoTac, ChucNang)
    VALUES (@username, @idChucVu, @thaoTac, @chucNang);
END;
GO

CREATE TRIGGER trg_Log_LICHCHIEU_InsertUpdateDelete --Khi thực hiện thao tác trên bảng LICHCHIEU
ON LICHCHIEU
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @username NVARCHAR(50) = (SELECT TOP 1 Username FROM LuuTruTam_TKNhanVien_DangDangNhap);
    DECLARE @idChucVu INT = (SELECT IDChucVu FROM NHANVIEN WHERE Username = @username);
    DECLARE @thaoTac NVARCHAR(200);
    DECLARE @chucNang NVARCHAR(100) = N'Quản lý lịch chiếu';

    IF EXISTS (SELECT * FROM INSERTED) AND EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Cập nhật lịch chiếu';
    ELSE IF EXISTS (SELECT * FROM INSERTED)
        SET @thaoTac = N'Thêm lịch chiếu';
    ELSE IF EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Xóa lịch chiếu';

    INSERT INTO LOG_NHANVIEN (Username, IDChucVu, ThaoTac, ChucNang)
    VALUES (@username, @idChucVu, @thaoTac, @chucNang);
END;
GO

CREATE TRIGGER trg_Log_KHUYENMAI_InsertUpdateDelete --Khi thực hiện thao tác trên bảng KHUYENMAI
ON KHUYENMAI
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @username NVARCHAR(50) = (SELECT TOP 1 Username FROM LuuTruTam_TKNhanVien_DangDangNhap);
    DECLARE @idChucVu INT = (SELECT IDChucVu FROM NHANVIEN WHERE Username = @username);
    DECLARE @thaoTac NVARCHAR(200);
    DECLARE @chucNang NVARCHAR(100) = N'Quản lý khuyến mãi';

    IF EXISTS (SELECT * FROM INSERTED) AND EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Cập nhật khuyến mãi';
    ELSE IF EXISTS (SELECT * FROM INSERTED)
        SET @thaoTac = N'Thêm khuyến mãi';
    ELSE IF EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Xóa khuyến mãi';

    INSERT INTO LOG_NHANVIEN (Username, IDChucVu, ThaoTac, ChucNang)
    VALUES (@username, @idChucVu, @thaoTac, @chucNang);
END;
GO

CREATE TRIGGER trg_Log_LOAIMONAN_InsertUpdateDelete --Khi thực hiện thao tác trên bảng LOAIMONAN
ON LOAIMONAN
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @username NVARCHAR(50) = (SELECT TOP 1 Username FROM LuuTruTam_TKNhanVien_DangDangNhap);
    DECLARE @idChucVu INT = (SELECT IDChucVu FROM NHANVIEN WHERE Username = @username);
    DECLARE @thaoTac NVARCHAR(200);
    DECLARE @chucNang NVARCHAR(100) = N'Quản lý loại món ăn';

    IF EXISTS (SELECT * FROM INSERTED) AND EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Cập nhật loại món ăn';
    ELSE IF EXISTS (SELECT * FROM INSERTED)
        SET @thaoTac = N'Thêm loại món ăn';
    ELSE IF EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Xóa loại món ăn';

    INSERT INTO LOG_NHANVIEN (Username, IDChucVu, ThaoTac, ChucNang)
    VALUES (@username, @idChucVu, @thaoTac, @chucNang);
END;
GO

CREATE TRIGGER trg_Log_MONAN_InsertUpdateDelete --Khi thực hiện thao tác trên bảng MONAN
ON MONAN
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @username NVARCHAR(50) = (SELECT TOP 1 Username FROM LuuTruTam_TKNhanVien_DangDangNhap);
    DECLARE @idChucVu INT = (SELECT IDChucVu FROM NHANVIEN WHERE Username = @username);
    DECLARE @thaoTac NVARCHAR(200);
    DECLARE @chucNang NVARCHAR(100) = N'Quản lý món ăn';

    IF EXISTS (SELECT * FROM INSERTED) AND EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Cập nhật món ăn';
    ELSE IF EXISTS (SELECT * FROM INSERTED)
        SET @thaoTac = N'Thêm món ăn';
    ELSE IF EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Xóa món ăn';

    INSERT INTO LOG_NHANVIEN (Username, IDChucVu, ThaoTac, ChucNang)
    VALUES (@username, @idChucVu, @thaoTac, @chucNang);
END;
GO

CREATE TRIGGER trg_Log_KHO_InsertUpdateDelete --Khi thực hiện thao tác trên bảng KHO
ON KHO
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @username NVARCHAR(50) = (SELECT TOP 1 Username FROM LuuTruTam_TKNhanVien_DangDangNhap);
    DECLARE @idChucVu INT = (SELECT IDChucVu FROM NHANVIEN WHERE Username = @username);
    DECLARE @thaoTac NVARCHAR(200);
    DECLARE @chucNang NVARCHAR(100) = N'Quản lý kho';

    IF EXISTS (SELECT * FROM INSERTED) AND EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Cập nhật kho';
    ELSE IF EXISTS (SELECT * FROM INSERTED)
        SET @thaoTac = N'Thêm vào kho';
    ELSE IF EXISTS (SELECT * FROM DELETED)
        SET @thaoTac = N'Xóa khỏi kho';

    INSERT INTO LOG_NHANVIEN (Username, IDChucVu, ThaoTac, ChucNang)
    VALUES (@username, @idChucVu, @thaoTac, @chucNang);
END;
GO











