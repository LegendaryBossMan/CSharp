using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBishop_Day6Ass1pt2
{
	class Program
	{
		static void Main(string[] args)
		{


			Gather.Run();
		}
	}
	class Gather
	{
		static string[] info = new string[] { "name", "fFood", "FColor", "FSTeam", "FMusAct", "FMove", "FAn"};
		static string[] need = new string[] { "Name: ", "Favorite Food: ", "Favorite Color: ", "Favorite Sports Team: ", "Favorite Musical Act: ", "Favorite Movie: ", "Favorite Animal: "};
		static string output;

		//Methods
		//Must be public static for allowense in main.
		public static void Run()
		{
			Start();
			GetInfo();
			outPut();
			End();
		}



		static void Start()
		{
			Console.WriteLine("Welcome, Let us learn more about you.");
		}

		static void GetInfo()
		{
			for(int i = 0; i < info.Length; i++)
			{
				Console.WriteLine("Please enter your " + need[i]);
				info[i] = Console.ReadLine();
			}
			Console.Clear();
		}
		static void outPut()
		{
			output = "Your name is: {0}\nYour favorite: \n Food: {1}\n Color: {2}\n Sports Team: {3}\n Musical Act: {4}\n Movie: {5}\n Animal: {6}";
			Console.WriteLine(output, info[0], info[1], info[2], info[3], info[4], info[5], info[6]);
			
		}
		static void End()
		{
			Console.WriteLine("Thank you for co-operating. Have a nice day.");

		}










	}




}
