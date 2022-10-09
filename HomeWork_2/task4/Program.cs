namespace task4
{
	static class Matrix
	{ 
		static public int[,] MultByANumber(int[,] arr, int num)
		{
			int[,] newArr = new int[arr.GetLength(0), arr.GetLength(1)];


			for (int i = 0; i < newArr.GetLength(0); ++i)
			{
				for (int j = 0; j < newArr.GetLength(1); ++j)
					newArr[i, j] = arr[i, j] * num;
			}


			return newArr;
		}

		//throw exceptions if "Different sizes."
		static public int[,] SumOfMatrix(int[,] arr1, int[,] arr2)
		{
			if (arr1.GetLength(0) != arr2.GetLength(0) && arr1.GetLength(1) != arr2.GetLength(1))
				throw new ArgumentException("Different sizes.");


			int[,] newArr = new int[arr1.GetLength(0), arr1.GetLength(1)];


			for (int i = 0; i < newArr.GetLength(0); ++i)
			{
				for (int j = 0; j < newArr.GetLength(1); ++j)
					newArr[i, j] = arr1[i, j] + arr2[i, j];
			}


			return newArr;
		}

		//throw exceptions if "The number of columns in the first matrix is not equal to the number of rows in the second matrix."
		static public int[,] MultOfMatrix(int[,] arr1, int[,] arr2)
		{
			if (arr1.GetLength(1) != arr2.GetLength(0))
				throw new ArgumentException("The number of columns in the first matrix is not equal to the number of rows in the second matrix.");
			

			int[,] newArr = new int[arr1.GetLength(0), arr2.GetLength(1)];


			for (int i = 0; i < newArr.GetLength(0); ++i)
			{
				for (int j = 0; j < newArr.GetLength(1); ++j)
				{
					newArr[i, j] = 0;

					for (int k = 0; k < arr1.GetLength(1);  ++k)
						newArr[i, j] += arr1[i, k] * arr2[k, j];
				}
			}


			return newArr;
		}


		static public void PrintArray(int[,] arr)
		{
			for (int i = 0; i < arr.GetLength(0); ++i)
			{
				for (int j = 0; j < arr.GetLength(1); ++j)
				{
					Console.Write(arr[i,j].ToString().PadRight(7));
				}
				Console.WriteLine();
			}
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			int[,] arr1 = new int[3, 5];
			int[,] arr3 = new int[5, 3];
			int[,] arr2 = new int[3, 5];
			int[,] arr4;
			Random r = new Random();


			for (int i = 0; i < arr1.GetLength(0); i++)
			{
				for (int j = 0; j < arr1.GetLength(1); j++)
				{
					arr1[i, j] = r.Next(0,100);
				}
			}


			Matrix.MultByANumber(arr1, 5);
			Matrix.PrintArray(arr1);
			Console.WriteLine();


			///////


			for (int i = 0; i < arr2.GetLength(0); i++)
			{
				for (int j = 0; j < arr2.GetLength(1); j++)
				{
					arr2[i, j] = r.Next(0, 100);
				}
			}


			arr4 = Matrix.SumOfMatrix(arr1, arr2);
			Matrix.PrintArray(arr4);
			Console.WriteLine();


			///////
			

			for (int i = 0; i < arr3.GetLength(0); i++)
			{
				for (int j = 0; j < arr3.GetLength(1); j++)
				{
					arr3[i, j] = r.Next(0, 100);
				}
			}


			arr4 = Matrix.MultOfMatrix(arr1, arr3);
			Matrix.PrintArray(arr4);
			Console.WriteLine();
		}
	}
}