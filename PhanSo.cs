using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Buoi04
{
    internal class PhanSo
    {
        private int tuSo;
        private int mauSo;

        public PhanSo()
        {
            mauSo = 1;
        }

        public PhanSo(int ts, int ms) {
            tuSo = ts;
            mauSo = ms;
        }

        public PhanSo(PhanSo phanSo)
        {
            tuSo = phanSo.tuSo;
            mauSo = phanSo.mauSo;
        }

        public PhanSo cong(PhanSo ps)
        {
            PhanSo tmp = new PhanSo(); 
            tmp.tuSo = this.tuSo * ps.mauSo + this.mauSo * ps.tuSo;
            tmp.mauSo = this.mauSo * ps.mauSo;
            return tmp;
        }

        public PhanSo cong(int x)
        {
            PhanSo tmp = new PhanSo();
            tmp.tuSo = this.mauSo * x + this.tuSo;
            tmp.mauSo = this.mauSo;
            return tmp;
        }

    }
}
