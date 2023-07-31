using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewBornLife_LIB
{
    public class Bayi
    {
        #region FIELD
        private int id;
        private string nama;
        private float berat;
        private float panjang;
        private DateTime tgl;
        private string jenisKelamin;
        #endregion
        #region CONSTRUCTORS
        public Bayi(int id, string nama, float berat, float panjang, DateTime tgl, string jenisKelamin)
        {
            this.Id = id;
            this.Nama = nama;
            this.Berat = berat;
            this.Panjang = panjang;
            this.Tgl = tgl;
            this.JenisKelamin = jenisKelamin;
        }
        #endregion
        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public float Berat { get => berat; set => berat = value; }
        public float Panjang { get => panjang; set => panjang = value; }
        public DateTime Tgl { get => tgl; set => tgl = value; }
        public string JenisKelamin { get => jenisKelamin; set => jenisKelamin = value; }
        #endregion
        #region METHOD
        public static List<Bayi> ReadData(Pengguna p)
        {
            string query = $"SELECT b.* FROM bayis AS b INNER JOIN bayi_pengguna AS bp ON b.id=bp.bayis_id WHERE bp.penggunas_id='{p.Id}'";
            MySqlDataReader result = Koneksi.RunQuery(query);
            List<Bayi> listBayi = new List<Bayi>();

            while (result.Read())
            {
                Bayi selectedBayi = new Bayi(result.GetInt32(0), result.GetString(1), result.GetFloat(2), result.GetFloat(3), result.GetDateTime(4), result.GetString(5));
                listBayi.Add(selectedBayi);
            }
            return listBayi;
        }

        public static List<Bayi> ReadDataFilter(string kriteria, string nilai)
        {
            string query = $"SELECT * FROM bayis WHERE {kriteria}='{nilai}'";
            MySqlDataReader result = Koneksi.RunQuery(query);
            List<Bayi> listBayi = new List<Bayi>();

            while (result.Read())
            {
                Bayi selectedBayi = new Bayi(result.GetInt32(0), result.GetString(1), result.GetFloat(2), result.GetFloat(3), result.GetDateTime(4), result.GetString(5));
                listBayi.Add(selectedBayi);
            }
            return listBayi;
        }

        public static void AddData(Bayi b, Pengguna p)
        {
            string query = $"INSERT INTO bayis (nama,berat,panjang,tanggal_lahir,jenis_kelamin) VALUES('{b.Nama}','{b.Berat}','{b.Panjang}','{b.Tgl}','{b.JenisKelamin}')";
            Koneksi.RunDMLCommand(query);

            string query3 = $"SELECT id FROM bayis ORDER BY id DESC LIMIT 1";
            MySqlDataReader result = Koneksi.RunQuery(query3);

            string query2 = $"INSERT INTO bayi_pengguna (bayis_id,penggunas_id) VALUES ('{result.GetInt32(0)}','{p.Id}')";
            Koneksi.RunDMLCommand(query2);
        }
        #endregion
    }
}
