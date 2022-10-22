using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_10
{
	internal abstract class State
	{
		protected Tamagochi tamagochi;

		public void SetTamagochi(Tamagochi tamagochi)
		{
			this.tamagochi = tamagochi;
		}

		public abstract void ShowState();
	}


	class CoolState : State
	{
		public override void ShowState()
		{
			Console.WriteLine($"(づ｡◕‿‿◕｡)づ");
		}
	}


	class OKState : State
	{
		public override void ShowState()
		{
			Console.WriteLine($"༼ つ ◕_◕ ༽つ");
		}
	}


	class BadState : State
	{
		public override void ShowState()
		{
			Console.WriteLine($"(ಥ﹏ಥ)");
		}
	}


	class DeathState : State
	{
		public override void ShowState()
		{
			Console.WriteLine($"                       ______");
			Console.WriteLine($"                    .-\"      \"-.");
			Console.WriteLine($"                   /            \\");
			Console.WriteLine($"      _           |              |          _");
			Console.WriteLine($"     ( \\          |,  .-.  .-.  ,|         / )");
			Console.WriteLine($"       > \"=._     | )(__/  \\__)( |     _.=\" <");
			Console.WriteLine($"      (_/\"=._\"=._ |/     /\\     \\| _.=\"_.=\"\\_)");
			Console.WriteLine($"             \"=._ (_     ^^     _)\"_.=\"");
			Console.WriteLine($"                 \"=\\__|IIIIII|__/=\"");
			Console.WriteLine($"                _.=\"| \\IIIIII/ |\"=._");
			Console.WriteLine($"      _     _.=\"_.=\"\\          /\"=._\"=._     _");
			Console.WriteLine($"     ( \\_.=\"_.=\"     `--------`     \"=._\"=._/ )");
			Console.WriteLine($"      > _.=\"                            \"=._ <");
			Console.WriteLine($"     (_/                                    \\_)");
		}
	}
}
