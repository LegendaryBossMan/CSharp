using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp9
{
	class Program
	{
		static void Main(string[] args)
		{
			string data;
			FileStream fn = new FileStream("C:\\Users\\NAZBI\\Desktop\\SuperSecretMessage", FileMode.Create);
			fn.Close();
			FileStream fs = new FileStream("C:\\Users\\NAZBI\\Desktop\\SuperSecretMessage", FileMode.Append);
			byte[] bdata = Encoding.Default.GetBytes("We're no strangers to love You know the rules and so do I A full commitment's what I'm thinking of You wouldn't get this from any other guy I just wanna tell you how I'm feeling Gotta make you understand Never gonna give you up Never gonna let you down Never gonna run around and desert you\nNever gonna make you cry Never gonna say goodbye Never gonna tell a lie and hurt you\nWe've known each other for so long Your heart's been aching but You're too shy to say it");
			fs.Write(bdata, 0, bdata.Length);
			Console.WriteLine("It is done.");
			fs.Close();
			FileStream fssource = new FileStream("C:\\Users\\NAZBI\\Desktop\\SuperSecretMessage", FileMode.Open, FileAccess.Read);
			using (StreamReader sr = new StreamReader(fssource))
			{
				data = sr.ReadToEnd();
			}
			Console.WriteLine(data);
			Console.ReadKey();
		}

	}
}
