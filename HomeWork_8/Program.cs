namespace HomeWork_8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//QueueRing<int> qr = new QueueRing<int>(5);

			//qr.Add(1);
			//qr.Add(2);
			//qr.Add(3);
			//qr.Add(4);
			//qr.Add(5);

			//foreach (var item in qr)
			//{
			//	Console.Write($"{item} ");
			//}
			//Console.WriteLine();

			//qr.Move();
			//qr.Move();
			//qr.Move();

			//foreach (var item in qr)
			//{
			//	Console.Write($"{item} ");
			//}
			//Console.WriteLine();



			PriorityQueue<int> pq = new PriorityQueue<int>();

			pq.Push(10, 1);
			pq.Push(9, 3);
			pq.Push(1, 2);
			pq.Push(7, 9);
			pq.Push(12, 1);
			pq.Push(20, 5);

			
			pq.Show();
			Console.WriteLine();


			pq.Pop();
			pq.Pop();
			pq.Pop();


			pq.Show();
			Console.WriteLine();
		}
	}
}