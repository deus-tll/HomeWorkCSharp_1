namespace task2
{
	internal class Program
	{
		static bool CheckingNum(string? s, out Double n)
		{
			if (!Double.TryParse(s, out n))
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
			string? numStr1;
			string? numStr2;

			Double value;
			Double percent;

			while (true)
			{
				Console.Write($"Input value: ");
				numStr1 = Console.ReadLine();

				if (!CheckingNum(numStr1, out value))
					continue;
				else
					break;
			}

			while (true)
			{
				Console.Write($"Input percent: ");
				numStr2 = Console.ReadLine();

				if (!CheckingNum(numStr2, out percent))
					continue;
				else
					break;
			}

			Console.WriteLine($"{percent} percent of {value} = {value / 100 * percent}");
		}
	}

	
}