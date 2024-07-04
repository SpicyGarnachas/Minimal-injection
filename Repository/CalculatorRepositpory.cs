namespace Minimal_injection.Repository;

public class CalculatorRepositpory : ICalculatorRepositpory
{
    public decimal CalculateRepositpory(decimal value1, decimal value2)
    {
        return value1 + value2;
    }
}