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
    public partial class maininterface : Form
    {
        daten daten;
        DBconnection DB;
        public maininterface(daten d, DBconnection db)
        {
            InitializeComponent();
            daten = d;
            this.DB = db;
            label1.Text = "Hallo "+daten.name+"!";
            label3.Text = daten.name + "s Konto:";
            label4.Text = daten.total.ToString() + "€";
            if (daten.total > 0)
            {
                label4.ForeColor = Color.Green;
            }
            else
            {
                label4.ForeColor = Color.DarkRed;
            }
        }

        private void maininterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.closecon();
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string[,] data = DB.gettransactions(daten.ID.ToString());
            for (int i = 0; i < data.GetLength(0); i+=2)
            {
                dataGridView1.Rows.Add(data[i,0], data[i, 1], data[i, 2], data[i, 3], data[i, 4]);
            }
        }
    }
}
