using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_15
{
	[Serializable]
	class Payment : ISerializable
	{
		public Payment(int dailyPayment, int dayCount, int penaltyForOneDayDelay, int dayCountDelay)
		{
			DailyPayment		  = dailyPayment;
			DayCount			  = dayCount;
			PenaltyForOneDayDelay = penaltyForOneDayDelay;
			DayCountDelay		  = dayCountDelay;
			IsFullSerialization   = true;
			MakeCalculations();
		}


		private Payment(SerializationInfo info, StreamingContext context)
		{
			DailyPayment = info.GetInt32("DailyPayment");
			DayCount = info.GetInt32("DayCount");
			PenaltyForOneDayDelay = info.GetInt32("PenaltyForOneDayDelay");
			DayCountDelay = info.GetInt32("DayCountDelay");
			IsFullSerialization = info.GetBoolean("IsFullSerialization");
			if (IsFullSerialization)
			{
				AmountWithoutPenalty = info.GetInt32("AmountWithoutPenalty");
				Penalty = info.GetInt32("Penalty");
				TotalPayment = info.GetInt32("TotalPayment");
			}
		}


		public int DailyPayment { get; private set; }
		public int DayCount { get; private set; }
		public int PenaltyForOneDayDelay { get; private set; }
		public int DayCountDelay { get; private set; }
		public int AmountWithoutPenalty { get; private set; }
		public int Penalty { get; private set; }
		public int TotalPayment { get; private set; }
		public static bool IsFullSerialization { get; set; }


		public void MakeCalculations()
		{
			AmountWithoutPenalty = DailyPayment * DayCount;
			Penalty = PenaltyForOneDayDelay * DayCountDelay;
			TotalPayment = AmountWithoutPenalty + Penalty;
		}


		public static void Serialize(Payment payment, string pathToFile)
		{
			#pragma warning disable SYSLIB0011

			BinaryFormatter bf = new();
			using(Stream stream = File.Create(pathToFile))
			{
				bf.Serialize(stream, payment);
			}

			#pragma warning restore SYSLIB0011
		}


		public static void Deserialize(out Payment payment, string pathToFile)
		{
			#pragma warning disable SYSLIB0011
			
			BinaryFormatter bf = new();
			using (Stream stream = File.OpenRead(pathToFile))
			{
				payment = (Payment)bf.Deserialize(stream);
			}

			#pragma warning restore SYSLIB0011
		}


		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("DailyPayment", DailyPayment);
			info.AddValue("DayCount", DayCount);
			info.AddValue("PenaltyForOneDayDelay", PenaltyForOneDayDelay);
			info.AddValue("DayCountDelay", DayCountDelay);
			info.AddValue("IsFullSerialization", IsFullSerialization);
			if (IsFullSerialization)
			{
				info.AddValue("AmountWithoutPenalty", AmountWithoutPenalty);
				info.AddValue("Penalty", Penalty);
				info.AddValue("TotalPayment", TotalPayment);
			}
		}


		public override string ToString()
		{
			if (IsFullSerialization)
			{
				MakeCalculations();
			}
			return $"Daily Payment: ".PadRight(27) + $"{DailyPayment}\n" +
				   $"Day Count: ".PadRight(27) + $"{DayCount}\n" +
				   $"Penalty For One Day Delay: ".PadRight(27) + $"{PenaltyForOneDayDelay}\n" +
				   $"Day Count Delay: ".PadRight(27) + $"{DayCountDelay}\n" +
 				   (!IsFullSerialization ? "" :
				   $"Amount Without Penalty: ".PadRight(27) + $"{AmountWithoutPenalty}\n" +
				   $"Penalty: ".PadRight(27) + $"{Penalty}\n" +
				   $"Total Payment: ".PadRight(27) + $"{TotalPayment}\n");
		}
	}
}
