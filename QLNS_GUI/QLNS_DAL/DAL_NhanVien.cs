using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DAL
{
    public class DAL_NhanVien : DAL_DATA
    {
        //DAL_DATA data = new DAL_DATA();
        //Load danh muc
        public IQueryable LoadNhanVien()
        {

            IQueryable ds = from item in Data.NhanViens
                            join cn in Data.ChiNhanhs on item.maCN equals cn.maCN                            
                            select new {item.MANV,item.HOTENNV,item.DIACHINV,item.SDT,item.NGAYSINH,item.CHUCVU,item.GIOITINH,cn.tenCN,item.CREATED_DATE_NV};

            return ds;
        }
        //Tim nhan vien
        public ET_NhanVien TimNhanVien(string maNV)
        {

            IQueryable ds = from item in Data.NhanViens
                            where item.MANV == maNV
                            select new ET_NhanVien { MaNV = item.MANV,TenNV = item.HOTENNV,ChucVu = item.CHUCVU };
            foreach (ET_NhanVien item in ds)
            {
                return item;
            }
            return null;
        }
        //Them danh muc
        public bool ThemNhanVien(ET_NhanVien nhanVien)
        {
            try
            {
                NhanVien nv = new NhanVien
                {
                    MANV = nhanVien.MaNV,
                    HOTENNV = nhanVien.TenNV,
                    DIACHINV = nhanVien.DiaChi,
                    SDT = nhanVien.SDT,
                    NGAYSINH = nhanVien.NgaySinh,
                    CHUCVU = nhanVien.ChucVu,
                    maCN = nhanVien.MaCN.MaCN,
                    GIOITINH = nhanVien.GioiTinh,
                    CREATED_DATE_NV = nhanVien.NgayTao


                };
                Data.NhanViens.InsertOnSubmit(nv);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                Data.SubmitChanges();
            }
            return true;
        }
        //Xoa danh muc
        public bool XoaNhanVien(ET_NhanVien nhanVien)
        {
            try
            {
                var list = from item in Data.NhanViens
                           where item.MANV == nhanVien.MaNV
                           select item;
                foreach (var item in list)
                {
                    Data.NhanViens.DeleteOnSubmit(item);
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                Data.SubmitChanges();
            }
            return true;
        }
        //Sua danh muc
        public bool SuaNhanVien(ET_NhanVien nhanVien)
        {
            try
            {
                var suaDM = Data.NhanViens.Single(NhanVien => NhanVien.MANV == nhanVien.MaNV);
                suaDM.HOTENNV = nhanVien.TenNV;
                suaDM.DIACHINV = nhanVien.DiaChi;
                suaDM.SDT = nhanVien.SDT;
                suaDM.NGAYSINH = nhanVien.NgaySinh;
                suaDM.CHUCVU = nhanVien.ChucVu;
                suaDM.maCN = nhanVien.MaCN.MaCN;
                suaDM.GIOITINH = nhanVien.GioiTinh;
                suaDM.CREATED_DATE_NV = nhanVien.NgayTao;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { Data.SubmitChanges(); }
            return true;
        }
    }
}
