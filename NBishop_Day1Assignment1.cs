using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewDay1
{
	class Program
	{
		static void Main(string[] args)
		{
			short a = 10;
			int b = 20;

			double c = a + b;
			Console.WriteLine("a={0},b={1},c={2}", a, b, c);
			Console.ReadKey();
			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 

			//Create a program:
			//That has 5 numbers stored in different variables
			//Display the result of adding them together
			//First two numbers display
			//Display result of multiplying
			//3rd and 4th number
			//Display 5th number squared
			int first = 1;
			int second = 3;
			int third = 5;
			int fourth = 7;
			int fifth = 9;

			int add = first + second;
			int mult = third * fourth;
			int sqr = fifth * fifth;

			Console.WriteLine("Adding first and second number: {0}, Multipy 3rd and 4th number: {1}, Square of the 5th number: {2}", add, mult, sqr);
			Console.ReadLine();

			












		}
	}
}
