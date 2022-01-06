using Mastermind.Resources;
using System;
using System.Collections.Generic;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var code = new List<CodePeg>();
            code.Add(CodePeg.White);
            code.Add(CodePeg.Yellow);
            code.Add(CodePeg.Green);
            code.Add(CodePeg.Black);
            MastermindGame m = new MastermindGame(code);

            var result = new List<ResultPeg>();

            var guess = new List<CodePeg>();
            guess.Add(CodePeg.White);
            guess.Add(CodePeg.Red);
            guess.Add(CodePeg.Yellow);
            guess.Add(CodePeg.Yellow);
            result = m.GetHints(guess);
            foreach(var res in result)
            {
                Console.WriteLine(res);
            }


        }
    }
}
