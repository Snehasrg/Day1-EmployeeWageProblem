namespace EmployeeWageProblem
{
    public class Program
    {
        public static void Main(String[] args)
        {
            EmployeeWage obj = new EmployeeWage();

            obj.Employee("Google", 20, 15, 80);
            Console.WriteLine("------------------------------------------------------");
            obj.Employee("Microsoft", 25, 10, 60);
        }
    }
}
