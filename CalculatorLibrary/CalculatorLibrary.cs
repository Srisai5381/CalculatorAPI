namespace CalculatorLibrary;

public static class CalculatorLibrary {

    public decimal Add(decimal x, decimal y)
    {
        return x + y;
    }

    public decimal Subtract(decimal x, decimal y)
    {
        return x - y;
    }

    public decimal Multiply(decimal x, decimal y)
    {
        return x * y;
    }

    public decimal Divide(decimal x, decimal y)
    {
        if (y == 0)
            throw new DivideByZeroException("Input cannot be zero");
        return x / y;
    }

    public decimal Modulo(decimal x, decimal y)
    {
        if (y == 0)
            throw new DivideByZeroException("Input cannot be zero");
        return x % y;
    }
}