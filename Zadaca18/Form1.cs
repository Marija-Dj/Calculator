using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca18
{
    public partial class Form1 : Form
    {
        String operation = "";
        Double Frstenum, Secondnum;
        public Form1()
        {
            InitializeComponent();
        }
        private void NUM(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textBox1.Text == "0") textBox1.Text = "";

            if (b.Text == ".")
            {

                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + b.Text;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + b.Text;

            }

        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void ButtonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";

            String f, s;
            f = Convert.ToString(Frstenum);
           s = Convert.ToString(Secondnum);
            f = "";
            s = "";
        }
        //Definirajne na operacii
        private void Operation(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Frstenum = Double.Parse(textBox1.Text);
            operation = b.Text;
            textBox1.Text = "";
        }
        //Brisi se
        private void ButtonDELL_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        //Ednakvo
        private void ButtonE_Click(object sender, EventArgs e)
        {
            Secondnum = double.Parse(textBox1.Text);
            switch (operation)
            {
                case "+":
                    textBox1.Text = Convert.ToString(Frstenum + Secondnum);
                    break;
                case "-":
                    textBox1.Text = Convert.ToString(Frstenum - Secondnum);
                    break;
                case "*":
                    textBox1.Text = Convert.ToString(Frstenum * Secondnum);
                    break;
                case "/":
                    textBox1.Text = Convert.ToString(Frstenum / Secondnum);
                    break;
                default:
                    break;

            }
        }
        //Plus i minus
        private void ButtonPiMi_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("-"))
            {
                textBox1.Text = textBox1.Text.Remove(0, 1);
            }
            else
            {
                textBox1.Text = "-" + textBox1.Text;
            }
        }

        


    }
}
