using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
               sub sub=new sub();
            Console.WriteLine(sub.subtract(9, 6));
            
            modules modules = new modules();
            Console.WriteLine(modules.mod(10, 2));
        }
    }
}
