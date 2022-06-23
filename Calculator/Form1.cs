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
        public static Calculator Instance { get; set; }

        public Calculator()
        {
            InitializeComponent();
            btn_clear.Click += new System.EventHandler(buttonHandler.btn_clear_Click);
            btn_0.Click += new System.EventHandler(buttonHandler.btn_0_Click);
            btn_1.Click += new System.EventHandler(buttonHandler.btn_1_Click);
            btn_2.Click += new System.EventHandler(buttonHandler.btn_2_Click);
            btn_3.Click += new System.EventHandler(buttonHandler.btn_3_Click);
            btn_4.Click += new System.EventHandler(buttonHandler.btn_4_Click);
            btn_5.Click += new System.EventHandler(buttonHandler.btn_5_Click);
            btn_6.Click += new System.EventHandler(buttonHandler.btn_6_Click);
            btn_7.Click += new System.EventHandler(buttonHandler.btn_7_Click);
            btn_8.Click += new System.EventHandler(buttonHandler.btn_8_Click);
            btn_9.Click += new System.EventHandler(buttonHandler.btn_9_Click);
            btn_add.Click += new System.EventHandler(buttonHandler.btn_add_Click);
            btn_sub.Click += new System.EventHandler(buttonHandler.btn_sub_Click);
            btn_div.Click += new System.EventHandler(buttonHandler.btn_div_Click);
            btn_mul.Click += new System.EventHandler(buttonHandler.btn_mul_Click);
            btn_equals.Click += new System.EventHandler(btn_equals_Click);
            Instance = this;
        }

        public void displayNumber(float number) => numberDisplay.Text = number.ToString();

        public void resetDisplay() => numberDisplay.Text = string.Empty;

        private void Quit_Click(object sender, EventArgs e) => Application.Exit();

        private void btn_equals_Click(object sender, EventArgs e)
        {
            displayNumber(numberHandler.computeEquation(numberHandler.firstNumber, numberHandler.op, numberHandler.secondNumber));
        }
    }
}
