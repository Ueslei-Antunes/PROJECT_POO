namespace UI;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}