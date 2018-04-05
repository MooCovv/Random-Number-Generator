using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Number_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void populateButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            for (int i = 1; i < 21; i++)
            {
                int number;
                number = rand.Next(99) + 1;
                numberListBox.Items.Add(number);

                if (i == 5)
                {
                    valueBox1.Text = number.ToString();
                }

                if (i == 15)
                {
                    valueBox2.Text = number.ToString();
                }
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int value1 = int.Parse(valueBox1.Text);
            int value2 = int.Parse(valueBox2.Text);

            int outPut = value1 + value2;

            MessageBox.Show(outPut.ToString());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
