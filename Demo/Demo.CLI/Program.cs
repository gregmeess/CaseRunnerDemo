using CommandLine;
using System;
using System.IO;

using Demo.Lib;

namespace Demo.CLI
{
    class Options
    {
        [Value(0, MetaName = "input file path", Required = true, HelpText = "Path to input file.")]
        public string InputFilePath { get; set; }

        [Value(1, MetaName = "output file path", Required = true, HelpText = "Path to output file.")]
        public string OutputFilePath { get; set; }

        [Value(2, MetaName = "repetitions", Required = false, Default = (uint)3, HelpText = "How many times to repeat the text.")]
        public uint Repetitions { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Using the CommandLineParser with the custom "Options" class defined above
            // in order to simplify parsing input arguements.
            Parser.Default.ParseArguments<Options>(args).WithParsed(o =>
            {
                string input_file_path = Path.GetFullPath(o.InputFilePath);
                string output_file_path = Path.GetFullPath(o.OutputFilePath);

                if (!File.Exists(input_file_path))
                {
                    Console.WriteLine($"ERROR: Input file {input_file_path} does not exist");
                    Environment.Exit(1);
                }

                Console.WriteLine($"Copying lines {o.Repetitions} times from {o.InputFilePath} to {o.OutputFilePath}");
                TextFileRepeater.CreateFile(input_file_path, output_file_path, o.Repetitions);
                Console.WriteLine($"Success!");
            });
        }
    }
}