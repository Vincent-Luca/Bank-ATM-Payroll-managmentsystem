using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;

namespace Bank
{
    public class DBconnection : verschluesslung
    {
        string DBpath;
        OleDbConnection con;
        OleDbCommand cmd;
        public DBconnection()
        {
            string dir = Environment.CurrentDirectory;
            DBpath = Directory.GetParent(dir).Parent.Parent.FullName;
            cmd = new OleDbCommand();
        }

        public void connection()
        {
            con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBpath + "\\MainDB.mdb");
            cmd.Connection = con;
            con.Open();
        }

        public bool login(string name, string pin)
        {
            cmd.CommandText = "Select * from Accounts Where Namen = '" + name + "' and Pin = '" + pin + "';";
            bool login = false;
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetValue(1).ToString() == name && reader.GetValue(reader.GetOrdinal("Pin")).ToString() == pin)
                {
                    login = true;
                }
            }
            reader.Close();
            return login;
        }

        public daten createacc(string name, string pin)
        {
            string iban;
            iban = "ECU" + encrypt(name) + encrypt(pin); // i know its not safe but this is just a test to see if it works good like this
            cmd.CommandText = "Insert into Accounts(Namen,Pin,Erstelldatum,Total,IBAN) Values ('" + name + "','" + encrypt(pin) + "','" + DateTime.Now.Date.ToString() + "'," + 500.ToString() + ",'" + iban + "');";
            cmd.ExecuteNonQuery();
            return dateneinfügen(name, pin);
        }


        public daten dateneinfügen(string name, string pin)
        {
            daten d = new daten();
            cmd.CommandText = "Select * from Accounts Where Namen = '" + name + "' and Pin = '" + pin + "';";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetValue(1).ToString() == name && reader.GetValue(reader.GetOrdinal("Pin")).ToString() == pin)
                {
                    d.ID = reader.GetInt32(0);
                    d.name = name;
                    d.pin = decrypt(pin);
                    d.date = reader.GetString(3);
                    d.total = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("Total")));
                    d.IBAN = reader.GetString(5);
                }
            }
            reader.Close();
            return d;
        }
        public void closecon()
        {
            con.Close();
            con.Dispose();
            cmd.Dispose();
        }

        public string[,] selectquery(List<string> colums, string table)
        {
            string query = "select " + colums[1];
            for (int i = 1; i < colums.Count; i++)
            {
                query = query + "," + colums[i];
            }
            query += "from " + table;
            cmd.CommandText = query;
            string[,] result = new string[colums.Count, getrows()];

            for (int i = 0; i < colums.Count; i++)
            {
                cmd.CommandText ="Select "+colums[i]+" from "+table+";";
                OleDbDataReader reader = cmd.ExecuteReader();
                int k = 1;
                while (reader.Read())
                {
                    result[i, k] = reader.GetValue(reader.GetOrdinal(colums[i])).ToString();
                    k++;
                }
            }
            return result;
        }

        private int getrows()
        {
            int thing = 0;
            OleDbDataReader reader = cmd.ExecuteReader();
            thing = reader.Depth;
            reader.Close();
            return thing+1;
        }


        public string[,] gettransactions(string id)
        {
            cmd.CommandText = "Select  DISTINCT * from Accounts, Transactions WHERE FromID = "+id+" or  ToID = "+id+";";

            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

            }
        }
    }
}
