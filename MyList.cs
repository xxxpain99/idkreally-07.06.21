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
				
			}

			Node <T> last = firstElement;

			while (last.next != null)
			{
				last = last.next;
			}
			last.next = asd;

		}
		Node <T> firstElement;
		
	}
}
