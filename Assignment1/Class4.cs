using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Employee
    {
        int empid;
        string ename, designation;

        public Employee()
        {
            Console.WriteLine("In Default Constructor");
        }

        public Employee(int id, string name, string d)
        {
            empid = id;
            ename = name;
            designation = d;
        }

        public void Print()
        {
            Console.WriteLine("Empid= {0} Ename={1} Designation={2}", empid, ename, designation);
        }
    }
    class Class4
    {

        static void Main(string[] args)
        {
            Employee e = new Employee();
            Employee e1 = new Employee(121, "Mohit", "Enginer");
            e1.Print();
        }
    }
}
