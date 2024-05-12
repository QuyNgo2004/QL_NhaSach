using QLNS_ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DAL
{
    public class DAl_CTNhaCungCap
    {
        DAL_DATA data = new DAL_DATA();
        DAL_SanPham sp = new DAL_SanPham();
        //Load CT nha cung cap
        public IQueryable LoadCTNhaCungCap()
        {

            IQueryable ds = from item in data.Data.NhaCCCTs
                            join sp in data.Data.SanPhams on item.maSP equals sp.maSP
                            select new { MaCT = item.maCTNCC, TênSảnPhẩm = sp.tenSP,SL = item.soLuong,NhàCungCấp = item.tenNCC,NgàyCC = item.ngayCC,GhiChú = item.ghiChu,MaSP = item.maSP};

            return ds;
        }
        //Them danh muc
        public bool ThemCTNhaCungCap(ET_CTNhaCC ct)
        {
            try
            {
                NhaCCCT dm = new NhaCCCT
                {
                    tenSP = ct.MaSP.TenSP,
                    tenNCC = ct.MaNCC.TenNCC,
                    maSP = ct.MaSP.MaSP,
                    maNCC = ct.MaNCC.MaNCC,
                    ngayCC = ct.NgayCC,
                    soLuong = ct.SL,
                    ghiChu = ct.GhiChu
                    
                };
                sp.SuaSLSanPham(ct.SL,ct.MaSP.MaSP);
                data.Data.NhaCCCTs.InsertOnSubmit(dm);
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
        // Xoa theo maSP
        public bool XoaCTNhaCungCapMaSP(int maSP)
        {
            try
            {
                var list = from item in data.Data.NhaCCCTs
                           where item.maSP == maSP
                           select item;
                foreach (var item in list)
                {
                    data.Data.NhaCCCTs.DeleteOnSubmit(item);
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
        //Xoa danh muc
        public bool XoaCTNhaCungCap(ET_CTNhaCC ct)
        {
            try
            {
                var list = from item in data.Data.NhaCCCTs
                           where item.maCTNCC == ct.MaCTNhaCC
                           select item;
                foreach (var item in list)
                {
                    
                    if(sp.SuaSLSanPham(-ct.SL, item.maSP)) { data.Data.NhaCCCTs.DeleteOnSubmit(item); }
                            
                            

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
        public bool SuaCTNhaCungCap(ET_CTNhaCC ct)
        {
            try
            {
                var suaDM = data.Data.NhaCCCTs.Single(NhaCCCT => NhaCCCT.maCTNCC == ct.MaCTNhaCC);
                suaDM.ngayCC = ct.NgayCC;
                suaDM.soLuong = ct.SL;
                suaDM.ghiChu = ct.GhiChu;
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
