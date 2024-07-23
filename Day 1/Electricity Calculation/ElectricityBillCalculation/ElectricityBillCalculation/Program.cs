namespace ElectricityBillCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Units = 0 ;
            Decimal BillAmount = 0;
            Console.WriteLine("Please Units");
            Units = Convert.ToInt32(Console.ReadLine());

            if (Units <= 50)
            {
                BillAmount = Convert.ToDecimal(Units * 0.50);
            }
            else if (Units > 50 && Units <= 150 )
            {
                BillAmount = Convert.ToDecimal(50 * 0.50 + (Units - 50) * 0.75);
            }
            else if (Units > 150 && Units <= 250 )
            {
                BillAmount = Convert.ToDecimal((50 * 0.50) + (100 * 0.75) + (Units - 150) * 1.20);
            }
            else if (Units > 250 )
            {
                BillAmount = Convert.ToDecimal(Units * 1.50);
            }
            BillAmount = BillAmount + (BillAmount * 20 / 100);
            Console.WriteLine("Electricity Bill Amount : "+ BillAmount);
        }
    }
}