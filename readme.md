#Anagrams
##Synopsis
"Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or phrase to produce a new word or phrase, using all the original letters exactly once; for example orchestra can be rearranged into carthorse.
This library centers around anagrams and identify anagrams.

##Code Example
###Assignment
Devise a function that gets one word as parameter and returns all the anagrams for it from the file wl.txt.
You can not use permutations to generate the possible words.

###Example Output
The anagram for "horse" given the current input file, should give:
```
['heros', 'horse', 'shore']
```

###Assumptions
From the instructions given, the following assumptions can be deducted from it:
- If a word contains a special character, the anagram should also contain those characters.
- The word's case (upper or lower) should not influence the anagram.

###Code Snippet
Here the input can be read from a text file, but for the anagram checker you can just use a list of string that originates from anywhere else as well:
```javascript
var path = Path.Combine(Directory.GetCurrentDirectory().ToString(), "wordlist.txt");
var words = path.readFile();
```

Using the list of string, which is our "anagram library", we can now identify all the anagrams for a specific input:
```javascript
var input = "horse";
var anagramsFound = getAllAnagrams(words, input); 
```

This will yeild the following results in the anagramsFound list:
```
heros
horse
shore
```


##Installation
To run this app, you'll need .NET 4.5 or higher installed on your machine, and to open up the project file you'll need Visual Studio. Other than that, no installation required. Microsoft .NET Framework 4.5 can be installed by downloading it from the microsoft website.

##Contributors
Feel free to pop me a message or flag an issue if you come across it - I'll see what I can do about it.

##License

Copyright © `2016` `Simone van Buuren`

Permission is hereby granted, free of charge, to any person
obtaining a copy of this software and associated documentation
files (the “Software”), to deal in the Software without
restriction, including without limitation the rights to use,
copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the
Software is furnished to do so, subject to the following
conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.