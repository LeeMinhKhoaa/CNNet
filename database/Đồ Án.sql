CREATE DATABASE NHATHUOC
USE NHATHUOC
-- Tạo bảng HoaDon
CREATE TABLE HOADON (
    MaHD varchar(10) PRIMARY KEY,
    NgayLap DATE,
    TienThua DECIMAL(10,2),
    TienThu DECIMAL(10,2),
    TongTien DECIMAL(10,2),
	MaKH varchar(10),
	MaNV varchar(10)

);

1
-- Tạo bảng KhachHang
CREATE TABLE KHACHHANG (
    MaKH varchar(10) PRIMARY KEY,
	TenKH NVARCHAR(200),
    GioiTinh VARCHAR(10),
    Tuoi INT,
    SDT VARCHAR(20),
);

-- Tạo bảng NhanVien
CREATE TABLE NHANVIEN (
    MaNV varchar(10) PRIMARY KEY,
    TenNV NVARCHAR(50),
    GioiTinh VARCHAR(10),
    SDT VARCHAR(20),
    ChucVu NVARCHAR(50),
    TaiKhoan VARCHAR(50),
    MatKhau VARCHAR(50),

);


-- Tạo bảng PhieuNhap
CREATE TABLE PHIEUNHAP (
    MaPN VARCHAR(10) PRIMARY KEY,
    NgayNhap DATE,
    NguoiGiao VARCHAR(50),
    TongTien DECIMAL(10,2),
	MaNV VARCHAR(10),
	MaNCC VARCHAR(10)


);
-- Tạo bảng ChiTietPhieuNhap
CREATE TABLE CHITIETPHIEUNHAP (
    MaPN VARCHAR(10) not null,
    MaThuoc VARCHAR(10) not null,
    SoLuong INT,
    DonGiaNhap DECIMAL(10,2),
	MaLo varchar(10)
	PRIMARY KEY(MaPN,MaThuoc)
);

-- Tạo bảng Thuoc
CREATE TABLE THUOC (
    MaThuoc VARCHAR(10) PRIMARY KEY,
	MaNhomThuoc VARCHAR(10),
	TenThuoc NVARCHAR(50),
	MaLoaiThuoc varchar(10),
	SoLuong int,
    DVT VARCHAR(20),
    GiaBan DECIMAL(10,2),
    HanSuDung DATE,
    MoTa NVARCHAR(100),
    GiaNhap DECIMAL(10,2),
    HinhAnh VARCHAR(100),
    TacDungPhu NVARCHAR(100),
    XuatXu NVARCHAR(50),
);


-- Tạo bảng NhaCungCap
CREATE TABLE NHACUNGCAP (
    MaNCC VARCHAR(10) PRIMARY KEY,
    TenNCC NVARCHAR(100),
    DiaChi NVARCHAR(100),
    SDT VARCHAR(20),

);


CREATE TABLE NHOMTHUOC(
	MaNhomThuoc VARCHAR(10) PRIMARY KEY,
	TenNhomThuoc NVARCHAR(200)
)

CREATE TABLE CHITIETHD(
MaHD VARCHAR(10) ,
MaThuoc VARCHAR(10),
SoLuong INT,
DonGia DECIMAL(10,2),
primary key(MaHD,MaThuoc)
)
create table LOTHUOC(
	MaLo varchar(10) primary key,
	SoLo int,
	MaThuoc varchar(10),
	SoLuongTon int,
	NgayHetHan datetime,
)

-- Liên kết khóa ngoại từ bảng HoaDon đến bảng KhachHang
ALTER TABLE HoaDon
ADD FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH);

-- Liên kết khóa ngoại từ bảng HoaDon đến bảng NhanVien
ALTER TABLE HoaDon
ADD FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV);

-- Liên kết khóa ngoại từ bảng LoThuoc đến bảng Thuoc
ALTER TABLE LoThuoc
ADD FOREIGN KEY (MaThuoc) REFERENCES Thuoc(MaThuoc); 


