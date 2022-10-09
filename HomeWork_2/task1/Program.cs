namespace task1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.Unicode;
			Console.InputEncoding = System.Text.Encoding.Unicode;


			Double[] A = new Double[5];
			Double[,] B = new Double[3, 4];
			

			for (int i = 0; i < 5; ++i)
			{
				Console.Write($"Введіть число {i + 1}: ");
				A[i] = Convert.ToDouble(Console.ReadLine());
			}
			Console.WriteLine();


			Random r = new Random();


			for (int i = 0; i < 3; ++i)
			{
				for (int j = 0; j < 4; ++j)
				{
					B[i,j] = r.NextDouble() * 100;
					B[i, j] = Math.Round(B[i,j],r.Next(0, 3));
				}
			}


			Console.WriteLine($"Массив \"A\":");
			for (int i = 0; i < 5; ++i)
			{
				Console.Write($"{A[i]} ");
			}
			Console.WriteLine();
			Console.WriteLine();


			Console.WriteLine($"Массив \"B\" у вигляді матриці:");
			for (int i = 0; i < 3; ++i)
			{
				for (int j = 0; j < 4; ++j)
				{
					Console.Write(B[i,j].ToString().PadRight(10));
				}
				Console.WriteLine();
			}
			Console.WriteLine();


			Double maxB = B[0,0];
			Double minB = B[0,0];

			for (int i = 0; i < 3; ++i)
			{
				for (int j = 0; j < 4; ++j)
				{
					if (maxB < B[i,j])
						maxB = B[i, j];
					
					if (minB > B[i, j])
						minB = B[i, j];
				}
			}


			Double? generalMax = null;
			Double? generalMin = null;


			for (int i = 0; i < 5; ++i)
			{
				for (int l = 0; l < 3; l++)
				{
					for (int j = 0; j < 4; ++j)
					{
						if (A[i] == B[l, j])
						{
							generalMax = A[i];
							if (A[i] == B[l, j] && generalMax < B[l, j])
								generalMax = A[i];

							generalMin = A[i];
							if (A[i] == B[l, j] && generalMin > B[l, j])
								generalMin = A[i];
						}
					}
				}
			}

			if (generalMax != null)
				Console.WriteLine($"Максимальний загальний елемент: {generalMax}");

			if (generalMin != null)
				Console.WriteLine($"Мінімальний загальний елемент: {generalMin}");

			Console.WriteLine();

			Console.WriteLine($"Максимальний елемент массиву \"A\": {A.Max()}");
			Console.WriteLine($"Максимальний елемент массиву \"B\": {maxB}");
			Console.WriteLine();
			Console.WriteLine($"Мінімальний елемент массиву \"A\": {A.Min()}");
			Console.WriteLine($"Мінімальний елемент массиву \"B\": {minB}");
			Console.WriteLine();


			Double resultSum = 0;


			for (int i = 0; i < 3; ++i)
			{
				for (int j = 0; j < 4; ++j)
				{
					resultSum += B[i, j];
				}
			}

			 
			Console.WriteLine($"Загальна сума елементів: {resultSum += A.Sum()}");
			Console.WriteLine();


			Double resultMultA = A[0];


			for (int i = 1; i < 5; i++)
			{
				resultMultA *= A[i];
			}


			Double resultMultB = B[0,0];


			for (int i = 0; i < 3; ++i)
			{
				for (int j = 0; j < 4; ++j)
				{
					resultMultB *= B[i, j];
				}
			}


			Console.WriteLine($"Загальний добуток елементів: {resultMultA *= resultMultB}");
			Console.WriteLine();


			Double resultEvenA = 0;


			for (int i = 0; i < 5; i++)
			{
				if (A[i] % 2 == 0)
				{
					resultEvenA += A[i];
				}
			}


			Double resultNotEvenColumnsB = 0;


			for (int i = 0; i < 3; ++i)
			{
				for (int j = 0; j < 4; ++j)
				{
					if (j % 2 != 0)
						resultNotEvenColumnsB += B[i, j];
				}
			}


			Console.WriteLine($"Сума парних елементів массиву \"A\": {resultEvenA}");
			Console.WriteLine($"Сума не парних стовпців массиву \"B\": {resultNotEvenColumnsB}");
		}
	}	
}