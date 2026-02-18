namespace Parcial1_Caifanes.Models
{
    /// <summary>
    /// Modelo de datos que representa un álbum musical.
    /// Estructura la información básica del disco, incluyendo su metadatos y lista de canciones.
    /// </summary>
    /// <author>Iker Javier Hernández Martínez</author>
    /// <date>17/02/2026</date>
    /// <version>1.0</version>
    /// <modification>17/02/2026</modification>
    public class Album
    {
        // Título oficial del álbum
        public string Name { get; set; } = string.Empty;

        // Año de publicación o lanzamiento
        public string Year { get; set; } = string.Empty;

        // Ruta del recurso de imagen para la portada
        public string ImageUrl { get; set; } = string.Empty;

        // Reseña o descripción del contenido del álbum
        public string Description { get; set; } = string.Empty;

        // Colección de cadenas con los títulos de las pistas (canciones)
        public List<string> Songs { get; set; } = new List<string>();
    }
}