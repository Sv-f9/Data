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
    public partial class CollectData : UserControl
    {
        public CollectData()
        {
            InitializeComponent();
            allCollectControl1.BringToFront();
            quickCollectControl1.Hide();
            selectiveCollectControl1.Hide();
            SidePanel.Height = metroTile2.Height;
            SidePanel.Top = metroTile2.Top;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
        //    if (progressBar1.Height == 0)
        //        progressBar1.Hide();
            Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            allCollectControl1.Hide();
            selectiveCollectControl1.Hide();
            quickCollectControl1.Show();
            quickCollectControl1.BringToFront();
            SidePanel.Height = metroTile3.Height;
            SidePanel.Top = metroTile3.Top;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            quickCollectControl1.Hide();
            selectiveCollectControl1.Hide();
            allCollectControl1.Show();
            allCollectControl1.BringToFront();
            SidePanel.Height = metroTile2.Height;
            SidePanel.Top = metroTile2.Top;
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            allCollectControl1.Hide();
            quickCollectControl1.Hide();
            selectiveCollectControl1.Show();
            selectiveCollectControl1.BringToFront();
            SidePanel.Height = metroTile4.Height;
            SidePanel.Top = metroTile4.Top;
        }
    }
}
