//Kiem tra chan/le va am/duong
using System;


namespace Bai3 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Nhap so nguyen n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0 && n % 2 == 0)
            {
                Console.WriteLine("n la so nguyen duong chan");
            }
            else if (n < 0 && n % 2 == 0)
            {
                Console.WriteLine("n la so nguyen am chan");
            }
            else if (n < 0 && n % 2 == 1)
            {
                Console.WriteLine("n la so nguyen am le");
            }
            else Console.WriteLine("n la so nguyen duong le");
        }
    }
}