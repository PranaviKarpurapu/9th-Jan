using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnUseDefinedExceptions
{
    class Employee
    {
        string name;
        int empid;
        public int sal;

        public Employee() { }

        public Employee(string name, int empid, int sal)
        {
            this.name = name;
            this.empid = empid;
            this.sal = sal;
        }
    }
}
       
