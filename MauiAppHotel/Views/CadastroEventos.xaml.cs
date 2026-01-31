using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class CadastroEvento : ContentPage
{
    private Evento evento;

    public CadastroEvento()
    {
        InitializeComponent();

        // Inicializa o evento e configura o BindingContext
        evento = new Evento();
        BindingContext = evento;

        // Configura as datas mínimas e máximas
        ConfigurarDatas();
    }

    private void ConfigurarDatas()
    {
        // Data de início não pode ser anterior a hoje
        dtpk_data_inicio.MinimumDate = DateTime.Now;
        dtpk_data_inicio.MaximumDate = DateTime.Now.AddYears(2);

        // Data de término deve ser pelo menos 1 dia após a data de início
        dtpk_data_termino.MinimumDate = dtpk_data_inicio.Date.AddDays(1);
        dtpk_data_termino.MaximumDate = dtpk_data_inicio.Date.AddYears(1);
    }

    private void dtpk_data_inicio_DateSelected(object sender, EventArgs e)
    {
        DatePicker elemento = sender as DatePicker;
        DateTime dataSelecionada = elemento.Date;

        // Atualiza as restrições da data de término
        dtpk_data_termino.MinimumDate = dataSelecionada.AddDays(1);
        dtpk_data_termino.MaximumDate = dataSelecionada.AddYears(1);

        // Se a data de término for anterior à nova data mínima, ajusta
        if (dtpk_data_termino.Date <= dataSelecionada)
        {
            dtpk_data_termino.Date = dataSelecionada.AddDays(1);
        }
    }

    private async void Button_CadastrarEvento_Clicked(object sender, EventArgs e)
    {
        try
        {            

            // Navegar para a tela de resumo passando o evento
           // await Navigation.PushAsync(new ResumoEvento(evento)); 
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}