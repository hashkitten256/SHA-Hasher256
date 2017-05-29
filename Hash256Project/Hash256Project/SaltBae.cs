using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

//Salting class

namespace Hash256Project
{
    class SaltBae
    {
        //Salt size is set to 32bits by default cause i am lazy
        public static byte[] CreateSalt(int size = 32)
        {
            //Generate a cryptographic true random number.
            using (var RNGCryptoGenerator = new RNGCryptoServiceProvider())
            {
                byte[] buffer = new byte[size];
                RNGCryptoGenerator.GetBytes(buffer);
                // Return Convert.ToBase64String(buffer) if you want a Base64 string representation of the random number.
                return buffer;
            }
        }
    }
}
