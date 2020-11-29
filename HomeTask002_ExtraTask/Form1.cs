using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTask002_ExtraTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minumum Value equals " + byte.MinValue + " AND Maximum Value equals " + byte.MaxValue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minumum Value equals " + sbyte.MinValue + " AND Maximum Value equals " + sbyte.MaxValue);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minumum Value equals " + short.MinValue + " AND Maximum Value equals " + short.MaxValue);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minumum Value equals " + ushort.MinValue + " AND Maximum Value equals " + ushort.MaxValue);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minumum Value equals " + int.MinValue + " AND Maximum Value equals " + int.MaxValue);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minumum Value equals " + uint.MinValue + " AND Maximum Value equals " + uint.MaxValue);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minumum Value equals " + long.MinValue + " AND Maximum Value equals " + long.MaxValue);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minumum Value equals " + ulong.MinValue + " AND Maximum Value equals " + ulong.MaxValue);
        }
    }
}
