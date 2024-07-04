using Minimal_injection.Repository;

namespace Minimal_injection.Services;

public class CalculatorService : ICalculatorService
{
    private readonly ICalculatorRepositpory _calculatorRepositpory;

    public CalculatorService(ICalculatorRepositpory calculatorRepository)
    {
        _calculatorRepositpory = calculatorRepository;
    }
    public decimal CalculateService(decimal value1, decimal value2)
    {
        return _calculatorRepositpory.CalculateRepositpory(value1, value2);
    }
}
