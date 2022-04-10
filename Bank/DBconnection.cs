using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;

namespace Bank
{
    class DBconnection : verschluesslung
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

        public bool login(string name, string pin)
        {
            cmd.CommandText = "Select * from Accounts Where Namen = '"+name+"' and Pin = '"+pin+"';";
            bool login = false;
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(1) == name && reader.GetString(2) == pin)
                {
                    login = true;
                }
            }
            reader.Close();
            return login;
        }

        public void createacc(string name, string pin)
        {
            string iban;
            Random ran = new Random();
            ran.Next(1000, 9999);
            iban = "ECU" + ran.Next(1000, 9999).ToString();
            cmd.CommandText = "Insert into Accounts(Namen,Pin,Erstelldatum,Total,IBAN) values("+name+","+pin+","+DateTime.Now.Date.ToString()+","+0.ToString()+","+iban+");";
            cmd.ExecuteNonQuery();
        }


        public daten dateneinfügen(string name, string pin)
        {
            daten d = new daten();
            cmd.CommandText = "Select * from Accounts Where Namen = '" + name + "' and Pin = '" + pin + "';";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(1) == name && reader.GetString(2) == pin)
                {
                    d.ID = reader.GetInt32(0);
                    d.name = name;
                    d.pin = pin;
                    d.date = reader.GetDateTime(3);
                    d.total = reader.GetInt32(4);
                    d.IBAN = reader.GetString(5);
                }
            }
            reader.Close();
            return d;
        }
    }
}
