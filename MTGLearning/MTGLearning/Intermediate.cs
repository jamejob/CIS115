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
    public partial class Intermediate : Form
    {
        public Intermediate()
        {
            InitializeComponent();
        }
        private void Home_Click(object sender, EventArgs e)
        {
            MTGLearning MTGLearning = new MTGLearning();
            MTGLearning.Show();

            this.Hide();
        }

        private void Phases_Click(object sender, EventArgs e)
        {
            //Open phases tab
            Phases Phases = new Phases();
            Phases.Show();

            this.Hide();
        }

        private void Stack_Click(object sender, EventArgs e)
        {
            //Open stack tab
            Stack Stack = new Stack();
            Stack.Show();

            this.Hide();
        }

        private void Card_Click(object sender, EventArgs e)
        {
            //Open card types in depth tab
            CardTypes CardTypes = new CardTypes();
            CardTypes.Show();

            this.Hide();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            //Open ways to play tab
            WaysPlay WaysPlay = new WaysPlay();
            WaysPlay.Show();

            this.Hide();
        }

        private void Quiz_Click(object sender, EventArgs e)
        {
            //Open quiz tab
            MTGQuiz MTGQuiz = new MTGQuiz();
            MTGQuiz.Show();

            this.Hide();

        }
    }
}
