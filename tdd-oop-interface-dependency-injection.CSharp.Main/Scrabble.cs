using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_oop_interface_dependency_injection.CSharp.Main.Alphabets;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class Scrabble 
    {
        //IAlphabet _alphabet;

        private Dictionary<Char, int> letterScores;

        public Scrabble(IAlphabet alphabet) {
            //_alphabet = alphabet;
            IAlphabet a = alphabet;
            this.letterScores = a.getLetterScores();
        }

        public int score(String word) {
            int total = 0;

            foreach (char ch in word.ToCharArray()) {
                if (this.letterScores.ContainsKey(ch)) {
                    int score = this.letterScores[ch];
                    total += score;
                }
            }

            return total;
        }
    }
}
