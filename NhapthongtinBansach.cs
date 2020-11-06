using System;
using System.Collections;
using System.Text;

namespace Quanlicuahangsach
{
    class NhapthongtinBansach
    {
        public void NhapBanSach(ArrayList list)
        {
            list.Add(new Bansach(masach(),tensach(),gia(),soluong(),ngayban(),tenkh(),email()));
        }
        //masach, tensach, gia, soluong, ngayban, tenkh, email;
        public string ngayban()
        {
            Console.WriteLine("Nhap ngay ban: ");
            string ngayban = Console.ReadLine();
            return ngayban;
        }
        public string email()
        {
            Console.WriteLine("Nhap email: ");
            string email = Console.ReadLine();
            return email;
        }
        public string masach()
        {
            Console.WriteLine("Nhap ma sach : ");
            string masach = Console.ReadLine();
            return masach;

        }
        public string tensach()
        {
            Console.WriteLine("Nhap ten sach: ");
            string tensach = Console.ReadLine();
            return tensach;
        }
        public int gia()
        {
            Console.WriteLine("Nhap gia sach : ");
            int gia = int.Parse(Console.ReadLine());
            return gia;
        }
        public string tenkh()
        {
            Console.WriteLine("Nhap ten khach hang ");
            string tenkh = Console.ReadLine();
            return tenkh;
        }
        public int soluong()
        {
            Console.WriteLine("Nhap so luong: ");
            int soluong = int.Parse(Console.ReadLine());
            return soluong;

        }

    }
}
