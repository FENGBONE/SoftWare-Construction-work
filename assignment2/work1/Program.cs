using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, i = 2, j = 0 ;
            num=int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            while(num>1)
            {
                if(num%i!=0)
                {
                    
                    i++;
                    continue;
                    /*
                    double sqrti = Math.Sqrt(i);
                    for (int k = 2; k < sqrti; k++)
                    {
                        if (arr[k] % k == 0)  //不是质数
                        {
                            i++;
                            break;
                        }
                    }
                    continue;*/
                }
                else
                {
                    if (arr[j] != i)    //arr第一位不考虑，输出时直接略过
                    {
                        j++;
                        arr[j] = i;
                    }
                    num = num / i;
                }
            }
            for(int k=1 ; k<=j ; k++) 
            {
                Console.WriteLine(arr[k]);
            }
            Console.Read();
        }
    }
}
