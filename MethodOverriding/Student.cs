using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Student : Person
    {
        int _age;
        string _name;
        public Student()
        {
            this._age = 20;
            this._name = "Le Minh Tuan";
        }
        public Student(int age)
        {
            this._age = age;
            this._name = "Le Minh Tuan";
        }

        public Student(string name)
        {
            this._name = name;
            this._age = 20;
        }

        public Student(int age, string name)
        {
            this._age = age;
            this._name = name;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(", Age: " + this._age + ", Name: " + this._name);
        }
    }
}
