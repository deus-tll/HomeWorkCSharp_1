namespace HomeWork_9
{
	internal class Program
	{


		class Operation
		{
			public static void TimeNow()
			{
				Console.WriteLine(DateTime.Now.ToLongTimeString());
			}


			public static void DateNow()
			{
				Console.WriteLine(DateTime.Now.ToShortDateString());
			}


			public static string DayOfWeek()
			{
				return DateTime.Now.DayOfWeek.ToString();
			}


			public static double AreaOfTriangle(double a, double h)
			{
				return 0.5 * a * h;
			}


			public static double AreaOfRectangle(double a, double b)
			{
				return a * b;
			}
		}


		static void Main(string[] args)
		{
			Action action = Operation.TimeNow;

			action();

			action = Operation.DateNow;

			action();



			Func<string> func1;

			func1 = Operation.DayOfWeek;

			Console.WriteLine(func1());



			Func<double, double, double> func2;

			func2 = Operation.AreaOfTriangle;

			Console.WriteLine(func2(4.5, 8));

			func2 = Operation.AreaOfRectangle;

			Console.WriteLine(func2(10, 5));
		}
	}
}