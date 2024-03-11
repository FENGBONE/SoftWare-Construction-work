  namespace work4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int m, n;
            m=int.Parse(Console.ReadLine());
            n=int.Parse(Console.ReadLine());
            int[,] ints = new int[m,n];
            //输入数组
            for (int i = 0; i < m; i++)
            {
                string str = Console.ReadLine();
                string[] tmp = str.Split(" ".ToCharArray());
                for (int j = 0; j < n; j++)
                {
                    ints[i, j] = int.Parse(tmp[j]);
                }
            }


            int num=m < n ? m : n;
            bool iss = true;
            for(int i = 1;i < num; i++) 
            {
                if (ints[i, i] != ints[0,0])
                {
                    iss = false;
                    
                    break;
                }
            }
            if (iss == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
