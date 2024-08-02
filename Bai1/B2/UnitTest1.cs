namespace B2
{
    public class Calculator
    {
        public int Multiply(int num1, int num2)
        {
            return checked(num1 * num2); // S? d?ng checked ?? phát hi?n tràn s? nguyên
        }
    }
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Multiply_TwoPositiveNumbers_ReturnsProduct()
        {
            // Arrange
            int num1 = 5;
            int num2 = 10;

            // Act
            int result = _calculator.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(50, result);
        }

        [Test]
        public void Multiply_TwoNegativeNumbers_ReturnsProduct()
        {
            // Arrange
            int num1 = -5;
            int num2 = -10;

            // Act
            int result = _calculator.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(50, result);
        }

        [Test]
        public void Multiply_PositiveAndNegativeNumber_ReturnsCorrectProduct()
        {
            // Arrange
            int num1 = 5;
            int num2 = -3;

            // Act
            int result = _calculator.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(-15, result);
        }

        [Test]
        public void Multiply_ZeroAndAnyNumber_ReturnsZero()
        {
            // Arrange
            int num1 = 0;
            int num2 = 10;

            // Act
            int result = _calculator.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Multiply_TwoZeros_ReturnsZero()
        {
            // Arrange
            int num1 = 0;
            int num2 = 0;

            // Act
            int result = _calculator.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Multiply_LargePositiveNumbers_ReturnsCorrectProduct()
        {
            // Arrange
            int num1 = 10000;
            int num2 = 20000;

            // Act
            int result = _calculator.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(200000000, result);
        }

        [Test]
        public void Multiply_LargeNegativeNumbers_ReturnsCorrectProduct()
        {
            // Arrange
            int num1 = -10000;
            int num2 = -20000;

            // Act
            int result = _calculator.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(200000000, result);
        }

        [Test]
        public void Multiply_LargeNumbers_Overflow_ReturnsException()
        {
            // Arrange
            int num1 = 1000000;
            int num2 = 3000;

            // Act & Assert
            Assert.Throws<OverflowException>(() => _calculator.Multiply(num1, num2));
        }

        [Test]
        public void Multiply_NegativeAndLargePositiveNumber_ReturnsCorrectProduct()
        {
            // Arrange
            int num1 = -1000000;
            int num2 = 2000;

            // Act
            int result = _calculator.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(-2000000, result);
        }
    }
}