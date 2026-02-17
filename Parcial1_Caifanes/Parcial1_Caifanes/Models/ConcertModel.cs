namespace Parcial1_Caifanes.Models
{
    /// <summary>
    /// Modelo de datos que representa la entidad de un concierto.
    /// Contiene la información básica necesaria para mostrar los detalles del evento en la lista y páginas de detalle.
    /// </summary>
    /// <author>Emmanuel Baltazar López</author>
    /// <date>17/02/2026</date>
    /// <version>1.0</version>
    /// <modification>17/02/2026</modification>
    public class ConcertModel
    {
        // Ruta o URL de la imagen del concierto, inicializada con una imagen por defecto
        public string ImageUrl { get; set; } = "concert_logo.png";

        // Fecha en la que se llevará a cabo el concierto
        public string Date { get; set; } = string.Empty;

        // Nombre del evento o ciudad donde se realiza
        public string Name { get; set; } = string.Empty;

        // Ubicación específica o recinto (Venue) del evento
        public string Location { get; set; } = string.Empty;

        // Estado actual de los boletos (ej. Available, Sold Out, Coming Soon)
        public string status { get; set; } = string.Empty;
    }
}