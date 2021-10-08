using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] randomNumberArray = new double[20];

        private void compareButton_Click(object sender, EventArgs e)
        {
            //Compare the value's from the load event 

            for (int i = 0; i < 20; i++)
            {
                int compareValue = Convert.ToInt32(compareBox.Text);

                double[] randomNumberArrayChanged = new double[20];

                if (randomNumberArray[i] >= compareValue)
                {
                    double increasedNumber = randomNumberArray[i] + 10;
                    randomNumberArrayChanged[i] += increasedNumber;
                    outputAfterLabel.Text += $"Element {i:00} = {increasedNumber}\n";
                }
                else
                {
                    double decreasedNumber = randomNumberArray[i] -5;
                    randomNumberArrayChanged[i] += decreasedNumber;
                    outputAfterLabel.Text += $"Element {i:00} = {decreasedNumber}\n";
                }

                compareButton.Enabled = false;
                
            }
        }

        private void  Form1_Load(object sender, EventArgs e)
        {
            beforeLabel.Font = new Font(beforeLabel.Font, FontStyle.Bold);

            afterLabel.Font = new Font(afterLabel.Font, FontStyle.Bold);

            Random random = new Random();

            double randomNumber;

            for (int i = 0; i < 20; i++)
            {
                randomNumber = random.Next(0, 500);

                randomNumberArray[i] += randomNumber;

                OutputBeforeLabel.Text += $"Element {i:00} = {randomNumber}\n";
            }
        }
    }
}
