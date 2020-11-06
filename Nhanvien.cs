using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlicuahangsach
{
    class Nhanvien
    {
        private string manv, tennv, ngaysinh, quequan, sdt;
        public Nhanvien()
        {

        }
        public Nhanvien(string manv, string tennv, string ngaysinh, string quequan, string sdt)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.ngaysinh = ngaysinh;
            this.quequan = quequan;
            this.sdt = sdt;
        }
        override
            public string ToString()
        {
            return manv + "#" + tennv + "#" + ngaysinh + "#" + quequan + "#" + sdt;
        }
        public string Manv { get => manv; set => manv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Quequan { get => quequan; set => quequan = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
