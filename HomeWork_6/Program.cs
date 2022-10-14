namespace HomeWork_6
{
	internal class Program
	{


		class Application
		{
			Team team;
			House house;

			public Application()
			{
				team = new Team();
				house = new House();
			}


			public void Working()
			{
				while (!house.Checked())
				{
					Random r = new Random();

					team.GetWorker(r.Next(0, team.Length)).Work(house);

					Thread.Sleep(500);
				}
			}

			
			public void GetReport()
			{
				Console.Clear();

				team.GetTeamLeader().Work(house);
			}
		}


		static void Main(string[] args)
		{
			Console.WindowWidth = 110;
			Console.WindowHeight = 40;

			Application application = new();
			application.Working();

			Console.ReadKey();

			application.GetReport();
		}
	}
}