using System;

namespace BetterDecorator
{
    class Program
    {

        private static string Decor(string s, char dec, int rep)
        {
            string decor = new string(dec, rep);
            return $"{decor} {s} {decor}";
        }
        static void Main(string[] args)
        {
            string input = args[0];
            char decorchar = args[1][0];
            int repcount = int.Parse(args[2]);

            string decorated = Decor(input, decorchar, repcount);
            Console.WriteLine(decorated);
        }
    }
}
