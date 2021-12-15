using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Blazorise;

namespace Sep3Vacation.Data
{
    public class CryptoService :ICryptoService
    {
        private static string MyKey = "*&^@Encrpt##Passw3221*&^@";
        ////Symmetric key, encrypting and decrypting with same key

        public async Task<string> Encrypt(string toEncrypt)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);
            string key = MyKey;
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            hashmd5.Clear();

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cryptoTransform = tdes.CreateEncryptor();
            byte[] resultArray = cryptoTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            tdes.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public async Task<string> Decrypt(string cipherString)
        {
            byte[] keyArray;
            byte[] toDecryptArray = Convert.FromBase64String(cipherString);

            string key = MyKey;

            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            hashmd5.Clear();

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cryptoTransform = tdes.CreateDecryptor();
            byte[] resultArray = cryptoTransform.TransformFinalBlock(toDecryptArray, 0, toDecryptArray.Length);
            
            tdes.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }
    }
}