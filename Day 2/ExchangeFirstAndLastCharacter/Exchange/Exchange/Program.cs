namespace Exchange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String MyStr , MySubStr;
            int MyStrLength = 0;
            Console.WriteLine("Please input a string");
            MyStr = Console.ReadLine();
            MyStrLength = MyStr.Length;
            if (MyStrLength > 1)
            {
                MySubStr = MyStr.Substring(MyStrLength - 1) + MyStr.Substring(1, MyStrLength - 2) + MyStr.Substring(0, 1);
            }
            else
            {
                MySubStr = MyStr;
            }
            Console.WriteLine("New Text is "+MySubStr);
        }
    }
}