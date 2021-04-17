using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBishopDay1Ass3
{
	class Program
	{
		static void Main(string[] args)
		{
			int n;
			int count;
			Console.WriteLine("Enter a number: ");
			n = int.Parse(Console.ReadLine());
			for(count = 0; count < n; count++)
			{
				Console.WriteLine("F/n");
			}
			Console.ReadKey();

			int[] MrSullivanLovesPurple = new int[35];
			//I forgot you age, I have it in another assignment along time ago...somewhere.
			int SullivanLength = MrSullivanLovesPurple.Length;
			Console.WriteLine("Mr. Sullivan is a kind an careing instructor: {0}", MrSullivanLovesPurple.Length);

 
		}
	}
}
