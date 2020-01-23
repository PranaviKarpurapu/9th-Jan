using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOnInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Id :");
            int id = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter your choice :");
            Console.WriteLine("1. Resident   2.DayScholar");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Resident re = new Resident(id,name);
                    re.ShowDetails();
                    break;
                case 2:
                    DayScholar ds = new DayScholar(id, name);
                    ds.ShowDetails();

                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}



