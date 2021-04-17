using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBishop_Day7Quiz
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{

			label1.Text = "Charlie and his father, an engineer, decided to build a treehouse in their backyard.";
			label2.Hide();
			label3.Hide();
			int btnClck;


			textBox1.Text = "In order to start constructing the house, Charlie and his father needed to gather\n some wood from the forest.If they initially have 15 extra planks of wood in the\n house and Charlie and his father got 10 planks of wood each, how many pieces\n of wood do they have in total";
			textBox2.Text = "While building the house, Charlie noticed that they were running out of nails so\n he told his father he’s going to buy some.If they still have 9 nails left and Charlie\n bought 2 boxes of nails, the big one containing 55 nails and the small one\n containing 31, how many nails will they have?";
			textBox3.Text = "To have a more stable treehouse, Charlie’s father decided to tie the corner posts\n of the house to the tree itself.He used 24 inches of rope for the first post, 20\n inches on the second, 14 inches on the third and 12 inches on the fourth.He also\n had 15 feet of cable, but didn’t use that.How many inches of rope were used ? ";
			textBox4.Text = "The treehouse is almost done; all they need is to paint it.His father estimated\n that they will use 20 ounces of white paint, 15 ounces of green paint and 34\n ounces of brown paint. How many ounces of paint would they buy in total ?";
			textBox5.Text = "Upon finishing the treehouse, Charlie’s mother served them freshly baked\n" +
"cookies.If Charlie ate 15 cookies, his father ate 10 and his mother only ate 5,\n" +
"please write an equation to show how many cookies were eaten";
			//Question 1 answers
			button1.Text = "35";
			button2.Text = "25";
			button3.Text = "45";
			//group 2
			button4.Text = "95";
			button5.Text = "105";
			button6.Text = "70";
			//group 3
			button7.Text = "70";
			button8.Text = "103";
			button9.Text = "50";
			//gropup 4
			button10.Text = "69";
			button11.Text = "72";
			button12.Text = "66";
			//group 5
			button13.Text = "30";
			button14.Text = "35";
			button15.Text = "25";
			//labels right wrong
			label2.Text = "Right: " + Convert.ToString(right);
			label3.Text = "Wrong: " + Convert.ToString(wrong);
			//hmmm, what am I doing wrong?


			/*Charlie and his father, an engineer, decided to build a treehouse in their backyard.

1.In order to start constructing the house, Charlie and his father needed to gather
some wood from the forest.If they initially have 15 extra planks of wood in the
house and Charlie and his father got 10 planks of wood each, how many pieces
of wood do they have in total ?

2.While building the house, Charlie noticed that they were running out of nails so\n he told his father he’s going to buy some.If they still have 9 nails left and Charlie\n bought 2 boxes of nails, the big one containing 55 nails and the small one\n containing 31, how many nails will they have?

3.To have a more stable treehouse, Charlie’s father decided to tie the corner posts\n
of the house to the tree itself.He used 24 inches of rope for the first post, 20\n 
inches on the second, 14 inches on the third and 12 inches on the fourth.He also\n 
had 15 feet of cable, but didn’t use that.How many inches of rope were used?

4.The treehouse is almost done; all they need is to paint it.His father estimated\n that they will use 20 ounces of white paint, 15 ounces of green paint and 34\n ounces of brown paint. How many ounces of paint would they buy in total ?

5.Upon finishing the treehouse, Charlie’s mother served them freshly baked\n
cookies.If Charlie ate 15 cookies, his father ate 10 and his mother only ate 5,\n
please write an equation to show how many cookies were eaten in total?

----------------------------------------------------------------------------

(DO NOT INCLUDE THE ANSWERS IN THE ACTUAL QUIZ)

Answers:
1. 15 + 10 + 10 = 35
There are 35 planks of wood.
2. 9 + 31 + 55 = 95
They have 95 pieces of nails.
3. 24 + 14 + 12 + 20 = 70
Charlie’s father used 70 inches of rope.
4. 20 + 15 + 34 = 69
They should buy a total of 69 ounces of paint.
5. 15 + 10 + 5 = 30
There were 30 cookies eaten.*/

		}

		// Was going todo a wrong/right and hide/show type thing with the buttons but time is running out.
		 int btnClick = 0;
		int right = 0;
		int wrong = 0;
		private void button1_Click(object sender, EventArgs e)
		{
			btnClick = 1;
			right += 1;
			if(btnClick == 1)
			{
				button2.Hide();
				button3.Hide();
			}
			else
			{
				button2.Show();
				button3.Show();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			btnClick = 1;
			wrong += 1;
			if (btnClick == 1)
			{
				button1.Hide();
				button3.Hide();
			}
			else
			{
				button1.Show();
				button3.Show();
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			btnClick = 1;
			wrong += 1;
			if (btnClick == 1)
			{
				button1.Hide();
				button2.Hide();
			}
			else
			{
				button1.Show();
				button2.Show();
			}
		}
		//group 2
		private void button4_Click(object sender, EventArgs e)
		{
			btnClick = 1;
			right += 1;
			if (btnClick == 1)
			{
				button5.Hide();
				button6.Hide();
			}
			else
			{
				button6.Show();
				button5.Show();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			btnClick = 1;
			wrong += 1;
			if (btnClick == 1)
			{
				button6.Hide();
				button4.Hide();
			}
			else
			{
				button4.Show();
				button6.Show();
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			btnClick = 1;
			wrong += 1;
			if (btnClick == 1)
			{
				button4.Hide();
				button5.Hide();
			}
			else
			{
				button4.Show();
				button5.Show();
			}
		}
		//group 3
		private void button7_Click(object sender, EventArgs e)
		{
			btnClick = 1;
			right += 1;
			if (btnClick == 1)
			{
				button8.Hide();
				button9.Hide();
			}
			else
			{
				button8.Show();
				button9.Show();
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			btnClick = 1;
			wrong += 1;
			if (btnClick == 1)
			{
				button7.Hide();
				button9.Hide();
			}
			else
			{
				button7.Show();
				button9.Show();
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			btnClick = 1;
			wrong += 1;
			if (btnClick == 1)
			{
				button7.Hide();
				button8.Hide();
			}
			else
			{
				button7.Show();
				button8.Show();
			}
		}
		//group 4
		private void button10_Click(object sender, EventArgs e)
		{
			btnClick = 1;
			right += 1;
			if (btnClick == 1)
			{
				button12.Hide();
				button11.Hide();
			}
			else
			{
				button12.Show();
				button11.Show();
			}
		}

		private void button11_Click(object sender, EventArgs e)
		{
			btnClick = 1;
			wrong += 1;
			if (btnClick == 1)
			{
				button10.Hide();
				button12.Hide();
			}
			else
			{
				button10.Show();
				button12.Show();
			}
		}

		private void button12_Click(object sender, EventArgs e)
		{
			btnClick = 1;
			wrong += 1;
			if (btnClick == 1)
			{
				button11.Hide();
				button10.Hide();
			}
			else
			{
				button11.Show();
				button10.Show();
			}
		}
		//group 5
		private void button13_Click(object sender, EventArgs e)
		{
			btnClick = 1;
			right += 1;
			if (btnClick == 1)
			{
				button14.Hide();
				button15.Hide();
			}
			else
			{
				button15.Show();
				button14.Show();
			}
		}

		private void button14_Click(object sender, EventArgs e)
		{
			btnClick = 1;
			wrong += 1;
			if (btnClick == 1)
			{
				button15.Hide();
				button14.Hide();
			}
			else
			{
				button15.Show();
				button14.Show();
			}
		}

		private void button15_Click(object sender, EventArgs e)
		{
			btnClick = 1;
			wrong += 1;
			if (btnClick == 1)
			{
				button14.Hide();
				button13.Hide();
			}
			else
			{
				button14.Show();
				button13.Show();
			}
		}
	}
}
