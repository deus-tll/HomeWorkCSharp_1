namespace task_3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string? pathToSource;
			string? pathToModerationFile;
			string? sourceText;
			string[] moderationWords;


			Console.WriteLine($"Input path to source: ");
			pathToSource = Console.ReadLine();


			Console.WriteLine($"Input path to file with words for moderation: ");
			pathToModerationFile = Console.ReadLine();


			if (pathToModerationFile is not null && pathToSource is not null)
			{
				FileInfo fileInfo1 = new FileInfo(pathToModerationFile);
				FileInfo fileInfo2 = new FileInfo(pathToSource);


				if (fileInfo1.Exists && fileInfo2.Exists)
				{
					using (FileStream fs = File.OpenRead(pathToModerationFile))
					{
						using (StreamReader sr = new(fs))
						{
							string tmp;
							tmp = sr.ReadToEnd();
							moderationWords = tmp.Split(' ', StringSplitOptions.RemoveEmptyEntries);
						}
					}


					using (FileStream fs = File.OpenRead(pathToSource))
					{
						using (StreamReader sr = new(fs))
						{
							sourceText = sr.ReadToEnd();
						}
					}


					for (int i = 0; i < moderationWords.Length; ++i)
					{
						sourceText = sourceText.Replace(moderationWords[i], new string('*', moderationWords[i].Length));
					}


					using (FileStream fs = File.OpenWrite(pathToSource))
					{
						using (StreamWriter sr = new(fs))
						{
							sr.Write(sourceText);
						}
					}
				}
				else
				{
					Console.WriteLine($"Something went wrong.");
				}
			}




		}
	}
}