using System;

namespace THCTDLLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien svA = new SinhVien();

            SinhVien svB = new SinhVien("123", "Huy", "CNTT", 1995, 9);

            SinhVien svC = new SinhVien(svB);
            svC.MaSo = "SV02";

            svA.XuatThongTin();
            svB.XuatThongTin();
            svC.XuatThongTin();
            Console.ReadKey();
        }
    }
}
