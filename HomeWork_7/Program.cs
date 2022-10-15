namespace HomeWork_7
{
	internal class Program
	{

		sealed class Application
		{
			List<IFigure>? figures;

			public void Menu()
			{
				bool flag = false;
				while (true)
				{
					Console.Clear();

					int c = ConsoleMenu.SelectVertical(
					HPosition.Center,
					VPosition.Center,
					HorizontalAlignment.Center,
					"Add figure to collection", "Print all figures", "Exit");

					switch (c)
					{
						case 0:
							Console.Clear();
							
							Console.ReadKey();
							break;
						case 1:
							Console.Clear();
							
							Console.ReadKey();
							break;
						case 2:
							Console.Clear();
							
							Console.ReadKey();
							flag = true;
							break;
					}

					if (flag)
					{
						break;
					}
				}
			}


			private void AddFigure()
			{

			}


			private void PrintAllFigures()
			{

			}
		}

		static void Main(string[] args)
		{
			

			
		}
	}
}