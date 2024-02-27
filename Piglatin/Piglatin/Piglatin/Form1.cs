using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piglatin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string originalWord = textBox1.Text.ToLower(); // Convert the input to lowercase
            string pigLatinWord = PigLatinConverter.ConvertToPigLatin(originalWord);
            label1.Text = pigLatinWord;
        }
    }

    public static class PigLatinConverter
    {
        public static string ConvertToPigLatin(string word)
        {
            if (string.IsNullOrEmpty(word))
                return "Please enter a word.";

            char firstLetter = word[0];
            string restOfWord = word.Substring(1);

            return restOfWord + firstLetter + "ay";
        }
    }
}
