using System;

namespace ConsoleApp7
{
    // Lớp cha
    internal class Employee
    {
        public virtual double CalculateSalary()
        {
            return 0; // Mức lương mặc định
        }
    }

    // Lớp con Manager
    internal class Manager : Employee
    {
        public override double CalculateSalary()
        {
            return 15000;
        }
    }

    // Lớp con Developer
    internal class Developer : Employee
    {
        public override double CalculateSalary()
        {
            return 10000;
        }
    }

    // Lớp con Tester
    internal class Tester : Employee
    {
        public override double CalculateSalary()
        {
            return 8000;
        }
    }
}