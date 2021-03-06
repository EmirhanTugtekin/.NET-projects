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
using System.Configuration;


namespace coiltech
{
    public partial class frmListeEkrani : Form
    {
        public frmListeEkrani()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUyfDuzenle2 fr = new frmUyfDuzenle2();
            fr.Show();
            this.Hide();
        }

        DataTable dt = new DataTable();
        private void frmListeEkrani_Load(object sender, EventArgs e)
        {
            
            SqlDataAdapter sda = new SqlDataAdapter("select * from Table_1",bgl.baglanti());
            
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("musteri like '%{0}%'", txtSearch.Text);
                dataGridView1.DataSource = dv.ToTable();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
