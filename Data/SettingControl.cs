using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Data
{
    public partial class SettingControl : UserControl
    {
        static public SettingMainProfile mainProfile;
        public SettingControl()
        {
            InitializeComponent();
            var jsonSerializer = new DataContractJsonSerializer(typeof(SettingMainProfile));
           // BinaryFormatter binaryFormatter = new BinaryFormatter();
            try
            {

                
                using (var file = new FileStream("C:\\Data Analysis\\MainProfile.json", FileMode.OpenOrCreate))
                {
                    mainProfile = jsonSerializer.ReadObject(file) as SettingMainProfile;
                }
                textBox1.Text = mainProfile.NumberOrAdress;
                maskedTextBox1.Text = mainProfile.Password;
                if ((mainProfile.Password) == "true")
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else
                {
                    radioButton2.Checked = true;
                    radioButton1.Checked = false;
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Directory.CreateDirectory("C:\\Data Analysis");
            }
            catch (System.Runtime.Serialization.SerializationException) {
                //  radioButton1.Checked = true;
               
            }
            
        }


        private void metroTile2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (maskedTextBox1.Text == "") || ((!radioButton1.Checked) && (!radioButton2.Checked)))
                MessageBox.Show("Проверьте информацию");
            else
            {
                //TODO save data
                mainProfile.NumberOrAdress = textBox1.Text;
                mainProfile.Password = maskedTextBox1.Text;
                mainProfile.Browser = radioButton1.Checked.ToString();

                //BinaryFormatter binaryFormatter = new BinaryFormatter();
                //using (FileStream stream = new FileStream("C:\\Data Analysis\\key.bin", FileMode.OpenOrCreate))
                //{
                //    binaryFormatter.Serialize(stream, Crypter.key);
                //}



                var jsonSerializer = new DataContractJsonSerializer(typeof(SettingMainProfile));
                using(var file = new FileStream("C:\\Data Analysis\\MainProfile.json", FileMode.OpenOrCreate))
                {
                    jsonSerializer.WriteObject(file, mainProfile);
                }


                Hide();
            }
        }
    }
}
