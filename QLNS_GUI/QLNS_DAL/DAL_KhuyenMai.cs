using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DAL
{
    public class DAL_KhuyenMai
    {
        DAL_DATA data = new DAL_DATA();

        public IQueryable LoadKhuyenMai()
        {
            IQueryable km = from dv in data.Data.KhuyenMais
                           
                            select new { MãKM = dv.maKM,TênKM = dv.tenKM,GiảmGiá = dv.giamGia };
            return km;
        }
        
        //Them danh muc
        public bool ThemKhuyenMai(ET_KhuyenMai km)
        {
            try
            {
                KhuyenMai dv = new KhuyenMai
                {
                    maKM = km.MaKM,
                    tenKM = km.TenKM,
                    giamGia = km.GiamGia
                };
                data.Data.KhuyenMais.InsertOnSubmit(dv);
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
        public bool XoaKhuyenMai(ET_KhuyenMai km)
        {
            try
            {
                var list = from item in data.Data.KhuyenMais
                           where item.maKM == km.MaKM
                           select item;
                foreach (var item in list)
                {
                    data.Data.KhuyenMais.DeleteOnSubmit(item);
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
        public bool SuaKhuyenMai(ET_KhuyenMai km)
        {
            try
            {
                var suadv = data.Data.KhuyenMais.Single(KhuyenMai => KhuyenMai.maKM == km.MaKM);
                suadv.maKM = km.MaKM;
                suadv.tenKM = km.TenKM;
                suadv.giamGia = km.GiamGia;
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
