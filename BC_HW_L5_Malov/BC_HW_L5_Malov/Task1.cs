using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BC_HW_L5_Malov
//1. Создать программу, которая будет проверять корректность ввода логина. 
//   Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
//а) без использования регулярных выражений;
//б) с использованием регулярных выражений.
{
    public class Task1    
    {
        public Task1()
        { 
        }
        
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
        /// Метод проверки корректности введёных логина и пароля без использования регулярных выражений
        /// </summary>
        /// <param name="log"></param>
        /// <param name="pas"></param>
        /// <returns></returns>
        static bool CheckCharTusk1(string log, string pas)        
        {
            bool flag = true;
            if (log.Length <= 10 && log.Length >= 2)
                if (pas.Length <= 10 && pas.Length >= 2)                    
                {                    
                    if (char.IsDigit(log[0]) || char.IsDigit(pas[0]))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("First char of login or password not be a Digit");
                            Console.ResetColor();
                            flag= false;
                        }
                    else
                    {
                        for (int i = 0; i < log.Length; i++)
                            if (char.IsLetterOrDigit(log[i]) && ((log[i] >= 'a' && log[i] <= 'z') || (log[i] >= 'A' && log[i] <= 'Z')))
                                flag = true;
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("not correct char in login!");
                                Console.ResetColor();
                                return false;                                
                            }
                        for (int i = 0; i < pas.Length; i++)
                            if (char.IsLetterOrDigit(pas[i]) && ((pas[i] >= 'a' && pas[i] <= 'z') || (pas[i] >= 'A' && pas[i] <= 'Z')))
                                flag = true;
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("not correct char in password!");
                                Console.ResetColor();
                                return false;                               
                            }
                    }

                }
                else
                {
                    Console.WriteLine("Not correct length of password");
                    return false;
                }
            else
            {
                Console.WriteLine("Not correct length of login");
                return false;
            }
            return flag;
        }
        /// <summary>
        /// Метод проверки корректности введёных логина и пароля с использованием регулярных выражений
        /// </summary>
        /// <param name="log"></param>
        /// <param name="pas"></param>
        /// <returns></returns>
        static bool CheckCharTusk1Reg(string logorpas)
        {
            Regex myreg = new Regex("^[a-zA-Zа-яА-Я][a-zA-Zа-яА-Я0-9]{2,9}$");           
            if (!myreg.IsMatch(logorpas))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("not correct format!");
                Console.ResetColor();
                return false;
            }
            else
                return true;

        }

        /// <summary>
        /// Проверка пароля и логина, введённых пользователем с базой данных и форматом.
        /// </summary>
        /// <param name="login">логин пользователя</param>
        /// <param name="passward">пароль пользователя</param>
        /// <param name="count">число попыток</param>
        /// <param name="accaunt">имя структуры содержащей базу данных</param>
        /// <returns></returns>
        static bool CheckAnswer(ref int count,Accaunt[] accaunt)
        {
            string login="", passward = "";
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
                do
                {
                    Console.Write("Ввдите логин => ");
                    login = Console.ReadLine();
                    CheckCharTusk1Reg(login);
                    Console.Write("Ввдите пароль => ");
                    passward = Console.ReadLine();
                    CheckCharTusk1Reg(passward);
                }
                while (!CheckCharTusk1(login, passward));
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
        /// Запкск выполнения 1-го задания к 5-му уроку.
        /// </summary>
        /// <param name="fileName"></param>
        public void RunTask1(string fileName)
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

