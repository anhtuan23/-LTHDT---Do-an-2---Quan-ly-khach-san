using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Do_an___Quan_ly_khach_san
{
    public class KHACHTHUE
    {
        //thanh phan du lieu
        private string cmnd;
        private string hoTen;
        private DateTime ngayThue;
        private DateTime ngayTra;
        private string maPhongThue;
        //ham nhap xuat
        public string HoTen
        {
            get
            {
                return this.hoTen;
            }
        }
        public string Cmnd
        {
            get
            {
                return this.cmnd;
            }
        }
        public string MaPhongThue
        {
            get
            {
                return this.maPhongThue;
            }
        }
        public DateTime NgayThue
        {
            get
            {
                return this.ngayThue;
            }
        }
        public DateTime NgayTra
        {
            get
            {
                return this.ngayTra;
            }
        }
        //ham khoi tao
        public KHACHTHUE()
        {
            this.ngayThue = new DateTime();
            this.ngayTra = new DateTime();
        }
        public KHACHTHUE(string s)
        {
            this.ngayThue = new DateTime();
            this.ngayTra = new DateTime();
            string[] thongTin = s.Split(',');
            this.cmnd = thongTin[0];
            this.hoTen = thongTin[1];
            this.ngayThue = DateTime.Parse(thongTin[2]);
            this.ngayTra = DateTime.Parse(thongTin[3]);
            this.maPhongThue = thongTin[4];

        }


        //thanh phan xu ly
        public void themKhachThue(string ghiChu = "Nhap thong tin khach thue: ")
        {
            Console.WriteLine(ghiChu);
            Console.Write("Nhap so CMND khach thue: ");
            this.cmnd = Console.ReadLine();
            Console.Write("Nhap ho ten khach thue: ");
            this.hoTen = Console.ReadLine();
            Console.Write("Nhap ngay thue: ");
            this.ngayThue = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap ngay tra: ");
            this.ngayTra = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap ma so phong thue: ");
            this.maPhongThue = Console.ReadLine();
        }
        public string xuatKhachThue()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\n", this.cmnd, this.hoTen, this.ngayThue.ToShortDateString(), this.ngayTra.ToShortDateString(), this.maPhongThue);
        }
        public void capNhatKhachThue(string ghiChu = "Cap nhat thong tin khach thue: ")
        {
            Console.WriteLine(ghiChu);
            Console.Write("Nhap ho ten khach thue: ");
            this.hoTen = Console.ReadLine();
            Console.Write("Nhap ngay thue: ");
            this.ngayThue = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap ngay tra: ");
            this.ngayTra = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap ma phong thue: ");
            this.maPhongThue = Console.ReadLine();
        }
        public void luu(StreamWriter boGhi)
        {
            boGhi.WriteLine(string.Format("{0},{1},{2},{3},{4}", this.cmnd, this.hoTen, this.ngayThue.ToString("yyyy/MM/dd"), this.ngayTra.ToString("yyyy/MM/dd"), this.maPhongThue));
        }
    }
}
