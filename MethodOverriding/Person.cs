using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Person
    {
        string _gt;
        public Person()
        {
            this._gt = "nam";
        }
        public virtual void Display()
        {
            Console.Write("Gioi tinh: " + this._gt);
        }
    }
}
   
