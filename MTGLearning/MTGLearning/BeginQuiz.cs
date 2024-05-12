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
    public partial class BeginQuiz : Form
    {
        private int score = 0; // To keep track of the score

        public BeginQuiz()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //Check if question is correct
            if (Correct1.Checked) score++;
            if (Correct2.Checked) score++;
            if (Correct3.Checked) score++;
            if (Correct4.Checked) score++;
            if (Correct5.Checked) score++;
            if (Correct6.Checked) score++;
            if (Correct7.Checked) score++;
            if (Correct8.Checked) score++;
            if (Correct9.Checked) score++;
            if (Correct10.Checked) score++;


            // Display the score
            MessageBox.Show("Your score is: " + score + " / 10", "Quiz Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Open Beginner Tab
            Beginner Beginner = new Beginner();
            Beginner.Show();

            this.Hide();

        }

      
    }
}
