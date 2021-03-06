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
using System.Net;
using System.Net.Mail;
using System.Web;

namespace coiltech
{
    public partial class frmAdminPaneli : Form
    {
        public frmAdminPaneli()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();

        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

        public string txtSmtp1 = "smtp.gmail.com";

        void sendEmailGuncelleme()
        {
            login = new NetworkCredential("ctbilgi41", "kocaeli4141");

            client = new SmtpClient(txtSmtp1);

            //client.Port = Convert.ToInt32(txtPort.Text);
            client.Port = 587;

            //client.EnableSsl = checkBox1.Checked;
            client.EnableSsl = true;

            client.Credentials = login;

            msg = new MailMessage { From = new MailAddress("ctbilgi41" + txtSmtp1.Replace("smtp.", "@"), "Coiltech Bilgilendirme", Encoding.UTF8) };
            msg.To.Add(new MailAddress("azime8777@gmail.com"));

            if (!string.IsNullOrEmpty(txtCC.Text))
                msg.To.Add(new MailAddress(txtCC.Text));

            msg.Subject = "bir sipariş yönetici tarafından güncellendi";
            msg.Body = "anma kodu: " + txtAnmaKodu.Text + "\n dolar kuru: " + txtDolar.Text + "\n euro kuru: " + txtEuro.Text + "\n iskonto oranı: " + txtIskontoOrani.Text + "\n adet: " + numericUpDownAdet.Text + "\n liste fiyatı:" + txtListeFiyati.Text + "\n makine grubu: " + txtMakineGrubu.Text + "\n Müşteri: " + txtMusteri.Text + "\n Müşteri Fiyatı: " + txtMusteriFiyati.Text + "\n Müşteri temsilcisi: " + txtMusteriTemsilcisi.Text + "\n sipariş kodu: " + txtSiparisKodu.Text + "\n UYF no: " + txtUYFno.Text + "\n sipariş tarihi: " + mskSiparisTarihi.Text + "\n teslim tarihi: " + mskTeslimTarihi.Text + "\n fatura şekli: " + cmbFaturaSekli.Text + "\n müşteri konumu: " + cmbMusteriKonumu.Text + "\n müşteri yeni mi eski mi?: " + cmbMusteriYeniEski.Text + "\n satış şekli: " + cmbSatisSekli.Text + "\n cezalı sözleşmeli: " + checkBoxCezaliSozlesmeli.Text + "\n teminat çekli: " + checkBoxTeminatCekli.Text + "\n notlar: " + richTextBox1.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);

            string userstate = "sending...";

            client.SendAsync(msg, userstate);
        }

        void sendEmailSilme()
        {
            login = new NetworkCredential("ctbilgi41", "kocaeli4141");

            client = new SmtpClient(txtSmtp1);

            //client.Port = Convert.ToInt32(txtPort.Text);
            client.Port = 587;

            //client.EnableSsl = checkBox1.Checked;
            client.EnableSsl = true;

            client.Credentials = login;

            msg = new MailMessage { From = new MailAddress("ctbilgi41" + txtSmtp1.Replace("smtp.", "@"), "Coiltech Bilgilendirme", Encoding.UTF8) };
            msg.To.Add(new MailAddress("azime8777@gmail.com"));

            if (!string.IsNullOrEmpty(txtCC.Text))
                msg.To.Add(new MailAddress(txtCC.Text));

            msg.Subject = "bir sipariş yönetici tarafından silindi";
            msg.Body = "anma kodu: " + txtAnmaKodu.Text + "\n dolar kuru: " + txtDolar.Text + "\n euro kuru: " + txtEuro.Text + "\n iskonto oranı: " + txtIskontoOrani.Text + "\n adet: " + numericUpDownAdet.Text + "\n liste fiyatı:" + txtListeFiyati.Text + "\n makine grubu: " + txtMakineGrubu.Text + "\n Müşteri: " + txtMusteri.Text + "\n Müşteri Fiyatı: " + txtMusteriFiyati.Text + "\n Müşteri temsilcisi: " + txtMusteriTemsilcisi.Text + "\n sipariş kodu: " + txtSiparisKodu.Text + "\n UYF no: " + txtUYFno.Text + "\n sipariş tarihi: " + mskSiparisTarihi.Text + "\n teslim tarihi: " + mskTeslimTarihi.Text + "\n fatura şekli: " + cmbFaturaSekli.Text + "\n müşteri konumu: " + cmbMusteriKonumu.Text + "\n müşteri yeni mi eski mi?: " + cmbMusteriYeniEski.Text + "\n satış şekli: " + cmbSatisSekli.Text + "\n cezalı sözleşmeli: " + checkBoxCezaliSozlesmeli.Text + "\n teminat çekli: " + checkBoxTeminatCekli.Text + "\n notlar: " + richTextBox1.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);

            string userstate = "sending...";

