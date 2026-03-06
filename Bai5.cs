//Tinh tong day so 
using System;

namespace Bai5
{
    class Bai5
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Nhap so nguyen duong n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= n;i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            } Console.WriteLine(sum);
        }
    }
}