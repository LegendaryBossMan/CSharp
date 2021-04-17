using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBishop_Day8_Quiz
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
			lblCor1.Text = "";
			lblCor2.Text = "";
			lblCor3.Text = "";
			lblCor4.Text = "";
			lblCor5.Text = "";
			//questions
			textBox1.Text = "What is Goku's real name in Dragon Ball Z?";
			//Kakarot
			textBox2.Text = "Who is Mr. Sullivans Favorite singer?";
			//Rick Astley
			textBox3.Text = "Who is getting a 99% on this assignment?";
			//Naz
			textBox4.Text = "Who is Batman's sidekick?";
			//Robin
			textBox5.Text = "Who has the IQ of a Goldfish?";
			//Alan
		}
		/*
In C#, create a 5 question trivia quiz application that contains:

1. Come up with 5 trivia questions (example: Who was the first president of the USA?)

2. Allow the user to type in the answer.

3. Display if the user got the answer correct.

4. Display the final score after all 5 questions have been answered.
		 */
		private void btnCheck_Click(object sender, EventArgs e)
		{
			string answer1 = "";
			string answer2 = "";
			string answer3 = "";
			string answer4 = "";
			string answer5 = "";
			int right = 0;
			int wrong = 0;


			//answer check

			answer1 = txtAns1.Text.ToLower();
			answer2 = txtAns2.Text.ToLower();
			answer3 = txtAns3.Text.ToLower();
			answer4 = txtAns4.Text.ToLower();
			answer5 = txtAns5.Text.ToLower();
			//Question 1
			if(answer1 == "kakarot")
			{
				lblCor1.Text = "Correct";
				right++;
			}
			else
			{
				lblCor1.Text = "Wrong";
				wrong++;
			}
			//question 2
			if (answer2== "rick astley")
			{
			lblCor2.Text= "Correct";
				right++;
			}
			else
			{
			lblCor2.Text = "Wrong";
				wrong++;
			}
			//question 3
			if (answer3== "naz")
			{
			lblCor3.Text = "Correct";
				right++;
			}
			else
			{
			lblCor3.Text = "Wrong";
				wrong++;
			}
			//question 4
			if (answer4 == "robin")
			{
			lblCor4.Text = "Correct";
				right++;
			}
			else
			{
			lblCor4.Text = "Wrong";
				wrong++;
			}
			//question 5
			if (answer5 == "alan")
			{
			lblCor5.Text = "Correct";
				right++;
			}
			else
			{
			lblCor5.Text = "Wrong";
				wrong++;
			}
			MessageBox.Show("Number Correct: " + right + " Number Incorrect: " + wrong);









		}
	}
}
