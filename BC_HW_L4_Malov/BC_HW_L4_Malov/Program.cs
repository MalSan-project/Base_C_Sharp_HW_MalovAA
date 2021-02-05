using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace BC_HW_L4_Malov
///Домашняя работа к уроку 4 курса "Основы c#". Студент: Малов А.А.
{
    class Program
    {    
        static void RunTusk1()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Задание 1 к уроку 4\nДан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3.\n--------------------------");
            MyIntArray arrayForTusk1 = new MyIntArray(20, 10000);
            arrayForTusk1.Print();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"количество пар элементов массива, в которых хотя бы одно число делится на 3 => {arrayForTusk1.MultiplesOfThree()}");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Метод инициализации массива заданной размерностью, начальным элементом и шагом заполнения пользователем. Парамаетры запрашиваются у пользователя и проверяются.
        /// </summary>
        /// <param name="arrTusk2">Одномерный массив для заполнения</param>
        static void GetArrTusk2User(ref MyIntArray arrTusk2)
        {
            uint len;
            int start, gap;
            bool flag = true;
            Console.WriteLine("Инициализация массива с заданной размерностью, начальным элементом и шагом заполнения.");
            do
            {
                Console.Write("Введите размерность массива=>");
                if (uint.TryParse(Console.ReadLine(), out len) && len != 0)
                {
                    flag = false;
                    do
                    {
                        Console.Write("Введите значение стартового элемента=>");
                        if (int.TryParse(Console.ReadLine(), out start))
                        {
                            flag = false;
                            do
                            {
                                Console.Write("Введите шаг =>");
                                if (int.TryParse(Console.ReadLine(), out gap))
                                {
                                    flag = false;
                                    arrTusk2 = new MyIntArray(len, start, gap);
                                }
                                else
                                {
                                    Console.WriteLine("Введён не корректный шаг. Повторите ввод!");
                                    flag = true;
                                }
                            }
                            while (flag);
                        }
                        else
                        {
                            flag = true;
                            Console.WriteLine("Введён не корректное значение стартового эллемента. Повторите ввод!");
                        }
                    }
                    while (flag);
                } 
                else
                {
                    flag = true;
                    Console.WriteLine("Введена не корректная размерность массива. Повторите ввод!");
                }
            } while (flag);
        }
        /// <summary>
        /// Метод проверки выбора метода заполнения массива позльзователем. И собственно его заполнение.
        /// </summary>
        /// <param name="answer">Строка содержащая ответ пользователя</param>
        /// <param name="arrTusk2">Получившийся массив</param>
        /// <returns></returns>
        static bool CheckAnswerInitArrTusk2(out string answer,out MyIntArray arrTusk2)
        {
            arrTusk2 = new MyIntArray();
            Console.Write("Введите способ заполнения массива:\n1. Массив с заданной размерностью, начальным элементом и шагом заполнения\n2. Запись массива из файла\nДля выхода нажмите 0\nВаш выбор=>");
            answer = Console.ReadLine();
            if (answer == "1")
            {
                GetArrTusk2User(ref arrTusk2);                
                return false;
            }
            else
                if (answer == "2")
            {
                var fileName = AppDomain.CurrentDomain.BaseDirectory;
                string answ;
                do
                {
                //R:\Учёба\Разработчик игр\Основы С#\Lesson4\BC_HW_L4_Malov\BC_HW_L4_Malov\MyIntArray.txt
                    Console.Write("Введите имя искомого файла, включая расширение.(Файл должен находиться в базовой директории)\nЧтобы воспользоваться дефолтным файлом введите 1, или MyIntArray.txt\nДля выхода нажимте 0\nВаш ответ=>");
                    answ = Console.ReadLine();
                    if (answ == "1")
                    {
                        fileName = fileName + "MyIntArray.txt";
                        arrTusk2 = new MyIntArray(fileName);
                    }
                    else
                        if (File.Exists(fileName = fileName + answ))
                        arrTusk2 = new MyIntArray(fileName);
                    else
                        Console.WriteLine("Файл не найден. Проверьте правильность названия файла и попробуйте ещё раз.");
                } while (File.Exists(fileName) != true && answ!="0" );
                if (answ == "0")
                {
                    Console.WriteLine("Конструктор создания массива из файла был остановлен пользователем");
                    return true;
                }
                else
                    return false;
            }
            else
                if (answer == "0")                
                return true;
            else
            {
                Console.WriteLine("Введён не корректный номер метода заполнения массива. Повторите ввод!");
                return true;
            }

        }
        /// <summary>
        /// Метод выбора действия с активным массивом и запуска действия.
        /// </summary>
        /// <param name="arrTusk2">Массив</param>
        static void CheckWhatDoTusk2(MyIntArray arrTusk2, string answer)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("У нас получился следующий массив:");
                arrTusk2.Print();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Выберите действие, которое хотите совершить с данным массивом:\n1.Посчитать сумму элементов\n2.Умножить каждый элемент на заданное число\n3.Поменять знак у каждого элемента на противоположный\n4.Посчитать кол-во максимальных элементов\n5.Записать массив в файл\nДля выхода в меню создания массива введите 0\nВаш выбор=>");
                answer = Console.ReadLine();
                if (answer == "1")
                {
                    Console.WriteLine($"Сумма элементов активного массива = {arrTusk2.Sum()}");
                    Console.ReadKey();
                }
                else
                    if (answer == "2")
                {
                    bool flag = true;
                    do
                    {
                        Console.WriteLine("Введите число на которое хотите умножить массив");
                        if (int.TryParse(Console.ReadLine(), out int number))
                        {
                            Console.WriteLine($"При умножении на число {number} получится следующий массив:");
                            arrTusk2.Multi(number);
                            arrTusk2.Print();
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("Введён не корректный множитель. Повторите ввод!");
                        }
                    } while (flag);
                    Console.ReadKey();
                }
                else
                    if (answer == "3")
                {
                    arrTusk2.Inverse();
                    arrTusk2.Print();
                    Console.ReadKey();
                }
                else
                    if (answer == "4")
                {
                    Console.WriteLine($"Количество максимальных элементов  = {arrTusk2.MaxCount(out int max)}\n Сам максимальный элемент = {max}");
                    Console.ReadKey();
                }
                else
                    if (answer == "5")
                {
                    Console.WriteLine("Введите имя файла базовой директории, в который вы хотите записать массив.\nЕсли файл не будет найден, вам предложат его создать в базовой директории");
                    string fileName = Console.ReadLine();
                    arrTusk2.PrintToFile(fileName);
                    Console.ReadKey();
                }
                else
                    if (answer != "0")
                {
                    Console.WriteLine("Вы ввели не корректный номер действия. Повторите ввод!");
                }
            } while (answer != "0");

        }
        /// <summary>
        /// Метод запуска Задания 2 к уроку 4.
        /// </summary>
        static void RunTusk2()
        {
            string answer;
            Console.WriteLine("Задание 2 к уроку 4\nКласс для работы с одномерными массивами:\n--------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            do
                if (!CheckAnswerInitArrTusk2(out answer, out MyIntArray arrTusk2))
                {
                    CheckWhatDoTusk2(arrTusk2, answer);
                }
            while (answer != "0");
            Console.WriteLine("До встречи на следующих заданиях!");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Метод запуска 3-го задлания к 4-му уроку.
        /// </summary>
        static void RunTusk3()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Task3 task3 = new Task3();
            bool flag = true;
            Console.WriteLine("Урок 4.Задание 3.\nРешить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.");
            do
            {
                Console.Write("Введите имя файла(Внимание, файл должен находиться в базовой директории программы)\n Чтобы воспользоваться файлом по дефолу введите 1 или Account.txt\nИмя файла=>");
                string fileName = Console.ReadLine();
                if (fileName == "1")
                {
                    fileName = AppDomain.CurrentDomain.BaseDirectory + "Account.txt";
                    task3.RunTask3(fileName);
                    flag = false;
                }
                else
                {
                    fileName = AppDomain.CurrentDomain.BaseDirectory + fileName;
                    if (File.Exists(fileName))
                    {
                        task3.RunTask3(fileName);
                        flag = false;
                    }
                    else
                        if (fileName == "0")
                        flag = false;
                        else
                        Console.WriteLine("Не корректное имя файла. Повторите ввод!");
                }
            } while (flag);
            Console.WriteLine("До встречи на других заданиях");
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();
        }
        /// <summary>
        /// Метод обработки данных пользователя для инициализации двумерного массива с заданной размерностью и диапазоном значений
        /// </summary>
        /// <param name="arrTusk4"></param>
        static void GetArrTusk4User(ref Dementional2Array arrTusk4)
        {
            uint len;
            int min, max;
            bool flag = true;
            Console.WriteLine("Инициализация двумерного массива с заданной размерностью и диапазоном значений.");
            do
            {
                Console.Write("Введите размерность массива=>");
                if (uint.TryParse(Console.ReadLine(), out len) && len != 0)
                {
                    flag = false;
                    do
                    {
                        Console.Write("Введите минимальное значение диапазона случайных чисел=>");
                        if (int.TryParse(Console.ReadLine(), out min))
                        {
                            flag = false;
                            do
                            {
                                Console.Write("Введите максимальное значение диапазона =>");
                                if (int.TryParse(Console.ReadLine(), out max))
                                {
                                    flag = false;
                                    arrTusk4 = new Dementional2Array(len, min, max);
                                }
                                else
                                {
                                    Console.WriteLine("Введёно не корректное максимальное значение диапазона. Повторите ввод!");
                                    flag = true;
                                }
                            }
                            while (flag);
                        }
                        else
                        {
                            flag = true;
                            Console.WriteLine("Введено не корректное минимальное значение диапазона. Повторите ввод!");
                        }
                    }
                    while (flag);
                }
                else
                {
                    flag = true;
                    Console.WriteLine("Введена не корректная размерность массива. Повторите ввод!");
                }
            } while (flag);
        }
        /// <summary>
        /// Метод обработки ответа пользователя по вопросу способа инициализации двумерного массива и инициализация оного.
        /// </summary>
        /// <param name="answer"></param>
        /// <param name="arrayForTask4"></param>
        /// <returns></returns>
        static bool CheckAnswerInitArrTusk4(out string answer, out Dementional2Array arrayForTask4)
        {
            arrayForTask4 = new Dementional2Array();
            Console.Write("Введите способ заполнения массива:\n1. Массив с заданной размерностью и случайными значениями элементов\n2. Запись массива из файла\nДля выхода нажмите 0\nВаш выбор=>");
            answer = Console.ReadLine();
            if (answer == "1")
            {
                GetArrTusk4User(ref arrayForTask4);
                return false;
            }
            else
                if (answer == "2")
            {
                var fileName = AppDomain.CurrentDomain.BaseDirectory;
                string answ;
                do
                {
                    Console.Write("Введите имя искомого файла, включая расширение.(Файл должен находиться в базовой директории)\nЧтобы воспользоваться дефолтным файлом введите 1, или MyDementional2Array.txt\nДля выхода нажимте 0\nВаш ответ=>");
                    answ = Console.ReadLine();
                    if (answ == "1")
                    {
                        fileName = fileName + "MyDementional2Array.txt";
                        arrayForTask4 = new Dementional2Array(fileName);
                    }
                    else
                        if (File.Exists(fileName = fileName + answ))
                        arrayForTask4 = new Dementional2Array(fileName);
                    else
                        Console.WriteLine("Файл не найден. Проверьте правильность названия файла и попробуйте ещё раз.");
                } while (File.Exists(fileName) != true && answ != "0");

                if (answ == "0")
                {
                    Console.WriteLine("Конструктор создания массива из файла был остановлен пользователем");
                    return true;
                }
                else
                    return false;
            }
            else
                if (answer == "0")
                {
                    Console.Clear();
                    return true;
                }
            else
            {
                Console.WriteLine("Введён не корректный номер метода заполнения массива. Повторите ввод!");
                return true;
            }
        }
            /// <summary>
            /// Метод выбора действия с активным двумерным массивом и запуска действия.
            /// </summary>
            /// <param name="arrTusk4">Двумерный массив</param>            
        static void CheckWhatDoTusk4(Dementional2Array arrTusk4, string answer4)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("У нас получился следующий массив:");
                arrTusk4.Print();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Выберите действие, которое хотите совершить с данным массивом:\n1.Посчитать сумму элементов\n2.Найти сумму всех элементов массива больше заданного\n3.Найти минимальный и максимальный элементы массива\n4.Вернуть индексы максимальных элементов массива\n5.Записать массив в файл\nДля выхода в меню создания массива введите 0\nВаш выбор=>");
                answer4 = Console.ReadLine();
                if (answer4 == "1")
                {
                    Console.WriteLine($"Сумма элементов активного массива = {arrTusk4.Sum()}");
                    Console.ReadKey();
                }
                else
                    if (answer4 == "2")
                {
                    bool flag = true;
                    do
                    {
                        Console.WriteLine("Введите число,чтобы посчитать сумму элементов массива, которые больше этого числа");
                        if (int.TryParse(Console.ReadLine(), out int number))
                        {
                            Console.WriteLine($"Сумма элементов массива, которые больше числа:  {number} => {arrTusk4.Sum(number)}");
                            flag = false;
                        }
                        else
                        {
                            Console.WriteLine("Введно не корректное значение. Повторите ввод!");
                        }
                    } while (flag);
                    Console.ReadKey();
                }
                else
                    if (answer4 == "3")
                {
                    Console.WriteLine($"Минимальным элементов массива является=>{arrTusk4.Min()}\nА максимальным => {arrTusk4.Max()}");
                    Console.ReadKey();
                }
                else
                    if (answer4 == "4")
                {
                    Console.WriteLine("Индексы максимальных элементов следующие:");
                    arrTusk4.IndexOfMax(out int max).Print();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"А сам максимальный элемент = {max}");                    
                    Console.ReadKey();
                }
                else
                    if (answer4 == "5")
                {
                    Console.WriteLine("Введите имя файла базовой директории, в который вы хотите записать массив.\nЕсли файл не будет найден, вам предложат его создать в базовой директории");
                    string fileName = Console.ReadLine();
                    arrTusk4.PrintToFile(fileName);
                    Console.ReadKey();
                }
                else
                    if (answer4 != "0")
                    Console.WriteLine("Вы ввели не корректный номер действия. Повторите ввод!");
            } while (answer4 != "0");
            Console.Clear();

        }
        /// <summary>
        /// Метод запуска Задания 4 к уроку 4
        /// </summary>
        static void RunTusk4()
            {
            string answer4;
                Console.WriteLine("Задание 4 к уроку 4\nКласс для работы с двумерными массивами:\n--------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
            do
            {
                if (!CheckAnswerInitArrTusk4(out answer4, out Dementional2Array arrTusk4))
                {
                    CheckWhatDoTusk4(arrTusk4, answer4);
                }
            }
            while (answer4 != "0");
                Console.WriteLine("До встречи на следующих заданиях!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
            }       
        static void Main(string[] args)
        {
            string answer = "0"; ;
            Console.WriteLine("Доброго время суток, пользователь. Добро пожаловать в домашнюю работу к уроку 4 курса Основы C#");
            do
            {
                Console.Write("Выбери задание,выполнение которое желаешь просмотреть:\n1.Подсчёт пар элементов, хотябы 1 из которых кратен 3 в заданнм массиве\n2.Демонстрация работы класса одномерных массивов\n3.Задача с проверкой ввода login|password\n4.Демонстрация работы класса двумерных массивов\nДля выхода введи 0\nТвой ответ=>");
                if ((answer = Console.ReadLine()) == "1")
                {
                    RunTusk1();
                }
                else
                    if (answer == "2")
                {
                    RunTusk2();
                }
                else
                    if (answer == "3")
                {
                    RunTusk3();
                }
                else
                    if (answer == "4")
                {
                    RunTusk4();
                }
                else
                    if (answer != "0")
                    Console.WriteLine("Вы ввели не корректный номер задания. Повторите ввод.");                        
            }
            while (answer != "0");
            Console.WriteLine("До встречи на домашних работах к следующим урокам.");
            Console.ReadKey();            
            
        }
    }
}
