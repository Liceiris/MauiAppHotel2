namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{

			Navigation.PopAsync();

		}catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
    }

  
    private void Button_Clicked_2(object sender, EventArgs e)
	{ 

         Navigation.PushAsync(new SobrePage());
    }
}
