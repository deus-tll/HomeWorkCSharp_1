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
			Console.WriteLine($"░░░░░░░░░░░░░░░░░░░░░░█████████\r\n░░███████░░░░░░░░░░███▒▒▒▒▒▒▒▒███\r\n░░█▒▒▒▒▒▒█░░░░░░░███▒▒▒▒▒▒▒▒▒▒▒▒▒███\r\n░░░█▒▒▒▒▒▒█░░░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██\r\n░░░░█▒▒▒▒▒█░░░██▒▒▒▒▒██▒▒▒▒▒▒██▒▒▒▒▒███\r\n░░░░░█▒▒▒█░░░█▒▒▒▒▒▒████▒▒▒▒████▒▒▒▒▒▒██\r\n░░░█████████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██\r\n░░░█▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒██\r\n░██▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒██▒▒▒▒▒▒▒▒▒▒██▒▒▒▒██\r\n██▒▒▒███████████▒▒▒▒▒██▒▒▒▒▒▒▒▒██▒▒▒▒▒██\r\n█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒████████▒▒▒▒▒▒▒██\r\n██▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██\r\n░█▒▒▒███████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██\r\n░██▒▒▒▒▒▒▒▒▒▒████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█\r\n░░████████████░░░█████████████████\r\n\r\n");
		}
	}


	class OKState : State
	{
		public override void ShowState()
		{
			Console.WriteLine($"███████▓█████▓▓╬╬╬╬╬╬╬╬▓███▓╬╬╬╬╬╬╬▓╬╬▓█ \r\n████▓▓▓▓╬╬▓█████╬╬╬╬╬╬███▓╬╬╬╬╬╬╬╬╬╬╬╬╬█ \r\n███▓▓▓▓╬╬╬╬╬╬▓██╬╬╬╬╬╬▓▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓█ \r\n████▓▓▓╬╬╬╬╬╬╬▓█▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓█ \r\n███▓█▓███████▓▓███▓╬╬╬╬╬╬▓███████▓╬╬╬╬▓█ \r\n████████████████▓█▓╬╬╬╬╬▓▓▓▓▓▓▓▓╬╬╬╬╬╬╬█ \r\n███▓▓▓▓▓▓▓╬╬▓▓▓▓▓█▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓█ \r\n████▓▓▓╬╬╬╬▓▓▓▓▓▓█▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓█ \r\n███▓█▓▓▓▓▓▓▓▓▓▓▓▓▓▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓█ \r\n█████▓▓▓▓▓▓▓▓█▓▓▓█▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓█ \r\n█████▓▓▓▓▓▓▓██▓▓▓█▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬██ \r\n█████▓▓▓▓▓████▓▓▓█▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬██ \r\n████▓█▓▓▓▓██▓▓▓▓██╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬██ \r\n████▓▓███▓▓▓▓▓▓▓██▓╬╬╬╬╬╬╬╬╬╬╬╬█▓╬▓╬╬▓██ \r\n█████▓███▓▓▓▓▓▓▓▓████▓▓╬╬╬╬╬╬╬█▓╬╬╬╬╬▓██ \r\n█████▓▓█▓███▓▓▓████╬▓█▓▓╬╬╬▓▓█▓╬╬╬╬╬╬███ \r\n██████▓██▓███████▓╬╬╬▓▓╬▓▓██▓╬╬╬╬╬╬╬▓███ \r\n███████▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓╬╬╬╬╬╬╬╬╬╬╬████ \r\n███████▓▓██▓▓▓▓▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓████ \r\n████████▓▓▓█████▓▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓█████ \r\n█████████▓▓▓█▓▓▓▓▓███▓╬╬╬╬╬╬╬╬╬╬╬▓██████ \r\n██████████▓▓▓█▓▓▓╬▓██╬╬╬╬╬╬╬╬╬╬╬▓███████ \r\n███████████▓▓█▓▓▓▓███▓╬╬╬╬╬╬╬╬╬▓████████ \r\n██████████████▓▓▓███▓▓╬╬╬╬╬╬╬╬██████████ \r\n███████████████▓▓▓██▓▓╬╬╬╬╬╬▓███████████");
		}
	}


	class BadState : State
	{
		public override void ShowState()
		{
			Console.WriteLine($".\r\n░░░░░░░░░▄▄▄████████▄▄▄░░░░░░░░░\r\n░░░░░░▄██████████████████▄░░░░░░\r\n░░░░▄██████████████████████▄░░░░\r\n░░▄██████▀▀▀███████▀▀▀███████▄░░\r\n░▄█████▀░░░░░█████░░░░░▀██████▄░\r\n░██████░░░░░░█████░░░░░░███████░\r\n███████░░░░░▄█████░░░░░░████████\r\n███████▄░░░▄███████▄░░░▄████████\r\n█████████████████████▄██████████\r\n████████████████████████████████\r\n░██████████▀▀░░░░░░░░▀▀▀███████░\r\n░▀██████▀░░░░░▄▄▄▄▄▄▄░░░░█████▀░\r\n░░▀████░░▄▄██████████████████▀░░\r\n░░░░▀██████████████████████▀░░░░\r\n░░░░░░▀██████████████████▀░░░░░░\r\n░░░░░░░░░▀▀▀████████▀▀▀░░░░░░░░░\r\n ");
		}
	}


	class TerribleState : State
	{
		public override void ShowState()
		{
			Console.WriteLine($"                      :::!~!!!!!:.\r\n                  .xUHWH!! !!?M88WHX:.\r\n                .X*#M@$!!  !X!M$$$$$$WWx:.\r\n               :!!!!!!?H! :!$!$$$$$$$$$$8X:\r\n              !!~  ~:~!! :~!$!#$$$$$$$$$$8X:\r\n             :!~::!H!<   ~.U$X!?R$$$$$$$$MM!\r\n             ~!~!!!!~~ .:XW$$$U!!?$$$$$$RMM!\r\n               !:~~~ .:!M\"T#$$$$WX??#MRRMMM!\r\n               ~?WuxiW*`   `\"#$$$$8!!!!??!!!\r\n             :X- M$$$$       `\"T#$T~!8$WUXU~\r\n            :%`  ~#$$$m:        ~!~ ?$$$$$$\r\n          :!`.-   ~T$$$$8xx.  .xWW- ~\"\"##*\"\r\n.....   -~~:<` !    ~?T#$$@@W@*?$$      /`\r\nW$@@M!!! .!~~ !!     .:XUW$W!~ `\"~:    :\r\n#\"~~`.:x%`!!  !H:   !WM$$$$Ti.: .!WUn+!`\r\n:::~:!!`:X~ .: ?H.!u \"$$$B$$$!W:U!T$$M~\r\n.~~   :X@!.-~   ?@WTWo(\"*$$$W$TH$! `\r\nWi.~!X$?!-~    : ?$$$B$Wu(\"**$RM!\r\n$R@i.~~ !     :   ~$$$$$B$$en:``\r\n?MXT@Wx.~    :     ~\"##*$$$$M~");

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
