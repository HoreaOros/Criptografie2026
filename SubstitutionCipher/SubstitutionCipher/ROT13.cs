using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstitutionCipher
{
    public class ROT13 : RotationCipher
    {
        public ROT13(): base(13) 
        { 
        }
    }
}
