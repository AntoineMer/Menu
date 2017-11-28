namespace Menu
{
    partial class CheckBoxEtRadioBoutons
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextModif = new System.Windows.Forms.Label();
            this.CouleurFond = new System.Windows.Forms.CheckBox();
            this.CaracCouleur = new System.Windows.Forms.CheckBox();
            this.Casse = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RedFond = new System.Windows.Forms.RadioButton();
            this.GreenFond = new System.Windows.Forms.RadioButton();
            this.BlueFond = new System.Windows.Forms.RadioButton();
            this.CasseMaj = new System.Windows.Forms.RadioButton();
            this.CasseMin = new System.Windows.Forms.RadioButton();
            this.BlackCarac = new System.Windows.Forms.RadioButton();
            this.BlancCarac = new System.Windows.Forms.RadioButton();
            this.RougeCarac = new System.Windows.Forms.RadioButton();
            this.groupBoxFond = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxFond.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextModif
            // 
            this.TextModif.AutoSize = true;
            this.TextModif.Location = new System.Drawing.Point(12, 21);
            this.TextModif.Name = "TextModif";
            this.TextModif.Size = new System.Drawing.Size(90, 13);
            this.TextModif.TabIndex = 0;
            this.TextModif.Text = "Tapez votre texte";
            this.TextModif.Click += new System.EventHandler(this.TextModif_Click);
            // 
            // CouleurFond
            // 
            this.CouleurFond.AutoSize = true;
            this.CouleurFond.Location = new System.Drawing.Point(323, 48);
            this.CouleurFond.Name = "CouleurFond";
            this.CouleurFond.Size = new System.Drawing.Size(101, 17);
            this.CouleurFond.TabIndex = 1;
            this.CouleurFond.Text = "Couleur de fond";
            this.CouleurFond.UseVisualStyleBackColor = true;
            this.CouleurFond.CheckedChanged += new System.EventHandler(this.CouleurFond_CheckedChanged);
            this.CouleurFond.Click += new System.EventHandler(this.RedFond_CheckedChanged);
            // 
            // CaracCouleur
            // 
            this.CaracCouleur.AutoSize = true;
            this.CaracCouleur.Location = new System.Drawing.Point(323, 71);
            this.CaracCouleur.Name = "CaracCouleur";
            this.CaracCouleur.Size = new System.Drawing.Size(135, 17);
            this.CaracCouleur.TabIndex = 2;
            this.CaracCouleur.Text = "Couleur des caractères";
            this.CaracCouleur.UseVisualStyleBackColor = true;
            this.CaracCouleur.CheckedChanged += new System.EventHandler(this.CaracCouleur_CheckedChanged);
            // 
            // Casse
            // 
            this.Casse.AutoSize = true;
            this.Casse.Location = new System.Drawing.Point(323, 94);
            this.Casse.Name = "Casse";
            this.Casse.Size = new System.Drawing.Size(55, 17);
            this.Casse.TabIndex = 3;
            this.Casse.Text = "Casse";
            this.Casse.UseVisualStyleBackColor = true;
            this.Casse.CheckedChanged += new System.EventHandler(this.Casse_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.TextModif_Click);
            // 
            // RedFond
            // 
            this.RedFond.AutoSize = true;
            this.RedFond.Location = new System.Drawing.Point(6, 19);
            this.RedFond.Name = "RedFond";
            this.RedFond.Size = new System.Drawing.Size(57, 17);
            this.RedFond.TabIndex = 6;
            this.RedFond.TabStop = true;
            this.RedFond.Tag = "Red";
            this.RedFond.Text = "Rouge";
            this.RedFond.UseVisualStyleBackColor = true;
            this.RedFond.CheckedChanged += new System.EventHandler(this.RedFond_CheckedChanged);
            this.RedFond.EnabledChanged += new System.EventHandler(this.RedFond_CheckedChanged);
            // 
            // GreenFond
            // 
            this.GreenFond.AutoSize = true;
            this.GreenFond.Location = new System.Drawing.Point(6, 42);
            this.GreenFond.Name = "GreenFond";
            this.GreenFond.Size = new System.Drawing.Size(44, 17);
            this.GreenFond.TabIndex = 7;
            this.GreenFond.TabStop = true;
            this.GreenFond.Tag = "Green";
            this.GreenFond.Text = "Vert";
            this.GreenFond.UseVisualStyleBackColor = true;
            this.GreenFond.CheckedChanged += new System.EventHandler(this.RedFond_CheckedChanged);
            this.GreenFond.EnabledChanged += new System.EventHandler(this.RedFond_CheckedChanged);
            // 
            // BlueFond
            // 
            this.BlueFond.AutoSize = true;
            this.BlueFond.Location = new System.Drawing.Point(6, 65);
            this.BlueFond.Name = "BlueFond";
            this.BlueFond.Size = new System.Drawing.Size(46, 17);
            this.BlueFond.TabIndex = 8;
            this.BlueFond.TabStop = true;
            this.BlueFond.Tag = "Blue";
            this.BlueFond.Text = "Bleu";
            this.BlueFond.UseVisualStyleBackColor = true;
            this.BlueFond.CheckedChanged += new System.EventHandler(this.RedFond_CheckedChanged);
            this.BlueFond.EnabledChanged += new System.EventHandler(this.RedFond_CheckedChanged);
            // 
            // CasseMaj
            // 
            this.CasseMaj.AutoSize = true;
            this.CasseMaj.Location = new System.Drawing.Point(6, 35);
            this.CasseMaj.Name = "CasseMaj";
            this.CasseMaj.Size = new System.Drawing.Size(78, 17);
            this.CasseMaj.TabIndex = 10;
            this.CasseMaj.TabStop = true;
            this.CasseMaj.Tag = "Maj";
            this.CasseMaj.Text = "Majuscules";
            this.CasseMaj.UseVisualStyleBackColor = true;
            this.CasseMaj.CheckedChanged += new System.EventHandler(this.CasseMin_CheckedChanged);
            // 
            // CasseMin
            // 
            this.CasseMin.AutoSize = true;
            this.CasseMin.Location = new System.Drawing.Point(6, 19);
            this.CasseMin.Name = "CasseMin";
            this.CasseMin.Size = new System.Drawing.Size(78, 17);
            this.CasseMin.TabIndex = 11;
            this.CasseMin.TabStop = true;
            this.CasseMin.Tag = "Min";
            this.CasseMin.Text = "Minuscules";
            this.CasseMin.UseVisualStyleBackColor = true;
            this.CasseMin.CheckedChanged += new System.EventHandler(this.CasseMin_CheckedChanged);
            // 
            // BlackCarac
            // 
            this.BlackCarac.AutoSize = true;
            this.BlackCarac.Location = new System.Drawing.Point(6, 66);
            this.BlackCarac.Name = "BlackCarac";
            this.BlackCarac.Size = new System.Drawing.Size(44, 17);
            this.BlackCarac.TabIndex = 12;
            this.BlackCarac.TabStop = true;
            this.BlackCarac.Tag = "Black";
            this.BlackCarac.Text = "Noir";
            this.BlackCarac.UseVisualStyleBackColor = true;
            this.BlackCarac.CheckedChanged += new System.EventHandler(this.RougeCarac_CheckedChanged);
            // 
            // BlancCarac
            // 
            this.BlancCarac.AutoSize = true;
            this.BlancCarac.Location = new System.Drawing.Point(6, 43);
            this.BlancCarac.Name = "BlancCarac";
            this.BlancCarac.Size = new System.Drawing.Size(52, 17);
            this.BlancCarac.TabIndex = 13;
            this.BlancCarac.TabStop = true;
            this.BlancCarac.Tag = "White";
            this.BlancCarac.Text = "Blanc";
            this.BlancCarac.UseVisualStyleBackColor = true;
            this.BlancCarac.CheckedChanged += new System.EventHandler(this.RougeCarac_CheckedChanged);
            // 
            // RougeCarac
            // 
            this.RougeCarac.AutoSize = true;
            this.RougeCarac.Location = new System.Drawing.Point(7, 20);
            this.RougeCarac.Name = "RougeCarac";
            this.RougeCarac.Size = new System.Drawing.Size(57, 17);
            this.RougeCarac.TabIndex = 14;
            this.RougeCarac.TabStop = true;
            this.RougeCarac.Tag = "Red";
            this.RougeCarac.Text = "Rouge";
            this.RougeCarac.UseVisualStyleBackColor = true;
            this.RougeCarac.CheckedChanged += new System.EventHandler(this.RougeCarac_CheckedChanged);
            // 
            // groupBoxFond
            // 
            this.groupBoxFond.Controls.Add(this.RedFond);
            this.groupBoxFond.Controls.Add(this.GreenFond);
            this.groupBoxFond.Controls.Add(this.BlueFond);
            this.groupBoxFond.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBoxFond.Location = new System.Drawing.Point(12, 150);
            this.groupBoxFond.Name = "groupBoxFond";
            this.groupBoxFond.Size = new System.Drawing.Size(70, 100);
            this.groupBoxFond.TabIndex = 15;
            this.groupBoxFond.TabStop = false;
            this.groupBoxFond.Text = "Fond";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RougeCarac);
            this.groupBox1.Controls.Add(this.BlancCarac);
            this.groupBox1.Controls.Add(this.BlackCarac);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(88, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(77, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caractères";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CasseMin);
            this.groupBox2.Controls.Add(this.CasseMaj);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(171, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 58);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Casse";
            // 
            // CheckBoxEtRadioBoutons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 262);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxFond);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Casse);
            this.Controls.Add(this.CaracCouleur);
            this.Controls.Add(this.CouleurFond);
            this.Controls.Add(this.TextModif);
            this.Name = "CheckBoxEtRadioBoutons";
            this.Text = "CheckBoxEtRadionBoutons";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxFond.ResumeLayout(false);
            this.groupBoxFond.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextModif;
        private System.Windows.Forms.CheckBox CouleurFond;
        private System.Windows.Forms.CheckBox CaracCouleur;
        private System.Windows.Forms.CheckBox Casse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton RedFond;
        private System.Windows.Forms.RadioButton GreenFond;
        private System.Windows.Forms.RadioButton BlueFond;
        private System.Windows.Forms.RadioButton CasseMaj;
        private System.Windows.Forms.RadioButton CasseMin;
        private System.Windows.Forms.RadioButton BlackCarac;
        private System.Windows.Forms.RadioButton BlancCarac;
        private System.Windows.Forms.RadioButton RougeCarac;
        private System.Windows.Forms.GroupBox groupBoxFond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

