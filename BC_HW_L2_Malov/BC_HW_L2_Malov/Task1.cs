using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_HW_L2_Malov
{
    public class Task1
    {
        //Урок 2. Задание 1. Написать метод, возвращающий минимальное из трех чисел.
        static Task1()
        {
        }
        /// <summary>
        /// Метод нахождения минимума из 3-ёх чисел
        /// </summary>
        /// <param name=""="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static double MinOfThree (double a,double b,double c)
        {
            if (a <= b && a <= c)
                return a;
            else
                if (b <= a && b <= c)
                return b;
            else
                return c;
        }
        /// <summary>
        /// Метод Запуска 1-го задания. метод, возвращающий минимальное из трех чисел.
        /// </summary>
        public void RunTask1()
        {
            double a, b, c = 0;
            Console.WriteLine("Урок 2.Задание 1. \nДанная программа находит минимальное из 3-ёх чисел. \nВведите 3 числа:");
            Console.Write("Введите 1-ое число: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите 2-ое число: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Введите 3-ое число: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine($"Минимальным числом среди числел {a} , {b} и {c} является число: {MinOfThree(a, b, c)}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
