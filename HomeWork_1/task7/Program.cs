namespace task7
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
			string? numStr1;
			string? numStr2;

			Int32 begin;
			Int32 end;

			while (true)
			{
				Console.Write($"Input begin of range: ");
				numStr1 = Console.ReadLine();

				if (!CheckingNum(numStr1, out begin))
					continue;
				else
					break;
			}

			while (true)
			{
				Console.Write($"Input end of range: ");
				numStr2 = Console.ReadLine();

				if (!CheckingNum(numStr2, out end))
					continue;
				else
					break;
			}


			if (begin > end)
			{
				Int32 tmp = begin;
				begin = end;
				end = tmp;
			}

			for (int i = begin; i <= end; ++i)
			{
				if (i % 2 == 0)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}