namespace Carros.Pages;
using Carros.PagesVehicles;
public partial class SeachPage : ContentPage
{
	public SeachPage()
	{
		InitializeComponent();
	}
	private async void OnButtonClicked(object sender, EventArgs e)
    {
        Button clickedButton = sender as Button;

		if (clickedButton == btnPageChevrolet){
        await Navigation.PushAsync(new Carros.PagesVehicles.Chevrolet());
		}

        if (clickedButton == btnFord)
        {
            await Navigation.PushAsync(new Carros.PagesVehicles.Ford());
        }
        if (clickedButton == btnHonda)
        {
            await Navigation.PushAsync(new Carros.PagesVehicles.Honda());
        }
        if (clickedButton == btnHyundai)
        {
            await Navigation.PushAsync(new Carros.PagesVehicles.Hyundai());
        }
        if (clickedButton == btnPageCitroen)
        {
            await Navigation.PushAsync(new Carros.PagesVehicles.citroen());
        }
        if (clickedButton == btnPageNissan)
        {
            await Navigation.PushAsync(new Carros.PagesVehicles.Nissan());
        }
        if (clickedButton == btnFiat)
        {
            await Navigation.PushAsync(new Carros.PagesVehicles.Fiat());
        }
        if (clickedButton == btnHyundai)
        {
            await Navigation.PushAsync(new Carros.PagesVehicles.Hyundai());
        }
        if (clickedButton == btnAllVehicles)
        {
            await Navigation.PushAsync(new Carros.PagesVehicles.allVehicles());
        }

    }
}