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
    public partial class FormTambahBayi : Form
    {
        public FormTambahBayi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                string nama = textBoxNama.Text;
                string jenisKelamin = (string)comboBoxJenisKelamin.SelectedItem;
                float berat = float.Parse(textBoxBerat.Text);
                float panjang = float.Parse(textBoxPanjang.Text);
                DateTime tgl = dateTimePickerTglLahir.Value.Date;

                Bayi newBayi = new Bayi(0, nama, berat, panjang, tgl, jenisKelamin);

                FormUtama grandpa = (FormUtama)this.Owner.MdiParent;

                Pengguna loggedPengguna = grandpa.loggedPengguna;

                Bayi.AddData(newBayi, loggedPengguna);

                FormDaftarBayi Parent = new FormDaftarBayi();
                Parent.FormDaftarBayi_Load(sender, e);

                MessageBox.Show("Tambah Data Berhasil!", "Informasi");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
