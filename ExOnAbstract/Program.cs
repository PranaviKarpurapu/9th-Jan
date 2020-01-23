using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOnAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Id :");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Grade :");
            int grade = int.Parse(Console.ReadLine());
            Student st;
            Console.WriteLine("Enter your choice :");
            Console.WriteLine("1. UnderGraduate   2.Graduate");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                 st = new UnderGraduate(name,id,grade);
                    Console.WriteLine(st.IsPassed(grade));
                    break;
                case 2:
                   
                  st = new Graduate(name,id,grade);
                    Console.WriteLine(st.IsPassed(grade));
                    break;
                default :
                    break;
        }
            Console.ReadKey();
    }
    }
}
