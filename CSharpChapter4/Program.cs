using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChapter4
{
	class Program
	{
		static int[] CreateArray()
		{
			int[] array = new int[10];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = i;
			}
			return array;
		}

		static void ShowArray(int[] array)
		{
			foreach (int i in array)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
		}

		static void ShowObjectArray(object[] array)
		{
			foreach (object i in array)
			{
				Console.WriteLine(i + "\t" + i.GetType());
			}
		}

		static void MethodsArray(int[] array)
		{
			Console.WriteLine("\nMethodsArray");
			ShowArray(array);
			Console.WriteLine("array length " + array.Length);
			Array.Reverse(array);
			Console.WriteLine("reversed array");
			ShowArray(array);
			Array.Clear(array, 0, array.Length);
			Console.WriteLine("cleared array");
			ShowArray(array);
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Common array");

			int[] array = CreateArray();
			ShowArray(array);


			int[] array2 = new int[] { 1, 2, 3, 4 };
			ShowArray(array2);
			
			int[] array3 = { 1, 2, 3, 4, 0, 0, 0 };
			ShowArray(array3);

			object[] arrayObj = new object[5];

			Console.WriteLine("\nObject array");

			arrayObj[0] = 2;
			arrayObj[1] = 12.4;
			arrayObj[2] = '5';
			arrayObj[3] = "str";
			arrayObj[4] = false;
			ShowObjectArray(arrayObj);
			arrayObj[2] = 6666;
			Console.WriteLine();
			ShowObjectArray(arrayObj);


			int[,] matrix = new int[5, 13];


			Console.WriteLine("\nRectangle array");

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] = i + j;
				}
			}

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write(matrix[i,j] + "\t");
				}
				Console.WriteLine();
			}

			Console.WriteLine("\nStairs array");

			int[][] matrix2 = new int[5][];

			for (int i = 0; i < matrix2.Length; i++)
			{
				matrix2[i] = CreateArray();
			}
			foreach  (int[] arr in matrix2)
			{
				ShowArray(arr);
			}

			MethodsArray(array);
		}
	}
}
