using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BC_HW_L4_Malov
//3. Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.
{
    public class Task3    
    {
        public Task3()
        { }
        
        public struct Accaunt
        {
            public string log;
            public string pas;

            public Accaunt(string login, string passward)
            {
                log = login;
                pas = passward;
            }            
        }
        /// <summary>
        /// Метод получения базы данных из файла
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
            static Accaunt[] GetArrAcc(string fileName)
            {           
                int len = 0;
                if (File.Exists(fileName))
                {
                    string[] str = File.ReadAllLines(fileName);                
                    if (str.Length % 2 == 0)
                    {
                        len = str.Length / 2;
                        int j = 0;
                        Accaunt[] tempAcc = new Accaunt[len];
                        for (int i = 0; i < str.Length; i++)
                        {
                            tempAcc[j].log = str[i];
                            tempAcc[j].pas = str[i + 1];
                            j++;
                            i++;
                        }
                    Console.WriteLine("База данных успешно взята из файла.");
                    return tempAcc;
                    }
                    else
                        throw new Exception("Файл иммет не корректное количество строк");
                }
                else
                    throw new FileNotFoundException();
            }
        /// <summary>
        /// Проверка пароля и логина, введённых пользователем с конкретным элементом базы данных
        /// </summary>
        /// <param name="login"></param>
        /// <param name="passward"></param>
        /// <param name="count"></param>
        /// <param name="accaunt"></param>
        /// <returns></returns>
        static bool CheckAnswer(string login, string passward, int count,Accaunt accaunt)
            {
                bool flag = false;

            if (accaunt.log == login)
                if (accaunt.pas == passward)
                {
                    Console.WriteLine("Вы успешно ввели правильную пару логин|пароль! Молодцом!)");
                    flag = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Был введён не корректный пароль к логину=> {login}");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    flag = true;
                }
            if (flag)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Не валидная пара логин/пароль\nОсталось {count} попыток");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
                return flag;
            }
        /// <summary>
        /// Проверка пароля и логина, введённых пользователем с базой данных
        /// </summary>
        /// <param name="login">логин пользователя</param>
        /// <param name="passward">пароль пользователя</param>
        /// <param name="count">число попыток</param>
        /// <param name="accaunt">имя структуры содержащей базу данных</param>
        /// <returns></returns>
        static bool CheckAnswer(ref int count,Accaunt[] accaunt)
        {            
            bool flag = true;
            if (count == 0)
            {
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine("Вы исчерпали все попытки.Выполнение прекращено.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                return false;
            }
            else
            {
                Console.Write("Ввдите логин => ");
                string login = Console.ReadLine();
                Console.Write("Ввдите пароль => ");
                string passward = Console.ReadLine();
                count--;
                for (int i = 0; i < accaunt.Length; i++)
                    if (accaunt[i].log == login)
                        if (accaunt[i].pas == passward)
                        {
                            Console.WriteLine("Вы успешно ввели правильную пару логин|пароль ! Молодцом!)");
                            flag = false;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Был введён не корректный пароль к логину=> {login}");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            flag = true;
                        }
                if (flag)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Не валидная пара логин/пароль\nОсталось {count} попыток");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
            }            
            return flag;
        }
        /// <summary>
        /// Запкск выполнения 3-го задания к 4-му уроку.
        /// </summary>
        /// <param name="fileName"></param>
        public void RunTask3(string fileName)
        {
            int count = 3;            
            Accaunt[] myAcc = GetArrAcc(fileName);
            Console.WriteLine("------------------ \nЧтобы пройти дальше вам нужно ввести правильную пару логин/пароль.");
            while (CheckAnswer(ref count ,myAcc));               
            
            Console.ReadKey();
            Console.Clear();
        }
    }
}

