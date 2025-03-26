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
				Description = "Volkswagen é uma empresa alemã que pertence ao Grupo Volkswagen, uma das maiores fabricantes de automóveis do mundo."
			},
			new Manufacturer
			{
				Name = "Toyota",
				ImageUrl = "toyota.png",
				Description = "Toyota Motor Corporation é uma empresa multinacional japonesa. Em 2017, a Toyota foi listada como a 5ª maior empresa do mundo pela /nFortune Global 500 e a maior fabricante de automóveis do mundo."
			},
			new Manufacturer
			{
				Name = "BMW",
				ImageUrl = "bmw.png",
				Description = "BMW é uma empresa alemã que fabrica automóveis e motocicletas. A empresa foi fundada em 1916 e é proprietária das marcas Mini e /nRolls-Royce."
			},

			new Manufacturer
			{
				Name = "Mercedes",
				ImageUrl = "mercedes.png",
				Description = "Mercedes-Benz é uma marca alemã de automóveis de luxo e veículos comerciais. A empresa é uma divisão da Daimler AG."
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



