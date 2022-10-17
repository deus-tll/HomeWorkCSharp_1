using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8
{
	internal class QueueRing<T> : IEnumerable
	{
		public QueueRing(int _maxCount)
		{
			queueOfItems = new List<T>();
			maxCount = _maxCount;
		}


		private List<T> queueOfItems;
		private int maxCount;


		public void Clear()
		{
			if (queueOfItems is not null)
			{
				queueOfItems.Clear();
			}
		}


		public bool IsEmpty()
		{
			if (queueOfItems is not null)
			{
				return queueOfItems.Count == 0;
			}

			throw new NullReferenceException();
		}


		public bool IsFull()
		{
			if (queueOfItems is not null)
			{
				return maxCount == queueOfItems.Count;
			}
			throw new NullReferenceException();
		}


		public void Add(T item)
		{
			if (queueOfItems is not null && !IsFull())
			{
				queueOfItems.Add(item);
			}
		}


		public bool Move()
		{
			if (queueOfItems is not null && !IsEmpty())
			{
				T item = queueOfItems[0];
				queueOfItems.RemoveAt(0);
				queueOfItems.Add(item);
				return true;
			}
			return false;
		}

		public IEnumerator GetEnumerator()
		{
			if (queueOfItems is not null)
			{
				return queueOfItems.GetEnumerator();
			}
			throw new NullReferenceException();
		}
	}
}
