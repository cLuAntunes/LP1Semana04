using System;

namespace BetterDecorator
{   
    /// <summary>
    /// Programa para decorar uma string com um caractere nos lados.
    /// </summary>
    class Program
    {

        /// <summary>
        /// Método que decora uma string com um caractere repetido uma certa 
        /// quantidade de vezes.
        /// </summary>
        /// <param name="s">String que vai ser decorada.</param>
        /// <param name="dec">Caractere que vai ser usado pra decorar.</param>
        /// <param name="rep">Vezes que o caractere é repetido.</param>
        /// <returns></returns>
        private static string Decor(string s, char dec, int rep)
        {
            string decor = new string(dec, rep);
            return $"{decor} {s} {decor}";
        }
        
        /// <summary>
        /// Metodo que inicia o programa.
        /// </summary>
        /// <param name="args">Argumentos da linha de comando.</param>
        static void Main(string[] args)
        {   
            Console.WriteLine(Decor());
            string input = args[0];
            char decorchar = args[1][0];
            int repcount = int.Parse(args[2]);

            string decorated = Decor(input, decorchar, repcount);
            Console.WriteLine(decorated);
        }

        private static string Decor()
        {
            return Decor("User did not specify args!", '=', 3);
        }
    }
}
