using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ChainOfResponsibilityExercise;

namespace ChainOfResponsibiltyTests
{
    [TestFixture]
    public class ParsingTests
    {

        [Test]
        public void WhenFileIsATextFile_ShouldReturnAppropriateMessage()
        {
            //Arrange
            var input = "Text.txt";

            var text = new TextParser();
            var json = new JsonParser();
            var csv = new CsvParser();
            var xml = new XmlParser();

            text.SetSuccessor(json);
            json.SetSuccessor(csv);
            csv.SetSuccessor(xml);

            //Act
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            text.Parse(input);

            var expected = "Text Parser has parsed the file";

            //Assert
            Assert.AreEqual(expected, fakeoutput.ToString());

        }

        [Test]
        public void WhenFileIsAJsonFile_ShouldReturnAppropriateMessage()
        {
            //Arrange
            var input = "Text.json";

            var text = new TextParser();
            var json = new JsonParser();
            var csv = new CsvParser();
            var xml = new XmlParser();

            text.SetSuccessor(json);
            json.SetSuccessor(csv);
            csv.SetSuccessor(xml);

            //Act
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            text.Parse(input);

            var expected = "Json Parser has parsed the file";

            //Assert
            Assert.AreEqual(expected, fakeoutput.ToString());
        }

        [Test]
        public void WhenFileIsACsvFile_ShouldReturnAppropriateMessage()
        {
            //Arrange
            var input = "Text.csv";

            var text = new TextParser();
            var json = new JsonParser();
            var csv = new CsvParser();
            var xml = new XmlParser();

            text.SetSuccessor(json);
            json.SetSuccessor(csv);
            csv.SetSuccessor(xml);

            //Act
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            text.Parse(input);

            var expected = "Csv Parser has parsed the file";

            //Assert
            Assert.AreEqual(expected, fakeoutput.ToString());

        }

        [Test]
        public void WhenFileIsAXmlFile_ShouldReturnAppropriateMessage()
        {
            //Arrange
            var input = "Text.xml";

            var text = new TextParser();
            var json = new JsonParser();
            var csv = new CsvParser();
            var xml = new XmlParser();

            text.SetSuccessor(json);
            json.SetSuccessor(csv);
            csv.SetSuccessor(xml);

            //Act
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            text.Parse(input);
            
            var expected = "Xml Parser has parsed the file";

            //Assert
            Assert.AreEqual(expected, fakeoutput.ToString());

        }
    }
}
