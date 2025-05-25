namespace MauiAppHotel
{
    public partial class MainPage : ContentPage
    {
       public MainPage()
        {
            InitializeComponent();
        }

        private async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            try
            {
                await Shell.Current.GoToAsync(nameof(Views.HospedagemSobre));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
       
        }

        private async void OnContratacaoHospedagemClicked(object sender, EventArgs e)
        {
            try
            {
                await Shell.Current.GoToAsync(nameof(Views.ContratacaoHospedagem));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }

           // await Shell.Current.GoToAsync(nameof(Views.ContratacaoHospedagem));
        }
    }
}
