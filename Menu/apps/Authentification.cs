using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Authentification : Form
    {
        frmMenu frmMenu1;

        public Authentification()
        {
            InitializeComponent();
        }
        public Authentification(frmMenu _frmMenu1)
        {
            InitializeComponent();
            frmMenu1 = _frmMenu1;
        }

        private void button1Ok_Click(object sender, EventArgs e)
        {
            if (textBox1Login.Text == textBox2Password.Text)
            {

                frmMenu1.phase1ToolStripMenuItem.Enabled = true;
                frmMenu1.phase1ToolStripMenuItem.Enabled = true;
                frmMenu1.phase2ToolStripMenuItem.Enabled = true;
                frmMenu1.phase3ToolStripMenuItem.Enabled = true;
                frmMenu1.fenêtresToolStripMenuItem.Enabled = true;
                Close();
            }
            else 
                errorProvider1.SetError(label1Log, "erreur");

        }

        private void button2Cancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            
        }

        private void Authentification_Load(object sender, EventArgs e)
        {

        }
    }
}
