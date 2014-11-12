using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_an___Quan_ly_khach_san
{
    class Program
    {
        static void Main(string[] args)
        {
            KHACHSAN ks = new KHACHSAN();
            //danh sach chuc nang
            string giaoDien = "-----------------------------------\n";
            giaoDien += "1.Nhap thong tin phong\n";
            giaoDien += "2.Xoa phong\n";
            giaoDien += "3.Cap nhat thong tin phong\n";
            giaoDien += "4.Tim kiem phong\n";
            giaoDien += "5.Liet ke phong\n";
            giaoDien += "6.Nhap thong tin khach thue\n";
            giaoDien += "7.Xoa khach thue\n";
            giaoDien += "8.Cap nhat thong tin khach thue\n";
            giaoDien += "9.Tim kiem khach thue\n";
            giaoDien += "10.Liet ke khach thue\n";
            giaoDien += "11.Liet ke phong trong\n";
            giaoDien += "12.Tinh tong so giuong\n";
            giaoDien += "13.Liet ke phong theo gia giam dan\n";
            giaoDien += "14.Tinh doanh thu trong ngay\n";//luu y tinh tien ca ngay dau tien
            giaoDien += "15.Tinh so tien phai tra cua mot khach hang\n";//luu y tinh tien ca ngay dau tien
            giaoDien += "16.Save du lieu\n";
            giaoDien += "17.Load du lieu\n";
            giaoDien += "18.Thoat\n";
            giaoDien += "Chon chuc nang can thuc hien: ";

            bool kt = true;
            while (kt)
            {
                Console.Write(giaoDien);
                int chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1://them phong
                        ks.themPhong();
                        break;
                    case 2://xoa phong
                        Console.Write("Nhap ma phong can xoa: ");
                        string dkMaPhong = Console.ReadLine();
                        ks.xoaPhong(dkMaPhong);
                        break;
                    case 3://sua thong tin phong
                        Console.Write("Nhap ma phong can sua: ");
                        string dkMaPhong3 = Console.ReadLine();
                        bool kt3 = ks.capNhatPhong(dkMaPhong3);
                        if (kt3 == true)
                            Console.WriteLine("Cap nhat thanh cong");
                        else
                            Console.WriteLine("Khong tim thay phong");
                        break;
                    case 4://tim kiem phong
                        Console.Write("Nhap ten phong can tim: ");
                        string dkTenPhong = Console.ReadLine();
                        ks.timPhong(dkTenPhong);
                        break;
                    case 5://liet ke phong
                        ks.lietKePhong();
                        break;
                    case 6://them khach thue
                        ks.themKhachThue();
                        break;
                    case 7://xoa khach thue
                        Console.Write("Nhap cmnd khach thue phong can xoa: ");
                        string dkCmnd = Console.ReadLine();
                        ks.xoaPhong(dkCmnd);
                        break;
                    case 8://sua thong tin khach thue
                        Console.Write("Nhap cmnd khach thue phong can sua: ");
                        string dkCmnd8 = Console.ReadLine();
                        bool kt8 = ks.capNhatKhachThue(dkCmnd8);
                        if (kt8 == true)
                            Console.WriteLine("Cap nhat thanh cong");
                        else
                            Console.WriteLine("Khong tim thay sach");
                        break;
                    case 9://tim kiem khach thue
                        Console.Write("Nhap ten khach thue phong can tim: ");
                        string dkHoTen = Console.ReadLine();
                        ks.timKhachThue(dkHoTen);
                        break;
                    case 10://liet ke khach thue
                        ks.lietKeKhachThue();
                        break;
                    case 11://liet ke phong trong
                        Console.Write("Nhap ngay can tim: ");
                        DateTime ngayNhap = DateTime.Parse(Console.ReadLine());
                        ks.lietKePhongTrong(ngayNhap);
                        break;
                    case 12://tinh tong so giuong
                        string chuoi = string.Format("Tong so giuong trong khach san la {0}.", ks.tinhTongSoGiuong());
                        Console.WriteLine(chuoi);
                        break;
                    case 13://liet ke phong gia giam dan
                        ks.lietKePhongGiaGiamDan();
                        break;
                    case 14://tinh doanh thu trong ngay
                        Console.Write("Nhap ngay can tinh: ");
                        DateTime ngayNhap14 = DateTime.Parse(Console.ReadLine());
                        double doanhThu = ks.doanhThuTrongNgay(ngayNhap14);
                        Console.WriteLine(string.Format("Doanh thu trong ngay {0} la {1} D", ngayNhap14.ToShortDateString(), doanhThu));
                        break;
                    case 15://tinh so tien phai tra cua mot khach hang
                        Console.Write("Nhap cmnd khach hang: ");
                        string dkCmnd15 = Console.ReadLine();
                        double thanhTien = ks.tienPhaiTra(dkCmnd15);
                        if (thanhTien < 0)
                        {
                            Console.WriteLine("Khong tim thay ket qua.");
                        }
                        else
                        {
                            Console.WriteLine(string.Format("So tien phai tra cua khach hang {0} la {1} D", dkCmnd15, thanhTien));
                        }
                        break;
                    case 16://Save 
                        string duongDanPhong = "C:\\Users\\anh\\Google Drive\\Learning\\ĐH Khoa học Tự nhiên\\05.Phương pháp lập trình hướng đối tượng\\phong.txt";
                        string duongDanKhach = "C:\\Users\\anh\\Google Drive\\Learning\\ĐH Khoa học Tự nhiên\\05.Phương pháp lập trình hướng đối tượng\\khach thue.txt";
                        ks.luuDanhSachPhong(duongDanPhong);
                        ks.luuDanhSachKhachThue(duongDanKhach);
                        Console.WriteLine("Da luu");
                        break;
                    case 17://Load
                        string duongDanPhong14 = "C:\\Users\\anh\\Google Drive\\Learning\\ĐH Khoa học Tự nhiên\\05.Phương pháp lập trình hướng đối tượng\\phong.txt";
                        string duongDanKhach14 = "C:\\Users\\anh\\Google Drive\\Learning\\ĐH Khoa học Tự nhiên\\05.Phương pháp lập trình hướng đối tượng\\khach thue.txt";
                        ks.docDanhSachPhong(duongDanPhong14);
                        ks.docDanhSachKhachThue(duongDanKhach14);
                        Console.WriteLine("Da load");
                        break;
                    case 18://thoat
                        kt = false;
                        break;
                    default:
                        Console.WriteLine("Lenh khong hop le");
                        break;
                }
            }
        }
    }
}
