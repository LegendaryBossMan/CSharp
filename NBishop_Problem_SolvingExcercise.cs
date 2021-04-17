using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naz_ProblemSolvingExcercise
{
	class Program
	{
		static void Main(string[] args)
		{
			//inputed string var
			string str ="";
			//alphabet
			int alp = 0;
			//intigers
			int digit = 0;
			//symbols
			int sym = 0;

			int i = 0;
			//Length variable
			int l = 0;

			Console.WriteLine("Enter a string and I will count.");
			Console.WriteLine("Mr.Sullivan Thinks he is soooooo funnny....I forgot to laugh.");
			str = Console.ReadLine();
			
			
			//string length
			l = str.Length;
			 while(i < l)
			{
				if((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
				{
					alp++;	
				}
				else if((str[i] >= '0' && str[i] <= '9'))
				{
					digit++;
				}
				else
				{
					sym++;
				}

				i++;
			}
			Console.WriteLine("Letter: " +alp +"\nNumbers: " +digit +"\nSymbols: " + sym);
		}
	}
}
