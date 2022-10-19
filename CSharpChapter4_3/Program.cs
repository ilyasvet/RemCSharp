using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChapter4_3
{
	enum EmpType : long // нумерация в long (по умолчанию int)
	{
		Manager = 102, // по умолчанию = 0
		Grunt, // = 103
		Contractor, // = 104
		VicePresident, // = 105
		// нумерация не обязательно должна быть последовательной и уникальной
	}

	class Program
	{
		static void AskForBonus(EmpType e)
		{
			switch (e)
			{
				case EmpType.Manager:
					Console.WriteLine("Ok. Let's do this");
					break;
				case EmpType.Grunt:
					Console.WriteLine("Are you serious???");
					break;
				case EmpType.Contractor:
					Console.WriteLine("Maybe too much?");
					break;
				case EmpType.VicePresident:
					Console.WriteLine("Of course");
					break;
				default:
					Console.WriteLine("i dont know");
					break;
			}
		}

		static void GetDataEnum(Enum e)
		{
			Console.WriteLine();
			Console.WriteLine($"Information about enum : {e.GetType().Name}"); // получаем имя перечисления (EmpType)
			Console.WriteLine($"Type is {Enum.GetUnderlyingType(e.GetType()).Name}"); // получаем тип перечисления (long)
			Array arr = Enum.GetValues(e.GetType()); // получаем массив членов перечисления
			Console.WriteLine($"Enum has {arr.Length} members");
			foreach (var item in arr)
			{
				Console.WriteLine($"{item}\t {item:d}");
			}
		}

		static void Main(string[] args)
		{
			EmpType emp = EmpType.Contractor;
			DayOfWeek day = DayOfWeek.Monday;
			ConsoleColor color = ConsoleColor.Red;

			AskForBonus(emp);

			Console.WriteLine("Type is " + Enum.GetUnderlyingType(typeof(EmpType)));
			Console.WriteLine($"Emp is a {emp} or value {emp:d}");

			GetDataEnum(emp);
			GetDataEnum(day);
			GetDataEnum(color);


		}
	}
}
