using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
              sub sub=new sub();
            Console.WriteLine(sub.subtract(9, 6));
            multiply Multi = new multiply();
           Console.WriteLine( Multi.multiplyNum(2, 4));

        }
    }
}
