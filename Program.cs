using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Buoi04
{
    internal class Program
    {

        public static void Main(string[] args) {
            NhanVien nv1 = new NhanVien("NV001", "Nguyen Van A", 2.34, 2020);
            nv1.showTT();

            NhanVien.capNhatMLTT(1900);

            NhanVien nv2 = new NhanVien("NV002", "Nguyen Van B", 2.34, 2020);
            nv2.showTT();
        }
    }
}
