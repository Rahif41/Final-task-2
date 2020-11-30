using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace department_faculty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Department d = new Department("CSE", "111");
            Faculty f = new Faculty("a", "222");
            Faculty f2 = new Faculty("b", "333");
            Faculty f3 = new Faculty("c", "444");
            Faculty f4 = new Faculty("d", "555");
            d.AddFaculty(f, f2, f3, f4);
            d.ShowAllFaculty();
            d.RemoveFaculty(f2);
            Console.WriteLine();
            d.ShowAllFaculty();

        }
    }
}