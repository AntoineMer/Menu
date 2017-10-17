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
    public partial class Form2 : Form
    {
        internal static string maVar;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maVar = textBox1.Text;
            ActiveForm.Dispose();
            CheckBoxEtRadioBoutons checkBoxEtRadioBoutons = new CheckBoxEtRadioBoutons();
            checkBoxEtRadioBoutons.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
