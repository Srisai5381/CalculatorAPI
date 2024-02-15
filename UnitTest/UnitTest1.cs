using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace UnitTest;

[TestClass]
public class UnitTest1
{
    private readonly CalculatorLibrary calculator = new CalculatorLibrary();
    [TestMethod]
    public void TestAdd_PositiveNumbers()
    {
        // Arrange
        decimal x = 5;
        decimal y = 3;
        decimal expectedResult = 8;

        // Act
        decimal result = Add(x, y);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void TestAdd_NegativeNumbers()
    {
        // Arrange
        decimal x = -5;
        decimal y = -3;
        decimal expectedResult = -8;

        // Act
        decimal result = Add(x, y);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void TestAdd_ZeroAndPositive()
    {
        // Arrange
        decimal x = 0;
        decimal y = 3;
        decimal expectedResult = 3;

        // Act
        decimal result = Add(x, y);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void TestAdd_ZeroAndNegative()
    {
        // Arrange
        decimal x = 0;
        decimal y = -3;
        decimal expectedResult = -3;

        // Act
        decimal result = Add(x, y);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void TestAdd_DecimalNumbers()
    {
        // Arrange
        decimal x = 1.5m;
        decimal y = 2.5m;
        decimal expectedResult = 4.0m;

        // Act
        decimal result = Add(x, y);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    public decimal Add(decimal x, decimal y)
    {
        return x + y;
    }
    [TestMethod]
    public void TestSubtract_PositiveNumbers()
    {
        // Arrange
        decimal x = 5;
        decimal y = 3;
        decimal expectedResult = 2;

        // Act
        decimal result = Subtract(x, y);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void TestSubtract_NegativeNumbers()
    {
        // Arrange
        decimal x = -5;
        decimal y = -3;
        decimal expectedResult = -2;

        // Act
        decimal result = Subtract(x, y);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void TestSubtract_PositiveAndNegative()
    {
        // Arrange
        decimal x = 5;
        decimal y = -3;
        decimal expectedResult = 8;

        // Act
        decimal result = Subtract(x, y);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void TestSubtract_ZeroAndPositive()
    {
        // Arrange
        decimal x = 0;
        decimal y = 3;
        decimal expectedResult = -3;

        // Act
        decimal result = Subtract(x, y);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void TestSubtract_ZeroAndNegative()
    {
        // Arrange
        decimal x = 0;
        decimal y = -3;
        decimal expectedResult = 3;

        // Act
        decimal result = Subtract(x, y);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    public decimal Subtract(decimal x, decimal y)
    {
        return x - y;
    }
    [TestClass]
    public class MyTestClass
    {
        [TestMethod]
        public void TestMultiply_PositiveNumbers()
        {
            // Arrange
            decimal x = 5;
            decimal y = 3;
            decimal expectedResult = 15;

            // Act
            decimal result = Multiply(x, y);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestMultiply_NegativeNumbers()
        {
            // Arrange
            decimal x = -5;
            decimal y = -3;
            decimal expectedResult = 15;

            // Act
            decimal result = Multiply(x, y);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestMultiply_PositiveAndNegative()
        {
            // Arrange
            decimal x = 5;
            decimal y = -3;
            decimal expectedResult = -15;

            // Act
            decimal result = Multiply(x, y);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestMultiply_ByZero()
        {
            // Arrange
            decimal x = 5;
            decimal y = 0;
            decimal expectedResult = 0;

            // Act
            decimal result = Multiply(x, y);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestMultiply_Decimals()
        {
            // Arrange
            decimal x = 1.5m;
            decimal y = 2.5m;
            decimal expectedResult = 3.75m;

            // Act
            decimal result = Multiply(x, y);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        public decimal Multiply(decimal x, decimal y)
        {
            return x * y;
        }
        [TestMethod]
        public void TestDivide_PositiveNumbers()
        {
            // Arrange
            decimal x = 10;
            decimal y = 2;
            decimal expectedResult = 5;

            // Act
            decimal result = Divide(x, y);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestDivide_NegativeNumbers()
        {
            // Arrange
            decimal x = -10;
            decimal y = -2;
            decimal expectedResult = 5;

            // Act
            decimal result = Divide(x, y);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestDivide_DivideByZero()
        {
            // Arrange
            decimal x = 10;
            decimal y = 0;

            // Act & Assert
            Assert.ThrowsException<DivideByZeroException>(() => Divide(x, y));
        }

        [TestMethod]
        public void TestDivide_DecimalNumbers()
        {
            // Arrange
            decimal x = 5;
            decimal y = 2;
            decimal expectedResult = 2.5m;

            // Act
            decimal result = Divide(x, y);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestDivide_DecimalResult()
        {
            // Arrange
            decimal x = 5;
            decimal y = 3;
            decimal expectedResult = 1.666666m;

            // Act
            decimal result = Divide(x, y);

            // Assert
            Assert.AreEqual(expectedResult, Math.Round(result, 6));
        }

        public decimal Divide(decimal x, decimal y)
        {
            if (y == 0)
                throw new DivideByZeroException("Input cannot be zero");
            return x / y;
        }

    }