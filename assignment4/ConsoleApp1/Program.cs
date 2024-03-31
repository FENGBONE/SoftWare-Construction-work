namespace ConsoleApp1
{
    public class asd
    {
        int qwe;
        public asd(int s) { 
            qwe = s;
        }
        public override string ToString()
        {
            return "12321231232           " + qwe;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<asd> list = new List<asd>();
            list.Add(new asd(1));
            list.Add(new asd(2));
            list.Add(new asd(3));
            list.ForEach(x => Console.WriteLine(x));
        }
    }
}
