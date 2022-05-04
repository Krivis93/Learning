namespace FilmBook
{
    partial class DodawanieKsiazki
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tytul = new System.Windows.Forms.TextBox();
            this.Rok = new System.Windows.Forms.TextBox();
            this.OpisKsiazki = new System.Windows.Forms.TextBox();
            this.RecenzjaKsiazki = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ZnakiOpisK = new System.Windows.Forms.Label();
            this.ZnakiRecenzjaK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tytul
            // 
            this.Tytul.Location = new System.Drawing.Point(239, 88);
            this.Tytul.Name = "Tytul";
            this.Tytul.Size = new System.Drawing.Size(150, 20);
            this.Tytul.TabIndex = 0;
            // 
            // Rok
            // 
            this.Rok.Location = new System.Drawing.Point(239, 175);
            this.Rok.Name = "Rok";
            this.Rok.Size = new System.Drawing.Size(150, 20);
            this.Rok.TabIndex = 1;
            // 
            // OpisKsiazki
            // 
            this.OpisKsiazki.Location = new System.Drawing.Point(239, 247);
            this.OpisKsiazki.Multiline = true;
            this.OpisKsiazki.Name = "OpisKsiazki";
            this.OpisKsiazki.Size = new System.Drawing.Size(150, 60);
            this.OpisKsiazki.TabIndex = 2;
            this.OpisKsiazki.TextChanged += new System.EventHandler(this.OpisKsiazki_TextChanged);
            // 
            // RecenzjaKsiazki
            // 
            this.RecenzjaKsiazki.Location = new System.Drawing.Point(239, 325);
            this.RecenzjaKsiazki.Multiline = true;
            this.RecenzjaKsiazki.Name = "RecenzjaKsiazki";
            this.RecenzjaKsiazki.Size = new System.Drawing.Size(150, 60);
            this.RecenzjaKsiazki.TabIndex = 3;
            this.RecenzjaKsiazki.TextChanged += new System.EventHandler(this.RecenzjaKsiazki_TextCganged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(144, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tytuł Książki :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(102, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rok wydania książki :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(75, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Krótki opis(2000 znaków) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(46, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Krótka recenzja(2000 znaków) :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(185, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ZnakiOpisK
            // 
            this.ZnakiOpisK.AutoSize = true;
            this.ZnakiOpisK.Location = new System.Drawing.Point(454, 266);
            this.ZnakiOpisK.Name = "ZnakiOpisK";
            this.ZnakiOpisK.Size = new System.Drawing.Size(77, 13);
            this.ZnakiOpisK.TabIndex = 9;
            this.ZnakiOpisK.Text = "Użyte znaki : 0";
            // 
            // ZnakiRecenzjaK
            // 
            this.ZnakiRecenzjaK.AutoSize = true;
            this.ZnakiRecenzjaK.Location = new System.Drawing.Point(454, 353);
            this.ZnakiRecenzjaK.Name = "ZnakiRecenzjaK";
            this.ZnakiRecenzjaK.Size = new System.Drawing.Size(77, 13);
            this.ZnakiRecenzjaK.TabIndex = 10;
            this.ZnakiRecenzjaK.Text = "Użyte znaki : 0";
            // 
            // DodawanieKsiazki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ZnakiRecenzjaK);
            this.Controls.Add(this.ZnakiOpisK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecenzjaKsiazki);
            this.Controls.Add(this.OpisKsiazki);
            this.Controls.Add(this.Rok);
            this.Controls.Add(this.Tytul);
            this.Name = "DodawanieKsiazki";
            this.Size = new System.Drawing.Size(600, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tytul;
        private System.Windows.Forms.TextBox Rok;
        private System.Windows.Forms.TextBox OpisKsiazki;
        private System.Windows.Forms.TextBox RecenzjaKsiazki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ZnakiOpisK;
        private System.Windows.Forms.Label ZnakiRecenzjaK;
    }
}
