﻿using System;
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
    public partial class Form1 : Form
    {
        int Accu = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private double Result(string expression) {
            System.Data.DataTable table = new DataTable();
            return Convert.ToDouble(table.Compute(expression, String.Empty));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_accu.Text.Trim() == "0") txt_accu.Text="";
            txt_accu.Text = txt_accu.Text.Trim() + "1";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_accu.Text = Accu.ToString();

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Accu = 0;
            txt_accu.Text = Accu.ToString();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (txt_accu.Text.Trim() == "0") return;
            txt_accu.Text = txt_accu.Text.Trim() + "0";
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (txt_accu.Text.Trim() == "0") txt_accu.Text = "";
            txt_accu.Text = txt_accu.Text.Trim() + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (txt_accu.Text.Trim() == "0") txt_accu.Text = "";
            txt_accu.Text = txt_accu.Text.Trim() + "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (txt_accu.Text.Trim() == "0") txt_accu.Text = "";
            txt_accu.Text = txt_accu.Text.Trim() + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (txt_accu.Text.Trim() == "0") txt_accu.Text = "";
            txt_accu.Text = txt_accu.Text.Trim() + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (txt_accu.Text.Trim() == "0") txt_accu.Text = "";
            txt_accu.Text = txt_accu.Text.Trim() + "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (txt_accu.Text.Trim() == "0") txt_accu.Text = "";
            txt_accu.Text = txt_accu.Text.Trim() + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (txt_accu.Text.Trim() == "0") txt_accu.Text = "";
            txt_accu.Text = txt_accu.Text.Trim() + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (txt_accu.Text.Trim() == "0") txt_accu.Text = "";
            txt_accu.Text = txt_accu.Text.Trim() + "9";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            txt_accu.Text = txt_accu.Text.Trim() + "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            txt_accu.Text = txt_accu.Text.Trim() + "-";
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            txt_accu.Text = txt_accu.Text.Trim() + "*";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            txt_accu.Text = txt_accu.Text.Trim() + "/";
        }

        private void result_Click(object sender, EventArgs e)
        {
            txt_accu.Text = Result(txt_accu.Text.Trim()).ToString();
        }
    }
}
