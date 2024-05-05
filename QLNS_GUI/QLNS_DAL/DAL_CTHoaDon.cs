using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DAL
{
    public class DAL_CTHoaDon
    {
        DAL_DATA data = new DAL_DATA();
        //Load danh muc
        public IQueryable LoadCTHoaDon(int maHD)
        {

            IQueryable ds = from item in data.Data.CTHoaDons 
                            where item.maHD == maHD
                            select item;

            return ds;
        }
        //Them danh muc
        public bool ThemCTHoaDon(ET_CTHoaDon CTHoaDon)
        {
            try
            {
                CTHoaDon cthd = new CTHoaDon
                {
                    maHD = CTHoaDon.MaHD.MaHD,
                    maSP = CTHoaDon.MaSP.MaSP,
                    SL = CTHoaDon.SLuong,
                    TTien = CTHoaDon.TTien,
                };
                data.Data.CTHoaDons.InsertOnSubmit(cthd);
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
        public bool XoaCTHoaDon(ET_CTHoaDon CTHD)
        {
            try
            {
                var list = from item in data.Data.CTHoaDons
                           where item.maCTHD == CTHD.MaCTHD
                           select item;
                foreach (var item in list)
                {
                    data.Data.CTHoaDons.DeleteOnSubmit(item);
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
        public bool SuaCTHoaDon(ET_CTHoaDon CTHD)
        {
            try
            {
                var suaDM = data.Data.CTHoaDons.Single(CTHoaDon => CTHoaDon.maCTHD == CTHD.MaCTHD);
                suaDM.maSP = CTHD.MaSP.MaSP;
                suaDM.SL = CTHD.SLuong;
                suaDM.TTien = CTHD.TTien;
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
