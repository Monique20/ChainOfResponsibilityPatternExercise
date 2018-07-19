using System;
using ChainOfResponsibilityExercise;

namespace ChainOfResponsibiltyTests
{
    public class XmlParser : IParser
    {
        private IParser _nextParser;

        public void SetSuccessor(IParser nextParser)
        {
            _nextParser = nextParser;
        }

        public void Parse(string fileName)
        {
            if (fileName.EndsWith(".xml"))
            {
                Console.Write("Xml Parser has parsed the file");
            }
            else
            {
                _nextParser.Parse(fileName);
            }
        }


    }
}