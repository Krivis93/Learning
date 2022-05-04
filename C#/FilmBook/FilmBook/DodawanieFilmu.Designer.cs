namespace FilmBook
{
    partial class DodawanieFilmu
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RecenzjaFilm = new System.Windows.Forms.TextBox();
            this.OpisFilm = new System.Windows.Forms.TextBox();
            this.Rok = new System.Windows.Forms.TextBox();
            this.Tytul = new System.Windows.Forms.TextBox();
            this.ZnakiOpisF = new System.Windows.Forms.Label();
            this.ZnakiRecenzjaF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(188, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(49, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Krótka recenzja(2000 znaków) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(78, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Krótki opis(2000 znaków) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(105, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rok wydania Filmu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(147, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tytuł Filmu :";
            // 
            // RecenzjaFilm
            // 
            this.RecenzjaFilm.Location = new System.Drawing.Point(242, 295);
            this.RecenzjaFilm.Multiline = true;
            this.RecenzjaFilm.Name = "RecenzjaFilm";
            this.RecenzjaFilm.Size = new System.Drawing.Size(150, 60);
            this.RecenzjaFilm.TabIndex = 12;
            this.RecenzjaFilm.TextChanged += new System.EventHandler(this.RecenzjaFilm_TextChanged);
            // 
            // OpisFilm
            // 
            this.OpisFilm.Location = new System.Drawing.Point(242, 217);
            this.OpisFilm.Multiline = true;
            this.OpisFilm.Name = "OpisFilm";
            this.OpisFilm.Size = new System.Drawing.Size(150, 60);
            this.OpisFilm.TabIndex = 11;
            this.OpisFilm.TextChanged += new System.EventHandler(this.OpisFilm_TextChanged);
            // 
            // Rok
            // 
            this.Rok.Location = new System.Drawing.Point(242, 145);
            this.Rok.Name = "Rok";
            this.Rok.Size = new System.Drawing.Size(150, 20);
            this.Rok.TabIndex = 10;
            // 
            // Tytul
            // 
            this.Tytul.Location = new System.Drawing.Point(242, 58);
            this.Tytul.Name = "Tytul";
            this.Tytul.Size = new System.Drawing.Size(150, 20);
            this.Tytul.TabIndex = 9;
            // 
            // ZnakiOpisF
            // 
            this.ZnakiOpisF.AutoSize = true;
            this.ZnakiOpisF.Location = new System.Drawing.Point(454, 248);
            this.ZnakiOpisF.Name = "ZnakiOpisF";
            this.ZnakiOpisF.Size = new System.Drawing.Size(79, 13);
            this.ZnakiOpisF.TabIndex = 18;
            this.ZnakiOpisF.Text = "Użyte Znaki : 0";
            // 
            // ZnakiRecenzjaF
            // 
            this.ZnakiRecenzjaF.AutoSize = true;
            this.ZnakiRecenzjaF.Location = new System.Drawing.Point(454, 317);
            this.ZnakiRecenzjaF.Name = "ZnakiRecenzjaF";
            this.ZnakiRecenzjaF.Size = new System.Drawing.Size(79, 13);
            this.ZnakiRecenzjaF.TabIndex = 19;
            this.ZnakiRecenzjaF.Text = "Użyte Znaki : 0";
            // 
            // DodawanieFilmu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ZnakiRecenzjaF);
            this.Controls.Add(this.ZnakiOpisF);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecenzjaFilm);
            this.Controls.Add(this.OpisFilm);
            this.Controls.Add(this.Rok);
            this.Controls.Add(this.Tytul);
            this.Name = "DodawanieFilmu";
            this.Size = new System.Drawing.Size(600, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RecenzjaFilm;
        private System.Windows.Forms.TextBox OpisFilm;
        private System.Windows.Forms.TextBox Rok;
        private System.Windows.Forms.TextBox Tytul;
        private System.Windows.Forms.Label ZnakiOpisF;
        private System.Windows.Forms.Label ZnakiRecenzjaF;
    }
}
