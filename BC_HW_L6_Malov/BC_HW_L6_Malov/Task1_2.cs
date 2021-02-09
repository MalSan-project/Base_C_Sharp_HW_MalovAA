using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_HW_L6_Malov
{

    //Задание 1 к уроку 6. Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double,double). 
    //       Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
    //Задание 2 к уроку 6. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
    //       а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
    //       б) Используйте массив(или список) делегатов, в котором хранятся различные функции.
    //       в) * Переделайте функцию Load, чтобы она возвращала массив считанных значений.Пусть она возвращает минимум через параметр.
    delegate double MyFunc1(double x);
    delegate double MyFunc2(double x, double y);

    class Task1_2
    {
        public static void PauseAndClear()
        {            
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        public static void Table(MyFunc1 func,double x, double b)
        {
            
            Console.Write("----- X ----- Y -----");
            while (x<=b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, func(x));
                x += 1;
            }
            Console.WriteLine("-----------------------");
        }
        public static void Table(MyFunc2 func, double x,double a, double b,double c)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b )
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, func(x,a));
                x += c;
            }
            Console.WriteLine("-----------------------");
            
        }
        public static void Pause()
        {
            Console.ReadKey();
            Console.ResetColor();
        }
        #region Функции
        /// <summary>
        ///Кубическая функция с заданным множителем
        /// </summary>
        /// <param name="x">независимая пременная функции</param>
        /// <param name="a">множитель</param>
        /// <returns>а*х^3</returns>
        public static double ThirdDegree(double x,double a)
        {
            return (x * x * x)*a;
        }
        /// <summary>
        /// Параболическая функция с заданным множителем
        /// </summary>
        /// <param name="x">независимая пременная функции</param>
        /// <param name="a">множитель</param>
        /// <returns>а*х^2</returns>
        public static double Parabola(double x,double a)
        {
            return a * Math.Pow(x, 2);
        }
        /// <summary>
        /// Функция синуса угла с заданным множителем
        /// </summary>
        /// <param name="x">угол</param>
        /// <param name="a">множитель</param>
        /// <returns>a*sin(x)</returns>
        public static double Sinus(double x,double a)
        {
            return a * Math.Sin(x);
        }
        /// <summary>
        /// Функция косинуса угла с заданным множителем
        /// </summary>
        /// <param name="x">угол</param>
        /// <param name="a">множитель</param>
        /// <returns>a*cos(x)</returns>
        public static double Cosinus(double x,double a)
        {
            return a * Math.Cos(x);
        }
        /// <summary>
        /// Показательная функция
        /// </summary>
        /// <param name="x">Степень ункции</param>
        /// <param name="a">Основание функции</param>
        /// <returns>a^x</returns>
        public static double Exponential(double x, double a)
        {
            return Math.Pow(a,x);
        }
        /// <summary>
        /// Функция тангенса угла с заданным множителем
        /// </summary>
        /// <param name="x">угол</param>
        /// <param name="a">множитель</param>
        /// <returns>a*tg(x)</returns>
        public static double Tangent(double x, double a)
        {
            return a*Math.Tan(x);
        }
        /// <summary>
        /// Функция катангенса угла с заданным множителем
        /// </summary>
        /// <param name="x">угол</param>
        /// <param name="a">множитель</param>
        /// <returns>a*ctg(x)</returns>
        public static double Catangent(double x, double a)
        {
            return a*(1/Math.Tan(x));
        }
        #endregion
        /// <summary>
        /// Метод записи результатов функции на заданном отрезке с заданным шагом в файл
        /// </summary>
        /// <param name="fileName">имя создаваемого файла</param>
        /// <param name="f">функция для расчётов</param>
        /// <param name="c">начальное значение независимого параметра</param>
        /// <param name="a">множитель функции</param>
        /// <param name="b">максимальное значение независимого параметра</param>
        /// <param name="h">шаг значений независимого параметра</param>
        public static void SaveMyFunc(string fileName,MyFunc2 f,double c,double a,double b,double h)
        {
            double x = c;
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                BinaryWriter writer = new BinaryWriter(fs);
                while (x <= b)
                {
                    writer.Write(f(x, a));
                    x += h;
                }
                writer.Close();
            }
        }
        /// <summary>
        /// Метод считывания значений из файла, возвращающий массив значений и минимальное значение
        /// </summary>
        /// <param name="fileName">полный путь к файлу</param>
        /// <param name="min">минимальное значение</param>
        /// <returns></returns>
        public static double[] LoadMin(string fileName,out double min)
        {
            double[] tempres;
            min = double.MaxValue;
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                BinaryReader reader = new BinaryReader(fs);                
                tempres =new double[(fs.Length / sizeof(double))];
                for (int i=0;i<fs.Length/sizeof(double);i++)
                {
                    tempres[i] = reader.ReadDouble();
                    if (tempres[i] < min) min = tempres[i];
                }
                reader.Close();                
            }
            return tempres;
        }
        public static void EndOfTask()
        {
            Console.WriteLine("Увидимся на следующем задании!");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();         
        }
        /// <summary>
        /// Метод получения переменных для функции и вывода минимальных значений
        /// </summary>
        /// <param name="f"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public static bool CheckAndRunUserFunction(MyFunc2 f,out double min)
        {
            min = Double.MaxValue;
            string fileName = AppDomain.CurrentDomain.BaseDirectory + "mytestfunc.txt";            
            do
            {
                Console.Write("Введите множитель/основание функции.(П.С. Для выхода нажмите 0)=> ");
                if (Double.TryParse(Console.ReadLine(), out double a) && a != 0)
                {
                    do
                    {
                        Console.Write("Введите начальное значение диапазона.(П.С. Для выхода нажмите 0)=> ");
                        if (Double.TryParse(Console.ReadLine(), out double x) && x != 0)
                        {
                            do
                            {
                                Console.Write("Введите макимальное значение диапазона.(П.С. Для выхода нажмите 0)=> ");
                                if (Double.TryParse(Console.ReadLine(), out double b) && b != 0)
                                {
                                    do
                                    {
                                        Console.Write("Введите шаг значений функции.(П.С. Для выхода нажмите 0)=> ");
                                        if (Double.TryParse(Console.ReadLine(), out double h) && h != 0)
                                        {
                                            Table(f, x, a, b, h);
                                            SaveMyFunc(fileName, f, x, a, b, h);
                                            double[] results = LoadMin(fileName, out min);
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine("Минимальным значением функции на отрезке от{1,8:000}до{2,8:000}с шагом значений{3,8:000}\n будет => {0,8:000}", min, x, b, h);
                                            Pause();
                                            return true;
                                        }
                                        else
                                        if (h == 0)
                                            return false;
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("Введён не корректный шаг значений. Повторите ввод!");
                                            Pause();
                                        }
                                    } while (true);
                                }
                                else if (b == 0)
                                    return false;
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Введено не корректное максимальное значение диапазона. Повторите ввод!");
                                    Pause();
                                }
                            } while (true);
                        }
                        else if (x == 0)
                            return false;
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Введено не корректное минимальное значение диапазона. Повторите ввод!");
                            Pause();
                        }
                    } while (true);
                }
                else if (a == 0)
                    return false;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введен не корректный множитель/основание функции. Повторите ввод!");
                    Pause();
                }
            } while (true);            
        }
        /// <summary>
        /// Метод выбора функции пользователем
        /// </summary>
        public static void RunTask1_2()
        {
            MyFunc2[] funcs = { ThirdDegree, Parabola, Sinus,Cosinus, Exponential,Tangent,Catangent};
            int answer;
            Console.WriteLine("Добро пожаловать задания 1 и 2 к уроку 6. На этом задании мы будем играться с функциями.");
            do
            {
                Console.Write("Выберите интересующую вас функцию:\n1. а*х^3 \n2. а*х^2 \n3. а*sin(x) \n4. а*cos(x) \n5. а^x \n6. а*tg(х) \n7. а*ctg(x)\nДля выхода введите 0\nВаш выбор => ");
                if (int.TryParse(Console.ReadLine(),out answer)&& answer>0 && answer<=7)
                {
                    CheckAndRunUserFunction(funcs[answer - 1], out double min);                    
                }
                else
                if (answer!=0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Выбран не корректный номер функции!Повторите ввод!");
                    Pause();
                }                
            } while (answer!=0);            
            EndOfTask();
        }
    }
}