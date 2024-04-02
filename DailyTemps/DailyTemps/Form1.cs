namespace DailyTemps
{
    public partial class Form1 : Form
    {
        private const int MAX_TEMPERATURES = 7;
        private int[] temperatures = new int[MAX_TEMPERATURES];
        private int count = 0;
        private int total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count < MAX_TEMPERATURES)
            {
                if (int.TryParse(textBox1.Text, out int temp) && temp >= -20 && temp <= 130)
                {
                    temperatures[count] = temp;
                    total += temp;
                    count++;
                    textBox1.Clear();
                    if (count == MAX_TEMPERATURES)
                    {
                        button1.Enabled = false;
                        int average = total / MAX_TEMPERATURES;
                        label1.Text = $"Temperatures entered: {string.Join(", ", temperatures)}\nAverage temperature: {average}°F";
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid temperature between -20°F and 130°F.", "Invalid Temperature", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            count = 0;
            total = 0;
            Array.Clear(temperatures, 0, temperatures.Length);
            textBox1.Clear();
            button1.Enabled = true;
            label1.Text = "";
        }
    }
}
