using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestChastya
{
    class BDConnection
    {
        private MySqlConnection con;
        private string NameDB, Host, Port, UserName, Password;

        public BDConnection(string NameDB, string Host, string Port, string UserName, string password)
        {
            this.NameDB = NameDB;
            this.Host = Host;
            this.Port = Port;
            this.UserName = UserName;
            Password = password;
        }

        public bool OpenConnection()
        {
            try
            {
                con = new MySqlConnection("Server = " + Host + "; Database = " + NameDB
                   + ";port=" + Port + ";User Id=" + UserName + ";password=" + Password + ";SslMode=none");
                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public MySqlConnection returnCell()
        {
            return con;
        }
    }
}
