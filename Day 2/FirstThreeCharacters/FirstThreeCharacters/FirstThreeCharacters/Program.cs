namespace FirstThreeCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String MyStr, MySubStr;
            Console.WriteLine("Please input a string");
            MyStr = Console.ReadLine();
            int MyStrLength = 0;
            MyStrLength = MyStr.Length;
            if (MyStrLength > 3)
            {
                Console.WriteLine(MyStr.Substring(0, 3)+ MyStr+ MyStr.Substring(0, 3));
            }
            else
            {
                Console.WriteLine(MyStr + MyStr + MyStr);
            }
        }
    }
}