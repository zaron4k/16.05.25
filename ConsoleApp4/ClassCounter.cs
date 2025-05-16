using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ClassCounter
    {
        public delegate void MethodContainer();
        public event MethodContainer onCount;
        public void Count ()
        {
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine($"{i}");
                if ((i == 7)&&(onCount != null))
                    {
                    onCount();
                    }
            }
        }
        public void Message()
        {
            Console.WriteLine("У себя 7!!!");
        }
    }
}
