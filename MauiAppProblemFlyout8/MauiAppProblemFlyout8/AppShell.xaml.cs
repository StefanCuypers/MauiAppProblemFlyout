using System.ComponentModel;

namespace MauiAppProblemFlyout8
{
    public partial class AppShell : Shell
    {
        private readonly Authentication _authentication;

        public Authentication Authentication => _authentication;

        public AppShell(Authentication authentication)
        {
            _authentication = authentication;
            InitializeComponent();
            BindingContext = this;
            (_authentication as INotifyPropertyChanged).PropertyChanged += AppShell_PropertyChanged;
        }

        private void AppShell_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {

        }


    }
}
