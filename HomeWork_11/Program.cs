using System;

namespace HomeWork_11
{
	internal class Program
	{
		static void Main(string[] args)
		{
			///1
			int n = 6765;
			Console.WriteLine(n.IsFibonacci());
			///


			///2
			string str = "one two three";
			Console.WriteLine(str.WordsCount());
			///


			///3
			Console.WriteLine(str.LengthOfLastWord());
			///


			///4
			string str1 = "({ x - y - z} * [x + 2y] - (z + 4x));";
			Console.WriteLine(str1.IsValidParenthesis());
			///


			///5
			int[] arr = new int[] { 20, 3, 7, 16, 4, 8, 89, 31 };
			arr = arr.Filtration(s => s % 2 == 0);

			foreach (int item in arr)
			{
				Console.Write($"{item} ");
			}
			///
		}
	}
}