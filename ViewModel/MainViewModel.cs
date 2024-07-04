using CommunityToolkit.Mvvm.Input;
using Minimal_injection.Services;
using MvvmHelpers;
using System.Windows.Input;

namespace Minimal_injection.ViewModel;

public class MainViewModel : BaseViewModel
{
    private readonly ICalculatorService _calculatorService;

    private decimal _value1;
    private decimal _value2;
    private decimal _result;

    public ICommand CalculateCommand { get; }

    public decimal Value1
    {
        get => _value1;
        set
        {
            _value1 = value;
            OnPropertyChanged(nameof(Value1));
        }
    }

    public decimal Value2
    {
        get => _value2;
        set
        {
            _value2 = value;
            OnPropertyChanged(nameof(Value2));
        }
    }

    public decimal Result
    {
        get => _result;
        set
        {
            _result = value;
            OnPropertyChanged(nameof(Result));
        }
    }

    public MainViewModel(ICalculatorService calculatorService)
    {
        _calculatorService = calculatorService;
        CalculateCommand = new RelayCommand(OnCalculateCommandExecuted);
    }        

    private void OnCalculateCommandExecuted()
    {
        Result = _calculatorService.CalculateService(Value1, Value2);
    }
}
