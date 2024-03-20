using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hurricane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int windSpeed;
            if (int.TryParse(textBox1.Text, out windSpeed))
            {
                if (windSpeed >= 157)
                    label1.Text = "Category 5 Hurricane";
                else if (windSpeed >= 130)
                    label1.Text = "Category 4 Hurricane";
                else if (windSpeed >= 111)
                    label1.Text = "Category 3 Hurricane";
                else if (windSpeed >= 96)
                    label1.Text = "Category 2 Hurricane";
                else if (windSpeed >= 74)
                    label1.Text = "Category 1 Hurricane";
                else
                    label1.Text = "Not a hurricane";
            }
            else
            {
                MessageBox.Show("Please enter a wind speed using numbers.");
            }
        }
    }
}
