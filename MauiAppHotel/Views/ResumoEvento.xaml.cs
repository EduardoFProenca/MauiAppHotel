using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class ResumoEvento : ContentPage
{
    private Evento evento;

   //
    private async void Button_NovoEvento_Clicked(object sender, EventArgs e)
    {
        try
        {
            // Volta para a tela de cadastro de evento
            await Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private async void Button_VoltarInicio_Clicked(object sender, EventArgs e)
    {
        try
        {
            // Volta para a página principal (MainPage)
            await Shell.Current.GoToAsync("//MainPage");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}