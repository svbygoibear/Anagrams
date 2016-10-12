using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anagrams.Helpers;

namespace Anagrams {
    public static class Anagram {
        /// <summary>
        /// Returns all the anagrams form a list of string given an input word.
        /// </summary>
        /// <param name="anagramBase">List of string to search.</param>
        /// <param name="word">Original word</param>
        /// <returns>List of all the matches,</returns>
        public static List<string> getAllAnagrams(List<string> anagramBase, string word) {
            var matches = new List<string>();
            anagramBase.ForEach(anagram => {
                if (word.isAnagram(anagram))
                    matches.Add(anagram);
            });
            return matches;
        }
    }
}
