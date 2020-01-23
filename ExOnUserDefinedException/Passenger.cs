using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOnUserDefinedException
{
    class Passenger
    {
        string name;
        int age;
        public Passenger() { }
        public Passenger(string name, int age)
        {
            this.name = name;
            this.age = age;
        }



        public void Booking(int ntickets)
        {


            if (ntickets > 2)
            {
                try
                {
                    throw new TicketException("Cannot book more than 2 tickets");
                }

                catch (TicketException te)
                {
                    Console.WriteLine(te.Message);
                }
            }
            else
            {

                Test t = new Test();
                for (int i = 0; i < 2; i++)
                {
                    t.Accept();
                }
                Console.WriteLine("\nTickets booked Successfully ");
            }
        }
    }
}

  
