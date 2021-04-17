using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naz_MidTermPt2
{
	public partial class Form1 : Form
	{
		int cyln = 0;
		int rec = 0;
		int box = 0;
		int trap = 0;
		int tri = 0;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			/*
			Create a Windows Form Application where:
	
	1. The user can enter a base and height. Then, by selecting different buttons, can choose to see the area of a rectangle (base x height), triangle (1/2(base x height)), and trapezoid (1/2(base1 + base2) x height). *You will need to be able to enter a third value for the trapezoid.

	2. Allow the user to be able to input the length, width, and height of a box and click a button to display the volume (v = l x w x h).

	3. Allow the user to be able to enter the radius and height of a cylinder and display the volume (v = PI x (r x r) x h). *Use 3.14 for PI.

	*You are able to enlarge the form window in the properties window if you desire.

	Submit Screen shots of the working program and code.
			*/
			input1.Hide();
			input2.Hide();
			input3.Hide();
			mthBtn.Hide();
			typeCalc.Hide();
			output.Hide();

			//make sure to unhide
		}

		private void rectMthBtn_Click(object sender, EventArgs e)
		{
			//base X height
			rec += 1;
			input1.Show();
			input2.Show();
			type1.Text = "Base:";
			type2.Text = "Height:";
			type3.Hide();
			input3.Hide();
			if (input1.Text != null && input2.Text != null)
			{
				mthBtn.Show();
			}
			}

		private void triMthBtn_Click(object sender, EventArgs e)
		{
			tri += 1;
			input1.Show();
			input2.Show();
			type1.Text = "Base:";
			type2.Text = "Height:";
			input3.Hide();
			type3.Hide();
			if (input1.Text != null && input2.Text != null)
			{
				mthBtn.Show();
			}
		}

		private void trapMthBtn_Click(object sender, EventArgs e)
		{
			trap += 1;
			input1.Show();
			input2.Show();
			input3.Show();
			type1.Text = "Base1:";
			type2.Text = "Base2:";
			type3.Text = "Height:";
			type3.Show();
			if (input1.Text != null && input2.Text != null && input3.Text != null)
			{
				mthBtn.Show();
			}

		}

		private void boxCalcBtn_Click(object sender, EventArgs e)
		{
			box += 1;
			input1.Show();
			input2.Show();
			input3.Show();
			type1.Show();
			type2.Show();
			type3.Show();
			type1.Text = "Length:";
			type2.Text = "Width:";
			type3.Text = "Height:";
			if (input1.Text != null && input2.Text != null && input3.Text != null)
			{
				mthBtn.Show();
			}
		}

		private void cylCalcBtn_Click(object sender, EventArgs e)
		{
			cyln = 1;
			input1.Show();
			input2.Show();
			type1.Text = "Radius:";
			type2.Text = "Height:";
			type3.Text = "";
			type3.Hide();
			input3.Hide();
			if (input1.Text != null && input2.Text != null)
			{
				mthBtn.Show();
			}
		}

		private void mthBtn_Click(object sender, EventArgs e)
		{
			if(box == 1)
			{
				int l = 0;
				int w = 0;
				int h = 0;
				int volume = 0;
				//volume = l x w x h
				l = Int32.Parse(input1.Text);
				w = Int32.Parse(input2.Text);
				h = Int32.Parse(input3.Text);
				volume = l * w * h;
				//add parsing
				typeCalc.Text = "Volume:";
				output.Show();
				output.Text = Convert.ToString(volume);
				input1.Clear();
				input2.Clear();
				input3.Clear();
			}
			else if(cyln == 1)
			{
				//volume = PI X (r X r) X h
				double R = 0;
				double H = 0;
				double volume = 0;
				R = Int32.Parse(input1.Text);
				H = Int32.Parse(input2.Text);
				volume = 3.14 * (R * R) * H;
				typeCalc.Text = "Volume:";
				output.Text = Convert.ToString(volume);
				input1.Clear();
				input2.Clear();
				input3.Clear();
			}
			else if(trap == 1)
			{
				double b1 = 0;
				double b2 = 0;
				double h = 0;
				double area = 0;
				// area = 1/2(base1 + base2) X height
				//add parsing
				b1 = Double.Parse(input1.Text);
				b2 = Double.Parse(input2.Text);
				h = Double.Parse(input3.Text);
				area = 1 / 2 * (b1 * b2) * h;
				//add output
				typeCalc.Text = "Area:";
				output.Text = Convert.ToString(area);
				input1.Clear();
				input2.Clear();
				input3.Clear();
			}
			else if(tri == 1)
			{
				int b = 0;
				int h = 0;
				int area = 0;
				//1/2(base X height)
				//add parseing
				b = Int32.Parse(input1.Text);
				h = Int32.Parse(input2.Text);
				area = 1/2*(b * h);
				
				typeCalc.Text = "Area:";
				output.Text = Convert.ToString(area);
				input1.Clear();
				input2.Clear();
				input3.Clear();
			}
			else if(rec == 1)
			{
				int b = 0;
				int h = 0;
				int area = 0;
				b = Int32.Parse(input1.Text);
				h = Int32.Parse(input2.Text);
				area = b * h;
				output.Show();
				output.Text = Convert.ToString(area);
				typeCalc.Text = "Area:";
				input1.Clear();
				input2.Clear();
				input3.Clear();
			}
		}
	}
}
