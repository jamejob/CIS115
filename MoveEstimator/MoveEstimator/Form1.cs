using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveEstimator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            try
            {
                double hours = double.Parse(textBox1.Text);
                double miles = double.Parse(textBox2.Text);

                double baseRate = 200;
                double ratePerHour = 150;
                double ratePerMile = 2;

                double totalFee = baseRate + (hours * ratePerHour) + (miles * ratePerMile);

                label1.Text = $"For a move taking {hours} hours and going {miles} miles the estimate is ${totalFee:F2}";
            }
            catch (FormatException)
            {
                label1.Text = "Please enter valid numbers for hours and miles.";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                double hours = double.Parse(textBox1.Text);
                double miles = double.Parse(textBox2.Text);

                double baseRate = 200;
                double ratePerHour = 150;
                double ratePerMile = 2;

                double totalFee = baseRate + (hours * ratePerHour) + (miles * ratePerMile);

                label1.Text = $"For a move taking {hours} hours and going {miles} miles the estimate is ${totalFee:F2}";
            }
            catch (FormatException)
            {
                label1.Text = "Please enter valid numbers for hours and miles.";
            }
        }

    }
}
