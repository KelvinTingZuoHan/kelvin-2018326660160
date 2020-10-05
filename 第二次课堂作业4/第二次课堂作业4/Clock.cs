using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二次课堂作业4
{

    // 声明两个事件委托
    public delegate void RingHandler(object sender, string message);
    public delegate void ClockRunHandler(object sender, string time);

    class Clock
    {
        // 声明两个事件，一个alarm，一个时间前进
        public event RingHandler onRinging;
        public event ClockRunHandler onRunning;

        public void Ring(string message)
        {
            Console.WriteLine(message);
            string messageToHandle = message;
            onRinging(this, messageToHandle);
        }

        public void Run(string time)
        {
            Console.WriteLine($"Now is {time}");
            string timeToHandle = time;
            onRunning(this, timeToHandle);
        }
    }

    class callable
    {
        public Clock clock = new Clock();


        public callable()
        {
            clock.onRinging += new RingHandler(Ring);
            clock.onRunning += new ClockRunHandler(Run);
        }

        void Ring(object sender, string message)
        {
            Console.WriteLine("RING!!!");
        }

        void Run(object sender, string time)
        {
            Console.WriteLine("BULING BULINg BULING");
        }
    }

}
