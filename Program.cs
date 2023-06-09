namespace EmployeeWageProblem
{
    public class Program
    {
        public static void Main(String[] args)
        {

            EmployeeWage obj = new EmployeeWage();

            obj.addCompanies("Google", 20, 15, 90);

            obj.addCompanies("Microsoft", 45, 23, 150);

            obj.EmpComputation();
        }
    }
}
