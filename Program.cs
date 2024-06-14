using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Compress
{
    public class Compression : Decoderr
    {

        static void Main(string[] args)
        {
            Decoderr c = new Compression();

            string one = ">>>>.";
            string two = "++++++++++...+<";

            string oneEncoded = Encode.RunLengthEncoding(one);
            string twoEncoded = Encode.RunLengthEncoding(two);

            Console.WriteLine(oneEncoded);
            Console.WriteLine(twoEncoded);

            // Console.WriteLine($"Encoded strings :  \n 1.  {one} is {oneEncoded} \n 2. {two} is {twoEncoded}");

            // Console.WriteLine($"Decoded strings :  \n 1.  {oneEncoded} is {Decoderr.RunLengthDecoding(oneEncoded)} \n 2. {twoEncoded} is {Decoderr.RunLengthDecoding(twoEncoded)}");


        }



    }


}