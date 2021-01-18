using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_HW_L2_Malov
{
//Урок 2. Задание 7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
//б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.

    class Task7
    {
        static Task7()
        {
        }
        /// <summary>
        /// Рекурсивный метод вывода на экран всех чисел в заданном диапазоне
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void GetAllNumberRec(int a,int b)
        {
            if (a<=b)
            {
                Console.Write($"| {a} ");
                a++;
                GetAllNumberRec(a, b);
            }
        }
        /// <summary>
        /// Рекурсивный метод подсчёта суммы чисел в заданном диапазоне и вывод его на экран
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="sum"></param>
        static void GetSumAllNumbers(int a, int b, int sum)
        {
           if (a<=b)
            {
                sum = sum + a;
                a++;
                GetSumAllNumbers(a, b, sum);                

            } else
            Console.WriteLine($"\nСумма всех чисел в данном диапазоне => {sum}");           
        }
        /// <summary>
        /// Метод запуска 7-го задания. Рекурсивный метод вывода на экран всех чисел в заданном диапазоне & Рекурсивный метод подсчёта суммы чисел в заданном диапазоне и вывод его на экран
        /// </summary>
        public void RunTask7()
        {
            int a = 0;
            int b = 0;
            int sum = 0;
            Console.WriteLine("Урок 2.Задание 7. \nДанная программа выведет все числа в заданном диапазоне, а так же подсчитает их сумму. и всё, используюя рекурсивный метод, наслаждайтесь.");
            Console.Write("Для начала введите нижнюю границу диапазона: ");
            a=int.Parse(Console.ReadLine());
            Console.Write("А теперь, введите нижнюю границу диапазона: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Итак, у нас получились следующие числа: ");
            GetAllNumberRec(a, b);
            GetSumAllNumbers(a, b, sum);
            Console.ReadKey();
            Console.Clear();
        }

    }
}
