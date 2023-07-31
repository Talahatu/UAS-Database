using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewBornLife_LIB;

namespace NewbornLife
{
    public partial class FormSusu : Form
    {
        public FormSusu()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Bayi selectedBayi = (Bayi)comboBoxBayi.SelectedItem;
                DateTime waktu = dateTimePickerTglLahir.Value;
                int volume = int.Parse(textBoxBerat.Text);

                MinumSusu newMinumSusu = new MinumSusu(0, volume, waktu, selectedBayi);
                MinumSusu.AddData(newMinumSusu);
                MessageBox.Show("Tambah Data Berhasil", "Informasi");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormSusu_Load(object sender, EventArgs e)
        {
            FormUtama grandpa = (FormUtama)this.Owner.MdiParent;
            Pengguna loggedPengguna = grandpa.loggedPengguna;
            List<Bayi> listBayi = Bayi.ReadData(loggedPengguna);
            comboBoxBayi.DataSource = listBayi;
            comboBoxBayi.DisplayMember = "Nama";
        }
    }
}
