using dlog.views;

namespace dlog
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new loginView();
        }
    }
}
