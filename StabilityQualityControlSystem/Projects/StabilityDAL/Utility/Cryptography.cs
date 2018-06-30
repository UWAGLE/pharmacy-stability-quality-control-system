using System;
using System.IO;
using System.Security.Cryptography;

namespace StabilityDAL
{
    public static class Cryptography
    {
        private const String key = "UJhgWAf5_55";

        public static String Encode(String value)
        {
            try
            {
                var des = new TripleDESCryptoServiceProvider { IV = new byte[8] };
                var pdb = new PasswordDeriveBytes(key, new byte[-1 + 1]);
                des.Key = pdb.CryptDeriveKey("RC2", "MD5", 128, new byte[8]);
                var ms = new MemoryStream((value.Length * 2) - 1);
                var encStream = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
                var plainBytes = System.Text.Encoding.UTF8.GetBytes(value);
                encStream.Write(plainBytes, 0, plainBytes.Length);
                encStream.FlushFinalBlock();
                var encryptedBytes = new byte[(int)ms.Length - 1 + 1];
                ms.Position = 0;
                ms.Read(encryptedBytes, 0, (int)ms.Length);
                encStream.Close();
                return Convert.ToBase64String(encryptedBytes);
            }
            catch { return string.Empty; }
        }

        public static String Decode(String value)
        {
            try
            {
                var des = new TripleDESCryptoServiceProvider { IV = new byte[8] };
                var pdb = new PasswordDeriveBytes(key, new byte[-1 + 1]);
                des.Key = pdb.CryptDeriveKey("RC2", "MD5", 128, new byte[8]);
                var encryptedBytes = Convert.FromBase64String(value);
                var ms = new MemoryStream(value.Length);
                var decStream = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
                decStream.Write(encryptedBytes, 0, encryptedBytes.Length);
                decStream.FlushFinalBlock();
                var plainBytes = new byte[(int)ms.Length - 1 + 1];
                ms.Position = 0;
                ms.Read(plainBytes, 0, (int)ms.Length);
                decStream.Close();
                return System.Text.Encoding.UTF8.GetString(plainBytes);
            }
            catch { return string.Empty; }
        }
    }
}