using System;
using System.Text;

namespace Compress{
    public class Encode{

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