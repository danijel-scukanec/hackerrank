using System;

namespace HackerRank.Miscellaneous.FlippingBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(flippingBits(9));
        }

        static long flippingBits(long n)
        {
            var binary = Convert.ToString(n, 2).PadLeft(32, '0').ToCharArray();
            for (var i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    binary[i] = '0';
                }
                else
                {
                    binary[i] = '1';
                }
            }

            var binaryString = new string(binary);
            return Convert.ToInt64(binaryString, 2);
        }       
    }
}
