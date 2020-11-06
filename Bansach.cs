using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlicuahangsach
{
    class Bansach
    {
        private string masach, tensach, ngayban, tenkh, email;
        private int gia, soluong;
        public Bansach()
        {

        }
        public Bansach(string masach, string tensach, int gia, int soluong, string ngayban, string tenkh, string email)
        {
            this.masach = masach;
            this.tenkh = tenkh;
            this.tensach = tensach;
            this.gia = gia;
            this.soluong = soluong;
            this.ngayban = ngayban;
            this.email = email;
        }
        override
            public string ToString()
        {
            return masach + "#" + tensach + "#" + gia + "#" + soluong + "#" + ngayban + "#" + tenkh + "#" + email;
        }
        public string Masach { get => masach; set => masach = value; }
        public string Tensach { get => tensach; set => tensach = value; }
        public int Gia { get => gia; set => gia = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Ngayban { get => ngayban; set => ngayban = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Email { get => email; set => email = value; }
    }
}
