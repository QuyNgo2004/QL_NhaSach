using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DAL
{
    public class DAL_SanPham
    {
        DAL_DATA data = new DAL_DATA();
        
       

        //Load san pham
        public IQueryable LoadSanPham()
        {
            IQueryable ds = from tl in data.Data.SanPhams
                            join tloai in data.Data.TheLoais
                            on tl.maTL equals tloai.maTL
                            join dv in data.Data.DonVis
                            on tl.maDV equals dv.maDV
                            join ncc  in data.Data.NhaCCs on tl.maNCC equals ncc.maNCC
                            where tl.tangKem == 1
                            select new { MãSP = tl.maSP, TênSP = tl.tenSP,/*NhàCC = ncc.tenNCC,*/
                                         ThểLoại = tloai.tenTL,ĐơnGiá = tl.giaSP,ĐơnVị = dv.donVi1,
                                         SLTồnKho = tl.SLTonKho,LàQuàTặng = tl.tangKem};

            return ds;
        }
        //Load san pham theo san pham
        public IQueryable LoadSanPhamDM(string maDM)
        {

            IQueryable ds = from tl in data.Data.SanPhams
                            join tloai in data.Data.TheLoais
                            on tl.maTL equals tloai.maTL
                            join dv in data.Data.DonVis
                            on tl.maDV equals dv.maDV
                            join dm in data.Data.DanhMucs
                            on tloai.maDM equals dm.maDM
                            join ncc in data.Data.NhaCCs on tl.maNCC equals ncc.maNCC
                            where dm.maDM == maDM && tl.tangKem == 1    
                            select new
                            {
                                MãSP = tl.maSP,
                                TênSP = tl.tenSP,
                                /*NhàCC = ncc.tenNCC,*/
                                ThểLoại = tloai.tenTL,
                                ĐơnGiá = tl.giaSP,
                                ĐơnVị = dv.donVi1,
                                SLTồnKho = tl.SLTonKho,
                                LàQuàTặng = tl.tangKem
                            };

            return ds;
        }
        //Them san pham
        public bool ThemSanPham(ET_SanPham SanPham)
        {

            /*if (SuaSanPham(SanPham))
            {
                return true;
            }*/
            try
            {

                SanPham tl = new SanPham
                {
                    tenSP = SanPham.TenSP,
                    maNCC = SanPham.MaNCC.MaNCC,
                    maTL = SanPham.MaTL.MaTL,
                    giaSP = SanPham.GiaSP,
                    maDV = SanPham.MaDV.MaDV,
                    SLTonKho =SanPham.SLTonKho,
                    tangKem = SanPham.TKem
                };
                data.Data.SanPhams.InsertOnSubmit(tl);
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
        //Xoa san pham
        public bool XoaSanPham(ET_SanPham sp)
        {
            try
            {

                var list = from item in data.Data.SanPhams
                           where item.maSP == sp.MaSP
                           select item;
                    
                    foreach (var item in list)
                    {
                        data.Data.SanPhams.DeleteOnSubmit(item);
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


        //Sua san pham
        public bool SuaSanPham(ET_SanPham sp)
        {
            try
            {
                var suaTL = data.Data.SanPhams.Single(SanPham => SanPham.maSP == sp.MaSP);
                suaTL.tenSP = sp.TenSP;
                suaTL.maNCC = sp.MaNCC.MaNCC;
                suaTL.maTL = sp.MaTL.MaTL;
                suaTL.maDV = sp.MaDV.MaDV;
                suaTL.giaSP = sp.GiaSP;
                suaTL.SLTonKho = sp.SLTonKho;
                suaTL.tangKem = 1;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { data.Data.SubmitChanges(); }
            return true;
        }
        public bool SuaSLSanPham(int SL,int MaSP)
        {
            try
            {
                var suaTL = data.Data.SanPhams.Single(SanPham => SanPham.maSP == MaSP);
                if(suaTL.SLTonKho + SL >= 0)
                {
                    suaTL.SLTonKho += SL;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { data.Data.SubmitChanges(); }
            return true;
        }
        public IQueryable TimMaSanPham(int MaSP)
        {
            IQueryable ds = from tl in data.Data.SanPhams
                            join tloai in data.Data.TheLoais
                            on tl.maTL equals tloai.maTL
                            join dv in data.Data.DonVis
                            on tl.maDV equals dv.maDV
                            join dm in data.Data.DanhMucs
                            on tloai.maDM equals dm.maDM
                            join ncc in data.Data.NhaCCs on tl.maNCC equals ncc.maNCC
                            where tl.maSP == MaSP && tl.tangKem == 1
                            select new
                            {
                                MãSP = tl.maSP,
                                TênSP = tl.tenSP,
                                NhàCC = ncc.tenNCC,
                                ThểLoại = tloai.tenTL,
                                ĐơnGiá = tl.giaSP,
                                ĐơnVị = dv.donVi1,
                                SLTồnKho = tl.SLTonKho,
                                //LàQuàTặng = tl.tangKem
                            };

            return ds;
        }
    }
}
