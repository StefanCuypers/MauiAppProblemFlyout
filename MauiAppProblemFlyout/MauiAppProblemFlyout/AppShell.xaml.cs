namespace MauiAppProblemFlyout
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
        }
    }
}
