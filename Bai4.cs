//Bang cuu chuong
using System;

namespace Bai4{
    class Program{
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 9 && n >= 1)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(n + " * " + i + " = " + (n * i));
                }
            }
            else Console.WriteLine("Vui long nhap lai so nguyen  n tu 1 den 9");
        }
    }
}