using System;
using System.Collections.Generic;
using System.Linq;

namespace Mastermind.Resources
{
    public class MastermindGame
    {
        private readonly List<CodePeg> code;

        public MastermindGame(List<CodePeg> code)
        {
            this.code = code;
        }

        public List<ResultPeg> GetHints(List<CodePeg> guess)
        {
            // Implement your code here.
            var result = new List<ResultPeg>();

            if (Enumerable.SequenceEqual(code, guess))
            {
                //You won the Game!!
                //Code to let the user know he has won.
            }
            else
            {
                //Keep trying!!
                CodePeg[] c = code.ToArray();
                CodePeg[] ch = guess.ToArray();
                for (int i = 0; i <= c.Length - 1; i++)
                {
                    for (int j = 0; j <= ch.Length - 1; j++)
                    {
                        if (c[i] == ch[j])
                        {
                            if (i == j)
                            {
                                //There are some matched in the same position.
                                result.Add(ResultPeg.Black);
                                break;
                            }
                            //They matched in different position.
                            result.Add(ResultPeg.White);
                            break;
                        }
                        else
                        {
                            //There is no matched
                            //Code to indicate the user there was no match at all.

                        }

                    }

                }

            }
            return result;
        }
    }

    public enum CodePeg
    {
        Black,
        Blue,
        Green,
        Red,
        White,
        Yellow,
    }

    public enum ResultPeg
    {
        Black,
        White,
       


    }
}