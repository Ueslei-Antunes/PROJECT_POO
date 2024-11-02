namespace UI;

public partial class Register : ContentPage
{
  private List<string> opcoes = new();
  public Register()
  {
    InitializeComponent();

    opcoes.Add("Estudo");
    opcoes.Add("Rotinas");
    opcoes.Add("Prioritaria");
   
  
    CategoryPicker.ItemsSource = opcoes;
  }
  private async void Button_Clicked(object sender, EventArgs e){
	  await Navigation.PopAsync();
  }

   private async void OnNewCategoryClicked(object sender, EventArgs e){
      
    string category = await DisplayPromptAsync("Nova Categoria", "Digite o nome da nova categoria:");

     if (!string.IsNullOrWhiteSpace(category))
        {
            opcoes.Add(category);

            CategoryPicker.ItemsSource = null;
            CategoryPicker.ItemsSource = opcoes;
        }
        else
        {
            await DisplayAlert("Erro", "Por favor, digite uma categoria válida.", "OK");
        }
    }
}