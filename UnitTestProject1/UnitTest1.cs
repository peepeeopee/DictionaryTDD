using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using System.Collections.Generic;

namespace UnitTestProject1
{
    /*
     * Create a method that takes a string and a dictionary, and replaces every key in the dictionary pre and suffixed with a dollar sign, with the corresponding value from the Dictionary.

Tests

input : "", dict empty, output:""

input : "$temp$", dict ["temp", "temporary"], output: "temporary"

input : "$temp$ here comes the name $name$", dict ["temp", "temporary"] ["name", "John Doe"], output : "temporary here comes the name John Doe"
     */


    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GivenNullStringReturnError()
        {
            var replacer = new StringReplacer();

            var result = replacer.ReplaceOccurence(null, new Dictionary<string, string>());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GivenStringWithNoTargetCharactersThrowError()
        {
            var replacer = new StringReplacer();

            var result = replacer.ReplaceOccurence("xxxxx", new Dictionary<string, string>());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GivenStringWithOddNumberCharactersThrowError()
        {
            var replacer = new StringReplacer();

            var result = replacer.ReplaceOccurence("$xx$xxx$", new Dictionary<string, string>());
        }

        [TestMethod]
        public void GivenEmptyStringAndEmptyDictionaryReturnsEmptyString()
        {
            var replacer = new StringReplacer();

            var result = replacer.ReplaceOccurence(string.Empty, new Dictionary<string, string>());

            Assert.IsTrue(result == string.Empty);
        }

        [TestMethod]
        public void GivenOneTargetWithCorrectDictionaryReturnsDictionaryValue()
        {
            var replacer = new StringReplacer();

            var dictionary = new Dictionary<string, string>();

            dictionary.Add("temp", "temporary");

            var result = replacer.ReplaceOccurence("$temp$", dictionary);

            Assert.IsTrue(result == "temporary");
        }
    }
}
