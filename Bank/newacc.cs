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
    public partial class newacc : Form
    {
        DBconnection DB;
        public newacc(DBconnection DB)
        {
            InitializeComponent();
            this.DB = DB;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Namen.Text) && !String.IsNullOrEmpty(pin1.Text) && !String.IsNullOrEmpty(pin2.Text) && pin1.Text == pin2.Text)
            {
               
                daten d = DB.createacc(Namen.Text, pin1.Text);
                maininterface m = new maininterface(d,DB);
                m.Show();
                this.Hide();
            }
        }

        private void rjRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pin1.UseSystemPasswordChar = !pin1.UseSystemPasswordChar;
            pin2.UseSystemPasswordChar = !pin2.UseSystemPasswordChar;
        }

        private void newacc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.closecon();
            Environment.Exit(0);
        }
    }
}
