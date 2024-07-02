using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingExample
{
    internal class Admin
    {
        int id;
        String name;
        
        void Accept(int id,String name)
        {
            this.id=id;
            this.name=name;
        }
        void display()
        {
            Console.WriteLine("Id is {0} name is {1}",id,name);
        }
    }
}
