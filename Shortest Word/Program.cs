using System;

namespace Shortest_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindShort("hui pizda mochayobana pi"));
        }
        public static int FindShort(string s)
        {
            int count = 0;
            int count2 = s.Length;

            foreach (var c in s)
            {
                if (c != ' ')
                {
                    count++;
                }
                else
                {
                    if (count < count2)
                    {
                        count2 = count;
                    }

                    count = 0;
                }
            }
            if (count < count2)
            {
                count2 = count;
            }
            return count2 ;
        }
    }
}
