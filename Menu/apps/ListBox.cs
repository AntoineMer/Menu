using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Menu
{
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
        }

        private void labelSelectedIndex_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelWText.Text = (string)listBox1.SelectedItem;
            labelWSelectedText.Text = (string)listBox1.SelectedIndex.ToString();
        }
        private void AjoutList_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("^([a-zA-Z\\s-])+$");
            if ((!listBox1.Items.Contains(NouvelElement.Text))
                && (NouvelElement.Text != null)
                && (reg.IsMatch(NouvelElement.Text))
                )
            {
                listBox1.Items.Add(NouvelElement.Text);
                NouvelElement.Clear();
                NouvelElement.Focus();
            }
            labelWCount.Text = listBox1.Items.Count.ToString();
        }

        private void BtnVider_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            labelWCount.Text = null;
            labelWText.Text = null;
            labelWSelectedText.Text = null;
        }

        private void BtnSlec_Click(object sender, EventArgs e)
        {

            Regex reg = new Regex("^([0-9])+$");
                if (reg.IsMatch(IndexBox.Text)
                    && (listBox1.Items.Count != 0)
                    && (int.Parse(IndexBox.Text) < (listBox1.Items.Count))
                    )
                {
                    errorProvider1.Clear();
                    listBox1.SetSelected(int.Parse(IndexBox.Text), true);
                }
                else
                {
                    errorProvider1.SetError(IndexBox, "Erreur !");
                    labelWCount.Text = null;
                }
            
        }

        private void IndexBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelWCount.Text = "0";
            labelWCount.Text = "0";
        }

        private void labelWCount_Click(object sender, EventArgs e)
        {
           
        }
    }
}
