using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectMethods
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string Name, string Major, double Gpa)
        {
            name = Name;
            major = Major;
            gpa = Gpa;
        }

        public bool HasHonours()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
    }
}