            client.SendAsync(msg, userstate);
        }

        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} gönderim iptal oldu.", e.UserState), "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("eposta başarılı şekile iletildi", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUyfDuzenle2 fr = new frmUyfDuzenle2();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        DataTable dt = new DataTable();
        private void frmAdminPaneli_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from Table_1", bgl.baglanti());

            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = string.Format("musteri like '%{0}%'", txtSearch.Text);
                dataGridView1.DataSource = dv.ToTable();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenDeger = dataGridView1.SelectedCells[0].RowIndex;

            txtMusteri.Text = dataGridView1.Rows[secilenDeger].Cells[0].Value.ToString();
            txtMakineGrubu.Text= dataGridView1.Rows[secilenDeger].Cells[1].Value.ToString();
            numericUpDownAdet.Text = dataGridView1.Rows[secilenDeger].Cells[2].Value.ToString();
            txtAnmaKodu.Text = dataGridView1.Rows[secilenDeger].Cells[3].Value.ToString();
            txtSiparisKodu.Text = dataGridView1.Rows[secilenDeger].Cells[4].Value.ToString();
            txtListeFiyati.Text = dataGridView1.Rows[secilenDeger].Cells[5].Value.ToString();
            txtMusteriFiyati.Text = dataGridView1.Rows[secilenDeger].Cells[6].Value.ToString();
            txtEuro.Text = dataGridView1.Rows[secilenDeger].Cells[7].Value.ToString();
            txtDolar.Text = dataGridView1.Rows[secilenDeger].Cells[8].Value.ToString();
            txtIskontoOrani.Text = dataGridView1.Rows[secilenDeger].Cells[9].Value.ToString();
            checkBoxCezaliSozlesmeli.Text = dataGridView1.Rows[secilenDeger].Cells[10].Value.ToString();
            checkBoxTeminatCekli.Text = dataGridView1.Rows[secilenDeger].Cells[11].Value.ToString();
            txtMusteriTemsilcisi.Text = dataGridView1.Rows[secilenDeger].Cells[12].Value.ToString();
            cmbMusteriKonumu.Text = dataGridView1.Rows[secilenDeger].Cells[13].Value.ToString();
            cmbFaturaSekli.Text = dataGridView1.Rows[secilenDeger].Cells[14].Value.ToString();
            cmbSatisSekli.Text = dataGridView1.Rows[secilenDeger].Cells[15].Value.ToString();
            txtUYFno.Text = dataGridView1.Rows[secilenDeger].Cells[16].Value.ToString();
            mskSiparisTarihi.Text = dataGridView1.Rows[secilenDeger].Cells[17].Value.ToString();
            mskTeslimTarihi.Text = dataGridView1.Rows[secilenDeger].Cells[18].Value.ToString();
            cmbMusteriYeniEski.Text = dataGridView1.Rows[secilenDeger].Cells[19].Value.ToString();

            richTextBox1.Text = dataGridView1.Rows[secilenDeger].Cells[20].Value.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Table_1 where musteri=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtMusteri.Text);
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("kayıt silindi","uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            sendEmailSilme();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Table_1 set musteri=@d1, makineGrubu=@d2, adet=@d3, anmaKodu=@d4, listeFiyati=@d6, musteriFiyati=@d7, euro=@d8, dolar=@d9, iskontoOrani=@d10, cezaliSozlesmeli=@d11, teminatCekli=@d12, musteriTemsilcisi=@d13, musteriKonumu=@d14, faturaSekli=@d15, satisSekli=@d16, UYFno=@d17, siparisTarihi=@d18, teslimTarihi=@d19, musteriYeniEski=@d20, notlar=@d21 where siparisKodu=@d5", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtMusteri.Text);
            komut.Parameters.AddWithValue("@d2", txtMakineGrubu.Text);
            komut.Parameters.AddWithValue("@d3", numericUpDownAdet.Text);
            komut.Parameters.AddWithValue("@d4", txtAnmaKodu.Text);
            komut.Parameters.AddWithValue("@d5", txtSiparisKodu.Text);
            komut.Parameters.AddWithValue("@d6", txtListeFiyati.Text);
            komut.Parameters.AddWithValue("@d7", txtMusteriFiyati.Text);
            komut.Parameters.AddWithValue("@d8", txtEuro.Text);
            komut.Parameters.AddWithValue("@d9", txtDolar.Text);
            komut.Parameters.AddWithValue("@d10", txtIskontoOrani.Text);
            komut.Parameters.AddWithValue("@d11", checkBoxCezaliSozlesmeli.Text);
            komut.Parameters.AddWithValue("@d12", checkBoxTeminatCekli.Text);
            komut.Parameters.AddWithValue("@d13", txtMusteriTemsilcisi.Text);
            komut.Parameters.AddWithValue("@d14", cmbMusteriKonumu.Text);
            komut.Parameters.AddWithValue("@d15", cmbFaturaSekli.Text);
            komut.Parameters.AddWithValue("@d16", cmbSatisSekli.Text);
            komut.Parameters.AddWithValue("@d17", txtUYFno.Text);
            komut.Parameters.AddWithValue("@d18", mskSiparisTarihi.Text);
            komut.Parameters.AddWithValue("@d19", mskTeslimTarihi.Text);
            komut.Parameters.AddWithValue("@d20", cmbMusteriYeniEski.Text);
            komut.Parameters.AddWithValue("@d21", richTextBox1.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("kayıt güncellendi", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            sendEmailGuncelleme();
        }

        private void btnSayfayiYenile_Click(object sender, EventArgs e)
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
            this.dataGridView1.Refresh();
            this.dataGridView1.Parent.Refresh();
        }
    }
}
