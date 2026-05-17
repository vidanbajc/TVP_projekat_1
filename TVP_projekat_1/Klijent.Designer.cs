namespace TVP_projekat_1
{
    partial class Klijent
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Aktivna_izdavanja = new System.Windows.Forms.TabPage();
            this.detalji1 = new System.Windows.Forms.Panel();
            this.lbl_datum_vracanja = new System.Windows.Forms.Label();
            this.dtp_datum_vracanja = new System.Windows.Forms.DateTimePicker();
            this.btn_obrisi_izdavanje = new System.Windows.Forms.Button();
            this.btn_izmeni_izdavanje = new System.Windows.Forms.Button();
            this.lbl_korisnik1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Prethodna_izdavanja = new System.Windows.Forms.TabPage();
            this.detalji2 = new System.Windows.Forms.Panel();
            this.btn_pretrazi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_datum_vracanja_filtriraj = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_naziv_igrice_filtriraj = new System.Windows.Forms.TextBox();
            this.lbl_korisnik2 = new System.Windows.Forms.Label();
            this.Novo_izdavanje = new System.Windows.Forms.TabPage();
            this.btn_dodaj_igricu = new System.Windows.Forms.Button();
            this.lbl_datum_iznajmljivanja = new System.Windows.Forms.Label();
            this.dtp_datum_iznajmljivanja = new System.Windows.Forms.DateTimePicker();
            this.lbl_broj_dana = new System.Windows.Forms.Label();
            this.nud_broj_dana = new System.Windows.Forms.NumericUpDown();
            this.btn_filtriraj_igrice = new System.Windows.Forms.Button();
            this.cb_zanr = new System.Windows.Forms.ComboBox();
            this.lbl_naziv_igrice = new System.Windows.Forms.Label();
            this.tb_naziv_igrice = new System.Windows.Forms.TextBox();
            this.lbl_zanr = new System.Windows.Forms.Label();
            this.lbl_godina_izdavanja = new System.Windows.Forms.Label();
            this.tb_godina_izdavanja = new System.Windows.Forms.TextBox();
            this.lbl_korisnik3 = new System.Windows.Forms.Label();
            this.naziv_igrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv_studija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zanr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godina_izdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum_izdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum_vracanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupna_cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena_izdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.broj_dostupnih_primeraka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starosna_granica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.Aktivna_izdavanja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Prethodna_izdavanja.SuspendLayout();
            this.Novo_izdavanje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_broj_dana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Aktivna_izdavanja);
            this.tabControl1.Controls.Add(this.Prethodna_izdavanja);
            this.tabControl1.Controls.Add(this.Novo_izdavanje);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(564, 476);
            this.tabControl1.TabIndex = 0;
            // 
            // Aktivna_izdavanja
            // 
            this.Aktivna_izdavanja.Controls.Add(this.detalji1);
            this.Aktivna_izdavanja.Controls.Add(this.lbl_datum_vracanja);
            this.Aktivna_izdavanja.Controls.Add(this.dtp_datum_vracanja);
            this.Aktivna_izdavanja.Controls.Add(this.btn_obrisi_izdavanje);
            this.Aktivna_izdavanja.Controls.Add(this.btn_izmeni_izdavanje);
            this.Aktivna_izdavanja.Controls.Add(this.lbl_korisnik1);
            this.Aktivna_izdavanja.Controls.Add(this.dataGridView1);
            this.Aktivna_izdavanja.Location = new System.Drawing.Point(4, 22);
            this.Aktivna_izdavanja.Name = "Aktivna_izdavanja";
            this.Aktivna_izdavanja.Padding = new System.Windows.Forms.Padding(3);
            this.Aktivna_izdavanja.Size = new System.Drawing.Size(556, 450);
            this.Aktivna_izdavanja.TabIndex = 0;
            this.Aktivna_izdavanja.Text = "Aktivna izdavanja";
            this.Aktivna_izdavanja.UseVisualStyleBackColor = true;
            // 
            // detalji1
            // 
            this.detalji1.Location = new System.Drawing.Point(305, 217);
            this.detalji1.Name = "detalji1";
            this.detalji1.Size = new System.Drawing.Size(233, 227);
            this.detalji1.TabIndex = 118;
            // 
            // lbl_datum_vracanja
            // 
            this.lbl_datum_vracanja.AutoSize = true;
            this.lbl_datum_vracanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datum_vracanja.Location = new System.Drawing.Point(8, 217);
            this.lbl_datum_vracanja.Name = "lbl_datum_vracanja";
            this.lbl_datum_vracanja.Size = new System.Drawing.Size(99, 16);
            this.lbl_datum_vracanja.TabIndex = 117;
            this.lbl_datum_vracanja.Text = "datum vracanja";
            // 
            // dtp_datum_vracanja
            // 
            this.dtp_datum_vracanja.CustomFormat = "dd.MM.yyyy";
            this.dtp_datum_vracanja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_datum_vracanja.Location = new System.Drawing.Point(11, 236);
            this.dtp_datum_vracanja.Name = "dtp_datum_vracanja";
            this.dtp_datum_vracanja.Size = new System.Drawing.Size(100, 20);
            this.dtp_datum_vracanja.TabIndex = 116;
            // 
            // btn_obrisi_izdavanje
            // 
            this.btn_obrisi_izdavanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_obrisi_izdavanje.Location = new System.Drawing.Point(11, 308);
            this.btn_obrisi_izdavanje.Name = "btn_obrisi_izdavanje";
            this.btn_obrisi_izdavanje.Size = new System.Drawing.Size(100, 40);
            this.btn_obrisi_izdavanje.TabIndex = 55;
            this.btn_obrisi_izdavanje.Text = "Obrisi";
            this.btn_obrisi_izdavanje.UseVisualStyleBackColor = true;
            // 
            // btn_izmeni_izdavanje
            // 
            this.btn_izmeni_izdavanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izmeni_izdavanje.Location = new System.Drawing.Point(11, 262);
            this.btn_izmeni_izdavanje.Name = "btn_izmeni_izdavanje";
            this.btn_izmeni_izdavanje.Size = new System.Drawing.Size(100, 40);
            this.btn_izmeni_izdavanje.TabIndex = 54;
            this.btn_izmeni_izdavanje.Text = "Izmeni";
            this.btn_izmeni_izdavanje.UseVisualStyleBackColor = true;
            // 
            // lbl_korisnik1
            // 
            this.lbl_korisnik1.AutoSize = true;
            this.lbl_korisnik1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_korisnik1.Location = new System.Drawing.Point(7, 11);
            this.lbl_korisnik1.Name = "lbl_korisnik1";
            this.lbl_korisnik1.Size = new System.Drawing.Size(142, 24);
            this.lbl_korisnik1.TabIndex = 52;
            this.lbl_korisnik1.Text = "Ulogovani ste ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naziv_igrice,
            this.naziv_studija,
            this.zanr,
            this.godina_izdavanja,
            this.platforma,
            this.opis,
            this.datum_izdavanja,
            this.datum_vracanja,
            this.ukupna_cena});
            this.dataGridView1.Location = new System.Drawing.Point(11, 38);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(527, 168);
            this.dataGridView1.TabIndex = 51;
            // 
            // Prethodna_izdavanja
            // 
            this.Prethodna_izdavanja.Controls.Add(this.dataGridView2);
            this.Prethodna_izdavanja.Controls.Add(this.detalji2);
            this.Prethodna_izdavanja.Controls.Add(this.btn_pretrazi);
            this.Prethodna_izdavanja.Controls.Add(this.label4);
            this.Prethodna_izdavanja.Controls.Add(this.dtp_datum_vracanja_filtriraj);
            this.Prethodna_izdavanja.Controls.Add(this.label7);
            this.Prethodna_izdavanja.Controls.Add(this.tb_naziv_igrice_filtriraj);
            this.Prethodna_izdavanja.Controls.Add(this.lbl_korisnik2);
            this.Prethodna_izdavanja.Location = new System.Drawing.Point(4, 22);
            this.Prethodna_izdavanja.Name = "Prethodna_izdavanja";
            this.Prethodna_izdavanja.Padding = new System.Windows.Forms.Padding(3);
            this.Prethodna_izdavanja.Size = new System.Drawing.Size(556, 450);
            this.Prethodna_izdavanja.TabIndex = 1;
            this.Prethodna_izdavanja.Text = "Prethodna izdavanja";
            this.Prethodna_izdavanja.UseVisualStyleBackColor = true;
            // 
            // detalji2
            // 
            this.detalji2.Location = new System.Drawing.Point(305, 215);
            this.detalji2.Name = "detalji2";
            this.detalji2.Size = new System.Drawing.Size(233, 227);
            this.detalji2.TabIndex = 129;
            // 
            // btn_pretrazi
            // 
            this.btn_pretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pretrazi.Location = new System.Drawing.Point(11, 315);
            this.btn_pretrazi.Name = "btn_pretrazi";
            this.btn_pretrazi.Size = new System.Drawing.Size(100, 40);
            this.btn_pretrazi.TabIndex = 128;
            this.btn_pretrazi.Text = "Pretrazi";
            this.btn_pretrazi.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 127;
            this.label4.Text = "datum vracanja";
            // 
            // dtp_datum_vracanja_filtriraj
            // 
            this.dtp_datum_vracanja_filtriraj.CustomFormat = "dd.MM.yyyy";
            this.dtp_datum_vracanja_filtriraj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_datum_vracanja_filtriraj.Location = new System.Drawing.Point(11, 280);
            this.dtp_datum_vracanja_filtriraj.Name = "dtp_datum_vracanja_filtriraj";
            this.dtp_datum_vracanja_filtriraj.Size = new System.Drawing.Size(100, 20);
            this.dtp_datum_vracanja_filtriraj.TabIndex = 126;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 125;
            this.label7.Text = "naziv igrice";
            // 
            // tb_naziv_igrice_filtriraj
            // 
            this.tb_naziv_igrice_filtriraj.Location = new System.Drawing.Point(11, 238);
            this.tb_naziv_igrice_filtriraj.Name = "tb_naziv_igrice_filtriraj";
            this.tb_naziv_igrice_filtriraj.Size = new System.Drawing.Size(100, 20);
            this.tb_naziv_igrice_filtriraj.TabIndex = 121;
            // 
            // lbl_korisnik2
            // 
            this.lbl_korisnik2.AutoSize = true;
            this.lbl_korisnik2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_korisnik2.Location = new System.Drawing.Point(7, 11);
            this.lbl_korisnik2.Name = "lbl_korisnik2";
            this.lbl_korisnik2.Size = new System.Drawing.Size(142, 24);
            this.lbl_korisnik2.TabIndex = 119;
            this.lbl_korisnik2.Text = "Ulogovani ste ";
            // 
            // Novo_izdavanje
            // 
            this.Novo_izdavanje.Controls.Add(this.dataGridView3);
            this.Novo_izdavanje.Controls.Add(this.btn_dodaj_igricu);
            this.Novo_izdavanje.Controls.Add(this.lbl_datum_iznajmljivanja);
            this.Novo_izdavanje.Controls.Add(this.dtp_datum_iznajmljivanja);
            this.Novo_izdavanje.Controls.Add(this.lbl_broj_dana);
            this.Novo_izdavanje.Controls.Add(this.nud_broj_dana);
            this.Novo_izdavanje.Controls.Add(this.btn_filtriraj_igrice);
            this.Novo_izdavanje.Controls.Add(this.cb_zanr);
            this.Novo_izdavanje.Controls.Add(this.lbl_naziv_igrice);
            this.Novo_izdavanje.Controls.Add(this.tb_naziv_igrice);
            this.Novo_izdavanje.Controls.Add(this.lbl_zanr);
            this.Novo_izdavanje.Controls.Add(this.lbl_godina_izdavanja);
            this.Novo_izdavanje.Controls.Add(this.tb_godina_izdavanja);
            this.Novo_izdavanje.Controls.Add(this.lbl_korisnik3);
            this.Novo_izdavanje.Location = new System.Drawing.Point(4, 22);
            this.Novo_izdavanje.Name = "Novo_izdavanje";
            this.Novo_izdavanje.Size = new System.Drawing.Size(556, 450);
            this.Novo_izdavanje.TabIndex = 2;
            this.Novo_izdavanje.Text = "Novo izdavanje";
            this.Novo_izdavanje.UseVisualStyleBackColor = true;
            // 
            // btn_dodaj_igricu
            // 
            this.btn_dodaj_igricu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dodaj_igricu.Location = new System.Drawing.Point(149, 341);
            this.btn_dodaj_igricu.Name = "btn_dodaj_igricu";
            this.btn_dodaj_igricu.Size = new System.Drawing.Size(100, 40);
            this.btn_dodaj_igricu.TabIndex = 134;
            this.btn_dodaj_igricu.Text = "Dodaj";
            this.btn_dodaj_igricu.UseVisualStyleBackColor = true;
            // 
            // lbl_datum_iznajmljivanja
            // 
            this.lbl_datum_iznajmljivanja.AutoSize = true;
            this.lbl_datum_iznajmljivanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datum_iznajmljivanja.Location = new System.Drawing.Point(146, 217);
            this.lbl_datum_iznajmljivanja.Name = "lbl_datum_iznajmljivanja";
            this.lbl_datum_iznajmljivanja.Size = new System.Drawing.Size(127, 16);
            this.lbl_datum_iznajmljivanja.TabIndex = 133;
            this.lbl_datum_iznajmljivanja.Text = "datum iznajmljivanja";
            // 
            // dtp_datum_iznajmljivanja
            // 
            this.dtp_datum_iznajmljivanja.CustomFormat = "dd.MM.yyyy";
            this.dtp_datum_iznajmljivanja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_datum_iznajmljivanja.Location = new System.Drawing.Point(149, 236);
            this.dtp_datum_iznajmljivanja.Name = "dtp_datum_iznajmljivanja";
            this.dtp_datum_iznajmljivanja.Size = new System.Drawing.Size(100, 20);
            this.dtp_datum_iznajmljivanja.TabIndex = 132;
            // 
            // lbl_broj_dana
            // 
            this.lbl_broj_dana.AutoSize = true;
            this.lbl_broj_dana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_broj_dana.Location = new System.Drawing.Point(146, 259);
            this.lbl_broj_dana.Name = "lbl_broj_dana";
            this.lbl_broj_dana.Size = new System.Drawing.Size(64, 16);
            this.lbl_broj_dana.TabIndex = 131;
            this.lbl_broj_dana.Text = "broj dana";
            // 
            // nud_broj_dana
            // 
            this.nud_broj_dana.Location = new System.Drawing.Point(149, 278);
            this.nud_broj_dana.Name = "nud_broj_dana";
            this.nud_broj_dana.Size = new System.Drawing.Size(49, 20);
            this.nud_broj_dana.TabIndex = 130;
            // 
            // btn_filtriraj_igrice
            // 
            this.btn_filtriraj_igrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtriraj_igrice.Location = new System.Drawing.Point(11, 341);
            this.btn_filtriraj_igrice.Name = "btn_filtriraj_igrice";
            this.btn_filtriraj_igrice.Size = new System.Drawing.Size(100, 40);
            this.btn_filtriraj_igrice.TabIndex = 128;
            this.btn_filtriraj_igrice.Text = "Filtriraj";
            this.btn_filtriraj_igrice.UseVisualStyleBackColor = true;
            // 
            // cb_zanr
            // 
            this.cb_zanr.FormattingEnabled = true;
            this.cb_zanr.Location = new System.Drawing.Point(11, 273);
            this.cb_zanr.Name = "cb_zanr";
            this.cb_zanr.Size = new System.Drawing.Size(100, 21);
            this.cb_zanr.TabIndex = 127;
            // 
            // lbl_naziv_igrice
            // 
            this.lbl_naziv_igrice.AutoSize = true;
            this.lbl_naziv_igrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_naziv_igrice.Location = new System.Drawing.Point(8, 215);
            this.lbl_naziv_igrice.Name = "lbl_naziv_igrice";
            this.lbl_naziv_igrice.Size = new System.Drawing.Size(74, 16);
            this.lbl_naziv_igrice.TabIndex = 126;
            this.lbl_naziv_igrice.Text = "naziv igrice";
            // 
            // tb_naziv_igrice
            // 
            this.tb_naziv_igrice.Location = new System.Drawing.Point(11, 234);
            this.tb_naziv_igrice.Name = "tb_naziv_igrice";
            this.tb_naziv_igrice.Size = new System.Drawing.Size(100, 20);
            this.tb_naziv_igrice.TabIndex = 125;
            // 
            // lbl_zanr
            // 
            this.lbl_zanr.AutoSize = true;
            this.lbl_zanr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zanr.Location = new System.Drawing.Point(8, 254);
            this.lbl_zanr.Name = "lbl_zanr";
            this.lbl_zanr.Size = new System.Drawing.Size(32, 16);
            this.lbl_zanr.TabIndex = 124;
            this.lbl_zanr.Text = "zanr";
            // 
            // lbl_godina_izdavanja
            // 
            this.lbl_godina_izdavanja.AutoSize = true;
            this.lbl_godina_izdavanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_godina_izdavanja.Location = new System.Drawing.Point(8, 296);
            this.lbl_godina_izdavanja.Name = "lbl_godina_izdavanja";
            this.lbl_godina_izdavanja.Size = new System.Drawing.Size(110, 16);
            this.lbl_godina_izdavanja.TabIndex = 122;
            this.lbl_godina_izdavanja.Text = "godina izdavanja";
            // 
            // tb_godina_izdavanja
            // 
            this.tb_godina_izdavanja.Location = new System.Drawing.Point(11, 315);
            this.tb_godina_izdavanja.Name = "tb_godina_izdavanja";
            this.tb_godina_izdavanja.Size = new System.Drawing.Size(100, 20);
            this.tb_godina_izdavanja.TabIndex = 121;
            // 
            // lbl_korisnik3
            // 
            this.lbl_korisnik3.AutoSize = true;
            this.lbl_korisnik3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_korisnik3.Location = new System.Drawing.Point(7, 11);
            this.lbl_korisnik3.Name = "lbl_korisnik3";
            this.lbl_korisnik3.Size = new System.Drawing.Size(142, 24);
            this.lbl_korisnik3.TabIndex = 120;
            this.lbl_korisnik3.Text = "Ulogovani ste ";
            // 
            // naziv_igrice
            // 
            this.naziv_igrice.DataPropertyName = "naziv_igrice";
            this.naziv_igrice.HeaderText = "naziv igrice";
            this.naziv_igrice.MinimumWidth = 6;
            this.naziv_igrice.Name = "naziv_igrice";
            this.naziv_igrice.Width = 85;
            // 
            // naziv_studija
            // 
            this.naziv_studija.DataPropertyName = "naziv_studija";
            this.naziv_studija.HeaderText = "naziv studija";
            this.naziv_studija.MinimumWidth = 6;
            this.naziv_studija.Name = "naziv_studija";
            this.naziv_studija.Width = 90;
            // 
            // zanr
            // 
            this.zanr.DataPropertyName = "zanr";
            this.zanr.HeaderText = "zanr";
            this.zanr.MinimumWidth = 6;
            this.zanr.Name = "zanr";
            this.zanr.Width = 52;
            // 
            // godina_izdavanja
            // 
            this.godina_izdavanja.DataPropertyName = "godina_izdavanja";
            this.godina_izdavanja.HeaderText = "godina izdavanja";
            this.godina_izdavanja.MinimumWidth = 6;
            this.godina_izdavanja.Name = "godina_izdavanja";
            this.godina_izdavanja.Width = 103;
            // 
            // platforma
            // 
            this.platforma.DataPropertyName = "platforma";
            this.platforma.HeaderText = "platforma";
            this.platforma.MinimumWidth = 6;
            this.platforma.Name = "platforma";
            this.platforma.Width = 75;
            // 
            // opis
            // 
            this.opis.DataPropertyName = "opis";
            this.opis.HeaderText = "opis";
            this.opis.MinimumWidth = 6;
            this.opis.Name = "opis";
            this.opis.Width = 51;
            // 
            // datum_izdavanja
            // 
            this.datum_izdavanja.DataPropertyName = "datum_izdavanja";
            this.datum_izdavanja.HeaderText = "datum izdavanja";
            this.datum_izdavanja.Name = "datum_izdavanja";
            // 
            // datum_vracanja
            // 
            this.datum_vracanja.DataPropertyName = "datum_vracanja";
            this.datum_vracanja.HeaderText = "datum vracanja";
            this.datum_vracanja.Name = "datum_vracanja";
            this.datum_vracanja.Width = 97;
            // 
            // ukupna_cena
            // 
            this.ukupna_cena.DataPropertyName = "ukupna_cena";
            this.ukupna_cena.HeaderText = "ukupna cena";
            this.ukupna_cena.Name = "ukupna_cena";
            this.ukupna_cena.Width = 88;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridView2.Location = new System.Drawing.Point(11, 38);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(527, 168);
            this.dataGridView2.TabIndex = 130;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "naziv_igrice";
            this.dataGridViewTextBoxColumn1.HeaderText = "naziv igrice";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 79;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "naziv_studija";
            this.dataGridViewTextBoxColumn2.HeaderText = "naziv studija";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 83;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "zanr";
            this.dataGridViewTextBoxColumn3.HeaderText = "zanr";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 52;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "godina_izdavanja";
            this.dataGridViewTextBoxColumn4.HeaderText = "godina izdavanja";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 103;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "platforma";
            this.dataGridViewTextBoxColumn5.HeaderText = "platforma";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "opis";
            this.dataGridViewTextBoxColumn6.HeaderText = "opis";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 51;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "datum_izdavanja";
            this.dataGridViewTextBoxColumn7.HeaderText = "datum izdavanja";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "datum_vracanja";
            this.dataGridViewTextBoxColumn8.HeaderText = "datum vracanja";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 97;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ukupna_cena";
            this.dataGridViewTextBoxColumn9.HeaderText = "ukupna cena";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 88;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.cena_izdavanja,
            this.broj_dostupnih_primeraka,
            this.starosna_granica});
            this.dataGridView3.Location = new System.Drawing.Point(11, 38);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(527, 168);
            this.dataGridView3.TabIndex = 135;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "naziv_igrice";
            this.dataGridViewTextBoxColumn10.HeaderText = "naziv igrice";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 85;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "naziv_studija";
            this.dataGridViewTextBoxColumn11.HeaderText = "naziv studija";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 90;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "zanr";
            this.dataGridViewTextBoxColumn12.HeaderText = "zanr";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 52;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "godina_izdavanja";
            this.dataGridViewTextBoxColumn13.HeaderText = "godina izdavanja";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 103;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "platforma";
            this.dataGridViewTextBoxColumn14.HeaderText = "platforma";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 75;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "opis";
            this.dataGridViewTextBoxColumn15.HeaderText = "opis";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 51;
            // 
            // cena_izdavanja
            // 
            this.cena_izdavanja.DataPropertyName = "cena_izdavanja";
            this.cena_izdavanja.HeaderText = "cena izdavanja";
            this.cena_izdavanja.MinimumWidth = 6;
            this.cena_izdavanja.Name = "cena_izdavanja";
            this.cena_izdavanja.Width = 96;
            // 
            // broj_dostupnih_primeraka
            // 
            this.broj_dostupnih_primeraka.DataPropertyName = "broj_dostupnih_primeraka";
            this.broj_dostupnih_primeraka.HeaderText = "broj dostupnih primeraka";
            this.broj_dostupnih_primeraka.Name = "broj_dostupnih_primeraka";
            this.broj_dostupnih_primeraka.Width = 134;
            // 
            // starosna_granica
            // 
            this.starosna_granica.DataPropertyName = "starosna_granica";
            this.starosna_granica.HeaderText = "starosna granica";
            this.starosna_granica.Name = "starosna_granica";
            this.starosna_granica.Width = 101;
            // 
            // Klijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 476);
            this.Controls.Add(this.tabControl1);
            this.Name = "Klijent";
            this.Text = "Klijent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Klijent_FormClosed);
            this.Load += new System.EventHandler(this.Klijent_Load);
            this.tabControl1.ResumeLayout(false);
            this.Aktivna_izdavanja.ResumeLayout(false);
            this.Aktivna_izdavanja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Prethodna_izdavanja.ResumeLayout(false);
            this.Prethodna_izdavanja.PerformLayout();
            this.Novo_izdavanje.ResumeLayout(false);
            this.Novo_izdavanje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_broj_dana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Aktivna_izdavanja;
        private System.Windows.Forms.TabPage Prethodna_izdavanja;
        private System.Windows.Forms.TabPage Novo_izdavanje;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_korisnik1;
        private System.Windows.Forms.Button btn_izmeni_izdavanje;
        private System.Windows.Forms.Button btn_obrisi_izdavanje;
        private System.Windows.Forms.Label lbl_datum_vracanja;
        private System.Windows.Forms.DateTimePicker dtp_datum_vracanja;
        private System.Windows.Forms.Label lbl_korisnik2;
        private System.Windows.Forms.Label lbl_korisnik3;
        private System.Windows.Forms.Label lbl_godina_izdavanja;
        private System.Windows.Forms.TextBox tb_godina_izdavanja;
        private System.Windows.Forms.Label lbl_zanr;
        private System.Windows.Forms.Button btn_filtriraj_igrice;
        private System.Windows.Forms.ComboBox cb_zanr;
        private System.Windows.Forms.Label lbl_naziv_igrice;
        private System.Windows.Forms.TextBox tb_naziv_igrice;
        private System.Windows.Forms.Label lbl_broj_dana;
        private System.Windows.Forms.NumericUpDown nud_broj_dana;
        private System.Windows.Forms.Label lbl_datum_iznajmljivanja;
        private System.Windows.Forms.DateTimePicker dtp_datum_iznajmljivanja;
        private System.Windows.Forms.Button btn_dodaj_igricu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_naziv_igrice_filtriraj;
        private System.Windows.Forms.Button btn_pretrazi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_datum_vracanja_filtriraj;
        private System.Windows.Forms.Panel detalji1;
        private System.Windows.Forms.Panel detalji2;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv_igrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv_studija;
        private System.Windows.Forms.DataGridViewTextBoxColumn zanr;
        private System.Windows.Forms.DataGridViewTextBoxColumn godina_izdavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn platforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum_izdavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum_vracanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupna_cena;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena_izdavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn broj_dostupnih_primeraka;
        private System.Windows.Forms.DataGridViewTextBoxColumn starosna_granica;
    }
}