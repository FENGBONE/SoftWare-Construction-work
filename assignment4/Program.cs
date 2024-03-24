using System.Collections;
using System.Xml.Serialization;

namespace work1
{
    public delegate void Action<T>(T t);
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            head = tail = null;
        }
        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> node = new Node<T>(t);
            if (tail == null)
            {
                head = tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
        }

        public void Foreach(Action<T> action)
        {
            Node<T> n = Head;
            while (n != null)
            {
                action(n.Data);
                n = n.Next;
            }
        }
        

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(5);
            list.Add(4);
            list.Add(3);
            Action<int> action1 = x => Console.Write(x + " ");
            list.Foreach(action1);
            Console.WriteLine();
            int max = 0;
            int min = list.Head.Data;
            //求最大值
            list.Foreach(x =>
            {
                max = max > x ? max : x;
            });
            //求最小值
            list.Foreach(x =>
            {
                min = min < x ? min : x;
            });
            Console.WriteLine("最大值为："+ max);
            Console.WriteLine("最小值为：" + min);

        }
        
    }
    
}
