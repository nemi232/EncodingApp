using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Compress
{
    public class Compression
    {
        static void Main(string[] args)
        {
            string s = "40d";
            Console.WriteLine(RunLengthDecoding(s));

        }

        public static string RunLengthDecoding(string s)
        {
            StringBuilder stringBuilder = new StringBuilder();
            char[] charss = s.ToCharArray();


            for (int i = 0; i < charss.Length; i++)
            {
                
               StringBuilder counter = new StringBuilder();
                if (i + 1 != null)
                {
                    while (i < s.Length && char.IsDigit(charss[i]))
                    {
                        counter.Append(charss[i]);
                    }

                    stringBuilder.Append(counter);
                }
                
            }
            return stringBuilder.ToString();


        }
            

        


    public static string RunLengthEncoding(string s)
    {
        StringBuilder stringBuilder = new StringBuilder();
        char[] chars = s.ToCharArray();
        int count = 1;

        for (int i = 1; i < chars.Length; i++)
        {
            if (chars[i] == chars[i - 1])
            {
                count++;
            }
            else
            {
                if (count != 1)
                {
                    stringBuilder.Append(count.ToString());
                    stringBuilder.Append(chars[i - 1]);
                }
                else
                {
                    stringBuilder.Append(chars[i - 1]);
                    stringBuilder.Append(chars[i]);

                }
                count = 1;
            }

        }

        return stringBuilder.ToString();

    }
}
}