namespace task3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string? number = "";

			for (int i = 0; i < 4; ++i)
			{
				Console.Write($"Input {i + 1} number: ");
				number += Console.ReadLine();
			}

			Console.WriteLine($"Result = {number}");
		}
	}
}