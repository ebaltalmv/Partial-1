using Parcial1_Caifanes.Pages;

namespace Parcial1_Caifanes
{
    /// <summary>
    /// Clase principal que define la estructura visual y la jerarquía de navegación de la aplicación utilizando Shell.
    /// </summary>
    /// <author>Emmanuel Baltazar López</author>
    /// <date>17/02/2026</date>
    /// <version>1.0</version>
    /// <modification>17/02/2026</modification>
    public partial class AppShell : Shell
    {
        /// <summary>
        /// Inicializa los componentes de la Shell y registra las rutas de navegación para las páginas de detalles y tickets.
        /// </summary>
        /// <author>Emmanuel Baltazar López</author>
        /// <date>17/02/2026</date>
        /// <version>1.0</version>
        /// <modification>17/02/2026</modification>
        public AppShell()
        {
            InitializeComponent();

            // Registra la ruta para la página de detalles del concierto permitiendo navegación por URI
            Routing.RegisterRoute(nameof(DetailConcertsPage), typeof(DetailConcertsPage));

            // Registra la ruta para la página de compra de tickets
            Routing.RegisterRoute(nameof(TicketsPage), typeof(TicketsPage));
        }
    }
}