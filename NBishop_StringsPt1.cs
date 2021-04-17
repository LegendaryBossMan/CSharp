using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] characterArray = { 'b', 'i', 'r', 't', 'h',' ',	'd', 'a', 'y' };
			//above not done that often. spells out words letter by letter.
			string originalString = "Welcome to C# programming!";
			//string object, treated like an array. Just letter put together.
			string string1 = originalString;
			//equals above string.
			string string2 = new string(characterArray);
			//creates object out of the array
			//Prints out character array
			string string3 = new string(characterArray, 6, 3);
			//creates variation of string method, 3 parameters.
			//prints out the word day
			string string4 = new string('F', 5);
			//prints out 5 F's

			Console.WriteLine("String1= "+string1);
			Console.WriteLine("String2= " + string2);
			Console.WriteLine("String3= " + string3);
			Console.WriteLine("String4= " + string4);

			//Part 1 end




			//Start Part2
			string string5 = "Nicholas";
			string string6 = "Keane";
			string string7;
			//did he forget the variable type?
			//he did, "making sure we are paying attention", he says 

			string7 = String.Concat(string5, ' ' ,string6);
		//added space from original, concatinates strings
			Console.WriteLine(string7);
			Console.WriteLine(string5);


			Console.ReadKey();
		}
	}
}
