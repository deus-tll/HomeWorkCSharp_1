using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace HomeWork_10
{
	internal sealed class Tamagochi
	{
		Tamagochi()
		{
			this.TransitionTo(new CoolState());

			action += Action;

			listOfActions = new List<string>();
			listOfActions.Add("Нагодуй мене");
			listOfActions.Add("Погуляй зі мною");
			listOfActions.Add("Вклади мене спати");
			listOfActions.Add("Пограй зі мною");
		}


		private State state;
		private readonly Action<string> action;
		private readonly System.Timers.Timer timer;
		private readonly List<string> listOfActions;
		private readonly string treat = "Полікуй мене";
		private string duplication;
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
			DialogResult dialogResult = MessageBox.Show(action, "Tamagochi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			if (dialogResult == DialogResult.Yes)
			{
				rejection = 0;
			}
			else
			{
				if (action == treat)
				{
					isDead = true;
					return;
				}
				++rejection;
			}
		}


		public void Play()
		{
			
		}
	}
}
