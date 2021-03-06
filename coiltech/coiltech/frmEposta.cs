using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace coiltech
{
    public partial class frmEposta : Form
    {
        public frmEposta()
        {
            InitializeComponent();
        }

        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

        void sendEmail()
        {
            login = new NetworkCredential(txtUserName.Text, txtPassword.Text);

            client = new SmtpClient(txtSmtp.Text);
            

            //client.Port = Convert.ToInt32(txtPort.Text);
            client.Port = 587;

            //client.EnableSsl = checkBox1.Checked;
            client.EnableSsl = true;

            client.Credentials = login;

            msg = new MailMessage { From = new MailAddress(txtUserName.Text + txtSmtp.Text.Replace("smtp.", "@"), "Coiltech Bilgilendirme", Encoding.UTF8) };
            msg.To.Add(new MailAddress(txtTo.Text));

            if (!string.IsNullOrEmpty(txtCC.Text))
                msg.To.Add(new MailAddress(txtCC.Text));
            

            msg.Subject = txtSubject.Text;
            msg.Body = txtMessage.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);

            string userstate = "sending...";

            client.SendAsync(msg, userstate);
        }

            private static void SendCompletedCallback(object sender,AsyncCompletedEventArgs e)
            {
                if (e.Cancelled)
                    MessageBox.Show(string.Format("{0} gönderim iptal oldu.", e.UserState), "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(e.Error!=null)
                    MessageBox.Show(string.Format("{0} {1}", e.UserState,e.Error), "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("eposta başarılı şekile iletildi", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
      

        private void button1_Click(object sender, EventArgs e)
        {
            sendEmail();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
