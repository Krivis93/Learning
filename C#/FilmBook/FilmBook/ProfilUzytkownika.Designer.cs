namespace FilmBook
{
    partial class ProfilUzytkownika
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
            this.WidokTabeli = new System.Windows.Forms.DataGridView();
            this.Ksiazki = new System.Windows.Forms.Button();
            this.Filmy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WidokTabeli)).BeginInit();
            this.SuspendLayout();
            // 
            // WidokTabeli
            // 
            this.WidokTabeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WidokTabeli.Location = new System.Drawing.Point(41, 124);
            this.WidokTabeli.Name = "WidokTabeli";
            this.WidokTabeli.Size = new System.Drawing.Size(495, 342);
            this.WidokTabeli.TabIndex = 0;
            // 
            // Ksiazki
            // 
            this.Ksiazki.Location = new System.Drawing.Point(62, 46);
            this.Ksiazki.Name = "Ksiazki";
            this.Ksiazki.Size = new System.Drawing.Size(105, 35);
            this.Ksiazki.TabIndex = 1;
            this.Ksiazki.Text = "Pokaż moje książki";
            this.Ksiazki.UseVisualStyleBackColor = true;
            this.Ksiazki.Click += new System.EventHandler(this.Ksiazki_Click);
            // 
            // Filmy
            // 
            this.Filmy.Location = new System.Drawing.Point(395, 46);
            this.Filmy.Name = "Filmy";
            this.Filmy.Size = new System.Drawing.Size(105, 35);
            this.Filmy.TabIndex = 2;
            this.Filmy.Text = "Pokaż moje filmy";
            this.Filmy.UseVisualStyleBackColor = true;
            this.Filmy.Click += new System.EventHandler(this.Filmy_Click);
            // 
            // ProfilUzytkownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Filmy);
            this.Controls.Add(this.Ksiazki);
            this.Controls.Add(this.WidokTabeli);
            this.Name = "ProfilUzytkownika";
            this.Size = new System.Drawing.Size(600, 500);
            ((System.ComponentModel.ISupportInitialize)(this.WidokTabeli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView WidokTabeli;
        private System.Windows.Forms.Button Ksiazki;
        private System.Windows.Forms.Button Filmy;
    }
}
