using QLNS_ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QLNS_DAL
{
    public class DAL_CTKhuyenMai :DAL_DATA
    {
        //DAL_DATA data = new DAL_DATA();
        //Load danh muc
        public IQueryable LoadCTKhuyenMai()
        {

            IQueryable ds = from item in Data.CTKhuyenMais
                            join km in Data.KhuyenMais 
                            on item.maKM equals km.maKM

                            join sp in Data.SanPhams
                            on item.maSP equals sp.maSP
                            select new
                            {
                                MãCT = item.maCTKM,
                                MãSP = item.maSP,
                                SPKhuyếnMãi = sp.tenSP,
                                TênKM = km.tenKM,
                                NgàyBD = item.ngayBD,
                                NgàyKT = item.ngayKT
                            };

            return ds;
        }
        //Load chi tiet khuyen mai theo ma sp
        public IQueryable LoadCTKhuyenMai(int maSP)
        {

            IQueryable ds = from item in Data.CTKhuyenMais
                            join km in Data.KhuyenMais
                            on item.maKM equals km.maKM

                            join sp in Data.SanPhams
                            on item.maSP equals sp.maSP 
                            where item.maSP == maSP && item.ngayBD < DateTime.Now && item.ngayKT > DateTime.Now
                            select new 
                            {
                                maCTKM = item.maCTKM,
                                tenSP = sp.tenSP,
                                KhuyenMai = item.KhuyenMai,
                                GiamGia = km.giamGia,
                                ngayBD = item.ngayBD,
                                ngayKT = item.ngayKT
                            };
            
            return ds;
        }
        // Ham kiem tra thoi gian trung lap
        static bool CheckOverlap((DateTime, DateTime) cu, (DateTime, DateTime) moi)
        {
           /* if(cu.Item1 >= moi.Item1 && moi.Item1 <= cu.Item2)
            {
                return false;
            }*/
           /* else if(cu.Item1 >= moi.Item2 &&  moi.Item2 <= cu.Item2)
            {
                return false;
            }*/
           /* else if (cu.Item1 <= moi.Item1 && moi.Item2 >= cu.Item2)
            {
                return false;
            }*/
            return true;
        }
        //Them CTKhuyenMai
        public bool ThemCTKhuyenMai(ET_CTKhuyenMai km)
        {
            try
            {
               /* IQueryable<CTKhuyenMai> dsSP = LoadCTKhuyenMai(km.MaSP.MaSP);
                foreach (CTKhuyenMai item in dsSP)
                {
                    ET_CTKhuyenMai ctkm = new ET_CTKhuyenMai {
                        NgayBD = DateTime.Parse(item.ngayBD.ToString()),
                        NgayKT = DateTime.Parse(item.ngayBD.ToString())
                    };
                   *//* if (CheckOverlap( (ctkm.NgayBD, ctkm.NgayKT), (km.NgayBD, km.NgayKT)))
                    {
                        return false;
                    }*//*
                }*/
                    CTKhuyenMai dm = new CTKhuyenMai
                {
                    maKM = km.MaKM.MaKM,
                    maSP = km.MaSP.MaSP,
                    tenSP = km.MaSP.TenSP,
                    ngayBD = km.NgayBD,
                    ngayKT = km.NgayKT
                };
                Data.CTKhuyenMais.InsertOnSubmit(dm);
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
        //Xoa CTKhuyenMai
        public bool XoaCTKhuyenMai(ET_CTKhuyenMai km)
        {
            try
            {
                var list = from item in Data.CTKhuyenMais
                           where item.maCTKM == km.MaCTKM 
                           select item;
                foreach (var item in list)
                {
                    Data.CTKhuyenMais.DeleteOnSubmit(item);
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
        //Sua CTKhuyenMai
        public bool SuaCTKhuyenMaiTheoKM(ET_CTKhuyenMai km)
        {
            try
            {
                var suaDM = Data.CTKhuyenMais.Single(CTKhuyenMai => CTKhuyenMai.maCTKM == km.MaCTKM) ;
                suaDM.maKM = km.MaKM.MaKM;
                suaDM.maSP = km.MaSP.MaSP;
                suaDM.ngayBD = km.NgayBD;
                suaDM.ngayKT = km.NgayKT;
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
