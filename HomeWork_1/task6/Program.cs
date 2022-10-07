namespace task6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string? choice;
			string? t;
			Double? result;


			Console.Write($"Temperature: ");
			t = Console.ReadLine();


			Console.Write($"1 - to fahrenheit/ 2 - to celsius: ");
			choice = Console.ReadLine();


			switch (Convert.ToInt32(choice))
			{
				case 1:
					result = Convert.ToDouble(t) * 1.8 + 32;
					Console.WriteLine($"Temperature {t} from celsius to fahrenheit = {result}");
					break;
				case 2:
					result = (Convert.ToDouble(t) - 32) / 1.8;
					Console.WriteLine($"Temperature {t} from fahrenheit to celsius = {result}");
					break;
				default:
					break;
			}
		}
	}
}