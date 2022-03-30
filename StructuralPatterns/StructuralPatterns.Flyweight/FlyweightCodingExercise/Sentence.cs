using System.Collections.Generic;

namespace FlyweightCodingExercise
{
    public class Sentence
    {
        private string[] words;
        private Dictionary<int, WordToken> tokens = new Dictionary<int, WordToken>();
        public Sentence(string plainText)
        {
            words = plainText.Split(' ');
        }

        public WordToken this[int index]
        {
            get
            {
                WordToken token = new WordToken();
                tokens.Add(index, token);
                return tokens[index];
            }
        }

        public override string ToString()
        {
            List<string> wordList = new List<string>();

            for (var i = 0; i < words.Length; i++)
            {
                string word = words[i];

                if (tokens.ContainsKey(i) && tokens[i].Capitalize)
                    word = word.ToUpper();

                wordList.Add(word);
            }

            return string.Join(" ", wordList);
        }

        public class WordToken
        {
            public bool Capitalize;
        }
    }
}