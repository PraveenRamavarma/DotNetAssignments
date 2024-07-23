namespace AddFirstCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String MyStr,MySubStr;
            Console.WriteLine("Please input a string");
            MyStr =Console.ReadLine();
            MySubStr = MyStr.Substring(0, 1);
            Console.WriteLine(MySubStr + MyStr + MySubStr);
        }
    }
}