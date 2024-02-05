using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        public void HideRandomWords(int numberToHide)
        {
            Random random = new Random();

            for (int i = 0; i < numberToHide; i++)
            {
                int randomIndex = random.Next(_words.Count);
                _words[randomIndex].Hide();
            }
        }

        public string GetDisplayText()
        {
            return $"{_reference.GetDisplayText()}\n\n{_words.Aggregate("", (current, word) => current + word.GetDisplayText() + " ")}";
        }

        public bool IsCompletelyHidden()
        {
            return _words.All(word => word.IsHidden());
        }
    }
}
