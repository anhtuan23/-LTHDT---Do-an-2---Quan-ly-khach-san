using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Do_an___Quan_ly_khach_san
{
    public class KHACHSAN
    {
        //thanh phan du lieu
        private string tenKhachSan;
        private ArrayList dsPhong;
        private ArrayList dsKhachThue;
        public KHACHSAN()
        {
            dsPhong = new ArrayList();
            dsKhachThue = new ArrayList();
        }

        //thanh phan xu ly
        //cac chuc nang ve PHONG
        public void themPhong()
        {
            PHONG p;
            Console.Write("Phong thuong hay phong VIP (t/v)");
            string loaiPhong = Console.ReadLine();
            loaiPhong.ToLower();
            if (loaiPhong == "t")
            {
                p = new PHONGTHUONG();
                p.nhapPhong("Nhap thong tin phong thuong");
                this.dsPhong.Add(p);
            }
            else if (loaiPhong == "v")
            {
                p = new PHONGVIP();
                p.nhapPhong("Nhap thong tin phong VIP");
                this.dsPhong.Add(p);
            }
            else
            {
                Console.WriteLine("Lenh khong hop le");
            }
        }
        public void lietKePhong()
        {
            string kq = "Danh sach cac phong trong khach san:\n";
            foreach (PHONG p in this.dsPhong)
            {
                kq += p.xuatPhong() + '\n';
            }
            Console.WriteLine(kq);
        }
        public void timPhong(string dieuKienTenPhong)
        {
            ArrayList kq = new ArrayList();
            foreach (PHONG p in this.dsPhong)
            {
                if (p.TenPhong.Contains(dieuKienTenPhong) == true)
                    kq.Add(p);
            }
            //liet ke ket qua tim kiem
            string chuoi = string.Empty;
            if (kq.Count == 0)
            {
                chuoi = "Khong tim thay ket qua.";
            }
            else
            {
                chuoi = "Danh sach phong tim duoc:\n";
                foreach (PHONG p in kq)
                {
                    chuoi += p.xuatPhong() + '\n';
                }
            }
            Console.WriteLine(chuoi);
        }
        public void xoaPhong(string dkMaPhong)
        {
            foreach (PHONG p in this.dsPhong)
            {
                if (p.MaPhong == dkMaPhong)
                {
                    this.dsPhong.Remove(p);
                    break;
                }
            }
        }
        public bool capNhatPhong(string dkMaPhong)
        {
            foreach (PHONG p in this.dsPhong)
            {
                if (p.MaPhong == dkMaPhong)
                {
                    p.capNhatPhong();
                    return true;
                }
            }
            return false;
        }
        public void luuDanhSachPhong(string duongDan)
        {
            StreamWriter boGhi = new StreamWriter(duongDan);
            boGhi.WriteLine(this.dsPhong.Count);
            foreach (PHONG p in this.dsPhong)
            {
                p.luu(boGhi);
            }
            boGhi.Close();
        }
        public void docDanhSachPhong(string duongDan)
        {
            StreamReader boDoc = new StreamReader(duongDan);
            int n = int.Parse(boDoc.ReadLine());
            ArrayList dsPhong = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                string docDuoc = boDoc.ReadLine();
                if (docDuoc[0] == 't')
                {
                    PHONG p = new PHONGTHUONG(docDuoc);
                    this.dsPhong.Add(p);
                }
                else
                {
                    PHONG p = new PHONGVIP(docDuoc);
                    this.dsPhong.Add(p);

                }
            }
            boDoc.Close();
        }

        //cac chuc nang ve KHACH THUE
        public void themKhachThue()
        {
            KHACHTHUE k = new KHACHTHUE();
            k.themKhachThue("Nhap thong tin khach thue: ");
            this.dsKhachThue.Add(k);
        }
        public void lietKeKhachThue()
        {
            string kq = "Danh sach cac khach thue phong trong khach san:\n";
            foreach (KHACHTHUE k in this.dsKhachThue)
            {
                kq += k.xuatKhachThue() + '\n';
            }
            Console.WriteLine(kq);
        }
        public void timKhachThue(string dieuKien)
        {
            ArrayList kq = new ArrayList();
            foreach (KHACHTHUE k in this.dsKhachThue)
            {
                if (k.HoTen.Contains(dieuKien) == true)
                {
                    kq.Add(k);
                }
            }
            //liet ke ket qua tim kiem
            string chuoi = string.Empty;
            if (kq.Count == 0)
            {
                chuoi = "Khong tim thay ket qua.";
            }
            else
            {
                chuoi = "Danh sach khach thue tim duoc:\n";
                foreach (KHACHTHUE k in kq)
                {
                    chuoi += k.xuatKhachThue() + '\n';
                }
            }
            Console.WriteLine(chuoi);
        }
        public void xoaKhachThue(string dkCmnd)
        {
            foreach (KHACHTHUE k in this.dsKhachThue)
            {
                if (k.Cmnd == dkCmnd)
                {
                    this.dsKhachThue.Remove(k);
                    break;
                }
            }
        }
        public bool capNhatKhachThue(string dkCmnd)
        {
            foreach (KHACHTHUE k in this.dsKhachThue)
            {
                if (k.Cmnd == dkCmnd)
                {
                    k.capNhatKhachThue();
                    return true;
                }
            }
            return false;
        }
        public void luuDanhSachKhachThue(string duongDan)
        {
            StreamWriter boGhi = new StreamWriter(duongDan);
            boGhi.WriteLine(this.dsKhachThue.Count);
            foreach (KHACHTHUE k in this.dsKhachThue)
            {
                k.luu(boGhi);
            }
            boGhi.Close();
        }
        public void docDanhSachKhachThue(string duongDan)
        {
            StreamReader boDoc = new StreamReader(duongDan);
            int n = int.Parse(boDoc.ReadLine());
            ArrayList dsKhachThue = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                string docDuoc = boDoc.ReadLine();
                KHACHTHUE k = new KHACHTHUE(docDuoc);
                this.dsKhachThue.Add(k);
            }
            boDoc.Close();
        }

        //cac chuc nang khac
        public void lietKePhongTrong(DateTime ngay)
        {
            string kq = "Danh sach cac phong trong hien tai:\n";
            //lap danh sach cac phong da duoc thue
            string phongCoKhach = string.Empty;
            foreach (KHACHTHUE k in this.dsKhachThue)
            {
                if (k.NgayThue <= ngay && k.NgayTra >= ngay)
                {
                    phongCoKhach += k.MaPhongThue + ',';
                }
            }
            foreach (PHONG p in this.dsPhong)
            {
                if (phongCoKhach.Contains(p.MaPhong) == false)
                {
                    kq += p.xuatPhong() + '\n';
                }
            }
            Console.WriteLine(kq);
        }
        public int tinhTongSoGiuong()
        {
            int kq = 0;
            foreach (PHONG p in this.dsPhong)
            {
                kq += p.SoGiuong;
            }
            return kq;
        }
        public void lietKePhongGiaGiamDan()
        {
            string kq = "Danh sach cac phong theo thu tu gia giam dan:\n";
            List<PHONG> lPhong = new List<PHONG>();
            foreach (PHONG p in dsPhong)
            {
                lPhong.Add(p);
            }
            List<PHONG> daXep = lPhong.OrderBy(a => -a.DonGia).ToList();
            foreach (PHONG p in daXep)
            {
                kq += p.xuatPhong() + "\n";
            }
            Console.WriteLine(kq);
        }
        public double doanhThuTrongNgay(DateTime ngay)
        {
            double doanhThu = 0;
            string phongCoKhach = string.Empty;
            foreach (KHACHTHUE k in this.dsKhachThue)
            {
                if (k.NgayThue <= ngay && k.NgayTra >= ngay)
                {
                    phongCoKhach += k.MaPhongThue + ',';
                }
            }
            foreach (PHONG p in this.dsPhong)
            {
                if (phongCoKhach.Contains(p.MaPhong) == true)
                {
                    doanhThu += p.donGiaNgay(ngay, this.dsKhachThue);
                }
            }
            return doanhThu;
        }
        public double tienPhaiTra(string dkCmnd)
        {
            KHACHTHUE k = new KHACHTHUE();
            bool timThay = false;
            foreach (KHACHTHUE t in this.dsKhachThue)
            {
                if (t.Cmnd == dkCmnd)
                {
                    k = t;
                    timThay = true;
                    break;
                }
            }
            if (timThay == false)
            {
                return -1;
            }
            double kq = 0;
            TimeSpan soNgayThue = k.NgayTra - k.NgayThue;
            foreach (PHONG p in this.dsPhong)
            {
                if (p.MaPhong == k.MaPhongThue)
                {
                    kq = p.tongSoTien(soNgayThue.Days + 1);//tinh tien ca ngay dau tien
                    break;
                }
            }
            return kq;
        }
    }
}
