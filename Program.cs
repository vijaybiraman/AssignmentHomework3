using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;
namespace HRAPP
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConfirmEmployee confirmEmployee = new ConfirmEmployee("Sushant","pune",30000.0,"manager");
            Console.WriteLine(confirmEmployee.Name+" "+confirmEmployee.Address+" "+confirmEmployee.Basicsalary+" "+confirmEmployee.Designation);
            Console.WriteLine("netSalary :"+confirmEmployee.CalculateSalary());
            Trainee trainee = new Trainee("Kamlesh","Mumbai",30,1000.0);
            Console.WriteLine(trainee.Name + " " + trainee.Address + " " + trainee.NoOfDays + " " + trainee.RatePerDay); ;
            Console.WriteLine("salary :"+trainee.CalculateSalary());
            Console.ReadLine();
        }
    }
}
