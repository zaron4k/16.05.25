using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Man
    {
        public string Name { get; set; }
        public Man(string name)
        {
            Name = name;
        }
        public void OnEvent1()
        {
            Console.WriteLine($"{Name}, иду.");
        }
        public void OnEvent2()
        {
            Console.WriteLine($"{Name}, стою.");
        }
    }
}
