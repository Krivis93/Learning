namespace FilmBook
{
    partial class DodajFilmDoProfilu
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
            this.Lista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ocena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Odswiez = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(259, 42);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(137, 21);
            this.Lista.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wybierz Film z listy :";
            // 
            // Ocena
            // 
            this.Ocena.Location = new System.Drawing.Point(139, 461);
            this.Ocena.Name = "Ocena";
            this.Ocena.Size = new System.Drawing.Size(40, 20);
            this.Ocena.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(40, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Oceń film(1-10)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 53);
            this.button1.TabIndex = 9;
            this.button1.Text = "Dodaj film do profilu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Odswiez
            // 
            this.Odswiez.Location = new System.Drawing.Point(467, 32);
            this.Odswiez.Name = "Odswiez";
            this.Odswiez.Size = new System.Drawing.Size(81, 38);
            this.Odswiez.TabIndex = 12;
            this.Odswiez.Text = "Odśwież listę filmów";
            this.Odswiez.UseVisualStyleBackColor = true;
            this.Odswiez.Click += new System.EventHandler(this.Odswiez_Click);
            // 
            // DodajFilmDoProfilu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Odswiez);
            this.Controls.Add(this.Ocena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lista);
            this.Name = "DodajFilmDoProfilu";
            this.Size = new System.Drawing.Size(600, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Lista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ocena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Odswiez;
    }
}
