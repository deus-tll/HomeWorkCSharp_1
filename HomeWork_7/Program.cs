using System.Drawing;

namespace HomeWork_7
{
	internal class Program
	{

		sealed class Application
		{
			private List<IFigure>? figures;

			public Application()
			{
				figures = new List<IFigure>();
			}

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

							AddFigure();

							break;
						case 1:
							Console.Clear();

							PrintAllFigures();

							break;
						case 2:
							Console.Clear();
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
				bool flag = false;
				while (true)
				{
					Console.Clear();

					IFigure? figure = null;

					int x;
					int y;
					int length;
					ConsoleColor color;

					int c = ConsoleMenu.SelectVertical(
					HPosition.Center,
					VPosition.Center,
					HorizontalAlignment.Center,
					"Rectangle", "Rhombus", "IsoscelesTriangle", "Hexagon", "Exit");

					switch (c)
					{
						case 0:
							Console.Clear();

							length = InputLength("Input the length of the rectangle");
							int width = InputLength("Input the width of the rectangle");
							InputCoordinates(out x, out y);
							color = InputColor();

							figure = new Rectangle(length, width, x, y, color);

							Console.Clear();
							Console.WriteLine("Rectangle added!");
							Console.ReadKey();
							break;
						case 1:
							Console.Clear();

							length = InputLength("Input the length of the side of the rhombus");
							
							InputCoordinates(out x, out y);
							color = InputColor();

							figure = new Rhombus(length, x, y, color);

							Console.Clear();
							Console.WriteLine("Rhombus added!");
							Console.ReadKey();
							break;
						case 2:
							Console.Clear();

							length = InputLength("Input the length of the side of the isosceles triangle");

							InputCoordinates(out x, out y);
							color = InputColor();

							figure = new IsoscelesTriangle(length, x, y, color);

							Console.Clear();
							Console.WriteLine("Isosceles triangle added!");
							Console.ReadKey();
							break;
						case 3:
							Console.Clear();

							length = InputLength("Input the length of the side of the hexagon");

							InputCoordinates(out x, out y);
							color = InputColor();

							figure = new Hexagon(length, x, y, color);

							Console.Clear();
							Console.WriteLine("Hexagon added!");
							Console.ReadKey();
							break;
						case 4:
							flag = true;
							break;
					}

					if (flag)
					{
						Console.Clear();
						break;
					}
					if (figure is not null && figures is not null)
					{
						figures.Add(figure);
					}	
				}
			}


			private int InputLength(string info)
			{
				while (true)
				{
					Console.Clear();

					Console.WriteLine(info);

					string? lengthStr;

					lengthStr = Console.ReadLine();

					if (int.TryParse(lengthStr, out int lengthNum) && lengthNum > 0)
					{
						return lengthNum;
					}
				}
			}

			private void InputCoordinates( out int x, out int y)
			{
				while (true)
				{
					Console.Clear();

					Console.WriteLine("Enter the X-axis ordinate( >= 0 )");

					string? CoordinateXStr;

					CoordinateXStr = Console.ReadLine();

					if (int.TryParse(CoordinateXStr, out x) && x >= 0)
					{
						break;
					}
				}

				while (true)
				{
					Console.Clear();

					Console.WriteLine("Enter the Y-axis ordinate( >= 0 )");

					string? CoordinateXStr;

					CoordinateXStr = Console.ReadLine();

					if (int.TryParse(CoordinateXStr, out y) && y >= 0)
					{
						break;
					}
				}
			}

			private ConsoleColor InputColor()
			{
				List<string> colors = new();


				foreach (ConsoleColor col in Enum.GetValues(typeof(ConsoleColor)))
				{
					colors.Add(col.ToString());
				}


				Console.Clear();

				int c = ConsoleMenu.SelectVertical(
				HPosition.Center,
				VPosition.Center,
				HorizontalAlignment.Center, colors);

				return (ConsoleColor)c;
			}

			private void PrintAllFigures()
			{
				if (figures is not null)
				{
					if (figures.Count == 0)
					{
						Console.WriteLine("Empty!");
						Console.ReadKey();
						return;
					}

					foreach (var item in figures)
					{
						item.Print();
					}
					Console.ReadKey();
				}
				
			}
		}

		static void Main(string[] args)
		{
			Application application = new();

			application.Menu();
		}
	}
}