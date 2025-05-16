using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassCounter counter = new ClassCounter();
            Handler_1 handler_1 = new Handler_1();
            Handler_2 handler_2 = new Handler_2();
            counter.Count();
            counter.onCount += handler_1.Message;
            counter.onCount += handler_2.Message;
            counter.onCount += counter.Message;
            counter.Count();
            Console.Read();
        }
    }
}
