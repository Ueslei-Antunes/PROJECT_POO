namespace UI;

public partial class MainPage : ContentPage
{

	public string Texto
    {
        get => RegistedTask.Text;
        set => RegistedTask.Text = value; 
    }
	public MainPage()
	{
		InitializeComponent();

	}

    private async void Register_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Register());
		Navigation.RemovePage(this);
    }

	
}

