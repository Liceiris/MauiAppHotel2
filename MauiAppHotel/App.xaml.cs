using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {

           new Quarto()
           {
            Descricao = "Suíte super Luxo",
            ValorDiariaAdulto = 110.0,
            ValorDiariaCrianca = 55.0
            }, 
            
            new Quarto()
            {
             Descricao = "Suíte Luxo",
             ValorDiariaAdulto = 90.0,
             ValorDiariaCrianca = 45.0
            },

            new Quarto()
            {
             Descricao = "Suíte Simples",
             ValorDiariaAdulto = 70.0,
             ValorDiariaCrianca = 35.0
            },

            new Quarto()
            {
             Descricao = "Suíte Econômica",
             ValorDiariaAdulto = 50.0,
             ValorDiariaCrianca = 25.0
            },
        };

        
           
    public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MauiAppHotel.Views.ContratacaoDaHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 700;

            return window;
        }
    }
}