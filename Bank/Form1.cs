using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(rjTextBox1.Texts) && !String.IsNullOrEmpty(rjTextBox2.Texts))
            {

            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

        }

        private void rjRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rjTextBox2.PasswordChar = !rjTextBox2.PasswordChar;
        }
    }
}
