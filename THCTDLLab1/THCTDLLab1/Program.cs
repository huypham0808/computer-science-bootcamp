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

            svA.XuatThongTin();
            svB.XuatThongTin();
            svC.XuatThongTin();
            Console.ReadKey();
        }
    }
}
