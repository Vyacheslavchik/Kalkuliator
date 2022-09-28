using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Kalkuliator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panTable.Text = "0";
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (panTable.Text.Equals("0")) panTable.Text = "";
            panTable.Text += "1";
            label1.Text = "0";
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (panTable.Text.Equals("0")) panTable.Text = "";
            panTable.Text += "2";
            label1.Text = "0";
        }

        private void treeButton_Click(object sender, EventArgs e)
        {
            if (panTable.Text.Equals("0")) panTable.Text = "";
            panTable.Text += "3";
            label1.Text = "0";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (panTable.Text.Equals("0")) panTable.Text = "";
            panTable.Text += "4";
            label1.Text = "0";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (panTable.Text.Equals("0")) panTable.Text = "";
            panTable.Text += "5";
            label1.Text = "0";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (panTable.Text.Equals("0")) panTable.Text = "";
            panTable.Text += "6";
            label1.Text = "0";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (panTable.Text.Equals("0")) panTable.Text = "";
            panTable.Text += "7";
            label1.Text = "0";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (panTable.Text.Equals("0")) panTable.Text = "";
            panTable.Text += "8";
            label1.Text = "0";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (panTable.Text.Equals("0")) panTable.Text = "";
            panTable.Text += "9";
            label1.Text = "0";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (panTable.Text.Equals("0")) panTable.Text = "";
            panTable.Text += "0";
            label1.Text = "0";
            label1.Text = "0";
        }

        private void dekiteAllStringButton_Click(object sender, EventArgs e)
        {
            panTable.Text = "0";
            label1.Text = "0";
        }

        private void dekButton_Click(object sender, EventArgs e)
        {
            panTable.Text = panTable.Text.Remove(panTable.Text.Length - 1);
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            panTable.Text += " + ";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            panTable.Text += " - ";
        }

        private void umnogButton_Click(object sender, EventArgs e)
        {
            panTable.Text += " * ";
        }

        private void delitButton_Click(object sender, EventArgs e)
        {
            panTable.Text += " / ";
        }

        private void panTable_Click(object sender, EventArgs e)
        {

        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            string line = panTable.Text;
            string[] lineArray= line.Split(' ');
            double answer=0;
            for(int i = 0; i < lineArray.Length; i++)
            {
                switch (lineArray[i])
                {
                    case "+":
                        answer += Int32.Parse(lineArray[i+1]);
                        i++;
                        break;
                    case "-":
                        answer -= Int32.Parse(lineArray[i + 1]);
                        i++;
                        break;
                    case "*":
                        answer *= Int32.Parse(lineArray[i + 1]);
                        i++;
                        break;
                    case "/":
                        answer /= Int32.Parse(lineArray[i + 1]);
                        i++;
                        break;
                    default:
                        answer = Int32.Parse(lineArray[i]);
                        break;
                }
            }
            label1.Text = answer.ToString();

        }
    }
}
