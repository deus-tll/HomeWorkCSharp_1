using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;

namespace HomeWork_10
{
	internal sealed class Tamagochi
	{
		public Tamagochi()
		{
			this.TransitionTo(new CoolState());


			action += Action;


			listOfActions = new List<string>();
			listOfActions.Add("Нагодуй мене");
			listOfActions.Add("Погуляй зі мною");
			listOfActions.Add("Вклади мене спати");
			listOfActions.Add("Пограй зі мною");


			lifeCycle.Interval = 120000;
			lifeCycle.AutoReset = false;
			lifeCycle.Elapsed += LifeCycle_Elapsed;


			restart.Interval = 10000;
			restart.AutoReset = false;
			restart.Elapsed += Restart_Elapsed;
		}


		private State state;
		private System.Timers.Timer lifeCycle = new System.Timers.Timer();
		private System.Timers.Timer restart = new System.Timers.Timer();
		private readonly Action<string> action;
		private readonly List<string> listOfActions;
		private string lastAction;
		private int index;
		private int rejection;
		private bool isDead = false;


		private void TransitionTo(State state)
		{
			this.state = state;
			this.state.SetTamagochi(this);
		}


		private void CheckState()
		{
			switch (rejection)
			{
				case 0:
					this.TransitionTo(new CoolState());
					break;
				case 1:
					this.TransitionTo(new OKState());
					break;
				case 2:
					this.TransitionTo(new BadState());
					break;
				case 3:
					this.TransitionTo(new TerribleState());
					break;
				default:
					break;
			}

			if (isDead)
			{
				this.TransitionTo(new DeathState());
			}
		}


		private void Action(string action)
		{
			if (rejection < 3)
			{
				DialogResult dialogResult = MessageBox.Show(action, "Tamagochi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				if (dialogResult == DialogResult.Yes)
				{
					rejection = 0;
				}
				else
				{
					++rejection;
				}
			}
			else
			{
				DialogResult dialogResult = MessageBox.Show("Полікуй мене", "Tamagochi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				if (dialogResult == DialogResult.Yes)
				{
					rejection = 0;
				}
				else
				{
					isDead = true;
				}
			}
			
		}


		public void Play()
		{
			lifeCycle.Start();
			restart.Start();

			while (true)
			{
				CheckState();
				state.ShowState();
				if (!isDead)
				{
					Thread.Sleep(500);
				}
				else
				{
					MessageBox.Show("ТАМАГОЧІ ВМЕР!!!", "Tamagochi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					Console.ReadKey();
					break;
				}
				Console.Clear();
			}
		}

		private void Restart_Elapsed(object sender, ElapsedEventArgs e)
		{
			if (!isDead)
			{
				Random random = new Random();


				while (true)
				{
					index = random.Next(0, listOfActions.Count);

					if (listOfActions[index] != lastAction)
					{
						lastAction = listOfActions[index];
						break;
					}
				}


				action(listOfActions[index]);


				if (rejection <= 3)
				{
					restart.Start();
				}
				else
				{
					restart.Stop();
				}
			}
			else
			{
				restart.Stop();
				lifeCycle.Stop();
			}
		}

		private void LifeCycle_Elapsed(object sender, ElapsedEventArgs e)
		{
			isDead = true;

			this.TransitionTo(new DeathState());

			restart.Stop();
			lifeCycle.Stop();
		}
	}
}
