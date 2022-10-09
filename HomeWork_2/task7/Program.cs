namespace task7
{
	internal class Program
	{
		struct statistic
		{
			public string? word;
			public int? count;

			public void setStatistic(string? word, int? count)
			{
				this.word = word;
				this.count = count;
			}
		}

		static private Int32 CountWords(String str, String desired)
		{
			String[] temp = str.Split(new[] { desired }, StringSplitOptions.None);
			return temp.Length - 1;
		}


		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.Unicode;
			Console.InputEncoding = System.Text.Encoding.Unicode;


			string? text = "To be, or not to be, that is the question, \n" +
						  "Whether 'tis nobler in the mind to suffer \n" +
						  "The slings and arrows of outrageous fortune, \n" +
						  "Or to take arms against a sea of troubles, fuck \n" +
						  "And by opposing end them? To die: to sleep; \n" +
						  "more; and by a sleep to say we end \n" +
						  "The heart-ache bitch bitch bitch and the thousand natural shocks \n" +
						  "That flesh is heir to, 'tis a consummation \n" +
						  "Devoutly to be wish'd. To die, to sleep.";


			string? result = text;


			string[]? badWords = {"die", "fuck", "bitch"};
			statistic[]? fullStatistic = new statistic[badWords.Length];
			int? count;


			int? length = badWords.Length;


			for (int i = 0; i < length; ++i)
			{
				count = CountWords(text, badWords[i]);


				fullStatistic[i].setStatistic(badWords[i], count);


				result = result.Replace(badWords[i], new string('*', badWords[i].Length));
			}


			Console.WriteLine($"Result: ");
			Console.WriteLine(result + "\n\n");


			for (int i = 0; i < length; i++)
				Console.WriteLine($"{fullStatistic[i].count} заміни слова \"{fullStatistic[i].word}\"");
		}
	}
}