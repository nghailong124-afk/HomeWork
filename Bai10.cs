using System;
using System.Security.Principal;

namespace bai10
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();
            Console.WriteLine("Nhap so luong sinh vien: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Student s = new Student();
                Console.WriteLine("Nhap thong tin sinh vien: ");
                Console.Write("Nhap ID sinh vien: ");
                s.Id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap ten sinh vien: ");
                s.Name = Console.ReadLine();
                Console.Write("Nhap tuoi sinh vien: ");
                s.Age = Convert.ToInt32(Console.ReadLine());
                student.Add(s);
            }
            Console.WriteLine("Danh sach sinh vien:");
            foreach (Student s in student)
            {
                Console.WriteLine(s.Id + "-" + s.Name + "-" + s.Age);
            }
            Console.WriteLine("Danh sach sinh vien tren 18 tuoi: ");
            foreach (Student s in student)
            {
                if (s.Age >= 18)
                {
                    Console.WriteLine(s.Id + "-" + s.Name + "-" + s.Age);
                }
            }
        }
    }
}