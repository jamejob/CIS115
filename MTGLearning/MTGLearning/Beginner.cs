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
    public partial class Beginner : Form
    {
        public Beginner()
        {
            InitializeComponent();
        }
        private void Home_Click(object sender, EventArgs e)
        {
            //Open home tab
            MTGLearning MTGLearning = new MTGLearning();
            MTGLearning.Show();

            this.Hide();
        }

        private void Lands_Click(object sender, EventArgs e)
        {
            //Open lands tab
            Lands Lands = new Lands();
            Lands.Show();

            this.Hide();

        }
        private void Basics_Click(object sender, EventArgs e)
        {
            //Open card basics tab
            CardBasics CardBasics = new CardBasics();
            CardBasics.Show();

            this.Hide();
        }
        private void Building_Click(object sender, EventArgs e)
        {
            //Open deck building tab
            DeckBuilding DeckBuilding = new DeckBuilding();
            DeckBuilding.Show();

            this.Hide();
        }
        private void Game_Click(object sender, EventArgs e)
        {
            //Open beginner game tab
            BeginnerGame BeginnerGame = new BeginnerGame();
            BeginnerGame.Show();

            this.Hide();
        }

        private void Quiz_Click(object sender, EventArgs e)
        {
            //Open beginner quiz
            BeginQuiz BeginQuiz = new BeginQuiz();
            BeginQuiz.Show();

            this.Hide();
        }
    }
}
