using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp19
{
	class MyList <T>

	{
		public void Add(T value)
		{
			Node  <T> asd = new Node <T> ();
			asd.value = value;
			if (firstElement == null)
			{
				firstElement = asd;
			}
			else 
			{
				GetLast().next = asd;
			}


		}
		Node <T> firstElement;

		Node <T> GetLast()
		{
			Node<T> last = firstElement;

			while (last.next != null)
			{
				last = last.next;
			}
			return last;
		}
		 public void Print()
		 { 
			Node<T> last =firstElement;
			while (last != null)
			{
				Console.WriteLine(last.value);
				last = last.next;
				
			}
		 }
		public void AddFront(T value) // выводит предыдущий элемент
		{
			Node<T> rtd= new Node<T>();
			rtd.value = value;
			if (firstElement == null)
			{
				firstElement = rtd;
			}
			else
			{
				GetFirst().prev= rtd;
			}

			Node<T> GetFirst()
			{
				Node<T> last = firstElement;

				while (last.prev != null)
				{
					last = last.prev;
				}
				return last;
			}

		}

		

	}
}
