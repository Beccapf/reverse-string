using System;

namespace reversestring
{
    class Program
    {
        static void Main(string[] args)
        {
            int len;
            string str, revstr = "";
            Console.Write("Digite uma string:");
            str = Console.ReadLine();

            len = str.Length - 1;
            while (len >= 0)
            {
                revstr = revstr + str[len];
                len--;
            }
            Console.WriteLine("String invertida:" + revstr);
        }
    }
}
