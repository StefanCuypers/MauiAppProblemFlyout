namespace MauiAppProblemFlyout
{
    public partial class App : Application
    {
        private readonly Authentication _authentication;

        public App(Authentication authentication)
        {
            _authentication = authentication;
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell(_authentication));
        }
    }
}