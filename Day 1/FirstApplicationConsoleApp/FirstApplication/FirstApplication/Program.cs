namespace FirstApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int Number1, Number2 ;
            Console.WriteLine("Please Enter First Number");
            Number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please Enter Second Number");
            //Number2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(Number1);
            //Console.WriteLine(Number2);

            //Console.Write(Number1+"\t");
            //Console.WriteLine(Number2);

            if (Number1 % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }


        }
    }
}