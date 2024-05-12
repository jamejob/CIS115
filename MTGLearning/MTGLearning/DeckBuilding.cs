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
    public partial class DeckBuilding : Form
    {
        public DeckBuilding()
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
