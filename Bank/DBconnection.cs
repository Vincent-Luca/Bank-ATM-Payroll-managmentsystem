using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;

namespace Bank
{
    class DBconnection
    {
        string DBpath;
        OleDbConnection con;
        OleDbCommand cmd;
        public DBconnection()
        {
            string dir = Environment.CurrentDirectory;
            DBpath = Directory.GetParent(dir).Parent.Parent.FullName;
        }

        public void connection()
        {
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBpath + "\\MainDB.mdb");
            cmd.Connection = con;
            con.Open();
        }
    }
}
