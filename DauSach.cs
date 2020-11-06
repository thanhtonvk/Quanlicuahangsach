using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlicuahangsach
{
    class DauSach
    {
        private string maSach, tenSach, nXB, tacGia;
        private int soluong;
        private double gia;
        public DauSach()
        {

        }
        public DauSach(string masach, string tensach,string nxb,string tacgia,int soluong,double gia)
        {
            this.maSach = masach;
            this.tenSach = tensach;
            this.nXB = nxb;
            this.tacGia = tacgia;
            this.soluong = soluong;
            this.gia = gia;
        }
        public string MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string NXB { get => nXB; set => nXB = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public double Gia { get => gia; set => gia = value; }
        override
            public string ToString()
        {
            return maSach + "#" + tenSach + "#" + nXB + "#" + tacGia + "#" + soluong + "#" + gia;
        }
    }
}
