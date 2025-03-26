using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;


namespace Carros.Pages;

public partial class Home : ContentPage
{
	public ObservableCollection<Manufacturer> Manufacturers { get; set; }
	public Home()
	{
		InitializeComponent();

		Manufacturers = new ObservableCollection<Manufacturer>
		{
			new Manufacturer
			{
				Name = "Volkswalgem",
				ImageUrl = "volkswagen.png",
				Description = "Volkswagen � uma empresa alem� que pertence ao Grupo Volkswagen, uma das maiores fabricantes de autom�veis do mundo."
			},
			new Manufacturer
			{
				Name = "Toyota",
				ImageUrl = "toyota.png",
				Description = "Toyota Motor Corporation � uma empresa multinacional japonesa. Em 2017, a Toyota foi listada como a 5� maior empresa do mundo pela /nFortune Global 500 e a maior fabricante de autom�veis do mundo."
			},
			new Manufacturer
			{
				Name = "BMW",
				ImageUrl = "bmw.png",
				Description = "BMW � uma empresa alem� que fabrica autom�veis e motocicletas. A empresa foi fundada em 1916 e � propriet�ria das marcas Mini e /nRolls-Royce."
			},

			new Manufacturer
			{
				Name = "Mercedes",
				ImageUrl = "mercedes.png",
				Description = "Mercedes-Benz � uma marca alem� de autom�veis de luxo e ve�culos comerciais. A empresa � uma divis�o da Daimler AG."
			}



		};
	

        CarouselView.ItemsSource = Manufacturers;
		}
	
}
	public class Manufacturer
    {
        public required string Name{get;set;}
        public required string ImageUrl{get;set;}

		public required string Description{get;set;}

    }



