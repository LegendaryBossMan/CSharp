using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBishop_Quiz1
{
	class Program
	{
		static void Main(string[] args)
		{
			string string1 = "NANCY";
			string string2 = "Vanderwheelie";
			string string3 = "Nazawrath";
			string string4 = "Pope";



			for(int i = 0;i < 3; i++)
			{
				Console.WriteLine(string1);
				for(int y = 0; y < 3; y++)
				{
					Console.WriteLine(string2);
				}
			}
			//Part 2

			Console.WriteLine(string3.ToUpper() + " " + string4.ToUpper());
			int compare;
			compare = Convert.ToInt32(string3.CompareTo(string4));
			int compare2;
			compare2 = Convert.ToInt32(string4.CompareTo(string3));
			Console.WriteLine(string3.CompareTo(string4));
			if(compare ==1)
			{
				Console.WriteLine("The string3 > string4");
				 if (compare2 == 0)
				{
					Console.WriteLine("string4 = string3");
				}
				else if (compare2 == -1)
				{
					Console.WriteLine("string4 < string3");
				}
				else if (compare2 == 1)
				{
					Console.WriteLine("string4 > string3");
				}
			}
			else if(compare == -1)
			{
				Console.WriteLine("string4 > string3");
				 if (compare2 == 0)
				{
					Console.WriteLine("string4 = string3");
				}
				else if (compare2 == -1)
				{
					Console.WriteLine("string4 < string3");
				}
				else if (compare2 == 1)
				{
					Console.WriteLine("string4 > string3");
				}
			}
			else if(compare == 0)
			{
				Console.WriteLine("The strings =");
				 if (compare2 == 0)
				{
					Console.WriteLine("string4 = string3");
				}
				else if (compare2 == -1)
				{
					Console.WriteLine("string4 < string3");
				}
				else if (compare2 == 1)
				{
					Console.WriteLine("string4 > string3");
				}
			}
			else if(compare2 == 0)
			{
				Console.WriteLine("string4 = string3");
				if (compare2 == 0)
				{
					Console.WriteLine("string4 = string3");
				}
				else if (compare2 == -1)
				{
					Console.WriteLine("string4 < string3");
				}
				else if (compare2 == 1)
				{
					Console.WriteLine("string4 > string3");
				}
			}
			else if(compare2 == -1)
			{
				Console.WriteLine("string4 < string3");
				if (compare2 == 0)
				{
					Console.WriteLine("string4 = string3");
				}
				else if (compare2 == -1)
				{
					Console.WriteLine("string4 < string3");
				}
				else if (compare2 == 1)
				{
					Console.WriteLine("string4 > string3");
				}
			}
			else if(compare2 == 1)
			{
				Console.WriteLine("string4 > string3");
				 if (compare2 == 0)
				{
					Console.WriteLine("string4 = string3");
				}
				 if (compare2 == -1)
				{
					Console.WriteLine("string4 < string3");
				}
				else if (compare2 == 1)
				{
					Console.WriteLine("string4 > string3");
				}
			}
			else
			{
				Console.WriteLine("What more could you want Mr.Sullivan?");
			}
			Console.ReadLine();
		}
	}
}
