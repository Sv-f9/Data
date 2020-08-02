using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Data
{
    public partial class Data : MetroFramework.Forms.MetroForm
    {
        public Data()
        {
            InitializeComponent();
            
            collectData1.Hide();
            settingControl1.Hide();
            showDataControl1.Hide();
            dataProgramControl1.Hide();
            try
            {
                var jsonSerializer = new DataContractJsonSerializer(typeof(SettingMainProfile));
                using (var file = new FileStream("C:\\Data Analysis\\MainProfile.json", FileMode.OpenOrCreate))
                {
                    SettingControl.mainProfile = jsonSerializer.ReadObject(file) as SettingMainProfile;
                }
            }
            catch(System.Runtime.Serialization.SerializationException)
            {
                SettingControl.mainProfile = new SettingMainProfile();
            }


        }

        private void metroTile9_Click(object sender, EventArgs e)
        {

        }


        private void metroTile3_Click_1(object sender, EventArgs e)
        {
            collectData1.Show();
            collectData1.BringToFront();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            settingControl1.Show();
            settingControl1.BringToFront();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            showDataControl1.Show();
            showDataControl1.BringToFront();
            showDataControl1.Update();

        }

        private void metroTile2_Click_1(object sender, EventArgs e)
        {
            showDataControl1.Show();
            showDataControl1.BringToFront();
        }

        private void metroTile2_Click_2(object sender, EventArgs e)
        {
            showDataControl1.Show();
            showDataControl1.BringToFront();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            dataProgramControl1.Show();
        }

        private void dataProgramControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
