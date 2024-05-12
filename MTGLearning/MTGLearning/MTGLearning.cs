namespace MTGLearning
{
    public partial class MTGLearning : Form
    {
        public MTGLearning()
        {
            InitializeComponent();
        }
        private void Intro_Click(object sender, EventArgs e)
        {
            //Open intro tab
            Introduction Introduction = new Introduction();
            Introduction.Show();

            this.Hide();
        }
        private void Begin_Click(object sender, EventArgs e)
        {
            //Open beginner tab
            Beginner Beginner = new Beginner();
            Beginner.Show();

            this.Hide();
        }
        private void Inter_Click(object sender, EventArgs e)
        {
            //Open MTGPlayer tab
            Intermediate Intermediate = new Intermediate();
            Intermediate.Show();

            this.Hide();
        }

      
    }
}
