using Parcial1_Caifanes.Models;

namespace Parcial1_Caifanes.Pages;

public partial class ConcertsPage : ContentPage
{
    private List<ConcertModel> _concerts = [
new () { Date = "27 de febrero", Name = "Los Cabos, Baja California Sur", Location = "Explanada Madcons", status = "Available" },
    new () { Date = "28 de febrero", Name = "La Paz, Baja California Sur", Location = "Estadio Guaycura", status = "Available" },
    new () { Date = "07 de marzo", Name = "Villahermosa, Tabasco", Location = "Teatro Al Aire Libre", status = "Available" },
    new () { Date = "25 de marzo", Name = "Santa Cruz, California", Location = "The Catalyst", status = "Sold Out" },
    new () { Date = "27 de marzo", Name = "Ventura, California", Location = "Majestic Ventura Theater", status = "Sold Out" },
    new () { Date = "28 de marzo", Name = "Santa Ana, California", Location = "Santa Ana Stadium Festival Los Darks", status = "Available" },
    new () { Date = "18 de abril", Name = "Temoaya, Edomex", Location = "Centro Ceremonial Otomí", status = "Sold Out" },
    new () { Date = "24 de abril", Name = "Barcelona, España", Location = "Sala Luz de Gas", status = "Sold Out" },
    new () { Date = "26 de abril", Name = "Madrid, España", Location = "Sala But", status = "Sold Out" },
    new () { Date = "27 de abril", Name = "Madrid, España", Location = "Sala But", status = "Available" },
    new () { Date = "28 de abril", Name = "Londres, UK", Location = "Electric Ballroom", status = "Available" },
    new () { Date = "01 de mayo", Name = "New York, New York", Location = "Palladium Times Square", status = "Available" },
    new () { Date = "03 de mayo", Name = "Chicago, Illinois", Location = "The Riviera Theatre", status = "Available" },
    new () { Date = "07 de mayo", Name = "Nashville, Tennessee", Location = "Brooklyn Bowl", status = "Available" },
    new () { Date = "09 de mayo", Name = "Raleigh, North Carolina", Location = "The Ritz", status = "Available" },
    new () { Date = "10 de mayo", Name = "Charlotte, North Carolina", Location = "The Fillmore", status = "Available" },
    new () { Date = "15 de mayo", Name = "Toluca, Edomex", Location = "Teatro Morelos", status = "Available" },
    new () { Date = "16 de mayo", Name = "CDMX", Location = "Palacio de los Deportes Concierto 360°", status = "Available" },
    new () { Date = "22 de mayo", Name = "Pachuca, Hidalgo", Location = "Auditorio Explanada", status = "Available" },
    new () { Date = "23 de mayo", Name = "León, Guanajuato", Location = "Velaria de la Feria", status = "Available" },
    new () { Date = "29 de mayo", Name = "CDMX", Location = "Auditorio Nacional", status = "Sold Out" },
    new () { Date = "30 de mayo", Name = "CDMX", Location = "Auditorio Nacional", status = "Sold Out" },
    new () { Date = "04 de junio", Name = "El Paso, Texas", Location = "Plaza Theatre", status = "Available" },
    new () { Date = "06 de junio", Name = "Houston, Texas", Location = "Bayou Music Center", status = "Available" },
    new () { Date = "07 de junio", Name = "Irving, Texas", Location = "Toyota Music Factory", status = "Available" },
    new () { Date = "02 de septiembre", Name = "Tegucigalpa, Honduras", Location = "Coliseo Nacional", status = "Available" },
    new () { Date = "03 de septiembre", Name = "Guatemala, Guatemala", Location = "Fórum Majadas", status = "Coming Soon" },
    new () { Date = "05 de septiembre", Name = "San Salvador, El Salvador", Location = "Gimnasio Nacional", status = "Coming Soon" },
    new () { Date = "06 de septiembre", Name = "Heredia, Costa Rica", Location = "Parque Viva", status = "Coming Soon" },
    new () { Date = "08 de septiembre", Name = "Panamá, Panamá", Location = "Islas de Atlapa", status = "Coming Soon" },
    new () { Date = "11 de septiembre", Name = "Cali, Colombia", Location = "Arena Cañaveralejo", status = "Coming Soon" },
    new () { Date = "17 de septiembre", Name = "Manizales, Colombia", Location = "Plaza de Toros", status = "Coming Soon" },
    new () { Date = "19 de septiembre", Name = "Medellín, Colombia", Location = "Plaza de Toros La Macarena", status = "Coming Soon" },
    new () { Date = "23 de septiembre", Name = "Buenos Aires, Argentina", Location = "Teatro Vorterix", status = "Available" },
    new () { Date = "24 de septiembre", Name = "Santiago, Chile", Location = "Teatro Caupolicán", status = "Coming Soon" },
    new () { Date = "26 de septiembre", Name = "Lima, Perú", Location = "Costa 21 Duomo", status = "Coming Soon" },
    new () { Date = "02 de octubre", Name = "Chihuahua, Chihuahua", Location = "Gimnasio Bernardo Aguirre", status = "Coming Soon" },
    new () { Date = "03 de octubre", Name = "Cd. Juárez, Chihuahua", Location = "Gimnasio Universitario", status = "Coming Soon" },
    new () { Date = "08 de octubre", Name = "San Luis Potosí, SLP", Location = "Parque Tangamanga II", status = "Available" },
    new () { Date = "23 de octubre", Name = "Mexicali, Baja California", Location = "Por confirmar", status = "Coming Soon" }
    ];

    private List<ConcertModel> _filteredConcerts;
    public ConcertsPage()
    {
        InitializeComponent();
        _filteredConcerts = [.. _concerts];
        concertList.ItemsSource = _filteredConcerts;
    }

    private async void OnConcertSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem is ConcertModel selectedConcert)
        {
            await Shell.Current.GoToAsync(nameof(DetailConcertsPage), new Dictionary<string, object>
            {
                { "Concerts", selectedConcert }
            });

            concertList.SelectedItem = null;
        }
    }
}