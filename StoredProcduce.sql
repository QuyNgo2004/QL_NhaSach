--In hoa don
create proc InHoaDon
@MAHD int
as
begin 
select * from HoaDon as HD
INNER JOIN CTHoaDon as CTHD ON CTHD.maHD = HD.maHD
INNER JOIN NhanVien as NV ON HD.maNV = NV.MANV
where HD.maHD = @MAHD
end
go

exec InHoaDon @MAHD = '26'
go
--Danh sach hoa don theo thang
create proc HoaDonTheoThang
@Thang int ,
@TenNV nvarchar(100)
as
begin 
select * from HoaDon as HD
INNER JOIN CTHoaDon as CTHD ON CTHD.maHD = HD.maHD
INNER JOIN NhanVien as NV ON HD.maNV = NV.MANV
where MONTH(HD.ngayHD) = @Thang and YEAR(HD.ngayHD) = Year(GETDATE())
end
go

exec HoaDonTheoThang @Thang = '5'