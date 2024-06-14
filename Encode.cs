using System;
using System.Text;

namespace Compress{
    public class Encode{

        public static string RunLengthEncoding(string s)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int count = 1;

            for (int i = 0; i < s.Length; i++)
            {
                if (i +1< s.Length && s[i] == s[i+1])
                {
                    count++;
                }
                else
                {
                    stringBuilder.Append(count.ToString());
                    stringBuilder.Append(s[i]);
                    count = 1;
                }

            }

            return stringBuilder.ToString();

        }

        }

    }
