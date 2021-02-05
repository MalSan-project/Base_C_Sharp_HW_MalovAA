using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace BC_HW_L4_Malov
//1. Дан целочисленный массив из 20 элементов. 
//Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
//Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. 
//В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.

//2. а) Дописать класс для работы с одномерным массивом.
//Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом.
//Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива, метод Multi, 
//умножающий каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных элементов.
//В Main продемонстрировать работу класса.
//б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
{
    /// <summary>
    /// Класс для работы с одномерными целочисленными массивами
    /// </summary>
    class MyIntArray
    {
        int[] arr;
        Random r = new Random();

        /// <summary>
        /// Пустой конструктор. Создаст одномерный массив с 1 нулевым элементом
        /// </summary>
        public MyIntArray()
        {
            arr = new int[] { 0 };
        }
        /// <summary>
        /// Индексное свойство
        /// </summary>
        /// <param name="i">индекс элемента</param>
        /// <returns></returns>
        public int this [int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
        /// <summary>
        /// Метод печати активного массива на экран консоли. Цвет - фиолетовый.
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Активный массив:");
            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach (int el in arr)
                Console.Write(" {0,5} |", el);
            Console.WriteLine();
            Console.ResetColor();
        }
        /// <summary>
        /// Конструктор создания одномерного массива с заданной длиной, заполняющийся со стартового значения с заданным шагом
        /// </summary>
        /// <param name="len">размерность массива</param>
        /// <param name="sta">значение стартового элемента</param>
        /// <param name="gap">Шаг</param>
        public MyIntArray(uint len, int sta, int gap)
        {
            if (len == 0)
                throw new ArgumentException("Размерность массива не может быть => 0");
            else
            {
                arr = new int[len];
                arr[0] = sta;
                for (int i = 1; i < len; i++)
                    arr[i] = arr[i - 1] + gap;
            }
        }
        /// <summary>
        /// Конструктор создания копии одномерного массива , поданного на вход
        /// </summary>
        /// <param name="_arr">Целочисленный массив</param>
        public MyIntArray(int[] _arr)
        {
            arr = _arr;
        }
        /// <summary>
        /// Конструктор создания одномерного массива, заданной длины, который заполнится случайными значениями в диапазоне +- параметра поданого на вход
        /// </summary>
        /// <param name="len">Размерность массива</param>
        /// <param name="minmax">Диапазон значений</param>
        public MyIntArray(uint len, int minmax)
        {            
            if (len == 0)
                throw new ArgumentException("Размерность массива не может быть => 0");
            else
            {
                arr = new int[len];
                for (int i = 0; i < len; i++)
                {
                    arr[i] = r.Next(0, minmax+1)-r.Next(0,minmax+1);
                }
            }
        }
        /// <summary>
        /// Метод возвращающий сумму всех элементов одномерного массива целых чисел
        /// </summary>
        /// <returns>Сумма всех элементов массива</returns>
        public int Sum()
        {            
            int sumArr = 0;
            for (int i = 0; i < arr.Length; i++)
                sumArr = sumArr + arr[i];
            return sumArr; 
        }
        /// <summary>
        /// Метод позволяющуй найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. 
        /// </summary>
        /// <returns>количество пар элементов</returns>
        public int MultiplesOfThree()
        {
            int count = 0;
            for (int i = 0; i < arr.Length-1; i++)
                if (arr[i] % 3 == 0 || arr[i + 1] % 3 == 0)
                    count++;
            return count;
        }
        /// <summary>
        /// Метод умножения всех элементов одномерного целочисленного массива на заднное число
        /// </summary>
        /// <param name="number">Целочисленный множитель</param>
        public void Multi(int number)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = arr[i] * number;
        }
        /// <summary>
        /// Метод смены знака у всех элементов одномерного целочисленного массива
        /// </summary>
        public void Inverse()
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = -arr[i];
        }
        /// <summary>
        /// Метод, возвращающий количество максимальных элементов в одномерном массиве
        /// </summary>
        /// <returns>количество максимальных элементов</returns>
        public int MaxCount()
        {            
            int max = arr.Max();
            int maxcount = 1;
            MyIntArray temparr = new MyIntArray(arr);
            System.Array.Sort(temparr.arr);            
            for (int i = temparr.arr.Length - 1; i >= 0; i--)
                if (temparr[i] != max)
                    break;
                else
                    maxcount++;
            return maxcount;
        }
        public int MaxCount(out int max)
        {
            max = arr.Max();
            int maxcount = 0;
            MyIntArray temparr = new MyIntArray(arr);
            System.Array.Sort(temparr.arr);
            for (int i = temparr.arr.Length - 1; i >= 0; i--)
                if (temparr[i] != max)
                    break;
                else
                    maxcount++;
            return maxcount;
        }
        /// <summary>
        /// Конструктор создания одномерного массива на основе данных из файла, путь к которому подаётся на вход.
        /// </summary>
        /// <param name="fileName">Полный путь к файлу</param>
        public MyIntArray(string fileName)
        {            
            string[] str;
            if (File.Exists(fileName))
            {
                StreamReader reader = new StreamReader(fileName);
                str = File.ReadAllLines(fileName);
                var temparr = new int[str.Length];
                for (int i = 0; i < str.Length; i++)
                {
                    if (Int32.TryParse(str[i], out int val))
                    {
                        temparr[i] = val;
                    }
                    else
                        throw new Exception($"Файл содержит не валидные данные! в {i}-ой строке.");
                }
                arr = temparr;
            }
            else
                throw new FileNotFoundException();
        }
        /// <summary>
        /// Метод записи одномерного массива в файл.
        /// </summary>
        /// <param name="fileName">Имя интересующего файла</param>
        /// <param name="intArray">Записываемый одномерный массив</param>
        public void PrintToFile(string fileName)
        {
            var str = "";
            fileName = AppDomain.CurrentDomain.BaseDirectory + fileName;
            if (File.Exists(fileName))
            {
                StreamWriter writer = new StreamWriter(fileName);               
                for (int i = 0; i < arr.Length; i++)
                    writer.WriteLine(arr[i]);
                writer.Close();
                Console.WriteLine($"Массив успешно записан в файл=> {fileName}");
            }
            else
            {          
                    Console.Write("Файл не найден, создать его?\n1 - Да / Нет - любая другая кнопка =>");
                    if (Console.ReadLine() == "1")
                    {                       
                        StreamWriter writer = new StreamWriter(fileName, true, Encoding.ASCII);                       
                        for (int i = 0; i < arr.Length; i++)
                            writer.WriteLine(arr[i]);
                    Console.WriteLine($"Файл успешно создан, записан и находится в базовой директории=> {fileName}");
                    writer.Close();
                    }
                    else                    
                        Console.WriteLine("Запись массива в файл остановлена пользователем.");
            }


        }
    }
}
