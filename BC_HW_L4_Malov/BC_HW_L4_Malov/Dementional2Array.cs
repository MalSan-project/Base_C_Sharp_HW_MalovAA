using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace BC_HW_L4_Malov
{
    //4. * а) Реализовать класс для работы с двумерным массивом.Реализовать конструктор, заполняющий массив случайными числами.
    //     Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, 
    //     свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out)
    //   * б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
    //     Дополнительные задачи
    //     в) Обработать возможные исключительные ситуации при работе с файлами.
    class Dementional2Array
    {
        Random rnd = new Random();
        int[,] arr;


        /// <summary>
        /// Конструктор создающий двумерный массив с размерностю 1 и нулевыми элементами
        /// </summary>
        public Dementional2Array()
        {
            arr = new int[0, 0];
        }
        /// <summary>
        /// Конструктор создающий двумерный массив заданной размерности и заполненный случайными неотрицательными целыми числами
        /// </summary>
        /// <param name="len"></param>
        public Dementional2Array(uint len)
        {
            arr = new int[len, len];
            for (int i = 0; i < len; i++)
                for (int j = 0; j < len; j++)
                    arr[i, j] = rnd.Next();
        }
        /// <summary>
        ///  Конструктор создающий двумерный массив заданной размерности и заполненный случайными целыми числами в диапазоне заданных минимума и максимума
        /// </summary>
        /// <param name="len">размерность</param>
        /// <param name="min">минмальное значение</param>
        /// <param name="max">максимальное значение</param>
        public Dementional2Array(uint len, int min, int max)
        {
            if (min < max)
            {
                arr = new int[len , len ];
                for (int i = 0; i < len; i++)
                    for (int j = 0; j < len; j++)
                        arr[i, j] = rnd.Next(min, max);
            }
            else
            {
                arr = new int[len, len ];
                for (int i = 0; i < len; i++)
                    for (int j = 0; j < len; j++)
                        arr[i, j] = rnd.Next(max, min);
            }
        }
        /// <summary>
        /// Метод вывода на экран консоли двумерного массива
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Активный массив:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i=0;i<arr.GetLongLength(0);i++)
            {
                for (int j = 0; j < arr.GetLongLength(1); j++)
                {
                    Console.Write(" {0,5} |", arr[i,j]); 
                }
                Console.WriteLine("");
                Console.WriteLine($"-------->The end of {i+1} line<---------");
            }
            Console.WriteLine("---------------------------");
            Console.ResetColor();
        }

        /// <summary>
        /// Конструктор создания двумерного массиго, путём копирования заднного
        /// </summary>
        /// <param name="newarr">заданный массив</param>
        public Dementional2Array(int[,] newarr)
        {
            arr = newarr;
        }
        /// <summary>
        /// Конструктор создания двумерного массива путём считывания данных из файла
        /// </summary>
        /// <param name="fileName">Полный путь к файлу</param>
        public Dementional2Array(string fileName)
        {
            int len = 0;
            int i = 0;

            if (File.Exists(fileName))
            {
                string[] lin = File.ReadAllLines(fileName);
                string[] col = lin[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                arr = new int[lin.Length,col.Length];
                foreach (string str in lin)
                {
                    col = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (col.Length == arr.GetLength(1))
                        for (int j = 0; j < col.Length; j++)
                        {
                            if (int.TryParse(col[j], out len))
                            {
                                arr[i, j] = len;
                            }
                            else
                                throw new Exception("Файл содержит не корректные данные");
                        }
                    else
                        throw new Exception("Не верная структура файла!К-во элементов в строке не соответствует размерности массива!");
                    i++;

                }

            }
            else
                throw new FileNotFoundException();
        }
        /// <summary>
        /// индексное свойство
        /// </summary>
        /// <param name="i">индекс по столбцу</param>
        /// <param name="j">индекс по строке</param>
        /// <returns></returns>
        public int this[int i, int j]
        {
            get { return arr[i, j]; }
            set { arr[i, j] = value; }
        }
        /// <summary>
        /// Метод подсчёта суммы всех элементов двумерного массива
        /// </summary>
        /// <returns></returns>
        public int Sum()
        {
            int sum = 0; ;
            foreach (int el in arr)
                sum = sum + el;
            return sum;
        }
        /// <summary>
        /// Метод подсчёта суммы всех эллементов двумерного массива,которые больше заданного числа
        /// </summary>
        /// <param name="numb">заданное число</param>
        /// <returns></returns>
        public int Sum(int numb)
        {
            int sum = 0;
            foreach (int el in arr)
                if (el > numb)
                    sum = sum + el;
            return sum;
        }
        /// <summary>
        /// Метод поиска минимального элемента массива
        /// </summary>
        /// <returns></returns>
        public int Min()
        {
            int min = arr[0, 0];
            foreach (int el in arr)
                if (el < min)
                    min = el;
            return min;
        }
        /// <summary>
        /// Метод поиска максимального элемента массива
        /// </summary>
        /// <returns></returns>
        public int Max()
        {
            int count = 0;
            int max = arr[0, 0];
            foreach (int el in arr)
                if (el > max)
                {
                    count = 0;
                    max = el;
                }
                else
                    if (el == max)
                    count++;

            return max;
        }
        /// <summary>
        /// Метод поиска максимального элемента массива, возвращающий ещё и количество максимальных элементов
        /// </summary>
        /// <param name="count">количество максимальных элементов</param>
        /// <returns></returns>
        public int Max(out int count)
        {
            count = 0;
            int max = arr[0, 0];
            foreach (int el in arr)
                if (el > max)
                {
                    count = 1;
                    max = el;
                }
                else
                    if (el == max)
                    count++;

            return max;
        }
        /// <summary>
        /// Метод поиска всех индексов максимальных элементов. Возвращает двумерный массив содержащий эти индексы
        /// </summary>
        /// <returns></returns>
        public int[,] IndexOfMax()
        {
            int max = Max(out int count);
            int l = 0;
            int[,] inOfMax = new int[count, 1];
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
                for (int j = 0; j < arr.GetLength(1) - 1; j++)
                    if (max == arr[i, j])
                    {
                        inOfMax[l, 0] = i;
                        inOfMax[l, 1] = j;
                        l++;
                    }
            return inOfMax;
        }
        public Dementional2Array IndexOfMax(out int max)
        {
            max = Max(out int count);
            int l = 0;
            Dementional2Array inOfMax = new Dementional2Array(new int[count,2]);
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (max == arr[i, j])
                    {
                        inOfMax.arr[l, 0] = i;
                        inOfMax.arr[l, 1] = j;
                        l++;
                    }
            return inOfMax;
        }
        /// <summary>
        /// Метод записи двумерного массива в файл
        /// </summary>
        /// <param name="fileName">Имя файла базовой директории программы</param>
        /// <param name="array">записываемый массив</param>
        public void PrintToFile(string fileName)
        {
            var str = "";
            if (File.Exists(fileName))
            {
                StreamWriter writer = new StreamWriter(fileName);
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                        writer.Write(arr[i, j] + " ");
                    writer.WriteLine();
                }
                writer.Close();
            }
            else
            {
                Console.Write("Файл не найден, создать его?\n1 - Да / Если НЕТ - любая другая клавиша =>");
                if (Console.ReadLine() == "1")
                {
                    StreamWriter writer = new StreamWriter(fileName);
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                            writer.Write(arr[i, j] + " ");
                        writer.WriteLine();
                    }
                    writer.Close();
                    Console.WriteLine("Массив успешно записан в файл!Нажмите любую клавишу=>");
                    Console.ReadKey();
                }
                else
                    Console.WriteLine("Запись массива в файл остановлена пользователем.");
            }

        }
    }
}
