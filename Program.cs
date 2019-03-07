using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obratni_otschot
{
    class Program
    {
                /*Вводится ряд целых чисел, заканчивающийся нулём.
            Вывести эти числа в столбик в обратном порядке, включая 0.
            Использовать рекурсию.

            Начальные данные: много чисел, по одному на строчке, последнее число равно нулю.
            Вывод результата: те же самые числа в столбик, но в обратном порядке.*/

        static void Main(string[] args)
        {
            back();
        }

        static void back ()
        {
            long a = long.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine(a);
                return;
            }
            back ();  // Функция вызывает саму себя до вывода переданого значения на экран.
                       // Таким образом переданое значение запоминается и выводится только после того
                       // как в одном из следующих повторных обращений к функции введёное значение
                       //будет равно 0. Тогда все функции "расчехлятся в обратном порядке
            Console.WriteLine(a);
        }
             
            
    }
}
