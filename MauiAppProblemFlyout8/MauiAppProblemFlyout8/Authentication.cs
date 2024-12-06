using System.ComponentModel;

namespace MauiAppProblemFlyout8;

public class Authentication : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private bool _isLoggedOn;

    public bool IsLoggedOn
    {
        get => _isLoggedOn;
        set
        {
            if (_isLoggedOn != value)
            {
                _isLoggedOn = value;
                PropertyChanged?.Invoke(this, new(nameof(IsLoggedOn)));
            }
        }
    }
}
