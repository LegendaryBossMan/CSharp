using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPt2
{
	class Program
	{
		static void Main(string[] args)
		{
			string string1 = "alan";
			string string2 = "michael schaefer";
			string string3 = "Angel Rosario";
			string string4 = "angel rosario";

			Console.WriteLine(string1);
			Console.WriteLine(string2);
			Console.WriteLine(string3);
			Console.WriteLine(string4);

			if(string1.Equals("alan"))
			{
				Console.WriteLine("string1 = alan ");
			}
			else
			{
				Console.WriteLine("string1 != alan");
			}
			if(string1 == "alan")
			{
				Console.WriteLine("string1 = alan ");
			}
			else
			{
				Console.WriteLine("string1 != alan");
			}
			if(string.Equals(string3, string4))
			{
				Console.WriteLine("String3 = string4");
			}
			else
			{
				Console.WriteLine("string 3 != string4");
			}

			Console.WriteLine(string1.CompareTo(string2));
			Console.WriteLine(string2.CompareTo(string1));
			Console.WriteLine(string1.CompareTo(string1));
			Console.WriteLine(string3.CompareTo(string4));
			Console.WriteLine(string4.CompareTo(string3));
			Console.WriteLine(string3.CompareTo(string3));
			Console.WriteLine(string4.CompareTo(string4));
			/*-1 = less than
			//1 = greater than
			//0 = equal to.
			similar things:
					compareto()
					contains()
					endwith()
					equals()
					indexof()
					tolower()
					toupper()
					insert()
					remove()
					replace()
					split()
					toCharArray()
			*/
			Console.ReadLine();
		}
	}
}
