using Parcial1_Caifanes.Models;

namespace Parcial1_Caifanes.Pages;

[QueryProperty(nameof(ConcertModel), "Concerts")]
public partial class DetailConcertsPage : ContentPage
{
	private ConcertModel _concertModel;
	public ConcertModel ConcertModel
	{
		get => _concertModel;
		set
		{
			_concertModel = value;
			OnPropertyChanged();
		}
    }
    public DetailConcertsPage()
	{
		InitializeComponent();
		_concertModel = new ConcertModel();
    }

	override protected void OnAppearing()
	{
		base.OnAppearing();
		if (ConcertModel != null)
		{
			imageConcert.Source = ConcertModel.ImageUrl;
			dateLabel.Text = ConcertModel.Date;
			nameLabel.Text = ConcertModel.Name;
			locationLabel.Text = ConcertModel.Location;
			statusLabel.Text = ConcertModel.status;
		}
    }

    private async void OnBuyTicketClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(TicketsPage));
    }
}