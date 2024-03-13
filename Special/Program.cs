using System;

namespace Special
{
    class Program
    {   
        private static int GetSpecial(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1 || n == 2)
                return 1;
            else
                return GetSpecial(n - 1) + 2 * GetSpecial(n - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetSpecial(0));
            Console.WriteLine(GetSpecial(2));
            Console.WriteLine(GetSpecial(7));
        }
    }
}
