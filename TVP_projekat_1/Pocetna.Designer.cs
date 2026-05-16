namespace TVP_projekat_1
{
    partial class Pocetna
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
            this.izlaz = new System.Windows.Forms.Button();
            this.prijava = new System.Windows.Forms.Button();
            this.tb_lozinka = new System.Windows.Forms.TextBox();
            this.tb_korisnicko_ime = new System.Windows.Forms.TextBox();
            this.lbl_lozinka = new System.Windows.Forms.Label();
            this.lbl_korisnicko_ime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // izlaz
            // 
            this.izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izlaz.Location = new System.Drawing.Point(16, 204);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(100, 40);
            this.izlaz.TabIndex = 23;
            this.izlaz.Text = "Izadji";
            this.izlaz.UseVisualStyleBackColor = true;
            // 
            // prijava
            // 
            this.prijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prijava.Location = new System.Drawing.Point(16, 158);
            this.prijava.Name = "prijava";
            this.prijava.Size = new System.Drawing.Size(100, 40);
            this.prijava.TabIndex = 22;
            this.prijava.Text = "Prijavi se";
            this.prijava.UseVisualStyleBackColor = true;
            // 
            // tb_lozinka
            // 
            this.tb_lozinka.Location = new System.Drawing.Point(16, 114);
            this.tb_lozinka.Name = "tb_lozinka";
            this.tb_lozinka.PasswordChar = '*';
            this.tb_lozinka.Size = new System.Drawing.Size(100, 20);
            this.tb_lozinka.TabIndex = 21;
            // 
            // tb_korisnicko_ime
            // 
            this.tb_korisnicko_ime.Location = new System.Drawing.Point(16, 66);
            this.tb_korisnicko_ime.Name = "tb_korisnicko_ime";
            this.tb_korisnicko_ime.Size = new System.Drawing.Size(100, 20);
            this.tb_korisnicko_ime.TabIndex = 20;
            this.tb_korisnicko_ime.Tag = "";
            // 
            // lbl_lozinka
            // 
            this.lbl_lozinka.AutoSize = true;
            this.lbl_lozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lozinka.Location = new System.Drawing.Point(12, 95);
            this.lbl_lozinka.Name = "lbl_lozinka";
            this.lbl_lozinka.Size = new System.Drawing.Size(53, 16);
            this.lbl_lozinka.TabIndex = 19;
            this.lbl_lozinka.Text = "Lozinka";
            // 
            // lbl_korisnicko_ime
            // 
            this.lbl_korisnicko_ime.AutoSize = true;
            this.lbl_korisnicko_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_korisnicko_ime.Location = new System.Drawing.Point(12, 48);
            this.lbl_korisnicko_ime.Name = "lbl_korisnicko_ime";
            this.lbl_korisnicko_ime.Size = new System.Drawing.Size(94, 16);
            this.lbl_korisnicko_ime.TabIndex = 18;
            this.lbl_korisnicko_ime.Text = "Korisnicko ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Dobrodisli, unesite potrebne podatke";
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.prijava);
            this.Controls.Add(this.tb_lozinka);
            this.Controls.Add(this.tb_korisnicko_ime);
            this.Controls.Add(this.lbl_lozinka);
            this.Controls.Add(this.lbl_korisnicko_ime);
            this.Controls.Add(this.label1);
            this.Name = "Pocetna";
            this.Text = "Pocetna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button izlaz;
        private System.Windows.Forms.Button prijava;
        private System.Windows.Forms.TextBox tb_lozinka;
        private System.Windows.Forms.TextBox tb_korisnicko_ime;
        private System.Windows.Forms.Label lbl_lozinka;
        private System.Windows.Forms.Label lbl_korisnicko_ime;
        private System.Windows.Forms.Label label1;
    }
}

