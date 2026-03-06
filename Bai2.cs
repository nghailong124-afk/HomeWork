using System;

namespace Bai2 {
    class Program {
        static void Main(string[] args) {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tong a va b la: " + (a + b));
            Console.WriteLine("Hieu a va b la: " + (a - b));
            Console.WriteLine("Tich a va b la: " + (a * b));
            if (b == 0)
            {
                Console.WriteLine("Khong the chia");
            }
            else Console.WriteLine("Thuong cua a va b la: " + (a / b));
        }
    }
}