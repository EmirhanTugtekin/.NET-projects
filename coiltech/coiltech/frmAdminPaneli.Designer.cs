namespace coiltech
{
    partial class frmAdminPaneli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbMusteriYeniEski = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.mskTeslimTarihi = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.mskSiparisTarihi = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtUYFno = new System.Windows.Forms.TextBox();
            this.cmbSatisSekli = new System.Windows.Forms.ComboBox();
            this.cmbFaturaSekli = new System.Windows.Forms.ComboBox();
            this.cmbMusteriKonumu = new System.Windows.Forms.ComboBox();
            this.txtMusteriTemsilcisi = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIskontoOrani = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtListeFiyati = new System.Windows.Forms.TextBox();
            this.txtMusteriFiyati = new System.Windows.Forms.TextBox();
            this.txtSiparisKodu = new System.Windows.Forms.TextBox();
            this.numericUpDownAdet = new System.Windows.Forms.NumericUpDown();
            this.txtAnmaKodu = new System.Windows.Forms.TextBox();
            this.txtMakineGrubu = new System.Windows.Forms.TextBox();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.checkBoxTeminatCekli = new System.Windows.Forms.CheckBox();
            this.checkBoxCezaliSozlesmeli = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 56);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(380, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ara:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(435, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(511, 30);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(659, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 570);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(697, 570);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGuncelle);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 638);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1356, 60);
            this.panel3.TabIndex = 2;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuncelle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGuncelle.Location = new System.Drawing.Point(262, 0);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(255, 60);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(262, 60);
            this.button4.TabIndex = 6;
            this.button4.Text = "SİL";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Location = new System.Drawing.Point(839, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 60);
            this.button2.TabIndex = 5;
            this.button2.Text = "ÇIKIŞ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(1094, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "GERİ DÖN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.txtCC);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.cmbMusteriYeniEski);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.mskTeslimTarihi);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.mskSiparisTarihi);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.txtUYFno);
            this.panel4.Controls.Add(this.cmbSatisSekli);
            this.panel4.Controls.Add(this.cmbFaturaSekli);
            this.panel4.Controls.Add(this.cmbMusteriKonumu);
            this.panel4.Controls.Add(this.txtMusteriTemsilcisi);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.txtIskontoOrani);
            this.panel4.Controls.Add(this.txtDolar);
            this.panel4.Controls.Add(this.txtEuro);
            this.panel4.Controls.Add(this.txtListeFiyati);
            this.panel4.Controls.Add(this.txtMusteriFiyati);
            this.panel4.Controls.Add(this.txtSiparisKodu);
            this.panel4.Controls.Add(this.numericUpDownAdet);
            this.panel4.Controls.Add(this.txtAnmaKodu);
            this.panel4.Controls.Add(this.txtMakineGrubu);
            this.panel4.Controls.Add(this.txtMusteri);
            this.panel4.Controls.Add(this.checkBoxTeminatCekli);
            this.panel4.Controls.Add(this.checkBoxCezaliSozlesmeli);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(0, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(653, 570);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.richTextBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 360);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(653, 210);
            this.panel5.TabIndex = 109;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(653, 210);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // txtCC
            // 
            this.txtCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCC.Location = new System.Drawing.Point(334, 310);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(57, 26);
            this.txtCC.TabIndex = 108;
            this.txtCC.Visible = false;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(403, 232);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 20);
            this.label19.TabIndex = 107;
            this.label19.Text = "müşteri yeni/eski";
            // 
            // cmbMusteriYeniEski
            // 
            this.cmbMusteriYeniEski.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMusteriYeniEski.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMusteriYeniEski.FormattingEnabled = true;
            this.cmbMusteriYeniEski.Items.AddRange(new object[] {
            "yeni ",
            "eski"});
            this.cmbMusteriYeniEski.Location = new System.Drawing.Point(407, 255);
            this.cmbMusteriYeniEski.Name = "cmbMusteriYeniEski";
            this.cmbMusteriYeniEski.Size = new System.Drawing.Size(121, 28);
            this.cmbMusteriYeniEski.TabIndex = 104;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(524, 285);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 20);
            this.label16.TabIndex = 106;
            this.label16.Text = "teslim tarihi";
            // 
            // mskTeslimTarihi
            // 
            this.mskTeslimTarihi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mskTeslimTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTeslimTarihi.Location = new System.Drawing.Point(528, 310);
            this.mskTeslimTarihi.Mask = "00/00/0000";
            this.mskTeslimTarihi.Name = "mskTeslimTarihi";
            this.mskTeslimTarihi.Size = new System.Drawing.Size(93, 26);
            this.mskTeslimTarihi.TabIndex = 103;
            this.mskTeslimTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(405, 285);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 20);
            this.label17.TabIndex = 105;
            this.label17.Text = "sipariş tarihi";
            // 
            // mskSiparisTarihi
            // 
            this.mskSiparisTarihi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mskSiparisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskSiparisTarihi.Location = new System.Drawing.Point(409, 310);
            this.mskSiparisTarihi.Mask = "00/00/0000";
            this.mskSiparisTarihi.Name = "mskSiparisTarihi";
            this.mskSiparisTarihi.Size = new System.Drawing.Size(97, 26);
            this.mskSiparisTarihi.TabIndex = 102;
            this.mskSiparisTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(12, 287);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 20);
            this.label15.TabIndex = 95;
            this.label15.Text = "ÜYF no";
            // 
            // txtUYFno
            // 
            this.txtUYFno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUYFno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUYFno.Location = new System.Drawing.Point(12, 310);
            this.txtUYFno.Name = "txtUYFno";
            this.txtUYFno.Size = new System.Drawing.Size(195, 26);
            this.txtUYFno.TabIndex = 92;
            // 
            // cmbSatisSekli
            // 
            this.cmbSatisSekli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSatisSekli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSatisSekli.FormattingEnabled = true;
            this.cmbSatisSekli.Items.AddRange(new object[] {
            " doğrudan",
            " dolaylı"});
            this.cmbSatisSekli.Location = new System.Drawing.Point(533, 199);
            this.cmbSatisSekli.Name = "cmbSatisSekli";
            this.cmbSatisSekli.Size = new System.Drawing.Size(120, 28);
            this.cmbSatisSekli.TabIndex = 91;
            // 
            // cmbFaturaSekli
            // 
            this.cmbFaturaSekli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbFaturaSekli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFaturaSekli.FormattingEnabled = true;
            this.cmbFaturaSekli.Items.AddRange(new object[] {
            "ihracat",
            "ithalat"});
            this.cmbFaturaSekli.Location = new System.Drawing.Point(407, 199);
            this.cmbFaturaSekli.Name = "cmbFaturaSekli";
            this.cmbFaturaSekli.Size = new System.Drawing.Size(120, 28);
            this.cmbFaturaSekli.TabIndex = 90;
            // 
            // cmbMusteriKonumu
            // 
            this.cmbMusteriKonumu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMusteriKonumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMusteriKonumu.FormattingEnabled = true;
            this.cmbMusteriKonumu.Items.AddRange(new object[] {
            " yurt içi",
            " yurt dışı"});
            this.cmbMusteriKonumu.Location = new System.Drawing.Point(407, 141);
            this.cmbMusteriKonumu.Name = "cmbMusteriKonumu";
            this.cmbMusteriKonumu.Size = new System.Drawing.Size(120, 28);
            this.cmbMusteriKonumu.TabIndex = 88;
            // 
            // txtMusteriTemsilcisi
            // 
            this.txtMusteriTemsilcisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMusteriTemsilcisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriTemsilcisi.Location = new System.Drawing.Point(407, 91);
            this.txtMusteriTemsilcisi.Name = "txtMusteriTemsilcisi";
            this.txtMusteriTemsilcisi.Size = new System.Drawing.Size(170, 26);
            this.txtMusteriTemsilcisi.TabIndex = 87;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(529, 179);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 20);
            this.label18.TabIndex = 94;
            this.label18.Text = "Satış Şekli";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(403, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 20);
            this.label13.TabIndex = 89;
            this.label13.Text = "Fatura Şekli";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(403, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 20);
            this.label11.TabIndex = 86;
            this.label11.Text = "Müşteri Konumu";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(403, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 20);
            this.label14.TabIndex = 85;
            this.label14.Text = "Müşteri Temsilcisi";
            // 
            // txtIskontoOrani
            // 
            this.txtIskontoOrani.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIskontoOrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIskontoOrani.Location = new System.Drawing.Point(260, 251);
            this.txtIskontoOrani.Name = "txtIskontoOrani";
            this.txtIskontoOrani.Size = new System.Drawing.Size(124, 30);
            this.txtIskontoOrani.TabIndex = 31;
            // 
            // txtDolar
            // 
            this.txtDolar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDolar.Location = new System.Drawing.Point(134, 251);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(106, 30);
            this.txtDolar.TabIndex = 30;
            // 
            // txtEuro
            // 
            this.txtEuro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEuro.Location = new System.Drawing.Point(12, 251);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(106, 30);
            this.txtEuro.TabIndex = 28;
            // 
            // txtListeFiyati
            // 
            this.txtListeFiyati.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtListeFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtListeFiyati.Location = new System.Drawing.Point(12, 195);
            this.txtListeFiyati.Name = "txtListeFiyati";
            this.txtListeFiyati.Size = new System.Drawing.Size(180, 30);
            this.txtListeFiyati.TabIndex = 24;
            // 
            // txtMusteriFiyati
            // 
            this.txtMusteriFiyati.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMusteriFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriFiyati.Location = new System.Drawing.Point(235, 195);
            this.txtMusteriFiyati.Name = "txtMusteriFiyati";
            this.txtMusteriFiyati.Size = new System.Drawing.Size(156, 30);
            this.txtMusteriFiyati.TabIndex = 27;
            // 
            // txtSiparisKodu
            // 
            this.txtSiparisKodu.Location = new System.Drawing.Point(235, 143);
            this.txtSiparisKodu.Name = "txtSiparisKodu";
            this.txtSiparisKodu.Size = new System.Drawing.Size(156, 26);
            this.txtSiparisKodu.TabIndex = 22;
            // 
            // numericUpDownAdet
            // 
            this.numericUpDownAdet.Location = new System.Drawing.Point(235, 91);
            this.numericUpDownAdet.Name = "numericUpDownAdet";
            this.numericUpDownAdet.Size = new System.Drawing.Size(92, 26);
            this.numericUpDownAdet.TabIndex = 18;
            // 
            // txtAnmaKodu
            // 
            this.txtAnmaKodu.Location = new System.Drawing.Point(11, 143);
            this.txtAnmaKodu.Name = "txtAnmaKodu";
            this.txtAnmaKodu.Size = new System.Drawing.Size(203, 26);
            this.txtAnmaKodu.TabIndex = 20;
            // 
            // txtMakineGrubu
            // 
            this.txtMakineGrubu.Location = new System.Drawing.Point(12, 91);
            this.txtMakineGrubu.Name = "txtMakineGrubu";
            this.txtMakineGrubu.Size = new System.Drawing.Size(202, 26);
            this.txtMakineGrubu.TabIndex = 17;
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(16, 39);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(375, 26);
            this.txtMusteri.TabIndex = 15;
            // 
            // checkBoxTeminatCekli
            // 
            this.checkBoxTeminatCekli.AutoSize = true;
            this.checkBoxTeminatCekli.Location = new System.Drawing.Point(419, 14);
            this.checkBoxTeminatCekli.Name = "checkBoxTeminatCekli";
            this.checkBoxTeminatCekli.Size = new System.Drawing.Size(130, 24);
            this.checkBoxTeminatCekli.TabIndex = 33;
            this.checkBoxTeminatCekli.Text = "Teminat Çekli";
            this.checkBoxTeminatCekli.UseVisualStyleBackColor = true;
            // 
            // checkBoxCezaliSozlesmeli
            // 
            this.checkBoxCezaliSozlesmeli.AutoSize = true;
            this.checkBoxCezaliSozlesmeli.Location = new System.Drawing.Point(419, 39);
            this.checkBoxCezaliSozlesmeli.Name = "checkBoxCezaliSozlesmeli";
            this.checkBoxCezaliSozlesmeli.Size = new System.Drawing.Size(158, 24);
            this.checkBoxCezaliSozlesmeli.TabIndex = 34;
            this.checkBoxCezaliSozlesmeli.Text = "Cezalı Sözleşmeli";
            this.checkBoxCezaliSozlesmeli.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Anma Kodu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(256, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "İskonto Oranı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Dolar Kuru";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Euro Kuru";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Müşteri Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Liste Fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Sipariş Kodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Adet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Makine Grubu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Müşteri";
            // 
            // frmAdminPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1356, 698);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmAdminPaneli";
            this.Text = "Admin Paneli";
            this.Load += new System.EventHandler(this.frmAdminPaneli_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtIskontoOrani;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtListeFiyati;
        private System.Windows.Forms.TextBox txtMusteriFiyati;
        private System.Windows.Forms.TextBox txtSiparisKodu;
        private System.Windows.Forms.NumericUpDown numericUpDownAdet;
        private System.Windows.Forms.TextBox txtAnmaKodu;
        private System.Windows.Forms.TextBox txtMakineGrubu;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.CheckBox checkBoxTeminatCekli;
        private System.Windows.Forms.CheckBox checkBoxCezaliSozlesmeli;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtUYFno;
        private System.Windows.Forms.ComboBox cmbSatisSekli;
        private System.Windows.Forms.ComboBox cmbFaturaSekli;
        private System.Windows.Forms.ComboBox cmbMusteriKonumu;
        private System.Windows.Forms.TextBox txtMusteriTemsilcisi;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbMusteriYeniEski;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox mskTeslimTarihi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox mskSiparisTarihi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}