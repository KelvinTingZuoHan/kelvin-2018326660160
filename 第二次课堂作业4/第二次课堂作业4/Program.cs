using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二次课堂作业4
{
    class Program
    {
        static void Main(string[] args)
        {
            callable call = new callable();
            string time = DateTime.Now.ToLongTimeString().ToString();
            call.clock.Run(time);
            string message = "Please Get Up Now";
            call.clock.Ring(message);
        }
    }
}
