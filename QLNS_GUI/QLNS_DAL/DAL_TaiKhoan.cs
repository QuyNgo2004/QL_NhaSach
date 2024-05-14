using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DAL
{
    public class DAL_TaiKhoan :DAL_DATA
    {
        //DAL_DATA data = new DAL_DATA();

        public string KTTaiKhoan((string,string) Tkhoan)
        {
           IQueryable tk = from item in Data.TaiKhoans
                             where item.TKhoan == Tkhoan.Item1 && item.MKhau == Tkhoan.Item2
                             select new ET_TaiKhoan { MaNV = new ET_NhanVien { MaNV = item.maNV }};
            foreach (ET_TaiKhoan item in tk)
            {
                return item.MaNV.MaNV;
            }
            return null;
        }
        public bool ThemTK(string maNV)
        {
            try
            {
                TaiKhoan tk = new TaiKhoan {
                    maNV = maNV,
                    TKhoan = maNV,
                    MKhau = maNV,
                }; 
                Data.TaiKhoans.InsertOnSubmit(tk);
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
        //Xoa Nha cung cap
        public bool XoaTK(string maNV)
        {
            try
            {
                var list = from item in Data.TaiKhoans
                           where item.maNV == maNV
                           select item;
                foreach (var item in list)
                {
                    Data.TaiKhoans.DeleteOnSubmit(item);
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
        //Sua Tai khoan
        public bool SuaTK(ET_TaiKhoan tk)
        {
            try
            {
                var suaDM = Data.TaiKhoans.Single(TaiKhoan => TaiKhoan.maNV == tk.MaNV.MaNV);
                suaDM.MKhau = tk.MKhau;
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
