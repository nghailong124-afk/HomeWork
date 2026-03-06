//Mang va so nguyen
using System;
using System.Security.Cryptography;

namespace Bai7
{
    class Bai7
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            double answer = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                answer = arr.Sum() / n;
            }
            Console.WriteLine("Phan tu lon nhat la: " + arr.Max());
            Console.WriteLine("Phan tu nho nhat la: " + arr.Min());
            Console.WriteLine("Tong cac phan tu la: " + arr.Sum());
            Console.WriteLine("Trung binh cong cac phan tu la: " + answer);
        }
    }
}