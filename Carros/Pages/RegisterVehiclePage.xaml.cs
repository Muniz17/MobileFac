using System.Linq.Expressions;

namespace Carros.Pages;

public partial class RegisterVehiclePage : ContentPage
{
	public RegisterVehiclePage()
	{
		InitializeComponent();
	}
	private async void OnSelecionarFotoClicked(object sender, EventArgs e)
    {
		try
		{
			var result = await MediaPicker.PickPhotoAsync();
			if (result != null)
			{
                var stream = await result.OpenReadAsync();
                imagemDoVeiculo.Source = ImageSource.FromStream(() => stream);
			}
		}catch (Exception ex)
		
			{ 
				Console.WriteLine($"Erro ao selecionar foto: {ex.Message}"); 
			}

        }
    }
