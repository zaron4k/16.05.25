using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Account
    {
        public int Sum { get; private set; }
        public Account(int sum) => Sum = sum;
        public void Put(int sum) => Sum += sum;
        public void Take(int sum)
        {
            if(Sum >= sum)
            {
                Sum -= sum;
            }
        }
    }
}
