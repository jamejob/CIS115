namespace DeliveryCharges
{
    public partial class DeliveryCharges : Form
    {
        // Arrays
        private readonly string[] zipCodes = { "28789", "28786", "28788", "28785", "28784", "28783", "28782", "28781", "28780", "28790" };
        private readonly double[] deliveryCharges = { 4.99, 12.99, 1.99, 4.99, 15.99, 10.99, 7.99, 12.99, 13.99, 19.99 };
        public DeliveryCharges()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputZip = textBox1.Text.Trim();
            bool zipFound = false;

            for (int i = 0; i < zipCodes.Length; i++)
            {
                if (zipCodes[i] == inputZip)
                {
                    MessageBox.Show($"Delivery charge to {inputZip} is ${deliveryCharges[i]}", "Delivery Charge", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    zipFound = true;
                    textBox1.Clear();
                    break;
                }
            }

            if (!zipFound)
            {
                MessageBox.Show("The entered zip code is not supported. Please enter a valid zip code.", "Invalid Zip Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
            }
        }
    }
}