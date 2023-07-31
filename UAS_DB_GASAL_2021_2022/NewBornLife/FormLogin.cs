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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;
                Pengguna availablePengguna = Pengguna.CekLogin(username, password);

                if (availablePengguna != null)
                {
                    FormUtama parent = (FormUtama)this.MdiParent;
                    parent.loggedPengguna = availablePengguna;
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Login Berhasil", "Informasi");
                    Close();
                }
                else
                {
                    MessageBox.Show("User tidak dikenali", "Informasi");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
