using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(num/10);  //DivideByZeroException

                try {
                    int[] a = new int[] { 1, 2, 3 };
                    Console.WriteLine(a[5]);   //Out of Bounds Exception
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("\n Inner :\n" +ex.Message);
                    Console.WriteLine("Exception at :"+ex.StackTrace);
                    Console.WriteLine("\n"+ex.Source);
                }

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace); //stores all data
                Console.WriteLine(ex.Source);
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Source);
            }


            catch (Exception ex) //base class for all exceptions
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Source);
            }
            finally
            {
                Console.WriteLine("\nProgram has ended");
            }


            Console.ReadLine();
        }


    }
}
