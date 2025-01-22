using Review3;

namespace TestingReview3
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckifMethodCorrectlyIdentifysVowels()
        {
            //Arrange
            String inputString = "level";
            String ExpectedOutput = "ee";

            //Act
            String actualOutput =Probnum5.CheckVowels(inputString);

            //Assert
            Assert.AreEqual(ExpectedOutput,actualOutput);
        }

        [Test]
        public void CheckifMethodCorrectlyReversesAString()
        {
            //Arrange 
            String str = "hello";
            String expString = "olleh";

            //Act
            String reversedStr =Probnum5.ReverseString(str);

            //Assert
            Assert.AreEqual(expString,reversedStr);
        
        }

        [Test]
        public void checkifMethodReturnsTrueForPalindromeString() {

            Assert.IsTrue(Probnum5.CheckifPalindrome("level"));
        
        }

        [Test]
        public void checkifMethodReturnsFalseForNonPalindromeString()
        {

            Assert.IsFalse(Probnum5.CheckifPalindrome("hello"));

        }

    }
}