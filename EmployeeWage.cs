using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmployeeWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private List<CompanyEmpWage> CompanywageArr;

        public EmployeeWage()
        {
            CompanywageArr = new List<CompanyEmpWage>();
        }
        public void addCompanies(string company, int Wage_Per_Hour, int Max_Days_IN_Month, int Max_HrsInMonth)
        {
            CompanyEmpWage Emp = new CompanyEmpWage(company, Wage_Per_Hour, Max_Days_IN_Month, Max_HrsInMonth);
            this.CompanywageArr.Add(Emp);

        }

        public void EmpComputation()
        {
            foreach (CompanyEmpWage Emp in this.CompanywageArr)
            {
                Emp.setEmpWage(this.EmpComputation(Emp));
                Console.WriteLine(Emp.Return());
            }
        }


        private int EmpComputation(CompanyEmpWage emp)
        {
            int empHour = 0;
            int totalHours = 0;
            int totalDays = 0;
            int totalSallery = 0;
            Console.WriteLine();
            Console.WriteLine("---------" + emp.company + "");

            while (totalHours <= emp.Max_HrsInMonth && totalDays <= emp.Max_Days_IN_Month)
            {
                Random R = new Random();
                int empCheck = R.Next(3);
                totalDays++;
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        {
                            empHour = 8;
                            totalSallery = emp.Wage_Per_Hour * empHour;
                            break;
                        }
                    case IS_PART_TIME:
                        {
                            empHour = 4;
                            totalSallery = emp.Wage_Per_Hour * empHour;
                            break;
                        }
                    default:
                        {
                            empHour = 0;
                            totalSallery = emp.Wage_Per_Hour * empHour;
                            break;
                        }
                }
                totalHours = (totalHours + empHour);
                if (totalHours <= emp.Max_HrsInMonth)
                {
                    emp.sallery += totalSallery;

                    Console.WriteLine("Day# : " + totalDays + " =>  emp Hrs : " + empHour + " =>  EmpWage: " + totalSallery);
                }
            }
            return emp.sallery;
        }
    }
}
