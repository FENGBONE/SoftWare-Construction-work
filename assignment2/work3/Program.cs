namespace work3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[100];
            for (int i=0;i<99;i++)
            {
                ints[i] = i+2;
            }
            //Console.WriteLine("Hello, World!");
            for(int i = 2; i < 101; i++) 
            { 
                for(int j=0;j<99;j++)
                {
                    if (ints[j] != 0 && ints[j] % i == 0 && ints[j]!=i) //能整除i并且不为i,为零则已完成筛选，不用再进行
                    {
                        ints[j] = 0;
                    }
                }
            }
            for (int i = 0; i < 99; i++)
            {
                if (ints[i] != 0)
                {
                    Console.Write(ints[i]+" ");
                }
            }
        }
    }
}
