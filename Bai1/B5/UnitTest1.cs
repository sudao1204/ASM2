namespace B5
{
    public class ArrayManipulator
    {
        public int GetElementAtIndex(int[] array, int index)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Mảng không được null.");
            }

            if (index < 0 || index >= array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Chỉ số nằm ngoài phạm vi.");
            }

            return array[index];
        }
    }
    [TestFixture]
    public class ArrayManipulatorTests
    {
        private ArrayManipulator _arrayManipulator;

        [SetUp]
        public void Setup()
        {
            _arrayManipulator = new ArrayManipulator();
        }

        [Test]
        public void GetElementAtIndex_ValidIndex_ReturnsCorrectElement()
        {
            // Arrange
            int[] array = { 10, 20, 30, 40, 50 };
            int index = 2;

            // Act
            int result = _arrayManipulator.GetElementAtIndex(array, index);

            // Assert
            Assert.AreEqual(30, result);
        }

        [Test]
        public void GetElementAtIndex_FirstElement_ReturnsCorrectElement()
        {
            // Arrange
            int[] array = { 1, 2, 3, 4, 5 };
            int index = 0;

            // Act
            int result = _arrayManipulator.GetElementAtIndex(array, index);

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetElementAtIndex_LastElement_ReturnsCorrectElement()
        {
            // Arrange
            int[] array = { 5, 4, 3, 2, 1 };
            int index = 4;

            // Act
            int result = _arrayManipulator.GetElementAtIndex(array, index);

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetElementAtIndex_NegativeIndex_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            int[] array = { 10, 20, 30 };
            int index = -1;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _arrayManipulator.GetElementAtIndex(array, index));
        }

        [Test]
        public void GetElementAtIndex_IndexGreaterThanLength_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            int[] array = { 10, 20, 30 };
            int index = 3;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _arrayManipulator.GetElementAtIndex(array, index));
        }

        [Test]
        public void GetElementAtIndex_NullArray_ThrowsArgumentNullException()
        {
            // Arrange
            int[] array = null;
            int index = 0;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => _arrayManipulator.GetElementAtIndex(array, index));
        }

        [Test]
        public void GetElementAtIndex_EmptyArray_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            int[] array = { };
            int index = 0;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _arrayManipulator.GetElementAtIndex(array, index));
        }

        [Test]
        public void GetElementAtIndex_ArrayWithOneElement_ReturnsCorrectElement()
        {
            // Arrange
            int[] array = { 42 };
            int index = 0;

            // Act
            int result = _arrayManipulator.GetElementAtIndex(array, index);

            // Assert
            Assert.AreEqual(42, result);
        }

        [Test]
        public void GetElementAtIndex_MultipleCalls_ReturnsCorrectElements()
        {
            // Arrange
            int[] array = { 10, 20, 30, 40, 50 };

            // Act & Assert
            Assert.AreEqual(10, _arrayManipulator.GetElementAtIndex(array, 0));
            Assert.AreEqual(20, _arrayManipulator.GetElementAtIndex(array, 1));
            Assert.AreEqual(30, _arrayManipulator.GetElementAtIndex(array, 2));
            Assert.AreEqual(40, _arrayManipulator.GetElementAtIndex(array, 3));
            Assert.AreEqual(50, _arrayManipulator.GetElementAtIndex(array, 4));
        }
    }
}