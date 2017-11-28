namespace Menu
{
    partial class Authentification
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
            this.components = new System.ComponentModel.Container();
            this.button1Ok = new System.Windows.Forms.Button();
            this.button2Cancel = new System.Windows.Forms.Button();
            this.textBox1Login = new System.Windows.Forms.TextBox();
            this.textBox2Password = new System.Windows.Forms.TextBox();
            this.label1Log = new System.Windows.Forms.Label();
            this.label2Pass = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1Ok
            // 
            this.button1Ok.Location = new System.Drawing.Point(252, 108);
            this.button1Ok.Name = "button1Ok";
            this.button1Ok.Size = new System.Drawing.Size(75, 23);
            this.button1Ok.TabIndex = 0;
            this.button1Ok.Text = "OK";
            this.button1Ok.UseVisualStyleBackColor = true;
            this.button1Ok.Click += new System.EventHandler(this.button1Ok_Click);
            // 
            // button2Cancel
            // 
            this.button2Cancel.Location = new System.Drawing.Point(252, 79);
            this.button2Cancel.Name = "button2Cancel";
            this.button2Cancel.Size = new System.Drawing.Size(75, 23);
            this.button2Cancel.TabIndex = 1;
            this.button2Cancel.Text = "Annuler";
            this.button2Cancel.UseVisualStyleBackColor = true;
            this.button2Cancel.Click += new System.EventHandler(this.button2Cancel_Click);
            // 
            // textBox1Login
            // 
            this.textBox1Login.Location = new System.Drawing.Point(113, 47);
            this.textBox1Login.Name = "textBox1Login";
            this.textBox1Login.Size = new System.Drawing.Size(100, 20);
            this.textBox1Login.TabIndex = 2;
            // 
            // textBox2Password
            // 
            this.textBox2Password.Location = new System.Drawing.Point(113, 73);
            this.textBox2Password.Name = "textBox2Password";
            this.textBox2Password.Size = new System.Drawing.Size(100, 20);
            this.textBox2Password.TabIndex = 3;
            // 
            // label1Log
            // 
            this.label1Log.AutoSize = true;
            this.label1Log.Location = new System.Drawing.Point(43, 54);
            this.label1Log.Name = "label1Log";
            this.label1Log.Size = new System.Drawing.Size(33, 13);
            this.label1Log.TabIndex = 4;
            this.label1Log.Text = "Login";
            // 
            // label2Pass
            // 
            this.label2Pass.AutoSize = true;
            this.label2Pass.Location = new System.Drawing.Point(43, 80);
            this.label2Pass.Name = "label2Pass";
            this.label2Pass.Size = new System.Drawing.Size(53, 13);
            this.label2Pass.TabIndex = 5;
            this.label2Pass.Text = "Password";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 143);
            this.Controls.Add(this.label2Pass);
            this.Controls.Add(this.label1Log);
            this.Controls.Add(this.textBox2Password);
            this.Controls.Add(this.textBox1Login);
            this.Controls.Add(this.button2Cancel);
            this.Controls.Add(this.button1Ok);
            this.Name = "Authentification";
            this.Text = "Authentification";
            this.Load += new System.EventHandler(this.Authentification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Ok;
        private System.Windows.Forms.Button button2Cancel;
        private System.Windows.Forms.TextBox textBox1Login;
        private System.Windows.Forms.TextBox textBox2Password;
        private System.Windows.Forms.Label label1Log;
        private System.Windows.Forms.Label label2Pass;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}