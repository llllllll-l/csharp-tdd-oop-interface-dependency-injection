﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class Scrabble {
        
        private IAlphabet alphabet;
       
        public Scrabble(IAlphabet alphabet) {
            this.alphabet = alphabet;
        }

        // sligtly rewritten to work with the interface, the logic stays the same
        public int score(string word) {
            int wordScore = 0;
            foreach (char character in word) {
                wordScore += alphabet.GetLetterScore(character);
            }

            return wordScore;
        }

    }


    /*

        private Dictionary<Char, int> letterScores;

        public Scrabble() {
            Alphabet a = new Alphabet();
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
    */
}
