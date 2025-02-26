using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.Remoting.Messaging;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;

namespace MajorProject
{
    public class NewChat
    {
        public DateTime _Time;
        public NewFriend _Friend;
        public string _Name;
        public string _Text;
        public DateTime Time
        {
            get { return _Time; }
            set { _Time = value; }
        }
        public NewFriend Friend
        {
            get { return _Friend; }
            set { _Friend = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
        }

        public NewChat(DataRow DR, NewFriend f)
        {
            _Time = Convert.ToDateTime(DR["TimeStamp"]);
            _Friend = f;
            _Name = Convert.ToString(DR["Sender"]);

            byte[] encryptedMsg = Convert.FromBase64String(Convert.ToString(DR["Text"]));
            byte[] aesKey = Convert.FromBase64String(Convert.ToString(DR["Key"]));
            byte[] aesVector = Convert.FromBase64String(Convert.ToString(DR["Vector"]));
            _Text = Decrypt(encryptedMsg, aesKey, aesVector);
        }

        static string Decrypt(byte[] encrypted, byte[] aesKey, byte[] aesVector)
        {
            string decryptedText;

            using (Aes AES = Aes.Create())
            {
                AES.Key = aesKey;
                AES.IV = aesVector;

                using (MemoryStream memory = new MemoryStream(encrypted))
                {
                    using (CryptoStream crypto = new CryptoStream(memory, AES.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(crypto))
                        {
                            decryptedText = reader.ReadToEnd();
                        }
                    }
                }
            }

            return decryptedText;
        }
    }
}
