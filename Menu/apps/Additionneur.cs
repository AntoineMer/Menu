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
    public partial class Additionneur : Form
    {
        private int traitement;
        public Additionneur()
        {
            InitializeComponent();
        }

        private void chiffre_0_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int value = Convert.ToInt32(btn.Tag);
            traitement += value;
            if (textBox1.Text != "")
                textBox1.Text += " + " + value;
            else
                textBox1.Text += value;
        }
        private void Valider_Click(object sender, EventArgs e)
        {
            textBox1.Text = traitement.ToString();
        }

        private void Vider_Click(object sender, EventArgs e)
        {
            traitement = 0;
            textBox1.Clear();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
