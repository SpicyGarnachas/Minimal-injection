using Minimal_injection.ViewModel;
using System.Windows;


namespace Minimal_injection;

public partial class MainWindow : Window
{
    private readonly MainViewModel _mainViewModel;
    public MainWindow(MainViewModel mainViewModel)
    {
        InitializeComponent();
        _mainViewModel = mainViewModel;
        DataContext = _mainViewModel;
    }
}