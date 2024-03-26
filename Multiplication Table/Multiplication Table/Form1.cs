namespace Multiplication_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the input is a valid integer
            if (int.TryParse(textBox1.Text, out int inputValue))
            {
                // Clear previous results
                listBox1.Items.Clear();

                // Display the multiplication table
                for (int i = 1; i <= 10; i++)
                {
                    int result = i * inputValue;
                    listBox1.Items.Add($"{i} * {inputValue} = {result}");
                }
            }
            else
            {
                // Display an error message if the input is not a valid integer
                MessageBox.Show("Please enter a valid integer number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
