using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstitutionCipher
{
    abstract internal class SubstitutionCipher : EncryptionAlgorithm
    {
        protected string Substitute(string message, Dictionary<char, char> key)
        {
            List<char> buffer = new List<char>();
            foreach (char c in message) 
            {
                if(key.ContainsKey(c))
                    buffer.Add(key[c]);
                else
                    buffer.Add(c);
            }
            return new string(buffer.ToArray());
        }
        public override void Decrypt()
        {
            plainText = Substitute(ciperText, decryptionKey);
        }

        public override void Encrypt()
        {
            ciperText = Substitute(plainText, encryptionKey);
        }
    }
}
