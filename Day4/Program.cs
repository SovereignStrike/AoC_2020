using System;

namespace Day4
{
    class Program
    {
        const string PATH_INPUT = "input_pass.dat";
        static void Main(string[] args)
        {
            PassportList pL = new PassportList(PATH_INPUT);

            Console.Write("Valid passports : " + pL.ValidPasswordsCount(Validator.requiredFields).ToString());
        }
    }
}
