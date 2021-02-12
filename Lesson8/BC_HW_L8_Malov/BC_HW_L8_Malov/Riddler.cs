using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_HW_L8_Malov
{
    public class Riddler
    {
        public string question { get; set; }
        public List<string> answer { get; set; }
        public string comment { get; set; }
        Random rnd = new Random();

        /// <summary>
        /// пустой конструктор
        /// </summary>
        public Riddler()
        {
            question = "";
            answer = new List<string>();
            comment = "";
        }
        /// <summary>
        /// Заполнение класса напрямую
        /// </summary>
        /// <param name="_question">строка с вопросом</param>
        /// <param name="_answer">массив строк с ответами</param>
        /// <param name="_comment">строка с комментариями к вопросу</param>
        public Riddler(string _question, string[] _answer, string _comment)
        {
            question = _question;            
            comment = _comment;
            foreach (string el in _answer)
                answer.Add(el);
        }
        /// <summary>
        /// стандартный метод паузы и очистки консоли
        /// </summary>
        public void PauseAndClear()
        {
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
        /// <summary>
        /// Метод заполнения массива загадок из файла
        /// </summary>
        /// <param name="fileName">полный путь к файлу</param>
        /// <returns></returns>
        public Riddler[] GetDataBase(string fileName)
        {
            int j = 0;
            string[] database;
            if (File.Exists(fileName))
            {
                database = File.ReadAllLines(fileName);
                if (database.Length % 3 == 0)
                {
                    Riddler[] game = new Riddler[database.Length / 3];
                    for (int i = 0; i < database.Length; i = i + 3)
                    {
                        game[j] = new Riddler();
                        game[j].question = database[i];
                        string[] tempanswer = database[i + 1].Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string el in tempanswer)
                            answer.Add(el);
                        game[j].comment = database[i + 2];
                        j++;
                    }
                    return game;
                }
                else
                {
                    throw new Exception("не корректный формат файла");
                }
            }
            else
                throw new FileNotFoundException();
        }
        public void PrintAnswer()
        {
            foreach (string el in answer)
                Console.Write(el + " | ");
        }
        public string ToStringAnswer()
        {
            string tempanswer="";
            foreach (string el in answer)
                tempanswer=tempanswer+el+"|";
            return tempanswer;
        }

        /// <summary>
        /// Метод запуска игры с рандомного вопроса
        /// </summary>
        /// <param name="game">массив загадок</param>
        public void RunRandomQuestion(Riddler[] game)
        {
            string ansUs = "";
            int numbquest;
            Riddler[] tempgame = game;
            do
            {
                numbquest = rnd.Next(0, tempgame.Length);
                Console.WriteLine($"{tempgame[numbquest].question}");
                if (CheckAnswerUs(tempgame[numbquest]))
                {
                    tempgame = DeleteRiddle(numbquest, tempgame);
                }
                else
                {
                    Console.WriteLine($"Ответ не верный!\nПравельные ответы: ");
                    tempgame[numbquest].PrintAnswer();
                    Console.WriteLine("\n" + tempgame[numbquest].comment);
                    tempgame = DeleteRiddle(numbquest, tempgame);
                }
                Console.Write($"Осталось {tempgame.Length} вопросов\nДля выхода нажмите 0\nПродолжаем?");
                ansUs = Console.ReadLine();
                Console.Clear();

            } while (tempgame.Length != 0 && ansUs != "0");
            Console.WriteLine("Спасибо за игру. Увидимся на следующий работах!");
        }
        /// <summary>
        /// Метод удаления сыгранной загадки
        /// </summary>
        /// <param name="number">индекс сыгранный загадки</param>
        /// <param name="game">массив загадок</param>
        /// <returns></returns>
        static Riddler[] DeleteRiddle(int number, Riddler[] game)
        {
            int j = 0;
            Riddler[] tempgame = new Riddler[(game.Length - 1)];
            for (int i = 0; i < game.Length; i++)
                if (i != number)
                {
                    tempgame[j] = game[i];
                    j++;
                }
            return tempgame;
        }
        /// <summary>
        /// Проверка пользовательского ответа на загадку
        /// </summary>
        /// <param name="stage">активная загадка</param>
        /// <returns></returns>
        public bool CheckAnswerUs(Riddler stage)
        {
            string ansUs;
            int count = 0;
            Console.Write("Ваш ответ?=>");
            ansUs = Console.ReadLine();
            foreach (string el in stage.answer)
                if (el.ToLower() == ansUs.ToLower())
                {
                    Console.WriteLine("И это...");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"ПРАВИЛЬНЫЙ ОТВЕТ! \n {stage.comment}\nСписок ответов, считающихся правильными: ");
                    stage.PrintAnswer();
                    PauseAndClear();
                    return true;
                }
            return false;
        }
        
        public void RunTask5(string fileName)
        {
            Console.WriteLine("");
            Riddler[] game = GetDataBase(fileName);
            RunRandomQuestion(game);
            PauseAndClear();
        }
    }
}
    
