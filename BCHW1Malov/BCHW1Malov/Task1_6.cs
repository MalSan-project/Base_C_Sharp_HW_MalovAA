using System;
using System.Collections.Generic;
using System.Text;

namespace BCHW1Malov
{
	public class Task1_6
	////6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).

	{

		public Task1_6()
		{
		}
		public void PrintPlease(string str, int x, int y)
		{
			Console.SetCursorPosition(x, y);
			Console.WriteLine(str);
		}
		public void Pouse()
        {
			Console.ReadLine();
        }
		public void Clear()
        {
			Console.Clear();
        }
	}
}
