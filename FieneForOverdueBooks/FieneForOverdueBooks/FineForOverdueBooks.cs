namespace FieneForOverdueBooks
{
    public partial class FineForOverdueBooks : Form
    {
        public FineForOverdueBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numBooksCheckedOut) &&
                int.TryParse(textBox2.Text, out int numDaysOverdue))
            {
                double fine = CalculateFine(numBooksCheckedOut, numDaysOverdue);

                label1.Text = $"Library Fine: ${fine:F2}";
            }
            else
            {
                MessageBox.Show("Please enter valid numbers in the required sections.");
            }
        }

        private double CalculateFine(int numBooksCheckedOut, int numDaysOverdue)
        {
            double fine = 0;

            int days = Math.Min(numDaysOverdue, 7);
            fine += days * numBooksCheckedOut * 0.10;

            if (numDaysOverdue > 7)
            {
                fine += (numDaysOverdue - 7) * numBooksCheckedOut * 0.20;
            }

            return fine;
        }

        private void FineForOverdueBooks_Load(object sender, EventArgs e)
        {

        }
    }
}
