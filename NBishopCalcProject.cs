using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{





    public partial class Form1 : Form
    {
        Double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (txt_Results.Text == "0" || isOperationPerformed)
            {
                txt_Results.Clear();
            }


            isOperationPerformed = false;
            //connected with it, sends generic object
            Button button = (Button)sender;
            //no repeat of dots
            if(button.Text == ".")
            {
                if(!txt_Results.Text.Contains("."))
                {
                    txt_Results.Text = txt_Results.Text + button.Text;
                }
            }
            else
            {
                txt_Results.Text = txt_Results.Text + button.Text;
            }

          //  txt_Results.Text = txt_Results.Text + button.Text;


        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(resultValue != 0)
            {
                EqlsBtn.PerformClick();
                operationPerformed = button.Text;
                lbl_CrntOp.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(txt_Results.Text);

                isOperationPerformed = true;
                lbl_CrntOp.Text = resultValue + " " + operationPerformed;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_Results.Text = "0";
     
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_Results.Text = "0";
            resultValue = 0;
           // lbl_CrntOp.Text = " ";
        }

        private void EqlsBtn_Click(object sender, EventArgs e)
        {
            //switches
            switch(operationPerformed)
            {
                case "+":
                    txt_Results.Text = (resultValue + double.Parse(txt_Results.Text)).ToString();
                    break;
                case "-":
                    txt_Results.Text = (resultValue - double.Parse(txt_Results.Text)).ToString();
                    break;
                case "*":
                    txt_Results.Text = (resultValue * double.Parse(txt_Results.Text)).ToString();
                    break;
                case "/":
                    txt_Results.Text = (resultValue / double.Parse(txt_Results.Text)).ToString();
                    break;
                default:
                    break;
            }//end switch

            resultValue = Double.Parse(txt_Results.Text);
            lbl_CrntOp.Text = " ";
        }
    }
}
