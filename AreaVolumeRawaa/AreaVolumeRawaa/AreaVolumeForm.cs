/*
 * Created by: Rawaa Al Ghanai
 * Created on: March 24, 2020
 * Created for: ICS3U Programming
 * Assignment #4b - Area and Volume
 * This program allows the user to choose which shape they want and 
 * calculate the volume or area for the chosen shape.
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

namespace AreaVolumeRawaa
{
    public partial class frmAreaVolume : Form
    {
        public frmAreaVolume()
        {
            InitializeComponent();
        }

        private void frmAreaVolume_Load(object sender, EventArgs e)
        {
            // hide the labels and textboxes for trapezoid
            this.lblLengthA.Hide();
            this.lblHeightTrapezoid.Hide();
            this.lblArea.Hide();
            this.lblAreaAnswer.Hide();
            this.txtHeigthTrapezoid.Hide();
            this.txtLengthA.Hide();
            this.lblLengthB.Hide();
            this.txtLengthB.Hide();

            // hide the calculate button
            this.btnCalculate.Hide();

            // hide the labels and textboxes for sphere
            this.lblRadiusSphere.Hide();
            this.lblVolumeSphere.Hide();
            this.lblVolume.Hide();
            this.txtRadiusSphere.Hide();

            // hide the labels and textboxes for cylinder
            this.lblVolumeCylinder.Hide();
            this.lblHeightCylinder.Hide();
            this.lblRadiusCylinder.Hide();
            this.txtRadiusCylinder.Hide();
            this.txtHeightCylinder.Hide();
            this.lblVolumeC.Hide();


        }

        private void mniTrapezoid_Click(object sender, EventArgs e)
        {
            // show the labels and textboxes for trapezoid
            this.lblLengthA.Show();
            this.lblHeightTrapezoid.Show();
            this.lblArea.Show();
            this.txtHeigthTrapezoid.Show();
            this.txtLengthA.Show();
            this.lblLengthB.Show();
            this.txtLengthB.Show();

            // show the calculate button
            this.btnCalculate.Show();

            // hide the labels and textboxes for sphere
            this.lblRadiusSphere.Hide();
            this.lblVolumeSphere.Hide();
            this.lblVolume.Hide();
            this.txtRadiusSphere.Hide();

            // hide the labels and textboxes for cylinder
            this.lblVolumeCylinder.Hide();
            this.lblHeightCylinder.Hide();
            this.lblRadiusCylinder.Hide();
            this.txtRadiusCylinder.Hide();
            this.txtHeightCylinder.Hide();
            this.lblVolumeC.Hide();

        }

        private void mniSphere_Click(object sender, EventArgs e)
        {
            // show the labels and textboxes for sphere
            this.lblRadiusSphere.Show();
            this.lblVolume.Show();
            this.txtRadiusSphere.Show();

            // show the calculate button
            this.btnCalculate.Show();

            // hide the labels and textboxes for trapezoid
            this.lblLengthA.Hide();
            this.lblHeightTrapezoid.Hide();
            this.lblArea.Hide();
            this.lblAreaAnswer.Hide();
            this.txtHeigthTrapezoid.Hide();
            this.txtLengthA.Hide();
            this.lblLengthB.Hide();
            this.txtLengthB.Hide();

            // hide the labels and textboxes for cylinder
            this.lblVolumeCylinder.Hide();
            this.lblHeightCylinder.Hide();
            this.lblRadiusCylinder.Hide();
            this.txtRadiusCylinder.Hide();
            this.txtHeightCylinder.Hide();
            this.lblVolumeC.Hide();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            // close the program
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mniCylinder_Click(object sender, EventArgs e)
        {
            // show the labels and textboxes for cylinder
            this.lblHeightCylinder.Show();
            this.lblRadiusCylinder.Show();
            this.txtRadiusCylinder.Show();
            this.txtHeightCylinder.Show();
            this.lblVolumeC.Show();

            // show the calculate button
            this.btnCalculate.Show();

            // hide the labels and textboxes for trapezoid
            this.lblLengthA.Hide();
            this.lblHeightTrapezoid.Hide();
            this.lblArea.Hide();
            this.lblAreaAnswer.Hide();
            this.txtHeigthTrapezoid.Hide();
            this.txtLengthA.Hide();
            this.lblLengthB.Hide();
            this.txtLengthB.Hide();

            // hide the labels and textboxes for sphere
            this.lblRadiusSphere.Hide();
            this.lblVolumeSphere.Hide();
            this.lblVolume.Hide();
            this.txtRadiusSphere.Hide();


        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // local variables for trapezoid
            double lengthA, lengthB, height, area;

            // convert the string from each textbox to a double
            lengthA = double.Parse(txtLengthA.Text);
            lengthB = double.Parse(txtLengthB.Text);
            height = double.Parse(txtHeigthTrapezoid.Text);

            // Calculate the area of the trapezoid 
            area = 1 / 2 * (lengthA + lengthB) * height;

            // insert the area into its label 
            this.lblAreaAnswer.Text = Convert.ToString(area) + "m^2";

            // show the answer label
            this.lblAreaAnswer.Show();

            // local variables for sphere
            double radiusS, volumeS;

            // convert the string from the textbox to a double 
            radiusS = double.Parse(txtRadiusSphere.Text);

            // calculate the volume of the sphere
            volumeS = 4 / 3 * Math.PI * Math.Pow(radiusS, 3);

            // insert the volume into its label
            this.lblVolumeSphere.Text = Convert.ToString(volumeS) + "m^3";

            // show the answer label
            this.lblVolumeSphere.Show();

            // local variables for cylinder 
            double radiusC, heightC, volumeC;

            // convert the string from each textbox to a double
            radiusC = double.Parse(txtRadiusCylinder.Text);
            heightC = double.Parse(txtHeightCylinder.Text);

            // calculate the volume of the cylinder 
            volumeC = Math.PI * Math.Pow(radiusC, 2) * heightC;

            // insert volume into its label 
            this.lblVolumeCylinder.Text = Convert.ToString(volumeC) + "m^3";

            // show the answer label
            this.lblVolumeCylinder.Show();



        }
    }
}
