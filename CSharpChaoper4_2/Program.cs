using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChaoper4_2
{
	class Program
	{
		static void addOut(int x, int y, out int ans)
		{
			ans = x + y;
		}

		static void addRef(ref int x, ref int y, ref int ans)
		{
			ans = x + y;
			x++;
			y++;
		}

		static int GetValueOfArray(int[] arr, int index)
		{
			return arr[index];
		}

		static ref int GetRefOfArray(int[] arr, int index)
		{
			return ref arr[index];
		}

		static double AverageParams(params double[] values)
		{
			double res = 0.0;
			Console.WriteLine($"You sent me {values.Length} doubles");
			foreach (double item in values)
			{
				res += item;
			}
			return res / values.Length;
		}

		static void UnnesessaryParams(int x, int y = 4)
		{
			Console.WriteLine("result is " + (x + y));
		}

		static void Main(string[] args)
		{
			int x = 5, y = 10;

			Console.WriteLine("Test out");
			addOut(x, y, out int an); // не обязательно до этого объявлять переменную
			Console.WriteLine(an);
			int.TryParse("2345fd", out int c); //если не надо значение, то применить out int _
			Console.WriteLine(c); // выведет дефолтное значение для int


			Console.WriteLine("\nTest ref");
			Console.WriteLine($"x = {x}, y = {y}, an = {an}");
			addRef(ref x, ref y, ref an);
			Console.WriteLine($"x = {x}, y = {y}, an = {an}");
			addRef(ref x, ref y, ref an);
			Console.WriteLine($"x = {x}, y = {y}, an = {an}");


			Console.WriteLine("\nTest link and value");
			int[] arr = { 1, 2, 3, 4, 5 };
			int val = GetValueOfArray(arr, 3); //функция возвращает значение, не ссылку
			val = 5;
			Console.WriteLine("val = " + val);
			Console.WriteLine("arr[3] = " + arr[3]); //массив остаётся без изменений

			ref int val2 = ref GetRefOfArray(arr, 0); //функция возвращает ссылку на элемент массива
			val2 = 113;
			Console.WriteLine("val = " + val2); //теперь val2 ссылка на arr[0]
			Console.WriteLine("arr[0] = " + arr[0]); //массив меняется
			val2 = -123;
			Console.WriteLine("arr[0] = " + arr[0]);


			Console.WriteLine("\nTest params");
			double res = AverageParams();
			Console.WriteLine("Average is " + res);

			res = AverageParams(12, 123.3, 12.0);
			Console.WriteLine("Average is " + res);

			res = AverageParams(1,2,3,4,5);
			Console.WriteLine("Average is " + res);

			Console.WriteLine("\nTest Unnesessary params");
			UnnesessaryParams(2); //сложить 2 и 4
			UnnesessaryParams(2, 5); //сложить 2 и 5
			UnnesessaryParams(y: 5, x: 10); //аргументы в другом порядке
		}
	}
}
