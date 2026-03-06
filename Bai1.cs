//Chuong trinh chao hoi don gian
using System;
namespace Bai1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Dien ten:");
            string name = Console.ReadLine();
            Console.WriteLine("Dien tuoi:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Xin chao, Toi ten la "+ name+", Toi "+age+" tuoi");
            if(age >= 18){
                Console.WriteLine("Bạn đã đủ 18 tuổi");
            }else Console.WriteLine("Bạn chưa đủ 18 tuổi.");
        }
    }
}