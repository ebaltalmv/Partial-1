using Parcial1_Caifanes.Models;

namespace Parcial1_Caifanes.Pages;

/// <summary>
/// Página que presenta los detalles específicos de un concierto seleccionado.
/// Recibe el objeto ConcertModel directamente en el constructor para su visualización.
/// </summary>
/// <author>Emmanuel Baltazar López</author>
/// <date>27/02/2026</date>
/// <version>1.1</version>
/// <modification>27/02/2026</modification>
public partial class DetailConcertsPage : ContentPage
{
    // Variable privada de respaldo para el modelo
    private ConcertModel _concertModel;

    /// <summary>
    /// Constructor de la página. Inicializa los componentes y recibe el modelo seleccionado.
    /// </summary>
    /// <param name="selectedConcert">El objeto de modelo con los datos del concierto.</param>
    /// <author>Emmanuel Baltazar López</author>
    /// <date>27/02/2026</date>
    /// <version>1.1</version>
    /// <modification>27/02/2026</modification>
    public DetailConcertsPage(ConcertModel selectedConcert)
    {
        InitializeComponent();
        _concertModel = selectedConcert;

        // Asignación de datos a los controles visuales
        if (_concertModel != null)
        {
            dateLabel.Text = _concertModel.Date;
            nameLabel.Text = _concertModel.Name;
            locationLabel.Text = _concertModel.Location;
            statusLabel.Text = _concertModel.status;
        }
    }

    /// <summary>
    /// Manejador del evento de clic para el botón de compra. Navega a la página de tickets.
    /// </summary>
    /// <param name="sender">Objeto que dispara el evento.</param>
    /// <param name="e">Argumentos del evento.</param>
    /// <author>Emmanuel Baltazar López</author>
    /// <date>27/02/2026</date>
    /// <version>1.0</version>
    /// <modification>27/02/2026</modification>
    private async void OnBuyTicketClicked(object sender, EventArgs e)
    {
        // Usamos PushAsync para mantener consistencia con la navegación por stack
        await Navigation.PushAsync(new TicketsPage());
    }
}