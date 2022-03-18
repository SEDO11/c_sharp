using System;

namespace Print_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("This is the first line");
            //Console.WriteLine("This is the second line");

            String first = "This is the first line";
            String[] second = {"This is", "the second line" };

            Console.WriteLine(first);
            Console.Write(second[0]);
            Console.Write(" ");
            Console.Write(second[1]);
        }
    }
}
