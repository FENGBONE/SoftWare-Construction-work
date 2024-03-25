using System;
using System.Xml;
namespace work2
{
    //发布类
    public class ClockEvent
    {
        public delegate void ClockEventHandler(string s);
        public event ClockEventHandler Tick;
        public event ClockEventHandler Alarm;
        private int nowhour;
        private int nowminute;
        private int hour;
        private int minute;
        public ClockEvent(int nowhour, int nowminute, int hour, int minute)
        {
            this.nowhour = nowhour;
            this.nowminute = nowminute;
            this.hour = hour;
            this.minute = minute;
        }
        public void OnTick()
        {
            if (Tick != null)
            {
                for (int i = nowhour * 60 + nowminute; i < hour * 60 + minute; i++)
                {
                    Tick("Tick!");
                    Thread.Sleep(1000);
                }
                OnAlarm();
            }          
        }

        public void OnAlarm()
        {
            if (Alarm != null)
            {
                Alarm("Alarm");
            }
        }
    }
    //订阅器类
    public class SubscribEvent
    {
        public void printf(string s)
        {
            Console.WriteLine(s);
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int nh, nm, h, m;
            Console.WriteLine("请输入当前时间：");
            nh =  int.Parse(Console.ReadLine());
            nm = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入响铃时间：");
            h = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            ClockEvent clockEvent = new ClockEvent(nh,nm,h,m);
            SubscribEvent subscribEvent = new SubscribEvent();
            clockEvent.Tick += new ClockEvent.ClockEventHandler(subscribEvent.printf);
            clockEvent.Alarm += new ClockEvent.ClockEventHandler(subscribEvent.printf);

            clockEvent.OnTick();
        }
    }
}
