using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11
{

	internal static class ExtensionMethod
	{
		/////////////
		private static bool IsSquare(double number)
		{
			double tmp = Math.Sqrt(number);

			return tmp - Math.Floor(tmp) == 0;
		}
		public static bool IsFibonacci(this int number)
		{
			double tmp1 = 5 * Math.Pow(number, 2) + 4;
			double tmp2 = 5 * Math.Pow(number, 2) - 4;

			return (IsSquare(tmp1) || IsSquare(tmp2)) || (IsSquare(tmp1) && IsSquare(tmp2));
		}
		/////////////


		/////////////
		public static int WordsCount(this string str)
		{
			string[] words = str.Split(' ');

			return words.Length;
		}
		/////////////


		/////////////
		public static int LengthOfLastWord(this string str)
		{
			string[] words = str.Split(' ');

			return words[words.Length - 1].Length;
		}
		/////////////


		/////////////
		public static bool IsValidParenthesis(this string str)
		{
			Stack<char> stack = new();

			foreach (var c in str)
			{
				switch (c)
				{
					case '(':
					case '[':
					case '{':
						stack.Push(c);
						break;

					case ')':
						if (stack.Count == 0) return false;
						if (stack.Pop() != '(') return false;
						break;
					case ']':
						if(stack.Count == 0) return false;
						if(stack.Pop() != '[') return false;
						break;
					case '}':
						if (stack.Count == 0) return false;
						if(stack.Pop() != '{') return false;
						break;
				}
			}

			return stack.Count == 0;
		}
		/////////////


		/////////////
		public static int[] Filtration(this int[] arr, Predicate<int> predicate)
		{
			int[] newArr = Array.FindAll<int>(arr, predicate);

			return newArr;
		}
		/////////////
	}
}
