namespace MauiAppHotel
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(Views.HospedagemSobre), typeof(Views.HospedagemSobre));
            Routing.RegisterRoute(nameof(Views.ContratacaoHospedagem), typeof(Views.ContratacaoHospedagem));
        }


    }
}
