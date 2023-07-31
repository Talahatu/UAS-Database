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
    public partial class FormDaftarSusu : Form
    {
        public FormDaftarSusu()
        {
            InitializeComponent();
        }
        public List<MinumSusu> listMinum;
        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormSusu formSus = new FormSusu();
            formSus.Owner = this;
            formSus.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDaftarSusu_Load(object sender, EventArgs e)
        {
            FormUtama parent = (FormUtama)this.MdiParent;
            Pengguna loggedPengguna = parent.loggedPengguna;
            listMinum = MinumSusu.ReadData(loggedPengguna);
            FormatDataGrid();
            TampilDataGrid();
        }
        void FormatDataGrid()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("nama", "Nama");
            dataGridView1.Columns.Add("waktu", "Waktu Minum Susu");
            dataGridView1.Columns.Add("volume", "Volume Susu");



            dataGridView1.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["waktu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["volume"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.ReadOnly = true;
        }
        void TampilDataGrid()
        {
            dataGridView1.Rows.Clear();

            if (listMinum.Count > 0)
            {
                foreach (MinumSusu item in listMinum)
                {
                    dataGridView1.Rows.Add(item.Bayi.Nama, item.Waktu, item.Volume);
                }
            }
            else
            {
                dataGridView1.DataSource = null;
            }
        }
    }
}
