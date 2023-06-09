using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmployeeWage
    {
         const int Is_Full_Time = 1;
        const int Is_Part_Time = 2;

        public void Employee(string company, int Emp_Rate_Per_Hr, int Max_Days_In_Month, int Max_Hrs_In_Month)
        {

            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            Console.WriteLine(company);

            while (totalEmpHrs <= Max_Hrs_In_Month && totalWorkingDays < Max_Days_In_Month)
            {
                totalWorkingDays++;

                Random obj = new Random();
                int empcheck = obj.Next(0, 3);

                switch (empcheck)
                {
                    case Is_Full_Time:
                        empHrs = 8;
                        break;

                    case Is_Part_Time:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day : " + totalWorkingDays + "  Total employee hours are :- " + totalEmpHrs);

            }
            int totalEmpWage = totalEmpHrs * Emp_Rate_Per_Hr;
            Console.WriteLine("Total employee Wage is :- " + totalEmpWage);
        }
    }
}
