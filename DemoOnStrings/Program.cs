using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string str = "Welcome";
            Console.WriteLine(str.Length + "\n" + str.Replace("e", "g") + "\n" + str.ToLower());
            Console.WriteLine(str.Contains("me"));
            Console.WriteLine(String.Compare("Hello", "Hello"));
            string str2 = "WELCOME";
            string input = Console.ReadLine();
            Console.WriteLine(str.Equals(str2,StringComparison.InvariantCultureIgnoreCase));
            
            string[] data = input.Split(' ','/');
            foreach (string val in data)
              Console.WriteLine(val);

            int[] num2 = Array.ConvertAll(data, Convert.ToInt32);
            int[] num = new int[data.Length];
            for(int i=0;i<data.Length;i++)
            {
                num[i] = Convert.ToInt32(data[0]);
            }

            int k = 90;
            double d= 23.67;
            Console.WriteLine("k : " + k.ToString());
            Console.WriteLine("d : " + d.ToString());*/

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("dddd/MMMM/yyyy") + " "+dt.ToString("MMM,dd/MM/yyyy HH:mm:ss") + " ");


            int[] ix = new int[] { 1, 2, 3, 4 };
            Employee[] e = new Employee[3] {new Employee("Pranavi",48,80000),
                                            new Employee("Jaya",44,60000),
                                            new Employee("siri",41,40000)};

            foreach(Employee em in e)
            {
                Console.WriteLine(em.ToString());
            }
            Console.WriteLine("\n");


            /* List<Employee> elist = new List<Employee>();
             elist.Add(new Employee("Pranavi", 48, 80000));
             elist.Add(new Employee("Jaya", 44, 60000));
             elist.Add(new Employee("siri", 41, 40000));

             foreach (Employee el in elist)
             {
                 Console.WriteLine(el.ToString());
             }
             */

            Employee e1 = new Employee("def", 48, 80000);
            Employee e2 = new Employee("def", 47, 80000);
            if(e1.Equals(e2))
            {
                Console.WriteLine("Both are Same");
            }
            else
                Console.WriteLine("Both are not Same");

            Console.ReadKey();
        }
    }
}
















