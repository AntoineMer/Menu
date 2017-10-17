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
    public partial class ListBoxEtComboBox : Form
    {
        public ListBoxEtComboBox()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string comboSelect = comboBox1.SelectedItem as string;
            if (comboSelect != null)
                button1GoOne.Enabled = true;
        }

        private void button1GoOne_Click(object sender, EventArgs e)
        {

            if (!listBox1.Items.Contains(comboBox1.Text)
                && (comboBox1.Text != null)
                )
            {
                listBox1.Items.Add(comboBox1.Text);
                comboBox1.Items.Remove(comboBox1.Text);
                comboBox1.Text = string.Empty;
                button1BackOne.Enabled = true;
                button1BackAll.Enabled = true;

            }
        }

        private void button1BackOne_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {

                comboBox1.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
                if (listBox1.Text == string.Empty)
                {
                    button1BackOne.Enabled = false;
                    button1BackAll.Enabled = false;
                }
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (comboBox1.Text != string.Empty)
                {
                    comboBox1.Items.Add(comboBox1.Text);
                    comboBox1.Text = string.Empty;
                    button1GoAll.Enabled = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1GoOne.Enabled = false;
            button1BackOne.Enabled = false;
            button1BackAll.Enabled = false;
            button1GoAll.Enabled = false;
            button1UP.Enabled = false;
            button1Down.Enabled = false;
        }

        private void button1GoAll_Click(object sender, EventArgs e)
        {
            if (comboBox1 != null)
            {
                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    listBox1.Items.Add(comboBox1.Items[i]);
                }
                comboBox1.Items.Clear();
                button1GoOne.Enabled = false;
                button1GoAll.Enabled = false;
                button1BackOne.Enabled = true;
                button1BackAll.Enabled = true;
            }
        }
        private void button1BackAll_Click(object sender, EventArgs e)
        {
            if (listBox1 != null)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    comboBox1.Items.Add(listBox1.Items[i]);
                }
                listBox1.Items.Clear();
                button1BackOne.Enabled = false;
                button1BackAll.Enabled = false;
            }
        }

        private void button1UP_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            object temp = new object();
            temp = listBox1.Items[i];
            listBox1.Items[i] = listBox1.Items[i - 1];
            listBox1.Items[i - 1] = temp;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i > 0)
            {
                button1UP.Enabled = true;
            }
            if (i == 0)
            {
                button1UP.Enabled = false;
                button1Down.Enabled = true;
            }
            if (i == listBox1.Items.Count-1)
            {
                button1Down.Enabled = false;
            }

        }

        private void button1Down_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            object temp = new object();
            temp = listBox1.Items[i];
            listBox1.Items[i] = listBox1.Items[i + 1];
            listBox1.Items[i + 1] = temp;
        }
    }
}
