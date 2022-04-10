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
        public newacc()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Namen.Texts) && !String.IsNullOrEmpty(pin1.Texts) && !String.IsNullOrEmpty(pin2.Texts) && pin1.Texts == pin2.Texts)
            {
                DBconnection db = new DBconnection();
                db.createacc(Namen.Texts,pin1.Texts);
            }
        }

        private void rjRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pin1.PasswordChar = !pin1.PasswordChar;
            pin2.PasswordChar = !pin2.PasswordChar;
        }
    }
}
