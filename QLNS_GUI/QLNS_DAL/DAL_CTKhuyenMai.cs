using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DAL
{
    public class DAL_CTKhuyenMai
    {
        DAL_DATA data = new DAL_DATA();
        //Load danh muc
        public IQueryable LoadCTKhuyenMai()
        {

            IQueryable ds = from item in data.Data.CTKhuyenMais
                            join km in data.Data.KhuyenMais 
                            on item.maKM equals km.maKM

                            join sp in data.Data.SanPhams
                            on item.maSP equals sp.maSP
                            select new
                            {
                                MãCT = item.maCTKM,
                                SPKhuyếnMãi = sp.tenSP,
                                TênKM = km.tenKM,
                                NgàyBD = item.ngayBD,
                                NgàyKT = item.ngayKT
                            };

            return ds;
        }
        //Them CTKhuyenMai
        public bool ThemCTKhuyenMai(ET_CTKhuyenMai km)
        {
            try
            {
                CTKhuyenMai dm = new CTKhuyenMai
                {
                    maKM = km.MaKM.MaKM,
                    maSP = km.MaSP.MaSP,
                    ngayBD = km.NgayBD,
                    ngayKT = km.NgayKT
                };
                data.Data.CTKhuyenMais.InsertOnSubmit(dm);
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
        //Xoa CTKhuyenMai
        public bool XoaCTKhuyenMai(ET_CTKhuyenMai km)
        {
            try
            {
                var list = from item in data.Data.CTKhuyenMais
                           where item.maCTKM == km.MaCTKM 
                           select item;
                foreach (var item in list)
                {
                    data.Data.CTKhuyenMais.DeleteOnSubmit(item);
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
        //Sua CTKhuyenMai
        public bool SuaCTKhuyenMaiTheoKM(ET_CTKhuyenMai km)
        {
            try
            {
                var suaDM = data.Data.CTKhuyenMais.Single(CTKhuyenMai => CTKhuyenMai.maCTKM == km.MaCTKM) ;
                suaDM.maKM = km.MaKM.MaKM;
                suaDM.maSP = km.MaSP.MaSP;
                suaDM.ngayBD = km.NgayBD;
                suaDM.ngayKT = km.NgayKT;
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
