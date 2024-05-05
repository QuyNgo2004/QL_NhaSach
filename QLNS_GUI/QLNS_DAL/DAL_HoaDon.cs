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
        //Them danh muc
        public bool ThemHoaDon(ET_HoaDon hDon)
        {
            try
            {
                HoaDon hd = new HoaDon
                {
                    maKH = hDon.MaKH.MaKH,
                    maNV =hDon.MaNV.MaNV,
                    ngayHD = hDon.NgayHD,
                    tongHD = 0,
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
            DAL_CTHoaDon cTHoaDon = new DAL_CTHoaDon();
            IQueryable CT = cTHoaDon.LoadCTHoaDon(hDon.MaHD);
            float TongTien = 0;
            foreach (ET_CTHoaDon item in CT)
            {
                TongTien +=item.TTien;
            }
            try
            {
                var suaDM = data.Data.HoaDons.Single(DanhMuc => DanhMuc.maHD == hDon.MaHD);
                suaDM.maKH = hDon.MaKH.MaKH;
                suaDM.maNV = hDon.MaNV.MaNV;
                suaDM.tongHD = TongTien;
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
