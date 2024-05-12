using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DAL
{
    public class DAL_HoaDon
    {
        DAL_DATA data = new DAL_DATA();
        //Load danh muc
        public IQueryable LoadHoaDon()
        {

            IQueryable ds = from item in data.Data.HoaDons select item;

            return ds;
        }
        public IQueryable LoadHoaDonTheoNgay(DateTime date)
        {

            IQueryable ds = from item in data.Data.HoaDons
                            where item.ngayHD == date
                            select new
                            {
                                maHD = item.maHD,
                                MaNV = item.maNV,
                                MaKH = item.maKH,
                                TổngHD = item.tongHD
                            };

            return ds;
        }
        public int HoaDonMoiTao()
        {
             
            IQueryable ds = (from hd in data.Data.HoaDons
                             orderby hd.maHD descending 
                            select new ET_HoaDon { MaHD = hd.maHD }).Take(1);
            foreach (ET_HoaDon hd in ds)
            {
                return hd.MaHD;
            }
            return 0;
        }
        //Them danh muc
        public bool ThemHoaDon(ET_HoaDon hDon)
        {
            try
            {
                HoaDon hd = new HoaDon
                {
                    /*maKH = hDon.MaKH.MaKH,
                    maNV =hDon.MaNV.MaNV,*/
                    ngayHD = hDon.NgayHD,
                    //tongHD = 0,
                };
                data.Data.HoaDons.InsertOnSubmit(hd);
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
        public bool XoaHoaDon(ET_HoaDon hDon)
        {
            try
            {
                var list = from item in data.Data.HoaDons
                           where item.maHD == hDon.MaHD
                           select item;
                foreach (var item in list)
                {
                    data.Data.HoaDons.DeleteOnSubmit(item);
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
        public bool SuaHoaDon(ET_HoaDon hDon)
        {
            try
            {
                var suaDM = data.Data.HoaDons.Single(DanhMuc => DanhMuc.maHD == hDon.MaHD);
                suaDM.maKH = hDon.MaKH.MaKH;
                suaDM.maNV = hDon.MaNV.MaNV;
                suaDM.tongHD = hDon.TongHD;
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
