using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS_BUS
{
    public class BUS_KTLoi
    {
        public bool KTSo(string text)
        {
            int num;
            if(int.TryParse(text,out num))
            {
                return true;
            }
            return false;
        }
        public bool KTSoDT(string text) {
            int num;
            if(text.Count() >= 10 && text.Count() < 20) {
                if(KTSo(text))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
