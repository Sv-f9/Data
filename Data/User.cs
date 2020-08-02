using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    [DataContract]
    public sealed class User
    {
        public User()
        {
            countphoto = countsubscribers = countsubscriptions = -1;
            allCountLikes = 0;
            personsLikes = new List<SidePerson>();
        }
        internal User(string name) : this()
        {
            profileName = name;
        }
        [DataMember]
        public string profileName { get; set; }// Ник главного профиля 
        
        //[DataMember]
        //public Bitmap profilePhoto { get; set; }//Главная фотография

        [DataMember]
        private int countphoto;//Кол-во выложенных фотографий
        public int countPhoto
        {
            get
            {
                return countphoto >= 0 ? countphoto : -1;
            }
            set
            {
                countphoto = value >= 0 ? value : -1;
            }
        }
        [DataMember]
        private int countsubscribers;//Кол-во подписчиков 
        public int countSubscribers
        {
            get
            {
                return countsubscribers >= 0 ? countsubscribers : -1;
            }
            set
            {
                countsubscribers = value >= 0 ? value : -1;
            }
        }
        [DataMember]
        private int countsubscriptions;//Кол-во подписок
        public int countSubscriptions
        {
            get
            {
                return countsubscriptions >= 0 ? countsubscriptions : -1;
            }
            set
            {
                countsubscriptions = value >= 0 ? value : -1;
            }
        }
        [DataMember]
        public int allCountLikes { get; set; }//Общее кол-во лайков со всех фотографий
        [DataMember]
        public List<SidePerson> personsLikes { get; set; }//Люди, которые лайкали профиль (ник, кол-во лайков, его фото)
        [DataMember]
        public List<SidePerson> personsSubcribers { get; set; }//Люди, которые подписаны на главный профиль
        [DataMember]
        public List<SidePerson> personsSubscriptions { get; set; }//Люди, на которых подписан главный профиль
        [DataMember]
        public int countNoted { get; set; }//Кол-во фотографий на которых отметили главный профиль
        [DataMember]
        private int activityProfile;
        public int ActivityProfile { get { return activityProfile; } set { activityProfile = countNoted * 10 + countsubscribers * 5 + countphoto * 3 + countsubscriptions * 2 + allCountLikes; } }//Коэффициент активности профиля 



    }
}
