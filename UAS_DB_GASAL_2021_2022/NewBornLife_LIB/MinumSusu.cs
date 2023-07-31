using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBornLife_LIB
{
    public class MinumSusu
    {
        #region FIELD
        private int id;
        private int volume;
        private DateTime waktu;
        private Bayi bayi;
        #endregion
        #region CONSTRUCTORS
        public MinumSusu(int id, int volume, DateTime waktu, Bayi bayi)
        {
            this.Id = id;
            this.Volume = volume;
            this.Waktu = waktu;
            this.Bayi = bayi;
        }
        #endregion
        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public int Volume { get => volume; set => volume = value; }
        public DateTime Waktu { get => waktu; set => waktu = value; }
        public Bayi Bayi { get => bayi; set => bayi = value; }
        #endregion
        #region METHOD
        public static List<MinumSusu> ReadData(Pengguna p)
        {
            string query = $"SELECT ms.* FROM minum_susus AS ms INNER JOIN bayi_pengguna AS bp ON ms.bayis_id=bp.bayis_id WHERE bp.penggunas_id='{p.Id}'";
            MySqlDataReader result = Koneksi.RunQuery(query);
            List<MinumSusu> listMinumSusu = new List<MinumSusu>();

            while (result.Read())
            {
                Bayi selectedBayi = Bayi.ReadDataFilter("id", result.GetInt32(3).ToString())[0];
                MinumSusu minumSusu = new MinumSusu(result.GetInt32(0), result.GetInt32(2), result.GetDateTime(1), selectedBayi);
                listMinumSusu.Add(minumSusu);
            }
            return listMinumSusu;
        }

        public static void AddData(MinumSusu ms)
        {
            string query = $"INSERT INTO minum_susus (waktu,volume,bayis_id) VALUES('{ms.Waktu}','{ms.Volume}','{ms.Bayi.Id}')";
            Koneksi.RunDMLCommand(query);
        }
        #endregion
    }
}
