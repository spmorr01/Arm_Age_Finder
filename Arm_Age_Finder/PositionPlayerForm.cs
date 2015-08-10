using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arm_Age_Finder
{
    public partial class PositionPlayerForm : Form
    {
        public PositionPlayerForm()
        {
            InitializeComponent();
        }

        private void PP_CalculateButton_Click(object sender, EventArgs e)
        {
            bool check;
            int falseChecks = 0;
            int Question1Answer;
            int Question2Answer;
            int Question3Answer;
            int Question4Answer;
            int Question5Answer;
            int Question6Answer;
            String Question7Answer;
            int Question8Answer;

            Variables.age -= 5;

            check = int.TryParse(PP_Question1TextBox.Text, out Question1Answer);
            if (check == true)
            {
                Variables.age += Question1Answer;
            }
            else if (check == false)
            {
                falseChecks++;
                MessageBox.Show("Please enter a valid numeric value on question 1.");
            }

            check = int.TryParse(PP_Question2TextBox.Text, out Question2Answer);
            if (check == true)
            {

                if (Question2Answer == 2)
                {
                    Variables.age += 2;
                }
                else if (Question2Answer == 3)
                {
                    Variables.age += 0;
                }
                else if (Question2Answer == 4)
                {
                    Variables.age += 0;
                }
                else if (Question2Answer == 5)
                {
                    Variables.age += 1;
                }
                else if (Question2Answer == 6)
                {
                    Variables.age += 1;
                }
                else if (Question2Answer == 7 || Question2Answer == 8)
                {
                    Variables.age += 1;
                }
                else if (Question2Answer == 9)
                {
                    Variables.age += 2;
                }
                else
                {
                    falseChecks++;
                    MessageBox.Show("Please enter a valid position number on question 2.");
                }
            }
            else if (check == false)
            {
                falseChecks++;
                MessageBox.Show("Please enter a valid numeric value on question 2.");
            }


        }
    }
}
