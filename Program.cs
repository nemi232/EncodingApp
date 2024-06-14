using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Compress
{
    public class Compression
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Pick if you want to encode or decode. E/D");
            string s = Console.ReadLine().ToLower();
            if (s == "e" || s == "encode")
            {
                Console.WriteLine("Provide text to encoode ");
                string en = Console.ReadLine();
                Console.WriteLine($"Encoded output :  {RunLengthEncoding(en)}");
            }
            else
            {
                Console.WriteLine("Provide text to decode ");
                string k = Console.ReadLine();
                Console.WriteLine($"Decoded output :  {Decoderr.RunLengthDecoding(k)}");
            }



        }
        public static string RunLengthEncoding(string s)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int count = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i].Equals(s[i - 1]))
                {
                    count++;
                }
                else
                {
                    if (count != 1)
                    {
                        stringBuilder.Append(count.ToString());
                        stringBuilder.Append(s[i - 1]);
                    }
                    else
                    {
                        stringBuilder.Append(s[i]);
                        
                    }
                    count = 1;
                }


            }

            return stringBuilder.ToString();

        }


    }


}