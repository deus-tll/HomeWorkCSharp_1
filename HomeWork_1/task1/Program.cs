namespace task1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string numStr;
			Int32 number;
			while (true)
			{
				Console.Write($"Input number from 1 to 100: ");

				numStr = Console.ReadLine();

				if (!Int32.TryParse(numStr, out number))
				{
					Console.WriteLine($"Incorrect data!");
					Console.ReadKey();
					Console.Clear();
					continue;
				}

				if (number > 100 || number < 1)
				{
					Console.WriteLine($"Wrong number!");
					Console.ReadKey();
					Console.Clear();
					continue;
				}
				else
					break;
			}

			if (number % 3 == 0)
				Console.WriteLine($"Fizz");

			else if (number % 5 == 0)
				Console.WriteLine($"Buzz");

			else
				Console.WriteLine(number);
		}
	}
}