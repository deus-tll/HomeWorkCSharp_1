using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7
{
	internal interface IFigure
	{
		public int X { get; }
		public int Y { get; }

		public ConsoleColor Color { get; protected set; }

		public void Print();
	}

	abstract class CornerFigure : IFigure
	{
		public int LengthOfFirstSide { get; protected set; }

		public int X { get; protected set; }

		public int Y { get; protected set; }

		public ConsoleColor Color { get; set; }


		public CornerFigure(int lengthOfFirstSide, int x, int y, ConsoleColor color)
		{
			LengthOfFirstSide = lengthOfFirstSide;
			X = x;
			Y = y;
			Color = color;
		}

		public abstract void Print();
	}


	class Rectangle : CornerFigure
	{
		public int LengthOfSecondSide { get; protected set; }

		public Rectangle(int lengthOfFirstSide, int lengthOfSecondSide, int x, int y, ConsoleColor color) : base(lengthOfFirstSide, x, y, color)
		{
			LengthOfSecondSide = lengthOfSecondSide;
		}
		public override void Print()
		{
			Console.ForegroundColor = Color;

			int tmp = Y;

			Console.SetCursorPosition(X, tmp++);

			for (int i = 0; i < LengthOfSecondSide; ++i)
			{
				for (int j = 0; j < LengthOfFirstSide; ++j)
				{
					Console.Write("*");
				}
				Console.SetCursorPosition(X, tmp++);
			}
			Console.SetCursorPosition(0, 0);
			Console.ResetColor();
		}
	}


	class Rhombus : CornerFigure
	{
		public Rhombus(int lengthOfFirstSide, int x, int y, ConsoleColor color) : base(lengthOfFirstSide, x, y, color)
		{

		}


		public override void Print()
		{
			Console.ForegroundColor = Color;

			int tmp = Y;

			Console.SetCursorPosition(X, tmp++);

			int i, j, N = LengthOfFirstSide * 2;
			int center = N / 2;

			for (i = 0; i < N; ++i)
			{
				for (j = 0; j < N; ++j)
				{
					if (i <= center)
					{
						if (j > center - i && j < center + i)
							Console.Write("*");
						else
							Console.Write(" ");
					}
					else
					{
						if (j >= center + i - N + 1 && j <= center - i + N - 1)
							Console.Write("*");
						else
							Console.Write(" ");
					}
				}
				Console.SetCursorPosition(X, tmp++);
			}
			Console.SetCursorPosition(0, 0);
			Console.ResetColor();
		}
	}


	class IsoscelesTriangle : CornerFigure
	{
		public IsoscelesTriangle(int lengthOfFirstSide, int x, int y, ConsoleColor color) : base(lengthOfFirstSide, x, y, color)
		{

		}


		public override void Print()
		{
			Console.ForegroundColor = Color;

			int tmp = Y;

			Console.SetCursorPosition(X, tmp++);

			int i, j, N = LengthOfFirstSide * 2;
			int center = N / 2;

			for (i = 0; i < N; i++)
			{
				for (j = 0; j < N; j++)
				{
					if (i <= center)
					{
						if (j > center - i && j < center + i)
							Console.Write("*");
						else
							Console.Write(" ");
					}
				}
				Console.SetCursorPosition(X, tmp++);
			}
			Console.SetCursorPosition(0, 0);
			Console.ResetColor();
		}
	}


	class Hexagon : CornerFigure
	{
		public Hexagon(int lengthOfFirstSide, int x, int y, ConsoleColor color) : base(lengthOfFirstSide, x, y, color)
		{

		}


		public override void Print()
		{
			Console.ForegroundColor = Color;

			int tmp = Y;

			Console.SetCursorPosition(X, tmp++);

			int l = 2 * LengthOfFirstSide - 1;

			for (int i = 0; i < LengthOfFirstSide; i++)
			{
				int elem = i + LengthOfFirstSide;

				for (int k = 0; k < elem; k++)
				{
					// prints the star
					if ((k == LengthOfFirstSide + i - 1) ||
						(k == LengthOfFirstSide - i - 1))
						Console.Write("*");
					else
						Console.Write(" ");
				}
				Console.SetCursorPosition(X, tmp++);
			}


			for (int m = 0; m < LengthOfFirstSide - 2; m++)
			{
				for (int j = 0; j < l; j++)
				{
					if (j == 0 || j == l - 1)
						Console.Write("*");
					else
						Console.Write(" ");
				}
				Console.SetCursorPosition(X, tmp++);
			}


			int r = LengthOfFirstSide - 1;
			for (int h = r; h >= 0; h--)
			{
				int elem = h + LengthOfFirstSide;
				for (int k = 0; k < elem; k++)
				{
					if ((k == LengthOfFirstSide + h - 1) ||
						(k == LengthOfFirstSide - h - 1))
						Console.Write("*");
					else
						Console.Write(" ");
				}
				Console.SetCursorPosition(X, tmp++);
			}

			Console.ResetColor();
			Console.SetCursorPosition(0, 0);
		}
	}
}
