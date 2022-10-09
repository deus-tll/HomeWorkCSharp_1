namespace task2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Int32[,] arr = new Int32[5,5];

			Random r = new Random();

			for (int i = 0; i < 5; ++i)
			{
				for (int j = 0; j < 5; ++j)
				{
					arr[i, j] = r.Next(-100, 100);
				}
			}


			Int32 sum = 0;

			Int32 max = arr[0,0];
			Int32 indexImax = 0;
			Int32 indexJmax = 0;

			Int32 min = arr[0,0];
			Int32 indexImin = 0;
			Int32 indexJmin = 0;



			for (int i = 0; i < 5; ++i)
			{
				for (int j = 0; j < 5; ++j)
				{
					if (max < arr[i, j])
					{
						max = arr[i, j];
						indexImax = i;
						indexJmax = j;
					}

					if (min > arr[i, j])
					{
						min = arr[i, j];
						indexImin = i;
						indexJmin = j;
					}
				}
			}


			bool flag = false;


			if ((indexImin == indexImax && indexJmin < indexJmax) || (indexImin < indexImax))
			{
				for (int i = 0; i < 5; ++i)
				{
					for (int j = 0; j < 5; ++j)
					{
						if (arr[i, j] == min)
						{
							flag = true;
							
						}

						if (arr[i, j] == max)
						{
							flag = false;
							break;
						}

						if (flag)
							sum += arr[i, j];
					}
				}
			}
			else
			{
				for (int i = 0; i < 5; ++i)
				{
					for (int j = 0; j < 5; ++j)
					{
						if (arr[i, j] == max)
						{
							flag = true;
							
						}

						if (arr[i, j] == min)
						{
							flag = false;
							break;
						}

						if (flag)
							sum += arr[i, j];
					}
				}
			}


			Console.WriteLine($"Sum: {sum}");
		}
	}
}