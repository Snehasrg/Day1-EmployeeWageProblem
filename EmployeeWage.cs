using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmployeeWage
    {
        public static void EmpComputation()
        {
            int Is_Full_Time = 1;
            int Wage_Per_Hour = 20;
            int FullDayHour = 8;
            Random R = new Random();
            int empCheck = R.Next(2);
            if (empCheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is present.");
                FullDayHour = 8;

            }
            else
            {
                Console.WriteLine("Employee is absent.");
                FullDayHour = 0;
            }
            int DailyEmpWage = Wage_Per_Hour * FullDayHour;
            Console.WriteLine("Daily employee wage is :- " + DailyEmpWage);
        }
    }
}
