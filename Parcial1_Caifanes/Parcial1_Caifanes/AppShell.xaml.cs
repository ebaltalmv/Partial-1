using Parcial1_Caifanes.Pages;

namespace Parcial1_Caifanes
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(DetailConcertsPage), typeof(DetailConcertsPage));
            Routing.RegisterRoute(nameof(TicketsPage), typeof(TicketsPage));
        }
    }
}
