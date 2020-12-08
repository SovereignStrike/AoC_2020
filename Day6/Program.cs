using System;

namespace Day6
{
    class Program
    {
        
            const string PATH_INPUT = "input.dat";
            static void Main(string[] args)
            {
                QuestionnaireList quests = new QuestionnaireList(PATH_INPUT);

                Console.Write("Total positive answers : " + quests.PositiveAnswers());
            }
        
    }
}
