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
    public partial class WaysPlay : Form
    {
        public WaysPlay()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            //Open MTGPlayer tab
            Intermediate Intermediate = new Intermediate();
            Intermediate.Show();

            this.Hide();
        }
    }
}
