namespace B3
{
    public class Calculator
    {
        public int Subtract(int num1, int num2)
        {
            return num1 - num2; // Tính hiệu của hai số
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
        public void Subtract_TwoPositiveNumbers_ReturnsDifference()
        {
            // Arrange
            int num1 = 10;
            int num2 = 5;

            // Act
            int result = _calculator.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Subtract_TwoNegativeNumbers_ReturnsDifference()
        {
            // Arrange
            int num1 = -10;
            int num2 = -5;

            // Act
            int result = _calculator.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(-5, result);
        }

        [Test]
        public void Subtract_PositiveAndNegativeNumber_ReturnsCorrectDifference()
        {
            // Arrange
            int num1 = 5;
            int num2 = -3;

            // Act
            int result = _calculator.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(8, result);
        }

        [Test]
        public void Subtract_ZeroAndPositiveNumber_ReturnsNegativeNumber()
        {
            // Arrange
            int num1 = 0;
            int num2 = 10;

            // Act
            int result = _calculator.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(-10, result);
        }

        [Test]
        public void Subtract_ZeroAndNegativeNumber_ReturnsPositiveNumber()
        {
            // Arrange
            int num1 = 0;
            int num2 = -10;

            // Act
            int result = _calculator.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(10, result);
        }

        [Test]
        public void Subtract_LargePositiveNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            int num1 = 1000000;
            int num2 = 500000;

            // Act
            int result = _calculator.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(500000, result);
        }

        [Test]
        public void Subtract_LargeNegativeNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            int num1 = -1000000;
            int num2 = -500000;

            // Act
            int result = _calculator.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(-500000, result);
        }

        [Test]
        public void Subtract_LargeNumbers_Overflow_ReturnsException()
        {
            // Arrange
            int num1 = int.MaxValue; // Giá trị lớn nhất của int
            int num2 = -1;

            // Act & Assert
            Assert.Throws<OverflowException>(() => _calculator.Subtract(num1, num2));
        }

        [Test]
        public void Subtract_TwoZeros_ReturnsZero()
        {
            // Arrange
            int num1 = 0;
            int num2 = 0;

            // Act
            int result = _calculator.Subtract(num1, num2);

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}