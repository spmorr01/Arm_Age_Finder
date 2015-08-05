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
            label1.Text = stringAge;
        }
    }
}
