using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace UnitTestTypograph
{
    [TestClass]
    public class TypographTest
    {
        // 1 
        [TestMethod]
        public void TestPunctuationSpacing()
        {
            string inputText = "Пример текста,который нужно.проверить!";
            string expectedText = "Пример текста, который нужно. проверить!";

            string actualText = Regex.Replace(inputText, @"(\w)([.,!?])", "$1 $2");

            Assert.AreEqual(expectedText, actualText);
        }
        // 2
        [TestMethod]
        public void TestSingleSpace()
        {
            string inputText = "Этот текст    нужно  проверить";
            string expectedText = "Этот текст нужно проверить";

            string actualText = Regex.Replace(inputText, @"\s+", " ");

            Assert.AreEqual(expectedText, actualText);
        }
        // 3
        [TestMethod]
        public void TestHyphenSpacing()
        {
            string inputText = "слово - другое";
            string expectedText = "слово - другое";

            string actualText = Regex.Replace(inputText, @"(\S+)-(\S+)", "$1-$2");

            Assert.AreEqual(expectedText, actualText);
        }
        // 4
        [TestMethod]
        public void TestCapitalizationAfterPeriod()
        {
            string inputText = "это текст. следующее предложение.";
            string expectedText = "Это текст. Следующее предложение.";

            string actualText = Regex.Replace(inputText, @"(?<=\.|^)(\s*)(\w)", m => m.Value.ToUpper());

            Assert.AreEqual(expectedText, actualText);
        }
        // 5 
        [TestMethod]
        public void TestVowelHyphen()
        {
            string inputText = "белый еж";
            string expectedText = "белый е-ж";

            string actualText = Regex.Replace(inputText, @"е(\s+)ё", "е-ё");

            Assert.AreEqual(expectedText, actualText);
        }
        // 6
        [TestMethod]
        public void TestNumberSpacing()
        {
            string inputText = "123456789";
            string expectedText = "123 456 789";

            string actualText = Regex.Replace(inputText, @"(\d)(?=(\d{3})+(?!\d))", "$1 ");

            Assert.AreEqual(expectedText, actualText);
        }
        // 7
        [TestMethod]
        public void TestVowelHyphenReverse()
        {
            string inputText = "порт е-жа";
            string expectedText = "порт е-жа";

            string actualText = Regex.Replace(inputText, @"ё(\s+)е", "ё-е");

            Assert.AreEqual(expectedText, actualText);
        }
        // 8
        [TestMethod]
        public void TestSentenceStartWithNumber()
        {
            string inputText = "2 параграфа";
            string expectedText = "2 параграфа";

            string actualText = Regex.Replace(inputText, @"(?<=\.|^)(\s*)(\d)", m => m.Value.ToUpper());

            Assert.AreEqual(expectedText, actualText);
        }
        // 9
        [TestMethod]
        public void TestNumberDecimalSpacing()
        {
            string inputText = "12.3456";
            string expectedText = "12.3456";

            string actualText = Regex.Replace(inputText, @"(\d)\.(\d)", "$1.$2");

            Assert.AreEqual(expectedText, actualText);
        }
        // 10
        [TestMethod]
        public void TestNumberCommaSpacing()
        {
            string inputText = "1,000,000";
            string expectedText = "1,000,000";

            string actualText = Regex.Replace(inputText, @"(\d),(\d{3})", "$1,$2");

            Assert.AreEqual(expectedText, actualText);
        }
    }
}
