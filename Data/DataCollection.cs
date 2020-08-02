using Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.RightsManagement;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data
{
    class DataCollection
    {
        private string startUrl;
        private IWebDriver webDriver;
        private IWebDriver webDriverForSavePhoto;
        private Actions actions;
        private FirefoxOptions firefoxOptions;
        private ChromeOptions chromeOptions;
        private WebDriverWait webDriverWait;
        public bool[] threeStep;
        public DataCollection()
        {
            threeStep = new bool[] { true, true, true };
            if (SettingControl.mainProfile.Browser != "true")
            {
                firefoxOptions = new FirefoxOptions();
                firefoxOptions.AddArgument("--headless");

                webDriverForSavePhoto = new FirefoxDriver(firefoxOptions);
                webDriver = new FirefoxDriver(firefoxOptions);

            }
            else
            {
                chromeOptions = new ChromeOptions();
                chromeOptions.AddArgument("--headless");

                webDriverForSavePhoto = new ChromeDriver(chromeOptions);
                webDriver = new ChromeDriver(chromeOptions);

            }

            webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(30));

        }

        private int calculateCountLikesCurrentPhoto()
        {
            int countLikesCurrentPhoto;
            int number;
            webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector(".Nm9Fw button span")));
            string countLikesStringFormat = webDriver.FindElement(By.CssSelector(".Nm9Fw button span")).Text;
            while ((number = countLikesStringFormat.IndexOf(' ')) != -1)
            {
                countLikesStringFormat = countLikesStringFormat.Remove(number, 1);
            }
            countLikesCurrentPhoto = Convert.ToInt32(countLikesStringFormat);//Kоличество лайков текушей фотографии

            return countLikesCurrentPhoto;
        }
        public void OnInitWebDriver(User user)
        {
            webDriver.Navigate().GoToUrl("https://www.instagram.com/");

            webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector("input[aria-label^='П']")));

            webDriver.FindElement(By.CssSelector("input[aria-label^='Н']")).SendKeys(SettingControl.mainProfile.NumberOrAdress);
            webDriver.FindElement(By.CssSelector("input[aria-label^='П']")).SendKeys(SettingControl.mainProfile.Password);
            webDriver.FindElement(By.CssSelector("button[type='submit']")).Click();
            try
            {
                webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector("input[placeholder='Поиск']")));
                webDriver.FindElement(By.CssSelector("input[placeholder='Поиск']")).SendKeys(user.profileName);
            }
            catch
            {
                MessageBox.Show("Не удалось подключиться к интернету");
                threeStep[0] = false;
            }
            webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector(".yCE8d")));
            webDriver.FindElement(By.CssSelector(".yCE8d")).FindElement(By.CssSelector(".Ap253")).Click();

            startUrl = webDriver.Url;

        }
        public int calculateCountPhoto()
        {
            int countPhoto;
            webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector("span[class='g47SY ']")));
            if (!webDriver.FindElements(By.CssSelector("span[class='g47SY ']"))[0].Text.Contains(' '))
            {
                countPhoto = Convert.ToInt32(webDriver.FindElements(By.CssSelector("span[class='g47SY ']"))[0].Text);
            }
            else
            {
                int numberDeleteElement = webDriver.FindElements(By.CssSelector("span[class='g47SY ']"))[0].Text.IndexOf(' ');
                countPhoto = Convert.ToInt32(webDriver.FindElements(By.CssSelector("span[class='g47SY ']"))[0].Text.Remove(numberDeleteElement, numberDeleteElement));
            }
            return countPhoto;
        }
        public int calculateCountSubscribers()
        {
            int countSubscribers;
            webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector("span[class='g47SY ']")));
            try
            {
                countSubscribers = Convert.ToInt32(webDriver.FindElements(By.CssSelector("span[class='g47SY ']"))[1].Text);
            }
            catch
            {
                int lenght = webDriver.FindElements(By.CssSelector("span[class='g47SY ']"))[1].Text.Length;
                countSubscribers = Convert.ToInt32(webDriver.FindElements(By.CssSelector("span[class='g47SY ']"))[1].Text.Remove(lenght - 3, lenght - 1)) * 1000000;
            }
            return countSubscribers;
        }
        public int calculateCountSubscriptions()
        {
            int countSubscriptions;
            webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector("span[class='g47SY ']")));
            countSubscriptions = Convert.ToInt32(webDriver.FindElements(By.CssSelector("span[class='g47SY ']"))[2].Text);
            return countSubscriptions;
        }

        public int calculateCountNoted()
        {
            int countNoted;
            try
            {
                webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector("a[class='_9VEo1 '] svg[aria-label='Отметки']")));
                webDriver.FindElement(By.CssSelector("a[class='_9VEo1 '] svg[aria-label='Отметки']")).Click();

                webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector("div[class = 'v1Nh3 kIKUG  _bz0w']")));
                webDriver.FindElement(By.CssSelector("div[class = 'v1Nh3 kIKUG  _bz0w']")).Click();
            }
            catch
            {
                webDriver.Navigate().GoToUrl(startUrl);// Перезагружаем текущую страницу
                return countNoted = 0;
            }


            countNoted = 1;


            try
            {
                while (true)
                {
                    webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector(" a[ class =' _65Bje  coreSpriteRightPaginationArrow']")));
                    webDriver.FindElement(By.CssSelector(" a[ class =' _65Bje  coreSpriteRightPaginationArrow']")).Click();
                    countNoted++;
                }
            }
            catch
            {
                webDriver.FindElement(By.CssSelector(".wpO6b svg[aria-label='Закрыть']")).Click();//Закрываем текущую фотографию
                webDriver.Navigate().GoToUrl(startUrl);// Перезагружаем текущую страницу
                return countNoted;
            }
        }



        public void savePhotoCurrentProfile(string name)
        {
            webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector("img[class='_6q-tv']")));
            webDriverForSavePhoto.Navigate().GoToUrl(webDriver.FindElement(By.CssSelector("img[class='_6q-tv']")).GetAttribute("src"));
            (new Bitmap(new MemoryStream(((ITakesScreenshot)webDriverForSavePhoto).GetScreenshot().AsByteArray))).Save($"C:\\Data Analysis\\{name}\\{name}.bmp");
        }

        public void findPersonsLikes(User userCollectData, int numberFirstPhoto, int numberLastPhoto)
        {

            if (numberFirstPhoto == numberLastPhoto)
                return;

            if (numberFirstPhoto > numberLastPhoto)
                throw new ArgumentException("Номер до какой картинки, не может быть меньше номера от какой картинки");

            //     webDriverWait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(60));
            webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector(".eLAPa")));
            webDriver.FindElement(By.CssSelector(".eLAPa")).Click();//Находим первую фотографию и нажимаем на нее
            for (int numberCurrentPhoto = 0; numberCurrentPhoto < numberFirstPhoto; numberCurrentPhoto++)//Пропускаем не нужные фотографии
            {
                webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector("a[class^=' _']")));
                webDriver.FindElement(By.CssSelector("a[class^=' _']")).Click();//Переходим к следующей фотографии

            }
            for (int numberCurrentPhoto = numberFirstPhoto; numberCurrentPhoto < numberLastPhoto; numberCurrentPhoto++)
            {
                try
                {
                    int countLikesCurrentPhoto = calculateCountLikesCurrentPhoto();


                    webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector(".Nm9Fw button")));
                    webDriver.FindElement(By.CssSelector(".Nm9Fw button")).Click();//Заходим в список аккаунтов, кто лайкал данную фотографию
                  
                    userCollectData.allCountLikes += countLikesCurrentPhoto;

                    // save Persons
                    SavePersonsCurrentScrollBar(webDriver, userCollectData.personsLikes, userCollectData.profileName, countLikesCurrentPhoto, "div[aria-labelledby^='f']", "PhotoSidePersons");


                }
                catch (OpenQA.Selenium.WebDriverTimeoutException) { }


                try
                {
                    // webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector("a[class^=' _']")));
                    webDriver.FindElement(By.CssSelector("a[class^=' _']")).Click();//Переходим к следующей фотографии
                }
                catch (OpenQA.Selenium.NoSuchElementException) { break; }
            }
            webDriver.FindElement(By.CssSelector(".wpO6b svg[aria-label='Закрыть']")).Click();//Закрываем текущую фотографию
            webDriver.Navigate().GoToUrl(webDriver.Url);// Перезагружаем текущую страницу

        }

        public void findPersonsSubcribers(User user)
        {
            user.personsSubcribers = new List<SidePerson>();
            try
            {

                webDriver.FindElement(By.CssSelector("a[class='-nal3 ']")).Click();

                webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector(".m82CD")));
                actions = new Actions(webDriver);
                for (int i = 0; i < 10; i++)
                    actions.SendKeys(OpenQA.Selenium.Keys.Tab).Build().Perform();
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                    actions.SendKeys(OpenQA.Selenium.Keys.PageDown).Build().Perform();
                }


                foreach (IWebElement webElement in webDriver.FindElements(By.CssSelector("li[class='wo9IH']")))//Проходимся по всем пользователям
                {

                    webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector("img[src^='http']")));
                    webDriverForSavePhoto.Navigate().GoToUrl(webElement.FindElement(By.CssSelector("img[src^='http']")).GetAttribute("src"));

                    user.personsSubcribers.Add(new SidePerson(webElement.FindElement(By.CssSelector("a[title]")).Text));

                    new Bitmap(new MemoryStream(((ITakesScreenshot)webDriverForSavePhoto).GetScreenshot().AsByteArray)).Save($"C:\\Data Analysis\\{user.profileName}\\PhotoSubcribers\\{webElement.FindElement(By.CssSelector("a[title]")).Text}.bmp");

                }
 
                webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector("div[class='WaOAr'] button[type='button']")));
                webDriver.FindElement(By.CssSelector("div[class='WaOAr'] button[type='button']")).Click();//Закрываем список аккаунтов, кто лайкал текущее фото      

            }
            catch (OpenQA.Selenium.WebDriverTimeoutException) { }

        }

        public void findPersonsSubscriptions(User user)
        {
            user.personsSubscriptions = new List<SidePerson>();
            try
            {

                webDriver.FindElements(By.CssSelector("a[class='-nal3 ']"))[1].Click();

                webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector(".m82CD")));
                actions = new Actions(webDriver);
                for (int i = 0; i < 10; i++)
                    actions.SendKeys(OpenQA.Selenium.Keys.Tab).Build().Perform();
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                    actions.SendKeys(OpenQA.Selenium.Keys.PageDown).Build().Perform();
                }


                foreach (IWebElement webElement in webDriver.FindElements(By.CssSelector("li[class='wo9IH']")))//Проходимся по всем пользователям
                {

                    webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector("img[src^='http']")));
                    webDriverForSavePhoto.Navigate().GoToUrl(webElement.FindElement(By.CssSelector("img[src^='http']")).GetAttribute("src"));

                    user.personsSubscriptions.Add(new SidePerson(webElement.FindElement(By.CssSelector("a[title]")).Text));

                    new Bitmap(new MemoryStream(((ITakesScreenshot)webDriverForSavePhoto).GetScreenshot().AsByteArray)).Save($"C:\\Data Analysis\\{user.profileName}\\PhotoSubscriptions\\{webElement.FindElement(By.CssSelector("a[title]")).Text}.bmp");

                }




                webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector("div[class='WaOAr'] button[type='button']")));
                webDriver.FindElement(By.CssSelector("div[class='WaOAr'] button[type='button']")).Click();//Закрываем список аккаунтов, кто лайкал текущее фото      

            }
            catch (OpenQA.Selenium.WebDriverTimeoutException) { }
        }

        public void Quit()
        {
            webDriver.Dispose();
            webDriver.Quit();
            webDriverForSavePhoto.Quit();
        }

        private void SavePersonsCurrentScrollBar(IWebDriver webDriver, List<SidePerson> usersCollectData, string profileName, int countDefinitionsCurrentTask, string searchThrough, string mode) // Поиск людей текущего листа
        {

            webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector(searchThrough)));
            actions = new Actions(webDriver);
            for (int i = 0; i < 7; i++)//43 or 43/3
            {
                actions.MoveToElement(webDriver.FindElement(By.CssSelector(searchThrough))).SendKeys(OpenQA.Selenium.Keys.Tab).Build().Perform();
            }

            SortedDictionary<string, Bitmap> usersOnePhoto = new SortedDictionary<string, Bitmap>();//Люди, которые лайкали данное фото

            while (countDefinitionsCurrentTask != usersOnePhoto.Count)
            {

                try
                { 
                    foreach (IWebElement webElement in webDriver.FindElements(By.CssSelector(searchThrough)))//Проходимся по всем пользователям
                    {

                        webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector("img[src^='http']")));
                        webDriverForSavePhoto.Navigate().GoToUrl(webElement.FindElement(By.CssSelector("img[src^='http']")).GetAttribute("src"));


                        if (!usersOnePhoto.ContainsKey(webElement.FindElement(By.CssSelector("a[title]")).Text))//Если такой пользователь не встречался, то добавляем его
                        {
                            usersOnePhoto.Add(webElement.FindElement(By.CssSelector("a[title]")).Text, new Bitmap(new MemoryStream(((ITakesScreenshot)webDriverForSavePhoto).GetScreenshot().AsByteArray)));

                        }


                    }
                }
                catch { }

                IWebElement element = webDriver.FindElements(By.CssSelector(searchThrough)).Last();
                actions = new Actions(webDriver);
                try
                {
                    for (int i = 0; i < 5; i++)
                        actions.MoveToElement(webDriver.FindElement(By.CssSelector(searchThrough))).SendKeys(OpenQA.Selenium.Keys.Tab).Build().Perform();//Прокручиваем ниже список тех людей, кто лайкнул данное фото
                }
                catch
                {
                    actions = new Actions(webDriver);
                    for (int i = 0; i < 5; i++)
                        actions.SendKeys(OpenQA.Selenium.Keys.Tab).Perform();
                }

                try
                {
                    if (element.Text == webDriver.FindElements(By.CssSelector(searchThrough)).Last().Text)
                        break;
                }
                catch
                {
                    break;
                }
            }


            bool checkPerson = false;
            foreach (var user in usersOnePhoto)
            {
                checkPerson = false;
                foreach (var personLike in usersCollectData)
                {
                    if (user.Key == personLike.name)
                    {
                        personLike.countLikes++;
                        checkPerson = true;
                    }
                }
                if (checkPerson == false)
                {
                    usersCollectData.Add(new SidePerson(user.Key, 1));//Добавляем людей(кто лайкнул текущую фотографию) ко всем людям
                    user.Value.Save($"C:\\Data Analysis\\{profileName}\\{mode}\\{user.Key}.bmp");
                }
            }



            webDriverWait.Until(ExpectedConditions.ElementExists(By.CssSelector("div[class='WaOAr'] button[type='button']")));
            webDriver.FindElement(By.CssSelector("div[class='WaOAr'] button[type='button']")).Click();//Закрываем список аккаунтов, кто лайкал текущее фото      
        }

    }



}

