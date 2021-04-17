using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Bishop_MethodOfComparison
{
	class Program
	{
		static void Main(string[] args)
		{
			string string1 = "Naz.";
			string string2 = "Nazareth";

			string string4 = "Bishop";

			//Console.WriteLine("What do you want to see?");
			//string input = Console.ReadLine();
			//Contains
			Console.WriteLine(string2.Contains(string1));
			//ends with
			bool end = string1.EndsWith(".");
			Console.WriteLine("{0} Ends in a {1}", string1, end);

			//index of
			int loc;
			loc = string2.IndexOf('t', 0);
			Console.WriteLine("Index of letter t in String2 = " +loc);
			//doesn't display index???
			//Update: it works
			//tolower
			string lower = string1.ToLower();
			Console.WriteLine(lower);
			//toupper
			string upper = string1.ToUpper();
			Console.WriteLine(upper);
			//insert
			Console.WriteLine("Before: "+string2);
			Console.WriteLine("After: " + string2.Insert(8, "!!!"));
			//remove
			Console.WriteLine("Before: " + string4);
			Console.WriteLine("After: " +string4.Remove(3));
			//replace
			Console.WriteLine("Before: " + string2);
			Console.WriteLine("After: " + string4.Replace("Bishop", "Thomas"));
			//split
			string[] stringSeparators = new string[] { "[stop}" };
			Console.WriteLine(string2.Split(stringSeparators, 2, StringSplitOptions.RemoveEmptyEntries));
			//doesn't split correctly??
			//tochararray
			char[] array = string2.ToCharArray();
			Console.WriteLine(string2);
			Console.WriteLine("Character Array:");
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(" " + array[i]);
			}


			Console.ReadKey();
		}
	}
}
