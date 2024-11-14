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
  private async void OnSaveClicked(object sender, EventArgs e)
  {

    Models.Labor task = new();

    task.Title = TitleEntry.Text;
    task.Description = DescriptionEntry.Text;
    task.CategoryId = (string)CategoryPicker.SelectedItem;
    task.Priority = (string)PriorityPicker.SelectedItem;
    task.Date = DateEntry.Date.ToString(DateEntry.Format);
    task.Status = "Incompleto";


    MainPage mainPage = new();
    mainPage.Texto = task.ToString();
    await Navigation.PushAsync(mainPage);

    

    


  }

  private async void OnNewCategoryClicked(object sender, EventArgs e)
  {

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