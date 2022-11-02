using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Xml;
using System.Xml.Linq;

namespace HomeWork_16
{
	internal class Program
	{
		static void Parsing(List<Currency> list, XmlDocument xml)
		{
			if (xml.DocumentElement is not null)
			{
				XmlElement? xmlRoot = (XmlElement?)xml.DocumentElement;

				if (xmlRoot is not null)
				{
					foreach (XmlNode rNode in xmlRoot)
					{
						Currency cur = new Currency();

						ParsingCurrency(cur, rNode);

						list.Add(cur);
					}
				}
			}
		}

		static void ParsingCurrency(Currency cur, XmlNode node)
		{
			switch (node.Name)
			{
				case "r030": cur.r030 = Convert.ToInt32(node.InnerText); break;

				case "txt": cur.txt = node.InnerText; break;

				case "rate": NumberFormatInfo numberFormatInfo = new NumberFormatInfo() { NumberDecimalSeparator = ".",};
					cur.rate = Decimal.Parse(node.InnerText, numberFormatInfo);
					break;

				case "cc": cur.cc = node.InnerText; break;

				case "exchangedate": DateTimeFormatInfo dateTimeFormatInfo = new DateTimeFormatInfo() {	ShortDatePattern = "d.M.yyyy", DateSeparator = "."};
					cur.exchangedate = DateTime.Parse(node.InnerText);
					break;

				default:
					break;
			}


			if (node.HasChildNodes)
			{
				foreach (XmlNode item in node)
				{
					ParsingCurrency(cur, item);
				}
			}
		}

		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.Unicode;
			Console.InputEncoding = System.Text.Encoding.Unicode;


			List<Currency> list = new List<Currency>();
			XmlDocument xml = new XmlDocument();
			xml.Load("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange");

			Parsing(list, xml);
			
			Currency.ShowMoreThan20(list);
		}
	}
}
