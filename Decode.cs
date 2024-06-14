using System;
using System.Text;

namespace Compress{
    class Decoder
    {
        public static string RunLengthDecoding(string s)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int length = s.Length;

            for (int i = 0; i < length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    int count = 0;
                    while (i < length && char.IsDigit(s[i]))
                    {
                        int secondDigit = s[i] - '0';
                        count = count * 10 + secondDigit;
                        i++;
                    }

                    for (int j = 0; j < count; j++)
                    {
                        stringBuilder.Append(s[i]);
                    }
                }
                else
                {
                    stringBuilder.Append(s[i]);
                }
            }

            return stringBuilder.ToString();
        }
    }
}