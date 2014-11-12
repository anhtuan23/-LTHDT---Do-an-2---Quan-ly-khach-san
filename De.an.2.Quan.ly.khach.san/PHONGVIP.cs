using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Do_an___Quan_ly_khach_san
{
    public class PHONGVIP : PHONG
    {
        //ham khoi tao
        public PHONGVIP() { }
        public PHONGVIP(string chuoi)
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
            return string.Format("Phong vip\t{0}\t{1}\t{2}\t{3}\n", this.maPhong, this.tenPhong, this.donGia, this.soGiuong);
        }
        public override void luu(StreamWriter boGhi)
        {
            boGhi.WriteLine(string.Format("v,{0},{1},{2},{3}", this.maPhong, this.tenPhong, this.donGia, this.soGiuong));
        }
        public override double donGiaNgay(DateTime ngay, System.Collections.ArrayList dsKhachThue)
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
            soNgay = ngay - nguoiThue.NgayThue; double giaTrongNgay = 0;
            int soNgayTinhTien = soNgay.Days + 1;//tinh tien ca ngay dau
            if (soNgayTinhTien < 2)
            {
                giaTrongNgay = this.donGia;
            }
            else if (soNgayTinhTien < 5)
            {
                giaTrongNgay = this.donGia * 0.8;
            }
            else
            {
                giaTrongNgay = this.donGia * 0.7;
            }
            return giaTrongNgay;
        }
        public override double tongSoTien(int soNgayTinhTien)
        {
            double thanhTien = 0;
            if (soNgayTinhTien < 2)
            {
                thanhTien = soNgayTinhTien * this.donGia;
            }
            else if (soNgayTinhTien < 5)
            {
                thanhTien = soNgayTinhTien * this.donGia + ((soNgayTinhTien - 1) * this.donGia * 0.8);
            }
            else
            {
                thanhTien = soNgayTinhTien * this.donGia + (3 * this.donGia * 0.8) + ((soNgayTinhTien - 4) * this.donGia * 0.7);
            }
            return thanhTien;
        }

    }
}
