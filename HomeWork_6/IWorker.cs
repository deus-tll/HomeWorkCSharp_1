using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
	internal interface IWorker
	{
		public string? WorkerName { get; }

		public void Work(House house);
	}


	class Worker : IWorker
	{
		public string WorkerName { get; }

		public Worker(string workerName)
		{
			WorkerName = workerName;
		}

		public void Work(House house)
		{
			house.Build(WorkerName);
		}
	}


	class TeamLeader : IWorker
	{
		public string WorkerName { get; }

		public TeamLeader(string workerName)
		{
			WorkerName = workerName;
		}

		public void Work(House house)
		{
			for (int i = 0; i < 12; ++i)
			{
				Console.WriteLine("                                   ");
			}
			Console.SetCursorPosition(0, 0);
			Console.WriteLine(house.GetReport());
		}
	}


	class Team
	{
		private List<IWorker> workers;

		public Team()
		{
			workers = new()
			{
				new Worker("Builder Vasya"),
				new Worker("Builder Petya"),
				new Worker("Builder Ivan"),
				new Worker("Builder Alexey"),
				new Worker("Builder Vitaliy"),
				new TeamLeader("TeamLeader Anatoliy")
			};

			Length = workers.Count;
		}

		public IWorker GetWorker(int index)
		{
			return workers[index];
		}

		public IWorker GetTeamLeader()
		{
			return workers[^1];
		}


		public int Length { get; }

	}

}
