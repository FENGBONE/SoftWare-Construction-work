using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            char x;
            a=int.Parse(Console.ReadLine());
            x=char.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            switch (x)
            {
                case '+':
                    Console.WriteLine(a + b);
                    break;
                case '-':
                    Console.WriteLine(a - b);
                    break;
                case '*':
                    Console.WriteLine(a * b);
                    break;
                case '/':
                    Console.WriteLine(a / b);
                    break;
                default: 
                    Console.WriteLine("wrong");
                    break;
            }
            Console.Read();
        }
    }
}
