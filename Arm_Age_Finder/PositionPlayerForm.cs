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
            String Question6Answer;
            int Question7Answer;

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
                if (Question2Answer == 1)
                {
                    falseChecks++;
                    MessageBox.Show("If you are a pitcher, exit out and try the pitcher's portion of this program.");
                }

                else if (Question2Answer == 2)
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

            check = int.TryParse(PP_Question3TextBox.Text, out Question3Answer);
            if (check == true)
            {
                if (Question3Answer == 0)
                {
                    Variables.age += 0;
                }
                else if (Question3Answer > 0 && Question3Answer < 5)
                {
                    Variables.age++;
                }
                else if (Question3Answer >= 5 && Question3Answer < 10)
                {
                    Variables.age += 2;
                }
                else if (Question3Answer >= 10 && Question3Answer < 15)
                {
                    Variables.age += 3;
                }
                else if (Question3Answer >= 15 && Question3Answer < 20)
                {
                    Variables.age += 4;
                }
                else if (Question3Answer >= 20 && Question3Answer < 25)
                {
                    Variables.age += 5;
                }
                else
                {
                    Variables.age += 6;
                }
            }

            else if (check == false)
            {
                falseChecks++;
                MessageBox.Show("Please enter a valid numeric value on question 3.");
            }

            check = int.TryParse(PP_Question4TextBox.Text, out Question4Answer);
            if (check == true)
            {
                if (Question4Answer == 0)
                {
                    Variables.age += 0;
                }
                else if (Question4Answer >= 0 && Question4Answer <= 4)
                {
                    Variables.age += 1;
                }
                else if (Question4Answer >= 5 && Question4Answer <= 9)
                {
                    Variables.age += 2;
                }
                else if (Question4Answer >= 10 && Question4Answer <= 14)
                {
                    Variables.age += 3;
                }
                else if (Question4Answer >= 15)
                {
                    Variables.age += 4;
                }
            }

            else if (check == false)
            {
                falseChecks++;
                MessageBox.Show("Please enter a valid numeric value on question 4.");
            }

            check = int.TryParse(PP_Question5TextBox.Text, out Question5Answer);
            if (check == true)
            {
                if (Question5Answer == 0)
                {
                    Variables.age += 0;
                }
                else if (Question5Answer >= 1 && Question5Answer <= 3)
                {
                    Variables.age += 1;
                }
                else if (Question5Answer == 4 || Question5Answer == 5)
                {
                    Variables.age += 1;
                }
                else if (Question5Answer == 6)
                {
                    Variables.age += 2;
                }
                else if (Question5Answer == 7)
                {
                    Variables.age += 3;
                }
                else if (Question5Answer > 7)
                {
                    falseChecks++;
                    MessageBox.Show("Please enter a valid number for days on question 5.");
                }
            }
            else if (check == false)
            {
                falseChecks++;
                MessageBox.Show("Please enter a valid numeric value on question 5.");
            }

            Question6Answer = PP_Question6TextBox.Text;
                if (Question6Answer == "No" || Question6Answer == "no" || Question6Answer == "NO" || Question6Answer == "nO")
                {
                    Variables.age += 0;
                }
                else if (Question6Answer == "Yes" || Question6Answer == "yes" || Question6Answer == "YES" || Question6Answer == "yEs" || Question6Answer == "yeS" || Question6Answer == "yES" || Question6Answer == "YEs")
                {
                    Variables.age += 2;
                }
                else
                {
                    falseChecks++;
                    MessageBox.Show("Please format your entry like the example in question 6");
                }

            check = int.TryParse(PP_Question7TextBox.Text, out Question7Answer);
            if (check == true)
            {
                if (Question7Answer == 0)
                {
                    Variables.age += 0;
                }
                else if (Question7Answer == 1)
                {
                    Variables.age += 5;
                }
                else if (Question7Answer == 2)
                {
                    Variables.age += 10;
                }
                else if (Question7Answer > 2)
                {
                    Variables.age += 15;
                }
            }
            else if (check == false)
            {
                falseChecks++;
                MessageBox.Show("Please enter a valid numeric value on question 7.");
            }

            if (falseChecks == 0)
            {
                ResultsForm ResultsForm = new ResultsForm();
                ResultsForm.Show();
                this.Hide();
            }
            else if (falseChecks > 0)
            {
                Variables.age = 0;
            }
        }
    }
}
