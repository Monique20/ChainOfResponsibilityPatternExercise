using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityExercise
{
    public class TextParser : IParser
    {
        private IParser _nextParser;

        public void SetSuccessor(IParser nextParser)
        {
            _nextParser = nextParser;
        }

        public void Parse(string fileName)
        {
            if (fileName.EndsWith(".txt"))
            {
                Console.Write("Text Parser has parsed the file");
            }
            else
            {
                _nextParser.Parse(fileName);
            }
        }


    }
}
