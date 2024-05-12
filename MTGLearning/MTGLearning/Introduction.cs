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
    public partial class Introduction : Form
    {
        public Introduction()
        {
            InitializeComponent();
        }
        private void Home_Click(object sender, EventArgs e)
        {
            MTGLearning MTGLearning = new MTGLearning();
            MTGLearning.Show();

            this.Hide();
        }
    }
}
