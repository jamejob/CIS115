namespace PaintingEstimate
{
    public partial class PaintingEstimate : Form
    {
        public PaintingEstimate()
        {
            InitializeComponent();
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Parse length and width inputs
            if (double.TryParse(lengthTextBox.Text, out double length) &&
                double.TryParse(widthTextBox.Text, out double width))
            {
                double totalArea = 2 * (length + width) * 9;

                double cost = totalArea * 6;

                MessageBox.Show($"The estimated cost of painting the room is: ${cost}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                lengthTextBox.Clear();
                widthTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter valid values for length and width.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                lengthTextBox.Clear();
                widthTextBox.Clear();
            }
        }
    }
}
