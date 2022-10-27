namespace task5
{
	internal class Program
	{
		static void CreateAndFillFileRandom(int count, string path)
		{
			using (FileStream fs = new(path, FileMode.Create, FileAccess.Write, FileShare.None))
			{
				using (StreamWriter sw = new(fs))
				{
					Random r = new();
					for (int i = 0; i < count; ++i)
					{
						if (i == count - 1)
						{
							sw.Write(r.Next(-100000, 100000));
							break;
						}
						sw.WriteLine(r.Next(-100000, 100000));
					}
				}
			}
		}


		static void CreateAndFillFile(List<int> list, string path)
		{
			using (FileStream fs = new(path, FileMode.Create, FileAccess.Write, FileShare.None))
			{
				using (StreamWriter sw = new(fs))
				{
					for (int i = 0; i < list.Count; ++i)
					{
						if (i == list.Count - 1)
						{
							sw.Write(list[i]);
							break;
						}
						sw.WriteLine(list[i]);
					}
				}
			}
		}
		static void Main(string[] args)
		{
			int count = 100000;
			string pathToSource = "source.txt";


			CreateAndFillFileRandom(count, pathToSource);


			string[] sourceNumStr;
			List<int> positiveNumbers = new();
			List<int> negativeNumbers = new();
			List<int> twoDigitNumbers = new();
			List<int> fiveDigitNumbers = new();


			using (FileStream fs = File.OpenRead(pathToSource))
			{
				using (StreamReader sw = new(fs))
				{
					string tmp = sw.ReadToEnd();
					sourceNumStr = tmp.Split("\r\n");

					for (int i = 0; i < count; ++i)
					{
						int element = Convert.ToInt32(sourceNumStr[i]);

						if (element > 0)
							positiveNumbers.Add(element);

						if (element < 0)
							negativeNumbers.Add(element);

						if (element > 9 && element < 100)
							twoDigitNumbers.Add(element);

						if (element > 9999 && element < 100000)
							fiveDigitNumbers.Add(element);
					}
				}
			}


			CreateAndFillFile(positiveNumbers, "positiveNumbers.txt");
			CreateAndFillFile(negativeNumbers, "negativeNumbers.txt");
			CreateAndFillFile(twoDigitNumbers, "twoDigitNumbers.txt");
			CreateAndFillFile(fiveDigitNumbers, "fiveDigitNumbers.txt");


			Console.WriteLine($"Count of:\n" +
							  $"- positive numbers: {positiveNumbers.Count}\n" +
							  $"- negative numbers: {negativeNumbers.Count}\n" +
							  $"- two-digit numbers: {twoDigitNumbers.Count}\n" +
							  $"- five-digit numbers: {fiveDigitNumbers.Count}");
		}
	}
}