using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChapter4_4
{
	struct Point
	{
		public int x;
		public int y;

		public Point(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public void inc()
		{
			x++; y++;
		}

		public void dec()
		{
			x--; y--;
		}

		public void Display()
		{
			Console.WriteLine($"X = {x}; Y = {y}");
		}
	}

	class PointRef
	{
		public int x;
		public int y;

		public void Display()
		{
			Console.WriteLine($"X = {x}; Y = {y}");
		}
	}

	
	class Program
	{
		static void TestRefValue(PointRef p)
		{
			p.x = 10; // оригинальный объект изменится
			p = new PointRef() { x = 4, y = 4 }; //копия ссылки указывает на новый объект, но не оригинальная ссылка
			p.x = 1312; // оригинальный объект не изменится
		}

		static void TestRefRef(ref PointRef p)
		{
			p.x = 10; // оригинальный объект изменится
			p = new PointRef() { x = 4, y = 4235 }; //оригинальная ссылка указывает на новый объект
			p.x = 1312; // оригинальный объект не изменится
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Struct Point");
			
			Point p = new Point() { x = 3, y = 6};
			p.Display();
			Point p2 = default;
			p2.Display();
			Point p3 = new Point(3, 6);
			p3.inc();
			p3.Display();

			Point p4 = p2;
			Console.WriteLine("p4 = p2, p4.inc() ===== p4.display and p2.display");
			p4.inc();
			p4.Display();
			p2.Display();


			Console.WriteLine("pr2 = pr1, pr2.x = 5 ===== pr2.display and pr1.display");
			PointRef pr1 = new PointRef() { x = 4, y = 5 };
			PointRef pr2 = new PointRef();
			pr1 = pr2; //pr1 и pr2 указывают на один и тот же объект
			pr2.x = 5;
			pr2.Display();
			pr1.Display();

			TestRefValue(pr1);
			pr1.Display(); // pr1 останется указывать на этот объект
			pr2.Display();
			TestRefRef(ref pr1);
			pr1.Display(); // pr1 теперь указывает на новый объект, который был создан в методе
			pr2.Display(); // pr2 всё ещё указывает на первый объект
		}
	}
}
