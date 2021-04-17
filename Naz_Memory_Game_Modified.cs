using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Naz_MemoryGame_Modified
{
	public partial class Form1 : Form
	{
		Random random = new Random();
		//list of characters
		List<string> icons = new List<string>
		{
			//changes "image in boxs" based off of values
			"!", "!","N","N",",",",","k","k",
			"b","b","v","v","w","w","z","z"
		};
		//
		Label firstClicked, secondClicked;

		public Form1()
		{
			InitializeComponent();
			//method that was made.
			AssignIconsToSquares();
			//another method to play?
		}
		private void AssignIconsToSquares()
		{
			Label label;
			int randomNumber;

			for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
			{
				//treats layout like an array
				if (tableLayoutPanel1.Controls[i] is Label)
				{
					//creates label inside it.
					label = (Label)tableLayoutPanel1.Controls[i];
				}
				else
				{
					continue;
				}
				//put random number in spots, puts number untill the 'table' is filled.
				randomNumber = random.Next(0, icons.Count);
				label.Text = icons[randomNumber];
				//Removes the letter/number from the list above.
				icons.RemoveAt(randomNumber);
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			timer1.Stop();

			firstClicked.ForeColor = firstClicked.BackColor;
			secondClicked.ForeColor = secondClicked.BackColor;

			firstClicked = null;
			secondClicked = null;
		}

		private void label_Click(object sender, EventArgs e)
		{
			if (firstClicked != null && secondClicked != null)
			{
				return;
			}
			//Nani?
			Label clickedLabel = sender as Label;

			if (clickedLabel == null)
			{
				return;
			}

			if (clickedLabel.ForeColor == Color.Black)
			{
				return;
			}
			//no first click yet
			if (firstClicked == null)
			{
				firstClicked = clickedLabel;
				firstClicked.ForeColor = Color.Black;
				return;
			}
			secondClicked = clickedLabel;
			secondClicked.ForeColor = Color.Black;
			//if everthing is selected do below.
			CheckForWinner();


			if (firstClicked.Text == secondClicked.Text)
			{
				//start over
				firstClicked = null;
				secondClicked = null;

			}
			else
			{
				timer1.Start();

			}
		}
		private void CheckForWinner()
		{
			Label label;
			//cycles through entire "grid"
			//Label != null && colors don't match = you don't win yet.
			for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
			{
				label = tableLayoutPanel1.Controls[i] as Label;

				if (label != null && label.ForeColor == label.BackColor)
				{
					return;
				}

			}//end loops
			
			MessageBox.Show("Did you like the game?");
			//I was going to put something else here, but it was too complicated at the moment.
			Close();

		}

	}
}
