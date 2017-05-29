using System;
using System.Text;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;


namespace Hash256Project
{
    public class Hashing
    {
        
        public Hashing(string inputString , string whichHash)
        {

            //Note: Constructor to call "everything" since i don't wanna do it in the main class
            //One call more executions approach. 
            //No need to make an object for everything. 
            
            byte[] Salt = SaltBae.CreateSalt();
            byte[] inputData = GetBytes(ByteStringConverter.StringToBytes(inputString), Salt);
            byte[] outputData = Hash(inputData, whichHash);

            
            Console.WriteLine("Resulting Hash: " + ByteStringConverter.BytesToString(outputData));
            Console.WriteLine("Salt Used: " + ByteStringConverter.BytesToString(Salt));
            
        }

        //Get's hashing and salting input and concatenates them.
        /* 
            Fast way to concat byte arrays using iEnumerable<byte> with Linq Concat<>.
            Then casting it to a new byte array. 
            Slightly slower than the yeld method. 
         */
        public static byte[] GetBytes(byte[] inputString, byte[] inputSalt)
        {
            IEnumerable<byte> inputData = inputSalt.Concat(inputString);
            byte[] inputDataStream = inputData.Cast<byte>().ToArray();

            return inputDataStream;
        }

        //Hash functions for each hashing algorithm.
        public static byte[] Hash(byte[] inputData, string whichHash)
        {
            switch (whichHash)
            {
                case "SHA1":
                case "sha1": 
                    using (var Hash = new SHA1Managed())
                    {
                        return Hash.ComputeHash(inputData);
                    };
                case "HMACSHA1":
                case "hmacsha1":
                    using (var Hash = new HMACSHA1())
                    {
                        return Hash.ComputeHash(inputData);
                    };
                case "SHA256":
                case "sha256":
                    using (var Hash = new SHA256Managed())
                    {
                        return Hash.ComputeHash(inputData); 
                    };
                case "HMACSHA256":
                case "hmacsha256":
                    using (var Hash = new HMACSHA256())
                    {
                        return Hash.ComputeHash(inputData);
                    };
                case "SHA384":
                case "sha384":
                    using (var Hash = new SHA384Managed())
                    {
                        return Hash.ComputeHash(inputData);
                    };
                case "HMCASHA384":
                case "hmacsha384":
                    using (var Hash = new HMACSHA384())
                    {
                        return Hash.ComputeHash(inputData);
                    };
                case "SHA512":
                case "sha512":
                    using (var Hash = new SHA512Managed())
                    {
                        return Hash.ComputeHash(inputData);
                    };
                case "HMCASHA512":
                case "hmacsha512":
                    using (var Hash = new HMACSHA512())
                    {
                        return Hash.ComputeHash(inputData);
                    };
                default:
                    return null;
            }//Hash
            
        }
        
    }
}
