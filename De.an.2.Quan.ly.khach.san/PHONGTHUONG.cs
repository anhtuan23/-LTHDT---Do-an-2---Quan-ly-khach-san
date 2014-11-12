using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Do_an___Quan_ly_khach_san
{
    public class PHONGTHUONG : PHONG
    {
        //ham khoi tao
        public PHONGTHUONG() { }
        public PHONGTHUONG(string chuoi)
        {
            string[] thongTin = chuoi.Split(',');
            this.maPhong = thongTin[1];
            this.tenPhong = thongTin[2];
            this.donGia = int.Parse(thongTin[3]);
            this.soGiuong = int.Parse(thongTin[4]);
        }


        //thanh phan xu ly
        public override string xuatPhong()
        {
            return string.Format("Phong thuong\t{0}\t{1}\t{2}\t{3}\n", this.maPhong, this.tenPhong, this.donGia, this.soGiuong);
        }
        public override void luu(StreamWriter boGhi)
        {
            boGhi.WriteLine(string.Format("t,{0},{1},{2},{3}", this.maPhong, this.tenPhong, this.donGia, this.soGiuong));
        }
        public override double donGiaNgay(DateTime ngay, ArrayList dsKhachThue)
        {
            TimeSpan soNgay = new TimeSpan();
            KHACHTHUE nguoiThue = new KHACHTHUE();
            foreach (KHACHTHUE k in dsKhachThue)
            {
                if (k.MaPhongThue == this.maPhong)
                {
                    nguoiThue = k;
                    break;
                }
            }
            soNgay = ngay - nguoiThue.NgayThue;
            int soNgayTinhTien = soNgay.Days + 1;//tinh tien ca ngay dau
            double giaTrongNgay = 0;
            if (soNgayTinhTien < 3)
            {
                giaTrongNgay = this.DonGia;
            }
            else
            {
                giaTrongNgay = this.donGia * 0.9;
            }
            return giaTrongNgay;
        }
        public override double tongSoTien(int soNgayTinhTien)
        {
            double thanhTien = 0;
            if (soNgayTinhTien < 3)
            {
                thanhTien = soNgayTinhTien * this.DonGia;
            }
            else
            {
                thanhTien = (2 * this.donGia) + ((soNgayTinhTien - 2) * this.donGia * 0.9);
            }
            return thanhTien;
        }
    }
}
