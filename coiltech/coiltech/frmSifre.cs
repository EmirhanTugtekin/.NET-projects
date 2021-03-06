using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace coiltech
{
    public partial class frmSifre : Form
    {
        public frmSifre()
        {
            InitializeComponent();
        }

        sqlBaglantisi myConnection = new sqlBaglantisi();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_sifreTablosu where Sifre=@p1", myConnection.baglanti());
            komut.Parameters.AddWithValue("@p1", txtSifre.Text);

            SqlDataReader sdr = komut.ExecuteReader();

            if(sdr.Read())
            {
                frmAdminPaneli fr = new frmAdminPaneli();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("yanlış şifre");
            }

            myConnection.baglanti().Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmUyfDuzenle2 fr = new frmUyfDuzenle2();
            fr.Show();
            this.Hide();
        }
    }
}
