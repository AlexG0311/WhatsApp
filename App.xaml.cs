namespace WhastApp
{
    public partial class App : Application
    {
        public static FlyoutPage FlyoutPage { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
