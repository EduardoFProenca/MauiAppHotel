
namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;
        public ContratacaoHospedagem()
        {
            InitializeComponent();

            PropriedadesApp = (App)Application.Current;
            pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

            dtpk_check_in.MinimumDate = DateTime.Now;
            dtpk_check_in.MaximumDate= new DateTime(DateTime.Now.Year,DateTime.Now.Month +2 ,DateTime.Now.Day);
            dtpk_check_out.MinimumDate = dtpk_check_in.Date.AddDays(1);
            dtpk_check_out.MaximumDate = dtpk_check_in.Date.AddMonths(6);
    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContratada());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
    private void dtpk_check_in_DateSelected(object sender, EventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        

        DateTime Date_Selected_check_in = elemento.Date;

        dtpk_check_out.MinimumDate = Date_Selected_check_in.AddDays(1);
        dtpk_check_out.MaximumDate = Date_Selected_check_in.AddMonths(6);
    }

}
