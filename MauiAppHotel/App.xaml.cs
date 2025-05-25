using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>()
        {

            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto  = 180.0,
                ValorDiariaCrianca = 120.0
            },
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto  = 150.0,
                ValorDiariaCrianca = 100.0
            },
            new Quarto()
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto  = 120.0,
                ValorDiariaCrianca = 75.0
            },
             new Quarto()
            {
                Descricao = "Suíte Crise",
                ValorDiariaAdulto  = 90.0,
                ValorDiariaCrianca = 50.0
            }
        };
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new AppShell());
            window.Width = 400;
            window.Height = 600;
            return window;
        }
    }
}