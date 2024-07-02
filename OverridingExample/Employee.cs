using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingExample
{
    internal class Employee:Admin
    {
        int salary;
        internal void Accept(int salary)
        {
            this.salary = salary;
        }
        internal void display()
        {
            Console.WriteLine(salary.ToString());
        }
    }
}
