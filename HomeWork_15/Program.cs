namespace HomeWork_15
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string path = "payment.bin";
			Payment? payment = new(500, 10, 5, 5);


			Console.WriteLine(payment);
			Payment.Serialize(payment, path);

			payment = null;

			Payment.Deserialize(out payment, path);
			Console.WriteLine(payment);


			Payment.IsFullSerialization = false;


			Console.WriteLine("\n");

			Console.WriteLine(payment);
			Payment.Serialize(payment, path);


			Payment.IsFullSerialization = true;


			payment = null;

			Payment.Deserialize(out payment, path);
			Console.WriteLine(payment);
		}
	}
}