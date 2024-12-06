namespace MauiAppProblemFlyout
{
    public partial class MainPage : ContentPage
    {
        private readonly Authentication _authentication;

        public Authentication Authentication => _authentication;

        public MainPage(Authentication authentication)
        {
            _authentication = authentication;
            InitializeComponent();
            BindingContext = this;
        }

    }

}
