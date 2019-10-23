using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo.Lib;
using System.IO;

namespace Demo.CaseRunner
{
    [TestClass]
    public class Cases
    {
        private void RunCase(string case_name, string input_name, string output_name, uint n)
        {
            var root_directory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.Parent;
            var input_file = Path.Combine(root_directory.FullName, "Cases", case_name, input_name);
            var output_file = Path.Combine(root_directory.FullName, "Cases", case_name, output_name);
            TextFileRepeater.CreateFile(input_file, output_file, n);
        }

        [TestMethod]
        public void Lorum()
        {
            RunCase("Lorum", "input.txt", "output.txt", 2);
        }

        [TestMethod]
        public void Shining()
        {
            RunCase("Shining", "input.txt", "output.txt", 5);
        }

        [TestMethod]
        public void Bart()
        {
            RunCase("Bart", "input.txt", "output.txt", 20);
        }

    }
}
