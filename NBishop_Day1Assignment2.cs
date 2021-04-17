using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBishop_Triangle
{
	class Triangle
	{
		private double aLeg;
		private double bLeg;

		public void NumInput()
		{
			Console.WriteLine("Enter length of first leg: ");
			aLeg = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter length of second leg: ");
			bLeg = Convert.ToDouble(Console.ReadLine());
		}
		public void Display()
		{
			Console.WriteLine("First Leg: {0}\nSecond Leg: {1}\nArea: {2}", aLeg, bLeg, GetArea());

		}
		public double GetArea()
		{
			return aLeg * bLeg / 2;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Triangle tri = new Triangle();

			tri.NumInput();
			tri.Display();
			Console.ReadKey();

		}
	}
}
