using System.ComponentModel;

namespace task5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string? str;

			Console.Write($"Imput Date: ");
			str = Console.ReadLine();

			DateTime dateTime = new DateTime();
			dateTime = Convert.ToDateTime(str);

			switch (dateTime.Month)
			{
				case 12:
				case 1:
				case 2:
					Console.WriteLine($"Winter {dateTime.DayOfWeek}");
					break;
				case 3:
				case 4:
				case 5:
					Console.WriteLine($"Spring {dateTime.DayOfWeek}");
					break;
				case 6:
				case 7:
				case 8:
					Console.WriteLine($"Summer {dateTime.DayOfWeek}");
					break;
				case 9:
				case 10:
				case 11:
					Console.WriteLine($"Autumn {dateTime.DayOfWeek}");
					break;
				default:
					break;
			}

		}
	}
}