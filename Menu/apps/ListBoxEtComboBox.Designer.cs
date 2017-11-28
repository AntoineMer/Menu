namespace Menu
{
    partial class ListBoxEtComboBox
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelSource = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1GoOne = new System.Windows.Forms.Button();
            this.button1GoAll = new System.Windows.Forms.Button();
            this.button1BackOne = new System.Windows.Forms.Button();
            this.button1BackAll = new System.Windows.Forms.Button();
            this.button1UP = new System.Windows.Forms.Button();
            this.button1Down = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "France ",
            "Belgique",
            "Allemagne"});
            this.comboBox1.Location = new System.Drawing.Point(12, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(32, 33);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(41, 13);
            this.labelSource.TabIndex = 1;
            this.labelSource.Text = "Source";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(217, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(132, 199);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1GoOne
            // 
            this.button1GoOne.Location = new System.Drawing.Point(152, 49);
            this.button1GoOne.Name = "button1GoOne";
            this.button1GoOne.Size = new System.Drawing.Size(47, 27);
            this.button1GoOne.TabIndex = 3;
            this.button1GoOne.Text = ">";
            this.button1GoOne.UseVisualStyleBackColor = true;
            this.button1GoOne.Click += new System.EventHandler(this.button1GoOne_Click);
            // 
            // button1GoAll
            // 
            this.button1GoAll.Location = new System.Drawing.Point(152, 82);
            this.button1GoAll.Name = "button1GoAll";
            this.button1GoAll.Size = new System.Drawing.Size(47, 27);
            this.button1GoAll.TabIndex = 4;
            this.button1GoAll.Text = ">>";
            this.button1GoAll.UseVisualStyleBackColor = true;
            this.button1GoAll.Click += new System.EventHandler(this.button1GoAll_Click);
            // 
            // button1BackOne
            // 
            this.button1BackOne.Location = new System.Drawing.Point(152, 185);
            this.button1BackOne.Name = "button1BackOne";
            this.button1BackOne.Size = new System.Drawing.Size(47, 27);
            this.button1BackOne.TabIndex = 5;
            this.button1BackOne.Text = "<";
            this.button1BackOne.UseVisualStyleBackColor = true;
            this.button1BackOne.Click += new System.EventHandler(this.button1BackOne_Click);
            // 
            // button1BackAll
            // 
            this.button1BackAll.Location = new System.Drawing.Point(152, 221);
            this.button1BackAll.Name = "button1BackAll";
            this.button1BackAll.Size = new System.Drawing.Size(47, 27);
            this.button1BackAll.TabIndex = 6;
            this.button1BackAll.Text = "<<";
            this.button1BackAll.UseVisualStyleBackColor = true;
            this.button1BackAll.Click += new System.EventHandler(this.button1BackAll_Click);
            // 
            // button1UP
            // 
            this.button1UP.Location = new System.Drawing.Point(217, 254);
            this.button1UP.Name = "button1UP";
            this.button1UP.Size = new System.Drawing.Size(58, 24);
            this.button1UP.TabIndex = 7;
            this.button1UP.Text = "UP";
            this.button1UP.UseVisualStyleBackColor = true;
            this.button1UP.Click += new System.EventHandler(this.button1UP_Click);
            // 
            // button1Down
            // 
            this.button1Down.Location = new System.Drawing.Point(292, 254);
            this.button1Down.Name = "button1Down";
            this.button1Down.Size = new System.Drawing.Size(57, 24);
            this.button1Down.TabIndex = 8;
            this.button1Down.Text = "DOWN";
            this.button1Down.UseVisualStyleBackColor = true;
            this.button1Down.Click += new System.EventHandler(this.button1Down_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ListBoxEtComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 319);
            this.Controls.Add(this.button1Down);
            this.Controls.Add(this.button1UP);
            this.Controls.Add(this.button1BackAll);
            this.Controls.Add(this.button1BackOne);
            this.Controls.Add(this.button1GoAll);
            this.Controls.Add(this.button1GoOne);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.comboBox1);
            this.Name = "ListBoxEtComboBox";
            this.Text = "ListBoxEtComboBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1GoOne;
        private System.Windows.Forms.Button button1GoAll;
        private System.Windows.Forms.Button button1BackOne;
        private System.Windows.Forms.Button button1BackAll;
        private System.Windows.Forms.Button button1UP;
        private System.Windows.Forms.Button button1Down;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

