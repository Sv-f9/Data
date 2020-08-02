using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.Serialization;
using Newtonsoft.Json;
namespace Data
{
    internal class Crypter
    {
         // private static string key = "<RSAKeyValue><Modulus>nd/FeRWSJUQTmQFSrSKRCwuo583N7P8+5lXHn3niDBehJw/UmW7KtVQM+9gSYVlHDHcTJGtDPsxiNIg+6/LDs7babzASfY7mLQUB1+1B4GwnExlL+JX2hoqVnZ+wgcoFGUIJT22i/zWk7hyCx26NMwZrz3DRuqy8iCj0+pctLp0=</Modulus><Exponent>AQAB</Exponent><P>zJlBK08CS3KqMrbsp5APJn6sBlR/8EyvgGkspquOx6HEurzAvSoE2dBx4jfOsmsT4bNrl2z59wQbOQBIVd1y0w==</P><Q>xYlufmlORS3fem65HmHQX4awJl738Mee2drjIKUcliidEz022KGh6wb3N5wnv+NY9DgnwZCyT5U3K/WwnTuSzw==</Q><DP>k/SL5SbIsQjlvbD86JvL6PmXqyg2MO8zxzfHm2va39DDNItFEkatpVoQ0ReseOfoQ8J9Hs8m4JPun8TtinKPEw==</DP><DQ>k5GSsO78YOPfInia5J6P6v0UlOW3dfG6suc5bAbM70RR67B8S6Ob8ZcXkjye2VP+/RsCYDE3dAp11+pIUX3Ssw==</DQ><InverseQ>I87Xfap7lnZ+v8J9xaG5Vpd+q1k3PsEDy5so+IajjxTpuW2WqlMfr88eKZmk1W52CCqV2BmrZ41lsRpPEFvRKQ==</InverseQ><D>ONiQVG8t9nkyzU8qo+jkbSO/p+f1FDc8QNf2Tzgl6tC/WD9c//pixzQCkNRWmfL5oEVoAR8WUZBqdBvy/CanzIdoGnCYG8da79v9D5oUNp6m2SUMLJv1MOJFG1wj9iN2aQRDWhAAHHpRpmk25U1OlTJ1mi3CT4T7fKqcMc0Q7Uk=</D></RSAKeyValue>";
        internal static string key;
        public static string Encrypt(string data)
        {
            
            RSACryptoServiceProvider rSA = new RSACryptoServiceProvider();
            //   key = rSA.ToXmlString(true);
            key = rSA.ToXmlString(true);
            rSA.FromXmlString(key);

            byte[] encrData = rSA.Encrypt(Encoding.UTF8.GetBytes(data), false);

            return Convert.ToBase64String(encrData);
        }
        public static string Decrypt(string data)
        {
           // RSACryptoServiceProvider rSA = new RSACryptoServiceProvider();
           // //   key = rSA.ToXmlString(true);
           //// key = rSA.ToXmlString(true);
           // rSA.FromXmlString(key);
           // byte[] decrData = rSA.Decrypt(Convert.FromBase64String(data), true);
           // data = Encoding.UTF8.GetString(decrData);

            return data;
        }
    }
}
