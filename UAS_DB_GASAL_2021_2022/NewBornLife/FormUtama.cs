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
    public partial class FormUtama : Form
    {

        public Pengguna loggedPengguna;
        public FormUtama()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;

            Koneksi myConnection = new Koneksi();

            FormLogin login = new FormLogin();
            login.Owner = this;
            if(login.ShowDialog() == DialogResult.OK)
            {

                labelNama.Text = loggedPengguna.Nama;
            }
        }

        private void dataBayiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarBayi formDB = new FormDaftarBayi();
            formDB.MdiParent = this;
            formDB.Show();
        }

        private void minumSusuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDaftarSusu formDS = new FormDaftarSusu();
            formDS.MdiParent = this;
            formDS.Show();
        }
    }
}
