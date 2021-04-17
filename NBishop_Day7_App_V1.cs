using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nbishop_Day6Ass1
{
	class Program
	{
		static void Main(string[] args)
		{
			/*
			Create Program that allows user to enter: name, favorite food, color, sports team, musical act, movie, and animal.
			
			Display entered infor in the form of a pragraph.

			Include a welcome message: "Hello, let us learn more about you!"

			Include a closing message: thank you for your contribution.
			*/

			string name, fFood, FColor, FSTeam, FMusAct, FMove, FAn;


			Console.WriteLine("Hello, let's learn more about you!");
			Console.WriteLine("Name: ");
			name = Console.ReadLine();
			Console.WriteLine("Favorite Food:");
			fFood = Console.ReadLine();
			Console.WriteLine("Favorite Color: ");
			FColor = Console.ReadLine();
			Console.WriteLine("Favorite Sports Team: ");
			FSTeam = Console.ReadLine();
			Console.WriteLine("Favoirte Musical Act:");
			FMusAct = Console.ReadLine();
			Console.WriteLine("Favorite Movie: ");
			FMove = Console.ReadLine();
			Console.WriteLine("Favorite animal: ");
			FAn = Console.ReadLine();

			Console.WriteLine("Your name is: " + name + "\nYour favorite: \n Food: " + fFood + "\n Color: " + FColor + "\n Sports Team: " + FSTeam + "\n Musical Act: " + FMusAct + "\n Movie: " + FMove + "\n Animal: " + FAn);



			Console.WriteLine("Thank you, Have a nice day.");
		}
	}
}
