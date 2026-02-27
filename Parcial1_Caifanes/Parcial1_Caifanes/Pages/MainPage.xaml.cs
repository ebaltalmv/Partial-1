namespace Parcial1_Caifanes.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnToggledChancged(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                Shell.Current.Resources["BackgroundPage1"] = Color.FromArgb("#F5F5F5");
                Shell.Current.Resources["BackgroundPage2"] = Color.FromArgb("#D1C4E9");
                Shell.Current.Resources["BackgroundPage3"] = Color.FromArgb("#FFCDD2");
                Shell.Current.Resources["StatustTextPrimary"] = Colors.Red;
                Shell.Current.Resources["BackgroundColorSwitch"] = Colors.Black;
                Shell.Current.Resources["BoxView"] = Colors.Black;
                return;
            }

            Shell.Current.Resources["BackgroundPage1"] = Color.FromArgb("#0A0A0A");
            Shell.Current.Resources["BackgroundPage2"] = Color.FromArgb("#4B0082");
            Shell.Current.Resources["BackgroundPage3"] = Color.FromArgb("#8B0000");
            Shell.Current.Resources["StatustTextPrimary"] = Colors.Green;
            Shell.Current.Resources["BackgroundColorSwitch"] = Colors.White;
            Shell.Current.Resources["BoxView"] = Colors.LightGrey;
            return;
        }
    }
}
