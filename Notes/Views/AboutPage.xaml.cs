namespace Notes.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

	private async void LearnMore_Clicked(object sender, EventArgs e)
	{
		if(BindingContext is Models.About about)
		{
            //Sistem taray�c�s�nda belirtilen URL'ye gidin.
            await Launcher.Default.OpenAsync("https://aka.ms/maui");
        }       
    }
}