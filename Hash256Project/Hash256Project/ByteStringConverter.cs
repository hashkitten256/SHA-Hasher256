using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash256Project
{
    class ByteStringConverter
    {
        //Convert String to Byte[]
        public static byte[] StringToBytes(string String)
        {
            return Encoding.UTF8.GetBytes(String);
        }

        //Convert Byte[] to String
        public static string BytesToString(byte[] Bytes)
        {
            return BitConverter.ToString(Bytes).Replace("-", String.Empty);
        }
    }
}
