using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOnAbstract
{
    public abstract class Student
    {
        public string name;
        public int stuid;
        public int grade;

        public Student(string name, int stuid, int grade)
        {
            this.name = name;
            this.stuid = stuid;
            this.grade = grade;

        }

        public abstract bool IsPassed(int grade);

    }

    class UnderGraduate : Student
    {
        public UnderGraduate(string name, int stuid, int grade) : base(name, stuid, grade) { }
        public override bool IsPassed(int grade)
        {
            if (grade > 70)
                return true;
            else
                return false;
        }
    }

        public class Graduate : Student
        {
            public Graduate(string name, int stuid, int grade) : base(name, stuid, grade) { }
            public override bool IsPassed(int grade)
            {
                if (grade > 70)
                    return true;
                else
                    return false;
            }


        }
    }


