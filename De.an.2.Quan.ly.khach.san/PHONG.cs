using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Do_an___Quan_ly_khach_san
{
    public class PHONG
    {
        //thanh phan du lieu
        protected string maPhong;
        protected string tenPhong;
        protected int donGia;
        protected int soGiuong;
        //ham nhap xuat
        public string MaPhong
        {
            get
            {
                return this.maPhong;
            }
        }
        public string TenPhong
        {
            get
            {
                return this.tenPhong;
            }
        }
        public int SoGiuong
        {
            get
            {
                return soGiuong;
            }
        }
        public int DonGia
        {
            get
            {
                return this.donGia;
            }
        }
        //ham khoi tao
        public PHONG() { }
        //public virtual PHONG(string chuoi) { }



        //thanh phan xu ly
        public void nhapPhong(string ghiChu = "Nhap thong tin phong: ")
        {
            Console.WriteLine(ghiChu);
            Console.Write("Nhap ma phong: ");
            this.maPhong = Console.ReadLine();
            Console.Write("Nhap ten phong: ");
            this.tenPhong = Console.ReadLine();
            Console.Write("Nhap don gia phong: ");
            this.donGia = int.Parse(Console.ReadLine());
            Console.Write("Nhap so luong giuong: ");
            this.soGiuong = int.Parse(Console.ReadLine());
        }
        public virtual string xuatPhong()
        {
            return null;
        }
        public void capNhatPhong(string ghiChu = "Cap nhat thong tin phong: ")
        {
            Console.WriteLine(ghiChu);
            Console.Write("Nhap ten phong: ");
            this.tenPhong = Console.ReadLine();
            Console.Write("Nhap don gia phong: ");
            this.donGia = int.Parse(Console.ReadLine());
            Console.Write("Nhap so luong giuong: ");
            this.soGiuong = int.Parse(Console.ReadLine());
        }
        public virtual void luu(StreamWriter boGhi)
        {
        }
        public virtual double donGiaNgay(DateTime ngay, ArrayList dsKhachThue)
        {
            return 0;
        }
        public virtual double tongSoTien(int soNgay)
        {
            return 0;
        }
    }
}
