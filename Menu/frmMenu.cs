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
    public partial class frmMenu : Form
    {
        
        public frmMenu()
        {
            InitializeComponent();
        }
        private void frmMenu_Load(object sender, EventArgs e)
        {
            additionneurToolStripMenuItem.Tag = typeof(Additionneur);
            checkBoxEtBoutonsRadiosToolStripMenuItem.Tag = typeof(CheckBoxEtRadioBoutons);
            lesComposantsDeDéfilementToolStripMenuItem.Tag = typeof(Defilement);
            contrôlesDeSaisieToolStripMenuItem.Tag = typeof(ControleSaisie);
            listBoxToolStripMenuItem.Tag = typeof(ListBox);
            listBoxEtComboBoxToolStripMenuItem.Tag = typeof(ListBoxEtComboBox);
            synthèseToolStripMenuItem.Tag = typeof(Synthèse);
            toolStripLabel1.Text = DateTime.Now.ToString();
            
            
        }

        private void sidentifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authentification authentification = new Authentification(this);
            authentification.Show();
            
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show("Fin de l'application", "FIN", btn, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                Application.Exit();
        }

        private void additionneurToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   Additionneur open = new Additionneur();
           // open.MdiParent = this;
            //open.Show();
            
        }

        private void contrôlesDeSaisieToolStripMenuItem_Click(object sender, EventArgs e)
        {/*
            LesContrôlesDeSaisie.ControleSaisie open = new LesContrôlesDeSaisie.ControleSaisie();
            open.MdiParent = this;
            open.Show();*/
        }

        private void checkBoxEtBoutonsRadiosToolStripMenuItem_Click(object sender, EventArgs e)
        {/*
            CheckBoxEtRadioBoutons open = new CheckBoxEtRadioBoutons();
            open.MdiParent = this;
            open.Show();*/
        }
        private void testFonctionOpen (object sender, EventArgs e)
        {

            ToolStripMenuItem maVar = ((ToolStripMenuItem)sender);
            Form myForm = Activator.CreateInstance((Type)maVar.Tag) as Form;
            myForm.MdiParent = this;
            myForm.Visible = true;
            myForm.Show();
            toolStripTextBox1.Text = "Dernière opération effectuée : Ouverture de " + myForm.Name.ToString();

        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void saisieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

    }
}
