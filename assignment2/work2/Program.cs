using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            char[] s = new char[] { ' ' };
            string[] arr = Console.ReadLine().Split(s);
            int[] arry1 = new int[arr.Length];
            arry1 = Array.ConvertAll<string, int>(arr, m => int.Parse(m));
            */
            int num;
            num=int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            for(int i = 0; i < num; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            //求各值
            int max = arr[0];
            int min = arr[0];
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
                if (i >= max)
                {
                    max = i;
                }
                else
                {
                    min = i;
                }
            }
            Console.WriteLine("max:" + max);
            Console.WriteLine("min:" + min);
            Console.WriteLine("summary:" + sum);
            Console.WriteLine("average:" + sum / num);
            Console.Read();
        }
    }
}
