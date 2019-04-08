using MySql.Data.MySqlClient;

namespace chemicalModel
{
    class DB
    {
        private string nameDB = "";
        private string host = "";
        private string user = "";
        private string password = "";
        MySqlConnection connect = null;
        public DB(string nameDB, string host, string user, string password)
        {
            this.nameDB = nameDB;
            this.host = host;
            this.user = user;
            this.password = password;            
        }

        public void Connection()
        {
            this.connect = new MySqlConnection("server=" + host + ";user=" + user + ";database=" + nameDB + ";password=" + password + ";");            
        }

        public MySqlDataReader Get(string query)
        {
            connect.Open();
            MySqlCommand com = new MySqlCommand(query, connect);
            MySqlDataReader resp = com.ExecuteReader();
            
            return resp;
        }

    }
}
