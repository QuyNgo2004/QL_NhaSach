Insert into  DanhMuc (maDM,tenDM,ghiChu)
values ('DM1','Sách',''),('DM2','Dụng cụ học tập',''),('DM3','Đồ chơi','');
--Xem bang
select * from NhaCCCT
--

Insert into  TheLoai(maTL,tenTL,maDM,ghiChu)
values ('1','Sách giáo khoa','DM1','')
--Xem bang
select * from DanhMuc
--
Insert into  DonVi(donVi,maDM,ghiChu)
values ('quyển','DM1','')