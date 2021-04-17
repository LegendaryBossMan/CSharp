using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Linq_Day4_Ass2
{
	class Program
	{
		static void Main(string[] args)
		{
		
			string[] Weekdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

			//LINQ query, connects data sources, variation of sql
			var myLinqQuery = from text in Weekdays
							  where text.Contains('T')
							  select text;
			foreach (var text in myLinqQuery)
			{
				Console.WriteLine(text + " ");
			}

			Console.ReadKey();
		}
	}
}
