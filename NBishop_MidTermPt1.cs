using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NBishop_MidTermPt1
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			Create a program that allows the user to enter a string. Then:

	1. Display the length of the string.

	2. Display how many letters, numbers, and special characters are in the string.

	3. Display the string in reverse.

	4. Create a text file and store the entered string to the text file.
			*/

			string strng;
			int length;
			int letters = 0;
			int numbers = 0 ;
			int spcl =0;
			string rvrse = "";
			int i = 0;
			int l = 0;
			Console.WriteLine("Enter a word( With or without: letters, numbers, or symbols):");
			strng = Convert.ToString(Console.ReadLine());
			//Length of string
			Console.WriteLine("Length: " +strng.Length );
			//numbers of letter, numbers, and special characters
			 l = strng.Length;
			while (i < l)
			{
				if ((strng[i] >= 'a' && strng[i] <= 'z') || (strng[i] >= 'A' && strng[i] <= 'Z'))
				{
					letters++;
				}
				else if ((strng[i] >= '0' && strng[i] <= '9'))
				{
					numbers++;
				}
				else
				{
					spcl++;
				}

				i++;
			}
			Console.WriteLine("Letter: " + letters + "\nNumbers: " + numbers + "\nSymbols: " + spcl);
			//display it in reverse
			char[] array = strng.ToCharArray();
			Array.Reverse(array);
			Console.WriteLine(array);

			//create a text file and store string in text file
			FileStream fn = new FileStream("C:\\Users\\NAZBI\\Desktop\\String", FileMode.Create);
			fn.Close();
			FileStream fs = new FileStream("C:\\Users\\NAZBI\\Desktop\\String", FileMode.Append);
			byte[] bdata = Encoding.Default.GetBytes(strng);
		}
	}
}
