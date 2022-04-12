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
        }

        private void maininterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            DB.closecon();
            Environment.Exit(0);
        }
    }
}
