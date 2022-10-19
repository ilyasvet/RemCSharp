using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChapter4_5
{
	struct Point
	{
		public int x;
		public int y;

		public (int posX, int posY) GetValues() => (x, y);
	}

	class Program
	{
		static (int, int, int) GetTuple()
		{
			return (1, 2, 4);
		}


		static void Main(string[] args)
		{
			int? a = null;
			Nullable<int> b = 1; //другая запись
			Console.WriteLine(typeof(int?));
			if (a.HasValue)
			{
				Console.WriteLine("a has value! = " + a);
			}
			else
			{
				Console.WriteLine("a = null");
			}
			Console.WriteLine($"{a ?? b}");
			args = null;
			Console.WriteLine($"Args has {args?.Length} args"); //ничего не выведет в скобках

			Console.WriteLine("\nTUPLES!!!\n");

			(string str, int inty, string str2) values = ("st", 4, "stra");
			var values2 = (First:"str2", 24, "stoooo"); // вот так назвать first можно только при использовании var

			Console.WriteLine("Вывод кортежа " + values);
			Console.WriteLine(values2);
			Console.WriteLine(values.inty); // выведет 4
			Console.WriteLine(values2.First); // выведет str2

			Console.WriteLine("Тип кортежа1 " + values.GetType());
			Console.WriteLine("Тип кортежа2 " + values2.GetType());

			var values3 = new {pr1 = "first", pr2 = 4 }; //нельзя изменять
			Console.WriteLine("Тип кортежа3 " + values3.GetType());
			// values3.pr2 = 12; = ошибка компиляции
			var values4 = values2; // копируется значение, значимый тип
			values2.Item2 = 123;
			Console.WriteLine(values4.Item2); // выведет 24, кортежи - значимые типы


			Console.WriteLine("\nFunctions\n");

			var vals = GetTuple();
			Console.WriteLine($"{vals.Item1}, {vals.Item2}, {vals.Item3}");


			var (first, second, third) = GetTuple();
			Console.WriteLine($"{first}, {third}, {second}");

			var (f, _, t) = GetTuple();
			Console.WriteLine($"{f},{t}");

			Point p1 = new Point() { x = 4, y = 4 };
			(int x, int y) vasl = p1.GetValues();
			Console.WriteLine($"\nx = {vasl.x}; y = {vasl.y}");

		}
	}
}
