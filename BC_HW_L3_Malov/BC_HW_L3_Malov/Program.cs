using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_HW_L3_Malov
{
    //Домашнее задание к уроку 3 Базового курса C#
    //Студент Малов А.А.
    //Для удобства задания разбиты по классам, вызов происходит в классе Program.
    class Program
    {
        #region Методы запуска 1 задания урока 3
        /// <summary>
        /// Метод выбора алгебраической операции с комплексными числами пользователем
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void RunOperation(Complex a, Complex b)
        {
            Complex c = new Complex();
            string answer = "";
            do
            {
                Console.WriteLine($"Выберете операцию, которую хотите выполнить с числами\n {a} | {b} \n1) +  сложение\n2) - вычитание\n3) * умножение\n4) / деление\nЧтобы ввести другие числа введи 8\nДля выхода нажмите 0");
                if ((answer = Console.ReadLine()) == "1" || answer == "+")
                {
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    Console.WriteLine("Для продолжения нажмите любую кнопку");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                    if (answer == "2" || answer == "-")
                {
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    Console.WriteLine("Для продолжения нажмите любую кнопку");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                    if (answer == "3" || answer == "*")
                {
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    Console.WriteLine("Для продолжения нажмите любую кнопку");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                     if (answer == "4" || answer == "/")                
                    try
                    {
                        Console.WriteLine($"{a} / {b} = {a / b}");
                        Console.WriteLine("Для продолжения нажмите любую кнопку");
                        Console.ReadKey();
                        Console.Clear();
                    } 
                    catch (Exception e)
                    {
                        Console.WriteLine($"Ошибка => {e}");
                        Console.ReadKey();
                    }                
                else
                     if (answer == "8")
                {
                    Console.Clear();
                    RunTusk1();
                }
                else
                    if (answer == "0")
                {
                    Console.Clear();
                    Console.WriteLine("Спасибо, что рассмотрели задание 1 к уроку 3.\nХорошего дня!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Введёна не корректная операция");
                }
            }
            while (answer != "0");
        }
        /// <summary>
        /// Метод запроса комплекного числа у пользователя (Включает проверку "ввода от дурака")
        /// </summary>
        /// <returns></returns>
        public static Complex GetComplex()
        {
            Complex f = new Complex();
            bool flag = false;
            do
            {
                flag = false;
                try
                {
                    Console.Write("Введите реальную часть комплексного числа=>");
                    f.Re = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка => {e} \nПовторите ввод числа");
                    Console.ReadKey();
                    Console.Clear();
                    flag = true;
                }
            }
            while (flag);
            do
            {
                flag = false;
                try
                {
                    Console.Write("Введите мнимую часть комплексного числа=>");
                    f.Im = int.Parse(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка => {e} \nПовторите ввод числа");
                    Console.ReadKey();
                    Console.Clear();
                    flag = true;
                }
            }
            while (flag);
            return f;
        }
        /// <summary>
        /// Метод запуска первого задания(Работа с классом комплексных чисел)
        /// </summary>
         static void RunTusk1()
        {
            Console.WriteLine("Урок 3.Задание 1. \nДанная программа продемонстрирует работу класса комплексных чисел на примере простейших алгебраических операций: \n Таких, как: +, -, *, / ");
            Console.WriteLine("Введите 1-е комплексное число: ");
            Complex a = GetComplex();
            Console.WriteLine("И 2-е комплексное число: ");
            Complex b = GetComplex();            
            RunOperation(a, b);
            Console.ReadKey();
            Console.Clear();
        }
        #endregion
        #region Методы запуска Задания 3 для урока 3
        static
        public Fraction GetFraction()
        {
            Fraction f = new Fraction();
            bool flag = false;
            do
            {
                flag = false;
                try
                {
                    Console.Write("Введите числитель рационального числа=>");
                    f.Num=int.Parse(Console.ReadLine());                     
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка => {e} \nПовторите ввод числа");
                    Console.ReadKey();
                    Console.Clear();
                    flag = true;
                }
            }
            while (flag);
            do
            {
                flag = false;
                try
                {
                    Console.Write("Введите знаменатель рационального числа=>");
                    f.Den = int.Parse(Console.ReadLine());
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка => {e} \nПовторите ввод числа");
                    Console.ReadKey();
                    Console.Clear();
                    flag = true;
                }
            }
            while (flag);
            return f;
        }        
        /// <summary>
        /// Метод выбора и проведения алгебраических операция для рациональных чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void RunOperation(Fraction a, Fraction b)
        {
            Complex c = new Complex();
            string answer = "";
            do
            {
                Console.WriteLine($"Выберете операцию, которую хотите выполнить с дробями\n {a} | {b} \n1) +  сложение\n2) - вычитание\n3) * умножение\n4) / деление\nЧтобы ввести другие дроби введи 8\nДля выхода нажмите 0");
                if ((answer = Console.ReadLine()) == "1" || answer == "+")
                {
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    Console.WriteLine("Для продолжения нажмите любую кнопку");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                    if (answer == "2" || answer == "-")
                {
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    Console.WriteLine("Для продолжения нажмите любую кнопку");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                    if (answer == "3" || answer == "*")
                {
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    Console.WriteLine("Для продолжения нажмите любую кнопку");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                     if (answer == "4" || answer == "/")
                {
                    Console.WriteLine($"{a} / {b} = {a / b}");
                    Console.WriteLine("Для продолжения нажмите любую кнопку");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                     if (answer == "8")
                {
                    Console.Clear();
                    RunTusk3();
                }
                else
                    if (answer == "0")
                {
                    Console.Clear();
                    Console.WriteLine("Спасибо, что рассмотрели работу задания 3 к уроку 3.\nХорошего дня!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Введёна не корректная операция");
                }
            }
            while (answer != "0");
        }
        /// <summary>
        /// По классике метод запуска Задания 1 к уроку 3.
        /// </summary>
        static void RunTusk3()
        {           
            Console.WriteLine("Урок 3.Задание 3. \nДанная программа продемонстрирует работу класса рациональных чисел на примере простейших алгебраических операций: \n Таких, как: +, -, *, / ");
            Console.WriteLine("Введите 1-е рациональное число число: ");
            Fraction a=GetFraction();
            Console.WriteLine("Введите 2-е рациональное число число: ");
            Fraction b=GetFraction();
            RunOperation(a, b);
            Console.ReadKey();
            Console.Clear();
            }
        #endregion
        /// <summary>
        /// Метод Выбора пользователем операции с комплексными числами
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        
        
       
        /// <summary>
        /// Метод проверки ответа пользователя на выбор задания
        /// </summary>
        /// <param name="answer"></param>
        static void CheckAnswerRun(string answer)
        {
            #region Создание объектов классов задач
            Complex task1 = new Complex();
            Task2 task2 = new Task2();            
            #endregion
            if (answer == "1")
               RunTusk1();
            else
                if (answer == "2")
                task2.RunTask2();
            else
                if (answer == "3")
                RunTusk3();
            else                
                if (answer == "0")
                Console.WriteLine("Как пожелаете. \nУвидимся на следующем домашнем задании, и, благодарю за потраченное время.\n");
            else
                Console.WriteLine("Введён не корректный номер задания!");
        }

        static void Main(string[] args)
        {
            #region Объявление переменных
            string answer = "";
            string tasks = "Введи номер интересующего задания:\n1. Задание на создание класса комплексных чисел и работа его на примере элементарных алгебраических операций. \n__________________________\n2. Подсчёт суммы нечётных положительных чисел, из тех что введены пользователем. Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. \n__________________________\n3.Задание на создание класса рациональных чисел и работа его на примере элементарных алгебраических операций.\n__________________________\nДля выхода из программы введи 0 \n__________________________\nИтак, ваш выбор =>";
            #endregion
            Console.WriteLine("Доброго времени суток, пользователь. \nБлагодарю, что решили потратить время на просмотр моего домашнего задания к уроку №2 курса: 'Основы C#'.");
            do
            {
                Console.Write(tasks);
                answer =Console.ReadLine();
                CheckAnswerRun(answer);
            } while (answer != "0");
            Console.ReadKey();
        }
    }
}