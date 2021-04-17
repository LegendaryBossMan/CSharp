using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naz_QuickQuiz_Try2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double radius = 0;
			double diameter = 0;
			double area = 0;

			radius = Double.Parse(inputBx.Text);
			diameter = radius * radius;
			area = 3.14 * (radius * radius);
			//Convert.ToString(diameter);
			//Convert.ToString(area);
			//keeps getting errors after this point.
			label2.Text = "";
			label3.Text = "";
			label2.Text = Convert.ToString(diameter);
			label3.Text = Convert.ToString(area);


		}
	}
}
