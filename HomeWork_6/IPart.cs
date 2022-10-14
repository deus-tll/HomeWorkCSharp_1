using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
	internal interface IPart
	{
		string? NameOfPart { get; }
		string? NameOfWorkerWhoBuilt { get; }
		bool IsBuilt { get; }
		public string Build(string nameOfWorker);
	}

	abstract class Part : IPart
	{
		public string NameOfPart { get; }
		public bool IsBuilt { get; protected set; }

		public string? NameOfWorkerWhoBuilt { get; protected set; }

		protected int x;
		protected int y;



		public Part(string nameOfPart, int x, int y)
		{
			NameOfPart = nameOfPart;
			this.x = x;
			this.y = y;
		}

		protected abstract void Draw();

		public string Build(string workerName)
		{
			IsBuilt = true;
			NameOfWorkerWhoBuilt = workerName;
			Draw();
			return NameOfPart;
		}
	}


	class Basement : Part
	{
		public Basement(string nameOfPart, int x, int y) : base(nameOfPart, x, y)
		{

		}

		protected override void Draw()
		{

			Console.SetCursorPosition(x, y++); Console.Write("-------------------------------------------------------------");
			Console.SetCursorPosition(x, y++); Console.Write("|                                                           |");
			Console.SetCursorPosition(x, y++); Console.Write("-------------------------------------------------------------");

		}
	}


	class Wall : Part
	{
		public Wall(string nameOfPart, int x, int y) : base(nameOfPart, x, y)
		{
		}

		protected override void Draw()
		{
			Console.SetCursorPosition(x, y++); Console.Write("|");
			Console.SetCursorPosition(x, y++); Console.Write("|");
			Console.SetCursorPosition(x, y++); Console.Write("|");
			Console.SetCursorPosition(x, y++); Console.Write("|");
			Console.SetCursorPosition(x, y++); Console.Write("|");
			Console.SetCursorPosition(x, y++); Console.Write("|");
			Console.SetCursorPosition(x, y++); Console.Write("|");
			Console.SetCursorPosition(x, y++); Console.Write("|");
			Console.SetCursorPosition(x, y++); Console.Write("|");
			Console.SetCursorPosition(x, y++); Console.Write("|");
			Console.SetCursorPosition(x, y++); Console.Write("|");
			Console.SetCursorPosition(x, y++); Console.Write("|");
			Console.SetCursorPosition(x, y++); Console.Write("|");
			Console.SetCursorPosition(x, y++); Console.Write("|");
			Console.SetCursorPosition(x, y++); Console.Write("|");
			Console.SetCursorPosition(x, y++); Console.Write("|");
		}
	}


	class Door : Part
	{
		public Door(string nameOfPart, int x, int y) : base(nameOfPart, x, y)
		{
		}

		protected override void Draw()
		{
			Console.SetCursorPosition(x, y++); Console.Write("-------------------");
			Console.SetCursorPosition(x, y++); Console.Write("|        |        |");
			Console.SetCursorPosition(x, y++); Console.Write("|        |        |");
			Console.SetCursorPosition(x, y++); Console.Write("|        |        |");
			Console.SetCursorPosition(x, y++); Console.Write("|       0|0       |");
			Console.SetCursorPosition(x, y++); Console.Write("|        |        |");
			Console.SetCursorPosition(x, y++); Console.Write("|        |        |");
			Console.SetCursorPosition(x, y++); Console.Write("|        |        |");
			Console.SetCursorPosition(x, y++); Console.Write("-------------------");

		}
	}


	class Window : Part
	{
		public Window(string nameOfPart, int x, int y) : base(nameOfPart, x, y)
		{
		}

		protected override void Draw()
		{
			Console.SetCursorPosition(x, y++); Console.Write("===========");
			Console.SetCursorPosition(x, y++); Console.Write("|         |");
			Console.SetCursorPosition(x, y++); Console.Write("|         |");
			Console.SetCursorPosition(x, y++); Console.Write("|         |");
			Console.SetCursorPosition(x, y++); Console.Write("|         |");
			Console.SetCursorPosition(x, y++); Console.Write("===========");
		}
	}


	class Roof : Part
	{
		public Roof(string nameOfPart, int x, int y) : base(nameOfPart, x, y)
		{
		}

		protected override void Draw()
		{
			Console.SetCursorPosition(x, y++); Console.Write("                                ***                                ");
			Console.SetCursorPosition(x, y++); Console.Write("                             *********                             ");
			Console.SetCursorPosition(x, y++); Console.Write("                         *****************                         ");
			Console.SetCursorPosition(x, y++); Console.Write("                     *************************                     ");
			Console.SetCursorPosition(x, y++); Console.Write("                 *********************************                 ");
			Console.SetCursorPosition(x, y++); Console.Write("            *******************************************            ");
			Console.SetCursorPosition(x, y++); Console.Write("         *************************************************         ");
			Console.SetCursorPosition(x, y++); Console.Write("    ***********************************************************    ");
			Console.SetCursorPosition(x, y++); Console.Write("*******************************************************************");
		}
	}


	class House
	{
		readonly List<List<IPart>>? house;

		public House()
		{
			house = new()
			{
				new List<IPart>()
				{
					new Basement("Basement", 40, 37)
				},

				new List<IPart>()
				{
					new Wall("First Wall", 40, 21),
					new Wall("Second Wall", 41, 21),
					new Wall("Third Wall", 99, 21),
					new Wall("Fourth Wall", 100, 21)
				},

				new List<IPart>()
				{
					new Door("Door", 44, 28)
				},

				new List<IPart>()
				{
					new Roof("Roof", 37, 12)
				},

				new List<IPart>()
				{
					new Window("First Window", 84, 30),
					new Window("Second Window", 70, 30),
					new Window("Third Window", 84, 22),
					new Window("Fourth Window", 70, 22)
				}
			};
		}


		public void Build(string builderName)
		{
			if (house is not null)
			{
				for (int i = 0; i < house.Count; i++)
				{
					for (int j = 0; j < house[i].Count; j++)
					{
						if (house[i][j].IsBuilt == false)
						{
							house[i][j].Build(builderName);
							return;
						}
					}
					
				}
			}
		}


		public string GetReport()
		{
			StringBuilder sb = new StringBuilder();
			if (house is not null)
			{
				for (int i = 0; i < house.Count; i++)
				{
					for (int j = 0; j < house[i].Count; j++)
					{
						if (house[i][j].IsBuilt == true)
						{
							sb.Append($"Part \"{house[i][j].NameOfPart}\"".PadRight(22) + $"built - {house[i][j].NameOfWorkerWhoBuilt}\n");
						}
						else
						{
							sb.Append($"Part \"{house[i][j].NameOfPart}\"".PadRight(22) + "not built yet.\n");
						}
					}

				}
			}
			return sb.ToString();
		}


		public bool Checked()
		{
			if (house is not null)
			{
				for (int i = 0; i < house.Count; i++)
				{
					for (int j = 0; j < house[i].Count; j++)
					{
						if (house[i][j].IsBuilt == false)
						{
							return false;
						}
					}
				}
			}
			return true;
		}
	}
}
