using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Pract2Testing.Tests
{
    [TestClass]
    public class CheckStringTests
    {
        [TestMethod]
        public void FindShortestWord_ShortestWord_ShortestWordReturn()
        {
            //arrange
            string checkedString = "Привет, меня зовут Виктор. Я работник нефтедобывающей отрасли.";
            string shortestWord = "Я";//"Я"

            //act
            CheckString checkString = new CheckString();
            string result = checkString.FindShortestWord(checkedString);

            //assert
            Assert.AreEqual(shortestWord, result);
        }

        [TestMethod]
        public void CountWord_5WordsInString_ReturnCountWord()
        {
            //arrange
            string checkedString = "Индейцы захватили военный форпост англичан.";
            int countWord = 5; //5

            //act
            CheckString checkString = new CheckString();
            int result = checkString.CountWord(checkedString);

            //assert
            Assert.IsTrue(result == countWord);
        }

        [TestMethod]
        public void CountSymbols_7SymbolsInString_ReturnCountSymbols()
        {
            //arrange
            string checkedString = "Привет, Арсений, как твои дела? Я вчера купил ягоды: вишню, клубнику, арбуз.";
            int countSymbols = 7; //7

            //act
            CheckString checkString = new CheckString();
            int result = checkString.CountSymbols(checkedString);

            //assert
            Assert.IsFalse(result != countSymbols);
        }

        [TestMethod]
        public void FindSymbolByIndex_FindSymbolBy4Index_RetrunSymbol()
        {
            //arrange
            string checkedString = "Привет, Арсений, как твои дела? Я вчера купил ягоды: вишню, клубнику, арбуз.";
            int symbolIndex = 4;//4

            //act
            CheckString checkString = new CheckString();
            char result = checkString.FindSymbolByIndex(checkedString, symbolIndex);
            char indexSymbol = checkedString[3];

            //assert
            Assert.AreEqual(indexSymbol, result);
        }

        [TestMethod]
        public void CountNumbers_4NumbersInString_ReturnCountNumbers()
        {
            //arrange
            string checkedString = "Я - 1, он - 2, она - 3, а вот тот вообще - 4";
            int countNumbers = 4;//4

            //act
            CheckString checkString = new CheckString();
            int result = checkString.CountNumbers(checkedString);


            //assert
            Assert.AreEqual(countNumbers, result);
        }

        [TestMethod]
        public void ConsecutiveNumber_4ConsecutiveNumber_ReturnConsecutiveNumber()
        {
            //arrange
            string checkedString = "Этот магазин на 1 месте, вот этот на 123, а вон тот на 1234 месте";
            int countConsecutive = 4;//4

            //act
            CheckString checkString = new CheckString();
            int result = checkString.ConsecutiveNumbers(checkedString);

            //assert
            Assert.AreEqual(countConsecutive, result);
        }

        [TestMethod]
        public void CountCombination_3CombinationsInString_ReturnCountCombutation()
        {
            //arrange
            string checkedString = "Hello, hello! How are you? All are here.";
            string combination = "ll";
            int countCombination = 3;//3

            //act
            CheckString checkString = new CheckString();
            int result = checkString.CountCombination(checkedString, combination);

            //assert
            Assert.AreEqual(countCombination, result);
        }
    }
}
