using Parcial1_Caifanes.Models;
namespace Parcial1_Caifanes.Pages;

public partial class DatailAlbumPage : ContentPage
{
	public DatailAlbumPage(Album album)
	{
		InitializeComponent();
		BindingContext = album;
	}
}