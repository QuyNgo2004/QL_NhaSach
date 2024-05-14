using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DAL
{
    public class DAL_KhachHang :DAL_DATA
    {
       // DAL_DATA data = new DAL_DATA();
        //Load danh muc
        public IQueryable LoadKhachHang()
        {

            IQueryable ds = from item in Data.KhachHangs select item;

            return ds;
        }
        //Them danh muc
        public bool ThemKhachHang(ET_KhachHang khachHang)
        {
            try
            {
                KhachHang kh = new KhachHang
                {
                    maKH = khachHang.MaKH,
                    tenKH = khachHang.TenKH,
                    sDT = khachHang.SDT
                };
                Data.KhachHangs.InsertOnSubmit(kh);
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
        public bool XoaKhachHang(ET_KhachHang khachHang)
        {
            try
            {
                var list = from item in Data.KhachHangs
                           where item.maKH == khachHang.MaKH
                           select item;
                foreach (var item in list)
                {
                    Data.KhachHangs.DeleteOnSubmit(item);
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
        public bool SuaKhachHang(ET_KhachHang khachHang)
        {
            try
            {
                var suaDM = Data.KhachHangs.Single(KhachHang => KhachHang.maKH == khachHang.MaKH);
                suaDM.tenKH = khachHang.TenKH;
                suaDM.sDT = khachHang.SDT;
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
