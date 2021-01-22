using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_HW_L3_Malov
{
    //Урок 3. Задание 2. 
    //а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
    //   Требуется подсчитать сумму всех нечетных положительных чисел.
    //   Сами числа и сумму вывести на экран, используя tryParse;
    //б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
    //   При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;
    class Task2
    {
        /// <summary>
        /// Метод запрашивает число у пользователя и проверяет его валидность. Если введено корректное число - оно выведется на экран, если нет - будет выведено сообщение о некорректных данных.
        /// </summary>
        /// <returns></returns>
        public double GetAndPrintNumber()
        {
            Console.Write("Введите любое число. (Для завершения введите 0) => ");
            if (double.TryParse(Console.ReadLine(), out double number))
                return number;            
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ввели не корректное число");
                Console.ResetColor();
                return GetAndPrintNumber();
            }

        }
        /// <summary>
        /// Метод проверяет чётность и положительность числа и возвращает сумму нечётных положительных чисел
        /// </summary>
        /// <param name="number"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public double GetSumOddNumber(double number,ref double sum)
        {
            if (number > 0 && number % 2 != 0)
                return sum = sum + number;
            else
                return sum;
        }
        /// <summary>
        /// Метод вызова выполнения задания 2.
        /// </summary>
        public void RunTask2()
        {
            double sum = 0;
            double number = 0;
            Console.WriteLine("");
            while ((number = GetAndPrintNumber()) != 0)
                GetSumOddNumber(number,ref sum);
            Console.WriteLine($"Сумма введёных положительных нечётных чисел => {sum}");
            Console.ReadKey();
            Console.Clear();
        }
    }
    
}
