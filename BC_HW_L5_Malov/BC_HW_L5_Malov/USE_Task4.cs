using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BC_HW_L5_Malov
//4. Задача ЕГЭ.
//*На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней
//школы.В первой строке сообщается количество учеников N, которое не меньше 10, но не
//превосходит 100, каждая из следующих N строк имеет следующий формат:
//<Фамилия> <Имя> <оценки>,
//где<Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не
//более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по
//пятибалльной системе. <Фамилия> и<Имя>, а также<Имя> и<оценки> разделены одним пробелом.
//Пример входной строки:
//Иванов Петр 4 5 3
//Требуется написать как можно более эффективную программу, которая будет выводить на экран
//фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики,
//набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.

{
    /// <summary>
    /// Класс с данными школьников
    /// </summary>
    public class USE_Task4
    {
        string surname { get; set; }
        string name { get; set; }
        int[] score { get; set; }
        double avscore { get; set; }
        /// <summary>
        /// Пустой конструктор
        /// </summary>
        public USE_Task4()
        {
            surname = "";
            name = "";
            score= new int[3];
            avscore = (score[0]+score[1]+score[2])/3;
        }
        /// <summary>
        /// конструктор заполнения класса из строки
        /// </summary>
        /// <param name="student"></param>
        public USE_Task4(string student)
        {
            score= new int[3];
            string[]tempstu=student.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            if (tempstu.Length == 5 && int.TryParse(tempstu[2], out score[0]) && int.TryParse(tempstu[3], out score[1]) && int.TryParse(tempstu[4], out score[2]))
            {
                surname = tempstu[0];
                name = tempstu[1];
                avscore = (score[0] + score[1] + score[2]) / 3.0;
            }
            else
                throw new Exception("Строка имеет не корректный формат данных");
        }
        /// <summary>
        /// Перегрузка метода Ту Стринг
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return surname +" "+ name+ $" получил оценки: {score[0]} {score[1]} {score[2]} |средний балл студента=> {avscore:0.00}";
        }

        /// <summary>
        /// Поиск и вывод на экран студентов с самыми низкими средними баллами
        /// </summary>
        /// <param name="student"></param>
        public void GetLoosers(USE_Task4[] student)
        {            
          student = (student.OrderBy(a => a.avscore)).ToArray<USE_Task4>();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Список учеников с худшим средним баллом за экзамены:\n{student[0].ToString()}\n{student[1]}\n{student[2]}");
            for (int i = 3; i < student.Length; i++)
                if (student[i].avscore == student[2].avscore)
                    Console.WriteLine(student[i]);
                else
                    break;            
        }
        /// <summary>
        /// Метод заполнения массива класса школьников из файла
        /// </summary>
        /// <param name="fileName">полный путь к файлу</param>
        public USE_Task4[] GetBaseStudent(string fileName)
        {           
            if (File.Exists(fileName))
            {
                string[] tempstr = File.ReadAllLines(fileName);
                if (int.TryParse(tempstr[0], out int len))
                {
                    USE_Task4[] students = new USE_Task4[len];
                    for (int i = 0; i < students.Length; i++)
                        students[i] = new USE_Task4(tempstr[i + 1]);
                    return students;
                }
                else
                    throw new Exception("В файле не корректные данные!");
            }
            else
                throw new FileNotFoundException();
        } 
        static void PrintDataBase(USE_Task4[] database)
        {
            foreach (USE_Task4 el in database)
                Console.WriteLine(el);
        }
        public void RunTask4(string fileName)
        {
            USE_Task4[] basetask4;
            Console.WriteLine("Задание 4 к уроку 5.");
            Console.WriteLine("Даны следующие результаты сдачи экцаменов экспериментального класса 2003:");
            basetask4 = GetBaseStudent(fileName);
            PrintDataBase(basetask4);
            GetLoosers(basetask4);
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }

    }
}
