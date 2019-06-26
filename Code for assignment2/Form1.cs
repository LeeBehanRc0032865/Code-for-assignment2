using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_for_assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        // calculates the total resistance in series
            double R1, R2, R3, R4, R5;
            try
            {
                R1 = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                R1 = 0;
            }
            try
            {
                R2 = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                R2 = 0;
            }
            try
            {
                R3 = Convert.ToDouble(textBox4.Text);
            }
            catch
            {
                R3 = 0;
            }
            try
            {
                R4 = Convert.ToDouble(textBox6.Text);
            }
            catch
            {
                R4 = 0;
            }
            try
            {
                R5 = Convert.ToDouble(textBox5.Text);
            }
            catch
            {
                R5 = 0;
            }

            double Rt = R1 + R2 + R3 + R4 + R5;

            label7.Text = "Total series = " + Rt;

// calculates the total resistance in parallel
            if (R1 == 0)
                R1 = double.PositiveInfinity;
            if (R2 == 0)
                R2 = double.PositiveInfinity;
            if (R3 == 0)
                R3 = double.PositiveInfinity;
            if (R4 == 0)
                R4 = double.PositiveInfinity;
            if (R5 == 0)
                R5 = double.PositiveInfinity;

            Rt = 1.0 / (1.0 / R1 + 1.0 / R2 + 1.0 / R3 + 1.0 / R4 + 1.0 / R5);

            label6.Text = "Total parallel = " + Rt; 
        }
    }
}
