
using System;

namespace Day2
{

    
    class Program
    {
        const string PATH_INPUT = "input.dat";
        static void Main(string[] args)
        {
            PasswordList pL = new PasswordList(PATH_INPUT);
            Console.Write("Valid passwords " + pL.ValidPasswordsCount().ToString()); 
        }
    }
}
