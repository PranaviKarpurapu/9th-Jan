using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnStrings
{
    class Employee
    {
        string name;
        int empid;
        int sal;

        public Employee() { }

        public Employee(string name,int empid,int sal)
        {
             this.name=name;
             this.empid=empid;
             this.sal=sal;

            //Console.WriteLine("\nName : "+this.name+"\nEmp ID : "+this.empid+"\nSalary : "+this.sal);
        }
        public override string ToString()
        {
            return "\nName : " + this.name + "\nEmp ID : " + this.empid + "\nSalary : " + this.sal;
        }


        public override bool Equals(object obj)
        {
            Employee temp = (Employee)obj;
            if (this.empid == temp.empid && this.name == temp.name && this.sal == temp.sal)
                return true;
            else
                return false;
        }
    }
}
