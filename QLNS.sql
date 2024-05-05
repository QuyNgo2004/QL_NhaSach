--create database QLNhaSach
use QLNhaSach
--drop database QLNhaSach
go
SET DATEFORMAT dmy;
--Tạo bảng chi nhánh
create table ChiNhanh(
maCN varchar(20) primary key,
tenCN nvarchar(50),
diaChi nvarchar(100))
go
--Tạo bảng danh mục
create table DanhMuc(
maDM varchar(10) primary key,
tenDM nvarchar(50),
ghiChu nvarchar(200))
go
--Tạo bảng thể loại 
create table TheLoai(
maTL varchar(20) primary key,
tenTL nvarchar(50),
maDM varchar(10) foreign key references DanhMuc(maDM),
ghiChu nvarchar(200))
go
--Tạo bảng nhà cung cấp
create table NhaCC(
maNCC varchar(20) primary key,
tenNCC nvarchar(50),
diaChi nvarchar(100),
sDT varchar(20),
ghiChu nvarchar(200))
go
--Tạo bảng khách hàng
create table KhachHang(
maKH varchar(20) primary key,
tenKH nvarchar(50), 
sDT varchar(20))
go
--Tạo bảng đơn vị 
create table DonVi(
maDV INT IDENTITY(1,1) PRIMARY KEY,
maDM  varchar(10) foreign key references DanhMuc(maDM),
donVi nvarchar(50),
ghiChu nvarchar(200) null
)
--Tạo bảng sản phẩm
create table SanPham(
maSP INT IDENTITY(1,1) PRIMARY KEY,
tenSP nvarchar(50),
maNCC varchar(20),
maTL varchar(20) foreign key references TheLoai(maTL),
giaSP float,
maDV int foreign key references DonVi(maDV),
SLTonKho int,
tangKem int null)

go
--Tao bang chi tiet nha cung cap
create table NhaCCCT(
maCTNCC INT IDENTITY(1,1) ,
maNCC varchar(20) foreign key references NhaCC(maNCC),
maSP INT foreign key references SanPham(maSP),
ngayCC datetime,
soLuong int ,
ghiChu nvarchar(200),
constraint PK_CTNCC primary key(maCTNCC,maNCC,maSP))
go
--Tạo bảng Khuyến Mãi
create table KhuyenMai(
maKM varchar(20) primary key,
tenKM nvarchar(50),
giamGia int null,
maSP INT --Qua tang kem )
)
--Tao bang chi tiet khuyen mai
create table CTKhuyenMai(
maCTKM INT IDENTITY(1,1),
maSP INT foreign key references SanPham(maSP) ,
maKM varchar(20) foreign key references KhuyenMai(maKM),
ngayBD dateTime,
ngayKT dateTime,
constraint PK_CTKM primary key(maSP,maKM,maCTKM))
--Tao bang nhan vien
CREATE TABLE NhanVien (
MANV CHAR(15) primary key,
HOTENNV NVARCHAR(255) NOT NULL,
DIACHINV NVARCHAR(100),
SDT varchar NULL,
NGAYSINH DATE NOT NULL,
CHUCVU NVARCHAR(50),
maCN varchar(20) foreign key references ChiNhanh(maCN),
GIOITINH nvarchar(10) NOT NULL, 
CREATED_DATE_NV datetime not null);
--Tao bang Hoa Don
create table HoaDon(
maHD INT IDENTITY(1,1) PRIMARY KEY,
maKH varchar(20) foreign key references KhachHang(maKH),
maNV CHAR(15) foreign key references NhanVien(MANV),
ngayHD DATE,
tongHD float)
--Tao bang chi tiet hoa don
create table CTHoaDon(
maCTHD INT IDENTITY(1,1) ,
maHD int foreign key references HoaDon(maHD),
maSP int foreign key references SanPham(maSP),
SL int,
TTien float
constraint PK_CTHD primary key (maHD,maSP,maCTHD))
--Tao bang tai khoan
create table TaiKhoan(
maNV CHAR(15) foreign key references NhanVien(maNV) primary key,
TKhoan NVARCHAR(50),
MKhau NVARCHAR(50)
)
