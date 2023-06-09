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
            int Is_Part_Time = 2;
            int Wage_Per_Hour = 20;
            int empHour;
            int DailyEmpWage;
            Random R = new Random();
            int empCheck = R.Next(3);

            switch (empCheck)
            {
                case 1:
                    {
                        Console.WriteLine("Employee is present.");
                        empHour = 8;
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Employee present PartTime.");
                        empHour = 4;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Employee is absent.");
                        empHour = 0;
                        break;
                    }
            }

            DailyEmpWage = Wage_Per_Hour * empHour;
            Console.WriteLine("Daily employee wage is :- " + DailyEmpWage);

        }
    }
}
