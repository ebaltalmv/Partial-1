using Parcial1_Caifanes.Models;

namespace Parcial1_Caifanes.Pages;

/// <summary>
/// Página que muestra los detalles de un álbum específico.
/// Configura el contexto de datos (BindingContext) con el álbum seleccionado para mostrar su información en la vista.
/// </summary>
/// <author>Iker Javier Hernández Martínez</author>
/// <date>17/02/2026</date>
/// <version>1.0</version>
/// <modification>17/02/2026</modification>
public partial class DatailAlbumPage : ContentPage
{
    /// <summary>
    /// Constructor de la página. Inicializa los componentes visuales y establece el álbum recibido como contexto de enlace de datos.
    /// </summary>
    /// <param name="album">El objeto Album con la información a mostrar.</param>
    /// <author>Iker Javier Hernández Martínez</author>
    /// <date>17/02/2026</date>
    /// <version>1.0</version>
    /// <modification>17/02/2026</modification>
    public DatailAlbumPage(Album album)
    {
        InitializeComponent();
        BindingContext = album;
    }
}