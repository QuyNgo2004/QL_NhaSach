using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_DAL
{
    public class DAL_DATA
    {
        QLNhaSachDataContext data = new QLNhaSachDataContext();

        public QLNhaSachDataContext Data { get => data; set => data = value; }
    }
}
