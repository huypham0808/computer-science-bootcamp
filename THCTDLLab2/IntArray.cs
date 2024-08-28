using System;
using System.Collections.Generic;
using System.Text;

namespace THCTDLLab2
{
    class IntArray
    {
        //Properties
        int[] arr;
        int n;

        public int[] Arr { get => arr; set => arr = value; }
        public int N { get => n; set => n = (value>=0 && value <=1000000? value: 0); }
        //Constructor
        public IntArray()
        {
            N = 0;
            arr = new int[N];
        }
        public IntArray(int k) // Truyen vao k phan tu => phat sinh ngau nhien k phan tu cho mang
        {
            Random rd = new Random();
            N = k;
            arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = rd.Next(0, 201); //Phat sinh gia tri tu 0 - 200
            }
        }
        public IntArray(int[]a)
        {

        }
        public IntArray(IntArray obj)
        {

        }
        //Method
        public void Nhap()
        {

        }

        public void Xuat()
        {

        }

    }
}
