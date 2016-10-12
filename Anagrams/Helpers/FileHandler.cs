using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Anagrams.Helpers {
    public static class FileHandler {
        /// <summary>
        /// Reads a file from a path and returns each line in a list of string.
        /// </summary>
        /// <param name="filePath">Path of the file to be read</param>
        /// <returns></returns>
        public static List<string> readFile(this string filePath) {
            if (File.Exists(filePath))
                return File.ReadAllLines(filePath).ToList();
            else
                return new List<string>();
        }
    }
}
