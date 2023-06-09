using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class CompanyEmpWage
    {
        public string company;
        public int Wage_Per_Hour;
        public int Max_Days_IN_Month;
        public int Max_HrsInMonth;
        public int sallery;
        public CompanyEmpWage(string company, int Wage_Per_Hour, int Max_Days_IN_Month, int Max_HrsInMonth)
        {
            this.company = company;
            this.Wage_Per_Hour = Wage_Per_Hour;
            this.Max_Days_IN_Month = Max_Days_IN_Month;
            this.Max_HrsInMonth = Max_HrsInMonth;

        }
        public void setEmpWage(int sallery)
        {
            this.sallery = sallery;
        }
        public string Return()
        {
            return ("\n Total employee wage of " + this.company + " is :-  " + this.sallery);
        }
    }
}
