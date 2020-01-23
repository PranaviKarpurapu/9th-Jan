using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnUseDefinedExceptions
{

    public class salaryException : Exception           //user defined exception inherits exception class 
    {
        public salaryException(string s) : base(s)     
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Baby", 78, 0);

            try
            {
                //creating object for user defined exception & passing argument to its constructor using throw
                if (emp.sal == 0) throw new salaryException("Salary cannot be zero");                 
                {

                }
            }
            catch(salaryException se)
            {
                Console.WriteLine(se.Message);
                Console.WriteLine(se.StackTrace);     //stores details in stacktrace
                Console.WriteLine(se.Source);
            }
            Console.ReadKey();
    }
    }
}
