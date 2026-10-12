using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstitutionCipher
{
    public class CaesarCipher : RotationCipher
    {
        public CaesarCipher(): base(3)
        {
        }
    }
}
