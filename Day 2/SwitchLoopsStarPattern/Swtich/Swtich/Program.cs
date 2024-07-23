namespace Swtich
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Please enter some input");
            int Choice = Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    Console.WriteLine("You have choosen 1");
                    break;
                case 2:
                    Console.WriteLine("You have choosen 2");
                    break;
                default:
                    Console.WriteLine("You have given wrong input");
                    break;
            }
        }
    }
}