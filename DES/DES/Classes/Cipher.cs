using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DES.Classes
{
    internal class Cipher
    {
        public string Encrypt(string text, string key, CipherMode mode)
        {
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                des.Mode = mode;
                des.Padding = PaddingMode.PKCS7;

                byte[] Key = Encoding.UTF8.GetBytes(key);

                using (MemoryStream ms = new MemoryStream())
                {
                    des.GenerateIV();
                    ms.Write(des.IV, 0, des.IV.Length);

                    using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(Key, des.IV), CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(text);
                        }
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        public string Decrypt(string encryptedText, string key, CipherMode mode)
        {
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                des.Mode = mode;
                des.Padding = PaddingMode.PKCS7;

                byte[] Key = Encoding.UTF8.GetBytes(key);
                byte[] encryptedData = Convert.FromBase64String(encryptedText);
                byte[] iv = new byte[des.IV.Length];

                Array.Copy(encryptedData, iv, iv.Length);

                using (MemoryStream ms = new MemoryStream(encryptedData, iv.Length, encryptedData.Length - iv.Length))
                {
                    using (CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(Key, iv), CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(cs))
                        {
                            return reader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
