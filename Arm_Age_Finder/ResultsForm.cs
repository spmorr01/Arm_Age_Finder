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
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
            string stringAge = Convert.ToString(Variables.age);
            ageResult.Text = stringAge;
            if (Variables.age <= 30)
            {
                diagnosisResultsString.Text = "Your arm is fine.";
            }
            else if (Variables.age > 30 && Variables.age <= 40)
            {
                diagnosisResultsString.Text = "I bet you're starting to notice the pain.";
            }
            else if (Variables.age > 40 && Variables.age <= 45)
            {
                diagnosisResultsString.Text = "Enjoy the last few years of your arm's life.";
            }
            else if (Variables.age > 45 && Variables.age <= 55)
            {
                diagnosisResultsString.Text = "The end is near...";
            }
            else if (Variables.age > 55 && Variables.age <= 65)
            {
                diagnosisResultsString.Text = "Hang up the cleats and get to a doctor ASAP!";
            }
            else if (Variables.age > 65)
            {
                diagnosisResultsString.Text = "Are you sure your arm is still actually attached to your body?";
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
