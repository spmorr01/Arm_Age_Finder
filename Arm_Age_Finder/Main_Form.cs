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
    public partial class Main_Form : Form
    {
        public PitcherForm checkBoxReply { get; set; }
        CheckBox lastChecked;
        public string position;

        //public string checkBoxReply;
        public Main_Form()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pitcher_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;

            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            if (activeCheckBox.Checked == true)
            {
                Variables.age = 0;
                Variables.age += 5;
                PitcherForm PitcherForm = new PitcherForm();
                PitcherForm.Show();
            }
            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;
        }

        private void PP_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            if (activeCheckBox.Checked == true)
            {
                Variables.age = 0;
                Variables.age -= 1;
                PositionPlayerForm PPForm = new PositionPlayerForm();
                PPForm.Show();
            }
            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;
        }

        private void Dual_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            if (activeCheckBox.Checked == true)
            {
                Variables.age = 0;
                Variables.age += 6;
                DualPlayerForm DualPlayerForm = new DualPlayerForm();
                DualPlayerForm.Show();
            }
            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void questionLabel_Click(object sender, EventArgs e)
        {

        }
    }
  }

