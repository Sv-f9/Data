using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.IO;
using LiveCharts;
using LiveCharts.Wpf;

namespace Data
{

    public partial class ShowDataControl : UserControl
    {
        public ShowDataControl()
        {
            InitializeComponent();
            pieChart1.Hide();
            pictureBox1.Hide();
            panel3.Hide();
            label2.Hide();
            listBox2.Hide();
            metroTile1.Hide();

            label3.Hide();
            label4.Hide();
            label7.Hide();
            label6.Hide();
            label9.Hide();
            label10.Hide();

            metroTile4.Show();
            textBox1.Show();
            label5.Show();
            listBox1.Show();
            label1.Show();

            List<string> profiles = new List<string>();
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<string>));
            try
            {
                using (var file = new FileStream($"C:\\Data Analysis\\Persons.json", FileMode.OpenOrCreate))
                {
                    profiles = jsonFormatter.ReadObject(file) as List<string>;
                }
            }
            catch (System.Runtime.Serialization.SerializationException) { };
            
            foreach(var profile in profiles)
            {

                listBox1.Items.Add($"Профиль:{profile}");
            } 
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        User profile;
        private void metroTile4_Click(object sender, EventArgs e)
        {
            metroTile2.Hide();
            string selectedProfile = "";

            if ((listBox1.SelectedItem == null) && (textBox1.Text == ""))
            {
                MessageBox.Show("Выберите профиль");
                return;
            }
            else if (textBox1.Text != "")
            {
                selectedProfile = textBox1.Text;

            }
            else if (listBox1.SelectedItem != null)
            {
                selectedProfile = listBox1.SelectedItem.ToString();
            }




            metroTile4.Hide();
            textBox1.Hide();
            label5.Hide();
            listBox1.Hide();
            label1.Hide();


            pieChart1.Show();
            pictureBox1.Show();
            panel3.Show();
            label2.Show();
            listBox2.Show();
            metroTile1.Show();

            label3.Show();
            label4.Show();
            label7.Show();
            label6.Show();
            label9.Show();
            label10.Show();

            profile = new User();
            var jsonFormatter = new DataContractJsonSerializer(typeof(User));
            if (selectedProfile.IndexOf("Профиль") == 0)
                selectedProfile = selectedProfile.Remove(0, 8);
            try
            {
                using (var file = new FileStream($"C:\\Data Analysis\\{selectedProfile}\\{selectedProfile}.json", FileMode.OpenOrCreate))
                {
                    profile = jsonFormatter.ReadObject(file) as User;
                }
            }
            catch (System.Runtime.Serialization.SerializationException) { };

            pictureBox1.Image = new Bitmap($"C:\\Data Analysis\\{selectedProfile}\\{selectedProfile}.bmp");

            label2.Text = "Ник, Кол-во лайков";
            string mostLikeProfile = "";
            int max = -1; 
            foreach (SidePerson sidePerson in profile.personsLikes)
            {
                if (max < sidePerson.countLikes)
                {
                    max = sidePerson.countLikes;
                    mostLikeProfile = sidePerson.name;
                }
                listBox2.Items.Add($"{sidePerson.name} - {sidePerson.countLikes}");
            }

            label4.Text = profile.allCountLikes.ToString();
            label6.Text = profile.personsLikes.Count.ToString();
            label10.Text = mostLikeProfile;

            pieChart1.Show();
            SeriesCollection seriesViews = new SeriesCollection();
            seriesViews.Add(new PieSeries() { Title = "Подписчики", Values = new ChartValues<int> { profile.countSubscribers }, DataLabels = true });
            seriesViews.Add(new PieSeries() { Title = "Подписки", Values = new ChartValues<int> { profile.countSubscriptions }, DataLabels = true });
            pieChart1.Series = seriesViews;
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            pieChart1.Hide();
            pictureBox1.Hide();
            panel3.Hide();
            label2.Hide();
            listBox2.Hide();
            metroTile1.Hide();

            label3.Hide();
            label4.Hide();
            label7.Hide();
            label6.Hide();
            label9.Hide();
            label10.Hide();

            metroTile4.Show();
            textBox1.Show();
            label5.Show();
            listBox1.Show();
            label1.Show();
            listBox2.Items.Clear();
            metroTile2.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null)
            {
                MessageBox.Show("Выберите профиль");
                return;
            }

            string selectedProfile = listBox2.SelectedItem.ToString();
            selectedProfile = selectedProfile.Remove(selectedProfile.IndexOf(" - "));
            try
            {
                pictureBox1.Image = new Bitmap($"C:\\Data Analysis\\{profile.profileName}\\PhotoSidePersons\\{selectedProfile}.bmp");

            }
            catch 
            {
                try
                {
                    pictureBox1.Image = new Bitmap($"C:\\Data Analysis\\{profile.profileName}\\PhotoSubcribers\\{selectedProfile}.bmp");
                }
                catch
                {
                    pictureBox1.Image = new Bitmap($"C:\\Data Analysis\\{profile.profileName}\\PhotoSubscriptions\\{selectedProfile}.bmp");
                }
            }


        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            string userFromBox;
    
            foreach (SidePerson sidePerson in profile.personsSubcribers)
            {
                foreach (string selectedProfile in listBox2.Items)
                {
                    userFromBox = selectedProfile.Remove(selectedProfile.IndexOf(" - "));
                    if (userFromBox == sidePerson.name)
                    {
                        sidePerson.name = null;
                    }
                }
            }

            foreach(var sidePerson in profile.personsSubcribers)
            {
                if (sidePerson.name != null)
                    listBox2.Items.Add($"{sidePerson.name} - 0");
            }


        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            string mostLikeProfile = "";
            int max = -1;
            foreach (SidePerson sidePerson in profile.personsLikes)
            {
                if (max < sidePerson.countLikes)
                {
                    max = sidePerson.countLikes;
                    mostLikeProfile = sidePerson.name;
                }
                listBox2.Items.Add($"{sidePerson.name} - {sidePerson.countLikes}");
            }
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            string userFromBox;

            foreach (SidePerson sidePerson in profile.personsSubscriptions)
            {
                foreach (string selectedProfile in listBox2.Items)
                {
                    userFromBox = selectedProfile.Remove(selectedProfile.IndexOf(" - "));
                    if (userFromBox == sidePerson.name)
                    {
                        sidePerson.name = null;
                    }
                }
            }

            foreach (var sidePerson in profile.personsSubcribers)
            {
                if (sidePerson.name != null)
                    listBox2.Items.Add($"{sidePerson.name} - 0");
            }
        }
    }
}
