using static System.Formats.Asn1.AsnWriter;

namespace TestScoreList
{
    public partial class TestScoreList : Form
    {
        int[] scores = new int[8]; // Array to store test scores
        public TestScoreList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Loop through TextBoxes to read scores and validate input
            for (int i = 0; i < 8; i++)
            {
                if (!int.TryParse(Controls["textBox" + (i + 1)].Text, out scores[i]))
                {
                    MessageBox.Show("Please enter a valid number value for test score");
                    return; // Exit method if input is invalid
                }
            }

            // Calculate average
            double average = scores.Average();

            // Display scores and their deviation from average
            for (int i = 0; i < 8; i++)
            {
                int deviation = scores[i] - (int)average;
                listBox1.Items.Add($"Score {i + 1}: {scores[i]} - Deviation from average: {deviation}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear TextBoxes and ListBox
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                    ((TextBox)control).Clear();
            }
            listBox1.Items.Clear();
        }
    }
}
