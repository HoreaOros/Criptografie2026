using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstitutionCipher
{
    abstract internal class EncryptionAlgorithm
    {
        protected string plainText;
        protected string ciperText;
        protected Dictionary<char, char> encryptionKey;
        protected Dictionary<char, char> decryptionKey;
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
                return ciperText;
            }

            set
            {
                ciperText = value;
                Decrypt();
            }
        }
    }
}
