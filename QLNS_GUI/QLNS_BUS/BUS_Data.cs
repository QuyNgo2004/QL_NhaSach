using QLNS_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BUS
{
    public class BUS_Data
    {
        DAL_DATA serve = new DAL_DATA();
        public BUS_Data() { }
        public bool LoadData() {
            return serve.LoadData();
        }
        public void SaveData(string ser) {
            serve.ThemDataBase(ser);
        }
    }
}
