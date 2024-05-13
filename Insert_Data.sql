Insert into  DanhMuc (maDM,tenDM,ghiChu)
values ('DM1','Sách',''),('DM2','Dụng cụ học tập',''),('DM3','Đồ chơi','');
--Xem bang
select * from NhaCCCT
--
-- The loai
Insert into  TheLoai(maTL,tenTL,maDM,ghiChu)
values ('1','Sách giáo khoa','DM1',''),('2','Sách nước ngoài','DM1',''),('3','Truyện tranh','DM1',''),('4','Sách tham khảo','DM1',''),
		('5','Vở','DM2',''),('6','Bút','DM2',''),('7','Dụng cụ kĩ thuật','DM2',''),('8','Cặp sách','DM2',''),
		('9','Lego','DM3',''),('10','Xe điều khiển','DM3',''),('11','Sưu tầm','DM3',''),('12','BoardGame','DM3','')
--Xem bang
select * from DanhMuc
--
Insert into  DonVi(donVi,maDM,ghiChu)
values ('quyển','DM1',''),('bộ','DM1',''),
		('cây','DM2',''),('hộp','DM2',''),('quyển','DM2',''),('cái','DM2',''),
		('bộ','DM3',''),('bộ','DM3',''),('cái','DM3','')

-- Chi nhanh
Insert into  ChiNhanh(maCN,tenCN,diaChi)
values ('01','Nhà sách Sài Gòn','Sài gòn')
--Nhan vien 
Insert into  NhanVien(MANV ,HOTENNV,DIACHINV ,SDT ,NGAYSINH,CHUCVU ,maCN,GIOITINH , CREATED_DATE_NV )
values ('01','admin','Sài gòn','02230495223', GETDATE(),'QL','01','Nam',GETDATE())
--Nha cung cap
Insert into NhaCC(maNCC ,tenNCC ,diaChi ,sDT ,ghiChu)
values ('01','Kim đồng','Sài Gòn','0243554032','')
Insert into SanPham(tenSP ,maNCC ,maTL ,giaSP ,maDV ,SLTonKho ,tangKem )
values ('Connan','01','3','45000','1','20','1')
go
Insert into TaiKhoan(maNV ,TKhoan ,MKhau )
values ('01','01','01');
select * from HoaDon 