using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DAL
{
    public class DAL_NhanVien
    {
        DAL_DATA data = new DAL_DATA();
        //Load danh muc
        public IQueryable LoadNhanVien()
        {

            IQueryable ds = from item in data.Data.NhanViens select item;

            return ds;
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
                data.Data.NhanViens.InsertOnSubmit(nv);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                data.Data.SubmitChanges();
            }
            return true;
        }
        //Xoa danh muc
        public bool XoaNhanVien(ET_NhanVien nhanVien)
        {
            try
            {
                var list = from item in data.Data.NhanViens
                           where item.MANV == nhanVien.MaNV
                           select item;
                foreach (var item in list)
                {
                    data.Data.NhanViens.DeleteOnSubmit(item);
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                data.Data.SubmitChanges();
            }
            return true;
        }
        //Sua danh muc
        public bool SuaNhanVien(ET_NhanVien nhanVien)
        {
            try
            {
                var suaDM = data.Data.NhanViens.Single(NhanVien => NhanVien.MANV == nhanVien.MaNV);
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
            finally { data.Data.SubmitChanges(); }
            return true;
        }
    }
}
