CREATE DATABASE QuanLyNhaKhoa
GO
USE QuanLyNhaKhoa
GO
CREATE TABLE NhanVien
(
	MaNhanVien VARCHAR (10) NOT NULL,
	HoTen NVARCHAR (50),
	Phai NVARCHAR (4),
	NgaySinh DATE,
	DiaChi NVARCHAR (100),
	SDT VARCHAR (12),
	NgayVaoLam DATE,
	LuongCoBan INT,
	PRIMARY KEY(MaNhanVien)
)
CREATE TABLE NhomNguoiDung
(
	MaNhom VARCHAR NOT NULL,
	TenNhom NVARCHAR (50),
	GhiChu NVARCHAR(200),
	PRIMARY KEY(MaNhom)
)
CREATE TABLE NguoiDung
(
	MaNhanVien VARCHAR (10) NOT NULL,
	TenDangNhap VARCHAR(50) NOT NULL,
	MatKhau VARCHAR(50),
	TrangThai NVARCHAR(20),
	PRIMARY KEY(TenDangNhap),
	CONSTRAINT FK_NguoiDung_NhanVien FOREIGN KEY(MaNhanVien) REFERENCES NhanVien(MaNhanVien)
)
CREATE TABLE NguoiDungNhomNguoiDung
(
	TenDangNhap VARCHAR(50) NOT NULL,
	MaNhom VARCHAR NOT NULL,
	GhiChu NVARCHAR(200),
	PRIMARY KEY(TenDangNhap,  MaNhom),
	CONSTRAINT FK_NguoiDung_Nhom FOREIGN KEY(TenDangNhap) REFERENCES NguoiDung(TenDangNhap),
	CONSTRAINT FK_NhomNguoiDung_Nhom FOREIGN KEY(MaNhom) REFERENCES NhomNguoiDung(MaNhom)
)
CREATE TABLE ManHinh
(
	MaManHinh VARCHAR NOT NULL,
	TenManHinh NVARCHAR (50) NOT NULL,	
	PRIMARY KEY(MaManHinh)
)
CREATE TABLE PhanQuyen
(
	MaNhom VARCHAR NOT NULL,
	MaManHinh VARCHAR NOT NULL,
	CoQuyen NVARCHAR (10) NOT NULL,
	PRIMARY KEY(MaNhom, MaManHinh),
	CONSTRAINT FK_PhanQuyen_NhomNguoiDung FOREIGN KEY(MaNhom) REFERENCES NhomNguoiDung(MaNhom),
	CONSTRAINT FK_PhanQuyen_ManHinh FOREIGN KEY(MaManHinh) REFERENCES ManHinh(MaManHinh)
)
GO

--NHẬP DỮ LIỆU
SET DATEFORMAT DMY
INSERT INTO NhanVien
VALUES
('NV001', N'Ngô Văn Mười', N'Nam', '08/09/1999', N'123 Nguyễn Hữu Tiến, Tây Thạnh, Tân Phú, Tp.Hcm', '0392419643', '30/05/2010', 200000),
('NV002', N'Nguyễn Thị Thùy Dương', N'Nữ', '23/05/2001', N'11/50 Nguyễn Hữu Tiến, Tây Thạnh, Tân Phú, Tp.Hcm', '0351248625', '02/06/2020', 110000),
('NV003', N'Chung Tử Đơn', N'Nam', '21/03/1990', N'11 Bàu Bàng, Phường 13, Tân Bình, Tp.HCM', '0935224412', '12/05/2015', 200000),
('NV004', N'Châu Nhuận Phát ', N'Nam', '15/12/1991', N'64 Đường số 17, Linh Trung, Thủ Đức', '0392419643', '30/05/2010', 200000),
('NV005', N'Lý Gia Hân', N'Nữ', '01/10/1995', N'4 đường D11, P.Tây Thạnh ,Q.Tân Phú, Tp.Hcm', '0924032217', '21/12/2018', 150000),
('NV006', N'Huỳnh Thúy Như', N'Nữ', '16/02/1993', N'37 Trần Quý Cáp, Phường 11, Q.Bình Thạnh, Tp.Hcm', '0935124588', '04/11/2019', 120000)

INSERT INTO NhomNguoiDung
VALUES
('admin',N'Quản lý',Null),
('BS',N'Bác sĩ',Null),
('ThuNgan',N'Thu Ngân',Null),
('LeTan',N'Lễ Tân',Null)

INSERT INTO NguoiDung
VALUES
('NV001','ngo10','123',N'Hoạt động'),
('NV002','duong','123',N'Hoạt động'),
('NV003','don123','123',N'Hoạt động')

INSERT INTO NguoiDungNhomNguoiDung
VALUES
('ngo10','admin',Null),
('duong','LeTan',Null)

INSERT INTO ManHinh
VALUES
('ribbQuanLy',N'Màn hình quản lý'),
('ribbLeTan',N'Màn hình lễ tân')

INSERT INTO PhanQuyen
VALUES
('admin','ribbQuanLy',N'Có'),
('LeTan','ribbQuanLy',N'Không')