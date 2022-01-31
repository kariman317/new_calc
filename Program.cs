using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
               sub sub=new sub();
            Add ad = new Add();
              sub sub=new sub();
            Console.WriteLine(sub.subtract(9, 6));
            Console.WriteLine(ad.add(9, 6));

            
            modules modules = new modules();
            Console.WriteLine(modules.mod(10, 2));
            multiply Multi = new multiply();
           Console.WriteLine( Multi.multiplyNum(2, 4));

        }
    }
}
