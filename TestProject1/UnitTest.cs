


using Mastermind.Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    class UnitTest
    {
        [TestMethod]
        public void CorrectInTheSamePosition()
        {
            //Arrange
            var code = new List<CodePeg>();
            code.Add(CodePeg.White);
            code.Add(CodePeg.Red);
            code.Add(CodePeg.Green);
            code.Add(CodePeg.Black);
            //-----------------------------------
            var guess = new List<CodePeg>();
            guess.Add(CodePeg.White);
            guess.Add(CodePeg.Red);
            guess.Add(CodePeg.Yellow);
            guess.Add(CodePeg.Yellow);

            var expected = new List<ResultPeg>();
            expected.Add(ResultPeg.Black);
            expected.Add(ResultPeg.Black);
            //Act
           var actual = new MastermindGame(code).GetHints(guess);

            //Assert
            Assert.IsInstanceOfType(actual, typeof(ResultPeg));
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void CorrectInDifferentPosition()
        {
            //Arrange
            var code = new List<CodePeg>();
            code.Add(CodePeg.White);
            code.Add(CodePeg.Red);
            code.Add(CodePeg.Green);
            code.Add(CodePeg.Black);
            //-----------------------------------
            var guess = new List<CodePeg>();
            guess.Add(CodePeg.Red);
            guess.Add(CodePeg.Green);
            guess.Add(CodePeg.Black);
            guess.Add(CodePeg.Yellow);

            var expected = new List<ResultPeg>();
            expected.Add(ResultPeg.White);
            expected.Add(ResultPeg.White);
            //Act
            var actual = new MastermindGame(code).GetHints(guess);
            //Assert
            Assert.IsInstanceOfType(actual, typeof(ResultPeg));
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void ThereIsNoMatch()
        {
            //Arrange
            var code = new List<CodePeg>();
            code.Add(CodePeg.White);
            code.Add(CodePeg.White);
            code.Add(CodePeg.White);
            code.Add(CodePeg.White);
            //-----------------------------------
            var guess = new List<CodePeg>();
            guess.Add(CodePeg.Red);
            guess.Add(CodePeg.Red);
            guess.Add(CodePeg.Red);
            guess.Add(CodePeg.Red);

            var expected = new List<ResultPeg>();
            
            //Act
            var actual = new MastermindGame(code).GetHints(guess);
            //Assert
            Assert.IsInstanceOfType(actual, typeof(ResultPeg));
            Assert.AreEqual(expected, actual);


        }

    }
}
