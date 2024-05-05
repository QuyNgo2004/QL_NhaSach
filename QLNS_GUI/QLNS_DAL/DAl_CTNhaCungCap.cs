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
        //Load CT nha cung cap
        public IQueryable LoadCTNhaCungCap()
        {

            IQueryable ds = from item in data.Data.NhaCCCTs select item;

            return ds;
        }
        //Them danh muc
        public bool ThemCTNhaCungCap(ET_CTNhaCC ct)
        {
            try
            {
                NhaCCCT dm = new NhaCCCT
                {
                    maCTNCC = ct.MaCTNhaCC,
                    maSP = ct.MaSP.MaSP,
                    maNCC = ct.MaNCC.MaNCC,
                    ngayCC = ct.NgayCC,
                    soLuong = ct.SL,
                    ghiChu = ct.GhiChu
                };
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
        //Sua danh muc
        public bool SuaCTNhaCungCap(ET_CTNhaCC ct)
        {
            try
            {
                var suaDM = data.Data.NhaCCCTs.Single(NhaCCCT => NhaCCCT.maCTNCC == ct.MaCTNhaCC);
                suaDM.maSP = ct.MaSP.MaSP;
                suaDM.maNCC = ct.MaNCC.MaNCC;
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
