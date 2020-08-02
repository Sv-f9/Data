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
    public class SidePerson
    {
        [DataMember]
        public string name { get; set; } //Его никнейм
        [DataMember]
        public int countLikes { get; set; }//Сколько поставил лайков

       // public Bitmap photoSidePerson { get; set; }// Фото профиля


        public SidePerson(string Name)
        {
            name = Name;
            countLikes = 0;
        } 

        public SidePerson(string Name, int CountLikes) :this(Name)
        {
            name = Name;
            countLikes = CountLikes;
        }

    }
}
