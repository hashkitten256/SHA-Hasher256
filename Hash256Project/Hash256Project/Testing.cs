using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash256Project
{
    class Testing
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("SHA-Hasher256: Version: 0.1");
            Console.WriteLine("Input your string and the SHA algorithm.");
            Console.WriteLine("SHA Algorithms: SHA1, HMACSHA1, SHA256, HMACSHA256, SHA384, HMCASHA384, SHA512, HMCASHA256" + '\n');
            Console.Write("Your Input: ");
            string inputString = Console.ReadLine();
            Console.Write("\n");
            Console.Write("Your SHA Algorithm choice: ");
            string WhichHash = Console.ReadLine();
            Console.Write("\n");

            var watch = System.Diagnostics.Stopwatch.StartNew();
            var Hash = new Hashing(inputString, WhichHash);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Execution time: " + elapsedMs.ToString() + "ms \n");
        }

    }
}
