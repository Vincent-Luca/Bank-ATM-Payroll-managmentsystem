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
        DBconnection DB;
        public Form1()
        {
            InitializeComponent();
            DB = new DBconnection();
            DB.connection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
            {
                if(DB.login(textBox1.Text, DB.encrypt(textBox2.Text)))
                {
                    maininterface m = new maininterface(DB.dateneinfügen(textBox1.Text, DB.encrypt(textBox2.Text)),DB);
                    m.Show();
                    this.Hide();
                }
            }
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            newacc a = new newacc(DB);
            a.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.closecon();
            Environment.Exit(0);
        }
    }
}
