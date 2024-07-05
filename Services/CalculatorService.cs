using Minimal_injection.Repository;

namespace Minimal_injection.Services;

public class CalculatorService(ICalculatorRepositpory calculatorRepository) : ICalculatorService
{
    public decimal CalculateService(decimal value1, decimal value2)
    {
        return calculatorRepository.CalculateRepositpory(value1, value2);
    }
}
