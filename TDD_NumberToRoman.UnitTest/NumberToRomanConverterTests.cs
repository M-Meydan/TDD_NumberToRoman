using NUnit.Framework;
using TDD_NumberToRoman.Converters;

namespace TDD_NumberToRoman.UnitTest
{
    [TestFixture(Category = "Number to Roman Converter Tests")]
    public class NumberToRomanConverterTests //: GlobalTestSetup
    {
        [Test(Author = "Muhsin Meydan")]
        # region TestCases
        [TestCase(1, ExpectedResult = "I")]
        [TestCase(2, ExpectedResult = "II")]
        [TestCase(3, ExpectedResult = "III")]
        [TestCase(4, ExpectedResult = "IV")]
        [TestCase(5, ExpectedResult = "V")]
        [TestCase(6, ExpectedResult = "VI")]
        [TestCase(7, ExpectedResult = "VII")]
        [TestCase(8, ExpectedResult = "VIII")]
        [TestCase(9, ExpectedResult = "IX")]
        [TestCase(10, ExpectedResult = "X")]
        [TestCase(11, ExpectedResult = "XI")]
        [TestCase(12, ExpectedResult = "XII")]
        [TestCase(13, ExpectedResult = "XIII")]
        [TestCase(14, ExpectedResult = "XIV")]
        [TestCase(15, ExpectedResult = "XV")]
        [TestCase(16, ExpectedResult = "XVI")]
        [TestCase(17, ExpectedResult = "XVII")]
        [TestCase(18, ExpectedResult = "XVIII")]
        [TestCase(19, ExpectedResult = "XIX")]
        [TestCase(20, ExpectedResult = "XX")]
        [TestCase(21, ExpectedResult = "XXI")]
        [TestCase(22, ExpectedResult = "XXII")]
        [TestCase(23, ExpectedResult = "XXIII")]
        [TestCase(24, ExpectedResult = "XXIV")]
        [TestCase(25, ExpectedResult = "XXV")]
        [TestCase(26, ExpectedResult = "XXVI")]
        [TestCase(27, ExpectedResult = "XXVII")]
        [TestCase(28, ExpectedResult = "XXVIII")]
        [TestCase(29, ExpectedResult = "XXIX")]
        [TestCase(30, ExpectedResult = "XXX")]
        [TestCase(34, ExpectedResult = "XXXIV")]
        [TestCase(39, ExpectedResult = "XXXIX")]
        [TestCase(40, ExpectedResult = "XL")]
        [TestCase(44, ExpectedResult = "XLIV")]
        [TestCase(49, ExpectedResult = "XLIX")]
        [TestCase(50, ExpectedResult = "L")]
        [TestCase(54, ExpectedResult = "LIV")]
        [TestCase(59, ExpectedResult = "LIX")]
        [TestCase(60, ExpectedResult = "LX")]
        [TestCase(70, ExpectedResult = "LXX")]
        [TestCase(80, ExpectedResult = "LXXX")]
        [TestCase(90, ExpectedResult = "XC")]
        [TestCase(100, ExpectedResult = "C")]
        [TestCase(104, ExpectedResult = "CIV")]
        [TestCase(144, ExpectedResult = "CXLIV")]
        [TestCase(159, ExpectedResult = "CLIX")]
        [TestCase(199, ExpectedResult = "CXCIX")]
        [TestCase(200, ExpectedResult = "CC")]
        [TestCase(299, ExpectedResult = "CCXCIX")]
        [TestCase(999, ExpectedResult = "CMXCIX")]
        [TestCase(1000, ExpectedResult = "M")]
        [TestCase(1994, ExpectedResult = "MCMXCIV")]
        [TestCase(2994, ExpectedResult = "MMCMXCIV")]
        [TestCase(9999, ExpectedResult = "MMMMMMMMMCMXCIX")]
        [TestCase(10999, ExpectedResult = "MMMMMMMMMMCMXCIX")]
        [TestCase(99999, ExpectedResult = "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMCMXCIX")]
        #endregion 
        public string Convert(int number)
        {
            var result = new NumberToRomanConverter(number).Convert();

            return result;
        }
    }
}
