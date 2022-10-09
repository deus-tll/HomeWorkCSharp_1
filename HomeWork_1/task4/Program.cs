namespace task4
{
	internal class Program
	{
		static bool CheckingNum(string? s, out Int32 n)
		{
			if (!Int32.TryParse(s, out n))
			{
				Console.WriteLine($"Incorrect data!");
				Console.ReadKey();
				Console.Clear();
				return false;
			}
			return true;
		}


		static void Main(string[] args)
		{
			string? numberStr;
			Int32 number;


			while (true)
			{
				Console.Write($"Input a six-digit number: ");
				numberStr = Console.ReadLine();

				if (!CheckingNum(numberStr, out number))
					continue;

				else if (numberStr.Length > 6)
				{
					Console.WriteLine($"It's not a six-digit number!");
					Console.ReadKey();
					Console.Clear();
					continue;
				}
				else
					break;
			}


			Int32 digit1;
			Int32 digit2;
			string? tmpStr;


			while (true)
			{
				Console.WriteLine($"Enter the digits to be swapped(1 - 6):");

				Console.Write($"First - ");
				tmpStr = Console.ReadLine();

				if (!CheckingNum(tmpStr, out digit1))
					continue;
				if (digit1 > 6 || digit1 < 1)
				{
					Console.WriteLine($"Incorrect!");
					Console.ReadKey();
					Console.Clear();
					continue;
				}
				else
					break;
			}


			Console.Clear();


			while (true)
			{
				Console.WriteLine($"Enter the digits to be swapped(1 - 6):");

				Console.WriteLine($"First - {digit1}");
				Console.Write($"Second - ");
				tmpStr = Console.ReadLine();

				if (!CheckingNum(tmpStr, out digit2))
					continue;
				if (digit2 > 6 || digit2 < 1)
				{
					Console.WriteLine($"Incorrect!");
					Console.ReadKey();
					Console.Clear();
					continue;
				}
				else
					break;
			}
			

			char c = numberStr[digit1 - 1];

			numberStr = numberStr.Remove(digit1 - 1, 1).Insert(digit1 - 1, numberStr[digit2 - 1].ToString());

			numberStr = numberStr.Remove(digit2 - 1, 1).Insert(digit2 - 1, c.ToString());

			Console.WriteLine($"Result - {numberStr}");
		}
	}
}