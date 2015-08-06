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
    public partial class PitcherForm : Form
    {
        public PitcherForm()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void CalculateButton_Click(object sender, EventArgs e)
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

            Variables.age += 5;

            check = int.TryParse(Question1TextBox.Text, out Question1Answer);
            if (check == true)
            {
                Variables.age += Question1Answer;
            }
            else if (check == false)
            {
                falseChecks++;
                MessageBox.Show("Please enter a valid numeric value on question 1.");     
            }

            check = int.TryParse(Question2TextBox.Text, out Question2Answer);
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

            check = int.TryParse(Question3TextBox.Text, out Question3Answer);
            if (check == true)
            {
                if (Question3Answer == 0)
                {
                    Variables.age += 0;
                }
                else if (Question3Answer >=1 && Question3Answer < 70)
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

            check = int.TryParse(Question4TextBox.Text, out Question4Answer);
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
            }
            else if (check == false)
            {
                falseChecks++;
                MessageBox.Show("Please enter a valid numeric value on question 4.");
            }

            check = int.TryParse(Question5TextBox.Text, out Question5Answer);
            if (check == true)
            {
                if (Question5Answer == 0)
                {
                    Variables.age += 0;
                }
                else if (Question5Answer >= 1  && Question5Answer <= 3)
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
            }
            else if (check == false)
            {
                falseChecks++;
                MessageBox.Show("Please enter a valid numeric value on question 5.");
            }

            check = int.TryParse(Question6TextBox.Text, out Question6Answer);
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

            Question7Answer = Question7TextBox.Text;
                if (Question7Answer == "No" || Question7Answer == "no" || Question7Answer == "NO")
                {
                    Variables.age += 0;
                }
                else if (Question7Answer == "Yes" || Question7Answer == "yes" || Question7Answer == "YES")
                {
                    Variables.age += 2;
                }
                else
                {
                    falseChecks++;
                    MessageBox.Show("Please format your entry like the example in question 7");
                }

            check = int.TryParse(Question8TextBox.Text, out Question8Answer);
            if (check == true)
            {
                if (Question8Answer == 0)
                {
                    Variables.age += 0;
                }
                else if (Question8Answer == 1)
                {
                    Variables.age += 5;
                }
                else if (Question8Answer == 2)
                {
                    Variables.age += 10;
                }
                else if (Question8Answer > 2)
                {
                    Variables.age += 15;
                }
            }
            else if (check == false)
            {
                falseChecks++;
                MessageBox.Show("Please enter a valid numeric value on question 8.");
            }
            if (falseChecks == 0)
            {
                ResultsForm ResultsForm = new ResultsForm();
                ResultsForm.Show();
                this.Close();
            }
            else if (falseChecks > 0)
            {
                Variables.age = 0;
            }
        }

        
    }
}