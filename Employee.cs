using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public abstract class Employee
    {
       private string name;
       private string address;

        public string Name
        {
            set { name= value; }
            get { return name; }
        }

        public string Address
        {
            set { address= value; }
            get { return address; }
        }
        public Employee()
        {

        }

        public Employee(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public abstract double CalculateSalary();
    }
}
