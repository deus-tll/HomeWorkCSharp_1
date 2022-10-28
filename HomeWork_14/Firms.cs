using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_14
{
	internal class Firms
	{
		public List<Firm> firms;

		public Firms()
		{
			Random random = new Random();
			firms = new List<Firm>()
			{
				new Firm()
				{
					Name = "Apple",
					DateOfEstablishment = new DateTime(1973,12,30),
					Director_sFirstName = "Uthman",
					Director_sLastName = "Kelly",
					BusinessProfile = "IT",
					EmployeeNumber = Convert.ToInt16(random.Next(10,500)),
					Address = "Cupertino, California, United States"
				},
				new Firm()
				{
					Name = "Microsoft",
					DateOfEstablishment = new DateTime(1980,10,24),
					Director_sFirstName = "Boston",
					Director_sLastName = "Robinson",
					BusinessProfile = "IT",
					EmployeeNumber = Convert.ToInt16(random.Next(10,500)),
					Address = "Redmond, Washington, United States"
				},
				new Firm()
				{
					Name = "Canonical",
					DateOfEstablishment = new DateTime(1978,05,29),
					Director_sFirstName = "Hayden",
					Director_sLastName = "Collins",
					BusinessProfile = "IT",
					EmployeeNumber = Convert.ToInt16(random.Next(10,500)),
					Address = "London, United Kingdom"
				},
				new Firm()
				{
					Name = "Food Pantry",
					DateOfEstablishment = new DateTime(2010,04,23),
					Director_sFirstName = "Fabian",
					Director_sLastName = "Anderson",
					BusinessProfile = "Sales",
					EmployeeNumber = Convert.ToInt16(random.Next(10,500)),
					Address = "Brookline, United States"
				},
				new Firm()
				{
					Name = "Panasonic",
					DateOfEstablishment = new DateTime(2022,01,22),
					Director_sFirstName = "Wilmer",
					Director_sLastName = "White",
					BusinessProfile = "IT",
					EmployeeNumber = Convert.ToInt16(random.Next(10,500)),
					Address = "Kadoma, Osaka, Japan"
				},
				new Firm()
				{
					Name = "White Fish",
					DateOfEstablishment = new DateTime(1975,07,13),
					Director_sFirstName = "Todd",
					Director_sLastName = "Black",
					BusinessProfile = "Food",
					EmployeeNumber = Convert.ToInt16(random.Next(10,500)),
					Address = "San Leandro"
				},
				new Firm()
				{
					Name = "Alphabet",
					DateOfEstablishment = new DateTime(2005,10,25),
					Director_sFirstName = "Tucker",
					Director_sLastName = "Sanders",
					BusinessProfile = "IT",
					EmployeeNumber = Convert.ToInt16(random.Next(10,500)),
					Address = "Googleplex, Mountain View, California, U.S."
				},
				new Firm()
				{
					Name = "Berkshire Hathway",
					DateOfEstablishment = new DateTime(1998,05,07),
					Director_sFirstName = "Ulisses",
					Director_sLastName = "Butler",
					BusinessProfile = "",
					EmployeeNumber = Convert.ToInt16(random.Next(10,500)),
					Address = "Omaha, Nebraska, United States"
				},
				new Firm()
				{
					Name = "Tesla",
					DateOfEstablishment = new DateTime(1971,08,25),
					Director_sFirstName = "Kieran",
					Director_sLastName = "Coleman",
					BusinessProfile = "Technologies",
					EmployeeNumber = Convert.ToInt16(random.Next(10,500)),
					Address = "Austin, Texas, United States"
				},
				new Firm()
				{
					Name = "Amazon",
					DateOfEstablishment = new DateTime(1996,04,10),
					Director_sFirstName = "Kevin",
					Director_sLastName = "Anderson",
					BusinessProfile = "Sales",
					EmployeeNumber = Convert.ToInt16(random.Next(10,500)),
					Address = "Seattle, Washington and Arlington, Virginia, U.S."
				},
				new Firm()
				{
					Name = "Saudi Aramco",
					DateOfEstablishment = new DateTime(1974,06,20),
					Director_sFirstName = "Emmanuel",
					Director_sLastName = "Wright",
					BusinessProfile = "Minerals",
					EmployeeNumber = Convert.ToInt16(random.Next(10,500)),
					Address = "Dhahran, Saudi Arabia"
				},
				new Firm()
				{
					Name = "Facebook",
					DateOfEstablishment = new DateTime(1973,10,18),
					Director_sFirstName = "Ronin",
					Director_sLastName = "Roberts",
					BusinessProfile = "Marketing",
					EmployeeNumber = Convert.ToInt16(random.Next(10,500)),
					Address = "Menlo Park, California, United States"
				},
				new Firm()
				{
					Name = "Tencent",
					DateOfEstablishment = new DateTime(2009,07,09),
					Director_sFirstName = "David",
					Director_sLastName = "Patterson",
					BusinessProfile = "Technologies",
					EmployeeNumber = Convert.ToInt16(random.Next(10,500)),
					Address = "Tencent Binhai Mansion, Nanshan District, Shenzhen, Guangdong, China"
				},
				new Firm()
				{
					Name = "Alibaba",
					DateOfEstablishment = new DateTime(2020,06,20),
					Director_sFirstName = "Quenten",
					Director_sLastName = "Allen",
					BusinessProfile = "Sales",
					EmployeeNumber = Convert.ToInt16(random.Next(10,500)),
					Address = "Hangzhou, China"
				},
				new Firm()
				{
					Name = "Nike",
					DateOfEstablishment = new DateTime(2012,05,06),
					Director_sFirstName = "Todd",
					Director_sLastName = "Miller",
					BusinessProfile = "Сlothes",
					EmployeeNumber = Convert.ToInt16(random.Next(10,500)),
					Address = "Beaverton, Oregon, United States"
				},
			};
		}
	}
}
