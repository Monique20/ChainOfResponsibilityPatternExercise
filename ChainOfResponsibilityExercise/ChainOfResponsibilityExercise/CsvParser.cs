using System;
using ChainOfResponsibilityExercise;

namespace ChainOfResponsibiltyTests
{
    public class CsvParser : IParser
    {
        private IParser _nextParser;

        public void SetSuccessor(IParser nextParser)
        {
            _nextParser = nextParser;
        }

        public void Parse(string fileName)
        {
            if (fileName.EndsWith(".csv"))
            {
                Console.Write("Csv Parser has parsed the file");
            }
            else
            {
                _nextParser.Parse(fileName);
            }
        }


    }
}