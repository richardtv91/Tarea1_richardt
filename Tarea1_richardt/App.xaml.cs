namespace Tarea1_richardt
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //return new Window(new Views.Login());
            return new Window(new NavigationPage(new Views.Login()));
        }
    }
}