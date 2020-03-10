/*
 * Created by: Rawaa Al Ghanai
 * Created on: Feb. 19 2020
 * Created for: ICS3U Programming
 * Assignment #2 - Name of Program
 * This program assumes a person is on top of a cliff that is 100 m high. 
 * The user enters the number of seconds (representing the number of seconds 
 * since they released the object) and the program calculates how high 
 * the object currently is above ground.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Falling_Objects__Rawaa_
{
    public partial class frmFallingObjects : Form
    {
        public frmFallingObjects()
        {
            InitializeComponent();
        }

        private void LblTime_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double time, answer;
            double height;

            // declare local constants
            const double GRAVITY = 9.81; 

            // parse string from each text box to a double
            time = double.Parse(txtTime.Text);

            // calculate the height
            answer = 100 - 0.5 * 9.81 * Math.Pow(time, 2);
            this.lblAnswer.Show();
            this.lblAnswer.Text = Convert.ToString(answer) + "m";

            // response to nagative numbers
            if (time < 0)
            {
                this.lblAnswer.Text = "Error, please enter positive number";
            }

            // if answer is lower than zero
            if (answer < 0)
            {
                this.lblAnswer.Text = "The object already hit the ground";
            }
        }

        private void FrmFallingObjects_Load(object sender, EventArgs e)
        {
            this.lblAnswer.Hide();
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }
    }
}
