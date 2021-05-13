using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoAIgnite.Tests
{
    public class ConverterTests
    {
        [TestCase(new string[2] { "11.01.2010", "11.02.2011" }, "11.01.2010-11.02.2011")]
        [TestCase(new string[2] { "11.01.2010", "11.02.2010" }, "11.01-11.02.2010")]
        [TestCase(new string[2] { "10.01.2010", "11.01.2010" }, "10-11.01.2010")]
        [TestCase(new string[2] { "11.01.2010", "11.02.2009" }, "11.02.2009-11.01.2010")]
        [TestCase(new string[2] { "11.03.2010", "11.02.2010" }, "11.02-11.03.2010")]
        [TestCase(new string[2] { "12.01.2010", "11.01.2010" }, "11-12.01.2010")]
        [TestCase(new string[0] {}, "Error! You didnt provide two arguments")]
        [TestCase(new string[3] { "12.01.2010", "11.01.2010" , "12.01.2010" }, "Error! You didnt provide two arguments")]
        [TestCase(new string[2] { "21.13.2", "2"}, "Error! Bad dates format or this are not dates. Correct format date: 'dd.mm.yyyy dd.mm.yyyy'")]
        [TestCase(new string[2] { "21.13.2", "31.02.2020"}, "Error! Bad dates format or this are not dates. Correct format date: 'dd.mm.yyyy dd.mm.yyyy'")]
        [TestCase(new string[2] { "TEST", "TEST" }, "Error! Bad dates format or this are not dates. Correct format date: 'dd.mm.yyyy dd.mm.yyyy'")]
        public void Convert_TwoStringDate_ReturnsFormat1(string [] args, string exceptedDate)
        {
            var conv = new Converter();
            string sub = conv.Start(args);
            Assert.AreEqual(exceptedDate.ToString(), sub);
        }
    }
}
