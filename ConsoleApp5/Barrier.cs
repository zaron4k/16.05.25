using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Barrier
    {
        public static event Action Event1;
        public static event Action Event2;
        public static void HandleEvent1()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Открыто");
            Console.ResetColor();
            Event1?.Invoke();
        }
        public static void HandleEvent2()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Закрыто");
            Console.ResetColor();
            Event1?.Invoke();
        }
        public static void GenerateRandomEvent(int randomValue)
        {
            if (randomValue % 2 == 0)
            {
                HandleEvent1(); // Генерируем событие открытия шлагбаума
            }
            else
            {
                HandleEvent2(); // Генерируем событие закрытия шлагбаума
            }
        }
    }
}