-- Liên kết khóa ngoại từ bảng PhieuNhap đến bảng NhanVien
ALTER TABLE PhieuNhap
ADD FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV);

-- Liên kết khóa ngoại từ bảng ChiTietHD đến bảng LoThuoc
ALTER TABLE ChiTietHD
ADD FOREIGN KEY (MaLo) REFERENCES LoThuoc(MaLo);

-- Liên kết khóa ngoại từ bảng ChiTietPhieuNhap đến bảng PhieuNhap
ALTER TABLE ChiTietPhieuNhap
ADD FOREIGN KEY (MaPN) REFERENCES PhieuNhap(MaPN);

-- Liên kết khóa ngoại từ bảng ChiTietPhieuNhap đến bảng Thuoc
ALTER TABLE ChiTietPhieuNhap
ADD FOREIGN KEY (MaThuoc) REFERENCES Thuoc(MaThuoc);

-- Liên kết khóa ngoại từ bảng CHITIEUHD đến bảng HoaDon
ALTER TABLE CHITIETHD
ADD FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD);

-- Liên kết khóa ngoại từ bảng CHITIEUHD đến bảng Thuoc
ALTER TABLE CHITIETHD
ADD FOREIGN KEY (MaThuoc) REFERENCES Thuoc(MaThuoc);

-- Liên kết khóa ngoại từ bảng Thuoc đến bảng NhomThuoc
ALTER TABLE Thuoc
ADD FOREIGN KEY (MaNhomThuoc) REFERENCES NHOMTHUOC(MaNhomThuoc);


-- Liên kết khóa ngoại từ bảng PhieuNhap đến bảng NhaCungCap
ALTER TABLE PhieuNhap
ADD FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC);

-- Liên kết khóa ngoại Lo đến ChiTietPhieuNhap
alter table ChiTietPhieuNhap
add foreign key(MaLo) references LoThuoc(MaLo)

alter table Thuoc 
add MaNCC varchar(10)

alter table Thuoc 
add foreign key (MaNCC) references NhaCungCap(MaNCC)

--------------------------Trigger-----------------------------

-- Update số lượng tồn khi bán
CREATE TRIGGER trg_CHITIETHD_UpdateSLTon
ON CHITIETHD
AFTER INSERT
AS
BEGIN 
	DECLARE @MaThuoc varchar(10)
	DECLARE @SoLuongMua int
	SELECT @MaThuoc = MaThuoc, @SoLuongMua = SoLuong FROM inserted

	-- Trừ số lượng tồn của thuốc khi bán 
	Update THUOC
	SET SoLuong = SoLuong - @SoLuongMua
	WHERE MaThuoc = @MaThuoc
END
GO

-- Update số lượng tồn khi nhập 
CREATE TRIGGER trg_CHITIETPHIEUNHAP_UpdateSLTon
ON CHITIETPHIEUNHAP
AFTER INSERT
AS 
BEGIN
	DECLARE @MaThuoc varchar(10)
	DECLARE @SoLuongNhap int
	SELECT @MaThuoc = MaThuoc, @SoLuongNhap = SoLuong FROM INSERTED

	--Them so luong khi nhap
	UPDATE THUOC
	SET SoLuong = SoLuong + @SoLuongNhap
	WHERE MaThuoc = @MaThuoc


END
GO

-- Tru so luong ton khi het han
CREATE TRIGGER trg_HetHanThuoc
ON LOTHUOC
FOR DELETE
AS
BEGIN

	DECLARE @SoLuongTon INT
	DECLARE @MaThuoc varchar(10)
	SELECT @SoLuongTon = SoLuongTon, @MaThuoc = MaThuoc FROM DELETED

	-- Trừ số lượng tồn hết hạn vào số lượng thuốc
	UPDATE THUOC
	SET SoLuong = SoLuong - @SoLuongTon
	WHERE MaThuoc = @MaThuoc;

END

