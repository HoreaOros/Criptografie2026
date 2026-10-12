using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstitutionCipher
{
    public class RotationCipher : SubstitutionCipher
    {
        protected int n;
        protected override void GenerateDecryptionKey()
        {
            decryptionKey = new Dictionary<char, char>();
            for (int i = 0; i < 26; i++)
            {
                decryptionKey[(char)('A' + i)] = (char)('A' + (i - n % 26 + 26) % 26);
            }
        }

        protected override void GenerateEncryptionKey()
        {
            encryptionKey = new Dictionary<char, char>();
            for (int i = 0; i < 26; i++)
            {
                encryptionKey[(char)('A' + i)] = (char)('A' + (i + n) % 26);
            }
        }
        public RotationCipher(int n)
        {
            this.n = n;
            GenerateDecryptionKey();
            GenerateEncryptionKey();
        }
    }
}
