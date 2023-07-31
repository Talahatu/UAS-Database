using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace NewBornLife_LIB
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;


        #region Properties
        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }
        #endregion Properties


        #region Constructors

        public Koneksi()
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            //Ambil section userSettings yang otomatis dibuat berdasarkan file .settings
            ConfigurationSectionGroup userSettings = myConf.SectionGroups["userSettings"];

            //Ambil bagian setting SistemPenjualanPembelian.db
            var settingsSection = userSettings.Sections["NewbornLife.db"] as ClientSettingsSection;

            //Ambil tiap variable setting
            string DbServer = settingsSection.Settings.Get("DbServer").Value.ValueXml.InnerText;
            string DbName = settingsSection.Settings.Get("DbName").Value.ValueXml.InnerText;
            string DbUsername = settingsSection.Settings.Get("DbUsername").Value.ValueXml.InnerText;
            string DbPassword = settingsSection.Settings.Get("DbPassword").Value.ValueXml.InnerText;

            string strCon = "server=" + DbServer + ";database=" + DbName + ";uid=" + DbUsername + ";password=" + DbPassword + ";SSL Mode=0" ;
            KoneksiDB = new MySqlConnection();

            KoneksiDB.ConnectionString = strCon;

            Connect();
        }

        public Koneksi(string pServer, string pDatabase, string pUsername, string pPassword)
        {
            string strCon = "server=" + pServer + ";database=" + pDatabase + ";uid=" + pUsername + ";password=" + pPassword+";SSL Mode=0";
            KoneksiDB = new MySqlConnection();

            KoneksiDB.ConnectionString = strCon;

            Connect();
        }
        #endregion Constructors


        #region Methods
        public void Connect()
        {
            if (KoneksiDB.State == System.Data.ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            KoneksiDB.Open();
        }

        public static MySqlDataReader RunQuery(string query)
        {
            Koneksi connection = new Koneksi();

            MySqlCommand command = new MySqlCommand(query, connection.KoneksiDB);

            MySqlDataReader result = command.ExecuteReader();

            return result;
        }

        public static int RunDMLCommand(string query)
        {
            Koneksi connection = new Koneksi();

            MySqlCommand command = new MySqlCommand(query, connection.KoneksiDB);

            return command.ExecuteNonQuery();
        }

        #endregion Methods

    }
}
