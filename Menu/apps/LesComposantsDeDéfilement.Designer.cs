namespace Menu
{
    partial class Defilement
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
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.label1Red = new System.Windows.Forms.Label();
            this.label2Blue = new System.Windows.Forms.Label();
            this.label3Green = new System.Windows.Forms.Label();
            this.numericUpDown1Red = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2Blue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3Green = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2Red = new System.Windows.Forms.GroupBox();
            this.groupBox3Green = new System.Windows.Forms.GroupBox();
            this.groupBox4Blue = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3Green)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(52, 51);
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(138, 45);
            this.trackBarRed.TabIndex = 0;
            this.trackBarRed.Scroll += new System.EventHandler(this.TrackBarRed_ValueChanged);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(52, 153);
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(138, 45);
            this.trackBarBlue.TabIndex = 1;
            this.trackBarBlue.Scroll += new System.EventHandler(this.TrackBarRed_ValueChanged);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(52, 102);
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(138, 45);
            this.trackBarGreen.TabIndex = 2;
            this.trackBarGreen.Scroll += new System.EventHandler(this.TrackBarRed_ValueChanged);
            // 
            // label1Red
            // 
            this.label1Red.AutoSize = true;
            this.label1Red.Location = new System.Drawing.Point(11, 51);
            this.label1Red.Name = "label1Red";
            this.label1Red.Size = new System.Drawing.Size(39, 13);
            this.label1Red.TabIndex = 3;
            this.label1Red.Text = "Rouge";
            // 
            // label2Blue
            // 
            this.label2Blue.AutoSize = true;
            this.label2Blue.Location = new System.Drawing.Point(11, 153);
            this.label2Blue.Name = "label2Blue";
            this.label2Blue.Size = new System.Drawing.Size(28, 13);
            this.label2Blue.TabIndex = 4;
            this.label2Blue.Text = "Bleu";
            // 
            // label3Green
            // 
            this.label3Green.AutoSize = true;
            this.label3Green.Location = new System.Drawing.Point(11, 102);
            this.label3Green.Name = "label3Green";
            this.label3Green.Size = new System.Drawing.Size(26, 13);
            this.label3Green.TabIndex = 5;
            this.label3Green.Text = "Vert";
            // 
            // numericUpDown1Red
            // 
            this.numericUpDown1Red.Location = new System.Drawing.Point(214, 51);
            this.numericUpDown1Red.Name = "numericUpDown1Red";
            this.numericUpDown1Red.Size = new System.Drawing.Size(117, 20);
            this.numericUpDown1Red.TabIndex = 6;
            this.numericUpDown1Red.ValueChanged += new System.EventHandler(this.numericUpDown1Red_ValueChanged);
            // 
            // numericUpDown2Blue
            // 
            this.numericUpDown2Blue.Location = new System.Drawing.Point(214, 153);
            this.numericUpDown2Blue.Name = "numericUpDown2Blue";
            this.numericUpDown2Blue.Size = new System.Drawing.Size(117, 20);
            this.numericUpDown2Blue.TabIndex = 7;
            this.numericUpDown2Blue.ValueChanged += new System.EventHandler(this.numericUpDown1Red_ValueChanged);
            // 
            // numericUpDown3Green
            // 
            this.numericUpDown3Green.Location = new System.Drawing.Point(214, 100);
            this.numericUpDown3Green.Name = "numericUpDown3Green";
            this.numericUpDown3Green.Size = new System.Drawing.Size(117, 20);
            this.numericUpDown3Green.TabIndex = 8;
            this.numericUpDown3Green.ValueChanged += new System.EventHandler(this.numericUpDown1Red_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(102, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 63);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2Red
            // 
            this.groupBox2Red.Location = new System.Drawing.Point(337, 51);
            this.groupBox2Red.Name = "groupBox2Red";
            this.groupBox2Red.Size = new System.Drawing.Size(83, 20);
            this.groupBox2Red.TabIndex = 13;
            this.groupBox2Red.TabStop = false;
            // 
            // groupBox3Green
            // 
            this.groupBox3Green.Location = new System.Drawing.Point(337, 100);
            this.groupBox3Green.Name = "groupBox3Green";
            this.groupBox3Green.Size = new System.Drawing.Size(83, 20);
            this.groupBox3Green.TabIndex = 14;
            this.groupBox3Green.TabStop = false;
            // 
            // groupBox4Blue
            // 
            this.groupBox4Blue.Location = new System.Drawing.Point(337, 153);
            this.groupBox4Blue.Name = "groupBox4Blue";
            this.groupBox4Blue.Size = new System.Drawing.Size(83, 20);
            this.groupBox4Blue.TabIndex = 14;
            this.groupBox4Blue.TabStop = false;
            // 
            // Defilement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 269);
            this.Controls.Add(this.groupBox3Green);
            this.Controls.Add(this.groupBox4Blue);
            this.Controls.Add(this.groupBox2Red);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown3Green);
            this.Controls.Add(this.numericUpDown2Blue);
            this.Controls.Add(this.numericUpDown1Red);
            this.Controls.Add(this.label3Green);
            this.Controls.Add(this.label2Blue);
            this.Controls.Add(this.label1Red);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarRed);
            this.Name = "Defilement";
            this.Text = "ComposantsDeDéfilement";
            this.Load += new System.EventHandler(this.Defilement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3Green)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.Label label1Red;
        private System.Windows.Forms.Label label2Blue;
        private System.Windows.Forms.Label label3Green;
        private System.Windows.Forms.NumericUpDown numericUpDown1Red;
        private System.Windows.Forms.NumericUpDown numericUpDown2Blue;
        private System.Windows.Forms.NumericUpDown numericUpDown3Green;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2Red;
        private System.Windows.Forms.GroupBox groupBox3Green;
        private System.Windows.Forms.GroupBox groupBox4Blue;
    }
}

