using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTGLearning
{
    public partial class Lands : Form
    {
        public Lands()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            //Open beginner tab
            Beginner Beginner = new Beginner();
            Beginner.Show();

            this.Hide();
        }
    }
}
