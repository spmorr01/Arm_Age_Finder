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
    public partial class DualPlayerForm : Form
    {
        public DualPlayerForm()
        {
            InitializeComponent();
        }

        private void DP_CalculateButton_Click(object sender, EventArgs e)
        {
            bool check;
            int falseChecks = 0;
            int Question1Answer;
            int Question2Answer;
            int Question3Answer;
            int Question4Answer;
            int Question5Answer;
            int Question6Answer;
            int Question7Answer;
            int Question8Answer;
            int Question9Answer;
            int Question10Answer;

            Variables.age += 2;

            check = int.TryParse(DP_Question1TextBox.Text, out Question1Answer);
            if (check == true)
            {
                Variables.age += Question1Answer;
            }
            else if (check == false)
            {
                falseChecks++;
                MessageBox.Show("Please enter a valid numeric value on question 1.");
            }

            check = int.TryParse(DP_Question2TextBox.Text, out Question2Answer);
            if (check == true)
            {

                if (Question2Answer == 0)
                {
                    Variables.age += 0;
                }
                else if (Question2Answer >= 1 && Question2Answer < 5)
                {
                    Variables.age += 1;
                }
                else if (Question2Answer >= 5 && Question2Answer < 10)
                {
                    Variables.age += 2;
                }
                else if (Question2Answer >= 10 && Question2Answer < 15)
                {
                    Variables.age += 4;
                }
                else if (Question2Answer >= 15 && Question2Answer < 20)
                {
                    Variables.age += 8;
                }
                else if (Question2Answer >= 20 && Question2Answer < 25)
                {
                    Variables.age += 12;
                }
                else
                {
                    Variables.age += 16;
                }
            }
            else if (check == false)
            {
                falseChecks++;
                MessageBox.Show("Please enter a valid numeric value on question 2.");
            }

            check = int.TryParse(DP_Question3TextBox.Text, out Question3Answer);
            if (check == true)
            {
                if (Question3Answer == 0)
                {
                    Variables.age += 0;
                }
                else if (Question3Answer >= 1 && Question3Answer < 70)
                {
                    Variables.age += 1;
                }
                else if (Question3Answer >= 70 && Question3Answer < 75)
                {
                    Variables.age += 2;
                }
                else if (Question3Answer >= 75 && Question3Answer < 80)
                {
                    Variables.age += 3;
                }
                else if (Question3Answer >= 80 && Question3Answer < 85)
                {
                    Variables.age += 4;
                }
                else if (Question3Answer >= 85 && Question3Answer < 90)
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

            check = int.TryParse(DP_Question4TextBox.Text, out Question4Answer);
            if (check == true)
            {
                if (Question4Answer == 0)
                {
                    Variables.age += 0;
                }
                else if (Question4Answer >= 1 && Question4Answer <= 3)
                {
                    Variables.age += 1;
                }
                else if (Question4Answer == 4 || Question4Answer == 5)
                {
                    Variables.age += 2;
                }
                else if (Question4Answer == 6)
                {
                    Variables.age += 3;
                }
                else if (Question4Answer == 7)
                {
                    Variables.age += 4;
                }
                else if (Question4Answer > 7)
                {
                    falseChecks++;
                    MessageBox.Show("Please enter a valid number for days on question 4.");
                }
            }
            else if (check == false)
            {
                falseChecks++;
                MessageBox.Show("Please enter a valid numeric value on question 4.");
            }

            check = int.TryParse(DP_Question5TextBox.Text, out Question5Answer);
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
                else if (Question5Answer == 4)
                {
                    Variables.age += 2;
                }
                else if (Question5Answer == 5)
                {
                    Variables.age += 3;
                }
                else if (Question5Answer == 6)
                {
                    Variables.age += 4;
                }
                else if (Question5Answer == 7)
                {
                    Variables.age += 5;
                }
                else if (Question4Answer > 7)
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

            check = int.TryParse(DP_Question6TextBox.Text, out Question6Answer);
            if (check == true)
            {
                if (Question6Answer == 0)
                {
                    Variables.age += 0;
                }
                else if (Question6Answer == 1 || Question6Answer == 2)
                {
                    Variables.age += 1;
                }
                else if (Question6Answer == 3)
                {
                    Variables.age += 2;
                }
                else if (Question6Answer == 4)
                {
                    Variables.age += 3;
                }
                else if (Question6Answer == 5)
                {
                    Variables.age += 4;
                }
                else if (Question6Answer > 5)
                {
                    Variables.age += 5;
                }
            }
            else if (check == false)
            {
                falseChecks++;
                MessageBox.Show("Please enter a valid numeric value on question 6.");
            }

            check = int.TryParse(DP_Question7TextBox.Text, out Question7Answer);
            if (check == true)
            {
                if (Question7Answer == 1)
                {
                    falseChecks++;
                    MessageBox.Show("If you are a pitcher only, exit out and try the pitcher's portion of this program.");
                }

                else if (Question7Answer == 2)
                {
                    Variables.age += 2;
                }
                else if (Question7Answer == 3)
                {
                    Variables.age += 0;
                }
                else if (Question7Answer == 4)
                {
                    Variables.age += 0;
                }
                else if (Question7Answer == 5)
                {
                    Variables.age += 1;
                }
                else if (Question7Answer == 6)
                {
                    Variables.age += 1;
                }
                else if (Question7Answer == 7 || Question7Answer == 8)
                {
                    Variables.age += 1;
                }
                else if (Question7Answer == 9)
                {
                    Variables.age += 2;
                }
                else
                {
                    falseChecks++;
                    MessageBox.Show("Please enter a valid position number on question 7.");
                }
            }
            else if (check == false)
            {
                falseChecks++;
                MessageBox.Show("Please enter a valid numeric value on question 7.");
            }

            check = int.TryParse(DP_Question8TextBox.Text, out Question8Answer);
            if (check == true)
            {
                if (Question8Answer == 0)
                {
                    Variables.age += 0;
                }
                else if (Question8Answer > 0 && Question8Answer < 5)
                {
                    Variables.age++;
                }
                else if (Question8Answer >= 5 && Question8Answer < 10)
                {
                    Variables.age += 2;
                }
                else if (Question8Answer >= 10 && Question8Answer < 15)
                {
                    Variables.age += 3;
                }
                else if (Question8Answer >= 15 && Question8Answer < 20)
                {
                    Variables.age += 4;
                }
                else if (Question8Answer >= 20 && Question8Answer < 25)
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
                MessageBox.Show("Please enter a valid numeric value on question 8.");
            }

            check = int.TryParse(DP_Question9TextBox.Text, out Question9Answer);
            if (check == true)
            {
                if (Question9Answer == 0)
                {
                    Variables.age += 0;
                }
                else if (Question9Answer >= 0 && Question9Answer <= 4)
                {
                    Variables.age += 1;
                }
                else if (Question9Answer >= 5 && Question9Answer <= 9)
                {
                    Variables.age += 2;
                }
                else if (Question9Answer >= 10 && Question9Answer <= 14)
                {
                    Variables.age += 3;
                }
                else if (Question9Answer >= 15)
                {
                    Variables.age += 4;
                }
            }

            else if (check == false)
            {
                falseChecks++;
                MessageBox.Show("Please enter a valid numeric value on question 9.");
            }

            check = int.TryParse(DP_Question10TextBox.Text, out Question10Answer);
            if (check == true)
            {
                if (Question10Answer == 0)
                {
                    Variables.age += 0;
                }
                else if (Question10Answer == 1)
                {
                    Variables.age += 5;
                }
                else if (Question10Answer == 2)
                {
                    Variables.age += 10;
                }
                else if (Question10Answer > 2)
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
