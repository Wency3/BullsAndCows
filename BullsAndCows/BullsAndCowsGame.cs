﻿using System;

namespace BullsAndCows
{
    public class BullsAndCowsGame
    {
        private readonly string secret;
        private readonly SecretGenerator secretGenerator;
        public BullsAndCowsGame(SecretGenerator secretGenerator)
        {
            this.secretGenerator = secretGenerator;
            this.secret = secretGenerator.GenerateSecret();
        }

        public bool CanContinue => true;

        public string Guess(string guess)
        {
            int bulls = 0;
            int cows = 0;
            for (int i = 0; i < secret.Length; i++)
            {
                //if (guess[i] == secret[i])
                if (guess.IndexOf(secret[i]) == i)
                {
                    bulls++;
                }
            }

            for (int i = 0; i < secret.Length; i++)
            {
                if (guess.IndexOf(secret[i]) >= 0 && guess.IndexOf(secret[i]) != i)
                {
                    cows++;
                }
            }

            return $"{bulls}A{cows}B";
        }
    }
}