using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
               sub sub=new sub();
            Add ad = new Add();
            Console.WriteLine(sub.subtract(9, 6));
            Console.WriteLine(ad.add(9, 6));

            
            modules modules = new modules();
            Console.WriteLine(modules.mod(10, 2));
        }
    }
}
