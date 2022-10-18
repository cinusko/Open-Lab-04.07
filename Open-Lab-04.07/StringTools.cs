using System;
using System.Threading;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            int count = original.Length;
            char[] originalArr = original.ToCharArray();
            string reverse = string.Empty;
            for (int i = count - 1; i > -1; i--)
            {
                reverse = reverse + originalArr[i];
            }
            return reverse;

        }
    }
}
