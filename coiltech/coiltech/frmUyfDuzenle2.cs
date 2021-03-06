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
using System.Net;
using System.Net.Mail;
using System.Web;

namespace coiltech
{
    public partial class frmUyfDuzenle2 : Form
    {
        public frmUyfDuzenle2()
        {
            InitializeComponent();
            
        }

        sqlBaglantisi myConnection = new sqlBaglantisi();

        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

        
        private void frmUyfDuzenle2_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        public string txtSmtp1 = "smtp.gmail.com";

        void sendEmail()
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

            msg.Subject = "yeni sipariş alındı";
            msg.Body ="anma kodu: "+ txtAnmaKodu.Text+ "\n dolar kuru: " + txtDolar.Text+ "\n euro kuru: " + txtEuro.Text+ "\n iskonto oranı: " + txtIskontoOrani.Text + "\n adet: " +numericUpDownAdet.Text+ "\n liste fiyatı:" + txtListeFiyati.Text + "\n makine grubu: " + txtMakineGrubu.Text + "\n Müşteri: " + txtMusteri.Text + "\n Müşteri Fiyatı: " + txtMusteriFiyati.Text + "\n Müşteri temsilcisi: " + txtMusteriTemsilcisi.Text + "\n sipariş kodu: " + txtSiparisKodu.Text + "\n UYF no: " + txtUYFno.Text + "\n sipariş tarihi: "+mskSiparisTarihi.Text + "\n teslim tarihi: " +mskTeslimTarihi.Text + "\n fatura şekli: " +cmbFaturaSekli.Text + "\n müşteri konumu: "+cmbMusteriKonumu.Text+ "\n müşteri yeni mi eski mi?: "+cmbMusteriYeniEski.Text + "\n satış şekli: "+cmbSatisSekli.Text + "\n cezalı sözleşmeli: "+checkBoxCezaliSozlesmeli.Text + "\n teminat çekli: "+checkBoxTeminatCekli.Text + "\n notlar: "+richTextBox1.Text;
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Table_1 (musteri, makineGrubu, adet, anmaKodu, siparisKodu, listeFiyati, musteriFiyati, euro, dolar, iskontoOrani, cezaliSozlesmeli, teminatCekli, musteriTemsilcisi, musteriKonumu, faturaSekli, satisSekli, UYFno, siparisTarihi, teslimTarihi, musteriYeniEski, notlar) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20,@p21)", myConnection.baglanti());
            komut.Parameters.AddWithValue("@p1", txtMusteri.Text);
            komut.Parameters.AddWithValue("@p2", txtMakineGrubu.Text);
            komut.Parameters.AddWithValue("@p3", numericUpDownAdet.Text);
            komut.Parameters.AddWithValue("@p4", txtAnmaKodu.Text);
            komut.Parameters.AddWithValue("@p5", txtSiparisKodu.Text);
            komut.Parameters.AddWithValue("@p6", txtListeFiyati.Text);
            komut.Parameters.AddWithValue("@p7", txtMusteriFiyati.Text);
            komut.Parameters.AddWithValue("@p8", txtEuro.Text);
            komut.Parameters.AddWithValue("@p9", txtDolar.Text);
            komut.Parameters.AddWithValue("@p10", txtIskontoOrani.Text);
            komut.Parameters.AddWithValue("@p11", checkBoxCezaliSozlesmeli.Text);
            komut.Parameters.AddWithValue("@p12", checkBoxTeminatCekli.Text);
            komut.Parameters.AddWithValue("@p13", txtMusteriTemsilcisi.Text);
            komut.Parameters.AddWithValue("@p14", cmbMusteriKonumu.Text);
            komut.Parameters.AddWithValue("@p15", cmbFaturaSekli.Text);
            komut.Parameters.AddWithValue("@p16", cmbSatisSekli.Text);
            komut.Parameters.AddWithValue("@p17", txtUYFno.Text);
            komut.Parameters.AddWithValue("@p18", mskSiparisTarihi.Text);
            komut.Parameters.AddWithValue("@p19", mskTeslimTarihi.Text);
            komut.Parameters.AddWithValue("@p20", cmbMusteriYeniEski.Text);
            komut.Parameters.AddWithValue("@p21", richTextBox1.Text);

            komut.ExecuteNonQuery();
            myConnection.baglanti().Close();

            MessageBox.Show("kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //frmEposta frEposta = new frmEposta();
            //frEposta.Show();

            sendEmail();

        }

        private void btnListeEkranı_Click(object sender, EventArgs e)
        {
            frmListeEkrani fr = new frmListeEkrani();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSifre fr = new frmSifre();
            fr.Show();
            this.Hide();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }
    }
}
