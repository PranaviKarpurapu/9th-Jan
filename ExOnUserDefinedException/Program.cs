using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOnUserDefinedException
{

    class TicketException : Exception
    {
        public TicketException(string s):base(s)
        {

        }
   }

    class Test
    {
        string name;
        int age;
        public void Accept()
        {
            
                Console.WriteLine("Enter Passenger Name :");
                name = Console.ReadLine();
                Console.WriteLine("Enter Age :");
                age = int.Parse(Console.ReadLine());
            
        }
       
                
            }
            
        
    
    class Program
    {
        static void Main(string[] args)
        {
            Passenger ps = new Passenger();
            Console.WriteLine("Enter no.of tickets");
            int not = int.Parse(Console.ReadLine());
                ps.Booking(not);

            Console.ReadKey();
            }
        }

    }

