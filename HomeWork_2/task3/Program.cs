namespace task3
{
	public class CaesarCipher
	{
		private readonly string? alfabet;

		public CaesarCipher()
		{
			for (int i = 192; i <= 255; i++)
			{
				alfabet += (char)i;
			}
			for (int i = 32; i <= 126; i++)
			{
				alfabet += (char)i;
			}
		}

		public string Encryption(ref string str, ref int key)
		{
			int temp;
			string encryptText = "";
			for (int i = 0; i < str.Length; i++)
			{
				if (alfabet is not null)
				{
					for (int j = 0; j < alfabet.Length; j++)
					{
						if (str[i] == alfabet[j])
						{
							temp = j + key;


							if (temp < 0)
								temp += alfabet.Length;
							else
								temp = (j + key) % alfabet.Length;


							encryptText += alfabet[temp];
						}
					}
				}
			}
			return encryptText;
		}


		public string Decryption(ref string str, ref int key)
		{
			int temp;
			string decryptText = "";
			for (int i = 0; i < str.Length; i++)
			{
				if (alfabet is not null)
				{
					for (int j = 0; j < alfabet.Length; j++)
					{
						if (str[i] == alfabet[j])
						{
							if (key > alfabet.Length)
								key %= alfabet.Length;


							temp = j - key;


							if (temp < 0)
								temp += alfabet.Length;

							else
								temp = (j - key) % alfabet.Length;


							decryptText += alfabet[temp];
						}
					}
				}
			}
			return decryptText;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.Unicode;
			Console.InputEncoding = System.Text.Encoding.Unicode;


			CaesarCipher caesarCipher = new CaesarCipher();
			string? text;
			string? keyStr;
			string? encryptedText;
			string? decryptedText;
			Int32 key;


			Console.WriteLine($"Введіть текст який потрібно зашифрувати: ");
			text = Console.ReadLine();


			Console.Write($"Введіть ключ: ");
			keyStr = Console.ReadLine();

			while (true)
			{
				if (!Int32.TryParse(keyStr, out key))
				{
					Console.WriteLine($"Ключ має містити тільки цифри!");
					Console.ReadKey();
					Console.Clear();
					continue;
				}
				else
					break;
			}
			

			Console.Clear();


			if (text is not null)
			{
				Console.WriteLine($"Зашифрований текст: ");
				encryptedText = caesarCipher.Encryption(ref text, ref key);
				Console.WriteLine(encryptedText);

				Console.WriteLine($"Розшифрований текст: ");
				decryptedText = caesarCipher.Decryption(ref encryptedText, ref key);
				Console.WriteLine(decryptedText);
			}
		}
	}
}