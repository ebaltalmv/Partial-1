using Parcial1_Caifanes.Models;

namespace Parcial1_Caifanes.Pages;

/// <summary>
/// Página que presenta los detalles específicos de un concierto seleccionado.
/// Recibe el objeto ConcertModel a través de parámetros de consulta (QueryProperty).
/// </summary>
/// <author>Emmanuel Baltazar López</author>
/// <date>17/02/2026</date>
/// <version>1.0</version>
/// <modification>17/02/2026</modification>
[QueryProperty(nameof(ConcertModel), "Concerts")]
public partial class DetailConcertsPage : ContentPage
{
    // Variable privada de respaldo para el modelo
    private ConcertModel _concertModel;

    // Propiedad que almacena los datos del concierto actual y notifica cambios a la vista
    public ConcertModel ConcertModel
    {
        get => _concertModel;
        set
        {
            _concertModel = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Constructor de la página. Inicializa los componentes de la interfaz y crea una instancia base del modelo.
    /// </summary>
    /// <author>Emmanuel Baltazar López</author>
    /// <date>17/02/2026</date>
    /// <version>1.0</version>
    /// <modification>17/02/2026</modification>
    public DetailConcertsPage()
    {
        InitializeComponent();
        _concertModel = new ConcertModel();
    }

    /// <summary>
    /// Método sobrescrito del ciclo de vida que se ejecuta al mostrar la página.
    /// Asigna los valores del modelo (imagen, fecha, nombre, ubicación) a los controles de la UI.
    /// </summary>
    /// <author>Emmanuel Baltazar López</author>
    /// <date>17/02/2026</date>
    /// <version>1.0</version>
    /// <modification>17/02/2026</modification>
    override protected void OnAppearing()
    {
        base.OnAppearing();
        if (ConcertModel != null)
        {
            // Vinculación manual de datos a los controles visuales
            imageConcert.Source = ConcertModel.ImageUrl;
            dateLabel.Text = ConcertModel.Date;
            nameLabel.Text = ConcertModel.Name;
            locationLabel.Text = ConcertModel.Location;
            statusLabel.Text = ConcertModel.status;
        }
    }

    /// <summary>
    /// Manejador del evento de clic para el botón de compra. Navega a la página de tickets.
    /// </summary>
    /// <param name="sender">Objeto que dispara el evento.</param>
    /// <param name="e">Argumentos del evento.</param>
    /// <author>Emmanuel Baltazar López</author>
    /// <date>17/02/2026</date>
    /// <version>1.0</version>
    /// <modification>17/02/2026</modification>
    private async void OnBuyTicketClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(TicketsPage));
    }
}