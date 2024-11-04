
using CommunityToolkit.Mvvm.ComponentModel;

namespace Sentry_3694.ViewModels;
public class MainViewModel : ObservableObject
{
    private int _count = 0;

    public int Count
    {
        get => _count;
        set => SetProperty(ref _count, value);
    }
    public Command CountCommand { get; set; } 
    public MainViewModel ()
    {
        CountCommand = new Command(() =>
        {
            Count++;

            if (Count == 5)
            {
                throw new Exception();
            }
        });
    }
}
