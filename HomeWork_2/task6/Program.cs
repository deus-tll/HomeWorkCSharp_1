using System;

namespace task6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.Unicode;
			Console.InputEncoding = System.Text.Encoding.Unicode;


			string? source;
			string[] separated;
			string[] modifiedSentences;
			string? result = "";


			Console.WriteLine($"Введіть текст: ");
			source = Console.ReadLine();


			if (source is not null)
			{
				separated = source.Split(new string[] { ". ", ".", "! ", "!", "? ", "?" }, StringSplitOptions.RemoveEmptyEntries);


				string[] separators = source.Split(separated, StringSplitOptions.RemoveEmptyEntries);


				modifiedSentences = new string[separated.Length];


				for (int i = 0; i < separated.Length; i++)
					modifiedSentences[i] = separated[i].Remove(0, 1).Insert(0, char.ToUpper(Convert.ToChar(separated[i][0])).ToString());


				for (int i = 0; i < modifiedSentences.Length; ++i)
					result += modifiedSentences[i] + separators[i];


				Console.WriteLine($"Result: {result}");
			}
		}
	}
}