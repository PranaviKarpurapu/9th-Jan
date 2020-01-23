using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOnInterface
{
    interface IStudent
    {
        int stuid { get; set; }
        string name { get; set; }

        void ShowDetails();

    }
    class Resident : IStudent
    {

        int Stuid;
        string Name;

        /* One way of auto implementation
         
        int IStudent.stuid { get; set; }
        string IStudent.name { get; set; }

    */
        int IStudent.stuid { get { return Stuid; } set { Stuid = value; } }
        string IStudent.name { get { return Name; } set { Name = value; } }


        public Resident(int stuid, string name)
        {
            this.Stuid = stuid;
            this.Name = name;

        }
        public void ShowDetails()
        {
            Console.WriteLine("\n Student Id :" + this.Stuid + "\t Student Name :" + this.Name);
        }

    }
    class DayScholar : IStudent

    {

        int Stuid;
        string Name;

        /* One way of auto implementation
         
        int IStudent.stuid { get; set; }
        string IStudent.name { get; set; }

    */
        int IStudent.stuid { get { return Stuid; } set { Stuid = value; } }
        string IStudent.name { get { return Name; } set { Name = value; } }


        public DayScholar(int stuid, string name)
        {
            this.Stuid = stuid;
            this.Name = name;

        }
        public void ShowDetails()
        {
            Console.WriteLine("\n Student Id :"+this.Stuid + "\tStudent Name :  " + this.Name);
        }

    }
}

