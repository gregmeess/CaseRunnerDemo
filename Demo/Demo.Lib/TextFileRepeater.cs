using System;
using System.Collections.Generic;

namespace Demo.Lib
{
    public static class TextFileRepeater
    {
        public static void CreateFile(string input_file_path, string output_file_path, uint repetitions)
        {
            string[] lines = System.IO.File.ReadAllLines(input_file_path);
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(output_file_path))
            {
                foreach (var line in RepeatLines(lines, repetitions))
                    file.WriteLine(line);
            }
        }

        public static List<string> RepeatLines(string[] lines, uint repetitions)
        {
            var result = new List<string>();

            for (int i = 0; i < repetitions; i++)
                result.AddRange(lines);

            return result;
        }
    }
}
