using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RemCSharp
{
	class Program
	{
		static void showDetails()
		{
			Console.WriteLine("Name of machine - " + Environment.MachineName);
			Console.WriteLine("User domain name - " + Environment.UserDomainName);
			Console.WriteLine("System directory - " + Environment.SystemDirectory);
			Console.WriteLine("User name - " + Environment.UserName);
			Console.WriteLine("Drives");
			foreach (var drive in Environment.GetLogicalDrives())
			{
				Console.WriteLine(drive);
			}
			Console.WriteLine();
			Console.WriteLine("OS version is " + Environment.OSVersion);

			Console.WriteLine("Numper of processors - " + Environment.ProcessorCount);
			Console.WriteLine("Version .NET" + Environment.Version);

			if (Environment.Is64BitOperatingSystem)
			{
				Console.WriteLine("Operating system 64x");
			}
			else
			{
				Console.WriteLine("Operating system 32x");
			}

		}

		static void showTypesOfData()
		{
			int i = 959325;
			Console.WriteLine("\nshowTypesOfData\n");
			Console.WriteLine($"c format:{i:c}");
			Console.WriteLine($"d5 format:{94:d5}");
			Console.WriteLine($"f3 format:{999.4346:f3}");
			Console.WriteLine($"n format:{46536999:n}");
			Console.WriteLine($"e format:{992349:e}");
			Console.WriteLine($"x format:{92399:x}");
		}

		static void functionalityValues()
		{

			Console.WriteLine("\nfunctionalityValues\n");
			Console.WriteLine("Max value int : " + int.MaxValue);
			Console.WriteLine("Max value uint : " + uint.MaxValue);
			Console.WriteLine("PositiveInfinity double : " + double.PositiveInfinity);
			Console.WriteLine("NaN double : " + double.NaN);
			Console.WriteLine("Max double : " + double.MaxValue);
			Console.WriteLine("Epsilon double : " + double.Epsilon);
			Console.WriteLine("NegativeInfinity double : " + double.NegativeInfinity);
		}

		static void functionalDateTime()
		{
			Console.WriteLine("\nfunctionalDateTime\n");
			DateTime dt = new DateTime(2019, 5, 16, 18, 30, 30);
			Console.WriteLine(dt + $" Tiks : {dt.Ticks}  Day of week : {dt.DayOfWeek}");
			dt = dt.AddMonths(3);
			Console.WriteLine(dt + $" Day of week : {dt.DayOfWeek}");
			TimeSpan ts = new TimeSpan(26, 555, 35);
			Console.WriteLine($"TimeSpan {ts}");
			Console.WriteLine($"TimeSpan Zero {TimeSpan.Zero}");
			Console.WriteLine($"TimeSpan max {TimeSpan.MaxValue}");
			Console.WriteLine($"TimeSpan min {TimeSpan.MinValue}");
			Console.WriteLine($"DateTime min {DateTime.MinValue}");
			Console.WriteLine($"DateTime max {DateTime.MaxValue}");
		}

		static void New()
		{
			Console.WriteLine("\nNew feature\n");
			int a = 0b0001_0001;
			int b = 0b0001000111;
			Console.WriteLine($"This is 0b0001_0001 : {Convert.ToString(a,8)}\nThis is 0b0001000111 : {Convert.ToString(b, 8)}");
			//вывод в 8-ричной системе счисления
		}

		static void KeyWordChecked()
		{
			Console.WriteLine("\nKeyWordChecked\n");
			byte a = 200;
			byte b = 201;
			byte c = 0;
			try
			{
				//при переполнении в этом блоке будет сгенерировано испключение
				checked
				{
					c = (byte)(a + b);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
		//ключевое слово unchecked используется при включёном флаге /checked в свойствах проекта

		static void Types()
		{
			Console.WriteLine("\nTypes\n");
			var myInt = 10;
			Console.WriteLine("Type : " + myInt.GetType());
			Console.WriteLine("TypeCode : " + myInt.GetTypeCode());
			Console.WriteLine("TypeOf : " + typeof(int));
			Console.WriteLine("NameOf : " + nameof(myInt));
		}

		static void useBigInteger()
		{
			BigInteger biggy = BigInteger.Parse("99999999999999999999999999999999999999999999999999999999999999");
			Console.WriteLine($"Value = {biggy}");
			BigInteger secondBiggy = biggy * 77777777777777777;
			Console.WriteLine($"Really biggy = {secondBiggy}");
		}

		static void SystemString()
		{
			string myStr = @"upupupupu
					bou	
							bouuuuuuuu";
			Console.WriteLine(myStr);
			StringBuilder builder = new StringBuilder("string builder");
			builder.Append("\n");
			builder.AppendLine("this is bulshit\n");
			builder.AppendLine("holly bulshit\n");
			Console.WriteLine(builder);
			builder.Replace("string", "String");
			builder.Insert(0, "demostration >>>>>\n");
			Console.WriteLine(builder);
		}

		static void Conditions()
		{
			Console.WriteLine("\nConditions\n");
			double i = 10;
			Console.WriteLine(i > 0 && i < 11
				? "i > 0 and i < 11"
				: "not");

			Console.WriteLine("\nSwitch-Case\n");
			switch (i)
			{
				case 10.0:
					Console.WriteLine("this is 10");
					break;
				default:
					Console.WriteLine("i can't identify it:(");
					break;
			}

			string str = "piska";
			switch (str)
			{
				case "piska":
					Console.WriteLine("this is piska");
					break;
				default:
					Console.WriteLine("i can't identify it:(");
					break;
			}

			DayOfWeek day = DayOfWeek.Saturday;
			switch (day)
			{
				case DayOfWeek.Sunday:
				case DayOfWeek.Saturday:
					Console.WriteLine("Yeeeeeeeee WEEKEND!");
					break;
				default:
					Console.WriteLine("i can't identify it:(");
					break;
			}

			object obj = "st";
			switch (obj)
			{
				case int j:
					Console.WriteLine("this is int");
					break;
				case string s when s == "str":
					Console.WriteLine("this is string str");
					break;
				case string s when s == "sti":
					Console.WriteLine("this is string sti");
					break;
				case double d:
					Console.WriteLine("this is double");
					break;
				default:
					Console.WriteLine("i can't identify it:(");
					break;
			}
		}

		static void Main(string[] args)
		{
			Console.Clear();
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.Yellow;
			showDetails();
			Console.WriteLine();
			showTypesOfData();
			Console.WriteLine();
			functionalityValues();
			Console.WriteLine();
			functionalDateTime();
			Console.WriteLine();
			useBigInteger();
			Console.WriteLine();
			New();
			Console.WriteLine();
			SystemString();
			Console.WriteLine();
			KeyWordChecked();
			Console.WriteLine();
			Types();
			Console.WriteLine();
			Conditions();
			Console.ReadLine();
			
		}
	}
}
