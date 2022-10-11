using System.Xml.Linq;
using System;

namespace HomeWork_4
{
	internal class Program
	{
		enum Gender
		{
			Male, Female
		}
		abstract class Passport
		{
			public string? FirstName { get; set; }
			public string? LastName { get; set; }
			public Gender @Gender { get; set; }
			public DateTime Birthday { get; set; }
			public string? Citizenship { get; set; }
			public DateTime DateOfIssue { get; set; }
			public string? Birthplace { get; set; }
			public string? PlaceOfIssue { get; set; }


			public Passport() { }


			protected string ShowName()
			{
				return $"First Name: ".PadRight(18) + FirstName + "\n" +
						$"Last Name: ".PadRight(18) + LastName + "\n";
			}


			public override string ToString()
			{
				return $"Gender: ".         PadRight(18) + @Gender + "\n" +
					   $"Birthday: ".       PadRight(18) + Birthday.ToShortDateString() + "\n" +
					   $"Citizenship: ".    PadRight(18) + Citizenship + "\n" +
					   $"Birthplace: ".     PadRight(18) + Birthplace + "\n" +
					   $"Place of issue: ". PadRight(18) + PlaceOfIssue + "\n" +
					   $"Date of issue: ".  PadRight(18) + DateOfIssue.ToShortDateString() + "\n";
			}
		}



		class CountryPassport : Passport
		{
			public string? Patronymic { get; set; }
			public string? Registration { get; set; }


			public CountryPassport() { }


			public override string ToString()
			{
				return ShowName() +
					   $"Patronymic: ".PadRight(18) + Patronymic + "\n" +
					   base.ToString() + 
					   $"Registration: ".PadRight(18) + Registration + "\n";
			}
		}

		
		class Visa
		{
			string NameVisa;
			DateTime Validity;


			public Visa(string name, DateTime validity)
			{
				NameVisa = name;
				Validity = validity;
			}

			public override string ToString()
			{
				return $"   ~Name and direction of the visa: ".PadRight(37) + NameVisa + "\n" +
					    "   ~Validity: ".PadRight(37) + Validity.ToShortDateString();
			}
		}


		class ForeignPassport : Passport
		{
			public string? NumberOfPassport { get; set; }
			Visa[]? @Visa;

			public ForeignPassport() { }

			public void SetVisa(string name, DateTime dateTime)
			{
				if (@Visa == null)
				{
					@Visa = new Visa[1];
					@Visa[0] = new Visa(name, dateTime);
				}
				else
				{
					Visa[] @Visa_= new Visa[@Visa.Length + 1];


					for (int i = 0; i < @Visa.Length; ++i)
						@Visa_[i] = @Visa[i];


					@Visa_[@Visa_.Length - 1] = new Visa(name, dateTime);


					@Visa = @Visa_;
				}
			}


			public void RemoveVisa(int numberOfVisa)
			{
				if (@Visa == null)
				{
					return;
				}
				else
				{
					Visa[] @Visa_ = new Visa[@Visa.Length - 1];


					for (int i = 0; i < @Visa.Length; ++i)
					{
						if (i == numberOfVisa - 1)
						{
							continue;
						}
						@Visa_[i] = @Visa[i];
					}

					@Visa = @Visa_;
				}
			}


			public override string ToString()
			{
				string info = ShowName() +
							  base.ToString() +
					          $"Number of foreign passport: ".PadRight(18) + NumberOfPassport + "\n\n";

				if (@Visa == null)
				{
					info += "No valid visas.\n";
				}
				else
				{
					info += "Valid visas: \n";

					for (int i = 0; i < @Visa.Length; ++i)
					{
						info += @Visa[i] + "\n";
						info += "~ ~ ~ ~ ~ ~\n";
					}
				}

				return info;
			}
		}


		static void Main(string[] args)
		{
			CountryPassport countryPassport = new CountryPassport()
			{
				FirstName = "John",
				LastName = "Doe",
				Patronymic = "Smith`s",
				@Gender = Gender.Male,
				Birthday = new DateTime(1991, 12, 31),
				Birthplace = "Mykolayiv, Ukraine",
				Citizenship = "Ukraine",
				DateOfIssue = new DateTime(2005, 06, 12),
				PlaceOfIssue = "Mykolayiv, etc, etc, etc",
				Registration = "somewhere"
			};



			ForeignPassport foreignPassport = new ForeignPassport()
			{
				FirstName = "John",
				LastName = "Doe",
				@Gender = Gender.Male,
				Birthday = new DateTime(1991, 12, 31),
				Birthplace = "Mykolayiv, Ukraine",
				Citizenship = "Ukraine",
				DateOfIssue = new DateTime(2012, 09, 23),
				PlaceOfIssue = "Ukraine",
				NumberOfPassport = "AB374621"
			};


			foreignPassport.SetVisa("Schengen visa", new DateTime(2023, 04, 25));


			foreignPassport.SetVisa("Another visa", new DateTime(2025, 10, 11));


			Passport[] passports = { countryPassport, foreignPassport };


			for (int i = 0; i < passports.Length; ++i)
			{
				Console.WriteLine(passports[i]);
				Console.WriteLine();
			}


			foreignPassport.RemoveVisa(2);


			Console.WriteLine(passports[1]);
		}
	}
}