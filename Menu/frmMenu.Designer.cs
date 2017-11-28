namespace Menu
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sidentifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phase1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.additionneurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrôlesDeSaisieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phase2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxEtBoutonsRadiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxEtComboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phase3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesComposantsDeDéfilementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.synthèseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenêtresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saisieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.phase1ToolStripMenuItem,
            this.phase2ToolStripMenuItem,
            this.phase3ToolStripMenuItem,
            this.fenêtresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sidentifierToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // sidentifierToolStripMenuItem
            // 
            this.sidentifierToolStripMenuItem.Name = "sidentifierToolStripMenuItem";
            this.sidentifierToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.sidentifierToolStripMenuItem.Text = "S\'identifier";
            this.sidentifierToolStripMenuItem.Click += new System.EventHandler(this.sidentifierToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // phase1ToolStripMenuItem
            // 
            this.phase1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.additionneurToolStripMenuItem,
            this.contrôlesDeSaisieToolStripMenuItem});
            this.phase1ToolStripMenuItem.Enabled = false;
            this.phase1ToolStripMenuItem.Name = "phase1ToolStripMenuItem";
            this.phase1ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.phase1ToolStripMenuItem.Text = "Phase 1";
            // 
            // additionneurToolStripMenuItem
            // 
            this.additionneurToolStripMenuItem.Name = "additionneurToolStripMenuItem";
            this.additionneurToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.additionneurToolStripMenuItem.Text = "Additionneur";
            this.additionneurToolStripMenuItem.Click += new System.EventHandler(this.testFonctionOpen);
            // 
            // contrôlesDeSaisieToolStripMenuItem
            // 
            this.contrôlesDeSaisieToolStripMenuItem.Name = "contrôlesDeSaisieToolStripMenuItem";
            this.contrôlesDeSaisieToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.contrôlesDeSaisieToolStripMenuItem.Text = "Contrôles de saisie";
            this.contrôlesDeSaisieToolStripMenuItem.Click += new System.EventHandler(this.testFonctionOpen);
            // 
            // phase2ToolStripMenuItem
            // 
            this.phase2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxEtBoutonsRadiosToolStripMenuItem,
            this.listBoxToolStripMenuItem,
            this.listBoxEtComboBoxToolStripMenuItem});
            this.phase2ToolStripMenuItem.Enabled = false;
            this.phase2ToolStripMenuItem.Name = "phase2ToolStripMenuItem";
            this.phase2ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.phase2ToolStripMenuItem.Text = "Phase 2";
            // 
            // checkBoxEtBoutonsRadiosToolStripMenuItem
            // 
            this.checkBoxEtBoutonsRadiosToolStripMenuItem.Name = "checkBoxEtBoutonsRadiosToolStripMenuItem";
            this.checkBoxEtBoutonsRadiosToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.checkBoxEtBoutonsRadiosToolStripMenuItem.Text = "CheckBox et Boutons Radios";
            this.checkBoxEtBoutonsRadiosToolStripMenuItem.Click += new System.EventHandler(this.testFonctionOpen);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.listBoxToolStripMenuItem.Text = "ListBox";
            this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.testFonctionOpen);
            // 
            // listBoxEtComboBoxToolStripMenuItem
            // 
            this.listBoxEtComboBoxToolStripMenuItem.Name = "listBoxEtComboBoxToolStripMenuItem";
            this.listBoxEtComboBoxToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.listBoxEtComboBoxToolStripMenuItem.Text = "ListBox et ComboBox";
            this.listBoxEtComboBoxToolStripMenuItem.Click += new System.EventHandler(this.testFonctionOpen);
            // 
            // phase3ToolStripMenuItem
            // 
            this.phase3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lesComposantsDeDéfilementToolStripMenuItem,
            this.synthèseToolStripMenuItem});
            this.phase3ToolStripMenuItem.Enabled = false;
            this.phase3ToolStripMenuItem.Name = "phase3ToolStripMenuItem";
            this.phase3ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.phase3ToolStripMenuItem.Text = "Phase 3";
            // 
            // lesComposantsDeDéfilementToolStripMenuItem
            // 
            this.lesComposantsDeDéfilementToolStripMenuItem.Name = "lesComposantsDeDéfilementToolStripMenuItem";
            this.lesComposantsDeDéfilementToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.lesComposantsDeDéfilementToolStripMenuItem.Text = "Les composants de défilement";
            this.lesComposantsDeDéfilementToolStripMenuItem.Click += new System.EventHandler(this.testFonctionOpen);
            // 
            // synthèseToolStripMenuItem
            // 
            this.synthèseToolStripMenuItem.Name = "synthèseToolStripMenuItem";
            this.synthèseToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.synthèseToolStripMenuItem.Text = "Synthèse";
            this.synthèseToolStripMenuItem.Click += new System.EventHandler(this.testFonctionOpen);
            // 
            // fenêtresToolStripMenuItem
            // 
            this.fenêtresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.toolStripSeparator1,
            this.saisieToolStripMenuItem});
            this.fenêtresToolStripMenuItem.Enabled = false;
            this.fenêtresToolStripMenuItem.Name = "fenêtresToolStripMenuItem";
            this.fenêtresToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.fenêtresToolStripMenuItem.Text = "Fenêtres";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
            // 
            // saisieToolStripMenuItem
            // 
            this.saisieToolStripMenuItem.Name = "saisieToolStripMenuItem";
            this.saisieToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.saisieToolStripMenuItem.Text = "Saisie";
            this.saisieToolStripMenuItem.Click += new System.EventHandler(this.saisieToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 340);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(837, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(400, 25);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 363);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sidentifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        public System.Windows.Forms.ToolStripMenuItem additionneurToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem phase2ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem checkBoxEtBoutonsRadiosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem phase1ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem contrôlesDeSaisieToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem listBoxEtComboBoxToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem phase3ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem lesComposantsDeDéfilementToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem synthèseToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem fenêtresToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem saisieToolStripMenuItem;
    }
}

