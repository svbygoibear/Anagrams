using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagrams;
using System.Collections.Generic;

namespace AnagramUnitTest {
    [TestClass]
    public class AnagramTest {
        [TestMethod]
        public void GetAnagrams() {
            var word = "horse";
            var words = new List<string> { "shore", "mist", "heros", "horse" };
            var matches = Anagram.getAllAnagrams(words, word);

            Assert.AreEqual(matches.Count, 3);
        }
    }
}
