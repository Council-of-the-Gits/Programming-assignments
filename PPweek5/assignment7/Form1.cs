using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void throwButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = null;
            
            Random random = new Random();

            int randomNumber;

            int counter = 1;

            int[] dice = {0,0,0,0,0,0};



            for (int i = 0; i < 6000; i++)
            {
                randomNumber = random.Next(1, 7);

                switch (randomNumber)
                {
                    case 1:
                        dice[0]++;
                        break;
                    case 2:
                        dice[1]++;
                        break;
                    case 3:
                        dice[2]++;
                        break;
                    case 4:
                        dice[3]++;
                        break;
                    case 5:
                        dice[4]++;
                        break;
                    case 6:
                        dice[5]++;
                        break;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                outputLabel.Text += $"Number of throws of value {counter} = {dice[i]}\n";

                counter++;
            }

        }
    }
}
