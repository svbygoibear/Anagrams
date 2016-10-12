using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anagrams.Helpers {
    public static class AnagramHandler {
        /// <summary>
        /// Returns the result of the anagram check.
        /// </summary>
        /// <param name="word">Original word</param>
        /// <param name="wordInQuestion">Word for comparison</param>
        /// <returns>Boolean value indicating if the words are anagrams or not.</returns>
        public static bool isAnagram(this string word, string wordInQuestion) {
            return word.Length != wordInQuestion.Length ? false : anagramCheck(word.ToCharArray().ToList(), wordInQuestion, word.Length);
        }

        /// <summary>
        /// This is used to check if a word, in comparison to another word, are anagrams of each other.
        /// </summary>
        /// <param name="word">The main word, converted to a list of it's char</param>
        /// <param name="wordInQuestion">The comparison word</param>
        /// <param name="curr">The length of the check (usually the word length)</param>
        /// <returns>Boolean value indicating if the words are anagrams or not.</returns>
        private static bool anagramCheck(List<char> word, string wordInQuestion, int curr) {
            if (curr == 0)
                return true;

            if (wordInQuestion.ToLower().Contains(word[curr - 1].ToString().ToLower()))
                return anagramCheck(word, wordInQuestion, curr - 1);
            else
                return false;
        }
    }
}