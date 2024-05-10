namespace MSTest_Test_Project
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void ShouldCalculateSumCorrectly()
        {
            // Arrange
            int firstNumber = 5;
            int secondNumber = 10;
            int expectedSum = 15;

            // Act
            int sum = ArithmeticOperations.Sum(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void ShouldCalculateQuotientCorrectly()
        {
            // Arrange
            int dividend = 20;
            int divisor = 4;
            int expectedQuotient = 5;

            // Act
            int quotient = ArithmeticOperations.Quotient(dividend, divisor);

            // Assert
            Assert.AreEqual(expectedQuotient, quotient);
        }

        [TestMethod]
        public void ShouldIdentifyPalindromes()
        {
            // Arrange
            string word1 = "deified";
            string word2 = "example";

            // Act & Assert
            Assert.IsTrue(TextUtilities.CheckPalindrome(word1));
            Assert.IsFalse(TextUtilities.CheckPalindrome(word2));
        }
    }

    public static class ArithmeticOperations
    {
        public static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public static int Quotient(int dividend, int divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException("Divisor cannot be zero.");
            return dividend / divisor;
        }
    }

    public static class TextUtilities
    {
        public static bool CheckPalindrome(string input)
        {
            string reversed = new string(input.Reverse().ToArray());
            return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
    }

}