using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmployeeAttendence
    {
        public static void CheckAttendence()
        {
            int isFullTime = 1;
            Random r = new Random();
            int empcheck = r.Next(2);
            if(empcheck==1)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
