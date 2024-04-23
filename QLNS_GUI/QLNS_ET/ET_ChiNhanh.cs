using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_ET
{
    public class ET_ChiNhanh
    {
        string maCN, tenCN ,diaChi;

        public ET_ChiNhanh()
        {
        }

        public ET_ChiNhanh(string maCN, string tenCN, string diaChi)
        {
            this.MaCN = maCN;
            this.TenCN = tenCN;
            this.DiaChi = diaChi;
        }

        public string MaCN { get => maCN; set => maCN = value; }
        public string TenCN { get => tenCN; set => tenCN = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
