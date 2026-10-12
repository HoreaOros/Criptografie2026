using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstitutionCipher
{
    abstract public class EncryptionAlgorithm
    {
        protected string? plainText;
        protected string? cipherText;
        protected Dictionary<char, char>? encryptionKey;
        protected Dictionary<char, char>? decryptionKey;
        abstract public void Encrypt();
        abstract public void Decrypt();

        abstract protected void GenerateEncryptionKey();
        abstract protected void GenerateDecryptionKey();

        public string PlainText
        {
            get
            {
                return plainText;
            }
            set
            {
                plainText = value;
                Encrypt();
            }
        }
        public string CiperText
        {
            get
            {
                return cipherText;
            }

            set
            {
                cipherText = value;
                Decrypt();
            }
        }
        public string EncryptionKey
        {
            get
            {
                StringBuilder sb = new();
                foreach(char c in encryptionKey.Values)
                    sb.Append(c);
                return sb.ToString();
            }
        }
        public string DecryptionKey
        {
            get
            {
                StringBuilder sb = new();
                foreach (char c in decryptionKey.Values)
                    sb.Append(c);
                return sb.ToString();
            }
        }
    }
}
