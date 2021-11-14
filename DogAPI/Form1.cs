using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApiClient;

namespace DogAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> breeds = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            string breedname = textBox1.Text.ToLower();
            if (!breeds.Contains(breedname))
            {
                MessageBox.Show("Incorrect dog ID");
                return;
            }

            label2.Text = textBox1.Text;

            ImageResponse img = ApiHelper.GetBreedImage(breedname);
            pictureBox1.ImageLocation = img.message;                    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImageResponse img = ApiHelper.GetRandomImage();
            pictureBox1.ImageLocation = img.message;
            label2.Text = "";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Response dogs = ApiHelper.GetDogs();  // Is API paima rez dogs variable
            Console.WriteLine(dogs.Message);
            foreach (string dog in dogs.Message.Keys)
            {
                breeds.Add(dog);
                listBox1.Items.Add(char.ToUpper(dog[0]) + dog.Substring(1));
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                textBox1.Text = (listBox1.SelectedItem.ToString());
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            Console.WriteLine(textBox1.Text);
            if (textBox1.Text == "Input dog Id ")
            {
                textBox1.Text = "";
            }
        }
    }
}
