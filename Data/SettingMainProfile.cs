using System;
using System.Runtime.Serialization;

namespace Data
{
    [DataContract]
    public class SettingMainProfile
    {
        [DataMember]
        private string numberOrAdress;
        public string NumberOrAdress
        {
            get
            {
                //     return Crypter.Decrypt(numberOrAdress);
                return numberOrAdress;
            }
            set
            {
                //numberOrAdress = Crypter.Encrypt(value);
                numberOrAdress = value;
            }
        }
        [DataMember]
        private string password;
        public string Password
        {
            get
            {
                //  return Crypter.Decrypt(password);
                return password;
            }
            set 
            {
                //    password = Crypter.Encrypt(value);
                password = value;
            }
        }
        [DataMember]
        private string browser;
        public string Browser
        {
            get
            {
                //return Crypter.Decrypt(browser);
                return browser;
            }
            set
            {
                //browser = Crypter.Encrypt(value);
                browser = value;
            }
        }
     
       // public string key { get; set; }

    }
}
