namespace HomeWork_3
{
	internal class Program
	{


		class Magazine
		{
			public string? NameOfMagazine { get; set; }
			public string? DescriptionOfMagazine { get; set; }
			public DateTime? YearOfFoundation { get; set; }
			public string? ContactPhone { get; set; }
			public string? Email { get; set; }

			public void Print()
			{
				Console.WriteLine($"Назва журналу: ".      PadRight(20) + NameOfMagazine);
				Console.WriteLine($"Опис журналу: ".       PadRight(20) + DescriptionOfMagazine);
				Console.WriteLine($"Дата заснування: ".    PadRight(20) + YearOfFoundation);
				Console.WriteLine($"Контактний телефон: ". PadRight(20) + ContactPhone);
				Console.WriteLine($"Email: ".              PadRight(20) + Email);
			}
		}


		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.Unicode;
			Console.InputEncoding = System.Text.Encoding.Unicode;


			Magazine magazine = new Magazine()
			{
				NameOfMagazine =        "some magazine",
				DescriptionOfMagazine = "articles about something",
				YearOfFoundation = new DateTime(2022, 05, 29),
				ContactPhone =          "+380689894688",
				Email =                 "someemail@gamil.com"
			};


			magazine.Print();
		}
	}
}