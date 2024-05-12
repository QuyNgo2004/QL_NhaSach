using QLNS_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BUS
{
    public class BUS_DonVi
    {
        DAL_DonVi donVi = new DAL_DonVi();
        public IQueryable LoadDonViTheoDM(string maDM)
        {
            return donVi.LoadTheLoaiDM(maDM);
        }
    }
}
