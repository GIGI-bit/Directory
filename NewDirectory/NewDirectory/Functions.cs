using System;
using System.Drawing;
using System.IO;

namespace Directories
{
    internal static class Counter
    {
        public static int Count(string filePath)
        {
            using FileStream folder = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader readStream = new StreamReader(folder);
            string count = readStream.ReadLine();
            if (count == null) return 0;
            else if (count == "") return 0;
            else return Int32.Parse(count);
        }



        public static void IncreaseCount(string filePath)
        {
            int temp = Count(filePath);
            using FileStream folder = new FileStream(filePath, FileMode.Open, FileAccess.Write);
            using var streamWriter = new StreamWriter(folder);
            string count = Convert.ToString(temp + 1);
            streamWriter.WriteLine(count);
            folder.Flush();
        }
    }
}
