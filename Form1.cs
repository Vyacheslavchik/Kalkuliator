using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (panTable.Text.Equals("0")) panTable.Text = "";
            panTable.Text += "2";
        }

        private void treeButton_Click(object sender, EventArgs e)
        {
            if (panTable.Text.Equals("0")) panTable.Text = "";
            panTable.Text += "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (panTable.Text.Equals("0")) panTable.Text = "";
            panTable.Text += "4";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (panTable.Text.Equals("0")) panTable.Text = "";
            panTable.Text += "5";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (panTable.Text.Equals("0")) panTable.Text = "";
            panTable.Text += "6";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (panTable.Text.Equals("0")) panTable.Text = "";
            panTable.Text += "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (panTable.Text.Equals("0")) panTable.Text = "";
            panTable.Text += "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (panTable.Text.Equals("0")) panTable.Text = "";
            panTable.Text += "9";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (panTable.Text.Equals("0")) panTable.Text = "";
            panTable.Text += "0";
        }

        private void dekiteAllStringButton_Click(object sender, EventArgs e)
        {
            panTable.Text = "0";
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
    }
}
