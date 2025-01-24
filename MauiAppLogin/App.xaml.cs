namespace MauiAppLogin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);

            //definindo largura
            window.Width = 400;

            //definindo altura
            window.Height = 700;

            return window;
        }
    }  // fecha classe
} // fecha namespace
