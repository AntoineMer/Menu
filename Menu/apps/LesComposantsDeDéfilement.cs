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
    public partial class Defilement : Form
    {
        public Defilement()
        {
            InitializeComponent();
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            trackBarRed.ValueChanged += TrackBarRed_ValueChanged;
        }

        private void TrackBarRed_ValueChanged(object sender, EventArgs e)
        {
            TrackBar bar = sender as TrackBar;
            bar.Minimum = 0;
            bar.Maximum = 255;
            groupBox1.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            groupBox2Red.BackColor = Color.FromArgb(trackBarRed.Value, 0, 0);
            groupBox3Green.BackColor = Color.FromArgb(0, trackBarGreen.Value, 0);
            groupBox4Blue.BackColor = Color.FromArgb(0, 0, trackBarBlue.Value);
            numericUpDown1Red.Value = trackBarRed.Value;
        }

        private void numericUpDown1Red_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            num.Minimum = 0;
            num.Maximum = 255;
            int red = Convert.ToInt32(numericUpDown1Red.Value);
            int green = Convert.ToInt32(numericUpDown3Green.Value);
            int blue = Convert.ToInt32(numericUpDown2Blue.Value);
            groupBox1.BackColor = Color.FromArgb(red, green, blue);
            groupBox2Red.BackColor = Color.FromArgb(red, 0, 0);
            groupBox3Green.BackColor = Color.FromArgb(0, green, 0);
            groupBox4Blue.BackColor = Color.FromArgb(0, 0, blue);
            trackBarRed.Value = red;
            trackBarGreen.Value = green;
            trackBarBlue.Value = blue;
        }

        private void Defilement_Load(object sender, EventArgs e)
        {

        }
    }
}
