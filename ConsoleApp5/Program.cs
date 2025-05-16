using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            // Создаем объект шлагбаума
            var barrier = new Barrier();

            // Подписываем объект шлагбаума на оба события
            Barrier.Event1 += () => Console.WriteLine("Шлагбаум открыт.");
            Barrier.Event2 += () => Console.WriteLine("Шлагбаум закрыт.");

            // В цикле из 10 витков
            for (int i = 0; i < 10; i++)
            {
                // Создаем объект человека
                var person = new Man($"Человек {i + 1}");

                // Подписываем этого человека на оба события
                Barrier.Event1 += person.OnEvent1; // Подписываем на событие открытия
                Barrier.Event2 += person.OnEvent2; // Подписываем на событие закрытия

                // Генерируем случайное событие
                var randomValue = new Random().Next(0, 100); // Случайное число для генерации события
                Console.WriteLine($"Виток {i + 1}:");
                Barrier.GenerateRandomEvent(randomValue);
                Console.WriteLine();

                // Убираем подписку для следующего витка
                Barrier.Event1 -= person.OnEvent1;
                Barrier.Event2 -= person.OnEvent2;
                Console.Read();
            }
        }
    }
}
