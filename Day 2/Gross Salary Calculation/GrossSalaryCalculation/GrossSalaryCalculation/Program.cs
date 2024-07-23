namespace GrossSalaryCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Decimal GrossSalary = 0;
            int BasicSalary = 0, HRA = 0 , DA = 0;
            Console.WriteLine("Please Input Basic Salary");
            BasicSalary = Convert.ToInt32(Console.ReadLine());

            if (BasicSalary <= 10000)
            {
                HRA = (BasicSalary * 20 / 100);
                DA  = (BasicSalary * 80 /100);
                BasicSalary = BasicSalary + HRA + DA;
            }
            else if (BasicSalary <= 20000)
            {
                HRA = (BasicSalary * 25 / 100);
                DA = (BasicSalary * 90 / 100);
                BasicSalary = BasicSalary + HRA + DA;
            }
            else if (BasicSalary > 20000)
            {
                HRA = (BasicSalary * 30 / 100);
                DA = (BasicSalary * 95 / 100);
                BasicSalary = BasicSalary + HRA + DA;
            }
            Console.WriteLine("Gross Salary : " + BasicSalary);
        }
    }
}