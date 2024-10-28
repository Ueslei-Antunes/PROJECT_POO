namespace UI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

  
    private async void Register_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Register());
    }

}

