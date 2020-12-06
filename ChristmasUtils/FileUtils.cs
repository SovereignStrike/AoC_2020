using System;
using System.Collections;
using System.IO;

namespace ChristmasUtils
{
    public class FileUtils
    {
        public static string CreateTempFileFromList(IEnumerable input)
        {
            Guid gUID = Guid.NewGuid();

            string testInputFilePath = Path.GetTempPath() + gUID + ".temp";
            StreamWriter sw = new StreamWriter(testInputFilePath);
            foreach (string val in input)
            { sw.WriteLine(val); }
            sw.Close();
            return testInputFilePath;

               }
    }
}
