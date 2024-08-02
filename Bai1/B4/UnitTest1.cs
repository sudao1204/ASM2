namespace B4
{
    public class Calculator
    {
        public double CalculateAverage(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("Danh sách không được rỗng.");
            }
            return numbers.Average();
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
        public void CalculateAverage_ValidPositiveNumbers_ReturnsCorrectAverage()
        {
            // Arrange
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

            // Act
            double result = _calculator.CalculateAverage(numbers);

            // Assert
            Assert.AreEqual(30, result);
        }

        [Test]
        public void CalculateAverage_ValidNegativeNumbers_ReturnsCorrectAverage()
        {
            // Arrange
            List<int> numbers = new List<int> { -10, -20, -30, -40, -50 };

            // Act
            double result = _calculator.CalculateAverage(numbers);

            // Assert
            Assert.AreEqual(-30, result);
        }

        [Test]
        public void CalculateAverage_MixedNumbers_ReturnsCorrectAverage()
        {
            // Arrange
            List<int> numbers = new List<int> { -10, 0, 10, 20 };

            // Act
            double result = _calculator.CalculateAverage(numbers);

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void CalculateAverage_ZeroNumbers_ReturnsZero()
        {
            // Arrange
            List<int> numbers = new List<int> { 0, 0, 0 };

            // Act
            double result = _calculator.CalculateAverage(numbers);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CalculateAverage_SingleNumber_ReturnsSameNumber()
        {
            // Arrange
            List<int> numbers = new List<int> { 42 };

            // Act
            double result = _calculator.CalculateAverage(numbers);

            // Assert
            Assert.AreEqual(42, result);
        }

        [Test]
        public void CalculateAverage_EmptyList_ThrowsArgumentException()
        {
            // Arrange
            List<int> numbers = new List<int>();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _calculator.CalculateAverage(numbers));
        }

        [Test]
        public void CalculateAverage_NullList_ThrowsArgumentException()
        {
            // Arrange
            List<int> numbers = null;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => _calculator.CalculateAverage(numbers));
        }

        [Test]
        public void CalculateAverage_LargeNumbers_ReturnsCorrectAverage()
        {
            // Arrange
            List<int> numbers = new List<int> { int.MaxValue, int.MaxValue };

            // Act
            double result = _calculator.CalculateAverage(numbers);

            // Assert
            Assert.AreEqual(int.MaxValue, result);
        }

        [Test]
        public void CalculateAverage_VeryLargeList_ReturnsCorrectAverage()
        {
            // Arrange
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 1000; i++)
            {
                numbers.Add(i);
            }

            // Act
            double result = _calculator.CalculateAverage(numbers);

            // Assert
            Assert.AreEqual(500.5, result);
        }

        [Test]
        public void CalculateAverage_AllSameNumbers_ReturnsSameNumber()
        {
            // Arrange
            List<int> numbers = new List<int> { 5, 5, 5, 5, 5 };

            // Act
            double result = _calculator.CalculateAverage(numbers);

            // Assert
            Assert.AreEqual(5, result);
        }
    }
}