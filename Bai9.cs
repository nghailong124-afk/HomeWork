//Kiem tra so nguyen to
using System;

namespace Bai9
{
    class Bai9
    {
        static void IsPrime(int n)
        {
            if (n < 2)
            {
                Console.WriteLine(n +" khong phai so nguyen to");
            }
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 1)
                {
                    Console.WriteLine(n +" la so nguyen to");
                }
                else Console.WriteLine(n +  " khong phai so nguyen to");
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            IsPrime(n);
        }
    }
}