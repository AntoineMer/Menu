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
    public partial class CheckBoxEtRadioBoutons : Form
    {
        public CheckBoxEtRadioBoutons()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBoxFond.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            if (Form2.maVar != string.Empty)
            label1.Text = Form2.maVar;
        }

        private void TextModif_Click(object sender, EventArgs e)
        {
             label1.Text = textBox1.Text;
        }

        private void CouleurFond_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxFond.Visible = CouleurFond.Checked;
        }

        private void CaracCouleur_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = CaracCouleur.Checked;
        }

        private void Casse_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = Casse.Checked;
        }

        private void RedFond_CheckedChanged(object sender, EventArgs e)
        { 
            RadioButton btn = sender as RadioButton;
            if (btn != null)
            {
                string btn1 = btn.Tag as string;
                if (btn1 == "Red")
                    label1.BackColor = Color.Red;
                else if (btn1 == "Green")
                    label1.BackColor = Color.Green;
                else if (btn1 == "Blue")
                    label1.BackColor = Color.Blue;
            }
        }

        private void RougeCarac_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            if (btn != null)
            {
                string btn1 = btn.Tag as string;
                if (btn1 == "Red")
                    label1.ForeColor = Color.Red;
                else if (btn1 == "White")
                    label1.ForeColor = Color.White;
                else if (btn1 == "Black")
                    label1.ForeColor = Color.Black;
            }
        }

        private void CasseMin_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            if (btn != null)
            {
                string btn1 = btn.Tag as string;
                if (btn1 == "Min")
                    label1.Text = label1.Text.ToLower();
                else if (btn1 == "Maj")
                    label1.Text = label1.Text.ToUpper();

            }
        }
    }
}
