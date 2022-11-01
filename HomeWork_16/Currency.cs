using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork_16
{
	class Currency
	{
		public int r030 { get; set; }
		public string? txt { get; set; }
		public decimal rate { get; set; }
		public string? cc { get; set; }
		public DateTime exchangedate { get; set; }

		public override string ToString()
		{
			return $"r030:".PadRight(24) + $"{r030}\n" +
				   $"txt:".PadRight(24) + $"{txt}\n" +
				   $"rate:".PadRight(24) + $"{rate}\n" +
				   $"cc:".PadRight(24) + $"{cc}\n" +
				   $"exchangedate:".PadRight(24) + $"{exchangedate.ToShortDateString()}\n";
		}

		private static void Show(IEnumerable values)
		{
			foreach (var item in values)
			{
				Console.WriteLine(item);
			}
		}

		public static void ShowMoreThan20(List<Currency> l)
		{
			var v = from c in l
					where c.rate > 20
					select c;

			Show(v);
		}
	}
}
