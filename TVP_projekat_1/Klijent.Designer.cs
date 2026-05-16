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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_korisnika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnicko_ime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrsta_korisnika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prethodna_izdavanja = new System.Windows.Forms.TabPage();
            this.detalji2 = new System.Windows.Forms.Panel();
            this.btn_pretrazi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_datum_vracanja_filtriraj = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_naziv_igrice_filtriraj = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Novo_izdavanje = new System.Windows.Forms.TabPage();
            this.btn_dodaj_igricu = new System.Windows.Forms.Button();
            this.lbl_datum_iznajmljivanja = new System.Windows.Forms.Label();
            this.dtp_datum_iznajmljivanja = new System.Windows.Forms.DateTimePicker();
            this.lbl_broj_dana = new System.Windows.Forms.Label();
            this.nud_broj_dana = new System.Windows.Forms.NumericUpDown();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.id_destinacije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drzava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.popust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.br_dana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uk_mesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum_polaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_filtriraj_igrice = new System.Windows.Forms.Button();
            this.cb_zanr = new System.Windows.Forms.ComboBox();
            this.lbl_naziv_igrice = new System.Windows.Forms.Label();
            this.tb_naziv_igrice = new System.Windows.Forms.TextBox();
            this.lbl_zanr = new System.Windows.Forms.Label();
            this.lbl_godina_izdavanja = new System.Windows.Forms.Label();
            this.tb_godina_izdavanja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Aktivna_izdavanja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Prethodna_izdavanja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Novo_izdavanje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_broj_dana)).BeginInit();
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
            this.Aktivna_izdavanja.Controls.Add(this.label1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "Ulogovani ste ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_korisnika,
            this.ime,
            this.prezime,
            this.korisnicko_ime1,
            this.lozinka,
            this.vrsta_korisnika});
            this.dataGridView1.Location = new System.Drawing.Point(11, 38);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(527, 168);
            this.dataGridView1.TabIndex = 51;
            // 
            // id_korisnika
            // 
            this.id_korisnika.DataPropertyName = "id_korisnika";
            this.id_korisnika.HeaderText = "id";
            this.id_korisnika.MinimumWidth = 6;
            this.id_korisnika.Name = "id_korisnika";
            this.id_korisnika.Width = 40;
            // 
            // ime
            // 
            this.ime.DataPropertyName = "ime";
            this.ime.HeaderText = "ime";
            this.ime.MinimumWidth = 6;
            this.ime.Name = "ime";
            this.ime.Width = 48;
            // 
            // prezime
            // 
            this.prezime.DataPropertyName = "prezime";
            this.prezime.HeaderText = "prezime";
            this.prezime.MinimumWidth = 6;
            this.prezime.Name = "prezime";
            this.prezime.Width = 68;
            // 
            // korisnicko_ime1
            // 
            this.korisnicko_ime1.DataPropertyName = "korisnicko_ime1";
            this.korisnicko_ime1.HeaderText = "korisnicko ime";
            this.korisnicko_ime1.MinimumWidth = 6;
            this.korisnicko_ime1.Name = "korisnicko_ime1";
            this.korisnicko_ime1.Width = 99;
            // 
            // lozinka
            // 
            this.lozinka.DataPropertyName = "lozinka";
            this.lozinka.HeaderText = "lozinka";
            this.lozinka.MinimumWidth = 6;
            this.lozinka.Name = "lozinka";
            this.lozinka.Width = 65;
            // 
            // vrsta_korisnika
            // 
            this.vrsta_korisnika.DataPropertyName = "vrsta_korisnika";
            this.vrsta_korisnika.HeaderText = "vrsta";
            this.vrsta_korisnika.MinimumWidth = 6;
            this.vrsta_korisnika.Name = "vrsta_korisnika";
            this.vrsta_korisnika.Width = 55;
            // 
            // Prethodna_izdavanja
            // 
            this.Prethodna_izdavanja.Controls.Add(this.detalji2);
            this.Prethodna_izdavanja.Controls.Add(this.btn_pretrazi);
            this.Prethodna_izdavanja.Controls.Add(this.label4);
            this.Prethodna_izdavanja.Controls.Add(this.dtp_datum_vracanja_filtriraj);
            this.Prethodna_izdavanja.Controls.Add(this.label7);
            this.Prethodna_izdavanja.Controls.Add(this.tb_naziv_igrice_filtriraj);
            this.Prethodna_izdavanja.Controls.Add(this.label5);
            this.Prethodna_izdavanja.Controls.Add(this.dataGridView2);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 119;
            this.label5.Text = "Ulogovani ste ";
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
            this.dataGridViewTextBoxColumn6});
            this.dataGridView2.Location = new System.Drawing.Point(11, 38);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(527, 168);
            this.dataGridView2.TabIndex = 118;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_korisnika";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ime";
            this.dataGridViewTextBoxColumn2.HeaderText = "ime";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 48;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "prezime";
            this.dataGridViewTextBoxColumn3.HeaderText = "prezime";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 68;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "korisnicko_ime1";
            this.dataGridViewTextBoxColumn4.HeaderText = "korisnicko ime";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 99;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "lozinka";
            this.dataGridViewTextBoxColumn5.HeaderText = "lozinka";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 65;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "vrsta_korisnika";
            this.dataGridViewTextBoxColumn6.HeaderText = "vrsta";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 55;
            // 
            // Novo_izdavanje
            // 
            this.Novo_izdavanje.Controls.Add(this.btn_dodaj_igricu);
            this.Novo_izdavanje.Controls.Add(this.lbl_datum_iznajmljivanja);
            this.Novo_izdavanje.Controls.Add(this.dtp_datum_iznajmljivanja);
            this.Novo_izdavanje.Controls.Add(this.lbl_broj_dana);
            this.Novo_izdavanje.Controls.Add(this.nud_broj_dana);
            this.Novo_izdavanje.Controls.Add(this.dataGridView3);
            this.Novo_izdavanje.Controls.Add(this.btn_filtriraj_igrice);
            this.Novo_izdavanje.Controls.Add(this.cb_zanr);
            this.Novo_izdavanje.Controls.Add(this.lbl_naziv_igrice);
            this.Novo_izdavanje.Controls.Add(this.tb_naziv_igrice);
            this.Novo_izdavanje.Controls.Add(this.lbl_zanr);
            this.Novo_izdavanje.Controls.Add(this.lbl_godina_izdavanja);
            this.Novo_izdavanje.Controls.Add(this.tb_godina_izdavanja);
            this.Novo_izdavanje.Controls.Add(this.label2);
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
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_destinacije,
            this.mesto,
            this.drzava,
            this.cena,
            this.popust,
            this.br_dana,
            this.uk_mesta,
            this.datum_polaska});
            this.dataGridView3.Location = new System.Drawing.Point(11, 38);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(527, 168);
            this.dataGridView3.TabIndex = 129;
            // 
            // id_destinacije
            // 
            this.id_destinacije.DataPropertyName = "id_destinacije";
            this.id_destinacije.HeaderText = "id";
            this.id_destinacije.MinimumWidth = 6;
            this.id_destinacije.Name = "id_destinacije";
            this.id_destinacije.Width = 40;
            // 
            // mesto
            // 
            this.mesto.DataPropertyName = "mesto";
            this.mesto.HeaderText = "mesto";
            this.mesto.MinimumWidth = 6;
            this.mesto.Name = "mesto";
            this.mesto.Width = 60;
            // 
            // drzava
            // 
            this.drzava.DataPropertyName = "drzava";
            this.drzava.HeaderText = "drzava";
            this.drzava.MinimumWidth = 6;
            this.drzava.Name = "drzava";
            this.drzava.Width = 64;
            // 
            // cena
            // 
            this.cena.DataPropertyName = "cena";
            this.cena.HeaderText = "cena";
            this.cena.MinimumWidth = 6;
            this.cena.Name = "cena";
            this.cena.Width = 56;
            // 
            // popust
            // 
            this.popust.DataPropertyName = "popust";
            this.popust.HeaderText = "popust";
            this.popust.MinimumWidth = 6;
            this.popust.Name = "popust";
            this.popust.Width = 64;
            // 
            // br_dana
            // 
            this.br_dana.DataPropertyName = "br_dana";
            this.br_dana.HeaderText = "broj dana";
            this.br_dana.MinimumWidth = 6;
            this.br_dana.Name = "br_dana";
            this.br_dana.Width = 76;
            // 
            // uk_mesta
            // 
            this.uk_mesta.DataPropertyName = "uk_mesta";
            this.uk_mesta.HeaderText = "ukupno mesta";
            this.uk_mesta.MinimumWidth = 6;
            this.uk_mesta.Name = "uk_mesta";
            this.uk_mesta.Width = 99;
            // 
            // datum_polaska
            // 
            this.datum_polaska.DataPropertyName = "datum_polaska";
            this.datum_polaska.HeaderText = "datum";
            this.datum_polaska.MinimumWidth = 6;
            this.datum_polaska.Name = "datum_polaska";
            this.datum_polaska.Width = 61;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 120;
            this.label2.Text = "Ulogovani ste ";
            // 
            // Klijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 476);
            this.Controls.Add(this.tabControl1);
            this.Name = "Klijent";
            this.Text = "Klijent";
            this.tabControl1.ResumeLayout(false);
            this.Aktivna_izdavanja.ResumeLayout(false);
            this.Aktivna_izdavanja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Prethodna_izdavanja.ResumeLayout(false);
            this.Prethodna_izdavanja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Novo_izdavanje.ResumeLayout(false);
            this.Novo_izdavanje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_broj_dana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Aktivna_izdavanja;
        private System.Windows.Forms.TabPage Prethodna_izdavanja;
        private System.Windows.Forms.TabPage Novo_izdavanje;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_korisnika;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnicko_ime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinka;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrsta_korisnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_izmeni_izdavanje;
        private System.Windows.Forms.Button btn_obrisi_izdavanje;
        private System.Windows.Forms.Label lbl_datum_vracanja;
        private System.Windows.Forms.DateTimePicker dtp_datum_vracanja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_godina_izdavanja;
        private System.Windows.Forms.TextBox tb_godina_izdavanja;
        private System.Windows.Forms.Label lbl_zanr;
        private System.Windows.Forms.Button btn_filtriraj_igrice;
        private System.Windows.Forms.ComboBox cb_zanr;
        private System.Windows.Forms.Label lbl_naziv_igrice;
        private System.Windows.Forms.TextBox tb_naziv_igrice;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_destinacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn drzava;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn popust;
        private System.Windows.Forms.DataGridViewTextBoxColumn br_dana;
        private System.Windows.Forms.DataGridViewTextBoxColumn uk_mesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum_polaska;
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
    }
}