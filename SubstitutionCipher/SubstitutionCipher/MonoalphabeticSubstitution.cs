using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubstitutionCipher
{
    public class MonoalphabeticSubstitution : SubstitutionCipher
    {
        private char[] letter;
        protected override void GenerateDecryptionKey()
        {
            decryptionKey = new Dictionary<char, char>();
            for (int i = 0; i < letter.Length; i++)
                decryptionKey[letter[i]] = (char)('A' + i);
        }

        protected override void GenerateEncryptionKey()
        {
            encryptionKey = new Dictionary<char, char>();
            for (int i = 0; i < letter.Length; i++)
                encryptionKey[(char)('A' + i)] = letter[i];
        }
        public MonoalphabeticSubstitution()
        {
            letter = new char[26];
            for(int i = 0; i < letter.Length; i++) 
                letter[i] = (char)('A' + i);
            Shuffle(letter);
            GenerateEncryptionKey();
            GenerateDecryptionKey();
        }

        private void Shuffle(char[] letter)
        {
            // Fisher–Yates shuffle
            var rng = Random.Shared;
            for (int i = letter.Length - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1); // 0..i inclusive
                char tmp = letter[i];
                letter[i] = letter[j];
                letter[j] = tmp;
            }
        }
    }
}