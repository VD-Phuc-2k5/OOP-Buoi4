using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace OOP_Buoi04
{
    // Luong nhan vien = LCB * (1 + he so phu cap tham nien)
    // LCB = He so luong * Muc luong toi thieu (MLTT)
    // he so phu cap tham nien (HSPCTN) = (nam hien tai - NVL) / 100
    // MLTT = 1800
    class NhanVien
    {
        private string maNV = String.Empty;
        private string hoTen = string.Empty;
        private double heSoLg;
        private int namVaoLam;
        public static long MLTT = 1800;

        static NhanVien()
        {
            MLTT = 1800;
        }

        NhanVien() { }

        NhanVien(NhanVien obj) {
            this.maNV = obj.maNV;
            this.hoTen = obj.hoTen;
            this.heSoLg = obj.heSoLg;
            this.namVaoLam = obj.namVaoLam;
        }
        public NhanVien(string maNV, string hoTen, double heSoLg, int namVaoLam)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.heSoLg = heSoLg;
            this.namVaoLam = namVaoLam;
        }

        public void capNhatMLTT(long mltt)
        {
            MLTT = mltt;
        }

        public double tinhLuong() {
            double lcb = heSoLg * MLTT;
            double hspctm = (DateTime.Now.Year - namVaoLam) / 100.0;
            return lcb * (1 + hspctm);
        }

        public void showTT()
        {
            Console.WriteLine($"{maNV} {hoTen} {heSoLg} {namVaoLam} {tinhLuong()}");
        }
    }
}
