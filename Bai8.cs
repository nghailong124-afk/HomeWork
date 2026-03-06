//tim kiem trong mang
using System;

namespace Bai8
{
    class Bai8
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Nhap so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int x = Convert.ToInt32(Console.ReadLine());
            int index = Array.IndexOf(arr, x);
            if (index == -1)
            {
                Console.WriteLine("Khong tim thay");
            }
            while (index != -1)
            {
                Console.WriteLine("Vi tri cua phan tu la: " + index);
                index = Array.IndexOf(arr, x, index + 1);
            }
        }
    }
}