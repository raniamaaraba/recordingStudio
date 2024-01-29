/*Project: 3.2 Recording Studio
 * Date: October 2022
 * Programmer: Rania Maaraba
 * Description: Create a prediction module for a recording studio to determine expenses for recording groups.
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace studioTwo
{
    public partial class Form1 : Form
    {
        private int finalTotalInteger;
        private decimal groupFeeDecimal;
        private decimal averageChargeDecimal;
        private const decimal averageDecimal = 0.2m;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Calculate the total per group, average total, and final total.

            groupFeeDecimal = Decimal.Round((3.33 * textBox2_TextChanged),2);
            averageChargeDecimal = Decimal.Round((316.67 * textBox3_TextChanged), 2);
            finalTotalInteger = Decimal.Round((groupFeeDecimal + 333.33))

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printForm1.Print();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the text boxes.

            textBox1.Clear();
            textBox2.Clear();   
            textBox3.Clear();
            groupFeeTextBox.Clear();
            averageChargeTextBox.Clear();
            finalTotalTextBox.Clear();  
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // End the program,

            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupFeeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void averageChargeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void finalTotalTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}