namespace task5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.Unicode;
			Console.InputEncoding = System.Text.Encoding.Unicode;


			string? source;
			string[] numbers;
			string[] operators;
			double num;
			double? result = 0.0;


			Console.WriteLine($"Введіть вираз: ");
			source = Console.ReadLine();

			if (source is not null)
			{
				numbers = source.Split(new char[] { ' ', '+', '-' }, StringSplitOptions.RemoveEmptyEntries);


				operators = source.Split(numbers, StringSplitOptions.RemoveEmptyEntries);


				result = double.Parse(numbers[0]);


				for (int i = 0, j = 1; i < operators.Length; ++i, ++j)
				{
					num = double.Parse(numbers[j]);

					switch (operators[i])
					{
						case "+":
							result += num;
							break;
						case "-":
							result -= num;
							break;
						default:
							break;
					}
				}


				Console.WriteLine($"Result: {result}");
			}
		}
	}
}