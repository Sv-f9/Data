using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data
{
    public partial class QuickCollectControl : UserControl
    {
        public QuickCollectControl()
        {
            InitializeComponent();
            progressBar1.Hide();
            metroTile4.Hide();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            label3.Hide();
            textBox1.Hide();
            metroTile3.Hide();
            progressBar1.Show();
            progressBar1.BringToFront();
            metroTile4.Show();
            metroTile4.BringToFront();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroTile4_Click_1(object sender, EventArgs e)
        {
            metroTile4.Hide();
            progressBar1.Hide();
            metroTile3.Show();
            label3.Show();
            textBox1.Show();
            metroTile3.BringToFront();
            label3.BringToFront();
            textBox1.BringToFront();
        }
    }
}
