using System;

namespace ConsoleApp6
{
    internal class Student
    {
        // 1. Chỉ hiển thị tên (1 tham số)
        public void Display(string name)
        {
            Console.WriteLine($"Name: {name}");
        }

        // 2. Hiển thị tên + tuổi (2 tham số)
        public void Display(string name, int age)
        {
            Console.WriteLine($"Name: {name} - Age: {age}");
        }

        // 3. Hiển thị tên + tuổi + địa chỉ (3 tham số)
        public void Display(string name, int age, string address)
        {
            Console.WriteLine($"Name: {name} - Age: {age} - Address: {address}");
        }
    }
}