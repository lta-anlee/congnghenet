using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DBConnect
    {
        SqlConnection connect;
        string strConnect, strServerName, strDataBaseName, strUserName, strPassword;

        public string StrConnection
        {
            get { return strConnect; }
            set { strConnect = value; }
        }
        public string StrServerName
        {
            get { return strServerName; }
            set { strServerName = value; }
        }
        public string StrDataBaseName
        {
            get { return strDataBaseName; }
            set { strDataBaseName = value; }
        }
        public string StrUserName
        {
            get { return strUserName; }
            set { strUserName = value; }
        }
        public string StrPassword
        {
            get { return strPassword; }
            set { strPassword = value; }
        }

        public SqlConnection Connect
        {
            get { return connect; }
            set { connect = value; }
        }
        public DBConnect()
        {
            StrServerName = @"A110PC40";
            StrDataBaseName = "QLSINHVIEN";
            StrUserName = "sa";
            StrPassword="123";
            StrConnection = @"Data Source=" + StrServerName + ";Initial Catalog=" + StrDataBaseName;
            StrConnection += "User ID=" + StrUserName + ";Password=" + StrPassword;
            Connect = new SqlConnection(StrConnection);
        }
        public DBConnect(string strServerName, string strDataBaseName, string strUserName, string strPassword)
        {
            StrServerName = strServerName;
            StrDataBaseName = strDataBaseName;
            StrUserName = strUserName;
            StrPassword = strPassword;
            StrConnection = @"Data Source=" + StrServerName + ";Initial Catalog=" + StrDataBaseName;
            StrConnection += "User ID=" + StrUserName + ";Password=" + StrPassword;
            Connect = new SqlConnection(StrConnection);
        }
        public void oppenConnection()
        {
            if (Connect.State.ToString() == "Closed")
                Connect.Open();
        }
        public void closeConnection()
        {
            if (Connect.State.ToString() == "Open")
                Connect.Close();
        }
        public int executeNonQuery(string sql)
        {
            oppenConnection();
            SqlCommand cmd = new SqlCommand(sql, connect);
            int count = cmd.ExecuteNonQuery();
            closeConnection();
            return count;
        }
        public int getCount_ExecuteScalar(string sql)
        {
            oppenConnection();
            SqlCommand cmd = new SqlCommand(sql, connect);
            int count = (int)cmd.ExecuteScalar();
            closeConnection();
            return count;
        }
    }
}
