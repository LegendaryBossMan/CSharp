using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBishop_Assignment_BasicGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void AddBtn_Click(object sender, EventArgs e)
		{
			int total;
			total = Int32.Parse(FirstNum.Text) + Int32.Parse(SecondNum.Text);
			ResultLbl.Text = total.ToString();
		}

		private void SubBtn_Click(object sender, EventArgs e)
		{
			int total;
			total = Int32.Parse(FirstNum.Text) - Int32.Parse(SecondNum.Text);
			ResultLbl.Text = total.ToString();
		}

		private void MultBtn_Click(object sender, EventArgs e)
		{
			int total;
			total = Int32.Parse(FirstNum.Text) * Int32.Parse(SecondNum.Text);
			ResultLbl.Text = total.ToString();
		}

		private void DivBtn_Click(object sender, EventArgs e)
		{
			int total;
			total = Int32.Parse(FirstNum.Text) / Int32.Parse(SecondNum.Text);
			ResultLbl.Text = total.ToString();
		}
	}
}
