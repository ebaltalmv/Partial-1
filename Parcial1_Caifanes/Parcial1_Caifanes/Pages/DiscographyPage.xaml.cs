using Parcial1_Caifanes.Models;

namespace Parcial1_Caifanes.Pages;

/// <summary>
/// Página encargada de mostrar la discografía completa de la banda.
/// Gestiona la creación de la lista de álbumes y la navegación hacia los detalles de cada uno.
/// </summary>
/// <author>Iker Javier Hernández Martínez</author>
/// <date>17/02/2026</date>
/// <version>1.0</version>
/// <modification>17/02/2026</modification>
public partial class DiscographyPage : ContentPage
{
    /// <summary>
    /// Constructor de la página. Inicializa los componentes de la interfaz y carga la información de los álbumes.
    /// </summary>
    /// <author>Iker Javier Hernández Martínez</author>
    /// <date>17/02/2026</date>
    /// <version>1.0</version>
    /// <modification>17/02/2026</modification>
    public DiscographyPage()
    {
        InitializeComponent();
        CargarAlbumes();
    }

    /// <summary>
    /// Método auxiliar que instancia la lista de álbumes con su información detallada (nombre, año, imagen, descripción y canciones)
    /// y la asigna como fuente de datos para la colección visual.
    /// </summary>
    /// <author>Iker Javier Hernández Martínez</author>
    /// <date>17/02/2026</date>
    /// <version>1.0</version>
    /// <modification>17/02/2026</modification>
    private void CargarAlbumes()
    {
        var albumes = new List<Album>
        {
            new Album { Name = "Caifanes",
                Year = "1988",
                ImageUrl = "album_homonimo.jpg",
                Description = "El álbum debut de Caifanes definió el sonido oscuro y alternativo que marcaría al rock mexicano de finales de los años ochenta. Con influencias del post-punk y una estética cargada de misticismo urbano, la banda presentó letras intensas y atmósferas profundas que conectaron con una nueva generación. Canciones como “Mátenme porque me muero” y “La Negra Tomasa” impulsaron su popularidad, consolidándolos como una de las propuestas más innovadoras del momento.",
                Songs = new List<string>  {"Mátenme porque me muero", "Te estoy mirando", "La negra Tomasa", "Viento", "Nunca me voy a transformar en ti", "Perdí mi ojo de venado", "Amanece", "Estamos acostumbrados", "Cuéntame tu vida", "Será por eso" }},

            new Album { Name = "El Diablito",
                Year = "1990",
                ImageUrl = "album_diablito.jpg",
                Description = "Con El Diablito, la banda mostró una evolución clara en su propuesta musical, apostando por un sonido más potente y letras de mayor profundidad emocional y social. El disco mantiene la esencia oscura del debut, pero con una producción más sólida y composiciones más arriesgadas. Temas como “Antes de que nos olviden” y “La célula que explota” se convirtieron en himnos del rock en español, reflejando la identidad y la fuerza creativa del grupo.",
                Songs = new List<string> { "Detrás de ti", "Antes de que nos olviden", "La vida no es eterna", "De noche todos los gatos son pardos", "Sombras en tiempos perdidos", "El negro cósmico", "La célula que explota", "Los dioses ocultos", "El elefante", "Amárrate a una escoba y vuela lejos" }},

            new Album { Name = "El Silencio",
                Year = "1992",
                ImageUrl = "album_silencio.jpg",
                Description = "Considerado por muchos como su obra más lograda, El silencio representa una fusión más marcada entre el rock alternativo y elementos de la música mexicana. Con una producción más refinada y un enfoque sonoro más orgánico, el álbum destaca por su profundidad lírica y su intensidad emocional. Canciones como “No dejes que…” y “Nubes” muestran una madurez artística que consolidó a la banda como referente fundamental del rock latinoamericano.",
                Songs = new List<string>{"Metamorféame", "Nubes", "Piedra", "Tortuga", "Nos vamos juntos", "No dejes que...", "Hasta morir", "Debajo de tu piel", "Estás dormida", "Miércoles de ceniza", "El comunicador", "Vamos a hacer un silencio"}},

            new Album { Name = "El Nervio del Volcán",
                Year = "1994",
                ImageUrl = "album_nervio.jpg",
                Description = "El nervio del volcán es un álbum intenso y emocional que muestra a la banda en una etapa más introspectiva y poderosa. Con una producción más pulida y un tono más oscuro, las canciones exploran el dolor, la ruptura y la transformación personal. “Afuera” se convirtió en uno de sus mayores éxitos, mientras que otras piezas del disco reflejan la energía y la profundidad que caracterizaron esta etapa final antes de su separación en los años noventa.",
                Songs = new List<string> {"Afuera", "Miedo", "Aquí no es así", "Ayer me dijo un ave", "Hasta que dejes de respirar", "Aviéntame", "El animal", "Quisiera ser alcohol", "Pero nunca me caí", "El año del dragón", "La llorona"}},
        };

        AlbumsCollection.ItemsSource = albumes;
    }

    /// <summary>
    /// Manejador de evento que se dispara cuando el usuario selecciona un álbum de la lista.
    /// Navega a la página de detalles pasando el objeto seleccionado y limpia la selección.
    /// </summary>
    /// <param name="sender">El control que origina el evento (CollectionView).</param>
    /// <param name="e">Argumentos del evento que contienen la selección actual.</param>
    /// <author>Iker Javier Hernández Martínez</author>
    /// <date>17/02/2026</date>
    /// <version>1.0</version>
    /// <modification>17/02/2026</modification>
    private async void OnAlbumSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Album selectedAlbum)
        {
            // Navegamos a la página de detalle enviando el álbum seleccionado
            await Navigation.PushAsync(new DatailAlbumPage(selectedAlbum));

            // Quitamos la selección para que no se quede marcado al regresar
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}