namespace Menu
{
    partial class ListBox
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
            this.components = new System.ComponentModel.Container();
            this.NouvelElement = new System.Windows.Forms.TextBox();
            this.labelNvlElement = new System.Windows.Forms.Label();
            this.AjoutList = new System.Windows.Forms.Button();
            this.IndexBox = new System.Windows.Forms.TextBox();
            this.labelIndex = new System.Windows.Forms.Label();
            this.BtnSlec = new System.Windows.Forms.Button();
            this.BtnVider = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelList = new System.Windows.Forms.Label();
            this.labelProprietes = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelWCount = new System.Windows.Forms.Label();
            this.labelSelectedIndex = new System.Windows.Forms.Label();
            this.labelWSelectedText = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.labelWText = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // NouvelElement
            // 
            this.NouvelElement.Location = new System.Drawing.Point(12, 41);
            this.NouvelElement.Name = "NouvelElement";
            this.NouvelElement.Size = new System.Drawing.Size(100, 20);
            this.NouvelElement.TabIndex = 0;
            // 
            // labelNvlElement
            // 
            this.labelNvlElement.AutoSize = true;
            this.labelNvlElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNvlElement.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNvlElement.Location = new System.Drawing.Point(12, 25);
            this.labelNvlElement.Name = "labelNvlElement";
            this.labelNvlElement.Size = new System.Drawing.Size(96, 13);
            this.labelNvlElement.TabIndex = 1;
            this.labelNvlElement.Text = "Nouvel Elément";
            // 
            // AjoutList
            // 
            this.AjoutList.Location = new System.Drawing.Point(12, 90);
            this.AjoutList.Name = "AjoutList";
            this.AjoutList.Size = new System.Drawing.Size(100, 23);
            this.AjoutList.TabIndex = 2;
            this.AjoutList.Text = "Ajout Liste";
            this.AjoutList.UseVisualStyleBackColor = true;
            this.AjoutList.Click += new System.EventHandler(this.AjoutList_Click);
            // 
            // IndexBox
            // 
            this.IndexBox.Location = new System.Drawing.Point(187, 41);
            this.IndexBox.Name = "IndexBox";
            this.IndexBox.Size = new System.Drawing.Size(34, 20);
            this.IndexBox.TabIndex = 3;
            this.IndexBox.TextChanged += new System.EventHandler(this.IndexBox_TextChanged);
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndex.Location = new System.Drawing.Point(186, 25);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(87, 13);
            this.labelIndex.TabIndex = 4;
            this.labelIndex.Text = "Index Elément";
            // 
            // BtnSlec
            // 
            this.BtnSlec.Location = new System.Drawing.Point(248, 41);
            this.BtnSlec.Name = "BtnSlec";
            this.BtnSlec.Size = new System.Drawing.Size(100, 23);
            this.BtnSlec.TabIndex = 5;
            this.BtnSlec.Text = "Sélectionner";
            this.BtnSlec.UseVisualStyleBackColor = true;
            this.BtnSlec.Click += new System.EventHandler(this.BtnSlec_Click);
            // 
            // BtnVider
            // 
            this.BtnVider.Location = new System.Drawing.Point(248, 70);
            this.BtnVider.Name = "BtnVider";
            this.BtnVider.Size = new System.Drawing.Size(100, 23);
            this.BtnVider.TabIndex = 6;
            this.BtnVider.Text = "Vider la Liste";
            this.BtnVider.UseVisualStyleBackColor = true;
            this.BtnVider.Click += new System.EventHandler(this.BtnVider_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 160);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelList.Location = new System.Drawing.Point(9, 144);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(51, 13);
            this.labelList.TabIndex = 8;
            this.labelList.Text = "LstListe";
            // 
            // labelProprietes
            // 
            this.labelProprietes.AutoSize = true;
            this.labelProprietes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProprietes.Location = new System.Drawing.Point(184, 144);
            this.labelProprietes.Name = "labelProprietes";
            this.labelProprietes.Size = new System.Drawing.Size(64, 13);
            this.labelProprietes.TabIndex = 9;
            this.labelProprietes.Text = "Propriétés";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(184, 169);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(63, 13);
            this.labelCount.TabIndex = 10;
            this.labelCount.Text = "Items.Count";
            // 
            // labelWCount
            // 
            this.labelWCount.AutoSize = true;
            this.labelWCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelWCount.Location = new System.Drawing.Point(269, 169);
            this.labelWCount.Name = "labelWCount";
            this.labelWCount.Size = new System.Drawing.Size(2, 15);
            this.labelWCount.TabIndex = 11;
            this.labelWCount.Click += new System.EventHandler(this.labelWCount_Click);
            // 
            // labelSelectedIndex
            // 
            this.labelSelectedIndex.AutoSize = true;
            this.labelSelectedIndex.Location = new System.Drawing.Point(184, 193);
            this.labelSelectedIndex.Name = "labelSelectedIndex";
            this.labelSelectedIndex.Size = new System.Drawing.Size(75, 13);
            this.labelSelectedIndex.TabIndex = 12;
            this.labelSelectedIndex.Text = "SelectedIndex";
            this.labelSelectedIndex.Click += new System.EventHandler(this.labelSelectedIndex_Click);
            // 
            // labelWSelectedText
            // 
            this.labelWSelectedText.AutoSize = true;
            this.labelWSelectedText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelWSelectedText.Location = new System.Drawing.Point(269, 193);
            this.labelWSelectedText.Name = "labelWSelectedText";
            this.labelWSelectedText.Size = new System.Drawing.Size(2, 15);
            this.labelWSelectedText.TabIndex = 13;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(184, 216);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(28, 13);
            this.labelText.TabIndex = 14;
            this.labelText.Text = "Text";
            this.labelText.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelWText
            // 
            this.labelWText.AutoSize = true;
            this.labelWText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelWText.Location = new System.Drawing.Point(269, 214);
            this.labelWText.Name = "labelWText";
            this.labelWText.Size = new System.Drawing.Size(2, 15);
            this.labelWText.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 304);
            this.Controls.Add(this.labelWText);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelWSelectedText);
            this.Controls.Add(this.labelSelectedIndex);
            this.Controls.Add(this.labelWCount);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelProprietes);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnVider);
            this.Controls.Add(this.BtnSlec);
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.IndexBox);
            this.Controls.Add(this.AjoutList);
            this.Controls.Add(this.labelNvlElement);
            this.Controls.Add(this.NouvelElement);
            this.Name = "ListBox";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NouvelElement;
        private System.Windows.Forms.Label labelNvlElement;
        private System.Windows.Forms.Button AjoutList;
        private System.Windows.Forms.TextBox IndexBox;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.Button BtnSlec;
        private System.Windows.Forms.Button BtnVider;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Label labelProprietes;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelWCount;
        private System.Windows.Forms.Label labelSelectedIndex;
        private System.Windows.Forms.Label labelWSelectedText;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelWText;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

