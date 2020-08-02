using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Data
{

    public partial class AllCollectControl : UserControl
    {

        public AllCollectControl()
        {
            InitializeComponent();
            
            progressBar1.Hide();
            metroTile4.Hide();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        static bool killProcess = false;
        private void metroTile4_Click(object sender, EventArgs e)
        {
            metroTile4.Hide();
            progressBar1.Hide();
            metroTile3.Show();
            label3.Show();
            textBox1.Show();
            metroTile3.BringToFront();
            label3.BringToFront();
            textBox1.BringToFront();
            textBox1.Text = "";
            progressBar1.Value = 0;
            killProcess = true;
        }


        private void changeProgressBar(object param)
        {
            SynchronizationContext synchronizationContext = param as SynchronizationContext;
            synchronizationContext.Send(progressBar, 4);

        }
        private void progressBar(object i)
        {
            progressBar1.Value = Convert.ToInt32(i);
        }

        void workWithDirectory(User user)
        {
            try
            {
                Directory.Delete($"C:\\Data Analysis\\{user.profileName}", true);
            }
            catch { }
            Directory.CreateDirectory($"C:\\Data Analysis\\{user.profileName}");
            Directory.CreateDirectory($"C:\\Data Analysis\\{user.profileName}\\PhotoSidePersons");
            Directory.CreateDirectory($"C:\\Data Analysis\\{user.profileName}\\PhotoSubcribers");
            Directory.CreateDirectory($"C:\\Data Analysis\\{user.profileName}\\PhotoSubscriptions");
        }

        async private void metroTile3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите данные");
                return;
            }
            #region Form Visualization
            label3.Hide();
            textBox1.Hide();
            metroTile3.Hide();
            progressBar1.Show();
            progressBar1.BringToFront();
            metroTile4.Show();
            metroTile4.BringToFront();
            #endregion


            DataCollection dataCollection = null;

            #region Main Selenium

            User user = new User(textBox1.Text);
            await Task.Run(() => {

                dataCollection = new DataCollection();
                dataCollection.OnInitWebDriver(user);
            });
            if (dataCollection.threeStep[0] == false)//Не удалось подключиться к интернету первый шаг провален
                return;

            await Task.Run(() =>
            {
                Parallel.Invoke
                (
                    () =>
                    {
                        workWithDirectory(user);
                        user.countPhoto = dataCollection.calculateCountPhoto();
                        user.countSubscribers = dataCollection.calculateCountSubscribers();
                        
                    },
                    () =>
                    {
                        user.countSubscriptions = dataCollection.calculateCountSubscriptions();
                        user.countNoted = dataCollection.calculateCountNoted();
                        dataCollection.savePhotoCurrentProfile(user.profileName);
                    }
                );
                dataCollection.findPersonsSubscriptions(user);
                dataCollection.findPersonsSubcribers(user);
            });


            


            Thread thread = new Thread(changeProgressBar);
            var context = SynchronizationContext.Current;
            thread.Start(context);

            try
            {
                for (double i = 0; i < user.countPhoto;)
                {
                    if (killProcess == true)
                        break;
                    await Task.Run(() => { Task.Delay(50); dataCollection.findPersonsLikes(user, Convert.ToInt32(i), Convert.ToInt32(i += user.countPhoto * 0.0625)); });
                    progressBar1.Value += 6;

                }
            }
            catch { }
            var jsonFormatter = new DataContractJsonSerializer(typeof(User));
            using (var file = new FileStream($"C:\\Data Analysis\\{user.profileName}\\{user.profileName}.json", FileMode.Create))
            {
                jsonFormatter.WriteObject(file, user);
            }

            List<string> profiles = new List<string>();
            jsonFormatter = new DataContractJsonSerializer(typeof(List<string>));
            try
            {
                using (var file = new FileStream($"C:\\Data Analysis\\Persons.json", FileMode.OpenOrCreate))
                {
                    profiles = jsonFormatter.ReadObject(file) as List<string>;
                }

                foreach (var profile in profiles)
                {
                    if (profile == user.profileName)
                    {
                        profiles.Remove(profile);
                        break;
                    }
                }
            }
            catch (System.Runtime.Serialization.SerializationException) { };
            profiles.Add(user.profileName);
            using (var file = new FileStream($"C:\\Data Analysis\\Persons.json", FileMode.Open))
            {
                jsonFormatter.WriteObject(file, profiles);
            }

            dataCollection.Quit();

            #endregion



            metroTile4.Hide();
            progressBar1.Value = 0;
            progressBar1.Hide();
            textBox1.Text = "";
            textBox1.Show();
            metroTile3.Show();

        }
    }
}
