using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8
{
	internal class PriorityQueue<Value>
	{
		public PriorityQueue()
		{
			queueOfItems = new SortedList<int, List<Value>>();
		}

		private SortedList<int, List<Value>> queueOfItems;
		

		public void Push(Value item, int priority)
		{
			if (queueOfItems.Count == 0 || !queueOfItems.ContainsKey(priority))
			{
				List<Value> l = new List<Value>();
				l.Add(item);
				queueOfItems.Add(priority, l);
			}
			else if (queueOfItems.ContainsKey(priority))
			{
				queueOfItems[priority].Add(item);
			}
		}


		public Value Pop()
		{
			if (queueOfItems.Count > 0)
			{
				var keys = queueOfItems.Keys;

				Value item = queueOfItems[keys[0]][0];

				queueOfItems[keys[0]].RemoveAt(0);

				if (queueOfItems[keys[0]].Count == 0)
				{
					queueOfItems.RemoveAt(0);
				}

				return item;
			}

			throw new InvalidOperationException();
		}


		public int Count()
		{
			return queueOfItems.Count;
		}


		public void Clear()
		{
			queueOfItems.Clear();
		}


		public bool IsEmpty()
		{
			return queueOfItems.Count == 0;
		}


		public void Show()
		{
			if (queueOfItems.Count > 0)
			{
				var keys = queueOfItems.Keys;

				for (int i = 0; i < keys.Count; ++i)
				{
					for (int j = 0; j < queueOfItems[keys[i]].Count; ++j)
					{
						Console.Write($"{queueOfItems[keys[i]][j]} ");
					}
				}
			}
			
		}
	}


}
