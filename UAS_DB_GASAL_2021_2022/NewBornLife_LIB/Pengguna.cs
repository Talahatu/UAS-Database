using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBornLife_LIB
{
    public class Pengguna
    {
        #region FIELD
        private int id;
        private string nama;
        private string username;
        private string password;
        #endregion
        #region CONSTRUCTOR
        public Pengguna(int id, string nama, string username, string password)
        {
            this.Id = id;
            this.Nama = nama;
            this.Username = username;
            this.Password = password;
        }
        #endregion
        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        #endregion
        #region METHOD

        public static Pengguna CekLogin(string username, string password)
        {
            string query = $"SELECT * FROM penggunas WHERE username='{username}' AND password=SHA1('{password}')";
            MySqlDataReader result = Koneksi.RunQuery(query);
            while (result.Read())
            {
                Pengguna penggunaAvail = new Pengguna(result.GetInt32(0), result.GetString(1), result.GetString(2), result.GetString(3));
                return penggunaAvail;
            }
            return null;
        }
        #endregion
    }
}
