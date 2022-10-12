namespace HomeWork_5
{
	internal class Program
	{
		class Card : ICloneable
		{
			public string? OwnerPIB { get; set; }
			public Int64 Number { get; private set; }
			public Int16 CVV { get; private set; }
			public decimal Balance { get; private set; }


			public Card(string? ownerPIB)
			{
				OwnerPIB = ownerPIB;
				
				Random r = new();

				string tmp = "";

				for (int i = 0; i < 16; ++i)
				{
					tmp += r.Next(0,10).ToString();
				}


				Number = Convert.ToInt64(tmp);
				tmp = "";


				for (int i = 0; i < 3; ++i)
				{
					tmp += r.Next(0, 10).ToString();
				}

				CVV = Convert.ToInt16(tmp);
			}


			public static Card operator +(Card card, decimal amount)
			{
				if (amount >= (decimal)0.0)
				{
					Card _card = (Card)card.Clone();

					_card.Balance += amount;

					Console.WriteLine("Succes!");
					return _card;
				}
				else
				{
					throw new ArgumentException("Amount can`t be less than zero!");
				}
			}


			public static Card operator -(Card card, decimal amount)
			{
				if (amount >= (decimal)0.0)
				{
					Card _card = (Card)card.Clone();
					if (_card.Balance - amount < (decimal)0.0)
					{
						Console.WriteLine("There is not enough money on the card to complete the operation.");
						return _card;
					}
					_card.Balance -= amount;

					return _card;
				}
				else
				{
					throw new ArgumentException("Amount can`t be less than zero!");
				}
			}


			public static bool operator ==(Card card, Int16 cvv)
			{
				if (cvv.ToString().Length != 3)
				{
					Console.WriteLine("Invalid format of CVV!");
					return false;
				}
				return card.CVV == cvv;
			}


			public static bool operator !=(Card card, Int16 cvv)
			{
				return card.CVV != cvv;
			}


			public static implicit operator decimal(Card card)
			{
				return card.Balance;
			}


			public decimal this[string currency]
			{
				get
				{
					if (Balance == (decimal)0.0)
					{
						return (decimal)0.0;
					}
					if (currency == "USD")
					{
						return Balance / (decimal)40.50;
					}
					if (currency == "EUR")
					{
						return Balance / (decimal)38.65;
					}

					throw new ArgumentException("unknown currency");
				}
			}


			public static bool operator > (Card card, int sum)
			{
				return card.Balance > sum;
			}


			public static bool operator < (Card card, int sum)
			{
				return card.Balance < sum;
			}


			public object Clone()
			{
				return this.MemberwiseClone();
			}


			public override bool Equals(object? obj)
			{
				return obj is Card card &&
					   OwnerPIB == card.OwnerPIB &&
					   Number == card.Number &&
					   CVV == card.CVV &&
					   Balance == card.Balance;
			}


			public override int GetHashCode()
			{
				return HashCode.Combine(OwnerPIB, Number, CVV, Balance);
			}
		}


		static void Main(string[] args)
		{
			Card card = new("Miller Artem Valeriyovich");
			Card card_ = (Card)card.Clone();


			card += 1000;

			Console.WriteLine(card);

			card -= 500;

			Console.WriteLine(card);

			card -= 500;

			Console.WriteLine(card);

			card -= 500;
			Console.WriteLine();


			card += 100;
			Console.WriteLine(card);
			Console.WriteLine();


			Console.WriteLine(card.Equals(card_));
			Console.WriteLine();


			Console.WriteLine(card == 345);
			Console.WriteLine(card != 345);
			Console.WriteLine();


			card += 1000;

			Console.WriteLine(card > 100);
			Console.WriteLine(card < 100);
			Console.WriteLine();


			Console.WriteLine(Math.Round(card["USD"], 3).ToString() + " USD");
			Console.WriteLine();


			Console.WriteLine(Math.Round(card["EUR"], 3).ToString() + " EUR");
			Console.WriteLine();
		}
	}
}