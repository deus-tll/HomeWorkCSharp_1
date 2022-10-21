using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace HomeWork_10
{
	internal sealed partial class Tamagochi
	{
		Tamagochi()
		{
			actions = new List<Action>();

			actions.Add(Feed);
			actions.Add(TakeAWalk);
			actions.Add(PutToSleep);
			actions.Add(Play);
		}

		private List<Action> actions;


		private DialogResult InvokeMessageBox(string action, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon)
		{
			return MessageBox.Show(action, "Tamagochi", messageBoxButtons, messageBoxIcon);
		}


		


		public void StartPlay()
		{
			
		}
	}
}
