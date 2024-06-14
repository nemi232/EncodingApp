using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Compress
{
    public class Compression
    {

        static void Main(string[] args)
        {
            RunningApp();
        }


        public static void RunningApp()
        {
            bool answer = true;
            while (answer)
            {
                Console.WriteLine("Do you want to encode or decode. E/D");
                string s = Console.ReadLine().ToLower();
                if (s == "e" || s == "encode")
                {
                    Console.WriteLine("Provide text to encoode ");
                    string en = Console.ReadLine();
                    Console.WriteLine($"Encoded output :  {Encode.RunLengthEncoding(en)}");
                }
                else
                {
                    Console.WriteLine("Provide text to decode ");
                    string k = Console.ReadLine();
                    Console.WriteLine($"Decoded output :  {Decoderr.RunLengthDecoding(k)}");
                }
                Console.WriteLine("Do you want to repeat ? Y/N");
                string ans = Console.ReadLine().ToLower();
                if (ans.Contains("y"))
                {
                    answer = true;
                }
                else if (ans.Contains("n")) { answer = false; }
            }

        }




    }




}