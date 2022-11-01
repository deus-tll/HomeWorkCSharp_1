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

						foreach (XmlNode childNode in rNode)
						{
							if (childNode.Name == "r030")
							{
								cur.r030 = Convert.ToInt32(childNode.InnerText);
							}
							else if (childNode.Name == "txt")
							{
								cur.txt = childNode.InnerText;
							}
							else if (childNode.Name == "rate")
							{
								NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
								{
									NumberDecimalSeparator = ".",
								};

								cur.rate = Decimal.Parse(childNode.InnerText, numberFormatInfo);
							}
							else if (childNode.Name == "cc")
							{
								cur.cc = childNode.InnerText;
							}
							else if (childNode.Name == "exchangedate")
							{
								DateTimeFormatInfo dateTimeFormatInfo = new DateTimeFormatInfo()
								{
									ShortDatePattern = "d.M.yyyy",
									DateSeparator = "."
								};

								cur.exchangedate = DateTime.Parse(childNode.InnerText);
							}
						}

						list.Add(cur);
					}
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