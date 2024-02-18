using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.BL.Utilities
{
    public static class Security
    {
        // Se toma de los parametros de la llave de seguridad
        static string secretKey = ConfigurationManager.AppSettings["EncryptionKeySHA256"];

        // Set your salt here, change it to meet your flavor:
        // The salt bytes must be at least 8 bytes.
        static byte[] salt = Encoding.UTF8.GetBytes(secretKey);

        public static string Encrypt(string toEncrypt)
        {
            string value = string.Empty;

            try
            {
                //Se genera el hash de los bytes de la llave
                byte[] secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);
                secretKeyBytes = SHA256.Create().ComputeHash(secretKeyBytes);

                //Se generan los bytes del string a encriptar
                byte[] bytesToBeEncrypted = Encoding.UTF8.GetBytes(toEncrypt);

                //Se encriptan ambos hash con la llave
                byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, secretKeyBytes);

                //Se retorna el valor
                value = Convert.ToBase64String(bytesEncrypted);

            }
            catch (Exception ex)
            {
                
            }

            return value;
        }

        public static string Decrypt(string cipherString)
        {
            string value = string.Empty;

            try
            {
                //Se genera el hash de los bytes de la llave
                byte[] secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);
                secretKeyBytes = SHA256.Create().ComputeHash(secretKeyBytes);

                // Se toman los Bytes del string cifrado
                byte[] bytesToBeDecrypted = Convert.FromBase64String(cipherString);

                //Se desencripta el texto
                byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, secretKeyBytes);

                value = Encoding.UTF8.GetString(bytesDecrypted);

            }
            catch (Exception ex)
            {
                
            }

            return value;
        }

        private static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = new byte[1];

            //Stream para generar el cifrado/descifrado
            MemoryStream ms = new MemoryStream();

            var AES = Aes.Create("AesManaged");

            if (AES != null)
            {
                AES.KeySize = 256;
                AES.BlockSize = 128;

                var key = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);

                AES.Mode = CipherMode.CBC;

                using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                    cs.Close();
                }

                encryptedBytes = ms.ToArray();
            }

            return encryptedBytes;
        }

        private static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = new byte[1];

            //Stream para generar el cifrado/descifrado
            MemoryStream ms = new MemoryStream();

            var AES = Aes.Create("AesManaged");

            if (AES != null)
            {
                AES.KeySize = 256;
                AES.BlockSize = 128;

                var key = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);

                AES.Mode = CipherMode.CBC;

                using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                    cs.Close();
                }

                decryptedBytes = ms.ToArray();
            }
            return decryptedBytes;
        }
    }
}
