using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_14
{
	internal class Firm
	{
		public string? Name { get; set; }
		public DateTime DateOfEstablishment { get; set; }
		public string? Director_sFirstName { get; set; }
		public string? Director_sLastName { get; set; }
		public string? BusinessProfile { get; set; }
		public Int16 EmployeeNumber { get; set; }
		public string? Address { get; set; }


		public override string ToString()
		{
			return $"Name of firm:".PadRight(24) + $"{Name}\n" +
				   $"Date of establishment:".PadRight(24) + $"{DateOfEstablishment.ToShortDateString()}\n" +
				   $"Director`s first name:".PadRight(24) + $"{Director_sFirstName}\n" +
				   $"Director`s last name:".PadRight(24) + $"{Director_sLastName}\n" +
				   $"Business profile:".PadRight(24) + $"{BusinessProfile}\n" +
				   $"Employee number:".PadRight(24) + $"{EmployeeNumber}\n" +
				   $"Address:".PadRight(24) + $"{Address}\n";

		}


		private static void Show(IEnumerable values)
		{
			foreach (var item in values)
			{
				Console.WriteLine(item);
			}
		}


		public static void AllFirms(List<Firm> firms)
		{
			var f = from firm in firms
					select firm;

			Show(f);
		}


		public static void HaveFoodInName(List<Firm> firms)
		{
			var f = from firm in firms
					where firm.Name.Contains("Food")
					select firm;

			Show(f);
		}


		public static void WorkInMarketing(List<Firm> firms)
		{
			var f = from firm in firms
					where firm.BusinessProfile == "Marketing"
					select firm;

			Show(f);
		}


		public static void WorkInMarketingOrIT(List<Firm> firms)
		{
			var f = from firm in firms
					where firm.BusinessProfile == "Marketing" || firm.BusinessProfile == "IT"
					select firm;

			Show(f);
		}


		public static void EmployeeNumberMoreThan100(List<Firm> firms)
		{
			var f = from firm in firms
					where firm.EmployeeNumber > 100
					select firm;

			Show(f);
		}


		public static void EmployeeNumberInRangeFrom100To300(List<Firm> firms)
		{
			var f = from firm in firms
					where firm.EmployeeNumber >= 100 && firm.EmployeeNumber <= 300
					select firm;

			Show(f);
		}


		public static void LocationInLondon(List<Firm> firms)
		{
			var f = from firm in firms
					where firm.Address.Contains("London")
					select firm;

			Show(f);
		}


		public static void HaveWhiteInDirector_sLastName(List<Firm> firms)
		{
			var f = from firm in firms
					where firm.Director_sLastName == "White"
					select firm;

			Show(f);
		}


		public static void FoundedMoreThan2YearsAgo(List<Firm> firms)
		{
			var f = from firm in firms
					where ((DateTime.Now) - firm.DateOfEstablishment).TotalDays > 365.25 * 2
					select firm;

			Show(f);
		}


		public static void FoundedMoreThan123days(List<Firm> firms)
		{
			var f = from firm in firms
					where ((DateTime.Now) - firm.DateOfEstablishment).TotalDays > 123
					select firm;

			Show(f);
		}


		public static void HaveBlackInDirector_sLastNameAndWhiteInNameFirm(List<Firm> firms)
		{
			var f = from firm in firms
					where firm.Director_sLastName == "Black" && firm.Name.Contains("White")
					select firm;

			Show(f);
		}
	}
}
