using System;
using System.Collections.Generic;
using System.Text;

namespace THCTDLLab1
{
    class SinhVien
    {
        //Data
        string maSo;
        string hoTen;
        string chuyenNganh;
        int namSinh;
        float diemTB;
        string loai;
        //Properties
        //get : doc (read), set: ghi (write)
        public string MaSo { get => maSo; set => maSo = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string ChuyenNganh { get => chuyenNganh; set => chuyenNganh = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public float DiemTB { get => diemTB; set => diemTB = value; }
        public string Loai { get => loai; }

        //Method
        //Ham khoi tao co 2 loai: co tham so va khong tham so
        #region Constructor
        public SinhVien()
        {
            this.maSo = "";
            this.hoTen = "";
            this.chuyenNganh = "";
            this.namSinh = 0;
            this.diemTB = 0;
            this.loai = "";
        }
        public SinhVien(string maSo, string hoTen, string chuyenNganh, int namSinh, float diemTB)
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.chuyenNganh = chuyenNganh;
            this.namSinh = namSinh;
            this.diemTB = diemTB;
            this.loai = XepLoai(diemTB);
        }
        //Ham khoi tao sao chep cac thuoc tinh cua 1 doi tuong (Ex: doi tuong sv)
        public SinhVien(SinhVien sv)
        {
            this.maSo = sv.maSo;
            this.hoTen = sv.hoTen;
            this.chuyenNganh = sv.chuyenNganh;
            this.namSinh = sv.namSinh;
            this.diemTB = sv.diemTB;
            this.loai = XepLoai(diemTB);
        }
        #endregion
        #region PhuongThucThanhVien
        public string XepLoai(float diemTB)
        {
            string xepLoai = "";
            if(diemTB < 5)
            {
                xepLoai = "Yeu";
            }
            else if(diemTB >5 && diemTB <8)
            {
                xepLoai = "Kha";
            }
            else if( diemTB > 8)
            {
                xepLoai = "Gioi";
            }
            return xepLoai;
        }
        public void Them()
        {
            Console.WriteLine("Nhap ma sv: ");
            maSo = Console.ReadLine();
            Console.WriteLine("Nhap ho ten sv: ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap chuyen nganh sv: ");
            chuyenNganh = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem TB: ");
            diemTB = float.Parse(Console.ReadLine());
            loai = XepLoai(diemTB);
        }
        public void XuatThongTin()
        {
            Console.WriteLine("Ma so sv: {0}, Ten sv {1}, Nam sinh {2}, Diem TB {3}, Xep Loai {4}", maSo, hoTen, namSinh, diemTB, loai);
        }
        #endregion
    }
}
