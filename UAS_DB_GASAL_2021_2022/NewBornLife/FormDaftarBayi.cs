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
    public partial class FormDaftarBayi : Form
    {
        public FormDaftarBayi()
        {
            InitializeComponent();
        }

        List<Bayi> listBayi;

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahBayi formTB = new FormTambahBayi();
            formTB.Owner = this;
            formTB.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void FormDaftarBayi_Load(object sender, EventArgs e)
        {
            FormUtama parent = (FormUtama)this.MdiParent;
            Pengguna loggedPengguna = parent.loggedPengguna;
            listBayi = Bayi.ReadData(loggedPengguna);
            FormatDataGrid();
            TampilDataGrid();
        }

        void TampilDataGrid()
        {
            dataGridView1.Rows.Clear();

            if (listBayi.Count > 0)
            {
                foreach (Bayi item in listBayi)
                {
                    dataGridView1.Rows.Add(item.Id,item.Nama, item.Berat, item.Panjang, item.Tgl.Date, item.JenisKelamin);
                }
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }

        void FormatDataGrid()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("id", "ID Bayi");
            dataGridView1.Columns.Add("nama", "Nama");
            dataGridView1.Columns.Add("berat", "Berat");
            dataGridView1.Columns.Add("panjang", "Panjang");
            dataGridView1.Columns.Add("tglLahir", "Tanggal Lahir");
            dataGridView1.Columns.Add("jenisKelamin", "Jenis Kelamin");


            dataGridView1.Columns["berat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["panjang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["tglLahir"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["jenisKelamin"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.ReadOnly = true;
        }
    }
}
