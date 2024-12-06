namespace MauiAppProblemFlyout8
{
    public partial class App : Application
    {
        private readonly Authentication _authentication;

        public App(Authentication authentication)
        {
            _authentication = authentication;
            InitializeComponent();

            MainPage = new AppShell(_authentication);
        }
    }
}
