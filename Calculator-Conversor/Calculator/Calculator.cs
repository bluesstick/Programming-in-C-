using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double first;
        double second;
        string operation;

            public Calculator()
        {
            InitializeComponent();
        }

        Classes.ClsSum obj = new Classes.ClsSum();
        Classes.ClsMinus obj2 = new Classes.ClsMinus();
        Classes.ClsMultiply obj3 = new Classes.ClsMultiply();
        Classes.ClsDivide obj4 = new Classes.ClsDivide();

        private void btnCero_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "7";
        }

        private void bntEight_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "9";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + ".";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            operation = "+";
            first = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operation = "-";
            first = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operation = "*";
            first = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operation = "/";
            first = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            second = double.Parse(tbxScreen.Text);

            double Su;
            double Mi;
            double Mu;
            double Di;

            switch(operation)
            {
                case "+":
                    Su = obj.Sum((first), (second));
                    tbxScreen.Text = Su.ToString();
                    break;
                case "-":
                    Mi = obj2.Minus((first), (second));
                    tbxScreen.Text = Mi.ToString();
                    break;
                case "*":
                    Mu = obj3.Multiply((first), (second));
                    tbxScreen.Text = Mu.ToString();
                    break;
                case "/":
                    Di = obj4.Divide((first), (second));
                    tbxScreen.Text = Di.ToString();
                    break;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
            result.Clear();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text.Length == 1)
                tbxScreen.Text = "";
            else
                tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from, to;

            from = listBoxFrom.SelectedItem.ToString();
            to = listBoxTo.SelectedItem.ToString();

            if (from == "Kilometres" && to == "Miles")
            {
                result.Text = Convert.ToString(Convert.ToInt32(tbxScreen.Text) * 0.621371);
            }
            if (from == "Miles" && to == "Kilometres")
            {
                result.Text = Convert.ToString(Convert.ToInt32(tbxScreen.Text) * 1.60934);
            }
            if (from == "Kilograms" && to == "Pounds")
            {
                result.Text = Convert.ToString(Convert.ToInt32(tbxScreen.Text) * 2.20462);
            }
            if (from == "Pounds" && to == "Kilograms")
            {
                result.Text = Convert.ToString(Convert.ToInt32(tbxScreen.Text) * 0.453592);
            }
        }       
    }
}
